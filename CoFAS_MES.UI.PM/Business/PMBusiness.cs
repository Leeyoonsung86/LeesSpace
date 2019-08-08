using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CoFAS_MES.UI.PM.Data;
using CoFAS_MES.UI.PM.Entity;

using CoFAS_MES.CORE.Entity;
using CoFAS_MES.CORE.Function;
using System.Data;

namespace CoFAS_MES.UI.PM.Business
{
    public class SampleRegisterBusiness
    {
        #region 마스터 정보 조회 - Sample_Info(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(SampleRegisterEntity pSampleRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new SampleRegisterProvider(pDBManager).Sample_Info_Mst(pSampleRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(SampleRegisterEntity pSampleRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(SampleRegisterEntity pSampleRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new SampleRegisterProvider(pDBManager).Sample_Info_Mst(pSampleRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(SampleRegisterEntity pSampleRegisterEntity))", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(SampleRegisterEntity pSampleRegisterEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(SampleRegisterEntity pSampleRegisterEntity, DataTable dt)
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
                    bool isReturn = new SampleRegisterProvider(pDBManager).Sample_Info_Save(pSampleRegisterEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(SampleRegisterEntity pSampleRegisterEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public SampleRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                SampleRegisterEntity pSampleRegisterEntity = new SampleRegisterProvider(null).GetEntity(pDataRow);
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
    public class ProductInRegisterBusiness
    {
        #region 마스터 정보 조회 - Sample_Info(ProductInRegisterEntity pProductInRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductInRegister_Info(ProductInRegisterEntity pProductInRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductInRegisterProvider(pDBManager).ProductInRegister_Info(pProductInRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(ProductInRegisterEntity pSampleRegisterEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(ProductInRegisterEntity pProductInRegisterEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool ProductInRegister_Info_Save(ProductInRegisterEntity pProductInRegisterEntity)
        {
            try
            {

                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ProductInRegisterProvider(pDBManager).ProductInRegister_Info_Save(pProductInRegisterEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(ProductOutRegisterEntity pProductInRegisterEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ProductInRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ProductInRegisterEntity pSampleRegisterEntity = new ProductInRegisterProvider(null).GetEntity(pDataRow);
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
    public class ProductInRegister_T02Business
    {
        #region 마스터 정보 조회 - Sample_Info(ProductInRegister_T02Entity pProductInRegister_T02Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductInRegister_T02_Info(ProductInRegister_T02Entity pProductInRegister_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductInRegister_T02Provider(pDBManager).ProductInRegister_T02_Info(pProductInRegister_T02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(ProductInRegister_T02Entity pSampleRegisterEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(ProductInRegister_T02Entity pProductInRegister_T02Entity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool ProductInRegister_T02_Info_Save(ProductInRegister_T02Entity pProductInRegister_T02Entity)
        {
            try
            {

                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ProductInRegister_T02Provider(pDBManager).ProductInRegister_T02_Info_Save(pProductInRegister_T02Entity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(ProductOutRegisterEntity pProductInRegister_T02Entity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 시험검사 정보 저장 -MaterialOrder_Request_Info_Save(UserInformationEntity pUserInformationEntity)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool ProductInRegister_T02_Info_Check_Save(ProductInRegister_T02Entity pProductInRegister_T02Entity, DataTable dt)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ProductInRegister_T02Provider(pDBManager).ProductInRegister_T02_Info_Check_Save(pProductInRegister_T02Entity, dt);
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
        public ProductInRegister_T02Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                ProductInRegister_T02Entity pSampleRegisterEntity = new ProductInRegister_T02Provider(null).GetEntity(pDataRow);
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
    public class ProductInRegister_T01Business
    {
        #region 마스터 정보 조회 - Sample_Info(ProductInRegister_T01Entity pProductInRegister_T01Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductInRegister_Info(ProductInRegister_T01Entity pProductInRegister_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductInRegister_T01Provider(pDBManager).ProductInRegister_Info(pProductInRegister_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, " ProductInRegister_Info(ProductInRegister_T01Entity pProductInRegister_T01Entity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(ProductInRegisterEntity pProductInRegisterEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool ProductInRegister_Info_Save(ProductInRegister_T01Entity pProductInRegister_T01Entity, DataTable dt)
        {
            try
            {

                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ProductInRegister_T01Provider(pDBManager).ProductInRegister_Info_Save(pProductInRegister_T01Entity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductInRegister_Info_Save(ProductInRegister_T01Entity pProductInRegister_T01Entity)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ProductInRegister_T01Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                ProductInRegister_T01Entity pSampleRegister_T01Entity = new ProductInRegister_T01Provider(null).GetEntity(pDataRow);
                return pSampleRegister_T01Entity;
            }
            catch (Exception pException)
            {
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
    public class ProductInRegister_T04Business
    {
        #region 마스터 정보 조회 - Sample_Info(ProductInRegister_T04Entity pProductInRegister_T04Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductInRegister_T04_Info(ProductInRegister_T04Entity pProductInRegister_T04Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductInRegister_T04Provider(pDBManager).ProductInRegister_T04_Info(pProductInRegister_T04Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(ProductInRegister_T04Entity pSampleRegisterEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(ProductInRegister_T04Entity pProductInRegister_T04Entity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool ProductInRegister_T04_Info_Save(ProductInRegister_T04Entity pProductInRegister_T04Entity)
        {
            try
            {

                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ProductInRegister_T04Provider(pDBManager).ProductInRegister_T04_Info_Save(pProductInRegister_T04Entity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(ProductOutRegisterEntity pProductInRegister_T04Entity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ProductInRegister_T04Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                ProductInRegister_T04Entity pSampleRegisterEntity = new ProductInRegister_T04Provider(null).GetEntity(pDataRow);
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
    public class ProductInRegister_T05Business
    {
        #region 마스터 정보 조회 - Sample_Info(ProductInRegister_T05Entity pProductInRegister_T05Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductInRegister_Info(ProductInRegister_T05Entity pProductInRegister_T05Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductInRegister_T05Provider(pDBManager).ProductInRegister_Info(pProductInRegister_T05Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(ProductInRegisterEntity pSampleRegisterEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(ProductInRegisterEntity pProductInRegisterEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool ProductInRegister_Info_Save(ProductInRegister_T05Entity pProductInRegister_T05Entity)
        {
            try
            {

                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ProductInRegister_T05Provider(pDBManager).ProductInRegister_Info_Save(pProductInRegister_T05Entity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(ProductOutRegisterEntity pProductInRegisterEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ProductInRegister_T05Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                ProductInRegister_T05Entity pSampleRegisterEntity = new ProductInRegister_T05Provider(null).GetEntity(pDataRow);
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

    #region o 자재재고현황_바이오세라
    public class ProductStockStatus_T05Business
    {
        #region 마스터 정보 조회 - Sample_Info(ProductStockStatus_T05Entity pProductStockStatus_T05Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(ProductStockStatus_T05Entity pProductStockStatus_T05Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductStockStatus_T05Provider(pDBManager).Sample_Info_Mst(pProductStockStatus_T05Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(ProductStockStatus_T05Entity pSampleRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(ProductStockStatus_T05Entity pProductStockStatus_T05Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(ProductStockStatus_T05Entity pProductStockStatus_T05Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductStockStatus_T05Provider(pDBManager).Sample_Info_Mst(pProductStockStatus_T05Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(ProductStockStatus_T05Entity pProductStockStatus_T05Entity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(ProductStockStatus_T05Entity pProductStockStatus_T05Entity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(ProductStockStatus_T05Entity pProductStockStatus_T05Entity, DataTable dt)
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
                    bool isReturn = new ProductStockStatus_T05Provider(pDBManager).Sample_Info_Save(pProductStockStatus_T05Entity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(ProductStockStatus_T05Entity pProductStockStatus_T05Entity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductStockStatus_T05_Info_Filename(ProductStockStatus_T05Entity pProductStockStatus_T05Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductStockStatus_T05Provider(pDBManager).ProductStockStatus_T05_Info_Filename(pProductStockStatus_T05Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductStockStatus_T05_Info_Filename(ProductStockStatus_T05Entity pProductStockStatus_T05Entity)", pException);
            }
        }

        #endregion

        #region XML파일 다운로드 - Templete_Download(ProductStockStatus_T05Entity pProductStockStatus_T05Entity, string pMENU_NO, string pDSP_SORT)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public object Templete_Download(ProductStockStatus_T05Entity pProductStockStatus_T05Entity, string pMENU_NO, string pDSP_SORT)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    object pObject = new ProductStockStatus_T05Provider(pDBManager).Templete_Download(pProductStockStatus_T05Entity, pMENU_NO, pDSP_SORT);
                    return pObject;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductStockStatus_T05Provider(pDBManager).Templete_Download(pProductStockStatus_T05Entity, pMENU_NO, pDSP_SORT)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ProductStockStatus_T05Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                ProductStockStatus_T05Entity pSampleRegisterEntity = new ProductStockStatus_T05Provider(null).GetEntity(pDataRow);
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
    #region o 반/완/부재고현황_HPNC
    public class ProductStockStatus_T01Business
    {
        #region 마스터 정보 조회 - Sample_Info(ProductStockStatus_T01Entity pProductStockStatus_T01Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(ProductStockStatus_T01Entity pProductStockStatus_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductStockStatus_T01Provider(pDBManager).Sample_Info_Mst(pProductStockStatus_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(ProductStockStatus_T01Entity pSampleRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(ProductStockStatus_T01Entity pProductStockStatus_T01Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(ProductStockStatus_T01Entity pProductStockStatus_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductStockStatus_T01Provider(pDBManager).Sample_Info_Mst(pProductStockStatus_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(ProductStockStatus_T01Entity pProductStockStatus_T01Entity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(ProductStockStatus_T01Entity pProductStockStatus_T01Entity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(ProductStockStatus_T01Entity pProductStockStatus_T01Entity, DataTable dt)
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
                    bool isReturn = new ProductStockStatus_T01Provider(pDBManager).Sample_Info_Save(pProductStockStatus_T01Entity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(ProductStockStatus_T01Entity pProductStockStatus_T01Entity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductStockStatus_T01_Info_Filename(ProductStockStatus_T01Entity pProductStockStatus_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductStockStatus_T01Provider(pDBManager).ProductStockStatus_T01_Info_Filename(pProductStockStatus_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductStockStatus_T01_Info_Filename(ProductStockStatus_T01Entity pProductStockStatus_T01Entity)", pException);
            }
        }

        #endregion

        #region XML파일 다운로드 - Templete_Download(ProductStockStatus_T01Entity pProductStockStatus_T01Entity, string pMENU_NO, string pDSP_SORT)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public object Templete_Download(ProductStockStatus_T01Entity pProductStockStatus_T01Entity, string pMENU_NO, string pDSP_SORT)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    object pObject = new ProductStockStatus_T01Provider(pDBManager).Templete_Download(pProductStockStatus_T01Entity, pMENU_NO, pDSP_SORT);
                    return pObject;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductStockStatus_T01Provider(pDBManager).Templete_Download(pProductStockStatus_T01Entity, pMENU_NO, pDSP_SORT)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ProductStockStatus_T01Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                ProductStockStatus_T01Entity pSampleRegisterEntity = new ProductStockStatus_T01Provider(null).GetEntity(pDataRow);
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
    public class ProductInStatusBusiness
    {
        #region 마스터 정보 조회 - Sample_Info(ProductInStatusEntity pProductInStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(ProductInStatusEntity pProductInStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductInStatusProvider(pDBManager).Sample_Info_Mst(pProductInStatusEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(ProductInStatusEntity pSampleRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(ProductInStatusEntity pProductInStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(ProductInStatusEntity pProductInStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductInStatusProvider(pDBManager).Sample_Info_Mst(pProductInStatusEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(ProductInStatusEntity pProductInStatusEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(ProductInStatusEntity pProductInStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(ProductInStatusEntity pProductInStatusEntity, DataTable dt)
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
                    bool isReturn = new ProductInStatusProvider(pDBManager).Sample_Info_Save(pProductInStatusEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(ProductInStatusEntity pProductInStatusEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ProductInStatusEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ProductInStatusEntity pSampleRegisterEntity = new ProductInStatusProvider(null).GetEntity(pDataRow);
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

        #region ○ 화면명에 맞는 엑셀파일 불러오기
        public DataTable Sheet_Info_Sheet(ProductInStatusEntity pProductInStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pdatatable = new ProductInStatusProvider(pDBManager).Sheet_Info_sheet(pProductInStatusEntity);
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
        //public DataTable Sheet_Info_Sheet_Data(ProductInStatusEntity pProductInStatusEntity)
        public DataSet Sheet_Info_Sheet_Data(ProductInStatusEntity pProductInStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    // DataTable pDataTable = new ProductInStatusProvider(pDBManager).Sheet_Info_Sheet_Data(pProductInStatusEntity);
                    DataSet pDataSet = new ProductInStatusProvider(pDBManager).Sheet_Info_Sheet_Data(pProductInStatusEntity);
                    return pDataSet;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sheet_Info_Sheet_Data(ProductInStatusEntity pProductInStatusEntity)", pException);
            }
        }

        #endregion
        #region 마스터 정보 조회 - Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)
        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductInStatus_Info_Filename(ProductInStatusEntity pProductInStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductInStatusProvider(pDBManager).ProductInStatus_Info_Filename(pProductInStatusEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductInStatus_Info_Filename(ProductInStatusEntity pProductInStatusEntity)", pException);
            }
        }

        #endregion
        #region XML파일 다운로드 - Templete_Download(ProductNotOutStatusEntity pProductNotOutStatusEntity, string pMENU_NO, string pDSP_SORT)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public object Templete_Download(ProductInStatusEntity pProductInStatusEntity, string pMENU_NO, string pDSP_SORT)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    object pObject = new ProductInStatusProvider(pDBManager).Templete_Download(pProductInStatusEntity, pMENU_NO, pDSP_SORT);
                    return pObject;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductInStatusProvider(pDBManager).Templete_Download(pProductInStatusEntity, pMENU_NO, pDSP_SORT)", pException);
            }
        }

        #endregion


    }

    public class ProductInOutStatus_T50Business
    {
        #region 마스터 정보 조회 - Sample_Info(ProductInOutStatus_T50Entity pProductInOutStatus_T50Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(ProductInOutStatus_T50Entity pProductInOutStatus_T50Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductInOutStatus_T50Provider(pDBManager).Sample_Info_Mst(pProductInOutStatus_T50Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(ProductInOutStatus_T50Entity pSampleRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(ProductInOutStatus_T50Entity pProductInOutStatus_T50Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(ProductInOutStatus_T50Entity pProductInOutStatus_T50Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductInOutStatus_T50Provider(pDBManager).Sample_Info_Mst(pProductInOutStatus_T50Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(ProductInOutStatus_T50Entity pProductInOutStatus_T50Entity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(ProductInOutStatus_T50Entity pProductInOutStatus_T50Entity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(ProductInOutStatus_T50Entity pProductInOutStatus_T50Entity, DataTable dt)
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
                    bool isReturn = new ProductInOutStatus_T50Provider(pDBManager).Sample_Info_Save(pProductInOutStatus_T50Entity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(ProductInOutStatus_T50Entity pProductInOutStatus_T50Entity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ProductInOutStatus_T50Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                ProductInOutStatus_T50Entity pSampleRegisterEntity = new ProductInOutStatus_T50Provider(null).GetEntity(pDataRow);
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

        #region ○ 화면명에 맞는 엑셀파일 불러오기
        public DataTable Sheet_Info_Sheet(ProductInOutStatus_T50Entity pProductInOutStatus_T50Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pdatatable = new ProductInOutStatus_T50Provider(pDBManager).Sheet_Info_sheet(pProductInOutStatus_T50Entity);
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
        //public DataTable Sheet_Info_Sheet_Data(ProductInOutStatus_T50Entity pProductInOutStatus_T50Entity)
        public DataSet Sheet_Info_Sheet_Data(ProductInOutStatus_T50Entity pProductInOutStatus_T50Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    // DataTable pDataTable = new ProductInOutStatus_T50Provider(pDBManager).Sheet_Info_Sheet_Data(pProductInOutStatus_T50Entity);
                    DataSet pDataSet = new ProductInOutStatus_T50Provider(pDBManager).Sheet_Info_Sheet_Data(pProductInOutStatus_T50Entity);
                    return pDataSet;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sheet_Info_Sheet_Data(ProductInOutStatus_T50Entity pProductInOutStatus_T50Entity)", pException);
            }
        }

        #endregion
        #region 마스터 정보 조회 - Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)
        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductInOutStatus_T50_Info_Filename(ProductInOutStatus_T50Entity pProductInOutStatus_T50Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductInOutStatus_T50Provider(pDBManager).ProductInOutStatus_T50_Info_Filename(pProductInOutStatus_T50Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductInOutStatus_T50_Info_Filename(ProductInOutStatus_T50Entity pProductInOutStatus_T50Entity)", pException);
            }
        }

        #endregion
        #region XML파일 다운로드 - Templete_Download(ProductNotOutStatusEntity pProductNotOutStatusEntity, string pMENU_NO, string pDSP_SORT)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public object Templete_Download(ProductInOutStatus_T50Entity pProductInOutStatus_T50Entity, string pMENU_NO, string pDSP_SORT)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    object pObject = new ProductInOutStatus_T50Provider(pDBManager).Templete_Download(pProductInOutStatus_T50Entity, pMENU_NO, pDSP_SORT);
                    return pObject;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductInOutStatus_T50Provider(pDBManager).Templete_Download(pProductInOutStatus_T50Entity, pMENU_NO, pDSP_SORT)", pException);
            }
        }

        #endregion


    }

    public class ProductInOutStatusBusiness
    {


        #region 메인 정보 조회 - Sample_Info_Sub(ProductInStatusEntity pProductInStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductInOut_Info(ProductInOutStatusEntity pProductInOutStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductInOutStatusProvider(pDBManager).ProductInOut_Info(pProductInOutStatusEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(ProductInStatusEntity pProductInStatusEntity)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ProductInOutStatusEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ProductInOutStatusEntity pProductInOutStatusEntity = new ProductInOutStatusProvider(null).GetEntity(pDataRow);
                return pProductInOutStatusEntity;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "GetEntity(pDataRow)",
                    pException
                );
            }
        }
        #endregion

        #region ○ 화면명에 맞는 엑셀파일 불러오기
        public DataTable Sheet_Info_Sheet(ProductInStatusEntity pProductInStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pdatatable = new ProductInStatusProvider(pDBManager).Sheet_Info_sheet(pProductInStatusEntity);
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




    }

    #region o 제품입출현황_리스트_YB (ProductInOutStatus_T01Business)
    public class ProductInOutStatus_T01Business
    {
        #region 마스터 정보 조회 - Sample_Info(ProductInOutStatus_T01Entity pProductInOutStatus_T01Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(ProductInOutStatus_T01Entity pProductInOutStatus_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductInOutStatus_T01Provider(pDBManager).Sample_Info_Mst(pProductInOutStatus_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(ProductInOutStatus_T01Entity pSampleRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(ProductInOutStatus_T01Entity pProductInOutStatus_T01Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(ProductInOutStatus_T01Entity pProductInOutStatus_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductInOutStatus_T01Provider(pDBManager).Sample_Info_Mst(pProductInOutStatus_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(ProductInOutStatus_T01Entity pProductInOutStatus_T01Entity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(ProductInOutStatus_T01Entity pProductInOutStatus_T01Entity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(ProductInOutStatus_T01Entity pProductInOutStatus_T01Entity, DataTable dt)
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
                    bool isReturn = new ProductInOutStatus_T01Provider(pDBManager).Sample_Info_Save(pProductInOutStatus_T01Entity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(ProductInOutStatus_T01Entity pProductInOutStatus_T01Entity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductInOutStatus_T01_Info_Filename(ProductInOutStatus_T01Entity pProductInOutStatus_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductInOutStatus_T01Provider(pDBManager).ProductInOutStatus_T01_Info_Filename(pProductInOutStatus_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductInOutStatus_T01_Info_Filename(ProductInOutStatus_T01Entity pProductInOutStatus_T01Entity)", pException);
            }
        }

        #endregion

        #region XML파일 다운로드 - Templete_Download(ProductInOutStatus_T01Entity pProductInOutStatus_T01Entity, string pMENU_NO, string pDSP_SORT)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public object Templete_Download(ProductInOutStatus_T01Entity pProductInOutStatus_T01Entity, string pMENU_NO, string pDSP_SORT)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    object pObject = new ProductInOutStatus_T01Provider(pDBManager).Templete_Download(pProductInOutStatus_T01Entity, pMENU_NO, pDSP_SORT);
                    return pObject;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductInOutStatus_T01Provider(pDBManager).Templete_Download(pProductInOutStatus_T01Entity, pMENU_NO, pDSP_SORT)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ProductInOutStatus_T01Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                ProductInOutStatus_T01Entity pSampleRegisterEntity = new ProductInOutStatus_T01Provider(null).GetEntity(pDataRow);
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

    #region o 제품입고현황_리스트_YB (ProductInStatus_T02Business)
    public class ProductInStatus_T02Business
    {
        #region 마스터 정보 조회 - Sample_Info(ProductInStatus_T02Entity pProductInStatus_T02Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(ProductInStatus_T02Entity pProductInStatus_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductInStatus_T02Provider(pDBManager).Sample_Info_Mst(pProductInStatus_T02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(ProductInStatus_T02Entity pSampleRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(ProductInStatus_T02Entity pProductInStatus_T02Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(ProductInStatus_T02Entity pProductInStatus_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductInStatus_T02Provider(pDBManager).Sample_Info_Mst(pProductInStatus_T02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(ProductInStatus_T02Entity pProductInStatus_T02Entity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(ProductInStatus_T02Entity pProductInStatus_T02Entity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(ProductInStatus_T02Entity pProductInStatus_T02Entity, DataTable dt)
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
                    bool isReturn = new ProductInStatus_T02Provider(pDBManager).Sample_Info_Save(pProductInStatus_T02Entity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(ProductInStatus_T02Entity pProductInStatus_T02Entity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductInStatus_T02_Info_Filename(ProductInStatus_T02Entity pProductInStatus_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductInStatus_T02Provider(pDBManager).ProductInStatus_T02_Info_Filename(pProductInStatus_T02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductInStatus_T02_Info_Filename(ProductInStatus_T02Entity pProductInStatus_T02Entity)", pException);
            }
        }

        #endregion

        #region XML파일 다운로드 - Templete_Download(ProductInStatus_T02Entity pProductInStatus_T02Entity, string pMENU_NO, string pDSP_SORT)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public object Templete_Download(ProductInStatus_T02Entity pProductInStatus_T02Entity, string pMENU_NO, string pDSP_SORT)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    object pObject = new ProductInStatus_T02Provider(pDBManager).Templete_Download(pProductInStatus_T02Entity, pMENU_NO, pDSP_SORT);
                    return pObject;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductInStatus_T02Provider(pDBManager).Templete_Download(pProductInStatus_T02Entity, pMENU_NO, pDSP_SORT)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ProductInStatus_T02Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                ProductInStatus_T02Entity pSampleRegisterEntity = new ProductInStatus_T02Provider(null).GetEntity(pDataRow);
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

    #region o 제품출고현황_리스트_YB (ProductOutStatus_T02Business)
    public class ProductOutStatus_T02Business
    {
        #region 마스터 정보 조회 - Sample_Info(ProductOutStatus_T02Entity pProductOutStatus_T02Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(ProductOutStatus_T02Entity pProductOutStatus_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductOutStatus_T02Provider(pDBManager).Sample_Info_Mst(pProductOutStatus_T02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(ProductOutStatus_T02Entity pSampleRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(ProductOutStatus_T02Entity pProductOutStatus_T02Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(ProductOutStatus_T02Entity pProductOutStatus_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductOutStatus_T02Provider(pDBManager).Sample_Info_Mst(pProductOutStatus_T02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(ProductOutStatus_T02Entity pProductOutStatus_T02Entity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(ProductOutStatus_T02Entity pProductOutStatus_T02Entity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(ProductOutStatus_T02Entity pProductOutStatus_T02Entity, DataTable dt)
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
                    bool isReturn = new ProductOutStatus_T02Provider(pDBManager).Sample_Info_Save(pProductOutStatus_T02Entity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(ProductOutStatus_T02Entity pProductOutStatus_T02Entity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductOutStatus_T02_Info_Filename(ProductOutStatus_T02Entity pProductOutStatus_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductOutStatus_T02Provider(pDBManager).ProductOutStatus_T02_Info_Filename(pProductOutStatus_T02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductOutStatus_T02_Info_Filename(ProductOutStatus_T02Entity pProductOutStatus_T02Entity)", pException);
            }
        }

        #endregion

        #region XML파일 다운로드 - Templete_Download(ProductOutStatus_T02Entity pProductOutStatus_T02Entity, string pMENU_NO, string pDSP_SORT)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public object Templete_Download(ProductOutStatus_T02Entity pProductOutStatus_T02Entity, string pMENU_NO, string pDSP_SORT)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    object pObject = new ProductOutStatus_T02Provider(pDBManager).Templete_Download(pProductOutStatus_T02Entity, pMENU_NO, pDSP_SORT);
                    return pObject;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductOutStatus_T02Provider(pDBManager).Templete_Download(pProductOutStatus_T02Entity, pMENU_NO, pDSP_SORT)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ProductOutStatus_T02Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                ProductOutStatus_T02Entity pSampleRegisterEntity = new ProductOutStatus_T02Provider(null).GetEntity(pDataRow);
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


    public class ProductOutRegisterBusiness
    {

        #region 마스터 정보 조회 - ProductOutRegister_Info(ProductOutRegisterEntity pProductOutRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductOutRegister_Info(ProductOutRegisterEntity pProductOutRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductOutRegisterProvider(pDBManager).ProductOutRegister_Info_Mst(pProductOutRegisterEntity);
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


        #region 그리드 정보 저장 - ProductOutRegister_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool ProductOutRegister_Info_Save(ProductOutRegisterEntity pProductOutRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ProductOutRegisterProvider(pDBManager).ProductOutRegister_Info_Save(pProductOutRegisterEntity);
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
        public ProductOutRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ProductOutRegisterEntity pProductOutRegisterEntity = new ProductOutRegisterProvider(null).GetEntity(pDataRow);
                return pProductOutRegisterEntity;
            }
            catch (Exception pException)
            {
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

    public class ProductOutRegister_T02Business
    {

        #region 마스터 정보 조회 - ProductOutRegister_Info(ProductOutRegister_T01Entity pProductOutRegister_T01Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductOutRegister_Info(ProductOutRegister_T02Entity pProductOutRegister_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductOutRegister_T02Provider(pDBManager).ProductOutRegister_Info_Mst(pProductOutRegister_T02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductOutRegister_Info(ProductOutRegister_T02Entity pProductOutRegister_T02Entity)", pException);
            }
        }

        #endregion


        #region 그리드 정보 저장 - ProductOutRegister_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool ProductOutRegister_Info_Save(ProductOutRegister_T02Entity pProductOutRegister_T02Entity, DataTable dt)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ProductOutRegister_T02Provider(pDBManager).ProductOutRegister_Info_Save(pProductOutRegister_T02Entity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductOutRegister_Info_Save(ProductOutRegister_T02Entity pProductOutRegister_T02Entity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ProductOutRegister_T02Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                ProductOutRegister_T02Entity pProductOutRegister_T01Entity = new ProductOutRegister_T02Provider(null).GetEntity(pDataRow);
                return pProductOutRegister_T01Entity;
            }
            catch (Exception pException)
            {
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

    public class ProductOutRegister_T03Business
    {

        #region ○ 화면명에 맞는 엑셀파일 불러오기
        public DataTable Sheet_Info_Sheet(ProductOutRegister_T03Entity pProductOutRegister_T03Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductOutRegister_T03Provider(pDBManager).Sheet_Info_sheet(pProductOutRegister_T03Entity);
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

        #region 마스터 정보 조회 - MaterialOutRegister_T01_Info(MaterialOutRegister_T01Entity pMaterialOutRegister_T01Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataSet Sheet_Info_Sheet_Data(ProductOutRegister_T03Entity pProductOutRegister_T03Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataSet pDataSet = new ProductOutRegister_T03Provider(pDBManager).Sheet_Info_Sheet_Data(pProductOutRegister_T03Entity);
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
        //#region 마스터 정보 조회 - Sample_Info(ProductOutRegister_T03Entity pProductOutRegister_T03Entity)

        ///// <summary>
        ///// 언어 정보 조회
        ///// </summary>
        //public DataTable Sample_Info(ProductOutRegister_T03Entity pProductOutRegister_T03Entity)
        //{
        //    try
        //    {
        //        using (DBManager pDBManager = new DBManager())
        //        {
        //            DataTable pDataTable = new ProductOutRegister_T03Provider(pDBManager).Sample_Info_Mst(pProductOutRegister_T03Entity);
        //            return pDataTable;
        //        }
        //    }
        //    catch (ExceptionManager pExceptionManager)
        //    {
        //        throw pExceptionManager;
        //    }
        //    catch (Exception pException)
        //    {
        //        throw new ExceptionManager(this, "Sample_Info(ProductOutRegister_T03Entity pProductOutRegister_T03Entity)", pException);
        //    }
        //}

        //#endregion

        #region 마스터 정보 조회 - ProductOutRegister_T03_Info(ProductOutRegister_T03Entity pProductOutRegister_T03Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductOutRegister_T03_Info(ProductOutRegister_T03Entity pProductOutRegister_T03Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductOutRegister_T03Provider(pDBManager).ProductOutRegister_T03_Info_Mst(pProductOutRegister_T03Entity);
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

        //#region 상세 정보 조회 - Sample_Info_Sub(ProductOutRegister_T03Entity pProductOutRegister_T03Entity)

        ///// <summary>
        ///// 언어 정보 조회
        ///// </summary>
        //public DataTable Sample_Info_Sub(ProductOutRegister_T03Entity pProductOutRegister_T03Entity)
        //{
        //    try
        //    {
        //        using (DBManager pDBManager = new DBManager())
        //        {
        //            DataTable pDataTable = new ProductOutRegister_T03Provider(pDBManager).Sample_Info_Mst(pProductOutRegister_T03Entity);
        //            return pDataTable;
        //        }
        //    }
        //    catch (ExceptionManager pExceptionManager)
        //    {
        //        throw pExceptionManager;
        //    }
        //    catch (Exception pException)
        //    {
        //        throw new ExceptionManager(this, "Sample_Info_Sub(ProductOutRegister_T03Entity pProductOutRegister_T03Entity)", pException);
        //    }
        //}

        //#endregion

        #region 그리드 정보 저장 - ProductOutRegister_T03_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool ProductOutRegister_T03_Info_Save(ProductOutRegister_T03Entity pProductOutRegister_T03Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ProductOutRegister_T03Provider(pDBManager).ProductOutRegister_T03_Info_Save(pProductOutRegister_T03Entity);
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

        //#region 그리드 정보 저장 - Sample_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)

        ///// <summary>
        ///// 언어 정보 저장
        ///// </summary>
        //public DataTable ProductOutRegister_T03_Info_Save(ProductOutRegister_T03Entity pProductOutRegister_T03Entity)
        //{
        //    try
        //    {

        //       //DataTable dtTemp = null;
        //       //
        //       //bool isChack = CoFAS_ConvertManager.DataTable_FindCount(dt, "CRUD IN ('C','U','D')", "");
        //       //
        //       //if (isChack)
        //       //{
        //       //    dtTemp = CoFAS_ConvertManager.DataTable_FindValue(dt, "CRUD IN ('C','U','D')", ""); // 신규 and 수정 항목 데이터 테이블 화
        //       //}

        //        using (DBManager pDBManager = new DBManager())
        //        {
        //            DataTable isReturn = new ProductOutRegister_T03Provider(pDBManager).ProductOutRegister_T03_Info_Save(pProductOutRegister_T03Entity);
        //            return isReturn;
        //        }
        //    }
        //    catch (ExceptionManager pExceptionManager)
        //    {
        //        throw pExceptionManager;
        //    }
        //    catch (Exception pException)
        //    {
        //        throw new ExceptionManager(this, "Sample_Info_Save(ProductOutRegister_T03Entity pProductOutRegister_T03Entity, DataTable dt)", pException);
        //    }
        //}

        //#endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ProductOutRegister_T03Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                ProductOutRegister_T03Entity pProductOutRegister_T03Entity = new ProductOutRegister_T03Provider(null).GetEntity(pDataRow);
                return pProductOutRegister_T03Entity;
            }
            catch (Exception pException)
            {
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
    public class ProductOutRegister_T05Business
    {

        #region 마스터 정보 조회 - ProductOutRegister_T05_Info(ProductOutRegister_T05Entity pProductOutRegister_T05Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductOutRegister_T05_Info(ProductOutRegister_T05Entity pProductOutRegister_T05Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductOutRegister_T05Provider(pDBManager).ProductOutRegister_T05_Info_Mst(pProductOutRegister_T05Entity);
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


        #region 그리드 정보 저장 - ProductOutRegister_T05_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool ProductOutRegister_T05_Info_Save(ProductOutRegister_T05Entity pProductOutRegister_T05Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ProductOutRegister_T05Provider(pDBManager).ProductOutRegister_T05_Info_Save(pProductOutRegister_T05Entity);
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
        #region 바코드 정보 조회 - BarcodeLabelPrint_Info(BarcodeLabelPrintEntity pBarcodeLabelPrintEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductOutRegister_T05_COM_Info(string _language_Type, string _terminal_code)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductOutRegister_T05Provider(pDBManager).ProductOutRegister_T05_COM_Info(_language_Type, _terminal_code);
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

        public DataTable ProductOutRegister_T05_COM_Info2(string _language_Type, string _terminal_code)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductOutRegister_T05Provider(pDBManager).ProductOutRegister_T05_COM_Info2(_language_Type, _terminal_code);
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

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ProductOutRegister_T05Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                ProductOutRegister_T05Entity pProductOutRegister_T05Entity = new ProductOutRegister_T05Provider(null).GetEntity(pDataRow);
                return pProductOutRegister_T05Entity;
            }
            catch (Exception pException)
            {
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

    public class ucProductionOrderInfoPopup_T06Business
    {
        public DataSet ucProductionOrderInfoPopup_T06_Select(ucProductionOrderInfoPopup_T06_Entity pucProductionOrderInfoPopup_T06_Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataSet pDataTableSet = new ucProductionOrderInfoPopup_T06Provider(pDBManager).ucProductionOrderInfoPopup_T06_Return(pucProductionOrderInfoPopup_T06_Entity);
                    return pDataTableSet;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucProductionOrderInfoPopup_T06_Select(ucProductionOrderInfoPopup_T06_Entity pucProductionOrderInfoPopup_T06_Entity)", pException);
            }
        }
    }

    public class ProductOutStatusBusiness
    {
        #region 마스터 정보 조회 - Sample_Info(ProductOutStatusEntity pProductOutStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(ProductOutStatusEntity pProductOutStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductOutStatusProvider(pDBManager).Sample_Info_Mst(pProductOutStatusEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(ProductOutStatusEntity pSampleRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(ProductOutStatusEntity pProductOutStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(ProductOutStatusEntity pProductOutStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductOutStatusProvider(pDBManager).Sample_Info_Mst(pProductOutStatusEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(ProductOutStatusEntity pProductOutStatusEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(ProductOutStatusEntity pProductOutStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(ProductOutStatusEntity pProductOutStatusEntity, DataTable dt)
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
                    bool isReturn = new ProductOutStatusProvider(pDBManager).Sample_Info_Save(pProductOutStatusEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(ProductOutStatusEntity pProductOutStatusEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ProductOutStatusEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ProductOutStatusEntity pSampleRegisterEntity = new ProductOutStatusProvider(null).GetEntity(pDataRow);
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
    public class ProductTrackingStatusBusiness
    {
        #region 마스터 정보 조회 - Sample_Info(ProductTrackingStatusEntity pProductTrackingStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(ProductTrackingStatusEntity pProductTrackingStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductTrackingStatusProvider(pDBManager).Sample_Info_Mst(pProductTrackingStatusEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(ProductTrackingStatusEntity pSampleRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(ProductTrackingStatusEntity pProductTrackingStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(ProductTrackingStatusEntity pProductTrackingStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductTrackingStatusProvider(pDBManager).Sample_Info_Mst(pProductTrackingStatusEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(ProductTrackingStatusEntity pProductTrackingStatusEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(ProductTrackingStatusEntity pProductTrackingStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(ProductTrackingStatusEntity pProductTrackingStatusEntity, DataTable dt)
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
                    bool isReturn = new ProductTrackingStatusProvider(pDBManager).Sample_Info_Save(pProductTrackingStatusEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(ProductTrackingStatusEntity pProductTrackingStatusEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ProductTrackingStatusEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ProductTrackingStatusEntity pSampleRegisterEntity = new ProductTrackingStatusProvider(null).GetEntity(pDataRow);
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
    public class ProductStockStatusBusiness
    {
        #region 마스터 정보 조회 - ProductStockStatus_Mst(ProductStockStatusEntity pProductStockStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductStockStatus_Mst(ProductStockStatusEntity pProductStockStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductStockStatusProvider(pDBManager).ProductStockStatus_Mst(pProductStockStatusEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductStockStatus_Mst(ProductStockStatusEntity pSampleRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(ProductStockStatusEntity pProductStockStatusEntity) - 사용x

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(ProductStockStatusEntity pProductStockStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductStockStatusProvider(pDBManager).ProductStockStatus_Mst(pProductStockStatusEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(ProductStockStatusEntity pProductStockStatusEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(ProductStockStatusEntity pProductStockStatusEntity, DataTable dt) - 사용X

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(ProductStockStatusEntity pProductStockStatusEntity, DataTable dt)
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
                    bool isReturn = new ProductStockStatusProvider(pDBManager).Sample_Info_Save(pProductStockStatusEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(ProductStockStatusEntity pProductStockStatusEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region ○ 화면명에 맞는 엑셀파일 불러오기
        public DataTable Sheet_Info_Sheet(ProductStockStatusEntity pProductStockStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pdatatable = new ProductStockStatusProvider(pDBManager).Sheet_Info_sheet(pProductStockStatusEntity);
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

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ProductStockStatusEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ProductStockStatusEntity pSampleRegisterEntity = new ProductStockStatusProvider(null).GetEntity(pDataRow);
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



        #region 마스터 정보 조회 - Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)
        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductStockStatus_Info_Filename(ProductStockStatusEntity pProductStockStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductStockStatusProvider(pDBManager).ProductStockStatus_Info_Filename(pProductStockStatusEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductStockStatus_Info_Filename(ProductStockStatusEntity pProductStockStatusEntity)", pException);
            }
        }

        #endregion
        #region XML파일 다운로드 - Templete_Download(ProductNotOutStatusEntity pProductNotOutStatusEntity, string pMENU_NO, string pDSP_SORT)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public object Templete_Download(ProductStockStatusEntity pProductStockStatusEntity, string pMENU_NO, string pDSP_SORT)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    object pObject = new ProductStockStatusProvider(pDBManager).Templete_Download(pProductStockStatusEntity, pMENU_NO, pDSP_SORT);
                    return pObject;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductStockStatusProvider(pDBManager).Templete_Download(pProductStockStatusEntity, pMENU_NO, pDSP_SORT)", pException);
            }
        }

        #endregion


    }

    public class ProductInformationRegisterBusiness
    {
        #region 마스터 정보 조회 - ProductInformationRegister_Info(ProductInformationRegisterEntity pProductInformationRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductInformationRegister_Info(ProductInformationRegisterEntity pProductInformationRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductInformationRegisterProvider(pDBManager).ProductInformationRegister_Info_Mst(pProductInformationRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductInformationRegister_Info(ProductInformationRegisterEntity pProductInformationRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - ProductInformationRegister_Info_Sub(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductInformationRegister_Info_Sub(ProductInformationRegisterEntity pProductInformationRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductInformationRegisterProvider(pDBManager).ProductInformationRegister_Info_Sub(pProductInformationRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductInformationRegister_Info_Sub(ProductInformationRegisterEntity pProductInformationRegisterEntity))", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - ProductInformationRegister_Info_Save(ProductInformationRegisterEntity pProductInformationRegisterEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool ProductInformationRegister_Info_Save(ProductInformationRegisterEntity pProductInformationRegisterEntity, DataTable dt)
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
                    bool isReturn = new ProductInformationRegisterProvider(pDBManager).ProductInformationRegister_Info_Save(pProductInformationRegisterEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductInformationRegister_Info_Save(ProductInformationRegisterEntity pProductInformationRegisterEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ProductInformationRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ProductInformationRegisterEntity pProductInformationRegisterEntity = new ProductInformationRegisterProvider(null).GetEntity(pDataRow);
                return pProductInformationRegisterEntity;
            }
            catch (Exception pException)
            {
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

    public class ProductInformationRegister_T03Business
    {
        #region 마스터 정보 조회 - ProductInformationRegister_T03_Info(ProductInformationRegister_T03Entity pProductInformationRegister_T03Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductInformationRegister_T03_Info(ProductInformationRegister_T03Entity pProductInformationRegister_T03Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductInformationRegister_T03Provider(pDBManager).ProductInformationRegister_T03_Info_Mst(pProductInformationRegister_T03Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductInformationRegister_T03_Info(ProductInformationRegister_T03Entity pProductInformationRegister_T03Entity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - ProductInformationRegister_T03_Info_Sub(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductInformationRegister_T03_Info_Sub(ProductInformationRegister_T03Entity pProductInformationRegister_T03Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductInformationRegister_T03Provider(pDBManager).ProductInformationRegister_T03_Info_Sub(pProductInformationRegister_T03Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductInformationRegister_T03_Info_Sub(ProductInformationRegister_T03Entity pProductInformationRegister_T03Entity))", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - ProductInformationRegister_T03_Info_Save(ProductInformationRegister_T03Entity pProductInformationRegister_T03Entity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool ProductInformationRegister_T03_Info_Save(ProductInformationRegister_T03Entity pProductInformationRegister_T03Entity, DataTable dt)
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
                    bool isReturn = new ProductInformationRegister_T03Provider(pDBManager).ProductInformationRegister_T03_Info_Save(pProductInformationRegister_T03Entity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductInformationRegister_T03_Info_Save(ProductInformationRegister_T03Entity pProductInformationRegister_T03Entity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ProductInformationRegister_T03Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                ProductInformationRegister_T03Entity pProductInformationRegister_T03Entity = new ProductInformationRegister_T03Provider(null).GetEntity(pDataRow);
                return pProductInformationRegister_T03Entity;
            }
            catch (Exception pException)
            {
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

    public class ProductInformationRegister_T01Business
    {
        #region 마스터 정보 조회 - ProductInformationRegister_T01_Info(ProductInformationRegister_T01Entity pProductInformationRegister_T01Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductInformationRegister_T01_Info(ProductInformationRegister_T01Entity pProductInformationRegister_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductInformationRegister_T01Provider(pDBManager).ProductInformationRegister_T01_Info_Mst(pProductInformationRegister_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductInformationRegister_T01_Info(ProductInformationRegister_T01Entity pProductInformationRegister_T01Entity)", pException);
            }
        }

        #endregion

        #region 상세 단가 정보 조회 - ProductInformationRegister_T01_Info_Sub(ProductInformationRegister_T01Entity pProductInformationRegister_T01Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductInformationRegister_T01_Info_Sub(ProductInformationRegister_T01Entity pProductInformationRegister_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductInformationRegister_T01Provider(pDBManager).ProductInformationRegister_T01_Info_Sub(pProductInformationRegister_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductInformationRegister_T01_Info_Sub(ProductInformationRegister_T01Entity pProductInformationRegister_T01Entity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - ProductInformationRegister_T01_Info_Save(ProductInformationRegister_T01Entity pProductInformationRegister_T01Entity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool ProductInformationRegister_T01_Info_Save(ProductInformationRegister_T01Entity pProductInformationRegister_T01Entity, DataTable dt)
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
                    bool isReturn = new ProductInformationRegister_T01Provider(pDBManager).ProductInformationRegister_T01_Info_Save(pProductInformationRegister_T01Entity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductInformationRegister_T01_Info_Save(ProductInformationRegister_T01Entity pProductInformationRegister_T01Entity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ProductInformationRegister_T01Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                ProductInformationRegister_T01Entity pProductInformationRegister_T01Entity = new ProductInformationRegister_T01Provider(null).GetEntity(pDataRow);
                return pProductInformationRegister_T01Entity;
            }
            catch (Exception pException)
            {
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
    public class ucSemiProductStockInfoPopupBusiness
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
                    DataSet pDataTableSet = new ucSemiProductStockInfoPopupProvider(pDBManager).ucInspectRequestInfo_Return(pCRUD, pPART_CODE, pPART_NAME);
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
        public bool ucSemiProductStockInfoPopup_Save(ucSemiProductStockInfoMaterialPopupEntity pucSemiProductStockInfoMaterialPopupEntity, DataTable dt)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ucSemiProductStockInfoPopupProvider(pDBManager).ucSemiProductStockInfoPopup_Save(pucSemiProductStockInfoMaterialPopupEntity, dt);
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

    public class ProductInformationRegister_T02Business
    {
        #region 마스터 정보 조회 - ProductInformationRegister_T02_Info(ProductInformationRegister_T02Entity pProductInformationRegister_T02Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductInformationRegister_T02_Info(ProductInformationRegister_T02Entity pProductInformationRegister_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductInformationRegister_T02Provider(pDBManager).ProductInformationRegister_T02_Info_Mst(pProductInformationRegister_T02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductInformationRegister_T02_Info(ProductInformationRegister_T02Entity pProductInformationRegister_T02Entity)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - ProductInformationRegister_T02_Info2(ProductInformationRegister_T02Entity pProductInformationRegister_T02Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductInformationRegister_T02_Info2(ProductInformationRegister_T02Entity pProductInformationRegister_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductInformationRegister_T02Provider(pDBManager).ProductInformationRegister_T02_Info2(pProductInformationRegister_T02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductInformationRegister_T02_Info2(ProductInformationRegister_T02Entity pProductInformationRegister_T02Entity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - ProductInformationRegister_T02_Info_Sub(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductInformationRegister_T02_Info_Sub(ProductInformationRegister_T02Entity pProductInformationRegister_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductInformationRegister_T02Provider(pDBManager).ProductInformationRegister_T02_Info_Sub(pProductInformationRegister_T02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductInformationRegister_T02_Info_Sub(ProductInformationRegister_T02Entity pProductInformationRegister_T02Entity))", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - ProductInformationRegister_T02_Info_Save(ProductInformationRegister_T02Entity pProductInformationRegister_T02Entity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool ProductInformationRegister_T02_Info_Save(ProductInformationRegister_T02Entity pProductInformationRegister_T02Entity, DataTable dt)
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
                    bool isReturn = new ProductInformationRegister_T02Provider(pDBManager).ProductInformationRegister_T02_Info_Save(pProductInformationRegister_T02Entity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductInformationRegister_T02_Info_Save(ProductInformationRegister_T02Entity pProductInformationRegister_T02Entity, DataTable dt)", pException);
            }
        }

        #endregion


        #region 그리드 정보 저장 - ProductInformationRegister_T02_Info_Save(ProductInformationRegister_T02Entity pProductInformationRegister_T02Entity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool ProductInformationRegister_T02_Info_Save2(ProductInformationRegister_T02Entity pProductInformationRegister_T02Entity, DataTable dt)
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
                    bool isReturn = new ProductInformationRegister_T02Provider(pDBManager).ProductInformationRegister_T02_Info_Save2(pProductInformationRegister_T02Entity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductInformationRegister_T02_Info_Save2(ProductInformationRegister_T02Entity pProductInformationRegister_T02Entity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ProductInformationRegister_T02Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                ProductInformationRegister_T02Entity pProductInformationRegister_T02Entity = new ProductInformationRegister_T02Provider(null).GetEntity(pDataRow);
                return pProductInformationRegister_T02Entity;
            }
            catch (Exception pException)
            {
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

    public class ProductInformationRegister_T06Business
    {
        #region 마스터 정보 조회 - ProductInformationRegister_T06_Info(ProductInformationRegister_T06Entity pProductInformationRegister_T06Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductInformationRegister_T06_Info(ProductInformationRegister_T06Entity pProductInformationRegister_T06Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductInformationRegister_T06Provider(pDBManager).ProductInformationRegister_T06_Info_Mst(pProductInformationRegister_T06Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductInformationRegister_T06_Info(ProductInformationRegister_T06Entity pProductInformationRegister_T06Entity)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - ProductInformationRegister_T06_Info2(ProductInformationRegister_T06Entity pProductInformationRegister_T06Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductInformationRegister_T06_Info2(ProductInformationRegister_T06Entity pProductInformationRegister_T06Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductInformationRegister_T06Provider(pDBManager).ProductInformationRegister_T06_Info2(pProductInformationRegister_T06Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductInformationRegister_T06_Info2(ProductInformationRegister_T06Entity pProductInformationRegister_T06Entity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - ProductInformationRegister_T06_Info_Sub(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductInformationRegister_T06_Info_Sub(ProductInformationRegister_T06Entity pProductInformationRegister_T06Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductInformationRegister_T06Provider(pDBManager).ProductInformationRegister_T06_Info_Sub(pProductInformationRegister_T06Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductInformationRegister_T06_Info_Sub(ProductInformationRegister_T06Entity pProductInformationRegister_T06Entity))", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - ProductInformationRegister_T06_Info_Save(ProductInformationRegister_T06Entity pProductInformationRegister_T06Entity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool ProductInformationRegister_T06_Info_Save(ProductInformationRegister_T06Entity pProductInformationRegister_T06Entity, DataTable dt)
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
                    bool isReturn = new ProductInformationRegister_T06Provider(pDBManager).ProductInformationRegister_T06_Info_Save(pProductInformationRegister_T06Entity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductInformationRegister_T06_Info_Save(ProductInformationRegister_T06Entity pProductInformationRegister_T06Entity, DataTable dt)", pException);
            }
        }

        #endregion


        #region 그리드 정보 저장 - ProductInformationRegister_T06_Info_Save(ProductInformationRegister_T06Entity pProductInformationRegister_T06Entity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool ProductInformationRegister_T06_Info_Save2(ProductInformationRegister_T06Entity pProductInformationRegister_T06Entity, DataTable dt)
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
                    bool isReturn = new ProductInformationRegister_T06Provider(pDBManager).ProductInformationRegister_T06_Info_Save2(pProductInformationRegister_T06Entity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductInformationRegister_T06_Info_Save2(ProductInformationRegister_T06Entity pProductInformationRegister_T06Entity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ProductInformationRegister_T06Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                ProductInformationRegister_T06Entity pProductInformationRegister_T06Entity = new ProductInformationRegister_T06Provider(null).GetEntity(pDataRow);
                return pProductInformationRegister_T06Entity;
            }
            catch (Exception pException)
            {
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

    public class ProductInformationRegister_T50Business
    {
        #region 마스터 정보 조회 - ProductInformationRegister_T50_Info(ProductInformationRegister_T50Entity pProductInformationRegister_T50Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductInformationRegister_T50_Info(ProductInformationRegister_T50Entity pProductInformationRegister_T50Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductInformationRegister_T50Provider(pDBManager).ProductInformationRegister_T50_Info_Mst(pProductInformationRegister_T50Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductInformationRegister_T50_Info(ProductInformationRegister_T50Entity pProductInformationRegister_T50Entity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - ProductInformationRegister_T50_Info_Sub(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductInformationRegister_T50_Info_Sub(ProductInformationRegister_T50Entity pProductInformationRegister_T50Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductInformationRegister_T50Provider(pDBManager).ProductInformationRegister_T50_Info_Sub(pProductInformationRegister_T50Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductInformationRegister_T50_Info_Sub(ProductInformationRegister_T50Entity pProductInformationRegister_T50Entity))", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - ProductInformationRegister_T50_Info_Save(ProductInformationRegister_T50Entity pProductInformationRegister_T50Entity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool ProductInformationRegister_T50_Info_Save(ProductInformationRegister_T50Entity pProductInformationRegister_T50Entity, DataTable dt)
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
                    bool isReturn = new ProductInformationRegister_T50Provider(pDBManager).ProductInformationRegister_T50_Info_Save(pProductInformationRegister_T50Entity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductInformationRegister_T50_Info_Save(ProductInformationRegister_T50Entity pProductInformationRegister_T50Entity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ProductInformationRegister_T50Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                ProductInformationRegister_T50Entity pProductInformationRegister_T50Entity = new ProductInformationRegister_T50Provider(null).GetEntity(pDataRow);
                return pProductInformationRegister_T50Entity;
            }
            catch (Exception pException)
            {
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

    public class ucVendCostInfoListPopupBusiness
    {
        #region 정보 조회 - ucVendCostInfoListPopup_Info_Return(ucVendCostInfoListPopupEntity pucVendCostInfoListPopupEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ucVendCostInfoListPopup_Info_Return(ucVendCostInfoListPopupEntity pucVendCostInfoListPopupEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucVendCostInfoListPopupProvider(pDBManager).ucVendCostInfoListPopup_Info_Return(pucVendCostInfoListPopupEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucVendCostInfoListPopup_Info_Return(ucVendCostInfoListPopupEntity pucVendCostInfoListPopupEntity)", pException);
            }
        }

        #endregion

        #region 정보 저장 - ucVendCostInfoListPopup_Info_Save(ucVendCostInfoListPopupEntity pucVendCostInfoListPopupEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool ucVendCostInfoListPopup_Info_Save(ucVendCostInfoListPopupEntity pucVendCostInfoListPopupEntity, DataTable dt)
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
                    bool isReturn = new ucVendCostInfoListPopupProvider(pDBManager).ucVendCostInfoListPopup_Info_Save(pucVendCostInfoListPopupEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucVendCostInfoListPopup_Info_Save(ucVendCostInfoListPopupEntity pucVendCostInfoListPopupEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ucVendCostInfoListPopupEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ucVendCostInfoListPopupEntity pucVendCostInfoListPopupEntity = new ucVendCostInfoListPopupProvider(null).GetEntity(pDataRow);
                return pucVendCostInfoListPopupEntity;
            }
            catch (Exception pException)
            {
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

    public class ucProductionPartListPopupBusiness
    {
        #region 정보 조회 - ucProductionPartListPopup_Info_Return(ucProductionPartListPopupEntity pucProductionPartListPopupEntity)

        /// <summary>
        /// 정보 조회
        /// </summary>
        public DataTable ucProductionPartListPopup_Info_Return(ucProductionPartListPopupEntity pucProductionPartListPopupEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucProductionPartListPopupProvider(pDBManager).ucProductionPartListPopup_Info_Return(pucProductionPartListPopupEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, " ucProductionPartListPopup_Info_Return(ucProductionPartListPopupEntity pucProductionPartListPopupEntity)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ucProductionPartListPopupEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ucProductionPartListPopupEntity pucProductionPartListPopupEntity = new ucProductionPartListPopupProvider(null).GetEntity(pDataRow);
                return pucProductionPartListPopupEntity;
            }
            catch (Exception pException)
            {
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

    public class ucContractInfoPopupBusiness
    {
        #region 정보 조회 - ucContractInfoPopup_Info_Return(ucContractInfoPopupEntity pucContractInfoPopupEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ucContractInfoPopup_Info_Return(ucContractInfoPopupEntity pucContractInfoPopupEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucContractInfoPopupProvider(pDBManager).ucContractInfoPopup_Info_Return(pucContractInfoPopupEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucContractInfoPopup_Info_Return(ucContractInfoPopupEntity pucContractInfoPopupEntity)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ucContractInfoPopupEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ucContractInfoPopupEntity pucContractInfoPopupEntity = new ucContractInfoPopupProvider(null).GetEntity(pDataRow);
                return pucContractInfoPopupEntity;
            }
            catch (Exception pException)
            {
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

    public class ucPartDocumentListPopup_T01Business
    {
        #region 메인 정보 조회 - ucPartDocumentListPopup_T01_Info_Main(ucPartDocumentListPopup_T01Entity pucPartDocumentListPopup_T01Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ucPartDocumentListPopup_T01_Info_Main(ucPartDocumentListPopup_T01Entity pucPartDocumentListPopup_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucPartDocumentListPopup_T01Provider(pDBManager).ucPartDocumentListPopup_T01_Info_Main(pucPartDocumentListPopup_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucPartDocumentListPopup_T01_Info_Main(ucPartDocumentListPopup_T01Entity pucPartDocumentListPopup_T01Entity)", pException);
            }
        }

        #endregion

        #region 서브 정보 조회 - ucPartDocumentListPopup_T01_Info_Sub(ucPartDocumentListPopup_T01Entity pucPartDocumentListPopup_T01Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ucPartDocumentListPopup_T01_Info_Sub(ucPartDocumentListPopup_T01Entity pucPartDocumentListPopup_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucPartDocumentListPopup_T01Provider(pDBManager).ucPartDocumentListPopup_T01_Info_Sub(pucPartDocumentListPopup_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucPartDocumentListPopup_T01_Info_Sub(ucPartDocumentListPopup_T01Entity pucPartDocumentListPopup_T01Entity)", pException);
            }
        }

        #endregion

        //#region 정보 저장 - ucPartDocumentListPopup_T01_Info_Save(ucPartDocumentListPopup_T01Entity pucPartDocumentListPopup_T01Entity, DataTable dt)

        ///// <summary>
        ///// 정보 저장
        ///// </summary>
        //public bool ucPartDocumentListPopup_T01_Info_Save(ucPartDocumentListPopup_T01Entity pucPartDocumentListPopup_T01Entity, DataTable dt)
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
        //            bool isReturn = new ucPartDocumentListPopup_T01Provider(pDBManager).ucPartDocumentListPopup_T01_Info_Save(pucPartDocumentListPopup_T01Entity, dtTemp);
        //            return isReturn;
        //        }
        //    }
        //    catch (ExceptionManager pExceptionManager)
        //    {
        //        throw pExceptionManager;
        //    }
        //    catch (Exception pException)
        //    {
        //        throw new ExceptionManager(this, "ucPartDocumentListPopup_T01_Info_Save(ucPartDocumentListPopup_T01Entity pucPartDocumentListPopup_T01Entity, DataTable dt)", pException);
        //    }
        //}

        //#endregion

        #region 언어 정보 저장 - Document_Info_Save(ucPartDocumentListPopup_T01Entity pucPartDocumentListPopup_T01Entity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Document_Info_Save(ucPartDocumentListPopup_T01Entity pDocumentInfoRegisterEntity, DataTable dt)
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
                        isReturn = new ucPartDocumentListPopup_T01Provider(pDBManager).Document_Info_Save(pDocumentInfoRegisterEntity, dtTemp);
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

        #region OPENBUTTON으로 파일,파일명 삭제 - Document_File_Delete(ucPartDocumentListPopup_T01Entity pucPartDocumentListPopup_T01Entity)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Document_File_Delete(ucPartDocumentListPopup_T01Entity pucPartDocumentListPopup_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ucPartDocumentListPopup_T01Provider(pDBManager).Document_File_Delete(pucPartDocumentListPopup_T01Entity);
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
        public ucPartDocumentListPopup_T01Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                ucPartDocumentListPopup_T01Entity pucPartDocumentListPopup_T01Entity = new ucPartDocumentListPopup_T01Provider(null).GetEntity(pDataRow);
                return pucPartDocumentListPopup_T01Entity;
            }
            catch (Exception pException)
            {
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


    public class ProductBOMRegisterBusiness
    {
        #region 마스터 정보 조회 - ProductBOMRegister_Info(ProductBOMRegisterEntity pProductBOMRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductBOMRegister_Info_Left(ProductBOMRegisterEntity pProductBOMRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductBOMRegisterProvider(pDBManager).ProductBOMRegister_Info_Left(pProductBOMRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_Info(ProductBOMRegisterEntity pProductBOMRegisterEntity)", pException);
            }
        }

        #endregion

        #region 트리리스트 BOM 정보 조회 - ProductBOMRegister_Info(ProductBOMRegisterEntity pProductBOMRegisterEntity)

        public DataTable ProductBOMRegister_Info_Main(ProductBOMRegisterEntity pProductBOMRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductBOMRegisterProvider(pDBManager).ProductBOMRegister_Info_Main(pProductBOMRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_Info_Main(ProductBOMRegisterEntity pProductBOMRegisterEntity)", pException);
            }
        }

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductBOMRegister_Info_BOM(ProductBOMRegisterEntity pProductBOMRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductBOMRegisterProvider(pDBManager).ProductBOMRegister_Info_BOM(pProductBOMRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_Info_BOM(ProductBOMRegisterEntity pProductBOMRegisterEntity)", pException);
            }
        }

        #endregion

        #region 트리리스트 BOM 신규 입력용 정보 조회 - ProductBOMRegister_Info(ProductBOMRegisterEntity pProductBOMRegisterEntity)

        /// <summary>
        /// 트리리스트 BOM 신규 입력용 정보 조회
        /// </summary>
        public DataTable ProductBOMRegister_Info_Main_Sub(ProductBOMRegisterEntity pProductBOMRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductBOMRegisterProvider(pDBManager).ProductBOMRegister_Info_Main_Sub(pProductBOMRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_Info_Main_Sub(ProductBOMRegisterEntity pProductBOMRegisterEntity)", pException);
            }
        }

        #endregion

        #region 구성 정보 조회 서브1 - ProductBOMRegister_Info_SUB01(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductBOMRegister_Info_SUB01(ProductBOMRegisterEntity pProductBOMRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductBOMRegisterProvider(pDBManager).ProductBOMRegister_Info_SUB01(pProductBOMRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_Info_SUB01(ProductBOMRegisterEntity pProductBOMRegisterEntity)", pException);
            }
        }

        #endregion

        #region 구성 정보 조회 서브2 - ProductBOMRegister_Info_SUB02(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductBOMRegister_Info_SUB02(ProductBOMRegisterEntity pProductBOMRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductBOMRegisterProvider(pDBManager).ProductBOMRegister_Info_SUB02(pProductBOMRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_Info_SUB02(ProductBOMRegisterEntity pProductBOMRegisterEntity)", pException);
            }
        }

        #endregion

        #region 구성 정보 조회 서브3 - ProductBOMRegister_Info_SUB03(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductBOMRegister_Info_SUB03(ProductBOMRegisterEntity pProductBOMRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductBOMRegisterProvider(pDBManager).ProductBOMRegister_Info_SUB03(pProductBOMRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_Info_SUB03(ProductBOMRegisterEntity pProductBOMRegisterEntity)", pException);
            }
        }

        #endregion

        #region 구성 정보 조회 서브4 - ProductBOMRegister_Info_SUB04(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductBOMRegister_Info_SUB04(ProductBOMRegisterEntity pProductBOMRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductBOMRegisterProvider(pDBManager).ProductBOMRegister_Info_SUB04(pProductBOMRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_Info_SUB04(ProductBOMRegisterEntity pProductBOMRegisterEntity)", pException);
            }
        }

        #endregion

        #region 구성 정보 조회 서브5 - ProductBOMRegister_Info_SUB05(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductBOMRegister_Info_SUB05(ProductBOMRegisterEntity pProductBOMRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductBOMRegisterProvider(pDBManager).ProductBOMRegister_Info_SUB05(pProductBOMRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_Info_SUB05(ProductBOMRegisterEntity pProductBOMRegisterEntity)", pException);
            }
        }

        #endregion


        #region 트리리스트 BOM 정보 조회 - ProductBOMRegister_Configuration_Info(ProductBOMRegisterEntity pProductBOMRegisterEntity)

        public DataTable ProductBOMRegister_Configuration_Info(ProductBOMRegisterEntity pProductBOMRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductBOMRegisterProvider(pDBManager).ProductBOMRegister_Configuration_Info(pProductBOMRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_Configuration_Info(ProductBOMRegisterEntity pProductBOMRegisterEntity)", pException);
            }
        }

        #endregion


        #region 정보 저장 - ProductBOMRegister_Info_Save(ProductBOMRegisterEntity pProductBOMRegisterEntity, DataTable dt)

        /// <summary>
        /// 정보 저장
        /// </summary>
        public bool ProductBOMRegister_Info_Save(ProductBOMRegisterEntity pProductBOMRegisterEntity, DataTable dt)
        {
            try
            {

               // DataTable dtTemp = null;
               //
               // bool isChack = CoFAS_ConvertManager.DataTable_FindCount(dt, "CRUD IN ('C','U','D')", "");
               //
               // if (isChack)
               // {
               //     dtTemp = CoFAS_ConvertManager.DataTable_FindValue(dt, "CRUD IN ('C','U','D')", ""); // 신규 and 수정 항목 데이터 테이블 화
               // }

                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = false;
                    if (pProductBOMRegisterEntity.CRUD == "U")
                    {
                        pProductBOMRegisterEntity.CRUD = "D";

                        isReturn = new ProductBOMRegisterProvider(pDBManager).ProductBOMRegister_Info_Delete(pProductBOMRegisterEntity, dt);

                        if(!isReturn)
                        {
                            pProductBOMRegisterEntity.CRUD = "U";

                            isReturn = new ProductBOMRegisterProvider(pDBManager).ProductBOMRegister_Info_Save(pProductBOMRegisterEntity,dt);
                        }
                    }
                    else
                    {
                        isReturn = new ProductBOMRegisterProvider(pDBManager).ProductBOMRegister_Info_Save(pProductBOMRegisterEntity, dt);
                    }

                    //bool isReturn = new ProductBOMRegisterProvider(pDBManager).ProductBOMRegister_Info_Save(pProductBOMRegisterEntity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_Info_Save(ProductBOMRegisterEntity pProductBOMRegisterEntity, DataTable dt)", pException);
            }
        }

        public bool ProductBOMRegister_Info_Enable(ProductBOMRegisterEntity pProductBOMRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ProductBOMRegisterProvider(pDBManager).ProductBOMRegister_Info_Enable(pProductBOMRegisterEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_Info_Delete(ProductBOMRegisterEntity pProductBOMRegisterEntity, DataTable dt)", pException);
            }
        }

        //중복검사
        public DataTable ProductBOMRegister_Info_Duplicate_chk(ProductBOMRegisterEntity pProductBOMRegisterEntity, DataTable dt)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductBOMRegisterProvider(pDBManager).ProductBOMRegister_Info_Duplicate_chk(pProductBOMRegisterEntity, dt);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_Info_Main(ProductBOMRegisterEntity pProductBOMRegisterEntity)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ProductBOMRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ProductBOMRegisterEntity pProductBOMRegisterEntity = new ProductBOMRegisterProvider(null).GetEntity(pDataRow);
                return pProductBOMRegisterEntity;
            }
            catch (Exception pException)
            {
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

    public class ProductBOMRegister_T01Business
    {
        #region 마스터 정보 조회 - ProductBOMRegister_T01_Info_Left(ProductBOMRegister_T01Entity pProductBOMRegister_T01Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductBOMRegister_T01_Info_Left(ProductBOMRegister_T01Entity pProductBOMRegister_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductBOMRegister_T01Provider(pDBManager).ProductBOMRegister_T01_Info_Left(pProductBOMRegister_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_T01_Info_Left(ProductBOMRegister_T01Entity pProductBOMRegister_T01Entity)", pException);
            }
        }

        #endregion

        #region BOM 정보 조회 - ProductBOMRegister_T01_Info_Mst(ProductBOMRegister_T01Entity pProductBOMRegister_T01Entity)

        public DataTable ProductBOMRegister_T01_Info_Mst(ProductBOMRegister_T01Entity pProductBOMRegister_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductBOMRegister_T01Provider(pDBManager).ProductBOMRegister_T01_Info_Mst(pProductBOMRegister_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_T01_Info_Mst(ProductBOMRegister_T01Entity pProductBOMRegister_T01Entity)", pException);
            }
        }

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductBOMRegister_T01_Info_Detail(ProductBOMRegister_T01Entity pProductBOMRegister_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductBOMRegister_T01Provider(pDBManager).ProductBOMRegister_T01_Info_Detail(pProductBOMRegister_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_T01_Info_Detail(ProductBOMRegister_T01Entity pProductBOMRegister_T01Entity)", pException);
            }
        }

        #endregion


        #region 정보 저장 - ProductBOMRegister_T01_Info_Save(ProductBOMRegister_T01Entity pProductBOMRegister_T01Entity, DataTable dt)

        /// <summary>
        /// 정보 저장
        /// </summary>
        public bool ProductBOMRegister_T01_Info_Save(ProductBOMRegister_T01Entity pProductBOMRegister_T01Entity, DataTable dt)
        {
            try
            {

                // DataTable dtTemp = null;
                //
                // bool isChack = CoFAS_ConvertManager.DataTable_FindCount(dt, "CRUD IN ('C','U','D')", "");
                //
                // if (isChack)
                // {
                //     dtTemp = CoFAS_ConvertManager.DataTable_FindValue(dt, "CRUD IN ('C','U','D')", ""); // 신규 and 수정 항목 데이터 테이블 화
                // }

                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = false;
                    if (pProductBOMRegister_T01Entity.CRUD == "U")
                    {
                        pProductBOMRegister_T01Entity.CRUD = "D";

                        isReturn = new ProductBOMRegister_T01Provider(pDBManager).ProductBOMRegister_T01_Info_Delete(pProductBOMRegister_T01Entity, dt);

                        if (!isReturn)
                        {
                            pProductBOMRegister_T01Entity.CRUD = "U";

                            isReturn = new ProductBOMRegister_T01Provider(pDBManager).ProductBOMRegister_T01_Info_Save(pProductBOMRegister_T01Entity, dt);
                        }
                    }
                    else
                    {
                        isReturn = new ProductBOMRegister_T01Provider(pDBManager).ProductBOMRegister_T01_Info_Save(pProductBOMRegister_T01Entity, dt);
                    }
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_T01_Info_Save(ProductBOMRegister_T01Entity pProductBOMRegister_T01Entity, DataTable dt)", pException);
            }
        }

        public bool ProductBOMRegister_T01_Info_Enable(ProductBOMRegister_T01Entity pProductBOMRegister_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ProductBOMRegister_T01Provider(pDBManager).ProductBOMRegister_T01_Info_Enable(pProductBOMRegister_T01Entity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_T01_Info_Enable(ProductBOMRegister_T01Entity pProductBOMRegister_T01Entity)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ProductBOMRegister_T01Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                ProductBOMRegister_T01Entity pProductBOMRegister_T01Entity = new ProductBOMRegister_T01Provider(null).GetEntity(pDataRow);
                return pProductBOMRegister_T01Entity;
            }
            catch (Exception pException)
            {
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
    public class ProductBOMRegister_T03Business
    {
        #region 마스터 정보 조회 - ProductBOMRegister_T03_Info(ProductBOMRegister_T03Entity pProductBOMRegister_T03Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductBOMRegister_T03_Info_Left(ProductBOMRegister_T03Entity pProductBOMRegister_T03Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductBOMRegister_T03Provider(pDBManager).ProductBOMRegister_T03_Info_Left(pProductBOMRegister_T03Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_T03_Info(ProductBOMRegister_T03Entity pProductBOMRegister_T03Entity)", pException);
            }
        }

        #endregion

        #region 트리리스트 BOM 정보 조회 - ProductBOMRegister_T03_Info(ProductBOMRegister_T03Entity pProductBOMRegister_T03Entity)

        public DataTable ProductBOMRegister_T03_Info_Main(ProductBOMRegister_T03Entity pProductBOMRegister_T03Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductBOMRegister_T03Provider(pDBManager).ProductBOMRegister_T03_Info_Main(pProductBOMRegister_T03Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_T03_Info_Main(ProductBOMRegister_T03Entity pProductBOMRegister_T03Entity)", pException);
            }
        }

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductBOMRegister_T03_Info_BOM(ProductBOMRegister_T03Entity pProductBOMRegister_T03Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductBOMRegister_T03Provider(pDBManager).ProductBOMRegister_T03_Info_BOM(pProductBOMRegister_T03Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_T03_Info_BOM(ProductBOMRegister_T03Entity pProductBOMRegister_T03Entity)", pException);
            }
        }

        #endregion

        #region 트리리스트 BOM 신규 입력용 정보 조회 - ProductBOMRegister_T03_Info(ProductBOMRegister_T03Entity pProductBOMRegister_T03Entity)

        /// <summary>
        /// 트리리스트 BOM 신규 입력용 정보 조회
        /// </summary>
        public DataTable ProductBOMRegister_T03_Info_Main_Sub(ProductBOMRegister_T03Entity pProductBOMRegister_T03Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductBOMRegister_T03Provider(pDBManager).ProductBOMRegister_T03_Info_Main_Sub(pProductBOMRegister_T03Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_T03_Info_Main_Sub(ProductBOMRegister_T03Entity pProductBOMRegister_T03Entity)", pException);
            }
        }

        #endregion

        #region 구성 정보 조회 서브1 - ProductBOMRegister_T03_Info_SUB01(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductBOMRegister_T03_Info_SUB01(ProductBOMRegister_T03Entity pProductBOMRegister_T03Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductBOMRegister_T03Provider(pDBManager).ProductBOMRegister_T03_Info_SUB01(pProductBOMRegister_T03Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_T03_Info_SUB01(ProductBOMRegister_T03Entity pProductBOMRegister_T03Entity)", pException);
            }
        }

        #endregion

        #region 구성 정보 조회 서브2 - ProductBOMRegister_T03_Info_SUB02(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductBOMRegister_T03_Info_SUB02(ProductBOMRegister_T03Entity pProductBOMRegister_T03Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductBOMRegister_T03Provider(pDBManager).ProductBOMRegister_T03_Info_SUB02(pProductBOMRegister_T03Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_T03_Info_SUB02(ProductBOMRegister_T03Entity pProductBOMRegister_T03Entity)", pException);
            }
        }

        #endregion

        #region 구성 정보 조회 서브3 - ProductBOMRegister_T03_Info_SUB03(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductBOMRegister_T03_Info_SUB03(ProductBOMRegister_T03Entity pProductBOMRegister_T03Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductBOMRegister_T03Provider(pDBManager).ProductBOMRegister_T03_Info_SUB03(pProductBOMRegister_T03Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_T03_Info_SUB03(ProductBOMRegister_T03Entity pProductBOMRegister_T03Entity)", pException);
            }
        }

        #endregion

        #region 구성 정보 조회 서브4 - ProductBOMRegister_T03_Info_SUB04(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductBOMRegister_T03_Info_SUB04(ProductBOMRegister_T03Entity pProductBOMRegister_T03Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductBOMRegister_T03Provider(pDBManager).ProductBOMRegister_T03_Info_SUB04(pProductBOMRegister_T03Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_T03_Info_SUB04(ProductBOMRegister_T03Entity pProductBOMRegister_T03Entity)", pException);
            }
        }

        #endregion

        #region 구성 정보 조회 서브5 - ProductBOMRegister_T03_Info_SUB05(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductBOMRegister_T03_Info_SUB05(ProductBOMRegister_T03Entity pProductBOMRegister_T03Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductBOMRegister_T03Provider(pDBManager).ProductBOMRegister_T03_Info_SUB05(pProductBOMRegister_T03Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_T03_Info_SUB05(ProductBOMRegister_T03Entity pProductBOMRegister_T03Entity)", pException);
            }
        }

        #endregion


        #region 트리리스트 BOM 정보 조회 - ProductBOMRegister_T03_Configuration_Info(ProductBOMRegister_T03Entity pProductBOMRegister_T03Entity)

        public DataTable ProductBOMRegister_T03_Configuration_Info(ProductBOMRegister_T03Entity pProductBOMRegister_T03Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductBOMRegister_T03Provider(pDBManager).ProductBOMRegister_T03_Configuration_Info(pProductBOMRegister_T03Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_T03_Configuration_Info(ProductBOMRegister_T03Entity pProductBOMRegister_T03Entity)", pException);
            }
        }

        #endregion


        #region 정보 저장 - ProductBOMRegister_T03_Info_Save(ProductBOMRegister_T03Entity pProductBOMRegister_T03Entity, DataTable dt)

        /// <summary>
        /// 정보 저장
        /// </summary>
        public bool ProductBOMRegister_T03_Info_Save(ProductBOMRegister_T03Entity pProductBOMRegister_T03Entity, DataTable dt)
        {
            try
            {

                // DataTable dtTemp = null;
                //
                // bool isChack = CoFAS_ConvertManager.DataTable_FindCount(dt, "CRUD IN ('C','U','D')", "");
                //
                // if (isChack)
                // {
                //     dtTemp = CoFAS_ConvertManager.DataTable_FindValue(dt, "CRUD IN ('C','U','D')", ""); // 신규 and 수정 항목 데이터 테이블 화
                // }

                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = false;
                    if (pProductBOMRegister_T03Entity.CRUD == "U")
                    {
                        pProductBOMRegister_T03Entity.CRUD = "D";

                        isReturn = new ProductBOMRegister_T03Provider(pDBManager).ProductBOMRegister_T03_Info_Delete(pProductBOMRegister_T03Entity, dt);

                        if (!isReturn)
                        {
                            pProductBOMRegister_T03Entity.CRUD = "U";

                            isReturn = new ProductBOMRegister_T03Provider(pDBManager).ProductBOMRegister_T03_Info_Save(pProductBOMRegister_T03Entity, dt);
                        }
                    }
                    else
                    {
                        pProductBOMRegister_T03Entity.CRUD = "D";

                        isReturn = new ProductBOMRegister_T03Provider(pDBManager).ProductBOMRegister_T03_Info_Delete(pProductBOMRegister_T03Entity, dt);

                        if (!isReturn)
                        {
                            pProductBOMRegister_T03Entity.CRUD = "C";

                            isReturn = new ProductBOMRegister_T03Provider(pDBManager).ProductBOMRegister_T03_Info_Save(pProductBOMRegister_T03Entity, dt);
                        }
                    }

                    //bool isReturn = new ProductBOMRegister_T03Provider(pDBManager).ProductBOMRegister_T03_Info_Save(pProductBOMRegister_T03Entity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_T03_Info_Save(ProductBOMRegister_T03Entity pProductBOMRegister_T03Entity, DataTable dt)", pException);
            }
        }

        public bool ProductBOMRegister_T03_Info_Enable(ProductBOMRegister_T03Entity pProductBOMRegister_T03Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ProductBOMRegister_T03Provider(pDBManager).ProductBOMRegister_T03_Info_Enable(pProductBOMRegister_T03Entity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_T03_Info_Delete(ProductBOMRegister_T03Entity pProductBOMRegister_T03Entity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ProductBOMRegister_T03Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                ProductBOMRegister_T03Entity pProductBOMRegister_T03Entity = new ProductBOMRegister_T03Provider(null).GetEntity(pDataRow);
                return pProductBOMRegister_T03Entity;
            }
            catch (Exception pException)
            {
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
    public class ProductBOMRegister_T04Business
    {
        #region 마스터 정보 조회 - ProductBOMRegister_T04_Info(ProductBOMRegister_T04Entity pProductBOMRegister_T04Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductBOMRegister_T04_Info_Left(ProductBOMRegister_T04Entity pProductBOMRegister_T04Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductBOMRegister_T04Provider(pDBManager).ProductBOMRegister_T04_Info_Left(pProductBOMRegister_T04Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_T04_Info(ProductBOMRegister_T04Entity pProductBOMRegister_T04Entity)", pException);
            }
        }

        #endregion

        #region 트리리스트 BOM 정보 조회 - ProductBOMRegister_T04_Info(ProductBOMRegister_T04Entity pProductBOMRegister_T04Entity)

        public DataTable ProductBOMRegister_T04_Info_Main(ProductBOMRegister_T04Entity pProductBOMRegister_T04Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductBOMRegister_T04Provider(pDBManager).ProductBOMRegister_T04_Info_Main(pProductBOMRegister_T04Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_T04_Info_Main(ProductBOMRegister_T04Entity pProductBOMRegister_T04Entity)", pException);
            }
        }

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductBOMRegister_T04_Info_BOM(ProductBOMRegister_T04Entity pProductBOMRegister_T04Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductBOMRegister_T04Provider(pDBManager).ProductBOMRegister_T04_Info_BOM(pProductBOMRegister_T04Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_T04_Info_BOM(ProductBOMRegister_T04Entity pProductBOMRegister_T04Entity)", pException);
            }
        }

        #endregion

        #region 트리리스트 BOM 신규 입력용 정보 조회 - ProductBOMRegister_T04_Info(ProductBOMRegister_T04Entity pProductBOMRegister_T04Entity)

        /// <summary>
        /// 트리리스트 BOM 신규 입력용 정보 조회
        /// </summary>
        public DataTable ProductBOMRegister_T04_Info_Main_Sub(ProductBOMRegister_T04Entity pProductBOMRegister_T04Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductBOMRegister_T04Provider(pDBManager).ProductBOMRegister_T04_Info_Main_Sub(pProductBOMRegister_T04Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_T04_Info_Main_Sub(ProductBOMRegister_T04Entity pProductBOMRegister_T04Entity)", pException);
            }
        }

        #endregion

        #region 구성 정보 조회 서브1 - ProductBOMRegister_T04_Info_SUB01(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductBOMRegister_T04_Info_SUB01(ProductBOMRegister_T04Entity pProductBOMRegister_T04Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductBOMRegister_T04Provider(pDBManager).ProductBOMRegister_T04_Info_SUB01(pProductBOMRegister_T04Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_T04_Info_SUB01(ProductBOMRegister_T04Entity pProductBOMRegister_T04Entity)", pException);
            }
        }

        #endregion

        #region 구성 정보 조회 서브2 - ProductBOMRegister_T04_Info_SUB02(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductBOMRegister_T04_Info_SUB02(ProductBOMRegister_T04Entity pProductBOMRegister_T04Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductBOMRegister_T04Provider(pDBManager).ProductBOMRegister_T04_Info_SUB02(pProductBOMRegister_T04Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_T04_Info_SUB02(ProductBOMRegister_T04Entity pProductBOMRegister_T04Entity)", pException);
            }
        }

        #endregion

        #region 구성 정보 조회 서브3 - ProductBOMRegister_T04_Info_SUB03(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductBOMRegister_T04_Info_SUB03(ProductBOMRegister_T04Entity pProductBOMRegister_T04Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductBOMRegister_T04Provider(pDBManager).ProductBOMRegister_T04_Info_SUB03(pProductBOMRegister_T04Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_T04_Info_SUB03(ProductBOMRegister_T04Entity pProductBOMRegister_T04Entity)", pException);
            }
        }

        #endregion

        #region 구성 정보 조회 서브4 - ProductBOMRegister_T04_Info_SUB04(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductBOMRegister_T04_Info_SUB04(ProductBOMRegister_T04Entity pProductBOMRegister_T04Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductBOMRegister_T04Provider(pDBManager).ProductBOMRegister_T04_Info_SUB04(pProductBOMRegister_T04Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_T04_Info_SUB04(ProductBOMRegister_T04Entity pProductBOMRegister_T04Entity)", pException);
            }
        }

        #endregion

        #region 구성 정보 조회 서브5 - ProductBOMRegister_T04_Info_SUB05(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductBOMRegister_T04_Info_SUB05(ProductBOMRegister_T04Entity pProductBOMRegister_T04Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductBOMRegister_T04Provider(pDBManager).ProductBOMRegister_T04_Info_SUB05(pProductBOMRegister_T04Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_T04_Info_SUB05(ProductBOMRegister_T04Entity pProductBOMRegister_T04Entity)", pException);
            }
        }

        #endregion


        #region 트리리스트 BOM 정보 조회 - ProductBOMRegister_T04_Configuration_Info(ProductBOMRegister_T04Entity pProductBOMRegister_T04Entity)

        public DataTable ProductBOMRegister_T04_Configuration_Info(ProductBOMRegister_T04Entity pProductBOMRegister_T04Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductBOMRegister_T04Provider(pDBManager).ProductBOMRegister_T04_Configuration_Info(pProductBOMRegister_T04Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_T04_Configuration_Info(ProductBOMRegister_T04Entity pProductBOMRegister_T04Entity)", pException);
            }
        }

        #endregion


        #region 정보 저장 - ProductBOMRegister_T04_Info_Save(ProductBOMRegister_T04Entity pProductBOMRegister_T04Entity, DataTable dt)

        /// <summary>
        /// 정보 저장
        /// </summary>
        public bool ProductBOMRegister_T04_Info_Save(ProductBOMRegister_T04Entity pProductBOMRegister_T04Entity, DataTable dt)
        {
            try
            {

                // DataTable dtTemp = null;
                //
                // bool isChack = CoFAS_ConvertManager.DataTable_FindCount(dt, "CRUD IN ('C','U','D')", "");
                //
                // if (isChack)
                // {
                //     dtTemp = CoFAS_ConvertManager.DataTable_FindValue(dt, "CRUD IN ('C','U','D')", ""); // 신규 and 수정 항목 데이터 테이블 화
                // }

                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = false;
                    if (pProductBOMRegister_T04Entity.CRUD == "U")
                    {
                        pProductBOMRegister_T04Entity.CRUD = "D";

                        isReturn = new ProductBOMRegister_T04Provider(pDBManager).ProductBOMRegister_T04_Info_Delete(pProductBOMRegister_T04Entity, dt);

                        if (!isReturn)
                        {
                            pProductBOMRegister_T04Entity.CRUD = "U";

                            isReturn = new ProductBOMRegister_T04Provider(pDBManager).ProductBOMRegister_T04_Info_Save(pProductBOMRegister_T04Entity, dt);
                        }
                    }
                    else
                    {
                        pProductBOMRegister_T04Entity.CRUD = "D";

                        isReturn = new ProductBOMRegister_T04Provider(pDBManager).ProductBOMRegister_T04_Info_Delete(pProductBOMRegister_T04Entity, dt);

                        if (!isReturn)
                        {
                            pProductBOMRegister_T04Entity.CRUD = "C";

                            isReturn = new ProductBOMRegister_T04Provider(pDBManager).ProductBOMRegister_T04_Info_Save(pProductBOMRegister_T04Entity, dt);
                        }
                    }

                    //bool isReturn = new ProductBOMRegister_T04Provider(pDBManager).ProductBOMRegister_T04_Info_Save(pProductBOMRegister_T04Entity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_T04_Info_Save(ProductBOMRegister_T04Entity pProductBOMRegister_T04Entity, DataTable dt)", pException);
            }
        }

        public bool ProductBOMRegister_T04_Info_Enable(ProductBOMRegister_T04Entity pProductBOMRegister_T04Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ProductBOMRegister_T04Provider(pDBManager).ProductBOMRegister_T04_Info_Enable(pProductBOMRegister_T04Entity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_T04_Info_Delete(ProductBOMRegister_T04Entity pProductBOMRegister_T04Entity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ProductBOMRegister_T04Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                ProductBOMRegister_T04Entity pProductBOMRegister_T04Entity = new ProductBOMRegister_T04Provider(null).GetEntity(pDataRow);
                return pProductBOMRegister_T04Entity;
            }
            catch (Exception pException)
            {
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

    public class ProductBOMRegister_T50Business
    {
        #region 마스터 정보 조회 - ProductBOMRegister_T50_Info(ProductBOMRegister_T50Entity pProductBOMRegister_T50Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductBOMRegister_T50_Info_Left(ProductBOMRegister_T50Entity pProductBOMRegister_T50Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductBOMRegister_T50Provider(pDBManager).ProductBOMRegister_T50_Info_Left(pProductBOMRegister_T50Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_T50_Info(ProductBOMRegister_T50Entity pProductBOMRegister_T50Entity)", pException);
            }
        }

        #endregion

        #region 트리리스트 BOM 정보 조회 - ProductBOMRegister_T50_Info(ProductBOMRegister_T50Entity pProductBOMRegister_T50Entity)

        public DataTable ProductBOMRegister_T50_Info_Main(ProductBOMRegister_T50Entity pProductBOMRegister_T50Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductBOMRegister_T50Provider(pDBManager).ProductBOMRegister_T50_Info_Main(pProductBOMRegister_T50Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_T50_Info_Main(ProductBOMRegister_T50Entity pProductBOMRegister_T50Entity)", pException);
            }
        }

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductBOMRegister_T50_Info_BOM(ProductBOMRegister_T50Entity pProductBOMRegister_T50Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductBOMRegister_T50Provider(pDBManager).ProductBOMRegister_T50_Info_BOM(pProductBOMRegister_T50Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_T50_Info_BOM(ProductBOMRegister_T50Entity pProductBOMRegister_T50Entity)", pException);
            }
        }

        #endregion

        #region 트리리스트 BOM 신규 입력용 정보 조회 - ProductBOMRegister_T50_Info(ProductBOMRegister_T50Entity pProductBOMRegister_T50Entity)

        /// <summary>
        /// 트리리스트 BOM 신규 입력용 정보 조회
        /// </summary>
        public DataTable ProductBOMRegister_T50_Info_Main_Sub(ProductBOMRegister_T50Entity pProductBOMRegister_T50Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductBOMRegister_T50Provider(pDBManager).ProductBOMRegister_T50_Info_Main_Sub(pProductBOMRegister_T50Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_T50_Info_Main_Sub(ProductBOMRegister_T50Entity pProductBOMRegister_T50Entity)", pException);
            }
        }

        #endregion

        #region 구성 정보 조회 서브1 - ProductBOMRegister_T50_Info_SUB01(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductBOMRegister_T50_Info_SUB01(ProductBOMRegister_T50Entity pProductBOMRegister_T50Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductBOMRegister_T50Provider(pDBManager).ProductBOMRegister_T50_Info_SUB01(pProductBOMRegister_T50Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_T50_Info_SUB01(ProductBOMRegister_T50Entity pProductBOMRegister_T50Entity)", pException);
            }
        }

        #endregion

        #region 구성 정보 조회 서브2 - ProductBOMRegister_T50_Info_SUB02(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductBOMRegister_T50_Info_SUB02(ProductBOMRegister_T50Entity pProductBOMRegister_T50Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductBOMRegister_T50Provider(pDBManager).ProductBOMRegister_T50_Info_SUB02(pProductBOMRegister_T50Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_T50_Info_SUB02(ProductBOMRegister_T50Entity pProductBOMRegister_T50Entity)", pException);
            }
        }

        #endregion

        #region 구성 정보 조회 서브3 - ProductBOMRegister_T50_Info_SUB03(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductBOMRegister_T50_Info_SUB03(ProductBOMRegister_T50Entity pProductBOMRegister_T50Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductBOMRegister_T50Provider(pDBManager).ProductBOMRegister_T50_Info_SUB03(pProductBOMRegister_T50Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_T50_Info_SUB03(ProductBOMRegister_T50Entity pProductBOMRegister_T50Entity)", pException);
            }
        }

        #endregion

        #region 구성 정보 조회 서브4 - ProductBOMRegister_T50_Info_SUB04(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductBOMRegister_T50_Info_SUB04(ProductBOMRegister_T50Entity pProductBOMRegister_T50Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductBOMRegister_T50Provider(pDBManager).ProductBOMRegister_T50_Info_SUB04(pProductBOMRegister_T50Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_T50_Info_SUB04(ProductBOMRegister_T50Entity pProductBOMRegister_T50Entity)", pException);
            }
        }

        #endregion

        #region 구성 정보 조회 서브5 - ProductBOMRegister_T50_Info_SUB05(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductBOMRegister_T50_Info_SUB05(ProductBOMRegister_T50Entity pProductBOMRegister_T50Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductBOMRegister_T50Provider(pDBManager).ProductBOMRegister_T50_Info_SUB05(pProductBOMRegister_T50Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_T50_Info_SUB05(ProductBOMRegister_T50Entity pProductBOMRegister_T50Entity)", pException);
            }
        }

        #endregion


        #region 트리리스트 BOM 정보 조회 - ProductBOMRegister_T50_Configuration_Info(ProductBOMRegister_T50Entity pProductBOMRegister_T50Entity)

        public DataTable ProductBOMRegister_T50_Configuration_Info(ProductBOMRegister_T50Entity pProductBOMRegister_T50Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductBOMRegister_T50Provider(pDBManager).ProductBOMRegister_T50_Configuration_Info(pProductBOMRegister_T50Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_T50_Configuration_Info(ProductBOMRegister_T50Entity pProductBOMRegister_T50Entity)", pException);
            }
        }

        #endregion


        #region 정보 저장 - ProductBOMRegister_T50_Info_Save(ProductBOMRegister_T50Entity pProductBOMRegister_T50Entity, DataTable dt)

        /// <summary>
        /// 정보 저장
        /// </summary>
        public bool ProductBOMRegister_T50_Info_Save(ProductBOMRegister_T50Entity pProductBOMRegister_T50Entity, DataTable dt)
        {
            try
            {

                // DataTable dtTemp = null;
                //
                // bool isChack = CoFAS_ConvertManager.DataTable_FindCount(dt, "CRUD IN ('C','U','D')", "");
                //
                // if (isChack)
                // {
                //     dtTemp = CoFAS_ConvertManager.DataTable_FindValue(dt, "CRUD IN ('C','U','D')", ""); // 신규 and 수정 항목 데이터 테이블 화
                // }

                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = false;
                    if (pProductBOMRegister_T50Entity.CRUD == "U")
                    {
                        pProductBOMRegister_T50Entity.CRUD = "D";

                        isReturn = new ProductBOMRegister_T50Provider(pDBManager).ProductBOMRegister_T50_Info_Delete(pProductBOMRegister_T50Entity, dt);

                        if (!isReturn)
                        {
                            pProductBOMRegister_T50Entity.CRUD = "U";

                            isReturn = new ProductBOMRegister_T50Provider(pDBManager).ProductBOMRegister_T50_Info_Save(pProductBOMRegister_T50Entity, dt);
                        }
                    }
                    else
                    {
                        isReturn = new ProductBOMRegister_T50Provider(pDBManager).ProductBOMRegister_T50_Info_Save(pProductBOMRegister_T50Entity, dt);
                    }

                    //bool isReturn = new ProductBOMRegister_T50Provider(pDBManager).ProductBOMRegister_T50_Info_Save(pProductBOMRegister_T50Entity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_T50_Info_Save(ProductBOMRegister_T50Entity pProductBOMRegister_T50Entity, DataTable dt)", pException);
            }
        }

        public bool ProductBOMRegister_T50_Info_Enable(ProductBOMRegister_T50Entity pProductBOMRegister_T50Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ProductBOMRegister_T50Provider(pDBManager).ProductBOMRegister_T50_Info_Enable(pProductBOMRegister_T50Entity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_T50_Info_Delete(ProductBOMRegister_T50Entity pProductBOMRegister_T50Entity, DataTable dt)", pException);
            }
        }

        //중복검사
        public DataTable ProductBOMRegister_T50_Info_Duplicate_chk(ProductBOMRegister_T50Entity pProductBOMRegister_T50Entity, DataTable dt)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductBOMRegister_T50Provider(pDBManager).ProductBOMRegister_T50_Info_Duplicate_chk(pProductBOMRegister_T50Entity, dt);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_T50_Info_Main(ProductBOMRegister_T50Entity pProductBOMRegister_T50Entity)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ProductBOMRegister_T50Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                ProductBOMRegister_T50Entity pProductBOMRegister_T50Entity = new ProductBOMRegister_T50Provider(null).GetEntity(pDataRow);
                return pProductBOMRegister_T50Entity;
            }
            catch (Exception pException)
            {
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

    public class ucProductStockInfoPopupBusiness
    {
        #region 반제품 선입선출 조회 

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public DataSet ucInspectRequestInfo_Return(string pCRUD, string pPART_CODE, string pPART_NAME)
        {
            try
            {

                using (DBManager pDBManager = new DBManager())
                {
                    DataSet pDataTableSet = new ucProductStockInfoPopupProvider(pDBManager).ucInspectRequestInfo_Return(pCRUD, pPART_CODE, pPART_NAME);
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
        #region 반제품 선입선출 접수 Insert - Mst

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool ucProductStockInfoPopup_Save(ucProductStockInfoPopupEntity pucProductStockInfoPopupEntity, DataTable dt)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ucProductStockInfoPopupProvider(pDBManager).ucProductStockInfoPopup_Save(pucProductStockInfoPopupEntity, dt);
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

    public class ProductBOMRegister_T02Business
    {
        #region 마스터 정보 조회 - ProductBOMRegister_T02_Info(ProductBOMRegister_T02Entity pProductBOMRegister_T02Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductBOMRegister_T02_Info_Left(ProductBOMRegister_T02Entity pProductBOMRegister_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductBOMRegister_T02Provider(pDBManager).ProductBOMRegister_T02_Info_Left(pProductBOMRegister_T02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_T02_Info(ProductBOMRegister_T02Entity pProductBOMRegister_T02Entity)", pException);
            }
        }

        #endregion

        #region 트리리스트 BOM 정보 조회 - ProductBOMRegister_T02_Info(ProductBOMRegister_T02Entity pProductBOMRegister_T02Entity)

        public DataTable ProductBOMRegister_T02_Info_Main(ProductBOMRegister_T02Entity pProductBOMRegister_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductBOMRegister_T02Provider(pDBManager).ProductBOMRegister_T02_Info_Main(pProductBOMRegister_T02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_T02_Info_Main(ProductBOMRegister_T02Entity pProductBOMRegister_T02Entity)", pException);
            }
        }

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductBOMRegister_T02_Info_BOM(ProductBOMRegister_T02Entity pProductBOMRegister_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductBOMRegister_T02Provider(pDBManager).ProductBOMRegister_T02_Info_BOM(pProductBOMRegister_T02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_T02_Info_BOM(ProductBOMRegister_T02Entity pProductBOMRegister_T02Entity)", pException);
            }
        }

        #endregion

        #region 트리리스트 BOM 신규 입력용 정보 조회 - ProductBOMRegister_T02_Info(ProductBOMRegister_T02Entity pProductBOMRegister_T02Entity)

        /// <summary>
        /// 트리리스트 BOM 신규 입력용 정보 조회
        /// </summary>
        public DataTable ProductBOMRegister_T02_Info_Main_Sub(ProductBOMRegister_T02Entity pProductBOMRegister_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductBOMRegister_T02Provider(pDBManager).ProductBOMRegister_T02_Info_Main_Sub(pProductBOMRegister_T02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_T02_Info_Main_Sub(ProductBOMRegister_T02Entity pProductBOMRegister_T02Entity)", pException);
            }
        }

        #endregion

        #region 구성 정보 조회 서브1 - ProductBOMRegister_T02_Info_SUB01(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductBOMRegister_T02_Info_SUB01(ProductBOMRegister_T02Entity pProductBOMRegister_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductBOMRegister_T02Provider(pDBManager).ProductBOMRegister_T02_Info_SUB01(pProductBOMRegister_T02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_T02_Info_SUB01(ProductBOMRegister_T02Entity pProductBOMRegister_T02Entity)", pException);
            }
        }

        #endregion

        #region 구성 정보 조회 서브2 - ProductBOMRegister_T02_Info_SUB02(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductBOMRegister_T02_Info_SUB02(ProductBOMRegister_T02Entity pProductBOMRegister_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductBOMRegister_T02Provider(pDBManager).ProductBOMRegister_T02_Info_SUB02(pProductBOMRegister_T02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_T02_Info_SUB02(ProductBOMRegister_T02Entity pProductBOMRegister_T02Entity)", pException);
            }
        }

        #endregion

        #region 구성 정보 조회 서브3 - ProductBOMRegister_T02_Info_SUB03(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductBOMRegister_T02_Info_SUB03(ProductBOMRegister_T02Entity pProductBOMRegister_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductBOMRegister_T02Provider(pDBManager).ProductBOMRegister_T02_Info_SUB03(pProductBOMRegister_T02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_T02_Info_SUB03(ProductBOMRegister_T02Entity pProductBOMRegister_T02Entity)", pException);
            }
        }

        #endregion

        #region 구성 정보 조회 서브4 - ProductBOMRegister_T02_Info_SUB04(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductBOMRegister_T02_Info_SUB04(ProductBOMRegister_T02Entity pProductBOMRegister_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductBOMRegister_T02Provider(pDBManager).ProductBOMRegister_T02_Info_SUB04(pProductBOMRegister_T02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_T02_Info_SUB04(ProductBOMRegister_T02Entity pProductBOMRegister_T02Entity)", pException);
            }
        }

        #endregion

        #region 구성 정보 조회 서브5 - ProductBOMRegister_T02_Info_SUB05(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductBOMRegister_T02_Info_SUB05(ProductBOMRegister_T02Entity pProductBOMRegister_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductBOMRegister_T02Provider(pDBManager).ProductBOMRegister_T02_Info_SUB05(pProductBOMRegister_T02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_T02_Info_SUB05(ProductBOMRegister_T02Entity pProductBOMRegister_T02Entity)", pException);
            }
        }

        #endregion


        #region 트리리스트 BOM 정보 조회 - ProductBOMRegister_T02_Configuration_Info(ProductBOMRegister_T02Entity pProductBOMRegister_T02Entity)

        public DataTable ProductBOMRegister_T02_Configuration_Info(ProductBOMRegister_T02Entity pProductBOMRegister_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductBOMRegister_T02Provider(pDBManager).ProductBOMRegister_T02_Configuration_Info(pProductBOMRegister_T02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_T02_Configuration_Info(ProductBOMRegister_T02Entity pProductBOMRegister_T02Entity)", pException);
            }
        }

        #endregion


        #region 정보 저장 - ProductBOMRegister_T02_Info_Save(ProductBOMRegister_T02Entity pProductBOMRegister_T02Entity, DataTable dt)

        /// <summary>
        /// 정보 저장
        /// </summary>
        public bool ProductBOMRegister_T02_Info_Save(ProductBOMRegister_T02Entity pProductBOMRegister_T02Entity, DataTable dt)
        {
            try
            {

                // DataTable dtTemp = null;
                //
                // bool isChack = CoFAS_ConvertManager.DataTable_FindCount(dt, "CRUD IN ('C','U','D')", "");
                //
                // if (isChack)
                // {
                //     dtTemp = CoFAS_ConvertManager.DataTable_FindValue(dt, "CRUD IN ('C','U','D')", ""); // 신규 and 수정 항목 데이터 테이블 화
                // }

                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = false;
                    if (pProductBOMRegister_T02Entity.CRUD == "U")
                    {
                        pProductBOMRegister_T02Entity.CRUD = "D";

                        isReturn = new ProductBOMRegister_T02Provider(pDBManager).ProductBOMRegister_T02_Info_Delete(pProductBOMRegister_T02Entity, dt);

                        if (!isReturn)
                        {
                            pProductBOMRegister_T02Entity.CRUD = "U";

                            isReturn = new ProductBOMRegister_T02Provider(pDBManager).ProductBOMRegister_T02_Info_Save(pProductBOMRegister_T02Entity, dt);
                        }
                    }
                    else
                    {
                        isReturn = new ProductBOMRegister_T02Provider(pDBManager).ProductBOMRegister_T02_Info_Save(pProductBOMRegister_T02Entity, dt);
                    }

                    //bool isReturn = new ProductBOMRegister_T02Provider(pDBManager).ProductBOMRegister_T02_Info_Save(pProductBOMRegister_T02Entity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_T02_Info_Save(ProductBOMRegister_T02Entity pProductBOMRegister_T02Entity, DataTable dt)", pException);
            }
        }

        public bool ProductBOMRegister_T02_Info_Enable(ProductBOMRegister_T02Entity pProductBOMRegister_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ProductBOMRegister_T02Provider(pDBManager).ProductBOMRegister_T02_Info_Enable(pProductBOMRegister_T02Entity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductBOMRegister_T02_Info_Delete(ProductBOMRegister_T02Entity pProductBOMRegister_T02Entity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ProductBOMRegister_T02Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                ProductBOMRegister_T02Entity pProductBOMRegister_T02Entity = new ProductBOMRegister_T02Provider(null).GetEntity(pDataRow);
                return pProductBOMRegister_T02Entity;
            }
            catch (Exception pException)
            {
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


    #region o 제품미출고현황
    public class ProductNotOutStatusBusiness
    {

        #region 마스터 정보 조회 - Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductNotOutStatus_Info_Filename(ProductNotOutStatusEntity pProductNotOutStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductNotOutStatusProvider(pDBManager).ProductNotOutStatus_Info_Filename(pProductNotOutStatusEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductNotOutStatus_Info_Filename(ProductNotOutStatusEntity pProductNotOutStatusEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(ProductNotOutStatusEntity pProductNotOutStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(ProductNotOutStatusEntity pProductNotOutStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductNotOutStatusProvider(pDBManager).Sample_Info_Mst(pProductNotOutStatusEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(ProductNotOutStatusEntity pProductNotOutStatusEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(ProductNotOutStatusEntity pProductNotOutStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(ProductNotOutStatusEntity pProductNotOutStatusEntity, DataTable dt)
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
                    bool isReturn = new ProductNotOutStatusProvider(pDBManager).Sample_Info_Save(pProductNotOutStatusEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(ProductNotOutStatusEntity pProductNotOutStatusEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region XML파일 다운로드 - Templete_Download(ProductNotOutStatusEntity pProductNotOutStatusEntity, string pMENU_NO, string pDSP_SORT)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public object Templete_Download(ProductNotOutStatusEntity pProductNotOutStatusEntity, string pMENU_NO, string pDSP_SORT)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    object pObject = new ProductNotOutStatusProvider(pDBManager).Templete_Download(pProductNotOutStatusEntity, pMENU_NO, pDSP_SORT);
                    return pObject;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductNotOutStatusProvider(pDBManager).Templete_Download(pProductNotOutStatusEntity, pMENU_NO, pDSP_SORT)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ProductNotOutStatusEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ProductNotOutStatusEntity pSampleRegisterEntity = new ProductNotOutStatusProvider(null).GetEntity(pDataRow);
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


    #region o 제품출하지시현황
    public class ProductOutOrderStatusBusiness
    {

        #region 마스터 정보 조회 - Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductOutOrderStatus_Info_Filename(ProductOutOrderStatusEntity pProductOutOrderStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductOutOrderStatusProvider(pDBManager).ProductOutOrderStatus_Info_Filename(pProductOutOrderStatusEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductOutOrderStatus_Info_Filename(ProductOutOrderStatusEntity pProductOutOrderStatusEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(ProductOutOrderStatusEntity pProductOutOrderStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(ProductOutOrderStatusEntity pProductOutOrderStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductOutOrderStatusProvider(pDBManager).Sample_Info_Mst(pProductOutOrderStatusEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(ProductOutOrderStatusEntity pProductOutOrderStatusEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(ProductOutOrderStatusEntity pProductOutOrderStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(ProductOutOrderStatusEntity pProductOutOrderStatusEntity, DataTable dt)
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
                    bool isReturn = new ProductOutOrderStatusProvider(pDBManager).Sample_Info_Save(pProductOutOrderStatusEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(ProductOutOrderStatusEntity pProductOutOrderStatusEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region XML파일 다운로드 - Templete_Download(ProductOutOrderStatusEntity pProductOutOrderStatusEntity, string pMENU_NO, string pDSP_SORT)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public object Templete_Download(ProductOutOrderStatusEntity pProductOutOrderStatusEntity, string pMENU_NO, string pDSP_SORT)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    object pObject = new ProductOutOrderStatusProvider(pDBManager).Templete_Download(pProductOutOrderStatusEntity, pMENU_NO, pDSP_SORT);
                    return pObject;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductOutOrderStatusProvider(pDBManager).Templete_Download(pProductOutOrderStatusEntity, pMENU_NO, pDSP_SORT)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ProductOutOrderStatusEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ProductOutOrderStatusEntity pSampleRegisterEntity = new ProductOutOrderStatusProvider(null).GetEntity(pDataRow);
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

    #region o 제품재고현황_범아기전
    public class ProductStockStatus_T02Business
    {
        #region 마스터 정보 조회 - Sample_Info(ProductStockStatus_T02Entity pProductStockStatus_T02Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(ProductStockStatus_T02Entity pProductStockStatus_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductStockStatus_T02Provider(pDBManager).Sample_Info_Mst(pProductStockStatus_T02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(ProductStockStatus_T02Entity pSampleRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(ProductStockStatus_T02Entity pProductStockStatus_T02Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(ProductStockStatus_T02Entity pProductStockStatus_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductStockStatus_T02Provider(pDBManager).Sample_Info_Mst(pProductStockStatus_T02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(ProductStockStatus_T02Entity pProductStockStatus_T02Entity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(ProductStockStatus_T02Entity pProductStockStatus_T02Entity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(ProductStockStatus_T02Entity pProductStockStatus_T02Entity, DataTable dt)
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
                    bool isReturn = new ProductStockStatus_T02Provider(pDBManager).Sample_Info_Save(pProductStockStatus_T02Entity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(ProductStockStatus_T02Entity pProductStockStatus_T02Entity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductStockStatus_T02_Info_Filename(ProductStockStatus_T02Entity pProductStockStatus_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductStockStatus_T02Provider(pDBManager).ProductStockStatus_T02_Info_Filename(pProductStockStatus_T02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductStockStatus_T02_Info_Filename(ProductStockStatus_T02Entity pProductStockStatus_T02Entity)", pException);
            }
        }

        #endregion

        #region XML파일 다운로드 - Templete_Download(ProductStockStatus_T02Entity pProductStockStatus_T02Entity, string pMENU_NO, string pDSP_SORT)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public object Templete_Download(ProductStockStatus_T02Entity pProductStockStatus_T02Entity, string pMENU_NO, string pDSP_SORT)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    object pObject = new ProductStockStatus_T02Provider(pDBManager).Templete_Download(pProductStockStatus_T02Entity, pMENU_NO, pDSP_SORT);
                    return pObject;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductStockStatus_T02Provider(pDBManager).Templete_Download(pProductStockStatus_T02Entity, pMENU_NO, pDSP_SORT)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ProductStockStatus_T02Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                ProductStockStatus_T02Entity pSampleRegisterEntity = new ProductStockStatus_T02Provider(null).GetEntity(pDataRow);
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

    #region o 제품재고현황_대성
    public class ProductStockStatus_T04Business
    {
        #region 마스터 정보 조회 - Sample_Info(ProductStockStatus_T04Entity pProductStockStatus_T04Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(ProductStockStatus_T04Entity pProductStockStatus_T04Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductStockStatus_T04Provider(pDBManager).Sample_Info_Mst(pProductStockStatus_T04Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(ProductStockStatus_T04Entity pSampleRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(ProductStockStatus_T04Entity pProductStockStatus_T04Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(ProductStockStatus_T04Entity pProductStockStatus_T04Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductStockStatus_T04Provider(pDBManager).Sample_Info_Mst(pProductStockStatus_T04Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(ProductStockStatus_T04Entity pProductStockStatus_T04Entity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(ProductStockStatus_T04Entity pProductStockStatus_T04Entity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(ProductStockStatus_T04Entity pProductStockStatus_T04Entity, DataTable dt)
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
                    bool isReturn = new ProductStockStatus_T04Provider(pDBManager).Sample_Info_Save(pProductStockStatus_T04Entity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(ProductStockStatus_T04Entity pProductStockStatus_T04Entity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductStockStatus_T04_Info_Filename(ProductStockStatus_T04Entity pProductStockStatus_T04Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductStockStatus_T04Provider(pDBManager).ProductStockStatus_T04_Info_Filename(pProductStockStatus_T04Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductStockStatus_T04_Info_Filename(ProductStockStatus_T04Entity pProductStockStatus_T04Entity)", pException);
            }
        }

        #endregion

        #region XML파일 다운로드 - Templete_Download(ProductStockStatus_T04Entity pProductStockStatus_T04Entity, string pMENU_NO, string pDSP_SORT)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public object Templete_Download(ProductStockStatus_T04Entity pProductStockStatus_T04Entity, string pMENU_NO, string pDSP_SORT)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    object pObject = new ProductStockStatus_T04Provider(pDBManager).Templete_Download(pProductStockStatus_T04Entity, pMENU_NO, pDSP_SORT);
                    return pObject;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductStockStatus_T04Provider(pDBManager).Templete_Download(pProductStockStatus_T04Entity, pMENU_NO, pDSP_SORT)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ProductStockStatus_T04Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                ProductStockStatus_T04Entity pSampleRegisterEntity = new ProductStockStatus_T04Provider(null).GetEntity(pDataRow);
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

    public class ProductOrderRegister_RequestBusiness
    {
        public DataTable ProductOrderRegister_RequestBusiness_R10(ProductOrderRegister_RequestEntity pProductOrderRegister_RequestEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductOrderRegister_RequestProvider(pDBManager).ProductOrderRegister_Request_R10(pProductOrderRegister_RequestEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductOrderRegister_Request_R10(ProductOrderRegister_RequestEntity1 pProductOrderRegister_RequestEntity)", pException);
            }
        }

        public DataTable ProductOrderRegister_Request_R20(ProductOrderRegister_RequestEntity pProductOrderRegister_RequestEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductOrderRegister_RequestProvider(pDBManager).ProductOrderRegister_Request_R20(pProductOrderRegister_RequestEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductOrderRegister_Request_R20(ProductOrderRegister_RequestEntity pProductOrderRegister_RequestEntity)", pException);
            }
        }

        #region ○ 화면명에 맞는 엑셀파일 불러오기
        public DataTable Sheet_Info_Sheet(ProductOrderRegister_RequestEntity pProductOrderRegister_RequestEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductOrderRegister_RequestProvider(pDBManager).Sheet_Info_sheet(pProductOrderRegister_RequestEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sheet_Info_Sheet(ProductOrderRegister_RequestEntity pProductOrderRegister_RequestEntity)", pException);
            }
        }

        #endregion

        #region 바인딩 데이터 테이블 불러오기 - Sheet_Info_Sheet_Data(ProductOrderRegister_RequestEntity pProductOrderRegister_RequestEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataSet Sheet_Info_Sheet_Data(ProductOrderRegister_RequestEntity pProductOrderRegister_RequestEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataSet psDataTable = new ProductOrderRegister_RequestProvider(pDBManager).Sheet_Info_Sheet_Data(pProductOrderRegister_RequestEntity);
                    return psDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sheet_Info_Sheet_Data(ProductOrderRegister_RequestEntity pProductOrderRegister_RequestEntity)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Filename(ProductOrderRegister_RequestEntity pProductOrderRegister_RequestEntityEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductOrderRegister_RequestProvider(pDBManager).Sample_Info_Filename(pProductOrderRegister_RequestEntityEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Filename(ProductOrderRegister_RequestEntity pProductOrderRegister_RequestEntityEntity)", pException);
            }
        }

        #endregion

        #region XML파일 다운로드 - MenuRegister_Templete_Download(MenuRegisterEntity pMenuRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public object Templete_Download(ProductOrderRegister_RequestEntity pProductOrderRegister_RequestEntityEntity, string pMENU_NO, string pDSP_SORT)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    object pObject = new ProductOrderRegister_RequestProvider(pDBManager).Templete_Download(pProductOrderRegister_RequestEntityEntity, pMENU_NO, pDSP_SORT);
                    return pObject;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Templete_Download(ProductOrderRegister_RequestEntity pProductOrderRegister_RequestEntityEntity, string pMENU_NO, string pDSP_SORT)", pException);
            }
        }

        #endregion

        #region 시험발주 정보 저장 -ProductOrderRegister_Request_Info_Save(ProductOrderRegister_RequestEntity pProductOrderRegister_RequestEntityEntity)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool ProductOrderRegister_Request_Info_Save(ProductOrderRegister_RequestEntity pProductOrderRegister_RequestEntityEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ProductOrderRegister_RequestProvider(pDBManager).ProductOrderRegister_Request_Info_Save(pProductOrderRegister_RequestEntityEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductOrderRegister_Request_Info_Save(ProductOrderRegister_RequestEntity pProductOrderRegister_RequestEntityEntity)", pException);
            }
        }

        #endregion

        #region 시험검사 정보 저장 -MaterialOrder_Request_Info_Save(UserInformationEntity pUserInformationEntity)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool ProductOrderRegister_Request_Info_Check_Save(ProductOrderRegister_RequestEntity pProductOrderRegister_RequestEntityEntity, DataTable dt)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ProductOrderRegister_RequestProvider(pDBManager).ProductOrderRegister_Request_Info_Check_Save(pProductOrderRegister_RequestEntityEntity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductOrderRegister_Request_Info_Check_Save(ProductOrderRegister_RequestEntity pProductOrderRegister_RequestEntityEntity, DataTable dt)", pException);
            }
        }

        #endregion
    }

    public class ucProductOrderInfoPopupBusiness
    {
        public DataSet ucProductOrderInfoPopup_Return(string pCRUD, string pFromDate, string pToDate, string pPART_NAME, string pVEND_NAME)  //CRUD , 발주일자 , 자재명, 거래처명
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataSet pDataTableSet = new ucProductOrderInfoPopupProvider(pDBManager).ucProductOrderInfoPopup_Return(pCRUD, pFromDate, pToDate, pPART_NAME, pVEND_NAME);
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

    public class ProductInformationRegister_T04Business
    {
        #region 마스터 정보 조회 - ProductInformationRegister_T04_Info(ProductInformationRegister_T04Entity pProductInformationRegister_T04Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductInformationRegister_T04_Info(ProductInformationRegister_T04Entity pProductInformationRegister_T04Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductInformationRegister_T04Provider(pDBManager).ProductInformationRegister_T04_Info_Mst(pProductInformationRegister_T04Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductInformationRegister_T04_Info(ProductInformationRegister_T04Entity pProductInformationRegister_T04Entity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - ProductInformationRegister_T04_Info_Sub(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductInformationRegister_T04_Info_Sub(ProductInformationRegister_T04Entity pProductInformationRegister_T04Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductInformationRegister_T04Provider(pDBManager).ProductInformationRegister_T04_Info_Sub(pProductInformationRegister_T04Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductInformationRegister_T04_Info_Sub(ProductInformationRegister_T04Entity pProductInformationRegister_T04Entity))", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - ProductInformationRegister_T04_Info_Save(ProductInformationRegister_T04Entity pProductInformationRegister_T04Entity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool ProductInformationRegister_T04_Info_Save(ProductInformationRegister_T04Entity pProductInformationRegister_T04Entity, DataTable dt)
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
                    bool isReturn = new ProductInformationRegister_T04Provider(pDBManager).ProductInformationRegister_T04_Info_Save(pProductInformationRegister_T04Entity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductInformationRegister_T04_Info_Save(ProductInformationRegister_T04Entity pProductInformationRegister_T04Entity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ProductInformationRegister_T04Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                ProductInformationRegister_T04Entity pProductInformationRegister_T04Entity = new ProductInformationRegister_T04Provider(null).GetEntity(pDataRow);
                return pProductInformationRegister_T04Entity;
            }
            catch (Exception pException)
            {
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

    public class ProductInRegister_T03Business
    {
        #region 마스터 정보 조회 - Sample_Info(ProductInRegister_T03Entity pProductInRegister_T03Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductInRegister_T03_Info(ProductInRegister_T03Entity pProductInRegister_T03Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductInRegister_T03Provider(pDBManager).ProductInRegister_T03_Info(pProductInRegister_T03Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(ProductInRegister_T03Entity pSampleRegisterEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(ProductInRegister_T03Entity pProductInRegister_T03Entity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool ProductInRegister_T03_Info_Save(ProductInRegister_T03Entity pProductInRegister_T03Entity)
        {
            try
            {

                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ProductInRegister_T03Provider(pDBManager).ProductInRegister_T03_Info_Save(pProductInRegister_T03Entity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(ProductOutRegisterEntity pProductInRegister_T03Entity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ProductInRegister_T03Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                ProductInRegister_T03Entity pSampleRegisterEntity = new ProductInRegister_T03Provider(null).GetEntity(pDataRow);
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

    public class ProductOutRegister_T04Business
    {

        #region 마스터 정보 조회 - ProductOutRegister_T04_Info(ProductOutRegister_T04Entity pProductOutRegister_T04Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductOutRegister_T04_Info(ProductOutRegister_T04Entity pProductOutRegister_T04Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductOutRegister_T04Provider(pDBManager).ProductOutRegister_T04_Info_Mst(pProductOutRegister_T04Entity);
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


        #region 그리드 정보 저장 - ProductOutRegister_T04_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool ProductOutRegister_T04_Info_Save(ProductOutRegister_T04Entity pProductOutRegister_T04Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ProductOutRegister_T04Provider(pDBManager).ProductOutRegister_T04_Info_Save(pProductOutRegister_T04Entity);
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
        public ProductOutRegister_T04Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                ProductOutRegister_T04Entity pProductOutRegister_T04Entity = new ProductOutRegister_T04Provider(null).GetEntity(pDataRow);
                return pProductOutRegister_T04Entity;
            }
            catch (Exception pException)
            {
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

    #region o 반/완/부재고현황_C타입
    public class ProductRecepiStatus_T01Business
    {
        #region 마스터 정보 조회 - Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductRecepiStatus_T01_Info_Filename(ProductRecepiStatus_T01Entity pProductRecepiStatus_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductRecepiStatus_T01Provider(pDBManager).ProductRecepiStatus_T01_Info_Filename(pProductRecepiStatus_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductRecepiStatus_T01_Info_Filename(ProductRecepiStatus_T01Entity pProductRecepiStatus_T01Entity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(MaterialExpirationDateStatusEntity pMaterialExpirationDateStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(ProductRecepiStatus_T01Entity pProductRecepitStatus_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductRecepiStatus_T01Provider(pDBManager).Sample_Info_Mst(pProductRecepitStatus_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(ProductRecepiStatus_T01Entity pProductRecepiStatus_T01Entity)", pException);
            }
        }

        #endregion

        #region XML파일 다운로드 - Templete_Download(ResultStatusDataEntity pResultStatusDataEntity, string pMENU_NO, string pDSP_SORT)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public object Templete_Download(ProductRecepiStatus_T01Entity pProductRecepiStatus_T01Entity, string pMENU_NO, string pDSP_SORT)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    object pObject = new ProductRecepiStatus_T01Provider(pDBManager).Templete_Download(pProductRecepiStatus_T01Entity, pMENU_NO, pDSP_SORT);
                    return pObject;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductRecepiStatus_T01Provider(pDBManager).Templete_Download(pProductRecepiStatus_T01Entity, pMENU_NO, pDSP_SORT)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ProductRecepiStatus_T01Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                ProductRecepiStatus_T01Entity pSampleRegisterEntity = new ProductRecepiStatus_T01Provider(null).GetEntity(pDataRow);
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

}
