using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CoFAS_MES.UI.MM.Data;
using CoFAS_MES.UI.MM.Entity;

using CoFAS_MES.CORE.Entity;
using CoFAS_MES.CORE.Function;
using System.Data;

namespace CoFAS_MES.UI.MM.Business
{
    public class MaterialOrderRegisterBusiness
    {
        public DataTable MaterialOrderRegister_R10(MaterialOrderRegisterEntity pMaterialOrderRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialOrderRegisterProvider(pDBManager).MaterialOrderRegister_R10(pMaterialOrderRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialOrderRegister_R10(MaterialOrderRegisterEntity pMaterialOrderRegisterEntity)", pException);
            }
        }

        public DataTable MaterialOrderRegister_R20(MaterialOrderRegisterEntity pMaterialOrderRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialOrderRegisterProvider(pDBManager).MaterialOrderRegister_R20(pMaterialOrderRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialOrderRegister_R20(MaterialOrderRegisterEntity pMaterialOrderRegisterEntity)", pException);
            }
        }

        #region ○ 화면명에 맞는 엑셀파일 불러오기
        public DataTable Sheet_Info_Sheet(MaterialOrderRegisterEntity pMaterialOrderRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialOrderRegisterProvider(pDBManager).Sheet_Info_sheet(pMaterialOrderRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sheet_Info_Sheet(MaterialOrderRegisterEntity pMaterialOrderRegisterEntity)", pException);
            }
        }

        #endregion

        #region 바인딩 데이터 테이블 불러오기 - Sheet_Info_Sheet_Data(SheetInfoRegisterEntity pSheetInfoRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sheet_Info_Sheet_Data(MaterialOrderRegisterEntity pMaterialOrderRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialOrderRegisterProvider(pDBManager).Sheet_Info_Sheet_Data(pMaterialOrderRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sheet_Info_Sheet_Data(MaterialOrderRegisterEntity _pMaterialOrderRegisterEntity)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Filename(MaterialOrderRegisterEntity pSampleRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialOrderRegisterProvider(pDBManager).Sample_Info_Filename(pSampleRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)", pException);
            }
        }

        #endregion

        #region XML파일 다운로드 - MenuRegister_Templete_Download(MenuRegisterEntity pMenuRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public object Templete_Download(MaterialOrderRegisterEntity pSampleRegisterEntity, string pMENU_NO, string pDSP_SORT)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    object pObject = new MaterialOrderRegisterProvider(pDBManager).Templete_Download(pSampleRegisterEntity, pMENU_NO, pDSP_SORT);
                    return pObject;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MenuRegister_Templete_Download(pMENU_NO, pDSP_SORT, pCUR_FILE)", pException);
            }
        }

        #endregion

        #region 발주 정보 저장 -MaterialOrder_Info_Save(UserInformationEntity pUserInformationEntity)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool MaterialOrderRegister_Info_Save(MaterialOrderRegisterEntity pUserInformationEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new MaterialOrderRegisterProvider(pDBManager).MaterialOrderRegister_Info_Save(pUserInformationEntity);
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
    }

    public class MaterialOrderRegister_T02Business
    {
        public DataTable MaterialOrderRegister_T02_R10(MaterialOrderRegister_T02Entity pMaterialOrderRegister_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialOrderRegister_T02Provider(pDBManager).MaterialOrderRegister_T02_R10(pMaterialOrderRegister_T02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialOrderRegister_T02_R10(MaterialOrderRegister_T02Entity pMaterialOrderRegister_T02Entity)", pException);
            }
        }

        public DataTable MaterialOrderRegister_T02_R20(MaterialOrderRegister_T02Entity pMaterialOrderRegister_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialOrderRegister_T02Provider(pDBManager).MaterialOrderRegister_T02_R20(pMaterialOrderRegister_T02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialOrderRegister_T02_R20(MaterialOrderRegister_T02Entity pMaterialOrderRegister_T02Entity)", pException);
            }
        }

        #region ○ 화면명에 맞는 엑셀파일 불러오기
        public DataTable Sheet_Info_Sheet(MaterialOrderRegister_T02Entity pMaterialOrderRegister_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialOrderRegister_T02Provider(pDBManager).Sheet_Info_sheet(pMaterialOrderRegister_T02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sheet_Info_Sheet(MaterialOrderRegister_T02Entity pMaterialOrderRegister_T02Entity)", pException);
            }
        }

        #endregion

        #region 바인딩 데이터 테이블 불러오기 - Sheet_Info_Sheet_Data(SheetInfoRegisterEntity pSheetInfoRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sheet_Info_Sheet_Data(MaterialOrderRegister_T02Entity pMaterialOrderRegister_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialOrderRegister_T02Provider(pDBManager).Sheet_Info_Sheet_Data(pMaterialOrderRegister_T02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sheet_Info_Sheet_Data(MaterialOrderRegister_T02Entity _pMaterialOrderRegister_T02Entity)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Filename(MaterialOrderRegister_T02Entity pSampleRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialOrderRegister_T02Provider(pDBManager).Sample_Info_Filename(pSampleRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)", pException);
            }
        }

        #endregion

        #region XML파일 다운로드 - MenuRegister_Templete_Download(MenuRegisterEntity pMenuRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public object Templete_Download(MaterialOrderRegister_T02Entity pSampleRegisterEntity, string pMENU_NO, string pDSP_SORT)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    object pObject = new MaterialOrderRegister_T02Provider(pDBManager).Templete_Download(pSampleRegisterEntity, pMENU_NO, pDSP_SORT);
                    return pObject;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MenuRegister_Templete_Download(pMENU_NO, pDSP_SORT, pCUR_FILE)", pException);
            }
        }

        #endregion

        #region 발주 정보 저장 -MaterialOrder_Info_Save(UserInformationEntity pUserInformationEntity)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool MaterialOrderRegister_T02_Info_Save(MaterialOrderRegister_T02Entity pUserInformationEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new MaterialOrderRegister_T02Provider(pDBManager).MaterialOrderRegister_T02_Info_Save(pUserInformationEntity);
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
    }
    public class MaterialOrderRegister_T03Business
    {
        public DataTable MaterialOrderRegister_T03_R30(MaterialOrderRegister_T03Entity pMaterialOrderRegister_T03Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialOrderRegister_T03Provider(pDBManager).MaterialOrderRegister_T03_R30(pMaterialOrderRegister_T03Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialOrderRegister_T03_R10(MaterialOrderRegister_T03Entity pMaterialOrderRegister_T03Entity)", pException);
            }
        }

        public DataTable MaterialOrderRegister_T03_R40(MaterialOrderRegister_T03Entity pMaterialOrderRegister_T03Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialOrderRegister_T03Provider(pDBManager).MaterialOrderRegister_T03_R40(pMaterialOrderRegister_T03Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialOrderRegister_T03_R20(MaterialOrderRegister_T03Entity pMaterialOrderRegister_T03Entity)", pException);
            }
        }

        #region ○ 화면명에 맞는 엑셀파일 불러오기
        public DataTable Sheet_Info_Sheet(MaterialOrderRegister_T03Entity pMaterialOrderRegister_T03Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialOrderRegister_T03Provider(pDBManager).Sheet_Info_sheet(pMaterialOrderRegister_T03Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sheet_Info_Sheet(MaterialOrderRegister_T03Entity pMaterialOrderRegister_T03Entity)", pException);
            }
        }

        #endregion

        #region 바인딩 데이터 테이블 불러오기 - Sheet_Info_Sheet_Data(SheetInfoRegisterEntity pSheetInfoRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sheet_Info_Sheet_Data(MaterialOrderRegister_T03Entity pMaterialOrderRegister_T03Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialOrderRegister_T03Provider(pDBManager).Sheet_Info_Sheet_Data(pMaterialOrderRegister_T03Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sheet_Info_Sheet_Data(MaterialOrderRegister_T03Entity _pMaterialOrderRegister_T03Entity)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Filename(MaterialOrderRegister_T03Entity pSampleRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialOrderRegister_T03Provider(pDBManager).Sample_Info_Filename(pSampleRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)", pException);
            }
        }

        #endregion

        #region XML파일 다운로드 - MenuRegister_Templete_Download(MenuRegisterEntity pMenuRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public object Templete_Download(MaterialOrderRegister_T03Entity pSampleRegisterEntity, string pMENU_NO, string pDSP_SORT)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    object pObject = new MaterialOrderRegister_T03Provider(pDBManager).Templete_Download(pSampleRegisterEntity, pMENU_NO, pDSP_SORT);
                    return pObject;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MenuRegister_Templete_Download(pMENU_NO, pDSP_SORT, pCUR_FILE)", pException);
            }
        }

        #endregion

        #region 발주 정보 저장 -MaterialOrder_Info_Save(UserInformationEntity pUserInformationEntity)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool MaterialOrderRegister_T03_Info_Save(MaterialOrderRegister_T03Entity pUserInformationEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new MaterialOrderRegister_T03Provider(pDBManager).MaterialOrderRegister_T03_Info_Save(pUserInformationEntity);
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
    }
    public class MaterialOrderRegister_ReportBusiness
    {

        #region ○ 화면명에 맞는 엑셀파일 불러오기
        public DataTable Sheet_Info_Sheet(MaterialOrderRegister_ReportEntity pMaterialOrderRegister_ReportEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pdatatable = new MaterialOrderRegister_ReportProvider(pDBManager).Sheet_Info_sheet(pMaterialOrderRegister_ReportEntity);
                    return pdatatable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sheet_Info_Sheet(ProcessMaterialStockStatusEntity _pProcessMaterialStockStatusEntity)", pException);
            }
        }

        #endregion


        #region 마스터 정보 조회 - Sample_Info(MaterialOrderRegister_ReportEntity pMaterialOrderRegister_ReportEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(MaterialOrderRegister_ReportEntity pMaterialOrderRegister_ReportEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialOrderRegister_ReportProvider(pDBManager).Sample_Info_Mst(pMaterialOrderRegister_ReportEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(MaterialOrderRegister_ReportEntity pMaterialOrderRegister_ReportEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(MaterialOrderStatusEntity pMaterialOrderStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(MaterialOrderRegister_ReportEntity pMaterialOrderRegister_ReportEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialOrderRegister_ReportProvider(pDBManager).Sample_Info_Mst(pMaterialOrderRegister_ReportEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(MaterialOrderRegister_ReportEntity pMaterialOrderRegister_ReportEntity)", pException);
            }
        }

        #endregion

        #region 검사의뢰 마스터 정보 저장 - Sample_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>

        #endregion
        #region 검사의뢰 검사결과 정보 저장 - Sample_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>

        #endregion
        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public MaterialOrderRegister_ReportEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                MaterialOrderRegister_ReportEntity pMaterialOrderRegister_ReportEntity = new MaterialOrderRegister_ReportProvider(null).GetEntity(pDataRow);
                return pMaterialOrderRegister_ReportEntity;
            }
            catch (Exception pException)
            {
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

    public class MaterialOrderRegister_RequestBusiness
    {
        public DataTable MaterialOrderRegister_RequestBusiness_R10(MaterialOrderRegisterEntity_Request pMaterialOrderRegisterEntity_Request)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialOrderRegister_RequestProvider(pDBManager).MaterialOrderRegister_Request_R10(pMaterialOrderRegisterEntity_Request);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialOrderRegister_Request_R10(MaterialOrderRegisterEntity_Request1 pMaterialOrderRegisterEntity_Request)", pException);
            }
        }

        public DataTable MaterialOrderRegister_Request_R20(MaterialOrderRegisterEntity_Request pMaterialOrderRegisterEntity_Request)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialOrderRegister_RequestProvider(pDBManager).MaterialOrderRegister_Request_R20(pMaterialOrderRegisterEntity_Request);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialOrderRegister_Request_R20(MaterialOrderRegisterEntity_Request pMaterialOrderRegisterEntity_Request)", pException);
            }
        }

        #region ○ 화면명에 맞는 엑셀파일 불러오기
        public DataTable Sheet_Info_Sheet(MaterialOrderRegisterEntity_Request pMaterialOrderRegisterEntity_Request)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialOrderRegister_RequestProvider(pDBManager).Sheet_Info_sheet(pMaterialOrderRegisterEntity_Request);
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

        #region 바인딩 데이터 테이블 불러오기 - Sheet_Info_Sheet_Data(MaterialOrderRegisterEntity_Request pMaterialOrderRegisterEntity_Request)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataSet Sheet_Info_Sheet_Data(MaterialOrderRegisterEntity_Request pMaterialOrderRegisterEntity_Request)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataSet psDataTable = new MaterialOrderRegister_RequestProvider(pDBManager).Sheet_Info_Sheet_Data(pMaterialOrderRegisterEntity_Request);
                    return psDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sheet_Info_Sheet_Data(MaterialOrderRegisterEntity_Request pMaterialOrderRegisterEntity_Request)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Filename(MaterialOrderRegisterEntity_Request pMaterialOrderRegisterEntity_RequestEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialOrderRegister_RequestProvider(pDBManager).Sample_Info_Filename(pMaterialOrderRegisterEntity_RequestEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Filename(MaterialOrderRegisterEntity_Request pMaterialOrderRegisterEntity_RequestEntity)", pException);
            }
        }

        #endregion

        #region XML파일 다운로드 - MenuRegister_Templete_Download(MenuRegisterEntity pMenuRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public object Templete_Download(MaterialOrderRegisterEntity_Request pMaterialOrderRegisterEntity_RequestEntity, string pMENU_NO, string pDSP_SORT)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    object pObject = new MaterialOrderRegister_RequestProvider(pDBManager).Templete_Download(pMaterialOrderRegisterEntity_RequestEntity, pMENU_NO, pDSP_SORT);
                    return pObject;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Templete_Download(MaterialOrderRegisterEntity_Request pMaterialOrderRegisterEntity_RequestEntity, string pMENU_NO, string pDSP_SORT)", pException);
            }
        }

        #endregion

        #region 시험발주 정보 저장 -MaterialOrderRegister_Request_Info_Save(MaterialOrderRegisterEntity_Request pMaterialOrderRegisterEntity_RequestEntity)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool MaterialOrderRegister_Request_Info_Save(MaterialOrderRegisterEntity_Request pMaterialOrderRegisterEntity_RequestEntity)

        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new MaterialOrderRegister_RequestProvider(pDBManager).MaterialOrderRegister_Request_Info_Save(pMaterialOrderRegisterEntity_RequestEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialOrderRegister_Request_Info_Save(MaterialOrderRegisterEntity_Request pMaterialOrderRegisterEntity_RequestEntity)", pException);
            }
        }

        #endregion

        #region 시험검사 정보 저장 -MaterialOrder_Request_Info_Save(UserInformationEntity pUserInformationEntity)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool MaterialOrderRegister_Request_Info_Check_Save(MaterialOrderRegisterEntity_Request pMaterialOrderRegisterEntity_RequestEntity, DataTable dt)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new MaterialOrderRegister_RequestProvider(pDBManager).MaterialOrderRegister_Request_Info_Check_Save(pMaterialOrderRegisterEntity_RequestEntity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialOrderRegister_Request_Info_Check_Save(MaterialOrderRegisterEntity_Request pMaterialOrderRegisterEntity_RequestEntity, DataTable dt)", pException);
            }
        }

        #endregion
    }

    public class MaterialOrderRegister_Request_T01Business
    {
        #region 메인조회
        public DataTable MaterialOrderRegister_Request_T01_R10(MaterialOrderRegisterEntity_Request_T01 pMaterialOrderRegisterEntity_Request_T01)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialOrderRegister_Request_T01Provider(pDBManager).MaterialOrderRegister_Request_T01_R10(pMaterialOrderRegisterEntity_Request_T01);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialOrderRegister_Request_T01_R10(MaterialOrderRegisterEntity_Request_T01 pMaterialOrderRegisterEntity_Request_T01)", pException);
            }
        }
        #endregion


        #region 서브 조회
        public DataTable MaterialOrderRegister_Request_T01_R20(MaterialOrderRegisterEntity_Request_T01 pMaterialOrderRegisterEntity_Request_T01)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialOrderRegister_Request_T01Provider(pDBManager).MaterialOrderRegister_Request_T01_R20(pMaterialOrderRegisterEntity_Request_T01);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialOrderRegister_Request_T01_R20(MaterialOrderRegisterEntity_Request_T01 pMaterialOrderRegisterEntity_Request_T01)", pException);
            }
        }
        #endregion


        #region 그리드 정보 저장 - MaterialOrderRegisterEntity_Request_T01_Save(MaterialOrderRegisterEntity_Request_T01 pMaterialOrderRegisterEntity_Request_T01)
        public bool MaterialOrderRegisterEntity_Request_T01_Save(MaterialOrderRegisterEntity_Request_T01 pMaterialOrderRegisterEntity_Request_T01, DataTable dt)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new MaterialOrderRegister_Request_T01Provider(pDBManager).MaterialOrderRegister_Request_T01_Info_Save(pMaterialOrderRegisterEntity_Request_T01, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialOrderRegisterEntity_Request_T01_Save(MaterialOrderRegisterEntity_Request_T01 pMaterialOrderRegisterEntity_Request_T01, DataTable dt)", pException);
            }
        }
        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public MaterialOrderRegisterEntity_Request_T01 GetEntity(DataRow pDataRow)
        {
            try
            {
                MaterialOrderRegisterEntity_Request_T01 pMaterialOrderRegisterEntity_Request_T01 = new MaterialOrderRegister_Request_T01Provider(null).GetEntity(pDataRow);
                return pMaterialOrderRegisterEntity_Request_T01;
            }
            catch (Exception pException)
            {
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

    public class ucMaterialOrderRegister_Request_T01Business
    {
        #region 메인조회
        public DataTable ucMaterialOrderRegister_Request_T01_R10(ucMaterialOrderRegister_Request_T01Entity pucMaterialOrderRegister_Request_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucMaterialOrderRegister_Request_T01Provider(pDBManager).pucMaterialOrderRegister_Request_T01_R10(pucMaterialOrderRegister_Request_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucMaterialOrderRegister_Request_T01_R10(ucMaterialOrderRegister_Request_T01Entity pucMaterialOrderRegister_Request_T01Entity)", pException);
            }
        }
        #endregion

        #region 서브 조회
        public DataTable ucMaterialOrderRegister_Request_T01_R20(ucMaterialOrderRegister_Request_T01Entity pucMaterialOrderRegister_Request_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucMaterialOrderRegister_Request_T01Provider(pDBManager).pucMaterialOrderRegister_Request_T01_R20(pucMaterialOrderRegister_Request_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucMaterialOrderRegister_Request_T01_R20(ucMaterialOrderRegister_Request_T01Entity pucMaterialOrderRegister_Request_T01Entity)", pException);
            }
        }
        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public MaterialOrderRegisterEntity_Request_T01 GetEntity(DataRow pDataRow)
        {
            try
            {
                MaterialOrderRegisterEntity_Request_T01 pMaterialOrderRegisterEntity_Request_T01 = new MaterialOrderRegister_Request_T01Provider(null).GetEntity(pDataRow);
                return pMaterialOrderRegisterEntity_Request_T01;
            }
            catch (Exception pException)
            {
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


    #region o 자재발주현황
    public class MaterialOrderStatusBusiness
    {
        #region 마스터 정보 조회 - MaterialOrderStatus(MaterialOrderStatusEntity pMaterialOrderStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable MaterialOrderStatus_Info_Filename(MaterialOrderStatusEntity pMaterialOrderStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialOrderStatusProvider(pDBManager).MaterialOrderStatus_Info_Filename(pMaterialOrderStatusEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialOrderStatus_Info_Filename(MaterialOrderStatusEntity pMaterialOrderStatusEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(MaterialOrderStatusEntity pMaterialOrderStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(MaterialOrderStatusEntity pMaterialOrderStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialOrderStatusProvider(pDBManager).Sample_Info_Mst(pMaterialOrderStatusEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(MaterialOrderStatusEntity pMaterialOrderStatusEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)
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
                    bool isReturn = new MaterialOrderStatusProvider(pDBManager).Sample_Info_Save(pMaterialOrderStatusEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region XML파일 다운로드 - Templete_Download(MaterialOrderStatusEntity pMaterialOrderStatusEntity, string pMENU_NO, string pDSP_SORT)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public object Templete_Download(MaterialOrderStatusEntity pMaterialOrderStatusEntity, string pMENU_NO, string pDSP_SORT)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    object pObject = new MaterialOrderStatusProvider(pDBManager).Templete_Download(pMaterialOrderStatusEntity, pMENU_NO, pDSP_SORT);
                    return pObject;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialOrderStatusProvider(pDBManager).Templete_Download(pMaterialOrderStatusEntity, pMENU_NO, pDSP_SORT)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public MaterialOrderStatusEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                MaterialOrderStatusEntity pSampleRegisterEntity = new MaterialOrderStatusProvider(null).GetEntity(pDataRow);
                return pSampleRegisterEntity;
            }
            catch (Exception pException)
            {
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
    #endregion

    #region o 자재유통기한현황
    public class MaterialExpirationDateStatusBusiness
    {
        #region 마스터 정보 조회 - MaterialExpirationDateStatus(MaterialExpirationDateStatusEntity pMaterialExpirationDateStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable MaterialExpirationDateStatus_Info_Filename(MaterialExpirationDateStatusEntity pMaterialExpirationDateStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialExpirationDateStatusProvider(pDBManager).MaterialExpirationDateStatus_Info_Filename(pMaterialExpirationDateStatusEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialExpirationDateStatus_Info_Filename(MaterialExpirationDateStatusEntity pMaterialExpirationDateStatusEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(MaterialExpirationDateStatusEntity pMaterialExpirationDateStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(MaterialExpirationDateStatusEntity pMaterialExpirationDateStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialExpirationDateStatusProvider(pDBManager).Sample_Info_Mst(pMaterialExpirationDateStatusEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(MaterialExpirationDateStatusEntity pMaterialExpirationDateStatusEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(MaterialExpirationDateStatusEntity pMaterialExpirationDateStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(MaterialExpirationDateStatusEntity pMaterialExpirationDateStatusEntity, DataTable dt)
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
                    bool isReturn = new MaterialExpirationDateStatusProvider(pDBManager).Sample_Info_Save(pMaterialExpirationDateStatusEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(MaterialExpirationDateStatusEntity pMaterialExpirationDateStatusEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region XML파일 다운로드 - Templete_Download(MaterialExpirationDateStatusEntity pMaterialExpirationDateStatusEntity, string pMENU_NO, string pDSP_SORT)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public object Templete_Download(MaterialExpirationDateStatusEntity pMaterialExpirationDateStatusEntity, string pMENU_NO, string pDSP_SORT)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    object pObject = new MaterialExpirationDateStatusProvider(pDBManager).Templete_Download(pMaterialExpirationDateStatusEntity, pMENU_NO, pDSP_SORT);
                    return pObject;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialExpirationDateStatusProvider(pDBManager).Templete_Download(pMaterialExpirationDateStatusEntity, pMENU_NO, pDSP_SORT)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public MaterialExpirationDateStatusEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                MaterialExpirationDateStatusEntity pSampleRegisterEntity = new MaterialExpirationDateStatusProvider(null).GetEntity(pDataRow);
                return pSampleRegisterEntity;
            }
            catch (Exception pException)
            {
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
    #endregion

    #region o 자재발주현황
    public class MaterialOrderStatus_T02Business
    {
        #region 마스터 정보 조회 - MaterialOrderStatus(MaterialOrderStatusEntity pMaterialOrderStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable MaterialOrderStatus_Info_Filename(MaterialOrderStatusEntity pMaterialOrderStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialOrderStatusProvider(pDBManager).Sample_Info_Mst(pMaterialOrderStatusEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialOrderStatus_Info_Filename(MaterialOrderStatusEntity pMaterialOrderStatusEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(MaterialOrderStatusEntity pMaterialOrderStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(MaterialOrderStatusEntity pMaterialOrderStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialOrderStatusProvider(pDBManager).Sample_Info_Mst(pMaterialOrderStatusEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(MaterialOrderStatusEntity pMaterialOrderStatusEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)
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
                    bool isReturn = new MaterialOrderStatusProvider(pDBManager).Sample_Info_Save(pMaterialOrderStatusEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region XML파일 다운로드 - Templete_Download(MaterialOrderStatusEntity pMaterialOrderStatusEntity, string pMENU_NO, string pDSP_SORT)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public object Templete_Download(MaterialOrderStatusEntity pMaterialOrderStatusEntity, string pMENU_NO, string pDSP_SORT)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    object pObject = new MaterialOrderStatusProvider(pDBManager).Templete_Download(pMaterialOrderStatusEntity, pMENU_NO, pDSP_SORT);
                    return pObject;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialOrderStatusProvider(pDBManager).Templete_Download(pMaterialOrderStatusEntity, pMENU_NO, pDSP_SORT)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public MaterialOrderStatusEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                MaterialOrderStatusEntity pSampleRegisterEntity = new MaterialOrderStatusProvider(null).GetEntity(pDataRow);
                return pSampleRegisterEntity;
            }
            catch (Exception pException)
            {
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
    #endregion


    #region o 자재입고등록
    public class MaterialInRegisterBusiness
    {

        #region 마스터 정보 조회 - Material_In_Mst(MaterialInRegisterEntity pMaterialInRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Material_In_Mst(MaterialInRegisterEntity pMaterialInRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialInRegisterProvider(pDBManager).Material_In_Mst(pMaterialInRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(MaterialInRegisterEntity pMaterialInRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(MaterialOrderStatusEntity pMaterialOrderStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        //public DataTable Sample_Info_Sub(MaterialInRegisterEntity pMaterialInRegisterEntity)
        //{
        //    try
        //    {
        //        using (DBManager pDBManager = new DBManager())
        //        {
        //            //DataTable pDataTable = new MaterialInRegisterProvider(pDBManager).Sample_Info_Mst(pMaterialInRegisterEntity);
        //            //return pDataTable;
        //        }
        //    }
        //    catch (ExceptionManager pExceptionManager)
        //    {
        //        throw pExceptionManager;
        //    }
        //    catch (Exception pException)
        //    {
        //        throw new ExceptionManager(this, "Sample_Info_Sub(MaterialInRegisterEntity pMaterialInRegisterEntity)", pException);
        //    }
        //}

        #endregion

        #region 그리드 정보 저장 - MaterialInRegister_Info_Save(MaterialInRegisterEntity pMaterialOrderStatusEntity, DataTable dt)
        public bool MaterialInRegister_Info_Save(MaterialInRegisterEntity pMaterialInRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new MaterialInRegisterProvider(pDBManager).MaterialInRegister_Info_Save(pMaterialInRegisterEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialInRegister_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity)", pException);
            }
        }
        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public MaterialInRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                MaterialInRegisterEntity pMaterialInRegisterEntity = new MaterialInRegisterProvider(null).GetEntity(pDataRow);
                return pMaterialInRegisterEntity;
            }
            catch (Exception pException)
            {
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
    #endregion

    #region o 자재입고등록_T01
    public class MaterialInRegister_T01Business
    {

        #region 마스터 정보 조회 - Material_In_Mst(MaterialInRegister_T01Entity pMaterialInRegister_T01Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Material_In_Mst(MaterialInRegister_T01Entity pMaterialInRegister_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialInRegister_T01Provider(pDBManager).Material_In_Mst(pMaterialInRegister_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(MaterialInRegister_T01Entity pMaterialInRegister_T01Entity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(MaterialOrderStatusEntity pMaterialOrderStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        //public DataTable Sample_Info_Sub(MaterialInRegister_T01Entity pMaterialInRegister_T01Entity)
        //{
        //    try
        //    {
        //        using (DBManager pDBManager = new DBManager())
        //        {
        //            //DataTable pDataTable = new MaterialInRegister_T01Provider(pDBManager).Sample_Info_Mst(pMaterialInRegister_T01Entity);
        //            //return pDataTable;
        //        }
        //    }
        //    catch (ExceptionManager pExceptionManager)
        //    {
        //        throw pExceptionManager;
        //    }
        //    catch (Exception pException)
        //    {
        //        throw new ExceptionManager(this, "Sample_Info_Sub(MaterialInRegister_T01Entity pMaterialInRegister_T01Entity)", pException);
        //    }
        //}

        #endregion

        #region 그리드 정보 저장 - MaterialInRegister_T01_Info_Save(MaterialInRegister_T01Entity pMaterialOrderStatusEntity, DataTable dt)
        public bool MaterialInRegister_T01_Info_Save(MaterialInRegister_T01Entity pMaterialInRegister_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new MaterialInRegister_T01Provider(pDBManager).MaterialInRegister_T01_Info_Save(pMaterialInRegister_T01Entity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialInRegister_T01_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity)", pException);
            }
        }
        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public MaterialInRegister_T01Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                MaterialInRegister_T01Entity pMaterialInRegister_T01Entity = new MaterialInRegister_T01Provider(null).GetEntity(pDataRow);
                return pMaterialInRegister_T01Entity;
            }
            catch (Exception pException)
            {
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
    #endregion

    #region o 자재입고등록_T02
    public class MaterialInRegister_T02Business
    {

        #region 마스터 정보 조회 - Material_In_Mst(MaterialInRegister_T02Entity pMaterialInRegister_T02Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Material_In_Mst(MaterialInRegister_T02Entity pMaterialInRegister_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialInRegister_T02Provider(pDBManager).Material_In_Mst(pMaterialInRegister_T02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(MaterialInRegister_T02Entity pMaterialInRegister_T02Entity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(MaterialOrderStatusEntity pMaterialOrderStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        //public DataTable Sample_Info_Sub(MaterialInRegister_T02Entity pMaterialInRegister_T02Entity)
        //{
        //    try
        //    {
        //        using (DBManager pDBManager = new DBManager())
        //        {
        //            //DataTable pDataTable = new MaterialInRegister_T02Provider(pDBManager).Sample_Info_Mst(pMaterialInRegister_T02Entity);
        //            //return pDataTable;
        //        }
        //    }
        //    catch (ExceptionManager pExceptionManager)
        //    {
        //        throw pExceptionManager;
        //    }
        //    catch (Exception pException)
        //    {
        //        throw new ExceptionManager(this, "Sample_Info_Sub(MaterialInRegister_T02Entity pMaterialInRegister_T02Entity)", pException);
        //    }
        //}

        #endregion

        #region 그리드 정보 저장 - MaterialInRegister_T02_Info_Save(MaterialInRegister_T02Entity pMaterialOrderStatusEntity, DataTable dt)
        public bool MaterialInRegister_T02_Info_Save(MaterialInRegister_T02Entity pMaterialInRegister_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new MaterialInRegister_T02Provider(pDBManager).MaterialInRegister_T02_Info_Save(pMaterialInRegister_T02Entity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialInRegister_T02_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity)", pException);
            }
        }
        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public MaterialInRegister_T02Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                MaterialInRegister_T02Entity pMaterialInRegister_T02Entity = new MaterialInRegister_T02Provider(null).GetEntity(pDataRow);
                return pMaterialInRegister_T02Entity;
            }
            catch (Exception pException)
            {
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
    #endregion

    #region o 자재입고등록_바이오세라
    public class MaterialInRegister_T03Business
    {

        #region 마스터 정보 조회 - Material_In_Mst(MaterialInRegister_T03Entity pMaterialInRegister_T03Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Material_In_Mst(MaterialInRegister_T03Entity pMaterialInRegister_T03Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialInRegister_T03Provider(pDBManager).Material_In_Mst(pMaterialInRegister_T03Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(MaterialInRegister_T03Entity pMaterialInRegister_T03Entity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(MaterialOrderStatusEntity pMaterialOrderStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        //public DataTable Sample_Info_Sub(MaterialInRegister_T03Entity pMaterialInRegister_T03Entity)
        //{
        //    try
        //    {
        //        using (DBManager pDBManager = new DBManager())
        //        {
        //            //DataTable pDataTable = new MaterialInRegister_T03Provider(pDBManager).Sample_Info_Mst(pMaterialInRegister_T03Entity);
        //            //return pDataTable;
        //        }
        //    }
        //    catch (ExceptionManager pExceptionManager)
        //    {
        //        throw pExceptionManager;
        //    }
        //    catch (Exception pException)
        //    {
        //        throw new ExceptionManager(this, "Sample_Info_Sub(MaterialInRegister_T03Entity pMaterialInRegister_T03Entity)", pException);
        //    }
        //}

        #endregion

        #region 그리드 정보 저장 - MaterialInRegister_T03_Info_Save(MaterialInRegister_T03Entity pMaterialOrderStatusEntity, DataTable dt)
        public bool MaterialInRegister_T03_Info_Save(MaterialInRegister_T03Entity pMaterialInRegister_T03Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new MaterialInRegister_T03Provider(pDBManager).MaterialInRegister_T03_Info_Save(pMaterialInRegister_T03Entity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialInRegister_T03_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity)", pException);
            }
        }
        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public MaterialInRegister_T03Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                MaterialInRegister_T03Entity pMaterialInRegister_T03Entity = new MaterialInRegister_T03Provider(null).GetEntity(pDataRow);
                return pMaterialInRegister_T03Entity;
            }
            catch (Exception pException)
            {
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
    #endregion

    #region o 자재입고등록_의뢰
    public class MaterialInRegister_RequestBusiness
    {

        #region 마스터 정보 조회 - Material_In_Mst(MaterialInRegister_RequestEntity pMaterialInRegister_RequestEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Material_In_Mst(MaterialInRegister_RequestEntity pMaterialInRegister_RequestEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialInRegister_RequestProvider(pDBManager).Material_In_Mst(pMaterialInRegister_RequestEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(MaterialInRegister_RequestEntity pMaterialInRegister_RequestEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(MaterialOrderStatusEntity pMaterialOrderStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        //public DataTable Sample_Info_Sub(MaterialInRegister_RequestEntity pMaterialInRegister_RequestEntity)
        //{
        //    try
        //    {
        //        using (DBManager pDBManager = new DBManager())
        //        {
        //            //DataTable pDataTable = new MaterialInRegister_RequestProvider(pDBManager).Sample_Info_Mst(pMaterialInRegister_RequestEntity);
        //            //return pDataTable;
        //        }
        //    }
        //    catch (ExceptionManager pExceptionManager)
        //    {
        //        throw pExceptionManager;
        //    }
        //    catch (Exception pException)
        //    {
        //        throw new ExceptionManager(this, "Sample_Info_Sub(MaterialInRegister_RequestEntity pMaterialInRegister_RequestEntity)", pException);
        //    }
        //}

        #endregion

        #region 그리드 정보 저장 - MaterialInRegister_Request_Info_Save(MaterialInRegister_RequestEntity pMaterialOrderStatusEntity, DataTable dt)
        public bool MaterialInRegister_Request_Info_Save(MaterialInRegister_RequestEntity pMaterialInRegister_RequestEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new MaterialInRegister_RequestProvider(pDBManager).MaterialInRegister_Request_Info_Save(pMaterialInRegister_RequestEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialInRegister_Request_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity)", pException);
            }
        }
        #endregion
        #region 시험검사 정보 저장 -MaterialOrder_Request_Info_Save(UserInformationEntity pUserInformationEntity)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool MaterialInRegister_Request_Info_Check_Save(MaterialInRegister_RequestEntity pMaterialInRegister_RequestEntity, DataTable dt)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new MaterialInRegister_RequestProvider(pDBManager).MaterialInRegister_Request_Info_Check_Save(pMaterialInRegister_RequestEntity, dt);
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
        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public MaterialInRegister_RequestEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                MaterialInRegister_RequestEntity pMaterialInRegister_RequestEntity = new MaterialInRegister_RequestProvider(null).GetEntity(pDataRow);
                return pMaterialInRegister_RequestEntity;
            }
            catch (Exception pException)
            {
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
    #endregion

    #region o 자재입고등록_의뢰_T01
    public class MaterialInRegister_Request_T01Business
    {

        #region 마스터 정보 조회 - Material_In_Mst(MaterialInRegister_Request_T01Entity pMaterialInRegister_Request_T01Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Material_In_Mst(MaterialInRegister_Request_T01Entity pMaterialInRegister_Request_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialInRegister_Request_T01Provider(pDBManager).Material_In_Mst(pMaterialInRegister_Request_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Material_In_Mst(MaterialInRegister_Request_T01Entity pMaterialInRegister_Request_T01Entity)", pException);
            }
        }

        #endregion

        #region 서브 정보 조회
        public DataTable Material_In_Sub(MaterialInRegister_Request_T01Entity pMaterialInRegister_Request_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialInRegister_Request_T01Provider(pDBManager).Material_In_Sub(pMaterialInRegister_Request_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Material_In_Sub(MaterialInRegister_Request_T01Entity pMaterialInRegister_Request_T01Entity)", pException);
            }
        }
        #endregion

        #region 하위 품목 정보 조회
        public DataTable Material_In_Thrid(MaterialInRegister_Request_T01Entity pMaterialInRegister_Request_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialInRegister_Request_T01Provider(pDBManager).Material_In_Third(pMaterialInRegister_Request_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Material_In_Thrid(MaterialInRegister_Request_T01Entity pMaterialInRegister_Request_T01Entity)", pException);
            }
        }
        #endregion

        #region 발주정보 마스터 조회
        public DataTable Material_Order_Mst(MaterialInRegister_Request_T01Entity pMaterialInRegister_Request_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialInRegister_Request_T01Provider(pDBManager).Material_Order_Mst(pMaterialInRegister_Request_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Material_Order_Mst(MaterialInRegister_Request_T01Entity pMaterialInRegister_Request_T01Entity)", pException);
            }
        }
        #endregion

        #region 발주정보 서브 조회
        public DataTable Material_Order_Sub(MaterialInRegister_Request_T01Entity pMaterialInRegister_Request_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialInRegister_Request_T01Provider(pDBManager).Material_Order_Sub(pMaterialInRegister_Request_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Material_Order_Sub(MaterialInRegister_Request_T01Entity pMaterialInRegister_Request_T01Entity)", pException);
            }
        }
        #endregion

        #region 그리드 정보 저장 - MaterialInRegister_Request_T01_Info_Save(MaterialInRegister_RequestEntity pMaterialOrderStatus_T01Entity, DataTable dt)
        public bool MaterialInRegister_Request_T01_Info_Save(MaterialInRegister_Request_T01Entity pMaterialInRegister_Request_T01Entity, DataTable dt, DataTable dt_sub)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new MaterialInRegister_Request_T01Provider(pDBManager).MaterialInRegister_Request_T01_Info_Save(pMaterialInRegister_Request_T01Entity, dt, dt_sub);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialInRegister_Request_T01_Info_Save(MaterialOrderStatus_T01Entity pMaterialOrderStatus_T01Entity)", pException);
            }
        }
        #endregion

        #region 시험검사 정보 저장 -MaterialOrder_Request_T01_Info_Save(UserInformationEntity pUserInformationEntity)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool MaterialInRegister_Request_T01_Info_Check_Save(MaterialInRegister_Request_T01Entity pMaterialInRegister_Request_T01Entity, DataTable dt)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new MaterialInRegister_Request_T01Provider(pDBManager).MaterialInRegister_Request_T01_Info_Check_Save(pMaterialInRegister_Request_T01Entity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialInRegister_Request_T01_Info_Check_Save(MaterialInRegister_Request_T01Entity pMaterialInRegister_Request_T01Entity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public MaterialInRegister_Request_T01Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                MaterialInRegister_Request_T01Entity pMaterialInRegister_Request_T01Entity = new MaterialInRegister_Request_T01Provider(null).GetEntity(pDataRow);
                return pMaterialInRegister_Request_T01Entity;
            }
            catch (Exception pException)
            {
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
    #endregion

    #region o 자재반출입(진영)
    public class MaterialReShipInOutBusiness
    {
        #region 마스터 조회
        public DataTable MaterialReShipInOut_Mst(MaterialReShipInOutEntity pMaterialReShipInOutEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTableSet = new MaterialReShipInOutProvider(pDBManager).MaterialReShipInOut_Mst(pMaterialReShipInOutEntity);
                    return pDataTableSet;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialReShipInOut_Mst(MaterialReShipInOutEntity pMaterialReShipInOutEntity)", pException);
            }
        }

        #endregion

        #region 마스터 디테일 조회
        public DataTable MaterialReShipInOut_Mst_Detail(MaterialReShipInOutEntity pMaterialReShipInOutEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTableSet = new MaterialReShipInOutProvider(pDBManager).MaterialReShipInOut_Mst_Detail(pMaterialReShipInOutEntity);
                    return pDataTableSet;
                }

            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialReShipInOut_Mst_Detail(MaterialReShipInOutEntity pMaterialReShipInOutEntity)", pException);
            }
        }
        #endregion

        #region 서브 조회
        public DataTable MaterialReShipInOut_Sub(MaterialReShipInOutEntity pMaterialReShipInOutEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTableSet = new MaterialReShipInOutProvider(pDBManager).MaterialReShipInOut_Sub(pMaterialReShipInOutEntity);
                    return pDataTableSet;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialReShipInOut_Sub(MaterialReShipInOutEntity pMaterialReShipInOutEntity)", pException);
            }
        }

        #endregion

        #region 서브 디테일 조회
        public DataTable MaterialReShipInOut_Sub_Detail(MaterialReShipInOutEntity pMaterialReShipInOutEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTableSet = new MaterialReShipInOutProvider(pDBManager).MaterialReShipInOut_Sub_Detail(pMaterialReShipInOutEntity);
                    return pDataTableSet;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialReShipInOut_Sub_Detail(MaterialReShipInOutEntity pMaterialReShipInOutEntity)", pException);
            }
        }
        #endregion

        #region 그리드 정보 저장
        public bool MaterialReShipInOutBusiness_Save(MaterialReShipInOutEntity pMaterialReShipInOutEntity, DataTable _dtMainDetail, DataTable _dtSubDetail)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new MaterialReShipInOutProvider(pDBManager).MaterialReShipInOut_Save(pMaterialReShipInOutEntity, _dtMainDetail, _dtSubDetail);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialReShipInOutBusiness_Save(MaterialReShipInOutEntity pMaterialReShipInOutEntity, DataTable _dtMainDetail, DataTable _dtSubDetail)", pException);
            }
        }
        #endregion
    }
    #endregion


    public class MaterialOrderInfoPopup_RequestBusiness
    {
        public DataSet MaterialOrderInfoPopup_Return(string pCRUD, string pFromDate, string pToDate, string pPART_NAME, string pVEND_NAME)  //CRUD , 발주일자 , 자재명, 거래처명
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataSet pDataTableSet = new MaterialOrderInfoPopup_RequestProvider(pDBManager).MaterialOrderInfoPopup_Request_Return(pCRUD, pFromDate, pToDate, pPART_NAME, pVEND_NAME);
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
    #region o 자재입고현황
    public class MaterialInStatusBusiness
    {

        #region 마스터 정보 조회 - Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable MaterialInStatus_Info_Filename(MaterialInStatusEntity pMaterialInStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialInStatusProvider(pDBManager).MaterialInStatus_Info_Filename(pMaterialInStatusEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialInStatus_Info_Filename(MaterialInStatusEntity pMaterialInStatusEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(MaterialInStatusEntity pMaterialInStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(MaterialInStatusEntity pMaterialInStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialInStatusProvider(pDBManager).Sample_Info_Mst(pMaterialInStatusEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(MaterialInStatusEntity pMaterialInStatusEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(MaterialInStatusEntity pMaterialInStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(MaterialInStatusEntity pMaterialInStatusEntity, DataTable dt)
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
                    bool isReturn = new MaterialInStatusProvider(pDBManager).Sample_Info_Save(pMaterialInStatusEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(MaterialInStatusEntity pMaterialInStatusEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region XML파일 다운로드 - Templete_Download(MaterialInStatusEntity pMaterialInStatusEntity, string pMENU_NO, string pDSP_SORT)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public object Templete_Download(MaterialInStatusEntity pMaterialInStatusEntity, string pMENU_NO, string pDSP_SORT)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    object pObject = new MaterialInStatusProvider(pDBManager).Templete_Download(pMaterialInStatusEntity, pMENU_NO, pDSP_SORT);
                    return pObject;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialInStatusProvider(pDBManager).Templete_Download(pMaterialInStatusEntity, pMENU_NO, pDSP_SORT)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public MaterialInStatusEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                MaterialInStatusEntity pSampleRegisterEntity = new MaterialInStatusProvider(null).GetEntity(pDataRow);
                return pSampleRegisterEntity;
            }
            catch (Exception pException)
            {
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
    #endregion
    #region o 자재입고현황
    public class MaterialInStatus_T02Business
    {

        #region 마스터 정보 조회 - Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable MaterialInStatus_T02_Info(MaterialInStatus_T02Entity pMaterialInStatus_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialInStatus_T02Provider(pDBManager).MaterialInStatus_T02_Info(pMaterialInStatus_T02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialInStatus_Info_Filename(MaterialInStatusEntity pMaterialInStatusEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(MaterialInStatusEntity pMaterialInStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(MaterialInStatusEntity pMaterialInStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialInStatusProvider(pDBManager).Sample_Info_Mst(pMaterialInStatusEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(MaterialInStatusEntity pMaterialInStatusEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(MaterialInStatusEntity pMaterialInStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(MaterialInStatusEntity pMaterialInStatusEntity, DataTable dt)
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
                    bool isReturn = new MaterialInStatusProvider(pDBManager).Sample_Info_Save(pMaterialInStatusEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(MaterialInStatusEntity pMaterialInStatusEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region XML파일 다운로드 - Templete_Download(MaterialInStatusEntity pMaterialInStatusEntity, string pMENU_NO, string pDSP_SORT)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public object Templete_Download(MaterialInStatusEntity pMaterialInStatusEntity, string pMENU_NO, string pDSP_SORT)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    object pObject = new MaterialInStatusProvider(pDBManager).Templete_Download(pMaterialInStatusEntity, pMENU_NO, pDSP_SORT);
                    return pObject;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialInStatusProvider(pDBManager).Templete_Download(pMaterialInStatusEntity, pMENU_NO, pDSP_SORT)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public MaterialInStatus_T02Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                MaterialInStatus_T02Entity pSampleRegisterEntity = new MaterialInStatus_T02Provider(null).GetEntity(pDataRow);
                return pSampleRegisterEntity;
            }
            catch (Exception pException)
            {
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
    #endregion

    public class MaterialManagementBusiness
    {
        #region 마스터 정보 조회 - MaterialManagement_Mst(MaterialManagementEntity pMaterialManagementEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable MaterialManagement_Mst(MaterialManagementEntity pMaterialManagementEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialManagementProvider(pDBManager).MaterialManagement_Mst(pMaterialManagementEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialManagement_Sub(MaterialManagementEntity pMaterialManagementEntity)", pException);
            }
        }

        #endregion

        #region 서식파일 조회 - EquipmentChange_Sub(EquipmentChangeEntity pEquipmentChangeEntity)
        public DataTable MaterialManagement_Sub(MaterialManagementEntity pMaterialManagementEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialManagementProvider(pDBManager).MaterialManagement_Sub(pMaterialManagementEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialManagement_Sub(MaterialManagementEntity pMaterialManagementEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - MaterialManagement_Save(MaterialManagementEntity pMaterialManagementEntity)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool MaterialManagement_Save(MaterialManagementEntity pMaterialManagementEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new MaterialManagementProvider(pDBManager).MaterialManagement_Save(pMaterialManagementEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialManagement_Save(MaterialManagementEntity pMaterialManagementEntity)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public MaterialManagementEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                MaterialManagementEntity pListofManagementEntity = new MaterialManagementProvider(null).GetEntity(pDataRow);
                return pListofManagementEntity;
            }
            catch (Exception pException)
            {
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

    #region o 자재미입고현황
    public class MaterialNotInStatusBusiness
    {
        #region 마스터 정보 조회 - Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable MaterialNotInStatus_Info_Filename(MaterialNotInStatusEntity pMaterialNotInStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialNotInStatusProvider(pDBManager).MaterialNotInStatus_Info_Filename(pMaterialNotInStatusEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialNotInStatus_Info_Filename(MaterialNotInStatusEntity pMaterialNotInStatusEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(MaterialNotInStatusEntity pMaterialNotInStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(MaterialNotInStatusEntity pMaterialNotInStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialNotInStatusProvider(pDBManager).Sample_Info_Mst(pMaterialNotInStatusEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(MaterialNotInStatusEntity pMaterialNotInStatusEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(MaterialNotInStatusEntity pMaterialNotInStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(MaterialNotInStatusEntity pMaterialNotInStatusEntity, DataTable dt)
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
                    bool isReturn = new MaterialNotInStatusProvider(pDBManager).Sample_Info_Save(pMaterialNotInStatusEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(MaterialNotInStatusEntity pMaterialNotInStatusEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region XML파일 다운로드 - MenuRegister_Templete_Download(MenuRegisterEntity pMenuRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public object Templete_Download(MaterialNotInStatusEntity pSampleRegisterEntity, string pMENU_NO, string pDSP_SORT)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    object pObject = new MaterialNotInStatusProvider(pDBManager).Templete_Download(pSampleRegisterEntity, pMENU_NO, pDSP_SORT);
                    return pObject;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MenuRegister_Templete_Download(pMENU_NO, pDSP_SORT, pCUR_FILE)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public MaterialNotInStatusEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                MaterialNotInStatusEntity pSampleRegisterEntity = new MaterialNotInStatusProvider(null).GetEntity(pDataRow);
                return pSampleRegisterEntity;
            }
            catch (Exception pException)
            {
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
    #endregion

    #region o 자재출고등록
    public class MaterialOutRegisterBusiness
    {

        #region 마스터 정보 조회 - MaterialOutRegister_Info(MaterialOutRegisterEntity pMaterialOutRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable MaterialOutRegister_Info(MaterialOutRegisterEntity pMaterialOutRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialOutRegisterProvider(pDBManager).MaterialOutRegister_Info_Mst(pMaterialOutRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialOutRegister_Info(MaterialOutRegisterEntity pMaterialOutRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - MaterialOutRegister_Info_Sub(MaterialOutRegisterEntity pMaterialOutRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable MaterialOutRegister_Info_Sub(MaterialOutRegisterEntity pMaterialOutRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialOutRegisterProvider(pDBManager).MaterialOutRegister_Info_Mst(pMaterialOutRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialOutRegister_Info_Sub(MaterialOutRegisterEntity pMaterialOutRegisterEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - MaterialOutRegister_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool MaterialOutRegister_Info_Save(MaterialOutRegisterEntity pMaterialOutRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new MaterialOutRegisterProvider(pDBManager).MaterialOutRegister_Info_Save(pMaterialOutRegisterEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialOutRegister_Info_Save(MaterialOutRegisterEntity pMaterialOutRegisterEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public MaterialOutRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                MaterialOutRegisterEntity pMaterialOutRegisterEntity = new MaterialOutRegisterProvider(null).GetEntity(pDataRow);
                return pMaterialOutRegisterEntity;
            }
            catch (Exception pException)
            {
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
    #endregion

    #region o 자재출고등록_T01
    public class MaterialOutRegister_T01Business
    {

        #region 마스터 정보 조회 - MaterialOutRegister_T01_Info(MaterialOutRegister_T01Entity pMaterialOutRegister_T01Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable MaterialOutRegister_T01_Info(MaterialOutRegister_T01Entity pMaterialOutRegister_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialOutRegister_T01Provider(pDBManager).MaterialOutRegister_T01_Info_Mst(pMaterialOutRegister_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialOutRegister_T01_Info(MaterialOutRegister_T01Entity pMaterialOutRegister_T01Entity)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - MaterialOutRegister_T01_Info(MaterialOutRegister_T01Entity pMaterialOutRegister_T01Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataSet Sheet_Info_Sheet_Data(MaterialOutRegister_T01Entity pMaterialOutRegister_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataSet pDataSet = new MaterialOutRegister_T01Provider(pDBManager).Sheet_Info_Sheet_Data(pMaterialOutRegister_T01Entity);
                    return pDataSet;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialOutRegister_T01_Info(MaterialOutRegister_T01Entity pMaterialOutRegister_T01Entity)", pException);
            }
        }

        #endregion

        #region ○ 화면명에 맞는 엑셀파일 불러오기
        public DataTable Sheet_Info_Sheet(MaterialOutRegister_T01Entity pMaterialOutRegister_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialOutRegister_T01Provider(pDBManager).Sheet_Info_sheet(pMaterialOutRegister_T01Entity);
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

        #region 상세 정보 조회 - MaterialOutRegister_T01_Info_Sub(MaterialOutRegister_T01Entity pMaterialOutRegister_T01Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable MaterialOutRegister_T01_Info_Sub(MaterialOutRegister_T01Entity pMaterialOutRegister_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialOutRegister_T01Provider(pDBManager).MaterialOutRegister_T01_Info_Mst(pMaterialOutRegister_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialOutRegister_T01_Info_Sub(MaterialOutRegister_T01Entity pMaterialOutRegister_T01Entity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - MaterialOutRegister_T01_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool MaterialOutRegister_T01_Info_Save(MaterialOutRegister_T01Entity pMaterialOutRegister_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new MaterialOutRegister_T01Provider(pDBManager).MaterialOutRegister_T01_Info_Save(pMaterialOutRegister_T01Entity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialOutRegister_T01_Info_Save(MaterialOutRegister_T01Entity pMaterialOutRegister_T01Entity, DataTable dt)", pException);
            }
        }

        #endregion
        #region 상세 정보 조회 - MaterialOutRegister_T01_Info_Sub(MaterialOutRegister_T01Entity pMaterialOutRegister_T01Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public bool MaterialOutRegister_T01_Popup_Save(MaterialOutRegister_T01Entity pMaterialOutRegister_T01Entity, DataTable dt)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool pbool = new MaterialOutRegister_T01Provider(pDBManager).MaterialOutRegister_T01_Popup_Save(pMaterialOutRegister_T01Entity, dt);
                    return pbool;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialOutRegister_T01_Info_Sub(MaterialOutRegister_T01Entity pMaterialOutRegister_T01Entity)", pException);
            }
        }

        #endregion
        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public MaterialOutRegister_T01Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                MaterialOutRegister_T01Entity pMaterialOutRegister_T01Entity = new MaterialOutRegister_T01Provider(null).GetEntity(pDataRow);
                return pMaterialOutRegister_T01Entity;
            }
            catch (Exception pException)
            {
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
    #endregion

    #region o 자재출고등록_T02
    public class MaterialOutRegister_T02Business
    {
        #region 마스터 정보 조회 - MaterialOutRegister_T02_Info(MaterialOutRegister_T02Entity pMaterialOutRegister_T02Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable MaterialOutRegister_T02_Info(MaterialOutRegister_T02Entity pMaterialOutRegister_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialOutRegister_T02Provider(pDBManager).MaterialOutRegister_T02_Info_Mst(pMaterialOutRegister_T02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialOutRegister_T02_Info(MaterialOutRegister_T02Entity pMaterialOutRegister_T02Entity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - MaterialOutRegister_T02_Info_Sub(MaterialOutRegister_T02Entity pMaterialOutRegister_T02Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable MaterialOutRegister_T02_Info_Sub(MaterialOutRegister_T02Entity pMaterialOutRegister_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialOutRegister_T02Provider(pDBManager).MaterialOutRegister_T02_Info_Mst(pMaterialOutRegister_T02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialOutRegister_T02_Info_Sub(MaterialOutRegister_T02Entity pMaterialOutRegister_T02Entity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - MaterialOutRegister_T02_Info_Save(MaterialOutRegister_T02Entity pMaterialOutRegister_T02Entity)
        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool MaterialOutRegister_T02_Info_Save(MaterialOutRegister_T02Entity pMaterialOutRegister_T02Entity, DataTable dt)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new MaterialOutRegister_T02Provider(pDBManager).MaterialOutRegister_T02_Info_Save(pMaterialOutRegister_T02Entity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialOutRegister_T02_Info_Save(MaterialOutRegister_T02Entity pMaterialOutRegister_T02Entity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - MaterialOutRegister_T01_Info_Sub(MaterialOutRegister_T01Entity pMaterialOutRegister_T01Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public bool MaterialOutRegister_T02_Popup_Save(MaterialOutRegister_T02Entity pMaterialOutRegister_T02Entity, DataTable dt)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool pbool = new MaterialOutRegister_T02Provider(pDBManager).MaterialOutRegister_T02_Popup_Save(pMaterialOutRegister_T02Entity, dt);
                    return pbool;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialOutRegister_T02_Popup_Save(MaterialOutRegister_T02Entity pMaterialOutRegister_T02Entity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public MaterialOutRegister_T02Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                MaterialOutRegister_T02Entity pMaterialOutRegister_T02Entity = new MaterialOutRegister_T02Provider(null).GetEntity(pDataRow);
                return pMaterialOutRegister_T02Entity;
            }
            catch (Exception pException)
            {
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
    #endregion

    #region o 자재출고등록_바이오세라
    public class MaterialOutRegister_T03Business
    {

        #region 마스터 정보 조회 - MaterialOutRegister_T03_Info(MaterialOutRegister_T03Entity pMaterialOutRegister_T03Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable MaterialOutRegister_T03_Info(MaterialOutRegister_T03Entity pMaterialOutRegister_T03Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialOutRegister_T03Provider(pDBManager).MaterialOutRegister_T03_Info_Mst(pMaterialOutRegister_T03Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialOutRegister_T03_Info(MaterialOutRegister_T03Entity pMaterialOutRegister_T03Entity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - MaterialOutRegister_T03_Info_Sub(MaterialOutRegister_T03Entity pMaterialOutRegister_T03Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable MaterialOutRegister_T03_Info_Sub(MaterialOutRegister_T03Entity pMaterialOutRegister_T03Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialOutRegister_T03Provider(pDBManager).MaterialOutRegister_T03_Info_Mst(pMaterialOutRegister_T03Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialOutRegister_T03_Info_Sub(MaterialOutRegister_T03Entity pMaterialOutRegister_T03Entity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - MaterialOutRegister_T03_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool MaterialOutRegister_T03_Info_Save(MaterialOutRegister_T03Entity pMaterialOutRegister_T03Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new MaterialOutRegister_T03Provider(pDBManager).MaterialOutRegister_T03_Info_Save(pMaterialOutRegister_T03Entity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialOutRegister_T03_Info_Save(MaterialOutRegister_T03Entity pMaterialOutRegister_T03Entity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public MaterialOutRegister_T03Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                MaterialOutRegister_T03Entity pMaterialOutRegister_T03Entity = new MaterialOutRegister_T03Provider(null).GetEntity(pDataRow);
                return pMaterialOutRegister_T03Entity;
            }
            catch (Exception pException)
            {
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
    #endregion

    public class PartMoveRegisterBusiness
    {

        #region 마스터 정보 조회 - PartMoveRegister_Info(PartMoveRegisterEntity pPartMoveRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable PartMoveRegister_Info(PartMoveRegisterEntity pPartMoveRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new PartMoveRegisterProvider(pDBManager).PartMoveRegister_Info_Mst(pPartMoveRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "PartMoveRegister_Info(PartMoveRegisterEntity pPartMoveRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - PartMoveRegister_Info_Sub(PartMoveRegisterEntity pPartMoveRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable PartMoveRegister_Info_Sub(PartMoveRegisterEntity pPartMoveRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new PartMoveRegisterProvider(pDBManager).PartMoveRegister_Info_Mst(pPartMoveRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "PartMoveRegister_Info_Sub(PartMoveRegisterEntity pPartMoveRegisterEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - PartMoveRegister_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool PartMoveRegister_Info_Save(PartMoveRegisterEntity pPartMoveRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new PartMoveRegisterProvider(pDBManager).PartMoveRegister_Info_Save(pPartMoveRegisterEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "PartMoveRegister_Info_Save(PartMoveRegisterEntity pPartMoveRegisterEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public PartMoveRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                PartMoveRegisterEntity pPartMoveRegisterEntity = new PartMoveRegisterProvider(null).GetEntity(pDataRow);
                return pPartMoveRegisterEntity;
            }
            catch (Exception pException)
            {
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

    #region o 자재출고현황
    public class MaterialOutStatusBusiness
    {
        #region 마스터 정보 조회 - Sample_Info(MaterialOutStatusEntity pMaterialOutStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(MaterialOutStatusEntity pMaterialOutStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialOutStatusProvider(pDBManager).Sample_Info_Mst(pMaterialOutStatusEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(MaterialOutStatusEntity pSampleRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(MaterialOutStatusEntity pMaterialOutStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(MaterialOutStatusEntity pMaterialOutStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialOutStatusProvider(pDBManager).Sample_Info_Mst(pMaterialOutStatusEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(MaterialOutStatusEntity pMaterialOutStatusEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(MaterialOutStatusEntity pMaterialOutStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(MaterialOutStatusEntity pMaterialOutStatusEntity, DataTable dt)
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
                    bool isReturn = new MaterialOutStatusProvider(pDBManager).Sample_Info_Save(pMaterialOutStatusEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(MaterialOutStatusEntity pMaterialOutStatusEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable MaterialOutStatus_Info_Filename(MaterialOutStatusEntity pMaterialOutStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialOutStatusProvider(pDBManager).MaterialOutStatus_Info_Filename(pMaterialOutStatusEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialOutStatus_Info_Filename(MaterialOutStatusEntity pMaterialOutStatusEntity)", pException);
            }
        }

        #endregion

        #region XML파일 다운로드 - Templete_Download(MaterialOutStatusEntity pMaterialOutStatusEntity, string pMENU_NO, string pDSP_SORT)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public object Templete_Download(MaterialOutStatusEntity pMaterialOutStatusEntity, string pMENU_NO, string pDSP_SORT)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    object pObject = new MaterialOutStatusProvider(pDBManager).Templete_Download(pMaterialOutStatusEntity, pMENU_NO, pDSP_SORT);
                    return pObject;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialOutStatusProvider(pDBManager).Templete_Download(pMaterialOutStatusEntity, pMENU_NO, pDSP_SORT)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public MaterialOutStatusEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                MaterialOutStatusEntity pSampleRegisterEntity = new MaterialOutStatusProvider(null).GetEntity(pDataRow);
                return pSampleRegisterEntity;
            }
            catch (Exception pException)
            {
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
    #endregion
    #region o 자재출고현황 - YB
    public class MaterialOutStatus_T02Business
    {
        #region 마스터 정보 조회 - Sample_Info(MaterialOutStatusEntity pMaterialOutStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable MaterialOutStatus_T02_Info(MaterialOutStatus_T02Entity pMaterialOutStatus_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialOutStatus_T02Provider(pDBManager).MaterialOutStatus_T02_Info(pMaterialOutStatus_T02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(MaterialOutStatusEntity pSampleRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(MaterialOutStatusEntity pMaterialOutStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(MaterialOutStatusEntity pMaterialOutStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialOutStatusProvider(pDBManager).Sample_Info_Mst(pMaterialOutStatusEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(MaterialOutStatusEntity pMaterialOutStatusEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(MaterialOutStatusEntity pMaterialOutStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(MaterialOutStatusEntity pMaterialOutStatusEntity, DataTable dt)
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
                    bool isReturn = new MaterialOutStatusProvider(pDBManager).Sample_Info_Save(pMaterialOutStatusEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(MaterialOutStatusEntity pMaterialOutStatusEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable MaterialOutStatus_Info_Filename(MaterialOutStatusEntity pMaterialOutStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialOutStatusProvider(pDBManager).MaterialOutStatus_Info_Filename(pMaterialOutStatusEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialOutStatus_Info_Filename(MaterialOutStatusEntity pMaterialOutStatusEntity)", pException);
            }
        }

        #endregion

        #region XML파일 다운로드 - Templete_Download(MaterialOutStatusEntity pMaterialOutStatusEntity, string pMENU_NO, string pDSP_SORT)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public object Templete_Download(MaterialOutStatusEntity pMaterialOutStatusEntity, string pMENU_NO, string pDSP_SORT)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    object pObject = new MaterialOutStatusProvider(pDBManager).Templete_Download(pMaterialOutStatusEntity, pMENU_NO, pDSP_SORT);
                    return pObject;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialOutStatusProvider(pDBManager).Templete_Download(pMaterialOutStatusEntity, pMENU_NO, pDSP_SORT)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public MaterialOutStatus_T02Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                MaterialOutStatus_T02Entity pSampleRegisterEntity = new MaterialOutStatus_T02Provider(null).GetEntity(pDataRow);
                return pSampleRegisterEntity;
            }
            catch (Exception pException)
            {
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
    #endregion

    #region o 자재재고현황
    public class MaterialStockStatusBusiness
    {
        #region 마스터 정보 조회 - Sample_Info(MaterialStockStatusEntity pMaterialStockStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(MaterialStockStatusEntity pMaterialStockStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialStockStatusProvider(pDBManager).Sample_Info_Mst(pMaterialStockStatusEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(MaterialStockStatusEntity pSampleRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(MaterialStockStatusEntity pMaterialStockStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(MaterialStockStatusEntity pMaterialStockStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialStockStatusProvider(pDBManager).Sample_Info_Mst(pMaterialStockStatusEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(MaterialStockStatusEntity pMaterialStockStatusEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(MaterialStockStatusEntity pMaterialStockStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(MaterialStockStatusEntity pMaterialStockStatusEntity, DataTable dt)
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
                    bool isReturn = new MaterialStockStatusProvider(pDBManager).Sample_Info_Save(pMaterialStockStatusEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(MaterialStockStatusEntity pMaterialStockStatusEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable MaterialStockStatus_Info_Filename(MaterialStockStatusEntity pMaterialStockStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialStockStatusProvider(pDBManager).MaterialStockStatus_Info_Filename(pMaterialStockStatusEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialStockStatus_Info_Filename(MaterialStockStatusEntity pMaterialStockStatusEntity)", pException);
            }
        }

        #endregion

        #region XML파일 다운로드 - Templete_Download(MaterialStockStatusEntity pMaterialStockStatusEntity, string pMENU_NO, string pDSP_SORT)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public object Templete_Download(MaterialStockStatusEntity pMaterialStockStatusEntity, string pMENU_NO, string pDSP_SORT)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    object pObject = new MaterialStockStatusProvider(pDBManager).Templete_Download(pMaterialStockStatusEntity, pMENU_NO, pDSP_SORT);
                    return pObject;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialStockStatusProvider(pDBManager).Templete_Download(pMaterialStockStatusEntity, pMENU_NO, pDSP_SORT)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public MaterialStockStatusEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                MaterialStockStatusEntity pSampleRegisterEntity = new MaterialStockStatusProvider(null).GetEntity(pDataRow);
                return pSampleRegisterEntity;
            }
            catch (Exception pException)
            {
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
    #endregion
    #region o 자재재고현황_HPNC
    public class MaterialStockStatus_T01Business
    {
        #region 마스터 정보 조회 - Sample_Info(MaterialStockStatus_T01Entity pMaterialStockStatus_T01Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(MaterialStockStatus_T01Entity pMaterialStockStatus_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialStockStatus_T01Provider(pDBManager).Sample_Info_Mst(pMaterialStockStatus_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(MaterialStockStatus_T01Entity pSampleRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(MaterialStockStatus_T01Entity pMaterialStockStatus_T01Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(MaterialStockStatus_T01Entity pMaterialStockStatus_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialStockStatus_T01Provider(pDBManager).Sample_Info_Mst(pMaterialStockStatus_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(MaterialStockStatus_T01Entity pMaterialStockStatus_T01Entity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(MaterialStockStatus_T01Entity pMaterialStockStatus_T01Entity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(MaterialStockStatus_T01Entity pMaterialStockStatus_T01Entity, DataTable dt)
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
                    bool isReturn = new MaterialStockStatus_T01Provider(pDBManager).Sample_Info_Save(pMaterialStockStatus_T01Entity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(MaterialStockStatus_T01Entity pMaterialStockStatus_T01Entity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable MaterialStockStatus_T01_Info_Filename(MaterialStockStatus_T01Entity pMaterialStockStatus_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialStockStatus_T01Provider(pDBManager).MaterialStockStatus_T01_Info_Filename(pMaterialStockStatus_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialStockStatus_T01_Info_Filename(MaterialStockStatus_T01Entity pMaterialStockStatus_T01Entity)", pException);
            }
        }

        #endregion

        #region XML파일 다운로드 - Templete_Download(MaterialStockStatus_T01Entity pMaterialStockStatus_T01Entity, string pMENU_NO, string pDSP_SORT)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public object Templete_Download(MaterialStockStatus_T01Entity pMaterialStockStatus_T01Entity, string pMENU_NO, string pDSP_SORT)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    object pObject = new MaterialStockStatus_T01Provider(pDBManager).Templete_Download(pMaterialStockStatus_T01Entity, pMENU_NO, pDSP_SORT);
                    return pObject;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialStockStatus_T01Provider(pDBManager).Templete_Download(pMaterialStockStatus_T01Entity, pMENU_NO, pDSP_SORT)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public MaterialStockStatus_T01Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                MaterialStockStatus_T01Entity pSampleRegisterEntity = new MaterialStockStatus_T01Provider(null).GetEntity(pDataRow);
                return pSampleRegisterEntity;
            }
            catch (Exception pException)
            {
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
    #endregion

    #region o 자재재고현황_범아기전
    public class MaterialStockStatus_T02Business
    {
        #region 마스터 정보 조회 - Sample_Info(MaterialStockStatus_T02Entity pMaterialStockStatus_T02Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(MaterialStockStatus_T02Entity pMaterialStockStatus_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialStockStatus_T02Provider(pDBManager).Sample_Info_Mst(pMaterialStockStatus_T02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(MaterialStockStatus_T02Entity pSampleRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(MaterialStockStatus_T02Entity pMaterialStockStatus_T02Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(MaterialStockStatus_T02Entity pMaterialStockStatus_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialStockStatus_T02Provider(pDBManager).Sample_Info_Mst(pMaterialStockStatus_T02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(MaterialStockStatus_T02Entity pMaterialStockStatus_T02Entity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(MaterialStockStatus_T02Entity pMaterialStockStatus_T02Entity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(MaterialStockStatus_T02Entity pMaterialStockStatus_T02Entity, DataTable dt)
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
                    bool isReturn = new MaterialStockStatus_T02Provider(pDBManager).Sample_Info_Save(pMaterialStockStatus_T02Entity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(MaterialStockStatus_T02Entity pMaterialStockStatus_T02Entity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable MaterialStockStatus_T02_Info_Filename(MaterialStockStatus_T02Entity pMaterialStockStatus_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialStockStatus_T02Provider(pDBManager).MaterialStockStatus_T02_Info_Filename(pMaterialStockStatus_T02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialStockStatus_T02_Info_Filename(MaterialStockStatus_T02Entity pMaterialStockStatus_T02Entity)", pException);
            }
        }

        #endregion

        #region XML파일 다운로드 - Templete_Download(MaterialStockStatus_T02Entity pMaterialStockStatus_T02Entity, string pMENU_NO, string pDSP_SORT)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public object Templete_Download(MaterialStockStatus_T02Entity pMaterialStockStatus_T02Entity, string pMENU_NO, string pDSP_SORT)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    object pObject = new MaterialStockStatus_T02Provider(pDBManager).Templete_Download(pMaterialStockStatus_T02Entity, pMENU_NO, pDSP_SORT);
                    return pObject;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialStockStatus_T02Provider(pDBManager).Templete_Download(pMaterialStockStatus_T02Entity, pMENU_NO, pDSP_SORT)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public MaterialStockStatus_T02Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                MaterialStockStatus_T02Entity pSampleRegisterEntity = new MaterialStockStatus_T02Provider(null).GetEntity(pDataRow);
                return pSampleRegisterEntity;
            }
            catch (Exception pException)
            {
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
    #endregion

    #region o 자재재고현황_대성
    public class MaterialStockStatus_T04Business
    {
        #region 마스터 정보 조회 - Sample_Info(MaterialStockStatus_T04Entity pMaterialStockStatus_T04Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(MaterialStockStatus_T04Entity pMaterialStockStatus_T04Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialStockStatus_T04Provider(pDBManager).Sample_Info_Mst(pMaterialStockStatus_T04Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(MaterialStockStatus_T04Entity pSampleRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(MaterialStockStatus_T04Entity pMaterialStockStatus_T04Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(MaterialStockStatus_T04Entity pMaterialStockStatus_T04Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialStockStatus_T04Provider(pDBManager).Sample_Info_Mst(pMaterialStockStatus_T04Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(MaterialStockStatus_T04Entity pMaterialStockStatus_T04Entity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(MaterialStockStatus_T04Entity pMaterialStockStatus_T04Entity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(MaterialStockStatus_T04Entity pMaterialStockStatus_T04Entity, DataTable dt)
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
                    bool isReturn = new MaterialStockStatus_T04Provider(pDBManager).Sample_Info_Save(pMaterialStockStatus_T04Entity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(MaterialStockStatus_T04Entity pMaterialStockStatus_T04Entity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable MaterialStockStatus_T04_Info_Filename(MaterialStockStatus_T04Entity pMaterialStockStatus_T04Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialStockStatus_T04Provider(pDBManager).MaterialStockStatus_T04_Info_Filename(pMaterialStockStatus_T04Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialStockStatus_T04_Info_Filename(MaterialStockStatus_T04Entity pMaterialStockStatus_T04Entity)", pException);
            }
        }

        #endregion

        #region XML파일 다운로드 - Templete_Download(MaterialStockStatus_T04Entity pMaterialStockStatus_T04Entity, string pMENU_NO, string pDSP_SORT)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public object Templete_Download(MaterialStockStatus_T04Entity pMaterialStockStatus_T04Entity, string pMENU_NO, string pDSP_SORT)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    object pObject = new MaterialStockStatus_T04Provider(pDBManager).Templete_Download(pMaterialStockStatus_T04Entity, pMENU_NO, pDSP_SORT);
                    return pObject;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialStockStatus_T04Provider(pDBManager).Templete_Download(pMaterialStockStatus_T04Entity, pMENU_NO, pDSP_SORT)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public MaterialStockStatus_T04Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                MaterialStockStatus_T04Entity pSampleRegisterEntity = new MaterialStockStatus_T04Provider(null).GetEntity(pDataRow);
                return pSampleRegisterEntity;
            }
            catch (Exception pException)
            {
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
    #endregion

    #region o 자재재고현황_바이오세라
    public class MaterialStockStatus_T05Business
    {
        #region 마스터 정보 조회 - Sample_Info(MaterialStockStatus_T05Entity pMaterialStockStatus_T05Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(MaterialStockStatus_T05Entity pMaterialStockStatus_T05Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialStockStatus_T05Provider(pDBManager).Sample_Info_Mst(pMaterialStockStatus_T05Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(MaterialStockStatus_T05Entity pSampleRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(MaterialStockStatus_T05Entity pMaterialStockStatus_T05Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(MaterialStockStatus_T05Entity pMaterialStockStatus_T05Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialStockStatus_T05Provider(pDBManager).Sample_Info_Mst(pMaterialStockStatus_T05Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(MaterialStockStatus_T05Entity pMaterialStockStatus_T05Entity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(MaterialStockStatus_T05Entity pMaterialStockStatus_T05Entity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(MaterialStockStatus_T05Entity pMaterialStockStatus_T05Entity, DataTable dt)
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
                    bool isReturn = new MaterialStockStatus_T05Provider(pDBManager).Sample_Info_Save(pMaterialStockStatus_T05Entity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(MaterialStockStatus_T05Entity pMaterialStockStatus_T05Entity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable MaterialStockStatus_T05_Info_Filename(MaterialStockStatus_T05Entity pMaterialStockStatus_T05Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialStockStatus_T05Provider(pDBManager).MaterialStockStatus_T05_Info_Filename(pMaterialStockStatus_T05Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialStockStatus_T05_Info_Filename(MaterialStockStatus_T05Entity pMaterialStockStatus_T05Entity)", pException);
            }
        }

        #endregion

        #region XML파일 다운로드 - Templete_Download(MaterialStockStatus_T05Entity pMaterialStockStatus_T05Entity, string pMENU_NO, string pDSP_SORT)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public object Templete_Download(MaterialStockStatus_T05Entity pMaterialStockStatus_T05Entity, string pMENU_NO, string pDSP_SORT)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    object pObject = new MaterialStockStatus_T05Provider(pDBManager).Templete_Download(pMaterialStockStatus_T05Entity, pMENU_NO, pDSP_SORT);
                    return pObject;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialStockStatus_T05Provider(pDBManager).Templete_Download(pMaterialStockStatus_T05Entity, pMENU_NO, pDSP_SORT)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public MaterialStockStatus_T05Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                MaterialStockStatus_T05Entity pSampleRegisterEntity = new MaterialStockStatus_T05Provider(null).GetEntity(pDataRow);
                return pSampleRegisterEntity;
            }
            catch (Exception pException)
            {
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
    #endregion
    public class ProcessMaterialStockStatusBusiness
    {
        #region 마스터 정보 조회 - Sample_Info(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(ProcessMaterialStockStatusEntity pProcessMaterialStockStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProcessMaterialStockStatusProvider(pDBManager).Sample_Info_Mst(pProcessMaterialStockStatusEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(ProcessMaterialStockStatusEntity _pProcessMaterialStockStatusEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(ProcessMaterialStockStatusEntity pProcessMaterialStockStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProcessMaterialStockStatusProvider(pDBManager).Sample_Info_Mst(pProcessMaterialStockStatusEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(ProcessMaterialStockStatusEntity pProcessMaterialStockStatusEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(SampleRegisterEntity pSampleRegisterEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(ProcessMaterialStockStatusEntity pProcessMaterialStockStatusEntity, DataTable dt)
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
                    bool isReturn = new ProcessMaterialStockStatusProvider(pDBManager).Sample_Info_Save(pProcessMaterialStockStatusEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(ProcessMaterialStockStatusEntity _pProcessMaterialStockStatusEntity, DataTable dt)", pException);
            }
        }

        #endregion


        #region 마스터 정보 조회 - Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Filename(ProcessMaterialStockStatusEntity pSampleRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProcessMaterialStockStatusProvider(pDBManager).Sample_Info_Filename(pSampleRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)", pException);
            }
        }

        #endregion

        #region XML파일 다운로드 - MenuRegister_Templete_Download(MenuRegisterEntity pMenuRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public object Templete_Download(ProcessMaterialStockStatusEntity pSampleRegisterEntity, string pMENU_NO, string pDSP_SORT)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    object pObject = new ProcessMaterialStockStatusProvider(pDBManager).Templete_Download(pSampleRegisterEntity, pMENU_NO, pDSP_SORT);
                    return pObject;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MenuRegister_Templete_Download(pMENU_NO, pDSP_SORT, pCUR_FILE)", pException);
            }
        }

        #endregion

        #region ○ 화면명에 맞는 엑셀파일 불러오기
        public DataTable Sheet_Info_Sheet(ProcessMaterialStockStatusEntity _pProcessMaterialStockStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pdatatable = new ProcessMaterialStockStatusProvider(pDBManager).Sheet_Info_sheet(_pProcessMaterialStockStatusEntity);
                    return pdatatable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sheet_Info_Sheet(ProcessMaterialStockStatusEntity _pProcessMaterialStockStatusEntity)", pException);
            }
        }

        #endregion

        #region 바인딩 데이터 테이블 불러오기 - Sheet_Info_Sheet_Data(ProcessMaterialStockStatusProvider pProcessMaterialStockStatusProvider)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sheet_Info_Sheet_Data(ProcessMaterialStockStatusEntity pProcessMaterialStockStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProcessMaterialStockStatusProvider(pDBManager).Sheet_Info_Sheet_Data(pProcessMaterialStockStatusEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sheet_Info_Sheet_Data(ProcessMaterialStockStatusProvider pProcessMaterialStockStatusProvider)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ProcessMaterialStockStatusEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ProcessMaterialStockStatusEntity pSampleRegisterEntity = new ProcessMaterialStockStatusProvider(null).GetEntity(pDataRow);
                return pSampleRegisterEntity;
            }
            catch (Exception pException)
            {
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


    public class MaterialInformationRegisterBusiness
    {
        #region 마스터 정보 조회 - MaterialInformationRegister_Info(MaterialInformationRegisterEntity pMaterialInformationRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable MaterialInformationRegister_Info(MaterialInformationRegisterEntity pMaterialInformationRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialInformationRegisterProvider(pDBManager).MaterialInformationRegister_Info_Mst(pMaterialInformationRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialInformationRegister_Info(MaterialInformationRegisterEntity pMaterialInformationRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - MaterialInformationRegister_Info_Sub(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable MaterialInformationRegister_Info_Sub(MaterialInformationRegisterEntity pMaterialInformationRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialInformationRegisterProvider(pDBManager).MaterialInformationRegister_Info_Sub(pMaterialInformationRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialInformationRegister_Info_Sub(MaterialInformationRegisterEntity pMaterialInformationRegisterEntity))", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - MaterialInformationRegister_Info_Save(MaterialInformationRegisterEntity pMaterialInformationRegisterEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool MaterialInformationRegister_Info_Save(MaterialInformationRegisterEntity pMaterialInformationRegisterEntity, DataTable dt)
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
                    bool isReturn = new MaterialInformationRegisterProvider(pDBManager).MaterialInformationRegister_Info_Save(pMaterialInformationRegisterEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialInformationRegister_Info_Save(MaterialInformationRegisterEntity pMaterialInformationRegisterEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public MaterialInformationRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                MaterialInformationRegisterEntity pMaterialInformationRegisterEntity = new MaterialInformationRegisterProvider(null).GetEntity(pDataRow);
                return pMaterialInformationRegisterEntity;
            }
            catch (Exception pException)
            {
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

    public class MaterialInformationRegister_T01Business
    {
        #region 마스터 정보 조회 - MaterialInformationRegister_T01_Info(MaterialInformationRegister_T01Entity pMaterialInformationRegister_T01Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable MaterialInformationRegister_T01_Info(MaterialInformationRegister_T01Entity pMaterialInformationRegister_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialInformationRegister_T01Provider(pDBManager).MaterialInformationRegister_T01_Info_Mst(pMaterialInformationRegister_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialInformationRegister_T01_Info(MaterialInformationRegister_T01Entity pMaterialInformationRegister_T01Entity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - MaterialInformationRegister_T01_Info_Save(MaterialInformationRegister_T01Entity pMaterialInformationRegister_T01Entity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool MaterialInformationRegister_T01_Info_Save(MaterialInformationRegister_T01Entity pMaterialInformationRegister_T01Entity, DataTable dt)
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
                    bool isReturn = new MaterialInformationRegister_T01Provider(pDBManager).MaterialInformationRegister_T01_Info_Save(pMaterialInformationRegister_T01Entity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialInformationRegister_T01_Info_Save(MaterialInformationRegister_T01Entity pMaterialInformationRegister_T01Entity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public MaterialInformationRegister_T01Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                MaterialInformationRegister_T01Entity pMaterialInformationRegister_T01Entity = new MaterialInformationRegister_T01Provider(null).GetEntity(pDataRow);
                return pMaterialInformationRegister_T01Entity;
            }
            catch (Exception pException)
            {
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

    public class FrequentPartHistoryBusiness
    {
        #region 마스터 정보 조회 - FrequentPartHistory_Info(FrequentPartHistoryEntity pFrequentPartHistoryEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable FrequentPartHistory_Info(FrequentPartHistoryEntity pFrequentPartHistoryEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new FrequentPartHistoryProvider(pDBManager).FrequentPartHistory_Info_Mst(pFrequentPartHistoryEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "FrequentPartHistory_Info(FrequentPartHistoryEntity pFrequentPartHistoryEntity)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public FrequentPartHistoryEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                FrequentPartHistoryEntity pFrequentPartHistoryEntity = new FrequentPartHistoryProvider(null).GetEntity(pDataRow);
                return pFrequentPartHistoryEntity;
            }
            catch (Exception pException)
            {
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

    public class MaterialInformationRegister_T02Business
    {
        #region 마스터 정보 조회 - MaterialInformationRegister_T02_Info(MaterialInformationRegister_T02Entity pMaterialInformationRegister_T02Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable MaterialInformationRegister_T02_Info(MaterialInformationRegister_T02Entity pMaterialInformationRegister_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialInformationRegister_T02Provider(pDBManager).MaterialInformationRegister_T02_Info_Mst(pMaterialInformationRegister_T02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialInformationRegister_T02_Info(MaterialInformationRegister_T02Entity pMaterialInformationRegister_T02Entity)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - MaterialInformationRegister_T02_Info(MaterialInformationRegister_T02Entity pMaterialInformationRegister_T02Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable MaterialInformationRegister_T02_Info2(MaterialInformationRegister_T02Entity pMaterialInformationRegister_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialInformationRegister_T02Provider(pDBManager).MaterialInformationRegister_T02_Info2(pMaterialInformationRegister_T02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialInformationRegister_T02_Info(MaterialInformationRegister_T02Entity pMaterialInformationRegister_T02Entity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - MaterialInformationRegister_T02_Info_Sub(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable MaterialInformationRegister_T02_Info_Sub(MaterialInformationRegister_T02Entity pMaterialInformationRegister_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialInformationRegister_T02Provider(pDBManager).MaterialInformationRegister_T02_Info_Sub(pMaterialInformationRegister_T02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialInformationRegister_T02_Info_Sub(MaterialInformationRegister_T02Entity pMaterialInformationRegister_T02Entity))", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - MaterialInformationRegister_T02_Info_Save(MaterialInformationRegister_T02Entity pMaterialInformationRegister_T02Entity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool MaterialInformationRegister_T02_Info_Save(MaterialInformationRegister_T02Entity pMaterialInformationRegister_T02Entity, DataTable dt)
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
                    bool isReturn = new MaterialInformationRegister_T02Provider(pDBManager).MaterialInformationRegister_T02_Info_Save(pMaterialInformationRegister_T02Entity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialInformationRegister_T02_Info_Save(MaterialInformationRegister_T02Entity pMaterialInformationRegister_T02Entity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - MaterialInformationRegister_T02_Info_Save(MaterialInformationRegister_T02Entity pMaterialInformationRegister_T02Entity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool MaterialInformationRegister_T02_Info_Save2(MaterialInformationRegister_T02Entity pMaterialInformationRegister_T02Entity, DataTable dt)
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
                    bool isReturn = new MaterialInformationRegister_T02Provider(pDBManager).MaterialInformationRegister_T02_Info_Save2(pMaterialInformationRegister_T02Entity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialInformationRegister_T02_Info_Save(MaterialInformationRegister_T02Entity pMaterialInformationRegister_T02Entity, DataTable dt)", pException);
            }
        }

        #endregion



        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public MaterialInformationRegister_T02Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                MaterialInformationRegister_T02Entity pMaterialInformationRegister_T02Entity = new MaterialInformationRegister_T02Provider(null).GetEntity(pDataRow);
                return pMaterialInformationRegister_T02Entity;
            }
            catch (Exception pException)
            {
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

    public class ucMaterialVendCostInfoListPopupBusiness
    {
        #region 정보 조회 - ucMaterialVendCostInfoListPopup_Info_Return(ucMaterialVendCostInfoListPopupEntity pucMaterialVendCostInfoListPopupEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ucMaterialVendCostInfoListPopup_Info_Return(ucMaterialVendCostInfoListPopupEntity pucMaterialVendCostInfoListPopupEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucMaterialVendCostInfoListPopupProvider(pDBManager).ucMaterialVendCostInfoListPopup_Info_Return(pucMaterialVendCostInfoListPopupEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucMaterialVendCostInfoListPopup_Info_Return(ucMaterialVendCostInfoListPopupEntity pucMaterialVendCostInfoListPopupEntity)", pException);
            }
        }

        #endregion

        #region 정보 저장 - ucMaterialVendCostInfoListPopup_Info_Save(ucMaterialVendCostInfoListPopupEntity pucMaterialVendCostInfoListPopupEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool ucMaterialVendCostInfoListPopup_Info_Save(ucMaterialVendCostInfoListPopupEntity pucMaterialVendCostInfoListPopupEntity, DataTable dt)
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
                    bool isReturn = new ucMaterialVendCostInfoListPopupProvider(pDBManager).ucMaterialVendCostInfoListPopup_Info_Save(pucMaterialVendCostInfoListPopupEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucMaterialVendCostInfoListPopup_Info_Save(ucMaterialVendCostInfoListPopupEntity pucMaterialVendCostInfoListPopupEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ucMaterialVendCostInfoListPopupEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ucMaterialVendCostInfoListPopupEntity pucMaterialVendCostInfoListPopupEntity = new ucMaterialVendCostInfoListPopupProvider(null).GetEntity(pDataRow);
                return pucMaterialVendCostInfoListPopupEntity;
            }
            catch (Exception pException)
            {
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


    #region o 자재입출고현황
    public class MaterialInOutStatusBusiness
    {
        #region 마스터 정보 조회 - Sample_Info(MaterialInOutStatusEntity pMaterialInOutStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(MaterialInOutStatusEntity pMaterialInOutStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialInOutStatusProvider(pDBManager).Sample_Info_Mst(pMaterialInOutStatusEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(MaterialInOutStatusEntity pMaterialInOutStatusEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(MaterialInOutStatusEntity pMaterialInOutStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(MaterialInOutStatusEntity pMaterialInOutStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialInOutStatusProvider(pDBManager).Sample_Info_Mst(pMaterialInOutStatusEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(MaterialInOutStatusEntity pMaterialInOutStatusEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(MaterialOutStatusEntity pMaterialOutStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(MaterialInOutStatusEntity pMaterialInOutStatusEntity, DataTable dt)
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
                    bool isReturn = new MaterialInOutStatusProvider(pDBManager).Sample_Info_Save(pMaterialInOutStatusEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(MaterialInOutStatusEntity pMaterialInOutStatusEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public MaterialInOutStatusEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                MaterialInOutStatusEntity pSampleRegisterEntity = new MaterialInOutStatusProvider(null).GetEntity(pDataRow);
                return pSampleRegisterEntity;
            }
            catch (Exception pException)
            {
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
    #endregion

    #region o 자재입출현황_리스트_YB
    public class MaterialInOutStatus_T01Business
    {
        #region 마스터 정보 조회 - Sample_Info(MaterialInOutStatus_T01Entity pMaterialInOutStatus_T01Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(MaterialInOutStatus_T01Entity pMaterialInOutStatus_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialInOutStatus_T01Provider(pDBManager).Sample_Info_Mst(pMaterialInOutStatus_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(MaterialInOutStatus_T01Entity pSampleRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(MaterialInOutStatus_T01Entity pMaterialInOutStatus_T01Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(MaterialInOutStatus_T01Entity pMaterialInOutStatus_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialInOutStatus_T01Provider(pDBManager).Sample_Info_Mst(pMaterialInOutStatus_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(MaterialInOutStatus_T01Entity pMaterialInOutStatus_T01Entity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(MaterialInOutStatus_T01Entity pMaterialInOutStatus_T01Entity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(MaterialInOutStatus_T01Entity pMaterialInOutStatus_T01Entity, DataTable dt)
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
                    bool isReturn = new MaterialInOutStatus_T01Provider(pDBManager).Sample_Info_Save(pMaterialInOutStatus_T01Entity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(MaterialInOutStatus_T01Entity pMaterialInOutStatus_T01Entity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable MaterialInOutStatus_T01_Info_Filename(MaterialInOutStatus_T01Entity pMaterialInOutStatus_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialInOutStatus_T01Provider(pDBManager).MaterialInOutStatus_T01_Info_Filename(pMaterialInOutStatus_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialInOutStatus_T01_Info_Filename(MaterialInOutStatus_T01Entity pMaterialInOutStatus_T01Entity)", pException);
            }
        }

        #endregion

        #region XML파일 다운로드 - Templete_Download(MaterialInOutStatus_T01Entity pMaterialInOutStatus_T01Entity, string pMENU_NO, string pDSP_SORT)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public object Templete_Download(MaterialInOutStatus_T01Entity pMaterialInOutStatus_T01Entity, string pMENU_NO, string pDSP_SORT)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    object pObject = new MaterialInOutStatus_T01Provider(pDBManager).Templete_Download(pMaterialInOutStatus_T01Entity, pMENU_NO, pDSP_SORT);
                    return pObject;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialInOutStatus_T01Provider(pDBManager).Templete_Download(pMaterialInOutStatus_T01Entity, pMENU_NO, pDSP_SORT)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public MaterialInOutStatus_T01Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                MaterialInOutStatus_T01Entity pSampleRegisterEntity = new MaterialInOutStatus_T01Provider(null).GetEntity(pDataRow);
                return pSampleRegisterEntity;
            }
            catch (Exception pException)
            {
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
    #endregion

    #region o 자재입출현황_총합_YB
    public class MaterialInOutStatus_T02Business
    {
        #region 마스터 정보 조회 - Sample_Info(MaterialInOutStatus_T01Entity pMaterialInOutStatus_T01Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(MaterialInOutStatus_T02Entity pMaterialInOutStatus_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialInOutStatus_T02Provider(pDBManager).Sample_Info_Mst(pMaterialInOutStatus_T02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(MaterialInOutStatus_T01Entity pSampleRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(MaterialInOutStatus_T02Entity pMaterialInOutStatus_T02Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(MaterialInOutStatus_T01Entity pMaterialInOutStatus_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialInOutStatus_T01Provider(pDBManager).Sample_Info_Mst(pMaterialInOutStatus_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(MaterialInOutStatus_T01Entity pMaterialInOutStatus_T01Entity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(MaterialInOutStatus_T01Entity pMaterialInOutStatus_T01Entity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(MaterialInOutStatus_T01Entity pMaterialInOutStatus_T01Entity, DataTable dt)
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
                    bool isReturn = new MaterialInOutStatus_T01Provider(pDBManager).Sample_Info_Save(pMaterialInOutStatus_T01Entity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(MaterialInOutStatus_T01Entity pMaterialInOutStatus_T01Entity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable MaterialInOutStatus_T01_Info_Filename(MaterialInOutStatus_T01Entity pMaterialInOutStatus_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialInOutStatus_T01Provider(pDBManager).MaterialInOutStatus_T01_Info_Filename(pMaterialInOutStatus_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialInOutStatus_T01_Info_Filename(MaterialInOutStatus_T01Entity pMaterialInOutStatus_T01Entity)", pException);
            }
        }

        #endregion

        #region XML파일 다운로드 - Templete_Download(MaterialInOutStatus_T01Entity pMaterialInOutStatus_T01Entity, string pMENU_NO, string pDSP_SORT)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public object Templete_Download(MaterialInOutStatus_T01Entity pMaterialInOutStatus_T01Entity, string pMENU_NO, string pDSP_SORT)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    object pObject = new MaterialInOutStatus_T01Provider(pDBManager).Templete_Download(pMaterialInOutStatus_T01Entity, pMENU_NO, pDSP_SORT);
                    return pObject;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialInOutStatus_T01Provider(pDBManager).Templete_Download(pMaterialInOutStatus_T01Entity, pMENU_NO, pDSP_SORT)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public MaterialInOutStatus_T02Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                MaterialInOutStatus_T02Entity pSampleRegisterEntity = new MaterialInOutStatus_T02Provider(null).GetEntity(pDataRow);
                return pSampleRegisterEntity;
            }
            catch (Exception pException)
            {
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
    #endregion
    #region o 자재입출고현황
    public class MaterialCollectAndPayBusiness
    {
        #region 마스터 정보 조회 - Sample_Info(MaterialCollectAndPayEntity pMaterialCollectAndPayEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(MaterialCollectAndPayEntity pMaterialCollectAndPayEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialCollectAndPayProvider(pDBManager).Sample_Info_Mst(pMaterialCollectAndPayEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(MaterialCollectAndPayEntity pMaterialCollectAndPayEntity)", pException);
            }
        }

        #endregion
    }
    #endregion
    #region o 자재입출고현황_상세
    public class MaterialCollectAndPay_DetailBusiness
    {
        #region 마스터 정보 조회 - Sample_Info(MaterialCollectAndPayEntity pMaterialCollectAndPayEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(MaterialCollectAndPay_DetailEntity pMaterialCollectAndPay_DetailEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialCollectAndPay_DetailProvider(pDBManager).Sample_Info_Mst(pMaterialCollectAndPay_DetailEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialCollectAndPay_DetailProvider(pDBManager).Sample_Info_Mst(pMaterialCollectAndPay_DetailEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(MaterialCollectAndPayEntity pMaterialCollectAndPayEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(MaterialCollectAndPayEntity pMaterialCollectAndPayEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialCollectAndPayProvider(pDBManager).Sample_Info_Mst(pMaterialCollectAndPayEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(MaterialCollectAndPayEntity pMaterialCollectAndPayEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(MaterialOutStatusEntity pMaterialOutStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(MaterialCollectAndPayEntity pMaterialCollectAndPayEntity, DataTable dt)
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
                    bool isReturn = new MaterialCollectAndPayProvider(pDBManager).Sample_Info_Save(pMaterialCollectAndPayEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(MaterialCollectAndPayEntity pMaterialCollectAndPayEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public MaterialCollectAndPayEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                MaterialCollectAndPayEntity pSampleRegisterEntity = new MaterialCollectAndPayProvider(null).GetEntity(pDataRow);
                return pSampleRegisterEntity;
            }
            catch (Exception pException)
            {
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
    #endregion

    #region 검사의뢰 조회

    public class ucMaterialStockInfoPopupBusiness
    {
        #region 시험의뢰 조회 

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public DataSet ucInspectRequestInfo_Return(string pCRUD, string pPART_CODE, string pPART_NAME)
        {
            try
            {

                using (DBManager pDBManager = new DBManager())
                {
                    DataSet pDataTableSet = new ucMaterialStockInfoPopupProvider(pDBManager).ucInspectRequestInfo_Return(pCRUD, pPART_CODE, pPART_NAME);
                    return pDataTableSet;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Excel_Info_Mst_Save(ucInspectRequestInfoPopupEntity pucInspectRequestInfoPopupEntity, DataTable dt1, DataTable dt2)", pException);
            }
        }

        #endregion
        #region 시험의뢰 접수 Insert - Mst

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool ucMaterialStockInfoPopup_Save(ucMaterialStockInfoPopupEntity pucMaterialStockInfoPopupEntity, DataTable dt)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ucMaterialStockInfoPopupProvider(pDBManager).ucMaterialStockInfoPopup_Save(pucMaterialStockInfoPopupEntity, dt);
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
    }


    #endregion

    #region 검사의뢰 조회_T01

    public class ucMaterialStockInfoPopup_T01Business
    {
        #region 시험의뢰 조회 

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public DataSet ucInspectRequeestInfo_Return(string pCRUD, string pPART_CODE, string pPART_NAME)
        {
            try
            {

                using (DBManager pDBManager = new DBManager())
                {
                    DataSet pDataTableSet = new ucMaterialStockInfoPopup_T01Provider(pDBManager).ucInspectRequeestInfo_Return(pCRUD, pPART_CODE, pPART_NAME);
                    return pDataTableSet;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, " ucInspectRequeestInfo_Return(string pCRUD, string pPART_CODE, string pPART_NAME)", pException);
            }
        }

        #endregion

        #region 시험의뢰 접수 Insert - Mst

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool ucMaterialStockInfoPopup_Save(ucMaterialStockInfoPopup_T01Entity pucMaterialStockInfoPopup_T01Entity, DataTable dt)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ucMaterialStockInfoPopup_T01Provider(pDBManager).ucMaterialStockInfoPopup_Save(pucMaterialStockInfoPopup_T01Entity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucMaterialStockInfoPopup_Save(ucMaterialStockInfoPopup_T01Entity pucMaterialStockInfoPopup_T01Entity, DataTable dt)", pException);
            }
        }

        #endregion
    }


    #endregion

    public class ucPartDocumentListPopupBusiness
    {
        #region 메인 정보 조회 - ucPartDocumentListPopup_Info_Main(ucPartDocumentListPopupEntity pucPartDocumentListPopupEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ucPartDocumentListPopup_Info_Main(ucPartDocumentListPopupEntity pucPartDocumentListPopupEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucPartDocumentListPopupProvider(pDBManager).ucPartDocumentListPopup_Info_Main(pucPartDocumentListPopupEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucPartDocumentListPopup_Info_Main(ucPartDocumentListPopupEntity pucPartDocumentListPopupEntity)", pException);
            }
        }

        #endregion

        #region 서브 정보 조회 - ucPartDocumentListPopup_Info_Sub(ucPartDocumentListPopupEntity pucPartDocumentListPopupEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ucPartDocumentListPopup_Info_Sub(ucPartDocumentListPopupEntity pucPartDocumentListPopupEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucPartDocumentListPopupProvider(pDBManager).ucPartDocumentListPopup_Info_Sub(pucPartDocumentListPopupEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucPartDocumentListPopup_Info_Sub(ucPartDocumentListPopupEntity pucPartDocumentListPopupEntity)", pException);
            }
        }

        #endregion

        #region 정보 저장 - ucPartDocumentListPopup_Info_Save(ucPartDocumentListPopupEntity pucPartDocumentListPopupEntity, DataTable dt)

        /// <summary>
        /// 정보 저장
        /// </summary>
        public bool ucPartDocumentListPopup_Info_Save(ucPartDocumentListPopupEntity pucPartDocumentListPopupEntity, DataTable dt)
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
                    bool isReturn = new ucPartDocumentListPopupProvider(pDBManager).ucPartDocumentListPopup_Info_Save(pucPartDocumentListPopupEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucPartDocumentListPopup_Info_Save(ucPartDocumentListPopupEntity pucPartDocumentListPopupEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ucPartDocumentListPopupEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ucPartDocumentListPopupEntity pucPartDocumentListPopupEntity = new ucPartDocumentListPopupProvider(null).GetEntity(pDataRow);
                return pucPartDocumentListPopupEntity;
            }
            catch (Exception pException)
            {
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

    public class ucPartDocumentListPopup_T02Business
    {
        #region 메인 정보 조회 - ucPartDocumentListPopup_T02_Info_Main(ucPartDocumentListPopup_T02Entity pucPartDocumentListPopup_T02Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ucPartDocumentListPopup_T02_Info_Main(ucPartDocumentListPopup_T02Entity pucPartDocumentListPopup_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucPartDocumentListPopup_T02Provider(pDBManager).ucPartDocumentListPopup_T02_Info_Main(pucPartDocumentListPopup_T02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucPartDocumentListPopup_T02_Info_Main(ucPartDocumentListPopup_T02Entity pucPartDocumentListPopup_T02Entity)", pException);
            }
        }

        #endregion

        #region 서브 정보 조회 - ucPartDocumentListPopup_T02_Info_Sub(ucPartDocumentListPopup_T02Entity pucPartDocumentListPopup_T02Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ucPartDocumentListPopup_T02_Info_Sub(ucPartDocumentListPopup_T02Entity pucPartDocumentListPopup_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucPartDocumentListPopup_T02Provider(pDBManager).ucPartDocumentListPopup_T02_Info_Sub(pucPartDocumentListPopup_T02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucPartDocumentListPopup_T02_Info_Sub(ucPartDocumentListPopup_T02Entity pucPartDocumentListPopup_T02Entity)", pException);
            }
        }

        #endregion

        //#region 정보 저장 - ucPartDocumentListPopup_T02_Info_Save(ucPartDocumentListPopup_T02Entity pucPartDocumentListPopup_T02Entity, DataTable dt)

        ///// <summary>
        ///// 정보 저장
        ///// </summary>
        //public bool ucPartDocumentListPopup_T02_Info_Save(ucPartDocumentListPopup_T02Entity pucPartDocumentListPopup_T02Entity, DataTable dt)
        //{
        //    try
        //    {

        //        DataTable dtTemp = null;

        //        bool isChack = CoFAS_ConvertManager.DataTable_FindCount(dt, "CRUD IN ('C','U','D')", "");

        //        if (isChack)
        //        {
        //            dtTemp = CoFAS_ConvertManager.DataTable_FindValue(dt, "CRUD IN ('C','U','D')", ""); // 신규 and 수정 항목 데이터 테이블 화
        //        }

        //        using (DBManager pDBManager = new DBManager())
        //        {
        //            bool isReturn = new ucPartDocumentListPopup_T02Provider(pDBManager).ucPartDocumentListPopup_T02_Info_Save(pucPartDocumentListPopup_T02Entity, dtTemp);
        //            return isReturn;
        //        }
        //    }
        //    catch (ExceptionManager pExceptionManager)
        //    {
        //        throw pExceptionManager;
        //    }
        //    catch (Exception pException)
        //    {
        //        throw new ExceptionManager(this, "ucPartDocumentListPopup_T02_Info_Save(ucPartDocumentListPopup_T02Entity pucPartDocumentListPopup_T02Entity, DataTable dt)", pException);
        //    }
        //}

        //#endregion

        #region 언어 정보 저장 - Document_Info_Save(ucPartDocumentListPopup_T02Entity pucPartDocumentListPopup_T02Entity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Document_Info_Save(ucPartDocumentListPopup_T02Entity pDocumentInfoRegisterEntity, DataTable dt)
        {
            try
            {
                DataTable dtTemp = new DataTable();
                bool isReturn = true;

                bool isChack = CoFAS_ConvertManager.DataTable_FindCount(dt, "CRUD IN ('C','U','D')", "");

                if (isChack)
                {
                    dtTemp = CoFAS_ConvertManager.DataTable_FindValue(dt, "CRUD IN ('C','U','D')", ""); // 신규 and 수정 항목 데이터 테이블 화
                }

                if (dtTemp.Rows.Count > 0)
                {
                    using (DBManager pDBManager = new DBManager())
                    {
                        isReturn = new ucPartDocumentListPopup_T02Provider(pDBManager).Document_Info_Save(pDocumentInfoRegisterEntity, dtTemp);
                        return isReturn;
                    }
                }
                else
                {
                    return isReturn;
                }

            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Document_Info_Save(DocumentInfoRegisterEntity pDocumentInfoRegisterEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region OPENBUTTON으로 파일,파일명 삭제 - Document_File_Delete(ucPartDocumentListPopup_T02Entity pucPartDocumentListPopup_T02Entity)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Document_File_Delete(ucPartDocumentListPopup_T02Entity pucPartDocumentListPopup_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ucPartDocumentListPopup_T02Provider(pDBManager).Document_File_Delete(pucPartDocumentListPopup_T02Entity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Document_File_Delete(DocumentInfoRegisterEntity pDocumentInfoRegisterEntity)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ucPartDocumentListPopup_T02Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                ucPartDocumentListPopup_T02Entity pucPartDocumentListPopup_T02Entity = new ucPartDocumentListPopup_T02Provider(null).GetEntity(pDataRow);
                return pucPartDocumentListPopup_T02Entity;
            }
            catch (Exception pException)
            {
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


    public class ucBOM_SpendQtyCalcPopBusiness
    {
        public DataSet ucBOM_SpendQtyCalcPop_Main_Return(string pCRUD, string pDATE_FROM, string pDATE_TO, string pPART_TYPE, string pPART_CODE, string pPART_NAME, string pVEND_CODE, string pVEND_NAME, string pLANGUAGE_TYPE)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataSet pDataTableSet = new ucBOM_SpendQtyCalcPopProvider(pDBManager).ucBOM_SpendQtyCalcPop_Main_Return(pCRUD, pDATE_FROM, pDATE_TO, pPART_TYPE, pPART_CODE, pPART_NAME, pVEND_CODE, pVEND_NAME, pLANGUAGE_TYPE);
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
        public DataTable VendCost_Sub_Return(string pCRUD, string pCONTRACT_ID, string pPART_CODE, string pPART_TYPE, string pLANGUAGE_TYPE, decimal pQTY)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucBOM_SpendQtyCalcPopProvider(pDBManager).ucBOM_SpendQtyCalcPop_Sub_Return(pCRUD, pCONTRACT_ID, pPART_CODE, pPART_TYPE, pLANGUAGE_TYPE, pQTY);
                    return pDataTable;
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
        //체크한 수주에 대한 bom 계산_개별
        public DataTable VendCost_Sub_Return(ucBOM_SpendQtyCalcPopEntity _ucBOM_SpendQtyCalcPopEntity, DataTable dt)
        {
            try
            {
                DataTable dtTemp = null;

                //bool isChack = CoFAS_ConvertManager.DataTable_FindCount(dt, "CRUD IN ('C','U','D')", "");
                bool isChack = CoFAS_ConvertManager.DataTable_FindCount(dt, "CRUD IN ('Y')", "");

                if (isChack)
                {
                    dtTemp = CoFAS_ConvertManager.DataTable_FindValue(dt, "CRUD IN ('Y')", ""); // 신규 and 수정 항목 데이터 테이블 화
                }

                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucBOM_SpendQtyCalcPopProvider(pDBManager).ucBOM_SpendQtyCalcPop_Sub_Return(_ucBOM_SpendQtyCalcPopEntity, dt);
                    return pDataTable;
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
        public DataTable VendCost_Sub_Return_T02(MaterialOrderRegister_T02Entity _MaterialOrderRegister_T02Entity, DataTable dt)
        {
            try
            {
                DataTable dtTemp = null;

                //bool isChack = CoFAS_ConvertManager.DataTable_FindCount(dt, "CRUD IN ('C','U','D')", "");
                bool isChack = CoFAS_ConvertManager.DataTable_FindCount(dt, "CRUD IN ('Y')", "");

                if (isChack)
                {
                    dtTemp = CoFAS_ConvertManager.DataTable_FindValue(dt, "CRUD IN ('Y')", ""); // 신규 and 수정 항목 데이터 테이블 화
                }

                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialOrderRegister_T02Provider(pDBManager).MaterialOrderRegister_T02_Sub_Return(_MaterialOrderRegister_T02Entity, dt);
                    return pDataTable;
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
        //체크한 수주에 대한 bom 계산_통합
        public DataTable VendCost_Sub_Return2(ucBOM_SpendQtyCalcPopEntity _ucBOM_SpendQtyCalcPopEntity, DataTable dt)
        {
            try
            {
                DataTable dtTemp = null;

                //bool isChack = CoFAS_ConvertManager.DataTable_FindCount(dt, "CRUD IN ('C','U','D')", "");
                bool isChack = CoFAS_ConvertManager.DataTable_FindCount(dt, "CRUD IN ('Y')", "");

                if (isChack)
                {
                    dtTemp = CoFAS_ConvertManager.DataTable_FindValue(dt, "CRUD IN ('Y')", ""); // 신규 and 수정 항목 데이터 테이블 화
                }

                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucBOM_SpendQtyCalcPopProvider(pDBManager).ucBOM_SpendQtyCalcPop_Sub_Return2(_ucBOM_SpendQtyCalcPopEntity, dtTemp);
                    return pDataTable;
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
        //BOM으로 부자재 불량실적 등록
        public bool ucBOM_SpendQtyCalcPop_Save(ucBOM_SpendQtyCalcPopEntity _ucBOM_SpendQtyCalcPopEntity, DataTable dt)
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
                    bool isReturn = new ucBOM_SpendQtyCalcPopProvider(pDBManager).ucBOM_SpendQtyCalcPopInfo_Save(_ucBOM_SpendQtyCalcPopEntity, dtTemp);
                    return isReturn;
                }

            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucBOM_SpendQtyCalcPop_Save(ucBOM_SpendQtyCalcPopEntity _ucBOM_SpendQtyCalcPopEntity)", pException);
            }
        }
        //c체크 여부 업데이트
        public bool ucBOM_SpendQtyCalcPop_Save2(ucBOM_SpendQtyCalcPopEntity _ucBOM_SpendQtyCalcPopEntity, DataTable dt)
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
                    bool isReturn = new ucBOM_SpendQtyCalcPopProvider(pDBManager).ucBOM_SpendQtyCalcPopInfo_Save2(_ucBOM_SpendQtyCalcPopEntity, dtTemp);
                    return isReturn;
                }

            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucBOM_SpendQtyCalcPop_Save(ucBOM_SpendQtyCalcPopEntity _ucBOM_SpendQtyCalcPopEntity)", pException);
            }
        }
        public bool MaterialOrderRegister_T02_Save2(MaterialOrderRegister_T02Entity _MaterialOrderRegister_T02Entity, DataTable dt)
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
                    bool isReturn = new ucBOM_SpendQtyCalcPopProvider(pDBManager).MaterialOrderRegister_T02INFO_Save2(_MaterialOrderRegister_T02Entity, dtTemp);
                    return isReturn;
                }

            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucBOM_SpendQtyCalcPop_Save(ucBOM_SpendQtyCalcPopEntity _ucBOM_SpendQtyCalcPopEntity)", pException);
            }
        }
        public bool MaterialOrderRegister_T03_Save2(MaterialOrderRegister_T03Entity _MaterialOrderRegister_T03Entity, DataTable dt)
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
                    bool isReturn = new ucBOM_SpendQtyCalcPopProvider(pDBManager).MaterialOrderRegister_T03INFO_Save2(_MaterialOrderRegister_T03Entity, dtTemp);
                    return isReturn;
                }

            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucBOM_SpendQtyCalcPop_Save(ucBOM_SpendQtyCalcPopEntity _ucBOM_SpendQtyCalcPopEntity)", pException);
            }
        }
    }

    public class ucMaterialContractInfoPopupBusiness
    {
        #region 정보 조회 - ucMaterialContractInfoPopup_Info_Return(ucMaterialContractInfoPopupEntity pucMaterialContractInfoPopupEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ucMaterialContractInfoPopup_Info_Return(ucMaterialContractInfoPopupEntity pucMaterialContractInfoPopupEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucMaterialContractInfoPopupProvider(pDBManager).ucMaterialContractInfoPopup_Info_Return(pucMaterialContractInfoPopupEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucMaterialContractInfoPopup_Info_Return(ucMaterialContractInfoPopupEntity pucMaterialContractInfoPopupEntity)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ucMaterialContractInfoPopupEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ucMaterialContractInfoPopupEntity pucMaterialContractInfoPopupEntity = new ucMaterialContractInfoPopupProvider(null).GetEntity(pDataRow);
                return pucMaterialContractInfoPopupEntity;
            }
            catch (Exception pException)
            {
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

    public class ucMaterialPartListPopupBusiness
    {
        #region 정보 조회 - ucMaterialPartListPopup_Info_Return(ucMaterialPartListPopupEntity pucMaterialPartListPopupEntity)

        /// <summary>
        /// 정보 조회
        /// </summary>
        public DataTable ucMaterialPartListPopup_Info_Return(ucMaterialPartListPopupEntity pucMaterialPartListPopupEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucMaterialPartListPopupProvider(pDBManager).ucMaterialPartListPopup_Info_Return(pucMaterialPartListPopupEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucMaterialPartListPopup_Info_Return(ucMaterialPartListPopupEntity pucMaterialPartListPopupEntity)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ucMaterialPartListPopupEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ucMaterialPartListPopupEntity pucMaterialPartListPopupEntity = new ucMaterialPartListPopupProvider(null).GetEntity(pDataRow);
                return pucMaterialPartListPopupEntity;
            }
            catch (Exception pException)
            {
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

    public class ucMaterialPartListPopup_T01Business
    {
        #region 정보 조회 - ucMaterialPartListPopup_T01_Info_Return(ucMaterialPartListPopup_T01Entity pucMaterialPartListPopup_T01Entity)

        /// <summary>
        /// 정보 조회
        /// </summary>
        public DataTable ucMaterialPartListPopup_T01_Info_Return(ucMaterialPartListPopup_T01Entity pucMaterialPartListPopup_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucMaterialPartListPopup_T01Provider(pDBManager).ucMaterialPartListPopup_T01_Info_Return(pucMaterialPartListPopup_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucMaterialPartListPopup_T01_Info_Return(ucMaterialPartListPopup_T01Entity pucMaterialPartListPopup_T01Entity)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ucMaterialPartListPopup_T01Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                ucMaterialPartListPopup_T01Entity pucMaterialPartListPopupEntity = new ucMaterialPartListPopup_T01Provider(null).GetEntity(pDataRow);
                return pucMaterialPartListPopupEntity;
            }
            catch (Exception pException)
            {
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

    public class ucMaterialPartDocumentListPopupBusiness
    {
        #region 메인 정보 조회 - ucMaterialPartDocumentListPopup_Info_Main(ucMaterialPartDocumentListPopupEntity pucMaterialPartDocumentListPopupEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ucMaterialPartDocumentListPopup_Info_Main(ucMaterialPartDocumentListPopupEntity pucMaterialPartDocumentListPopupEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucMaterialPartDocumentListPopupProvider(pDBManager).ucMaterialPartDocumentListPopup_Info_Main(pucMaterialPartDocumentListPopupEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucMaterialPartDocumentListPopup_Info_Main(ucMaterialPartDocumentListPopupEntity pucMaterialPartDocumentListPopupEntity)", pException);
            }
        }

        #endregion

        #region 서브 정보 조회 - ucMaterialPartDocumentListPopup_Info_Sub(ucMaterialPartDocumentListPopupEntity pucMaterialPartDocumentListPopupEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ucMaterialPartDocumentListPopup_Info_Sub(ucMaterialPartDocumentListPopupEntity pucMaterialPartDocumentListPopupEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucMaterialPartDocumentListPopupProvider(pDBManager).ucMaterialPartDocumentListPopup_Info_Sub(pucMaterialPartDocumentListPopupEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucMaterialPartDocumentListPopup_Info_Sub(ucMaterialPartDocumentListPopupEntity pucMaterialPartDocumentListPopupEntity)", pException);
            }
        }

        #endregion

        #region 정보 저장 - ucMaterialPartDocumentListPopup_Info_Save(ucMaterialPartDocumentListPopupEntity pucMaterialPartDocumentListPopupEntity, DataTable dt)

        /// <summary>
        /// 정보 저장
        /// </summary>
        public bool ucMaterialPartDocumentListPopup_Info_Save(ucMaterialPartDocumentListPopupEntity pucMaterialPartDocumentListPopupEntity, DataTable dt)
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
                    bool isReturn = new ucMaterialPartDocumentListPopupProvider(pDBManager).ucMaterialPartDocumentListPopup_Info_Save(pucMaterialPartDocumentListPopupEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucMaterialPartDocumentListPopup_Info_Save(ucMaterialPartDocumentListPopupEntity pucMaterialPartDocumentListPopupEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ucMaterialPartDocumentListPopupEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ucMaterialPartDocumentListPopupEntity pucMaterialPartDocumentListPopupEntity = new ucMaterialPartDocumentListPopupProvider(null).GetEntity(pDataRow);
                return pucMaterialPartDocumentListPopupEntity;
            }
            catch (Exception pException)
            {
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

    public class WasherTruckRegisterBusiness
    {
        #region 마스터 정보 조회 - WasherTruckRegister_Info(WasherTruckRegisterEntity pWasherTruckRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable WasherTruckRegister_Info(WasherTruckRegisterEntity pWasherTruckRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WasherTruckRegisterProvider(pDBManager).WasherTruckRegister_Info_Mst(pWasherTruckRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "WasherTruckRegister_Info(WasherTruckRegisterEntity pWasherTruckRegisterEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(WasherTruckRegisterEntity pWasherTruckRegisterEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool WasherTruckRegister_Info_Save(WasherTruckRegisterEntity pWasherTruckRegisterEntity)
        {
            try
            {

                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new WasherTruckRegisterProvider(pDBManager).WasherTruckRegister_Info_Save(pWasherTruckRegisterEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(ProductOutRegisterEntity pWasherTruckRegisterEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public WasherTruckRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                WasherTruckRegisterEntity pWasherTruckRegisterEntity = new WasherTruckRegisterProvider(null).GetEntity(pDataRow);
                return pWasherTruckRegisterEntity;
            }
            catch (Exception pException)
            {
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

    public class WasherInformationRegisterBusiness
    {
        #region 마스터 정보 조회 - WasherInformationRegister_Info(WasherInformationRegisterEntity pWasherInformationRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable WasherInformationRegister_Info(WasherInformationRegisterEntity pWasherInformationRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WasherInformationRegisterProvider(pDBManager).WasherInformationRegister_Info_Mst(pWasherInformationRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "WasherInformationRegister_Info(WasherInformationRegisterEntity pWasherInformationRegisterEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(WasherInformationRegisterEntity pWasherInformationRegisterEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool WasherInformationRegister_Info_Save(WasherInformationRegisterEntity pWasherInformationRegisterEntity)
        {
            try
            {

                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new WasherInformationRegisterProvider(pDBManager).WasherInformationRegister_Info_Save(pWasherInformationRegisterEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(ProductOutRegisterEntity pWasherInformationRegisterEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public WasherInformationRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                WasherInformationRegisterEntity pWasherInformationRegisterEntity = new WasherInformationRegisterProvider(null).GetEntity(pDataRow);
                return pWasherInformationRegisterEntity;
            }
            catch (Exception pException)
            {
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

    public class WasherInRegisterBusiness
    {

        #region 마스터 정보 조회 - Material_In_Mst(WasherInRegisterEntity pWasherInRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Material_In_Mst(WasherInRegisterEntity pWasherInRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WasherInRegisterProvider(pDBManager).Material_In_Mst(pWasherInRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(WasherInRegisterEntity pWasherInRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(MaterialOrderStatusEntity pMaterialOrderStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        //public DataTable Sample_Info_Sub(WasherInRegisterEntity pWasherInRegisterEntity)
        //{
        //    try
        //    {
        //        using (DBManager pDBManager = new DBManager())
        //        {
        //            //DataTable pDataTable = new WasherInRegisterProvider(pDBManager).Sample_Info_Mst(pWasherInRegisterEntity);
        //            //return pDataTable;
        //        }
        //    }
        //    catch (ExceptionManager pExceptionManager)
        //    {
        //        throw pExceptionManager;
        //    }
        //    catch (Exception pException)
        //    {
        //        throw new ExceptionManager(this, "Sample_Info_Sub(WasherInRegisterEntity pWasherInRegisterEntity)", pException);
        //    }
        //}

        #endregion

        #region 그리드 정보 저장 - WasherInRegister_Info_Save(WasherInRegisterEntity pMaterialOrderStatusEntity, DataTable dt)
        public bool WasherInRegister_Info_Save(WasherInRegisterEntity pWasherInRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new WasherInRegisterProvider(pDBManager).WasherInRegister_Info_Save(pWasherInRegisterEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "WasherInRegister_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity)", pException);
            }
        }
        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public WasherInRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                WasherInRegisterEntity pWasherInRegisterEntity = new WasherInRegisterProvider(null).GetEntity(pDataRow);
                return pWasherInRegisterEntity;
            }
            catch (Exception pException)
            {
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

    public class WasherOutRegisterBusiness
    {

        #region 마스터 정보 조회 - Material_In_Mst(WasherOutRegisterEntity pWasherOutRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Material_In_Mst(WasherOutRegisterEntity pWasherOutRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WasherOutRegisterProvider(pDBManager).Material_In_Mst(pWasherOutRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(WasherOutRegisterEntity pWasherOutRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(MaterialOrderStatusEntity pMaterialOrderStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        //public DataTable Sample_Info_Sub(WasherOutRegisterEntity pWasherOutRegisterEntity)
        //{
        //    try
        //    {
        //        using (DBManager pDBManager = new DBManager())
        //        {
        //            //DataTable pDataTable = new WasherOutRegisterProvider(pDBManager).Sample_Info_Mst(pWasherOutRegisterEntity);
        //            //return pDataTable;
        //        }
        //    }
        //    catch (ExceptionManager pExceptionManager)
        //    {
        //        throw pExceptionManager;
        //    }
        //    catch (Exception pException)
        //    {
        //        throw new ExceptionManager(this, "Sample_Info_Sub(WasherOutRegisterEntity pWasherOutRegisterEntity)", pException);
        //    }
        //}

        #endregion

        #region 그리드 정보 저장 - WasherOutRegister_Info_Save(WasherOutRegisterEntity pMaterialOrderStatusEntity, DataTable dt)
        public bool WasherOutRegister_Info_Save(WasherOutRegisterEntity pWasherOutRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new WasherOutRegisterProvider(pDBManager).WasherOutRegister_Info_Save(pWasherOutRegisterEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "WasherOutRegister_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity)", pException);
            }
        }
        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public WasherOutRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                WasherOutRegisterEntity pWasherOutRegisterEntity = new WasherOutRegisterProvider(null).GetEntity(pDataRow);
                return pWasherOutRegisterEntity;
            }
            catch (Exception pException)
            {
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

    public class WasherStockStatusBusiness
    {
        #region 마스터 정보 조회 - Sample_Info(WasherStockStatusEntity pWasherStockStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(WasherStockStatusEntity pWasherStockStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WasherStockStatusProvider(pDBManager).Sample_Info_Mst(pWasherStockStatusEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(WasherStockStatusEntity pSampleRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(WasherStockStatusEntity pWasherStockStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(WasherStockStatusEntity pWasherStockStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WasherStockStatusProvider(pDBManager).Sample_Info_Mst(pWasherStockStatusEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(WasherStockStatusEntity pWasherStockStatusEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(WasherStockStatusEntity pWasherStockStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(WasherStockStatusEntity pWasherStockStatusEntity, DataTable dt)
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
                    bool isReturn = new WasherStockStatusProvider(pDBManager).Sample_Info_Save(pWasherStockStatusEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(WasherStockStatusEntity pWasherStockStatusEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable WasherStockStatus_Info_Filename(WasherStockStatusEntity pWasherStockStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WasherStockStatusProvider(pDBManager).WasherStockStatus_Info_Filename(pWasherStockStatusEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "WasherStockStatus_Info_Filename(WasherStockStatusEntity pWasherStockStatusEntity)", pException);
            }
        }

        #endregion

        #region XML파일 다운로드 - Templete_Download(WasherStockStatusEntity pWasherStockStatusEntity, string pMENU_NO, string pDSP_SORT)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public object Templete_Download(WasherStockStatusEntity pWasherStockStatusEntity, string pMENU_NO, string pDSP_SORT)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    object pObject = new WasherStockStatusProvider(pDBManager).Templete_Download(pWasherStockStatusEntity, pMENU_NO, pDSP_SORT);
                    return pObject;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "WasherStockStatusProvider(pDBManager).Templete_Download(pWasherStockStatusEntity, pMENU_NO, pDSP_SORT)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public WasherStockStatusEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                WasherStockStatusEntity pSampleRegisterEntity = new WasherStockStatusProvider(null).GetEntity(pDataRow);
                return pSampleRegisterEntity;
            }
            catch (Exception pException)
            {
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

    public class MaterialInformationRegister_T03Business
    {
        #region 마스터 정보 조회 - MaterialInformationRegister_T03_Info(MaterialInformationRegister_T03Entity pMaterialInformationRegister_T03Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable MaterialInformationRegister_T03_Info(MaterialInformationRegister_T03Entity pMaterialInformationRegister_T03Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialInformationRegister_T03Provider(pDBManager).MaterialInformationRegister_T03_Info_Mst(pMaterialInformationRegister_T03Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialInformationRegister_T03_Info(MaterialInformationRegister_T03Entity pMaterialInformationRegister_T03Entity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - MaterialInformationRegister_T03_Info_Sub(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable MaterialInformationRegister_T03_Info_Sub(MaterialInformationRegister_T03Entity pMaterialInformationRegister_T03Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialInformationRegister_T03Provider(pDBManager).MaterialInformationRegister_T03_Info_Sub(pMaterialInformationRegister_T03Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialInformationRegister_T03_Info_Sub(MaterialInformationRegister_T03Entity pMaterialInformationRegister_T03Entity))", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - MaterialInformationRegister_T03_Info_Save(MaterialInformationRegister_T03Entity pMaterialInformationRegister_T03Entity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool MaterialInformationRegister_T03_Info_Save(MaterialInformationRegister_T03Entity pMaterialInformationRegister_T03Entity, DataTable dt)
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
                    bool isReturn = new MaterialInformationRegister_T03Provider(pDBManager).MaterialInformationRegister_T03_Info_Save(pMaterialInformationRegister_T03Entity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialInformationRegister_T03_Info_Save(MaterialInformationRegister_T03Entity pMaterialInformationRegister_T03Entity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public MaterialInformationRegister_T03Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                MaterialInformationRegister_T03Entity pMaterialInformationRegister_T03Entity = new MaterialInformationRegister_T03Provider(null).GetEntity(pDataRow);
                return pMaterialInformationRegister_T03Entity;
            }
            catch (Exception pException)
            {
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

    public class MaterialOrderRegister_T01Business
    {
        public DataTable MaterialOrderRegister_T01_R10(MaterialOrderRegister_T01Entity pMaterialOrderRegister_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialOrderRegister_T01Provider(pDBManager).MaterialOrderRegister_T01_R10(pMaterialOrderRegister_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialOrderRegister_T01_R10(MaterialOrderRegister_T01Entity pMaterialOrderRegister_T01Entity)", pException);
            }
        }

        public DataTable MaterialOrderRegister_T01_R20(MaterialOrderRegister_T01Entity pMaterialOrderRegister_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialOrderRegister_T01Provider(pDBManager).MaterialOrderRegister_T01_R20(pMaterialOrderRegister_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MaterialOrderRegister_T01_R20(MaterialOrderRegister_T01Entity pMaterialOrderRegister_T01Entity)", pException);
            }
        }

        #region ○ 화면명에 맞는 엑셀파일 불러오기
        public DataTable Sheet_Info_Sheet(MaterialOrderRegister_T01Entity pMaterialOrderRegister_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialOrderRegister_T01Provider(pDBManager).Sheet_Info_sheet(pMaterialOrderRegister_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sheet_Info_Sheet(MaterialOrderRegister_T01Entity pMaterialOrderRegister_T01Entity)", pException);
            }
        }

        #endregion

        #region 바인딩 데이터 테이블 불러오기 - Sheet_Info_Sheet_Data(SheetInfoRegisterEntity pSheetInfoRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sheet_Info_Sheet_Data(MaterialOrderRegister_T01Entity pMaterialOrderRegister_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialOrderRegister_T01Provider(pDBManager).Sheet_Info_Sheet_Data(pMaterialOrderRegister_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sheet_Info_Sheet_Data(MaterialOrderRegister_T01Entity _pMaterialOrderRegister_T01Entity)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Filename(MaterialOrderRegister_T01Entity pSampleRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialOrderRegister_T01Provider(pDBManager).Sample_Info_Filename(pSampleRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)", pException);
            }
        }

        #endregion

        #region XML파일 다운로드 - MenuRegister_Templete_Download(MenuRegisterEntity pMenuRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public object Templete_Download(MaterialOrderRegister_T01Entity pSampleRegisterEntity, string pMENU_NO, string pDSP_SORT)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    object pObject = new MaterialOrderRegister_T01Provider(pDBManager).Templete_Download(pSampleRegisterEntity, pMENU_NO, pDSP_SORT);
                    return pObject;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MenuRegister_Templete_Download(pMENU_NO, pDSP_SORT, pCUR_FILE)", pException);
            }
        }

        #endregion

        #region 발주 정보 저장 -MaterialOrder_Info_Save(UserInformationEntity pUserInformationEntity)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool MaterialOrderRegister_T01_Info_Save(MaterialOrderRegister_T01Entity pUserInformationEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new MaterialOrderRegister_T01Provider(pDBManager).MaterialOrderRegister_T01_Info_Save(pUserInformationEntity);
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
    }

    public class frmRiskMaterialInfoRegisterBusiness
    {
        #region 마스터 정보 조회 - frmRiskMaterialInfoRegister_Info(frmRiskMaterialInfoRegisterEntity pfrmRiskMaterialInfoRegisterEntity)

        /// <summary>
        /// 프로세스 정보 조회
        /// </summary>
        public DataTable frmRiskMaterialInfoRegister_Info(frmRiskMaterialInfoRegisterEntity pfrmRiskMaterialInfoRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new frmRiskMaterialInfoRegisterProvider(pDBManager).frmRiskMaterialInfoRegister_Info(pfrmRiskMaterialInfoRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "frmRiskMaterialInfoRegister_Info(frmRiskMaterialInfoRegisterEntity pfrmRiskMaterialInfoRegisterEntity)", pException);
            }
        }

        #endregion

        #region 정보 저장 - frmRiskMaterialInfoRegister_Info_Save(frmRiskMaterialInfoRegisterEntity pfrmRiskMaterialInfoRegisterEntity)

        /// <summary>
        /// 정보 저장
        /// </summary>
        public bool frmRiskMaterialInfoRegister_Info_Save(frmRiskMaterialInfoRegisterEntity pfrmRiskMaterialInfoRegisterEntity)
        {
            try
            {

                DataTable dtTemp = null;

                //bool isChack = CoFAS_ConvertManager.DataTable_FindCount(dt, "CRUD IN ('C','U','D')", "");

                //if (isChack)
                //{
                //    dtTemp = CoFAS_ConvertManager.DataTable_FindValue(dt, "CRUD IN ('C','U','D')", ""); // 신규 and 수정 항목 데이터 테이블 화
                //}

                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new frmRiskMaterialInfoRegisterProvider(pDBManager).frmRiskMaterialInfoRegister_Info_Save(pfrmRiskMaterialInfoRegisterEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "frmRiskMaterialInfoRegister_Info_Save(frmRiskMaterialInfoRegisterEntity pfrmRiskMaterialInfoRegisterEntity)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public frmRiskMaterialInfoRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                frmRiskMaterialInfoRegisterEntity pfrmRiskMaterialInfoRegisterEntity = new frmRiskMaterialInfoRegisterProvider(null).GetEntity(pDataRow);
                return pfrmRiskMaterialInfoRegisterEntity;
            }
            catch (Exception pException)
            {
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
