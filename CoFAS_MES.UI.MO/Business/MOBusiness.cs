using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CoFAS_MES.UI.MO.Data;
using CoFAS_MES.UI.MO.Entity;

using CoFAS_MES.CORE.Entity;
using CoFAS_MES.CORE.Function;
using System.Data;

namespace CoFAS_MES.UI.MO.Business
{
    #region o SensorView
    public class SensorViewBusiness
    {


        #region 마스터 정보 조회 - SensorView_Info_Filename(SensorViewEntity pSensorViewEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable SensorView_Info_Filename(SensorViewEntity pSensorViewEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new SensorViewProvider(pDBManager).SensorView_Info_Filename(pSensorViewEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "SensorDataSearch_Info_Filename(SensorDataSearchEntity pSensorDataSearchEntity)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public SensorDataSearchEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                SensorDataSearchEntity pSampleRegisterEntity = new SensorDataSearchProvider(null).GetEntity(pDataRow);
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

    #region o SensorDataSearch
    public class SensorDataSearchBusiness
    {
        #region 마스터 정보 조회 - Sample_Info(SensorDataSearchEntity pSensorDataSearchEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(SensorDataSearchEntity pSensorDataSearchEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new SensorDataSearchProvider(pDBManager).Sample_Info_Mst(pSensorDataSearchEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(SensorDataSearchEntity pSensorDataSearchEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(SensorDataSearchEntity pSensorDataSearchEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(SensorDataSearchEntity pSensorDataSearchEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new SensorDataSearchProvider(pDBManager).Sample_Info_Mst(pSensorDataSearchEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(SensorDataSearchEntity pSensorDataSearchEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(ResultStatusDataEntity pResultStatusDataEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(SensorDataSearchEntity pSensorDataSearchEntity, DataTable dt)
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
                    bool isReturn = new SensorDataSearchProvider(pDBManager).Sample_Info_Save(pSensorDataSearchEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(SensorDataSearchEntity pSensorDataSearchEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable SensorDataSearch_Info_Filename(SensorDataSearchEntity pSensorDataSearchEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new SensorDataSearchProvider(pDBManager).SensorDataSearch_Info_Filename(pSensorDataSearchEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "SensorDataSearch_Info_Filename(SensorDataSearchEntity pSensorDataSearchEntity)", pException);
            }
        }

        #endregion

        #region XML파일 다운로드 - Templete_Download(SensorDataSearchEntity pSensorDataSearchEntity, string pMENU_NO, string pDSP_SORT)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public object Templete_Download(SensorDataSearchEntity pSensorDataSearchEntity, string pMENU_NO, string pDSP_SORT)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    object pObject = new SensorDataSearchProvider(pDBManager).Templete_Download(pSensorDataSearchEntity, pMENU_NO, pDSP_SORT);
                    return pObject;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "SensorDataSearchProvider(pDBManager).Templete_Download(pSensorDataSearchEntity, pMENU_NO, pDSP_SORT)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public SensorDataSearchEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                SensorDataSearchEntity pSampleRegisterEntity = new SensorDataSearchProvider(null).GetEntity(pDataRow);
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

    public class SensorStatusSeacrh_T01Business
    {
        #region 마스터 정보 조회 - Sample_Info(SensorStatusSeacrh_T01Entity pSensorStatusSeacrh_T01Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(SensorStatusSeacrh_T01Entity pSensorStatusSeacrh_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new SensorStatusSeacrh_T01Provider(pDBManager).Sample_Info_Mst(pSensorStatusSeacrh_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(SensorStatusSeacrh_T01Entity pSensorStatusSeacrh_T01Entity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(SensorStatusSeacrh_T01Entity pSensorStatusSeacrh_T01Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(SensorStatusSeacrh_T01Entity pSensorStatusSeacrh_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new SensorStatusSeacrh_T01Provider(pDBManager).Sample_Info_Mst(pSensorStatusSeacrh_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(SensorStatusSeacrh_T01Entity pSensorStatusSeacrh_T01Entity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(ResultStatusDataEntity pResultStatusDataEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(SensorStatusSeacrh_T01Entity pSensorStatusSeacrh_T01Entity, DataTable dt)
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
                    bool isReturn = new SensorStatusSeacrh_T01Provider(pDBManager).Sample_Info_Save(pSensorStatusSeacrh_T01Entity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(SensorStatusSeacrh_T01Entity pSensorStatusSeacrh_T01Entity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable SensorStatusSeacrh_T01_Info_Filename(SensorStatusSeacrh_T01Entity pSensorStatusSeacrh_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new SensorStatusSeacrh_T01Provider(pDBManager).SensorStatusSeacrh_T01_Info_Filename(pSensorStatusSeacrh_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "SensorStatusSeacrh_T01_Info_Filename(SensorStatusSeacrh_T01Entity pSensorStatusSeacrh_T01Entity)", pException);
            }
        }

        #endregion

        #region XML파일 다운로드 - Templete_Download(SensorStatusSeacrh_T01Entity pSensorStatusSeacrh_T01Entity, string pMENU_NO, string pDSP_SORT)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public object Templete_Download(SensorStatusSeacrh_T01Entity pSensorStatusSeacrh_T01Entity, string pMENU_NO, string pDSP_SORT)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    object pObject = new SensorStatusSeacrh_T01Provider(pDBManager).Templete_Download(pSensorStatusSeacrh_T01Entity, pMENU_NO, pDSP_SORT);
                    return pObject;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "SensorStatusSeacrh_T01Provider(pDBManager).Templete_Download(pSensorStatusSeacrh_T01Entity, pMENU_NO, pDSP_SORT)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public SensorStatusSeacrh_T01Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                SensorStatusSeacrh_T01Entity pSampleRegisterEntity = new SensorStatusSeacrh_T01Provider(null).GetEntity(pDataRow);
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

    #region o SensorStatusSeacrh
    public class SensorStatusSeacrhBusiness
    {
        #region 마스터 정보 조회 - Sample_Info(SensorStatusSeacrhEntity pSensorStatusSeacrhEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(SensorStatusSeacrhEntity pSensorStatusSeacrhEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new SensorStatusSeacrhProvider(pDBManager).Sample_Info_Mst(pSensorStatusSeacrhEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(SensorStatusSeacrhEntity pSensorStatusSeacrhEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(SensorStatusSeacrhEntity pSensorStatusSeacrhEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(SensorStatusSeacrhEntity pSensorStatusSeacrhEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new SensorStatusSeacrhProvider(pDBManager).Sample_Info_Mst(pSensorStatusSeacrhEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(SensorStatusSeacrhEntity pSensorStatusSeacrhEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(ResultStatusDataEntity pResultStatusDataEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(SensorStatusSeacrhEntity pSensorStatusSeacrhEntity, DataTable dt)
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
                    bool isReturn = new SensorStatusSeacrhProvider(pDBManager).Sample_Info_Save(pSensorStatusSeacrhEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(SensorStatusSeacrhEntity pSensorStatusSeacrhEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable SensorStatusSeacrh_Info_Filename(SensorStatusSeacrhEntity pSensorStatusSeacrhEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new SensorStatusSeacrhProvider(pDBManager).SensorStatusSeacrh_Info_Filename(pSensorStatusSeacrhEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "SensorStatusSeacrh_Info_Filename(SensorStatusSeacrhEntity pSensorStatusSeacrhEntity)", pException);
            }
        }

        #endregion

        #region XML파일 다운로드 - Templete_Download(SensorStatusSeacrhEntity pSensorStatusSeacrhEntity, string pMENU_NO, string pDSP_SORT)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public object Templete_Download(SensorStatusSeacrhEntity pSensorStatusSeacrhEntity, string pMENU_NO, string pDSP_SORT)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    object pObject = new SensorStatusSeacrhProvider(pDBManager).Templete_Download(pSensorStatusSeacrhEntity, pMENU_NO, pDSP_SORT);
                    return pObject;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "SensorStatusSeacrhProvider(pDBManager).Templete_Download(pSensorStatusSeacrhEntity, pMENU_NO, pDSP_SORT)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public SensorStatusSeacrhEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                SensorStatusSeacrhEntity pSampleRegisterEntity = new SensorStatusSeacrhProvider(null).GetEntity(pDataRow);
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

    #region o DoorOpeningClosingStatus
    public class DoorOpeningClosingStatusBusiness
    {
        #region 마스터 정보 조회 - Sample_Info(DoorOpeningClosingStatusEntity pDoorOpeningClosingStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(DoorOpeningClosingStatusEntity pDoorOpeningClosingStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new DoorOpeningClosingStatusProvider(pDBManager).Sample_Info_Mst(pDoorOpeningClosingStatusEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(DoorOpeningClosingStatusEntity pDoorOpeningClosingStatusEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(DoorOpeningClosingStatusEntity pDoorOpeningClosingStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(DoorOpeningClosingStatusEntity pDoorOpeningClosingStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new DoorOpeningClosingStatusProvider(pDBManager).Sample_Info_Mst(pDoorOpeningClosingStatusEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(DoorOpeningClosingStatusEntity pDoorOpeningClosingStatusEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(ResultStatusDataEntity pResultStatusDataEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(DoorOpeningClosingStatusEntity pDoorOpeningClosingStatusEntity, DataTable dt)
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
                    bool isReturn = new DoorOpeningClosingStatusProvider(pDBManager).Sample_Info_Save(pDoorOpeningClosingStatusEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(DoorOpeningClosingStatusEntity pDoorOpeningClosingStatusEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable DoorOpeningClosingStatus_Info_Filename(DoorOpeningClosingStatusEntity pDoorOpeningClosingStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new DoorOpeningClosingStatusProvider(pDBManager).DoorOpeningClosingStatus_Info_Filename(pDoorOpeningClosingStatusEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "DoorOpeningClosingStatus_Info_Filename(DoorOpeningClosingStatusEntity pDoorOpeningClosingStatusEntity)", pException);
            }
        }

        #endregion

        #region XML파일 다운로드 - Templete_Download(DoorOpeningClosingStatusEntity pDoorOpeningClosingStatusEntity, string pMENU_NO, string pDSP_SORT)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public object Templete_Download(DoorOpeningClosingStatusEntity pDoorOpeningClosingStatusEntity, string pMENU_NO, string pDSP_SORT)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    object pObject = new DoorOpeningClosingStatusProvider(pDBManager).Templete_Download(pDoorOpeningClosingStatusEntity, pMENU_NO, pDSP_SORT);
                    return pObject;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "DoorOpeningClosingStatusProvider(pDBManager).Templete_Download(pDoorOpeningClosingStatusEntity, pMENU_NO, pDSP_SORT)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public DoorOpeningClosingStatusEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                DoorOpeningClosingStatusEntity pSampleRegisterEntity = new DoorOpeningClosingStatusProvider(null).GetEntity(pDataRow);
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

    #region Gathering_Info

    public class Gathering_InfoBusiness
    {
        #region 마스터 정보 조회 - Gathering_Info_Info(Gathering_InfoEntity pGathering_InfoEntity)

        public DataTable Gathering_Info_Info(Gathering_InfoEntity pGathering_InfoEntity)
        {
        try
        {
            using (DBManager pDBManager = new DBManager())
            {
                DataTable pDataTable = new Gathering_InfoProvider(pDBManager).Sample_Info_Mst(pGathering_InfoEntity);
                return pDataTable;
            }
        }
        catch (ExceptionManager pExceptionManager)
        {
            throw pExceptionManager;
        }
        catch (Exception pException)
        {
            throw new ExceptionManager(this, "Sample_Info(Gathering_InfoEntity pGathering_InfoEntity)", pException);
        }
        }

        #endregion

        #region 그리드 정보 저장 - Gathering_Info_Save(Gathering_InfoEntity pGathering_InfoEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Gathering_Info_Info_Save(Gathering_InfoEntity pGathering_InfoEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new Gathering_InfoProvider(pDBManager).Gathering_Info_Info_Save(pGathering_InfoEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Gathering_Info_Info_Save(Gathering_InfoEntity pGathering_InfoEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public Gathering_InfoEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                Gathering_InfoEntity pGathering_InfoEntity = new Gathering_InfoProvider(null).GetEntity(pDataRow);
                return pGathering_InfoEntity;
            }
            catch (Exception pException)
            {
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

    #endregion //게더링 수식등록

    public class DPSSetting_mstBusiness
    {
        #region 마스터 정보 조회 - Gathering_Info_Info(DPSSetting_mstEntity pDPSSetting_mstEntity)

        public DataTable Gathering_Info_Info(DPSSetting_mstEntity pDPSSetting_mstEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new DPSSetting_mstProvider(pDBManager).Sample_Info_Mst(pDPSSetting_mstEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(DPSSetting_mstEntity pDPSSetting_mstEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Gathering_Info_Save(DPSSetting_mstEntity pDPSSetting_mstEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Gathering_Info_Info_Save(DPSSetting_mstEntity pDPSSetting_mstEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new DPSSetting_mstProvider(pDBManager).Gathering_Info_Info_Save(pDPSSetting_mstEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Gathering_Info_Info_Save(DPSSetting_mstEntity pDPSSetting_mstEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public DPSSetting_mstEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                DPSSetting_mstEntity pDPSSetting_mstEntity = new DPSSetting_mstProvider(null).GetEntity(pDataRow);
                return pDPSSetting_mstEntity;
            }
            catch (Exception pException)
            {
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
