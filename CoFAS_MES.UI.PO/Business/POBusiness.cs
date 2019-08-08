using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CoFAS_MES.UI.PO.Data;
using CoFAS_MES.UI.PO.Entity;

using CoFAS_MES.CORE.Entity;
using CoFAS_MES.CORE.Function;
using System.Data;
using DevExpress.Spreadsheet;

namespace CoFAS_MES.UI.PO.Business
{
    public class Dyeing_RecipeInformationRegisterBusiness
    {
        #region 마스터 정보 조회 - Sample_Info(Dyeing_RecipeInformationRegisterEntity pDyeing_RecipeInformationRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(Dyeing_RecipeInformationRegisterEntity pDyeing_RecipeInformationRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new Dyeing_RecipeInformationRegisterProvider(pDBManager).Sample_Info_Mst(pDyeing_RecipeInformationRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, " Sample_Info(Dyeing_RecipeInformationRegisterEntity pDyeing_RecipeInformationRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(Dyeing_RecipeInformationRegisterEntity pDyeing_RecipeInformationRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(Dyeing_RecipeInformationRegisterEntity pDyeing_RecipeInformationRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new Dyeing_RecipeInformationRegisterProvider(pDBManager).Sample_Info_Mst(pDyeing_RecipeInformationRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(Dyeing_RecipeInformationRegisterEntity pDyeing_RecipeInformationRegisterEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(SampleRegisterEntity pSampleRegisterEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(Dyeing_RecipeInformationRegisterEntity pDyeing_RecipeInformationRegisterEntity, DataTable dt)
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
                    bool isReturn = new Dyeing_RecipeInformationRegisterProvider(pDBManager).Sample_Info_Save(pDyeing_RecipeInformationRegisterEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(Dyeing_RecipeInformationRegisterEntity pDyeing_RecipeInformationRegisterEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public Dyeing_RecipeInformationRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                Dyeing_RecipeInformationRegisterEntity pDyeing_RecipeInformationRegisterEntity = new Dyeing_RecipeInformationRegisterProvider(null).GetEntity(pDataRow);
                return pDyeing_RecipeInformationRegisterEntity;
            }
            catch (Exception pException)
            {
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

    public class Dyeing_WorkOrdersRegisterBusiness
    {
        #region 마스터 정보 조회 - Sample_Info(Dyeing_RecipeInformationRegisterEntity pDyeing_RecipeInformationRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(Dyeing_WorkOrdersRegisterEntity pDyeing_WorkOrdersRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new Dyeing_WorkOrdersRegisterProvider(pDBManager).Sample_Info_Mst(pDyeing_WorkOrdersRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, " Sample_Info(Dyeing_RecipeInformationRegisterEntity pDyeing_RecipeInformationRegisterEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(SampleRegisterEntity pSampleRegisterEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(Dyeing_WorkOrdersRegisterEntity pDyeing_WorkOrdersRegisterEntity, DataTable dt)
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
                    bool isReturn = new Dyeing_WorkOrdersRegisterProvider(pDBManager).Sample_Info_Save(pDyeing_WorkOrdersRegisterEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(Dyeing_RecipeInformationRegisterEntity pDyeing_RecipeInformationRegisterEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public Dyeing_WorkOrdersRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                Dyeing_WorkOrdersRegisterEntity pDyeing_WorkOrdersRegisterEntity = new Dyeing_WorkOrdersRegisterProvider(null).GetEntity(pDataRow);
                return pDyeing_WorkOrdersRegisterEntity;
            }
            catch (Exception pException)
            {
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

    public class WorkOrdersRegisterBusiness
    {

        #region 마스터 정보 조회 - Sample_Info(WorkOrdersRegisterEntity pWorkOrdersRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(WorkOrdersRegisterEntity pWorkOrdersRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkOrdersRegisterProvider(pDBManager).Sample_Info_Mst(pWorkOrdersRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(WorkOrdersRegisterEntity pWorkOrdersRegisterEntity)", pException);
            }
        } 

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(MaterialOrderStatusEntity pMaterialOrderStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(WorkOrdersRegisterEntity pWorkOrdersRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkOrdersRegisterProvider(pDBManager).Sample_Info_Mst(pWorkOrdersRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(WorkOrdersRegisterEntity pWorkOrdersRegisterEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(WorkOrdersRegisterEntity pWorkOrdersRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new WorkOrdersRegisterProvider(pDBManager).Sample_Info_Save(pWorkOrdersRegisterEntity);
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
        public WorkOrdersRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                WorkOrdersRegisterEntity pWorkOrdersRegisterEntity = new WorkOrdersRegisterProvider(null).GetEntity(pDataRow);
                return pWorkOrdersRegisterEntity;
            }
            catch (Exception pException)
            {
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

    public class WorkOrdersRegister_T07Business
    {

        #region 마스터 정보 조회 - Sample_Info(WorkOrdersRegister_T07Entity pWorkOrdersRegister_T07Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(WorkOrdersRegister_T07Entity pWorkOrdersRegister_T07Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkOrdersRegister_T07Provider(pDBManager).Sample_Info_Mst(pWorkOrdersRegister_T07Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(WorkOrdersRegister_T07Entity pWorkOrdersRegister_T07Entity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(MaterialOrderStatusEntity pMaterialOrderStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(WorkOrdersRegister_T07Entity pWorkOrdersRegister_T07Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkOrdersRegister_T07Provider(pDBManager).Sample_Info_Mst(pWorkOrdersRegister_T07Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(WorkOrdersRegister_T07Entity pWorkOrdersRegister_T07Entity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(WorkOrdersRegister_T07Entity pWorkOrdersRegister_T07Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new WorkOrdersRegister_T07Provider(pDBManager).Sample_Info_Save(pWorkOrdersRegister_T07Entity);
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
        public WorkOrdersRegister_T07Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                WorkOrdersRegister_T07Entity pWorkOrdersRegister_T07Entity = new WorkOrdersRegister_T07Provider(null).GetEntity(pDataRow);
                return pWorkOrdersRegister_T07Entity;
            }
            catch (Exception pException)
            {
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

    public class WorkOrdersRegister_T50Business
    {

        #region ○ 화면명에 맞는 엑셀파일 불러오기
        public DataTable Sheet_Info_Sheet(WorkOrdersRegister_T50Entity pWorkOrdersRegister_T50Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pdatatable = new WorkOrdersRegister_T50Provider(pDBManager).Sheet_Info_sheet(pWorkOrdersRegister_T50Entity);
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

        #region 마스터 정보 조회 - Sample_Info(WorkOrdersRegister_T50Entity pWorkOrdersRegister_T50Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(WorkOrdersRegister_T50Entity pWorkOrdersRegister_T50Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkOrdersRegister_T50Provider(pDBManager).Sample_Info_Mst(pWorkOrdersRegister_T50Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(WorkOrdersRegister_T50Entity pWorkOrdersRegister_T50Entity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(MaterialOrderStatusEntity pMaterialOrderStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(WorkOrdersRegister_T50Entity pWorkOrdersRegister_T50Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkOrdersRegister_T50Provider(pDBManager).Sample_Info_Mst(pWorkOrdersRegister_T50Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(WorkOrdersRegister_T50Entity pWorkOrdersRegister_T50Entity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(WorkOrdersRegister_T50Entity pWorkOrdersRegister_T50Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new WorkOrdersRegister_T50Provider(pDBManager).Sample_Info_Save(pWorkOrdersRegister_T50Entity);
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
        public WorkOrdersRegister_T50Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                WorkOrdersRegister_T50Entity pWorkOrdersRegister_T50Entity = new WorkOrdersRegister_T50Provider(null).GetEntity(pDataRow);
                return pWorkOrdersRegister_T50Entity;
            }
            catch (Exception pException)
            {
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

    public class LotManagementSatusBusiness
    {

        #region 마스터 정보 조회 - Sample_Info(LotManagementSatusEntity pLotManagementSatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(LotManagementSatusEntity pLotManagementSatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new LotManagementSatusProvider(pDBManager).Sample_Info_Mst(pLotManagementSatusEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(LotManagementSatusEntity pLotManagementSatusEntity)", pException);
            }
        }

        #endregion
        
        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public LotManagementSatusEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                LotManagementSatusEntity pLotManagementSatusEntity = new LotManagementSatusProvider(null).GetEntity(pDataRow);
                return pLotManagementSatusEntity;
            }
            catch (Exception pException)
            {
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

    public class WorkOrdersRegister_T01Business
    {

        #region 마스터 정보 조회 - Sample_Info(WorkOrdersRegister_T01Entity pWorkOrdersRegister_T01Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(WorkOrdersRegister_T01Entity pWorkOrdersRegister_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkOrdersRegister_T01Provider(pDBManager).Sample_Info_Mst(pWorkOrdersRegister_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(WorkOrdersRegister_T01Entity pWorkOrdersRegister_T01Entity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(MaterialOrderStatusEntity pMaterialOrderStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(WorkOrdersRegister_T01Entity pWorkOrdersRegister_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkOrdersRegister_T01Provider(pDBManager).Sample_Info_Mst(pWorkOrdersRegister_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(WorkOrdersRegister_T01Entity pWorkOrdersRegister_T01Entity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(WorkOrdersRegister_T01Entity pWorkOrdersRegister_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new WorkOrdersRegister_T01Provider(pDBManager).Sample_Info_Save(pWorkOrdersRegister_T01Entity);
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
        public WorkOrdersRegister_T01Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                WorkOrdersRegister_T01Entity pWorkOrdersRegister_T01Entity = new WorkOrdersRegister_T01Provider(null).GetEntity(pDataRow);
                return pWorkOrdersRegister_T01Entity;
            }
            catch (Exception pException)
            {
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
    public class WorkOrdersRegister_T02Business
    {

        #region 마스터 정보 조회 - Sample_Info(WorkOrdersRegister_T02Entity pWorkOrdersRegister_T02Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(WorkOrdersRegister_T02Entity pWorkOrdersRegister_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkOrdersRegister_T02Provider(pDBManager).Sample_Info_Mst(pWorkOrdersRegister_T02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(WorkOrdersRegister_T02Entity pWorkOrdersRegister_T02Entity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(WorkOrdersRegister_T02Entity pWorkOrdersRegister_T02Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(WorkOrdersRegister_T02Entity pWorkOrdersRegister_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkOrdersRegister_T02Provider(pDBManager).Sample_Info_Sub(pWorkOrdersRegister_T02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(WorkOrdersRegister_T02Entity pWorkOrdersRegister_T02Entity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(WorkOrdersRegister_T02Entity pWorkOrdersRegister_T02Entity, DataTable dt)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new WorkOrdersRegister_T02Provider(pDBManager).Sample_Info_Save(pWorkOrdersRegister_T02Entity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(WorkOrdersRegister_T02Entity pWorkOrdersRegister_T02Entity)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public WorkOrdersRegister_T02Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                WorkOrdersRegister_T02Entity pWorkOrdersRegister_T02Entity = new WorkOrdersRegister_T02Provider(null).GetEntity(pDataRow);
                return pWorkOrdersRegister_T02Entity;
            }
            catch (Exception pException)
            {
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
    public class pucProductionOrderInfoPopup_T04Business
    {
        public DataSet ucProductionOrderInfoPopup_T04_Select(ucProductionOrderInfoPopup_T04_Entity pucProductionOrderInfoPopup_T04_Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataSet pDataTableSet = new ucProductionOrderInfoPopup_T04Provider(pDBManager).pucProductionOrderInfoPopup_T04_Return(pucProductionOrderInfoPopup_T04_Entity);
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

    public class pucProductionOrderInfoPopup_T07Business
    {
        public DataSet ucProductionOrderInfoPopup_T07_Select(ucProductionOrderInfoPopup_T07_Entity pucProductionOrderInfoPopup_T07_Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataSet pDataTableSet = new ucProductionOrderInfoPopup_T07Provider(pDBManager).pucProductionOrderInfoPopup_T07_Return(pucProductionOrderInfoPopup_T07_Entity);
                    return pDataTableSet;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucProductionOrderInfoPopup_T07_Select(ucProductionOrderInfoPopup_T07_Entity pucProductionOrderInfoPopup_T07_Entity)", pException);
            }
        }
    }

    public class ucWorkOrderInfoPopup_T01Business
    {
        public DataSet ucWorkOrderInfoPopup_T01_Return(string pCRUD, string pPLANORDER, string pPARTCODE)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataSet pDataTableSet = new ucWorkOrderInfoPopup_T01Provider(pDBManager).WorkOrderInfo_Return(pCRUD, pPLANORDER, pPARTCODE);
                    return pDataTableSet;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucWorkOrderInfoPopup_T01Provider(pDBManager).WorkOrderInfo_Return(pCRUD, pPARTCODE)", pException);
            }
        }

        public DataSet ucWorkOrderInfoPopup_T01_Save(ucWorkOrderInfoPopup_T01Entity pucWorkOrderInfoPopup_T01Entity, DataTable pDataTable)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    //bool isReturn = new ucWorkOrderInfoPopup_T01Provider(pDBManager).WorkOrderInfo_Save(pucWorkOrderInfoPopup_T01Entity, pDataTable);
                    DataSet rtn_DataSet = new ucWorkOrderInfoPopup_T01Provider(pDBManager).WorkOrderInfo_Save(pucWorkOrderInfoPopup_T01Entity, pDataTable);
                    return rtn_DataSet;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucWorkOrderInfoPopup_T01_Save(ucWorkOrderInfoPopup_T01Entity pucWorkOrderInfoPopup_T01Entity, DataTable pDataTable)", pException);
            }
        }

        #region ○ 화면명에 맞는 엑셀파일 불러오기
        public DataTable Sheet_Info_Sheet(ucWorkOrderInfoPopup_T01Entity pucWorkOrderInfoPopup_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucWorkOrderInfoPopup_T01Provider(pDBManager).Sheet_Info_sheet(pucWorkOrderInfoPopup_T01Entity);
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

    public class ucWorkOrderInfoPopup_T03Business
    {
        public DataSet ucWorkOrderInfoPopup_T03_Return(ucWorkOrderInfoPopup_T03Entity _pWorkOrderInfoPopup_T03Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataSet pDataTableSet = new ucWorkOrderInfoPopup_T03Provider(pDBManager).WorkOrderInfo_Return(_pWorkOrderInfoPopup_T03Entity);
                    return pDataTableSet;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucWorkOrderInfoPopup_T03_Return(string pCRUD, string pPLANORDER, string pPARTCODE)", pException);
            }
        }

        public bool ucWorkOrderInfoPopup_T03_Save(ucWorkOrderInfoPopup_T03Entity pucWorkOrderInfoPopup_T03Entity, DataTable pDataTable)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ucWorkOrderInfoPopup_T03Provider(pDBManager).WorkOrderInfo_Save(pucWorkOrderInfoPopup_T03Entity, pDataTable);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucWorkOrderInfoPopup_T03_Save(ucWorkOrderInfoPopup_T03Entity pucWorkOrderInfoPopup_T03Entity, DataTable pDataTable)", pException);
            }
        }
    }



    #region o 작업지시별생산실적현황
    public class ResultStatusDataBusiness
    {
        #region 마스터 정보 조회 - Sample_Info(ResultStatusDataEntity pResultStatusDataEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(ResultStatusDataEntity pResultStatusDataEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ResultStatusDataProvider(pDBManager).Sample_Info_Mst(pResultStatusDataEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(ResultStatusDataEntity pSampleRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(ResultStatusDataEntity pResultStatusDataEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(ResultStatusDataEntity pResultStatusDataEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ResultStatusDataProvider(pDBManager).Sample_Info_Mst(pResultStatusDataEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(ResultStatusDataEntity pResultStatusDataEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(ResultStatusDataEntity pResultStatusDataEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(ResultStatusDataEntity pResultStatusDataEntity, DataTable dt)
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
                    bool isReturn = new ResultStatusDataProvider(pDBManager).Sample_Info_Save(pResultStatusDataEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(ResultStatusDataEntity pResultStatusDataEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ResultStatusData_Info_Filename(ResultStatusDataEntity pResultStatusDataEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ResultStatusDataProvider(pDBManager).ResultStatusData_Info_Filename(pResultStatusDataEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ResultStatusData_Info_Filename(ResultStatusDataEntity pResultStatusDataEntity)", pException);
            }
        }

        #endregion

        #region XML파일 다운로드 - Templete_Download(ResultStatusDataEntity pResultStatusDataEntity, string pMENU_NO, string pDSP_SORT)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public object Templete_Download(ResultStatusDataEntity pResultStatusDataEntity, string pMENU_NO, string pDSP_SORT)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    object pObject = new ResultStatusDataProvider(pDBManager).Templete_Download(pResultStatusDataEntity, pMENU_NO, pDSP_SORT);
                    return pObject;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ResultStatusDataProvider(pDBManager).Templete_Download(pResultStatusDataEntity, pMENU_NO, pDSP_SORT)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ResultStatusDataEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ResultStatusDataEntity pSampleRegisterEntity = new ResultStatusDataProvider(null).GetEntity(pDataRow);
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

    #region o 계획대비실적현황
    public class ResultStatusPlanResultBusiness
    {
        #region 마스터 정보 조회 - Sample_Info(ResultStatusPlanResultEntity pResultStatusPlanResultEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(ResultStatusPlanResultEntity pResultStatusPlanResultEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ResultStatusPlanResultProvider(pDBManager).Sample_Info_Mst(pResultStatusPlanResultEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(ResultStatusPlanResultEntity pSampleRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(ResultStatusPlanResultEntity pResultStatusPlanResultEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(ResultStatusPlanResultEntity pResultStatusPlanResultEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ResultStatusPlanResultProvider(pDBManager).Sample_Info_Mst(pResultStatusPlanResultEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(ResultStatusPlanResultEntity pResultStatusPlanResultEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(ResultStatusPlanResultEntity pResultStatusPlanResultEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(ResultStatusPlanResultEntity pResultStatusPlanResultEntity, DataTable dt)
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
                    bool isReturn = new ResultStatusPlanResultProvider(pDBManager).Sample_Info_Save(pResultStatusPlanResultEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(ResultStatusPlanResultEntity pResultStatusPlanResultEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ResultStatusPlanResult_Info_Filename(ResultStatusPlanResultEntity pResultStatusPlanResultEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ResultStatusPlanResultProvider(pDBManager).ResultStatusPlanResult_Info_Filename(pResultStatusPlanResultEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ResultStatusPlanResult_Info_Filename(ResultStatusPlanResultEntity pResultStatusPlanResultEntity)", pException);
            }
        }

        #endregion

        #region XML파일 다운로드 - Templete_Download(ResultStatusPlanResultEntity pResultStatusPlanResultEntity, string pMENU_NO, string pDSP_SORT)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public object Templete_Download(ResultStatusPlanResultEntity pResultStatusPlanResultEntity, string pMENU_NO, string pDSP_SORT)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    object pObject = new ResultStatusPlanResultProvider(pDBManager).Templete_Download(pResultStatusPlanResultEntity, pMENU_NO, pDSP_SORT);
                    return pObject;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ResultStatusPlanResultProvider(pDBManager).Templete_Download(pResultStatusPlanResultEntity, pMENU_NO, pDSP_SORT)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ResultStatusPlanResultEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ResultStatusPlanResultEntity pSampleRegisterEntity = new ResultStatusPlanResultProvider(null).GetEntity(pDataRow);
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

    #region o 월별 생산계획/실적및 평균
    public class ProductPlanMonthStatusBusiness
    {
        #region 마스터 정보 조회 - Sample_Info(ProductPlanMonthStatusEntity pProductPlanMonthStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(ProductPlanMonthStatusEntity pProductPlanMonthStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductPlanMonthStatusProvider(pDBManager).Sample_Info_Mst(pProductPlanMonthStatusEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(ResultStatusPlanResultEntity pSampleRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(ResultStatusPlanResultEntity pResultStatusPlanResultEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(ResultStatusPlanResultEntity pResultStatusPlanResultEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ResultStatusPlanResultProvider(pDBManager).Sample_Info_Mst(pResultStatusPlanResultEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(ResultStatusPlanResultEntity pResultStatusPlanResultEntity)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ResultStatusPlanResult_Info_Filename(ProductPlanMonthStatusEntity pProductPlanMonthStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductPlanMonthStatusProvider(pDBManager).ProductPlanMonthStatus_Info_Filename(pProductPlanMonthStatusEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ResultStatusPlanResult_Info_Filename(ResultStatusPlanResultEntity pResultStatusPlanResultEntity)", pException);
            }
        }

        #endregion

        #region XML파일 다운로드 - Templete_Download(ResultStatusPlanResultEntity pResultStatusPlanResultEntity, string pMENU_NO, string pDSP_SORT)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public object Templete_Download(ResultStatusPlanResultEntity pResultStatusPlanResultEntity, string pMENU_NO, string pDSP_SORT)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    object pObject = new ResultStatusPlanResultProvider(pDBManager).Templete_Download(pResultStatusPlanResultEntity, pMENU_NO, pDSP_SORT);
                    return pObject;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ResultStatusPlanResultProvider(pDBManager).Templete_Download(pResultStatusPlanResultEntity, pMENU_NO, pDSP_SORT)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ResultStatusPlanResultEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ResultStatusPlanResultEntity pSampleRegisterEntity = new ResultStatusPlanResultProvider(null).GetEntity(pDataRow);
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

    #region o 월별 시간당 생산성 가동정지
    public class ProductTimeMonthLiveBusiness
    {
        #region 마스터 정보 조회 - Sample_Info(ProductTimeMonthLiveEntity pProductTimeMonthLiveEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(ProductTimeMonthLiveEntity pProductTimeMonthLiveEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductTimeMonthLiveProvider(pDBManager).Sample_Info_Mst(pProductTimeMonthLiveEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(ResultStatusPlanResultEntity pSampleRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(ResultStatusPlanResultEntity pResultStatusPlanResultEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(ProductTimeMonthLiveEntity pProductTimeMonthLiveEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductTimeMonthLiveProvider(pDBManager).Sample_Info_Mst(pProductTimeMonthLiveEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(ProductTimeMonthLiveEntity pProductTimeMonthLiveEntity)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductTimeMonthLive_Info_Filename(ProductTimeMonthLiveEntity pProductTimeMonthLiveEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductTimeMonthLiveProvider(pDBManager).ProductTimeMonthLive_Info_Filename(pProductTimeMonthLiveEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ResultStatusPlanResult_Info_Filename(ResultStatusPlanResultEntity pResultStatusPlanResultEntity)", pException);
            }
        }

        #endregion

        #region XML파일 다운로드 - Templete_Download(ResultStatusPlanResultEntity pResultStatusPlanResultEntity, string pMENU_NO, string pDSP_SORT)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public object Templete_Download(ProductTimeMonthLiveEntity pProductTimeMonthLiveEntity, string pMENU_NO, string pDSP_SORT)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    object pObject = new ProductTimeMonthLiveProvider(pDBManager).Templete_Download(pProductTimeMonthLiveEntity, pMENU_NO, pDSP_SORT);
                    return pObject;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductTimeMonthLiveProvider(pDBManager).Templete_Download(pProductTimeMonthLiveEntity, pMENU_NO, pDSP_SORT)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ProductTimeMonthLiveEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ProductTimeMonthLiveEntity pProductTimeMonthLiveEntity = new ProductTimeMonthLiveProvider(null).GetEntity(pDataRow);
                return pProductTimeMonthLiveEntity;
            }
            catch (Exception pException)
            {
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

    #region o 월별 시간당 생산성 가동정지
    public class ProductResultPlanStatusBusiness
    {
        #region 마스터 정보 조회 - Sample_Info(ProductResultPlanStatusEntity pProductResultPlanStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(ProductResultPlanStatusEntity pProductResultPlanStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductResultPlanStatusProvider(pDBManager).Sample_Info_Mst(pProductResultPlanStatusEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(ResultStatusPlanResultEntity pSampleRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(ProductResultPlanStatusEntity pProductResultPlanStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(ProductResultPlanStatusEntity pProductResultPlanStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductResultPlanStatusProvider(pDBManager).Sample_Info_Mst(pProductResultPlanStatusEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(ProductTimeMonthLiveEntity pProductTimeMonthLiveEntity)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductResultPlanStatus_Info_Filename(ProductResultPlanStatusEntity pProductResultPlanStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductResultPlanStatusProvider(pDBManager).ProductResultPlanStatus_Info_Filename(pProductResultPlanStatusEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ResultStatusPlanResult_Info_Filename(ResultStatusPlanResultEntity pResultStatusPlanResultEntity)", pException);
            }
        }

        #endregion

        #region XML파일 다운로드 - Templete_Download(ResultStatusPlanResultEntity pResultStatusPlanResultEntity, string pMENU_NO, string pDSP_SORT)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public object Templete_Download(ProductResultPlanStatusEntity pProductResultPlanStatusEntity, string pMENU_NO, string pDSP_SORT)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    object pObject = new ProductResultPlanStatusProvider(pDBManager).Templete_Download(pProductResultPlanStatusEntity, pMENU_NO, pDSP_SORT);
                    return pObject;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductTimeMonthLiveProvider(pDBManager).Templete_Download(pProductTimeMonthLiveEntity, pMENU_NO, pDSP_SORT)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ProductResultPlanStatusEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ProductResultPlanStatusEntity pProductResultPlanStatusEntity = new ProductResultPlanStatusProvider(null).GetEntity(pDataRow);
                return pProductResultPlanStatusEntity;
            }
            catch (Exception pException)
            {
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

    #region o 품목별생산실적현황

    public class ResultStatusProductBusiness
    {
        #region 마스터 정보 조회 - Sample_Info(ResultStatusProductEntity pResultStatusProductEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(ResultStatusProductEntity pResultStatusProductEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ResultStatusProductProvider(pDBManager).Sample_Info_Mst(pResultStatusProductEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(ResultStatusProductEntity pSampleRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(ResultStatusProductEntity pResultStatusProductEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(ResultStatusProductEntity pResultStatusProductEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ResultStatusProductProvider(pDBManager).Sample_Info_Mst(pResultStatusProductEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(ResultStatusProductEntity pResultStatusProductEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(ResultStatusProductEntity pResultStatusProductEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(ResultStatusProductEntity pResultStatusProductEntity, DataTable dt)
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
                    bool isReturn = new ResultStatusProductProvider(pDBManager).Sample_Info_Save(pResultStatusProductEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(ResultStatusProductEntity pResultStatusProductEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ResultStatusProduct_Info_Filename(ResultStatusProductEntity pResultStatusProductEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ResultStatusProductProvider(pDBManager).ResultStatusProduct_Info_Filename(pResultStatusProductEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ResultStatusProduct_Info_Filename(ResultStatusProductEntity pResultStatusProductEntity)", pException);
            }
        }

        #endregion

        #region XML파일 다운로드 - Templete_Download(ResultStatusProductEntity pResultStatusProductEntity, string pMENU_NO, string pDSP_SORT)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public object Templete_Download(ResultStatusProductEntity pResultStatusProductEntity, string pMENU_NO, string pDSP_SORT)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    object pObject = new ResultStatusProductProvider(pDBManager).Templete_Download(pResultStatusProductEntity, pMENU_NO, pDSP_SORT);
                    return pObject;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ResultStatusProductProvider(pDBManager).Templete_Download(pResultStatusProductEntity, pMENU_NO, pDSP_SORT)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ResultStatusProductEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ResultStatusProductEntity pSampleRegisterEntity = new ResultStatusProductProvider(null).GetEntity(pDataRow);
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

    #region o 수주정보등록
    public class ContractMstRegisterBusiness
    {

        #region 정보 조회 - ContractMst_Info(ContractMstRegisterEntity pContractMstRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ContractMst_Info(ContractMstRegisterEntity pContractMstRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ContractMstRegisterProvider(pDBManager).ContractMstRegister_Info_Mst(pContractMstRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ContractMst_Info(ContractMstRegisterEntity pContractMstRegisterEntity)", pException);
            }
        }

        #endregion

        #region ○ 정보 저장 - ContractMst_Save(ContractMstRegisterEntity pContractMstReigsterEntity)

        public bool ContractMst_Save(ContractMstRegisterEntity pContractMstReigsterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ContractMstRegisterProvider(pDBManager).ContractMstRegister_Save(pContractMstReigsterEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ContractMst_Save(ContractMstRegisterEntity pContractMstReigsterEntity)", pException);
            }
        }

        #endregion

        #region ○ 수주정보 수정 시, 해당 수주번호로 내려진 생산계획이 있는지 조회- Sample_Check_Next_Process(ContractMstRegisterEntity pContractMstReigsterEntity) 

        public DataTable Sample_Check_Next_Process(ContractMstRegisterEntity pContractMstReigsterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ContractMstRegisterProvider(pDBManager).Sample_Check_Next_Process(pContractMstReigsterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Check_Next_Process(ContractMstRegisterEntity pContractMstReigsterEntity)", pException);
            }
        }

        /*
        public DataTable ProductPlanMst_Del(ProductPlanRegisterEntity pProductPlanRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductPlanRegisterProvider(pDBManager).ProductPlanRegister_del(pProductPlanRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductPlanRegister_del(ProductPlanRegisterEntity pProductPlanRegisterEntity)", pException);
            }
        }
        */

        #endregion

    }

    #endregion

    #region o 수주정보등록_T01
    public class ContractMstRegister_T01Business
    {

        #region 정보 조회 - ContractMst_Info(ContractMstRegister_T01Entity pContractMstRegister_T01Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ContractMst_Info(ContractMstRegister_T01Entity pContractMstRegister_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ContractMstRegister_T01Provider(pDBManager).ContractMstRegister_Info_Mst(pContractMstRegister_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ContractMst_Info(ContractMstRegister_T01Entity pContractMstRegister_T01Entity)", pException);
            }
        }

        #endregion

        #region 정보 조회 - ContractSub_Info(ContractMstRegister_T01Entity pContractMstRegister_T01Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ContractSub_Info(ContractMstRegister_T01Entity pContractMstRegister_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ContractMstRegister_T01Provider(pDBManager).ContractMstRegister_Info_Sub(pContractMstRegister_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ContractSub_Info(ContractMstRegister_T01Entity pContractMstRegister_T01Entity)", pException);
            }
        }

        #endregion

        #region ○ 정보 저장 - ContractMst_Save(ContractMstRegisterEntity pContractMstReigsterEntity)

        public bool ContractMst_Save(ContractMstRegister_T01Entity pContractMstReigster_T01Entity, DataTable dt)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ContractMstRegister_T01Provider(pDBManager).ContractMstRegister_Save(pContractMstReigster_T01Entity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ContractMst_Save(ContractMstRegister_T01Entity pContractMstReigster_T01Entity)", pException);
            }
        }

        #endregion

    }

    #endregion

    #region 계약문서

    public class ucContractDocumentListPopupBusiness
    {
        #region 메인 정보 조회 - ucContractDocumentListPopup_Info_Main(ucContractDocumentListPopupEntity pucContractDocumentListPopupEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ucContractDocumentListPopup_Info_Main(ucContractDocumentListPopupEntity pucContractDocumentListPopupEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucContractDocumentListPopupProvider(pDBManager).ucContractDocumentListPopup_Info_Main(pucContractDocumentListPopupEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucPartDocumentListPopup_Info_Main(ucContractDocumentListPopupEntity pucContractDocumentListPopupEntity)", pException);
            }
        }

        #endregion

        #region 서브 정보 조회 - ucPartDocumentListPopup_Info_Sub(ucPartDocumentListPopupEntity pucPartDocumentListPopupEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ucContractDocumentListPopup_Info_Sub(ucContractDocumentListPopupEntity pucContractDocumentListPopupEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucContractDocumentListPopupProvider(pDBManager).uContractDocumentListPopup_Info_Sub(pucContractDocumentListPopupEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucPartDocumentListPopup_Info_Sub(ucContractDocumentListPopupEntity pucContractDocumentListPopupEntity)", pException);
            }
        }

        #endregion

        #region 정보 저장 - ucContractDocumentListPopup_Info_Save(ucContractDocumentListPopupEntity pucContractDocumentListPopupEntity, DataTable dt)

        /// <summary>
        /// 정보 저장
        /// </summary>
        public bool ucContractDocumentListPopup_Info_Save(ucContractDocumentListPopupEntity pucContractDocumentListPopupEntity, DataTable dt)
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
                    bool isReturn = new ucContractDocumentListPopupProvider(pDBManager).ucContractDocumentListPopup_Info_Save(pucContractDocumentListPopupEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucContractDocumentListPopup_Info_Save(ucContractDocumentListPopupEntity pucContractDocumentListPopupEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ucContractDocumentListPopupEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ucContractDocumentListPopupEntity pucContractDocumentListPopupEntity = new ucContractDocumentListPopupProvider(null).GetEntity(pDataRow);
                return pucContractDocumentListPopupEntity;
            }
            catch (Exception pException)
            {
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

    #region 수주정보등록_신규버튼팝업
    public class ucOrderNumberInfoPopup_Business
    {
        public DataTable ContractMst_Info(ucOrderNumberInfoPopup_Entity pucOrderNumberInfoPopup_Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucOrderNumberInfoPopup_Provider(pDBManager).ContractMstRegister_Info_Mst(pucOrderNumberInfoPopup_Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ContractMst_Info(ContractMstRegister_T01Entity pContractMstRegister_T01Entity)", pException);
            }
        }

        public bool ContractMst_Save(ucOrderNumberInfoPopup_Entity pucOrderNumberInfoPopup_Entity, DataTable dt)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ucOrderNumberInfoPopup_Provider(pDBManager).ContractMstRegister_Save(pucOrderNumberInfoPopup_Entity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ContractMst_Save(ucOrderNumberInfoPopup_Entity pucOrderNumberInfoPopup_Entity)", pException);
            }
        }
    }

    #endregion

    #region ○ 생산계획등록

    public class ProductPlanRegisterBusiness
    {
        #region ○ 데이터 조회

        public DataTable ProductPlanMst_Info(ProductPlanRegisterEntity pProductPlanRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductPlanRegisterProvider(pDBManager).ProductPlanRegister_Info_Mst(pProductPlanRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductPlanMst_Info(ProductPlanRegisterEntity pProductPlanRegisterEntity)", pException);
            }
        }

        public DataTable ProductPlanMst_Del(ProductPlanRegisterEntity pProductPlanRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductPlanRegisterProvider(pDBManager).ProductPlanRegister_del(pProductPlanRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductPlanRegister_del(ProductPlanRegisterEntity pProductPlanRegisterEntity)", pException);
            }
        }

        #endregion
    }

    #endregion

    #region ○ 생산계획등록_T01

    public class ProductPlanRegister_T01Business
    {
        #region ○ 데이터 조회

        public DataTable ProductPlanMst_Info(ProductPlanRegister_T01Entity pProductPlanRegister_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductPlanRegister_T01Provider(pDBManager).ProductPlanRegister_T01_Info_Mst(pProductPlanRegister_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductPlanMst_Info(ProductPlanRegister_T01Entity pProductPlanRegister_T01Entity)", pException);
            }
        }

        public DataTable ProductPlanMst_Del(ProductPlanRegister_T01Entity pProductPlanRegister_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductPlanRegister_T01Provider(pDBManager).ProductPlanRegister_T01_del(pProductPlanRegister_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductPlanRegister_T01_del(ProductPlanRegister_T01Entity pProductPlanRegister_T01Entity)", pException);
            }
        }

        #endregion

        #region ○ 작업지시 조회 - Sample_Check_Next_Process(ProductPlanRegister_T01Entity pProductPlanRegister_T01Entity)        
        /// <summary>
        /// 생산계획등록 삭제 시, 해당 생산계획번호를 가진 작업지시가 있는지 조회
        /// </summary>
        public DataTable Sample_Check_Next_Process(ProductPlanRegister_T01Entity pProductPlanRegister_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductPlanRegister_T01Provider(pDBManager).Sample_Check_Next_Process(pProductPlanRegister_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Check_Next_Process(ProductPlanRegister_T01Entity pProductPlanRegister_T01Entity)", pException);
            }
        }

        
        #endregion
    }

    #endregion

    #region ○ 생산계획등록_T02

    public class ProductPlanRegister_T02Business
    {
        #region ○ 메인 데이터 조회

        public DataTable ProductPlanMst_Info(ProductPlanRegister_T02Entity pProductPlanRegister_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductPlanRegister_T02Provider(pDBManager).ProductPlanRegister_Info_Mst(pProductPlanRegister_T02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductPlanMst_Info(ProductPlanRegister_T02Entity pProductPlanRegister_T02Entity)", pException);
            }
        }

        #endregion

        #region 서브 데이터 조회
        public DataTable ProductPlanMst_Info_sub(ProductPlanRegister_T02Entity pProductPlanRegister_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductPlanRegister_T02Provider(pDBManager).ProductPlanRegister_Info_Sub(pProductPlanRegister_T02Entity);
                    return pDataTable;
                }
            }            
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductPlanMst_Info(ProductPlanRegister_T02Entity pProductPlanRegister_T02Entity)", pException);
            }
        }
        #endregion

        #region 품목데이터 조회
        public DataTable ProductPlandetail_Info(ProductPlanRegister_T02Entity pProductPlanRegister_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductPlanRegister_T02Provider(pDBManager).ProductPlanRegister_Info_detail(pProductPlanRegister_T02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductPlandetail_Info(ProductPlanRegister_T02Entity pProductPlanRegister_T02Entity)", pException);
            }
        }
        #endregion

        #region 데이터 삭제

        public DataTable ProductPlanMst_Del(ProductPlanRegister_T02Entity pProductPlanRegister_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductPlanRegister_T02Provider(pDBManager).ProductPlanRegister_del(pProductPlanRegister_T02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductPlanMst_Del(ProductPlanRegister_T02Entity pProductPlanRegister_T02Entity)", pException);
            }
        }

        #endregion

        #region ○ 메인 데이터 저장
        public bool ProductPlanMst_Save(ProductPlanRegister_T02Entity pProductPlanRegister_T02Entity, DataTable dt)
        {
            try
            {

                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ProductPlanRegister_T02Provider(pDBManager).ProductPlanRegister_Save_Mst(pProductPlanRegister_T02Entity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductPlanMst_Save(ProductPlanRegister_T02Entity pProductPlanRegister_T02Entity))", pException);
            }
        }
        #endregion

        #region 서브 데이터 저장
        public bool ProductPlanSub_Save(ucOrderNumberInfoPopup_Entity pucOrderNumberInfoPopup_Entity, DataTable dt)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ProductPlanRegister_T02Provider(pDBManager).ProductPlanRegister_Save_Sub(pucOrderNumberInfoPopup_Entity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductPlanSub_Save(ProductPlanRegister_T02Entity pProductPlanRegister_T02Entity, DataTable dt)", pException);
            }
        }
        #endregion
    }

    #endregion

    #region ○ 생산계획등록_T50

    public class ProductPlanRegister_T50Business
    {
        #region ○ 데이터 조회

        public DataTable ProductPlanMst_T50_Info(ProductPlanRegister_T50Entity pProductPlanRegister_T50Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductPlanRegister_T50Provider(pDBManager).ProductPlanRegister_T50_Info_Mst(pProductPlanRegister_T50Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductPlanMst_Info(ProductPlanRegister_T50Entity pProductPlanRegister_T50Entity)", pException);
            }
        }

        public DataTable ProductPlanMst_Del(ProductPlanRegister_T50Entity pProductPlanRegister_T50Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductPlanRegister_T50Provider(pDBManager).ProductPlanRegister_T50_del(pProductPlanRegister_T50Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductPlanRegister_T50_del(ProductPlanRegister_T50Entity pProductPlanRegister_T50Entity)", pException);
            }
        }

        #endregion
    }

    #endregion

    #region ○ 외주품목등록
    public class ucOutsourcingInfoPopupBusiness
    {
        #region  메인 데이터 조회
        public DataTable ucOutsourcingInfo_Mst(ucOutsourcingInfoPopupEntity pucOutsourcingInfoPopupEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucOutsourcingInfoPopupProvider(pDBManager).ucOutsourcingInfoPopup_Mst(pucOutsourcingInfoPopupEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucOutsourcingInfo_Mst(ucOutsourcingInfoPopupEntity pucOutsourcingInfoPopupEntity)", pException);
            }
        }
        #endregion
    }

    #endregion

    #region ○ 출하품목등록
    public class ucShipmentInfoPopupBusiness
    {
        #region 메인 데이터 조회
        public DataTable ucShipmentInfoPopup_Mst(ucShipmentInfoPopupEntity pucShipmentInfoPopupEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucShipmentInfoPopupProvider(pDBManager).ucShipmentInfoPopup_Mst(pucShipmentInfoPopupEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "DataTable ucShipmentInfoPopup_Mst(ucShipmentInfoPopupEntity pucShipmentInfoPopupEntity)", pException);
            }
        }
        #endregion
    }
    #endregion

    #region 계약문서

    public class ucProductPlanDocumentListPopupBusiness
    {
        #region 메인 정보 조회 - ucProductPlanDocumentListPopup_Info_Main(ucProductPlanDocumentListPopupEntity pucProductPlanDocumentListPopupEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ucProductPlanDocumentListPopup_Info_Main(ucProductPlanDocumentListPopupEntity pucProductPlanDocumentListPopupEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucProductPlanDocumentListPopupProvider(pDBManager).ucProductPlanDocumentListPopup_Info_Main(pucProductPlanDocumentListPopupEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucProductPlanDocumentListPopup_Info_Main(ucProductPlanDocumentListPopupEntity pucProductPlanDocumentListPopupEntity)", pException);
            }
        }

        #endregion

        #region 서브 정보 조회 - ucPartDocumentListPopup_Info_Sub(ucPartDocumentListPopupEntity pucPartDocumentListPopupEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ucProductPlanDocumentListPopup_Info_Sub(ucProductPlanDocumentListPopupEntity pucProductPlanDocumentListPopupEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucProductPlanDocumentListPopupProvider(pDBManager).ucProductPlanDocumentListPopup_Info_Sub(pucProductPlanDocumentListPopupEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucPartDocumentListPopup_Info_Sub(ucContractDocumentListPopupEntity pucContractDocumentListPopupEntity)", pException);
            }
        }

        #endregion

        #region 정보 저장 - ucContractDocumentListPopup_Info_Save(ucContractDocumentListPopupEntity pucContractDocumentListPopupEntity, DataTable dt)

        /// <summary>
        /// 정보 저장
        /// </summary>
        public bool ucProductPlanDocumentListPopup_Info_Save(ucProductPlanDocumentListPopupEntity pucProductPlanDocumentListPopupEntity, DataTable dt)
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
                    bool isReturn = new ucProductPlanDocumentListPopupProvider(pDBManager).ucProductPlanDocumentListPopup_Info_Save(pucProductPlanDocumentListPopupEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucProductPlanDocumentListPopup_Info_Save(ucProductPlanDocumentListPopupEntity pucProductPlanDocumentListPopupEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ucProductPlanDocumentListPopupEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ucProductPlanDocumentListPopupEntity pucProductPlanDocumentListPopupEntity = new ucProductPlanDocumentListPopupProvider(null).GetEntity(pDataRow);
                return pucProductPlanDocumentListPopupEntity;
            }
            catch (Exception pException)
            {
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

    #region o 생산실적현황
    public class JobResultRegisterBusiness
    {
        #region 마스터 정보 조회 - Sample_Info(JobResultRegisterEntity pJobResultRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(JobResultRegisterEntity pJobResultRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new JobResultRegisterProvider(pDBManager).Sample_Info_Mst(pJobResultRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(JobResultRegisterEntity pJobResultRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(JobResultRegisterEntity pJobResultRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(JobResultRegisterEntity pJobResultRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new JobResultRegisterProvider(pDBManager).Sample_Info_Mst(pJobResultRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(JobResultRegisterEntity pJobResultRegisterEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(ResultStatusDataEntity pResultStatusDataEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(JobResultRegisterEntity pJobResultRegisterEntity, DataTable dt)
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
                    bool isReturn = new JobResultRegisterProvider(pDBManager).Sample_Info_Save(pJobResultRegisterEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(JobResultRegisterEntity pJobResultRegisterEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable JobResultRegister_Info_Filename(JobResultRegisterEntity pJobResultRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new JobResultRegisterProvider(pDBManager).JobResultRegister_Info_Filename(pJobResultRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "JobResultRegister_Info_Filename(JobResultRegisterEntity pJobResultRegisterEntity)", pException);
            }
        }

        #endregion

        #region XML파일 다운로드 - Templete_Download(JobResultRegisterEntity pJobResultRegisterEntity, string pMENU_NO, string pDSP_SORT)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public object Templete_Download(JobResultRegisterEntity pJobResultRegisterEntity, string pMENU_NO, string pDSP_SORT)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    object pObject = new JobResultRegisterProvider(pDBManager).Templete_Download(pJobResultRegisterEntity, pMENU_NO, pDSP_SORT);
                    return pObject;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "JobResultRegisterProvider(pDBManager).Templete_Download(pJobResultRegisterEntity, pMENU_NO, pDSP_SORT)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public JobResultRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                JobResultRegisterEntity pSampleRegisterEntity = new JobResultRegisterProvider(null).GetEntity(pDataRow);
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

    #region o 생산실적현황
    public class Facility_Utilization_StatusBusiness
    {
        #region 마스터 정보 조회 - Sample_Info(Facility_Utilization_StatusEntity pFacility_Utilization_StatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(Facility_Utilization_StatusEntity pFacility_Utilization_StatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new Facility_Utilization_StatusProvider(pDBManager).Sample_Info_Mst(pFacility_Utilization_StatusEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(Facility_Utilization_StatusEntity pFacility_Utilization_StatusEntity)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - Facility_Utilization_Status_Info_Filename(Facility_Utilization_StatusEntity pFacility_Utilization_StatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Facility_Utilization_Status_Info_Filename(Facility_Utilization_StatusEntity pFacility_Utilization_StatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new Facility_Utilization_StatusProvider(pDBManager).Facility_Utilization_Status_Info_Filename(pFacility_Utilization_StatusEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Facility_Utilization_Status_Info_Filename(Facility_Utilization_StatusEntity pFacility_Utilization_StatusEntity)", pException);
            }
        }

        #endregion
        
        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public Facility_Utilization_StatusEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                Facility_Utilization_StatusEntity pSampleRegisterEntity = new Facility_Utilization_StatusProvider(null).GetEntity(pDataRow);
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

    #region o 생산실적현황
    public class JobResultStatus_NGBusiness
    {
        #region 마스터 정보 조회 - Sample_Info(JobResultStatus_NGEntity pJobResultStatus_NGEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(JobResultStatus_NGEntity pJobResultStatus_NGEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new JobResultStatus_NGProvider(pDBManager).Sample_Info_Mst(pJobResultStatus_NGEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(JobResultStatus_NGEntity pJobResultStatus_NGEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(JobResultStatus_NGEntity pJobResultStatus_NGEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(JobResultStatus_NGEntity pJobResultStatus_NGEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new JobResultStatus_NGProvider(pDBManager).Sample_Info_Mst(pJobResultStatus_NGEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(JobResultStatus_NGEntity pJobResultStatus_NGEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(ResultStatusDataEntity pResultStatusDataEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(JobResultStatus_NGEntity pJobResultStatus_NGEntity, DataTable dt)
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
                    bool isReturn = new JobResultStatus_NGProvider(pDBManager).Sample_Info_Save(pJobResultStatus_NGEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(JobResultStatus_NGEntity pJobResultStatus_NGEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable JobResultStatus_NG_Info_Filename(JobResultStatus_NGEntity pJobResultStatus_NGEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new JobResultStatus_NGProvider(pDBManager).JobResultStatus_NG_Info_Filename(pJobResultStatus_NGEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "JobResultStatus_NG_Info_Filename(JobResultStatus_NGEntity pJobResultStatus_NGEntity)", pException);
            }
        }

        #endregion

        #region XML파일 다운로드 - Templete_Download(JobResultStatus_NGEntity pJobResultStatus_NGEntity, string pMENU_NO, string pDSP_SORT)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public object Templete_Download(JobResultStatus_NGEntity pJobResultStatus_NGEntity, string pMENU_NO, string pDSP_SORT)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    object pObject = new JobResultStatus_NGProvider(pDBManager).Templete_Download(pJobResultStatus_NGEntity, pMENU_NO, pDSP_SORT);
                    return pObject;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "JobResultStatus_NGProvider(pDBManager).Templete_Download(pJobResultStatus_NGEntity, pMENU_NO, pDSP_SORT)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public JobResultStatus_NGEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                JobResultStatus_NGEntity pSampleRegisterEntity = new JobResultStatus_NGProvider(null).GetEntity(pDataRow);
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

    #region o 생산모니터링
    public class ProductMonitoringBusiness
    {
        
        #region 마스터 정보 조회 - Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductMonitoring_Info_Filename(ProductMonitoringEntity pProductMonitoringEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductMonitoringProvider(pDBManager).ProductMonitoring_Info_Filename(pProductMonitoringEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductMonitoring_Info_Filename(ProductMonitoringEntity pProductMonitoringEntity)", pException);
            }
        }

        #endregion
       

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ProductMonitoringEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ProductMonitoringEntity pSampleRegisterEntity = new ProductMonitoringProvider(null).GetEntity(pDataRow);
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

    #region 생산모니터링T02
    public class ProductMonitoring_T02Business
    {
        /// <summary>
        /// 작업지시 정보 조회
        /// </summary>
        public DataTable ProductMonitoring_T02_Info(ProductMonitoring_T02Entity pProductMonitoring_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductMonitoring_T02Provider(pDBManager).ProductMonitoring_T02_Info_Mst2(pProductMonitoring_T02Entity);
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


    }
    #endregion

    #region 생산모니터링T03
    public class ProductMonitoring_T03Business
    {
        /// <summary>
        /// 작업지시 정보 조회
        /// </summary>
        public DataTable ProductMonitoring_T03_Info(ProductMonitoring_T03Entity pProductMonitoring_T03Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductMonitoring_T03Provider(pDBManager).ProductMonitoring_T03_Info_Mst2(pProductMonitoring_T03Entity);
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


    }
    #endregion

    #region o 생산모니터링_수주로 추적
    public class ProductMonitoring_T01Business
    {

        #region 마스터 정보 조회 - Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductMonitoring_T01_Info(ProductMonitoring_T01Entity pProductMonitoring_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductMonitoring_T01Provider(pDBManager).ProductMonitoring_T01_Info(pProductMonitoring_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductMonitoring_T01_Info_Filename(ProductMonitoring_T01Entity pProductMonitoring_T01Entity)", pException);
            }
        }

        #endregion


        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ProductMonitoring_T01Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                ProductMonitoring_T01Entity pSampleRegisterEntity = new ProductMonitoring_T01Provider(null).GetEntity(pDataRow);
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
    #region o 생산불량현황
    public class NgResultRegisterBusiness
    {
        #region 마스터 정보 조회 - Sample_Info(NgResultRegisterEntity pNgResultRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(NgResultRegisterEntity pNgResultRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new NgResultRegisterProvider(pDBManager).Sample_Info_Mst(pNgResultRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(NgResultRegisterEntity pNgResultRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(NgResultRegisterEntity pNgResultRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(NgResultRegisterEntity pNgResultRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new NgResultRegisterProvider(pDBManager).Sample_Info_Mst(pNgResultRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(NgResultRegisterEntity pNgResultRegisterEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(ResultStatusDataEntity pResultStatusDataEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(NgResultRegisterEntity pNgResultRegisterEntity, DataTable dt)
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
                    bool isReturn = new NgResultRegisterProvider(pDBManager).Sample_Info_Save(pNgResultRegisterEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(NgResultRegisterEntity pNgResultRegisterEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable NgResultRegister_Info_Filename(NgResultRegisterEntity pNgResultRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new NgResultRegisterProvider(pDBManager).NgResultRegister_Info_Filename(pNgResultRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "NgResultRegister_Info_Filename(NgResultRegisterEntity pNgResultRegisterEntity)", pException);
            }
        }

        #endregion

        #region XML파일 다운로드 - Templete_Download(NgResultRegisterEntity pNgResultRegisterEntity, string pMENU_NO, string pDSP_SORT)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public object Templete_Download(NgResultRegisterEntity pNgResultRegisterEntity, string pMENU_NO, string pDSP_SORT)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    object pObject = new NgResultRegisterProvider(pDBManager).Templete_Download(pNgResultRegisterEntity, pMENU_NO, pDSP_SORT);
                    return pObject;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "NgResultRegisterProvider(pDBManager).Templete_Download(pNgResultRegisterEntity, pMENU_NO, pDSP_SORT)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public NgResultRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                NgResultRegisterEntity pSampleRegisterEntity = new NgResultRegisterProvider(null).GetEntity(pDataRow);
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

    #region o 생산계획대비실적현황
    public class PlanResult_JobResultBusiness
    {
        #region 마스터 정보 조회 - Sample_Info(PlanResult_JobResultEntity pPlanResult_JobResultEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(PlanResult_JobResultEntity pPlanResult_JobResultEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new PlanResult_JobResultProvider(pDBManager).Sample_Info_Mst(pPlanResult_JobResultEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(PlanResult_JobResultEntity pPlanResult_JobResultEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(PlanResult_JobResultEntity pPlanResult_JobResultEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(PlanResult_JobResultEntity pPlanResult_JobResultEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new PlanResult_JobResultProvider(pDBManager).Sample_Info_Mst(pPlanResult_JobResultEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(PlanResult_JobResultEntity pPlanResult_JobResultEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(ResultStatusDataEntity pResultStatusDataEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(PlanResult_JobResultEntity pPlanResult_JobResultEntity, DataTable dt)
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
                    bool isReturn = new PlanResult_JobResultProvider(pDBManager).Sample_Info_Save(pPlanResult_JobResultEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(PlanResult_JobResultEntity pPlanResult_JobResultEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable PlanResult_JobResult_Info_Filename(PlanResult_JobResultEntity pPlanResult_JobResultEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new PlanResult_JobResultProvider(pDBManager).PlanResult_JobResult_Info_Filename(pPlanResult_JobResultEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "PlanResult_JobResult_Info_Filename(PlanResult_JobResultEntity pPlanResult_JobResultEntity)", pException);
            }
        }

        #endregion

        #region XML파일 다운로드 - Templete_Download(PlanResult_JobResultEntity pPlanResult_JobResultEntity, string pMENU_NO, string pDSP_SORT)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public object Templete_Download(PlanResult_JobResultEntity pPlanResult_JobResultEntity, string pMENU_NO, string pDSP_SORT)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    object pObject = new PlanResult_JobResultProvider(pDBManager).Templete_Download(pPlanResult_JobResultEntity, pMENU_NO, pDSP_SORT);
                    return pObject;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "PlanResult_JobResultProvider(pDBManager).Templete_Download(pPlanResult_JobResultEntity, pMENU_NO, pDSP_SORT)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public PlanResult_JobResultEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                PlanResult_JobResultEntity pSampleRegisterEntity = new PlanResult_JobResultProvider(null).GetEntity(pDataRow);
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

    #region ○ 작업일보등록

    public class WorkResultRegisterBusiness
    {
        #region ○ 데이터 조회

        public DataTable WorkResultRegister_Info_Mst(WorkResultRegisterEntity pWorkResultRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkResultRegisterProvider(pDBManager).WorkResultRegister_Info_Mst(pWorkResultRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "WorkResultRegister_Info_Mst(WorkResultRegisterEntity pWorkResultRegisterEntity)", pException);
            }
        }

        public DataTable WorkResultRegister_Info_Sub1(WorkResultRegisterEntity pWorkResultRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkResultRegisterProvider(pDBManager).WorkResultRegister_Info_Sub1(pWorkResultRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "WorkResultRegister_Info_Sub1(WorkResultRegisterEntity pWorkResultRegisterEntity)", pException);
            }
        }

        #endregion

        #region ○ 정보 저장 - WorkResultMst_Save(WorkResultRegisterEntity pWorkResultRegisterEntity, DataTable dt)

        public bool WorkResultMst_Save(WorkResultRegisterEntity pWorkResultRegisterEntity, DataTable dt)
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
                    bool isReturn = new WorkResultRegisterProvider(pDBManager).WorkResultRegister_Save(pWorkResultRegisterEntity, dtTemp);
                    return isReturn;
                }
            }
            
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "WorkResultMst_Save(WorkResultRegisterEntity pWorkResultRegisterEntity)", pException);
            }
        }

        #endregion
    }
    public class WorkResultRegister_T09Business
    {
        #region ○ 데이터 조회

        public DataTable WorkResultRegister_T09_Info_Mst(WorkResultRegister_T09Entity pWorkResultRegister_T09Entity)
        {
            try
            {

                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkResultRegister_T09Provider(pDBManager).WorkResultRegister_T09_Info_Mst(pWorkResultRegister_T09Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "WorkResultRegister_T09_Info_Mst(WorkResultRegister_T09Entity pWorkResultRegister_T09Entity)", pException);
            }
        }

        public DataTable WorkResultRegister_T09_Info_Sub1(WorkResultRegister_T09Entity pWorkResultRegister_T09Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkResultRegister_T09Provider(pDBManager).WorkResultRegister_T09_Info_Sub1(pWorkResultRegister_T09Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "WorkResultRegister_T09_Info_Sub1(WorkResultRegister_T09Entity pWorkResultRegister_T09Entity)", pException);
            }
        }

        #endregion
        #region 그리드 정보 저장 - WorkResultRegister_T09_Result_Sub1(WorkResultRegister_T09Entity pGridInfoRegisterEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool WorkResultRegister_T09_Result_Sub1(WorkResultRegister_T09Entity pWorkResultRegister_T09Entity, DataTable dt)
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

                if ((pWorkResultRegister_T09Entity.CRUD == "C" || pWorkResultRegister_T09Entity.CRUD == "U") || dtTemp.Rows.Count > 0)
                {

                    using (DBManager pDBManager = new DBManager())
                    {
                        isReturn = new WorkResultRegister_T09Provider(pDBManager).WorkResultRegister_T09_Result_Sub1(pWorkResultRegister_T09Entity, dtTemp);
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
                throw new ExceptionManager(this, "Grid_Info_Save(GridInfoRegisterEntity WorkResultRegister_T09Entity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - WorkResultRegister_T09_Result_Sub1(WorkResultRegister_T09Entity pGridInfoRegisterEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool WorkResultRegister_T09_Result_Sub2(WorkResultRegister_T09Entity pWorkResultRegister_T09Entity, DataTable dt)
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

                if ((pWorkResultRegister_T09Entity.CRUD == "C" || pWorkResultRegister_T09Entity.CRUD == "U") || dtTemp.Rows.Count > 0)
                {

                    using (DBManager pDBManager = new DBManager())
                    {
                        isReturn = new WorkResultRegister_T09Provider(pDBManager).WorkResultRegister_T09_Result_Sub2(pWorkResultRegister_T09Entity, dtTemp);
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
                throw new ExceptionManager(this, "Grid_Info_Save(GridInfoRegisterEntity pWorkResultRegister_T09Entity, DataTable dt)", pException);
            }
        }

        #endregion


        #region ○ 정보 저장 - WorkResultMst_Save(WorkResultRegister_T09Entity pWorkResultRegister_T09Entity, DataTable dt)

        public bool WorkResultMst_Save(WorkResultRegister_T09Entity pWorkResultRegister_T09Entity, DataTable dt)
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
                    bool isReturn = new WorkResultRegister_T09Provider(pDBManager).WorkResultRegister_T09_Save(pWorkResultRegister_T09Entity, dtTemp);
                    return isReturn;
                }
            }

            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "WorkResultMst_Save(WorkResultRegister_T09Entity pWorkResultRegister_T09Entity)", pException);
            }
        }

        #endregion
    }

    #endregion

    #region ○ 작업일보등록 T01

    public class WorkResultRegister_T01Business
    {
        #region ○ 데이터 조회

        public DataTable WorkResultRegister_T01_Info_Mst(WorkResultRegister_T01Entity pWorkResultRegister_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkResultRegister_T01Provider(pDBManager).WorkResultRegister_T01_Info_Mst(pWorkResultRegister_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "WorkResultRegister_T01_Info_Mst(WorkResultRegister_T01Entity pWorkResultRegister_T01Entity)", pException);
            }
        }

        public DataTable WorkResultRegister_T01_Info_Sub1(WorkResultRegister_T01Entity pWorkResultRegister_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkResultRegister_T01Provider(pDBManager).WorkResultRegister_T01_Info_Sub1(pWorkResultRegister_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "WorkResultRegister_T01_Info_Sub1(WorkResultRegister_T01Entity pWorkResultRegister_T01Entity)", pException);
            }
        }

        #endregion

        #region 시험검사 정보 저장 -WorkResultRegister_T01_Info_Check_Save(WorkResultRegister_T01Entity pWorkResultRegister_T01Entity)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        /// 
        public bool WorkResultRegister_T01_Info_Check_Save(WorkResultRegister_T01Entity pWorkResultRegister_T01Entity, DataTable dt)
        {
            try
            {
               using (DBManager pDBManager = new DBManager())
               {
                   bool isReturn = new WorkResultRegister_T01Provider(pDBManager).WorkResultRegister_T01_Info_Check_Save(pWorkResultRegister_T01Entity, dt);
                   return isReturn;
               }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "User_Info_Save(WorkResultRegister_T01Entity pWorkResultRegister_T01Entity)", pException);
            }
        }

        #endregion

        #region 작업요청 정보 저장 -WorkResultRegister_T01_Info_REQUEST_Save(WorkResultRegister_T01Entity pWorkResultRegister_T01Entity)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        /// 
        public bool WorkResultRegister_T01_Info_REQUEST_Save(WorkResultRegister_T01Entity pWorkResultRegister_T01Entity, DataTable dt)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new WorkResultRegister_T01Provider(pDBManager).WorkResultRegister_T01_Info_REQUEST_Save(pWorkResultRegister_T01Entity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "User_Info_Save(WorkResultRegister_T01Entity pWorkResultRegister_T01Entity)", pException);
            }
        }

        #endregion
    }

    #endregion

    #region ○ 작업일보등록_T03

    public class WorkResultRegister_T03Business
    {
        #region ○ 데이터 조회

        #region MAIN 조회
        public DataTable WorkResultRegister_Info_Mst(WorkResultRegister_T03Entity pWorkResultRegister_T03Entity)
        {
            try
            { 
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkResultRegister_T03Provider(pDBManager).WorkResultRegister_Info_Mst(pWorkResultRegister_T03Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "WorkResultRegister_Info_Mst(WorkResultRegister_T03Entity pWorkResultRegister_T03Entity)", pException);
            }
        }
        #endregion

        #region MAIN(LOT)_SUB 조회
        public DataTable WorkResultRegister_Info_Mst_Lot(WorkResultRegister_T03Entity pWorkResultRegister_T03Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkResultRegister_T03Provider(pDBManager).WorkResultRegister_Info_Mst_Lot(pWorkResultRegister_T03Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "WorkResultRegister_Info_Sub1(WorkResultRegister_T03Entity pWorkResultRegister_T03Entity)", pException);
            }
        }
        #endregion

        #region SUB1 조회
        public DataTable WorkResultRegister_Info_Sub_Detail1(WorkResultRegister_T03Entity pWorkResultRegister_T03Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkResultRegister_T03Provider(pDBManager).WorkResultRegister_Info_Sub_Detail1(pWorkResultRegister_T03Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "WorkResultRegister_Info_Sub_Detail1(WorkResultRegister_T03Entity pWorkResultRegister_T03Entity)", pException);
            }
        }
        #endregion

        #region SUB2 조회
        public DataTable WorkResultRegister_Info_Sub_Detail2(WorkResultRegister_T03Entity pWorkResultRegister_T03Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkResultRegister_T03Provider(pDBManager).WorkResultRegister_Info_Sub_Detail2(pWorkResultRegister_T03Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "WorkResultRegister_Info_Sub_Detail2(WorkResultRegister_T03Entity pWorkResultRegister_T03Entity)", pException);
            }
        }
        #endregion

        #region SUB3 조회
        public DataTable WorkResultRegister_Info_Sub_Detail3(WorkResultRegister_T03Entity pWorkResultRegister_T03Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkResultRegister_T03Provider(pDBManager).WorkResultRegister_Info_Sub_Detail3(pWorkResultRegister_T03Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "WorkResultRegister_Info_Sub_Detail3(WorkResultRegister_T03Entity pWorkResultRegister_T03Entity)", pException);
            }
        }
        #endregion

        #endregion

        #region LOT 생성
        public bool WorkResultRegister_Mst_Lot_save(WorkResultRegister_T03Entity pWorkResultRegister_T03Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new WorkResultRegister_T03Provider(pDBManager).WorkResultRegister_Lot_Save(pWorkResultRegister_T03Entity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "WorkResultRegister_Mst_Lot_save(WorkResultRegister_T03Entity pWorkResultRegister_T03Entity)", pException);
            }
        }
        #endregion

        #region 저장

        #region 데이터 삽입
        public bool WorkResultRegister_Save(WorkResultRegister_T03Entity pWorkResultRegister_T03Entity, DataTable dt)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new WorkResultRegister_T03Provider(pDBManager).WorkResultRegister_Save(pWorkResultRegister_T03Entity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucWorkResultPopup_Save(WorkResultRegister_T03Entity pWorkResultRegister_T03Entity)", pException);
            }
        }

        #endregion

        #region 완료처리
        public bool WorkResultRegister_Save_01(WorkResultRegister_T03Entity pWorkResultRegister_T03Entity, DataTable dt)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new WorkResultRegister_T03Provider(pDBManager).WorkResultRegister_Save_01(pWorkResultRegister_T03Entity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "usWorkResultPopup_Save_01(WorkResultRegister_T03Entity pWorkResultRegister_T03Entity)", pException);
            }
        }
        #endregion


        #endregion

    }

    #endregion

    #region ○ 작업일보등록_T04

    public class WorkResultRegister_T04Business
    {
        #region ○ 데이터 조회

        #region MAIN 조회
        public DataTable WorkResultRegister_Info_Mst(WorkResultRegister_T04Entity pWorkResultRegister_T04Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkResultRegister_T04Provider(pDBManager).WorkResultRegister_Info_Mst(pWorkResultRegister_T04Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "WorkResultRegister_Info_Mst(WorkResultRegister_T04Entity pWorkResultRegister_T04Entity)", pException);
            }
        }
        #endregion

        #region MAIN 조회(설비 확인)
        public DataTable WorkResultRegister_Info_Equip(WorkResultRegister_T04Entity pWorkResultRegister_T04Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkResultRegister_T04Provider(pDBManager).WorkResultRegister_Info_Equip(pWorkResultRegister_T04Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "WorkResultRegister_Info_Equip(WorkResultRegister_T04Entity pWorkResultRegister_T04Entity)", pException);
            }
        }
        #endregion

        #region MAIN 바인딩 조회

        public DataTable WorkResultRegister_Info_Mst_Binding(WorkResultRegister_T04Entity pWorkResultRegister_T04Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkResultRegister_T04Provider(pDBManager).WorkResultRegister_Info_Mst_Binding(pWorkResultRegister_T04Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "WorkResultRegister_Info_Mst_Binding(WorkResultRegister_T04Entity pWorkResultRegister_T04Entity)", pException);
            }
        }

        #endregion

        #region MAIN_SUB 조회
        public DataTable WorkResultRegister_Info_Mst_Lot(WorkResultRegister_T04Entity pWorkResultRegister_T04Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkResultRegister_T04Provider(pDBManager).WorkResultRegister_Info_Mst_Lot(pWorkResultRegister_T04Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "WorkResultRegister_Info_Sub1(WorkResultRegister_T04Entity pWorkResultRegister_T04Entity)", pException);
            }
        }
        #endregion

        #region PACKING 조회
        public DataTable WorkResultRegister_Info_Sub_Packing(WorkResultRegister_T04Entity pWorkResultRegister_T04Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkResultRegister_T04Provider(pDBManager).WorkResultRegister_Info_Sub_Packing(pWorkResultRegister_T04Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "WorkResultRegister_Info_Sub_Packing(WorkResultRegister_T04Entity pWorkResultRegister_T04Entity)", pException);
            }
        }
        #endregion

        #region SUB1 조회
        public DataTable WorkResultRegister_Info_Sub_Bad(WorkResultRegister_T04Entity pWorkResultRegister_T04Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkResultRegister_T04Provider(pDBManager).WorkResultRegister_Info_Sub_Bad(pWorkResultRegister_T04Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "WorkResultRegister_Info_Sub_Bad(WorkResultRegister_T04Entity pWorkResultRegister_T04Entity)", pException);
            }
        }
        #endregion

        #region SUB2 조회
        public DataTable WorkResultRegister_Info_Sub_Status(WorkResultRegister_T04Entity pWorkResultRegister_T04Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkResultRegister_T04Provider(pDBManager).WorkResultRegister_Info_Sub_Status(pWorkResultRegister_T04Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "WorkResultRegister_Info_Sub_Status(WorkResultRegister_T04Entity pWorkResultRegister_T04Entity)", pException);
            }
        }
        #endregion

        #endregion

        #region LOT 생성
        public bool WorkResultRegister_Mst_Lot_save(WorkResultRegister_T04Entity pWorkResultRegister_T04Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new WorkResultRegister_T04Provider(pDBManager).WorkResultRegister_Lot_Save(pWorkResultRegister_T04Entity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "WorkResultRegister_Mst_Lot_save(WorkResultRegister_T04Entity pWorkResultRegister_T04Entity)", pException);
            }
        }
        #endregion

        #region ○ 데이터 저장

        #region 데이터 삽입
        public bool WorkResultRegister_Save(WorkResultRegister_T04Entity pWorkResultRegister_T04Entity, DataTable dt, DataTable dtPacking, DataTable dtsub_Temp)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new WorkResultRegister_T04Provider(pDBManager).WorkResultRegister_Save(pWorkResultRegister_T04Entity, dt, dtPacking, dtsub_Temp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucWorkResultPopup_Save(WorkResultRegister_T04Entity pWorkResultRegister_T04Entity)", pException);
            }
        }

        #endregion

        #region 완료처리
        public bool WorkResultRegister_Save_01(WorkResultRegister_T04Entity pWorkResultRegister_T04Entity, DataTable dt)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new WorkResultRegister_T04Provider(pDBManager).WorkResultRegister_Save_01(pWorkResultRegister_T04Entity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "usWorkResultPopup_Save_01(WorkResultRegister_T04Entity pWorkResultRegister_T04Entity)", pException);
            }
        }
        #endregion

        #endregion

    }

    #endregion

    #region ○ 작업일보등록_T05
    public class WorkResultRegister_T05Business
    {
        #region ○ 데이터 조회

        #region MAIN 조회
        public DataTable WorkResultRegister_Info_Mst(WorkResultRegister_T05Entity pWorkResultRegister_T05Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkResultRegister_T05Provider(pDBManager).WorkResultRegister_Info_Mst(pWorkResultRegister_T05Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "WorkResultRegister_Info_Mst(WorkResultRegister_T05Entity pWorkResultRegister_T05Entity)", pException);
            }
        }
        #endregion

        #region MAIN 조회(설비 확인)
        public DataTable WorkResultRegister_Info_Equip(WorkResultRegister_T05Entity pWorkResultRegister_T05Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkResultRegister_T05Provider(pDBManager).WorkResultRegister_Info_Equip(pWorkResultRegister_T05Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "WorkResultRegister_Info_Equip(WorkResultRegister_T05Entity pWorkResultRegister_T05Entity)", pException);
            }
        }
        #endregion

        #region MAIN 바인딩 조회

        public DataTable WorkResultRegister_Info_Mst_Binding(WorkResultRegister_T05Entity pWorkResultRegister_T05Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkResultRegister_T05Provider(pDBManager).WorkResultRegister_Info_Mst_Binding(pWorkResultRegister_T05Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "WorkResultRegister_Info_Mst_Binding(WorkResultRegister_T05Entity pWorkResultRegister_T05Entity)", pException);
            }
        }

        #endregion

        #region MAIN_SUB 조회
        public DataTable WorkResultRegister_Info_Mst_Lot(WorkResultRegister_T05Entity pWorkResultRegister_T05Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkResultRegister_T05Provider(pDBManager).WorkResultRegister_Info_Mst_Lot(pWorkResultRegister_T05Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "WorkResultRegister_Info_Mst_Lot(WorkResultRegister_T05Entity pWorkResultRegister_T05Entity)", pException);
            }
        }
        #endregion

        #region PACKING 조회
        public DataTable WorkResultRegister_Info_Sub_Packing(WorkResultRegister_T05Entity pWorkResultRegister_T05Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkResultRegister_T05Provider(pDBManager).WorkResultRegister_Info_Sub_Packing(pWorkResultRegister_T05Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "WorkResultRegister_Info_Sub_Packing(WorkResultRegister_T05Entity pWorkResultRegister_T05Entity)", pException);
            }
        }
        #endregion

        #region SUB1 조회
        public DataTable WorkResultRegister_Info_Sub_Bad(WorkResultRegister_T05Entity pWorkResultRegister_T05Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkResultRegister_T05Provider(pDBManager).WorkResultRegister_Info_Sub_Bad(pWorkResultRegister_T05Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "WorkResultRegister_Info_Sub_Bad(WorkResultRegister_T05Entity pWorkResultRegister_T05Entity)", pException);
            }
        }
        #endregion

        #region SUB2 조회
        public DataTable WorkResultRegister_Info_Sub_Status(WorkResultRegister_T05Entity pWorkResultRegister_T05Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkResultRegister_T05Provider(pDBManager).WorkResultRegister_Info_Sub_Status(pWorkResultRegister_T05Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "WorkResultRegister_Info_Sub_Status(WorkResultRegister_T05Entity pWorkResultRegister_T05Entity)", pException);
            }
        }
        #endregion

        #endregion

        #region ○ 데이터 저장

        #region 데이터 삽입
        public bool WorkResultRegister_Save(WorkResultRegister_T05Entity pWorkResultRegister_T05Entity, DataTable dt, DataTable dtPacking, DataTable dtsub_Temp)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new WorkResultRegister_T05Provider(pDBManager).WorkResultRegister_Save(pWorkResultRegister_T05Entity, dt, dtPacking, dtsub_Temp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "WorkResultRegister_Save(WorkResultRegister_T05Entity pWorkResultRegister_T05Entity, DataTable dt, DataTable dtPacking)", pException);
            }
        }

        #endregion

        #region 완료처리
        public bool WorkResultRegister_Save_01(WorkResultRegister_T05Entity pWorkResultRegister_T05Entity, DataTable dt)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new WorkResultRegister_T05Provider(pDBManager).WorkResultRegister_Save_01(pWorkResultRegister_T05Entity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "WorkResultRegister_Save_01(WorkResultRegister_T05Entity pWorkResultRegister_T05Entity, DataTable dt)", pException);
            }
        }
        #endregion

        #endregion
    }
    #endregion

    #region ○ 작업일보등록_T06
    public class WorkResultRegister_T06Business
    {
        #region ○ 데이터 조회

        #region MAIN 조회
        public DataTable WorkResultRegister_Info_Mst(WorkResultRegister_T06Entity pWorkResultRegister_T06Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkResultRegister_T06Provider(pDBManager).WorkResultRegister_Info_Mst(pWorkResultRegister_T06Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "WorkResultRegister_Info_Mst(WorkResultRegister_T06Entity pWorkResultRegister_T06Entity)", pException);
            }
        }
        #endregion

        #region PACKING 조회
        public DataTable WorkResultRegister_Info_Sub(WorkResultRegister_T06Entity pWorkResultRegister_T06Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkResultRegister_T06Provider(pDBManager).WorkResultRegister_Info_Sub(pWorkResultRegister_T06Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "WorkResultRegister_Info_Sub_Shipment_Packing(WorkResultRegister_T06Entity pWorkResultRegister_T06Entity)", pException);
            }
        }
        #endregion

        #endregion

        #region ○ 데이터 저장

        #region 데이터 삽입
        public bool WorkResultRegister_Save(WorkResultRegister_T06Entity pWorkResultRegister_T06Entity, DataTable dt)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new WorkResultRegister_T06Provider(pDBManager).WorkResultRegister_Save(pWorkResultRegister_T06Entity, dt);
                    return isReturn;
                }

            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "WorkResultRegister_Save(WorkResultRegister_T05Entity pWorkResultRegister_T05Entity, DataTable dt)", pException);
            }
        }
        #endregion

        #region 완료 처리
        #endregion

        #endregion
    }
    #endregion

    #region ○ 작업일보등록(외주)
    public class OutsourcingInfoRegister_Business
    {
        #region 데이터조회

        #region MAIN 조회

        public DataTable OutsourcingInfoRegister_Info_Mst(OutsourcingInfoRegisterEntity pOutsourcingInfoRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new OutsourcingInfoRegister_Provider(pDBManager).OutsourcingInfoRegister_Info_Mst(pOutsourcingInfoRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "OutsourcingInfoRegister_Info_Mst(OutsourcingInfoRegisterEntity pOutsourcingInfoRegisterEntity)", pException);
            }
        }

        #endregion

        #region SUB 조회
        public DataTable OutsourcingInfoRegister_Info_Sub(OutsourcingInfoRegisterEntity pOutsourcingInfoRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new OutsourcingInfoRegister_Provider(pDBManager).OutsourcingInfoRegister_Info_Sub(pOutsourcingInfoRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "OutsourcingInfoRegister_Info_Sub(OutsourcingInfoRegisterEntity pOutsourcingInfoRegisterEntity)", pException);
            }
        }
        #endregion

        #endregion

        #region 데이터 저장

        #region 데이터 삽입

        public bool OutsourcingInfoRegister_Save(OutsourcingInfoRegisterEntity pOutsourcingInfoRegisterEntity, DataTable dt)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new OutsourcingInfoRegister_Provider(pDBManager).OutsourcingInfoRegister_Save(pOutsourcingInfoRegisterEntity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "OutsourcingInfoRegister_Save(OutsourcingInfoRegisterEntity pOutsourcingInfoRegisterEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #endregion
    }

    #endregion

    #region o 생산이력관리 조회
    public class ProductResultHistoryBusiness
    {
        #region 마스터 정보 조회 - ProductResultHistory_Info(ProductResultHistoryEntity pProductResultHistoryEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductResultHistory_Info(ProductResultHistoryEntity pProductResultHistoryEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductResultHistoryProvider(pDBManager).ProductResultHistory_Info_Mst(pProductResultHistoryEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductResultHistory_Info(ProductResultHistoryEntity pProductResultHistoryEntity)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ProductResultHistoryEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ProductResultHistoryEntity pProductResultHistoryEntity = new ProductResultHistoryProvider(null).GetEntity(pDataRow);
                return pProductResultHistoryEntity;
            }
            catch (Exception pException)
            {
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

    #region o 월별 목표 금액 조회
    public class ProductGoalMonthBusiness
    {
        #region 마스터 정보 조회 - ProductGoalMonth_Info(ProductGoalMonthEntity pProductGoalMonthEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductGoalMonth_Info(ProductGoalMonthEntity pProductGoalMonthEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductGoalMonthProvider(pDBManager).ProductGoalMonth_Info_Mst(pProductGoalMonthEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductGoalMonth_Info(ProductGoalMonthEntity pProductGoalMonthEntity)", pException);
            }
        }

        #endregion

        #region FPD마스터 정보 조회 - ProductGoalMonth_Info(ProductGoalMonthEntity pProductGoalMonthEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductGoalMonth_Info2(ProductGoalMonthEntity pProductGoalMonthEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductGoalMonthProvider(pDBManager).ProductGoalMonth_Info_Mst2(pProductGoalMonthEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductGoalMonth_Info(ProductGoalMonthEntity pProductGoalMonthEntity)", pException);
            }
        }

        #endregion

        #region SYS 마스터 정보 조회 - ProductGoalMonth_Info(ProductGoalMonthEntity pProductGoalMonthEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductGoalMonth_Info3(ProductGoalMonthEntity pProductGoalMonthEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductGoalMonthProvider(pDBManager).ProductGoalMonth_Info_Mst3(pProductGoalMonthEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductGoalMonth_Info(ProductGoalMonthEntity pProductGoalMonthEntity)", pException);
            }
        }

        #endregion

        #region 데이터 삽입
        public bool ProductGoalMonth_Save(ProductGoalMonthEntity pProductGoalMonthEntity, DataTable dt)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ProductGoalMonthProvider(pDBManager).ProductGoalMonth_Save(pProductGoalMonthEntity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductGoalMonth_Save(ProductGoalMonthEntity pProductGoalMonthEntity)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ProductGoalMonthEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ProductGoalMonthEntity pProductGoalMonthEntity = new ProductGoalMonthProvider(null).GetEntity(pDataRow);
                return pProductGoalMonthEntity;
            }
            catch (Exception pException)
            {
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


    #region O HPNC_작업일보등록_팝업
    public class ucWorkResultPopUp_T01Business
    {
        public bool ucWorkResultPopUp_T01_Save(ucWorkResultPopUp_T01_Entity pucWorkResultPopUp_T01_Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ucWorkResultPopUp_T01Provider(pDBManager).WorkResultInfo_Save(pucWorkResultPopUp_T01_Entity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "pucWorkResultPopUp_T01_Save(ucWorkResultPopUp_T01_Entity pucWorkResultPopUp_T01_Entity)", pException);
            }
        }
        //BOM으로 부자재 불량실적 등록
        public bool ucWorkResultPopUp_T01_Save_2(ucWorkResultPopUp_T01_Entity pucWorkResultPopUp_T01_Entity,DataTable dt)
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
                        bool isReturn = new ucWorkResultPopUp_T01Provider(pDBManager).WorkResultInfo_Save_02(pucWorkResultPopUp_T01_Entity, dtTemp);
                        return isReturn;
                    }
                    
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "pucWorkResultPopUp_T01_Save(ucWorkResultPopUp_T01_Entity pucWorkResultPopUp_T01_Entity)", pException);
            }
        }

        public DataTable ucWorkResultPopUp_T01_Info(ucWorkResultPopUp_T01_Entity pucWorkResultPopUp_T01_Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucWorkResultPopUp_T01Provider(pDBManager).WorkResultInfo_Save_T01_Info(pucWorkResultPopUp_T01_Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "WorkResultRegister_T01_Info_Mst(WorkResultRegister_T01Entity pWorkResultRegister_T01Entity)", pException);
            }
        }

        public bool usWorkResultPopup_Save_01(ucWorkResultPopUp_T01_Entity pucWorkResultPopUp_T01_Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ucWorkResultPopUp_T01Provider(pDBManager).WorkResultInfo_Save_01(pucWorkResultPopUp_T01_Entity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "pucWorkResultPopUp_T01_Save(ucWorkResultPopUp_T01_Entity pucWorkResultPopUp_T01_Entity)", pException);
            }
        }
        public bool usWorkResultPopup_Save_02(ucWorkResultPopUp_T01_Entity pucWorkResultPopUp_T01_Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ucWorkResultPopUp_T01Provider(pDBManager).WorkResultInfo_Save_02(pucWorkResultPopUp_T01_Entity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "pucWorkResultPopUp_T01_Save(ucWorkResultPopUp_T01_Entity pucWorkResultPopUp_T01_Entity)", pException);
            }
        }

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool ucWorkResultPopup_T01_Info_Save(ucWorkResultPopUp_T01_Entity pucWorkResultPopUp_T01_Entity)
        {
            try
            {

                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ucWorkResultPopUp_T01Provider(pDBManager).ucWorkResultPopup_T01_Info_Save(pucWorkResultPopUp_T01_Entity);
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
        

    }

    #endregion

    public class ucProductionPartListPopup_T01Business
    {
        #region 정보 조회 - ucProductionPartListPopup_Info_Return(ucProductionPartListPopup_T01Entity pucProductionPartListPopup_T01Entity)

        /// <summary>
        /// 정보 조회
        /// </summary>
        public DataTable ucProductionPartListPopup_Info_Return(ucProductionPartListPopup_T01Entity pucProductionPartListPopup_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucProductionPartListPopup_T01Provider(pDBManager).ucProductionPartListPopup_Info_Return(pucProductionPartListPopup_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucProductionPartListPopup_Info_Return(ucProductionPartListPopup_T01Entity pucProductionPartListPopup_T01Entity)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ucProductionPartListPopup_T01Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                ucProductionPartListPopup_T01Entity pucProductionPartListPopup_T01Entity = new ucProductionPartListPopup_T01Provider(null).GetEntity(pDataRow);
                return pucProductionPartListPopup_T01Entity;
            }
            catch (Exception pException)
            {
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

    public class ucMaterialUsagePartListPopupBusiness
    {
        #region 정보 조회 - ucMaterialUsagePartListPopup_Info_Return(ucMaterialUsagePartListPopupEntity pucMaterialUsagePartListPopupEntity)

        /// <summary>
        /// 정보 조회
        /// </summary>
        public DataTable ucMaterialUsagePartListPopup_Info_Return(ucMaterialUsagePartListPopupEntity pucMaterialUsagePartListPopupEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucMaterialUsagePartListPopupProvider(pDBManager).ucMaterialUsagePartListPopup_Info_Return(pucMaterialUsagePartListPopupEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucMaterialUsagePartListPopup_Info_Return(ucMaterialUsagePartListPopupEntity pucMaterialUsagePartListPopupEntity)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ucMaterialUsagePartListPopupEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ucMaterialUsagePartListPopupEntity pucMaterialUsagePartListPopupEntity = new ucMaterialUsagePartListPopupProvider(null).GetEntity(pDataRow);
                return pucMaterialUsagePartListPopupEntity;
            }
            catch (Exception pException)
            {
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

    public class ucMeterialUsagePopupBusiness
    {
        #region 정보 조회 - ucMeterialUsagePopup_Info_Return(ucMeterialUsagePopupEntity pucMeterialUsagePopupEntity)

        /// <summary>
        /// 정보 조회
        /// </summary>
        public DataTable ucMeterialUsagePopup_Info_Return(ucMeterialUsagePopupEntity pucMeterialUsagePopupEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucMeterialUsagePopupProvider(pDBManager).ucMeterialUsagePopup_Info_Return(pucMeterialUsagePopupEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucMeterialUsagePopup_Info_Return(ucMeterialUsagePopupEntity pucMeterialUsagePopupEntity)", pException);
            }
        }

        #endregion

        #region 서브 정보 조회 - ucMeterialUsagePopup_Sub_Return(ucMeterialUsagePopupEntity pucMeterialUsagePopupEntity)

        /// <summary>
        /// 정보 조회
        /// </summary>
        public DataTable ucMeterialUsagePopup_Sub_Return(ucMeterialUsagePopupEntity pucMeterialUsagePopupEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucMeterialUsagePopupProvider(pDBManager).ucMeterialUsagePopup_Sub_Return(pucMeterialUsagePopupEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucMeterialUsagePopup_Sub_Return(ucMeterialUsagePopupEntity pucMeterialUsagePopupEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - ucMeterialUsagePopup_Info_Save(ucMeterialUsagePopupEntity pucMeterialUsagePopupEntity, DataTable dt)
        public bool ucMeterialUsagePopup_Info_Save(ucMeterialUsagePopupEntity pucMeterialUsagePopupEntity, DataTable dt)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ucMeterialUsagePopupProvider(pDBManager).ucMeterialUsagePopup_Info_Save(pucMeterialUsagePopupEntity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucMeterialUsagePopup_Info_Save(ucMeterialUsagePopupEntity pucMeterialUsagePopupEntity, DataTable dt)", pException);
            }
        }
        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ucMeterialUsagePopupEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ucMeterialUsagePopupEntity pucMeterialUsagePopupEntity = new ucMeterialUsagePopupProvider(null).GetEntity(pDataRow);
                return pucMeterialUsagePopupEntity;
            }
            catch (Exception pException)
            {
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

    #region ○ 주문번호리스트 조회

    public class ucOrderNumberInfoListPopupBusiness
    {
        #region ○ 메인 데이터 조회

        public DataTable OrderNumber_Info_Mst(ucOrderNumberInfoListPopupEntity pucOrderNumberInfoListPopupEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucOrderNumberInfoListPopupProvider(pDBManager).OrderNumber_Info_Mst(pucOrderNumberInfoListPopupEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "OrderNumber_Info_Mst(ucOrderNumberInfoListPopupEntity pucOrderNumberInfoListPopupEntity)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ucOrderNumberInfoListPopupEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ucOrderNumberInfoListPopupEntity pucOrderNumberInfoListPopupEntity = new ucOrderNumberInfoListPopupProvider(null).GetEntity(pDataRow);
                return pucOrderNumberInfoListPopupEntity;
            }
            catch (Exception pException)
            {
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

    public class WorkRequestRegisterBusiness
    {

        #region ○ 화면명에 맞는 엑셀파일 불러오기
        public DataTable Sheet_Info_Sheet(WorkRequestRegisterEntity pWorkRequestRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pdatatable = new WorkRequestRegisterProvider(pDBManager).Sheet_Info_sheet(pWorkRequestRegisterEntity);
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


        #region 마스터 정보 조회 - Sample_Info(WorkRequestRegisterEntity pWorkRequestRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(WorkRequestRegisterEntity pWorkRequestRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkRequestRegisterProvider(pDBManager).Sample_Info_Mst(pWorkRequestRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(WorkRequestRegisterEntity pWorkRequestRegisterEntity)", pException);
            }
        }

        public DataTable Sub_BOM_Info(WorkRequestRegisterEntity pWorkRequestRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkRequestRegisterProvider(pDBManager).Sub_BOM_Info(pWorkRequestRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(WorkRequestRegisterEntity pWorkRequestRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(MaterialOrderStatusEntity pMaterialOrderStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(WorkRequestRegisterEntity pWorkRequestRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkRequestRegisterProvider(pDBManager).Sample_Info_Mst(pWorkRequestRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(WorkRequestRegisterEntity pWorkRequestRegisterEntity)", pException);
            }
        }

        #endregion

        #region 검사의뢰 마스터 정보 저장 - Sample_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool WorkRequestRegister_Info_Mst_Save(WorkRequestRegisterEntity pWorkRequestRegisterEntity, Worksheet sheet_1)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new WorkRequestRegisterProvider(pDBManager).WorkRequestRegister_Info_Mst_Save(pWorkRequestRegisterEntity, sheet_1);
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

      
        #region 검사의뢰 검사결과 정보 저장 - Sample_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool WorkRequestRegister_Info_Detail_Save(WorkRequestRegisterEntity pWorkRequestRegisterEntity, Worksheet sheet_1)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new WorkRequestRegisterProvider(pDBManager).WorkRequestRegister_Info_Detail_Save(pWorkRequestRegisterEntity, sheet_1);
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


        #region 사용자 이미지 조회 - Sample_Info(InspectFinalApprovalRegisterEntity pInspectFinalApprovalRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable GetUserImage(string CRUD, string USER_CODE)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkRequestRegisterProvider(pDBManager).GetUserImage(CRUD, USER_CODE);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(InspectFinalApprovalRegisterEntity pInspectFinalApprovalRegisterEntity)", pException);
            }
        }

        #endregion


        #region 검사의뢰 마스터 정보 저장 - Sample_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool WorkRequestRegister_Info_MAKE_NO_SAVE(WorkRequestRegisterEntity pWorkRequestRegisterEntity, Worksheet sheet_1)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new WorkRequestRegisterProvider(pDBManager).WorkRequestRegister_Info_MAKE_NO_SAVE(pWorkRequestRegisterEntity, sheet_1);
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
        public WorkRequestRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                WorkRequestRegisterEntity pWorkRequestRegisterEntity = new WorkRequestRegisterProvider(null).GetEntity(pDataRow);
                return pWorkRequestRegisterEntity;
            }
            catch (Exception pException)
            {
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

    #region 검사의뢰 조회

    public class ucWorkRequestInfoPopupBusiness
    {
        #region 시험의뢰 조회 

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public DataSet ucWorkRequestInfoPopup_Return(string pCRUD, string pFROM_DATE, string pTO_DATE, string pPRODUCTION_ORDER_ID, string pPART_NAME, string pPART_CODE, string pPROCESS_CODE_MST)
        {
            try
            {

                using (DBManager pDBManager = new DBManager())
                {
                    DataSet pDataTableSet = new ucWorkRequestInfoPopupProvider(pDBManager).ucWorkRequestInfoPopup_Return( pCRUD,  pFROM_DATE,  pTO_DATE,  pPRODUCTION_ORDER_ID,  pPART_NAME,  pPART_CODE,  pPROCESS_CODE_MST);
                    return pDataTableSet;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Excel_Info_Mst_Save(ucWorkRequestInfoPopupEntity pucWorkRequestInfoPopupEntity, DataTable dt1, DataTable dt2)", pException);
            }
        }

        #endregion
        #region 시험의뢰 접수 Insert - Mst

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool ucWorkRequestInfoPopup_Check_Save(ucWorkRequestInfoPopupEntity pucWorkRequestInfoPopupEntity, DataTable dt)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ucWorkRequestInfoPopupProvider(pDBManager).ucWorkRequestInfo_Info_Check_Save(pucWorkRequestInfoPopupEntity, dt);
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

    
    #region 검사의뢰 조회

    public class ucMakeNoMappingPopupBusiness
    {
        #region 시험의뢰 조회 

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public DataSet ucMakeNoMappingPopup_Return(string pCRUD, string pFROM_DATE, string pTO_DATE, string pPRODUCTION_ORDER_ID, string pPART_NAME, string pPART_CODE, string pPROCESS_CODE_MST)
        {
            try
            {

                using (DBManager pDBManager = new DBManager())
                {
                    DataSet pDataTableSet = new ucMakeNoMappingPopupProvider(pDBManager).ucMakeNoMappingPopup_Return( pCRUD,  pFROM_DATE,  pTO_DATE,  pPRODUCTION_ORDER_ID,  pPART_NAME,  pPART_CODE,  pPROCESS_CODE_MST);
                    return pDataTableSet;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Excel_Info_Mst_Save(ucMakeNoMappingPopupEntity pucMakeNoMappingPopupEntity, DataTable dt1, DataTable dt2)", pException);
            }
        }

        #endregion
        #region 시험의뢰 접수 Insert - Mst

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool ucMakeNoMappingPopup_Check_Save(ucMakeNoMappingPopupEntity pucMakeNoMappingPopupEntity, DataTable dt)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ucMakeNoMappingPopupProvider(pDBManager).ucWorkRequestInfo_Info_Check_Save(pucMakeNoMappingPopupEntity, dt);
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

    #region 작업지시서

    public class ucWorkOrderDocRegPopupBusiness
    {
        #region ○ 화면명에 맞는 엑셀파일 불러오기
        public DataTable Sheet_Info_Sheet(ucWorkOrderDocRegPopupEntity pucWorkOrderDocRegPopupEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucWorkOrderDocRegPopupProvider(pDBManager).Sheet_Info_sheet(pucWorkOrderDocRegPopupEntity);
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

        #region 시험의뢰 조회 

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public DataSet ucWorkOrderDocRegPopup_Return(string pCRUD, string pLANGUAGE_TYPE, string pPRODUCTION_ORDER_ID, string pPART_NAME, string pPART_CODE, string pPROCESS_CODE_MST)
        {
            try
            {

                using (DBManager pDBManager = new DBManager())
                {
                    DataSet pDataTableSet = new ucWorkOrderDocRegPopupProvider(pDBManager).ucWorkOrderDocRegPopup_Return(pCRUD, pLANGUAGE_TYPE, pPRODUCTION_ORDER_ID, pPART_NAME, pPART_CODE, pPROCESS_CODE_MST);
                    return pDataTableSet;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Excel_Info_Mst_Save(ucWorkOrderDocRegPopupEntity pucWorkOrderDocRegPopupEntity, DataTable dt1, DataTable dt2)", pException);
            }
        }

        #endregion
        #region 지시서 파일 저장

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool ucWorkOrderDocRegPopup_Save(ucWorkOrderDocRegPopupEntity pucWorkOrderDocRegPopupEntity, DataTable dt)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ucWorkOrderDocRegPopupProvider(pDBManager).ucWorkOrderDocRegPopup_Save(pucWorkOrderDocRegPopupEntity, dt);
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

        #region 지시서 파일 저장

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool ucWorkOrderDocRegPopup_Data_Save(ucWorkOrderDocRegPopupEntity pucWorkOrderDocRegPopupEntity, Worksheet pSheet)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ucWorkOrderDocRegPopupProvider(pDBManager).ucWorkOrderDocRegPopup_Data_Save(pucWorkOrderDocRegPopupEntity, pSheet);
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

        #region 사용자 이미지 조회 - Sample_Info(InspectFinalApprovalRegisterEntity pInspectFinalApprovalRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable GetUserImage(string CRUD, string USER_CODE)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucWorkOrderDocRegPopupProvider(pDBManager).GetUserImage(CRUD, USER_CODE);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(InspectFinalApprovalRegisterEntity pInspectFinalApprovalRegisterEntity)", pException);
            }
        }

        #endregion

        #region 포장/제조지시서에서 실적등록
        public bool ucWorkResultPopUp_T01_Save(ucWorkOrderDocRegPopupEntity ucWorkOrderDocRegPopupEntity, Worksheet pSheet)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ucWorkOrderDocRegPopupProvider(pDBManager).WorkResultInfo_Save(ucWorkOrderDocRegPopupEntity,pSheet);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "pucWorkResultPopUp_T01_Save(ucWorkResultPopUp_T01_Entity pucWorkResultPopUp_T01_Entity)", pException);
            }
        }
        #endregion
        #region 포장/제조지시서에서 실적등록
        public bool ucWorkResultPopUp_T02_Save(ucWorkOrderDocRegPopupEntity ucWorkOrderDocRegPopupEntity, Worksheet pSheet)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ucWorkOrderDocRegPopupProvider(pDBManager).WorkResultInfo_Save_02(ucWorkOrderDocRegPopupEntity, pSheet);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "pucWorkResultPopUp_T01_Save(ucWorkResultPopUp_T01_Entity pucWorkResultPopUp_T01_Entity)", pException);
            }
        }
        #endregion
    }


    #endregion

    #region ○ 생산계획등록_T01 팝업
    public class ProductPlanInfoPopup_T01Business
    {
        public DataSet ProductPlanInfoPopup_T01_Return(string pCRUD, string pPLANORDER)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataSet pDataTableSet = new ProductPlanInfoPopup_T01Provider(pDBManager).ProductPlanInfo_Return(pCRUD, pPLANORDER);
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

        public DataTable ProductPlanInfoPopup_T01_Save(ProductPlanInfoPopup_T01Entity pProductPlanInfoPopup_T01Entity, DataTable pDataTable)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable isReturn = new ProductPlanInfoPopup_T01Provider(pDBManager).ProductPlanInfo_Save(pProductPlanInfoPopup_T01Entity, pDataTable);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProductPlanInfoPopup_T01_Save(ProductPlanInfoPopup_T01Entity pProductPlanInfoPopup_T01Entity, DataTable pDataTable)", pException);
            }
        }
    }
    #endregion

    #region ○ 수주찾기팝업_T06 : 생산계획등록_T01팝업에서의 수주찾기팝업
    public class ucProductionOrderInfoPopup_T06Business
    {
        public DataSet ucProductionOrderInfoPopup_T06_Select(ucProductionOrderInfoPopup_T06_Entity pucProductionOrderInfoPopup_T06_Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataSet pDataTableSet = new ucProductionOrderInfoPopup_T06Provider(pDBManager).ucProductonOrderInfoPopup_T06_Return(pucProductionOrderInfoPopup_T06_Entity);
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
    #endregion

    #region ○ 작업지시등록_T03
    public class WorkOrdersRegister_T03Business
    {

        #region 마스터 정보 조회 - Sample_Info(WorkOrdersRegister_T03Entity pWorkOrdersRegister_T03Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(WorkOrdersRegister_T03Entity pWorkOrdersRegister_T03Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkOrdersRegister_T03Provider(pDBManager).Sample_Info_Mst(pWorkOrdersRegister_T03Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(WorkOrdersRegister_T03Entity pWorkOrdersRegister_T03Entity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(MaterialOrderStatusEntity pMaterialOrderStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(WorkOrdersRegister_T03Entity pWorkOrdersRegister_T03Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkOrdersRegister_T03Provider(pDBManager).Sample_Info_Mst(pWorkOrdersRegister_T03Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(WorkOrdersRegister_T03Entity pWorkOrdersRegister_T03Entity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(WorkOrdersRegister_T03Entity pWorkOrdersRegister_T03Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new WorkOrdersRegister_T03Provider(pDBManager).Sample_Info_Save(pWorkOrdersRegister_T03Entity);
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
        public WorkOrdersRegister_T03Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                WorkOrdersRegister_T03Entity pWorkOrdersRegister_T03Entity = new WorkOrdersRegister_T03Provider(null).GetEntity(pDataRow);
                return pWorkOrdersRegister_T03Entity;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "GetEntity(pDataRow)",
                    pException
                );
            }
        }
        #endregion

        #region 작업일보 조회하기 - Sample_Check_Next_Process (WorkOrdersRegister_T03Entity WorkOrdersRegister_T03Entity)

        public DataTable Sample_Check_Next_Process(WorkOrdersRegister_T03Entity pWorkResultRegister_T03Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkOrdersRegister_T03Provider(pDBManager).Sample_Check_Next_Process(pWorkResultRegister_T03Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Check_Next_Process(WorkOrdersRegister_T03Entity pWorkResultRegister_T03Entity)", pException);
            }
        }        

        #endregion
    }
    #endregion

    #region ○ 작업지시등록 신규팝업_T02 : 작업지시등록_T03에서의 신규팝업
    public class WorkOrderInfoPopup_T02Business
    {
        public DataSet WorkOrderInfoPopup_T02_Return(string pCRUD, string pPLANORDER, string pPARTCODE, WorkOrderInfoPopup_T02Entity pWorkOrderInfoPopup_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataSet pDataTableSet = new WorkOrderInfoPopup_T02Provider(pDBManager).WorkOrderInfo_Return(pCRUD, pPLANORDER, pPARTCODE, pWorkOrderInfoPopup_T02Entity);
                    return pDataTableSet;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "WorkOrderInfoPopup_T02Provider(pDBManager).WorkOrderInfo_Return(pCRUD, pPARTCODE)", pException);
            }
        }

        public bool WorkOrderInfoPopup_T02_Save(WorkOrderInfoPopup_T02Entity pWorkOrderInfoPopup_T02Entity, DataTable pDataTable)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new WorkOrderInfoPopup_T02Provider(pDBManager).WorkOrderInfo_Save(pWorkOrderInfoPopup_T02Entity, pDataTable);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "WorkOrderInfoPopup_T02_Save(WorkOrderInfoPopup_T02Entity pWorkOrderInfoPopup_T02Entity, DataTable pDataTable)", pException);
            }
        }
    }
    #endregion

    #region ○ 작업지시등록 신규팝업_T02에서의 생산계획찾기팝업
    public class pucPlanOrderinfoPopup_T01Business
    {
        public DataSet ucPlanOrderinfoPopup_T01_Select(ucPlanOrderinfoPopup_T01_Entity pucPlanOrderinfoPopup_T01_Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataSet pDataTableSet = new ucPlanOrderinfoPopup_T01Provider(pDBManager).pucPlanOrderinfoPopup_T01_Return(pucPlanOrderinfoPopup_T01_Entity);
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
    #endregion

    #region ○ 작업일보등록_T02

    public class WorkResultRegister_T02Business
    {
        #region ○ 데이터 조회

        public DataTable WorkResultRegister_T02_Info_Mst(WorkResultRegister_T02Entity pWorkResultRegister_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkResultRegister_T02Provider(pDBManager).WorkResultRegister_T02_Info_Mst(pWorkResultRegister_T02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "WorkResultRegister_T02_Info_Mst(WorkResultRegister_T02Entity pWorkResultRegister_T02Entity)", pException);
            }
        }

        public DataTable WorkResultRegister_T02_Info_Sub1(WorkResultRegister_T02Entity pWorkResultRegister_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkResultRegister_T02Provider(pDBManager).WorkResultRegister_T02_Info_Sub1(pWorkResultRegister_T02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "WorkResultRegister_T02_Info_Sub1(WorkResultRegister_T02Entity pWorkResultRegister_T02Entity)", pException);
            }
        }

        #endregion

        #region ○ 정보 저장 - WorkResultMst_Save_T02(WorkResultRegister_T02Entity pWorkResultRegister_T02Entity, DataTable dt)

        public bool WorkResultMst_Save_T02(WorkResultRegister_T02Entity pWorkResultRegister_T02Entity, DataTable dt)
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
                    bool isReturn = new WorkResultRegister_T02Provider(pDBManager).WorkResultRegister_T02_Save(pWorkResultRegister_T02Entity, dtTemp);
                    return isReturn;
                }
            }

            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "WorkResultMst_Save(WorkResultRegisterEntity pWorkResultRegisterEntity)", pException);
            }
        }

        #endregion
    }

    #endregion

    #region ○ 작업일보등록T02 신규팝업
    public class ucWorkResultPopUp_T02Business
    {
        public bool ucWorkResultPopUp_T02_Save(ucWorkResultPopUp_T02_Entity pucWorkResultPopUp_T02_Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ucWorkResultPopUp_T02Provider(pDBManager).WorkResultInfo_Save(pucWorkResultPopUp_T02_Entity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "pucWorkResultPopUp_T02_Save(ucWorkResultPopUp_T02_Entity pucWorkResultPopUp_T02_Entity)", pException);
            }
        }

        public bool usWorkResultPopUp_T02_Save_01(ucWorkResultPopUp_T02_Entity pucWorkResultPopUp_T02_Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ucWorkResultPopUp_T02Provider(pDBManager).WorkResultInfo_Save_01(pucWorkResultPopUp_T02_Entity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "pucWorkResultPopUp_T02_Save(ucWorkResultPopUp_T02_Entity pucWorkResultPopUp_T02_Entity)", pException);
            }
        }
    }
    #endregion

    #region ○ 작업일보등록_T07

    public class WorkResultRegister_T07Business
    {
        #region ○ 데이터 조회

        public DataTable WorkResultRegister_T07_Info_Mst(WorkResultRegister_T07Entity pWorkResultRegister_T07Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkResultRegister_T07Provider(pDBManager).WorkResultRegister_T07_Info_Mst(pWorkResultRegister_T07Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "WorkResultRegister_T07_Info_Mst(WorkResultRegister_T07Entity pWorkResultRegister_T07Entity)", pException);
            }
        }

        public DataTable WorkResultRegister_T07_Info_Sub1(WorkResultRegister_T07Entity pWorkResultRegister_T07Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkResultRegister_T07Provider(pDBManager).WorkResultRegister_T07_Info_Sub1(pWorkResultRegister_T07Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "WorkResultRegister_T07_Info_Sub1(WorkResultRegister_T07Entity pWorkResultRegister_T07Entity)", pException);
            }
        }

        #endregion

        #region ○ 정보 저장 - WorkResultMst_Save_T02(WorkResultRegister_T07Entity pWorkResultRegister_T07Entity, DataTable dt)

        public bool WorkResultMst_Save_T02(WorkResultRegister_T07Entity pWorkResultRegister_T07Entity, DataTable dt)
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
                    bool isReturn = new WorkResultRegister_T07Provider(pDBManager).WorkResultRegister_T07_Save(pWorkResultRegister_T07Entity, dtTemp);
                    return isReturn;
                }
            }

            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "WorkResultMst_Save(WorkResultRegisterEntity pWorkResultRegisterEntity)", pException);
            }
        }

        #endregion
    }

    #endregion

    #region ○ 작업일보등록T07 신규팝업
    public class ucWorkResultPopUp_T03Business
    {
        public bool ucWorkResultPopUp_T03_Save(ucWorkResultPopUp_T03_Entity pucWorkResultPopUp_T03_Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ucWorkResultPopUp_T03Provider(pDBManager).WorkResultInfo_Save(pucWorkResultPopUp_T03_Entity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "pucWorkResultPopUp_T03_Save(ucWorkResultPopUp_T03_Entity pucWorkResultPopUp_T03_Entity)", pException);
            }
        }

        public bool usWorkResultPopUp_T03_Save_01(ucWorkResultPopUp_T03_Entity pucWorkResultPopUp_T03_Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ucWorkResultPopUp_T03Provider(pDBManager).WorkResultInfo_Save_01(pucWorkResultPopUp_T03_Entity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "pucWorkResultPopUp_T03_Save(ucWorkResultPopUp_T03_Entity pucWorkResultPopUp_T03_Entity)", pException);
            }
        }
    }
    #endregion



    #region ○ 작업지시등록_T06
    public class WorkOrdersRegister_T06Business
    {

        #region 마스터 정보 조회 - Sample_Info(WorkOrdersRegister_T06Entity pWorkOrdersRegister_T06Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(WorkOrdersRegister_T06Entity pWorkOrdersRegister_T06Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkOrdersRegister_T06Provider(pDBManager).Sample_Info_Mst(pWorkOrdersRegister_T06Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(WorkOrdersRegister_T06Entity pWorkOrdersRegister_T06Entity)", pException);
            }
        }

        #endregion
        #region 마스터 정보 조회 - Sample_Info(WorkOrdersRegister_T06Entity pWorkOrdersRegister_T06Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info2(WorkOrdersRegister_T06Entity pWorkOrdersRegister_T06Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkOrdersRegister_T06Provider(pDBManager).Sample_Info_Mst2(pWorkOrdersRegister_T06Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(WorkOrdersRegister_T06Entity pWorkOrdersRegister_T06Entity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(MaterialOrderStatusEntity pMaterialOrderStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(WorkOrdersRegister_T06Entity pWorkOrdersRegister_T06Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkOrdersRegister_T06Provider(pDBManager).Sample_Info_Mst(pWorkOrdersRegister_T06Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(WorkOrdersRegister_T06Entity pWorkOrdersRegister_T06Entity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(WorkOrdersRegister_T06Entity pWorkOrdersRegister_T06Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new WorkOrdersRegister_T06Provider(pDBManager).Sample_Info_Save(pWorkOrdersRegister_T06Entity);
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

        #region 그리드 정보 저장 - Sample_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save2(WorkOrdersRegister_T06Entity pWorkOrdersRegister_T06Entity, DataTable dt)
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
                        isReturn = new WorkOrdersRegister_T06Provider(pDBManager).Sample_Info_Save2(pWorkOrdersRegister_T06Entity, dtTemp);
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
        public WorkOrdersRegister_T06Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                WorkOrdersRegister_T06Entity pWorkOrdersRegister_T06Entity = new WorkOrdersRegister_T06Provider(null).GetEntity(pDataRow);
                return pWorkOrdersRegister_T06Entity;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "GetEntity(pDataRow)",
                    pException
                );
            }
        }
        #endregion

        #region 작업일보 조회하기 - Sample_Check_Next_Process (WorkOrdersRegister_T06Entity WorkOrdersRegister_T06Entity)

        public DataTable Sample_Check_Next_Process(WorkOrdersRegister_T06Entity pWorkResultRegister_T03Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkOrdersRegister_T06Provider(pDBManager).Sample_Check_Next_Process(pWorkResultRegister_T03Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Check_Next_Process(WorkOrdersRegister_T06Entity pWorkResultRegister_T03Entity)", pException);
            }
        }

        #endregion
    }
    #endregion


    #region o 반/완/부재고현황_HPNC
    public class WorkReadingStatusBusiness
    {
        #region 마스터 정보 조회 - Sample_Info(WorkReadingStatusEntity pWorkReadingStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(WorkReadingStatusEntity pWorkReadingStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkReadingStatusProvider(pDBManager).Sample_Info_Mst(pWorkReadingStatusEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(WorkReadingStatusEntity pSampleRegisterEntity)", pException);
            }
        }

        #endregion


        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public WorkReadingStatusEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                WorkReadingStatusEntity pSampleRegisterEntity = new WorkReadingStatusProvider(null).GetEntity(pDataRow);
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

    #region o 반/완/부재고현황_C타입
    public class WorkResultStatus_T01Business
    {
        #region 마스터 정보 조회 - Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable WorkResultStatus_T01_Info_Filename(WorkResultStatus_T01Entity pWorkResultStatus_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkResultStatus_T01Provider(pDBManager).WorkResultStatus_T01_Info_Filename(pWorkResultStatus_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "WorkResultStatus_T01_Info_Filename(WorkResultStatus_T01Entity pWorkResultStatus_T01Entity)", pException);
            }
        }

        #endregion

        #region XML파일 다운로드 - Templete_Download(ResultStatusDataEntity pResultStatusDataEntity, string pMENU_NO, string pDSP_SORT)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public object Templete_Download(WorkResultStatus_T01Entity pWorkResultStatus_T01Entity, string pMENU_NO, string pDSP_SORT)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    object pObject = new WorkResultStatus_T01Provider(pDBManager).Templete_Download(pWorkResultStatus_T01Entity, pMENU_NO, pDSP_SORT);
                    return pObject;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "WorkResultStatus_T01Provider(pDBManager).Templete_Download(pWorkResultStatus_T01Entity, pMENU_NO, pDSP_SORT)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public WorkResultStatus_T01Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                WorkResultStatus_T01Entity pSampleRegisterEntity = new WorkResultStatus_T01Provider(null).GetEntity(pDataRow);
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

    #region ○ 작업일보등록_T50

    public class WorkResultRegister_T50Business
    {
        #region ○ 데이터 조회

        public DataTable WorkResultRegister_T50_Info_Mst(WorkResultRegister_T50Entity pWorkResultRegister_T50Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkResultRegister_T50Provider(pDBManager).WorkResultRegister_T50_Info_Mst(pWorkResultRegister_T50Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "WorkResultRegister_T50_Info_Mst(WorkResultRegister_T50Entity pWorkResultRegister_T50Entity)", pException);
            }
        }

        public DataTable WorkResultRegister_T50_Info_Sub1(WorkResultRegister_T50Entity pWorkResultRegister_T50Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkResultRegister_T50Provider(pDBManager).WorkResultRegister_T50_Info_Sub1(pWorkResultRegister_T50Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "WorkResultRegister_T50_Info_Sub1(WorkResultRegister_T50Entity pWorkResultRegister_T50Entity)", pException);
            }
        }

        #endregion

        #region ○ 정보 저장 - WorkResultMst_Save_T02(WorkResultRegister_T50Entity pWorkResultRegister_T50Entity, DataTable dt)

        public bool WorkResultMst_Save_T02(WorkResultRegister_T50Entity pWorkResultRegister_T50Entity, DataTable dt)
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
                    bool isReturn = new WorkResultRegister_T50Provider(pDBManager).WorkResultRegister_T50_Save(pWorkResultRegister_T50Entity, dtTemp);
                    return isReturn;
                }
            }

            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "WorkResultMst_Save(WorkResultRegisterEntity pWorkResultRegisterEntity)", pException);
            }
        }

        #endregion
    }

    #endregion

    #region ○ 작업일보등록T50 (대성엔지니어링)
    public class ucWorkResultPopUp_T50Business
    {
        public bool ucWorkResultPopUp_T50_Save(ucWorkResultPopUp_T50_Entity pucWorkResultPopUp_T50_Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ucWorkResultPopUp_T50Provider(pDBManager).WorkResultInfo_Save(pucWorkResultPopUp_T50_Entity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "pucWorkResultPopUp_T50_Save(ucWorkResultPopUp_T50_Entity pucWorkResultPopUp_T50_Entity)", pException);
            }
        }

        public bool usWorkResultPopUp_T02_Save_01(ucWorkResultPopUp_T50_Entity pucWorkResultPopUp_T50_Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ucWorkResultPopUp_T50Provider(pDBManager).WorkResultInfo_Save_01(pucWorkResultPopUp_T50_Entity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "pucWorkResultPopUp_T50_Save(ucWorkResultPopUp_T50_Entity pucWorkResultPopUp_T50_Entity)", pException);
            }
        }
    }
    #endregion

    public class Scheduling_T50Business
    {

        #region 작업지시 정보 조회 - Scheduling_T50_Info(Scheduling_T50Entity pScheduling_T50Entity)

        /// <summary>
        /// 작업지시 정보 조회
        /// </summary>
        public DataTable Scheduling_T50_Info(Scheduling_T50Entity pScheduling_T50Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new Scheduling_T50Provider(pDBManager).Scheduling_T50_Info(pScheduling_T50Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Scheduling_T50_Info_Filename(Scheduling_T50Entity pScheduling_T50Entity)", pException);
            }
        }

        public DataTable Scheduling_T50_R13(Scheduling_T50Entity pScheduling_T50Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new Scheduling_T50Provider(pDBManager).Scheduling_T50_R13(pScheduling_T50Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Scheduling_T50_R13(Scheduling_T50Entity pScheduling_T50Entity)", pException);
            }
        }

        #endregion


        #region 생산설비 리스트 조회 - Scheduling_T50_EquiList(Scheduling_T50Entity pScheduling_T50Entity)
        /// <summary>
        /// 생산설비 리스트 조회 조회
        /// </summary>
        public DataTable Scheduling_T50_EquiList(Scheduling_T50Entity pScheduling_T50Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new Scheduling_T50Provider(pDBManager).Scheduling_T50_EquiList(pScheduling_T50Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Scheduling_T50_Info_Filename(Scheduling_T50Entity pScheduling_T50Entity)", pException);
            }
        }
        #endregion

        #region 설비 작업지시서 조회 - ucScheduling_T50_OrderList(Scheduling_T50Entity pScheduling_T50Entity)
        /// <summary>
        /// 설비 작업지시서 조회
        /// </summary>
        public DataTable ucScheduling_T50_OrderList(Scheduling_T50Entity pScheduling_T50Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new Scheduling_T50Provider(pDBManager).ucScheduling_T50_OrderList(pScheduling_T50Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucScheduling_T50_OrderList(Scheduling_T50Entity pScheduling_T50Entity)", pException);
            }
        }
        #endregion


        #region 설비 작업지시서 배정 - ucScheduling_T50_U10(Scheduling_T50Entity pScheduling_T50Entity)
        /// <summary>
        /// 설비 작업지시서 배정
        /// </summary>
        public DataTable ucScheduling_T50_U10(Scheduling_T50Entity pScheduling_T50Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new Scheduling_T50Provider(pDBManager).ucScheduling_T50_U10(pScheduling_T50Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucScheduling_T50_U10(Scheduling_T50Entity pScheduling_T50Entity)", pException);
            }
        }
        #endregion

        #region 설비 작업지시서 순서변경 - ucScheduling_T50_U11(Scheduling_T50Entity pScheduling_T50Entity)
        /// <summary>
        /// 설비 작업지시서 배정
        /// </summary>
        public DataTable ucScheduling_T50_U11(Scheduling_T50Entity pScheduling_T50Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new Scheduling_T50Provider(pDBManager).ucScheduling_T50_U11(pScheduling_T50Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucScheduling_T50_U11(Scheduling_T50Entity pScheduling_T50Entity)", pException);
            }
        }
        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public Scheduling_T50Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                Scheduling_T50Entity pSampleRegisterEntity = new Scheduling_T50Provider(null).GetEntity(pDataRow);
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

    #region o 작업일보등록_T08
    public class WorkResultRegister_T08Business
    {

        #region 마스터 정보 조회 - Material_In_Mst(WorkResultRegister_T08Entity pWorkResultRegister_T08Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Material_In_Mst(WorkResultRegister_T08Entity pWorkResultRegister_T08Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkResultRegister_T08Provider(pDBManager).Material_In_Mst(pWorkResultRegister_T08Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(WorkResultRegister_T08Entity pWorkResultRegister_T08Entity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(MaterialOrderStatusEntity pMaterialOrderStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        //public DataTable Sample_Info_Sub(WorkResultRegister_T08Entity pWorkResultRegister_T08Entity)
        //{
        //    try
        //    {
        //        using (DBManager pDBManager = new DBManager())
        //        {
        //            //DataTable pDataTable = new WorkResultRegister_T08Provider(pDBManager).Sample_Info_Mst(pWorkResultRegister_T08Entity);
        //            //return pDataTable;
        //        }
        //    }
        //    catch (ExceptionManager pExceptionManager)
        //    {
        //        throw pExceptionManager;
        //    }
        //    catch (Exception pException)
        //    {
        //        throw new ExceptionManager(this, "Sample_Info_Sub(WorkResultRegister_T08Entity pWorkResultRegister_T08Entity)", pException);
        //    }
        //}

        #endregion

        #region 그리드 정보 저장 - WorkResultRegister_T08_Info_Save(WorkResultRegister_T08Entity pMaterialOrderStatusEntity, DataTable dt)
        public bool WorkResultRegister_T08_Info_Save(WorkResultRegister_T08Entity pWorkResultRegister_T08Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new WorkResultRegister_T08Provider(pDBManager).WorkResultRegister_T08_Info_Save(pWorkResultRegister_T08Entity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "WorkResultRegister_T08_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity)", pException);
            }
        }
        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public WorkResultRegister_T08Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                WorkResultRegister_T08Entity pWorkResultRegister_T08Entity = new WorkResultRegister_T08Provider(null).GetEntity(pDataRow);
                return pWorkResultRegister_T08Entity;
            }
            catch (Exception pException)
            {
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

    public class ucWorkOrderInfoPopup_T04Business
    {
        public DataSet ucWorkOrderInfoPopup_T04_Return(string pCRUD, string pPLANORDER, string pPARTCODE, ucWorkOrderInfoPopup_T04Entity pucWorkOrderInfoPopup_T04Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataSet pDataTableSet = new ucWorkOrderInfoPopup_T04Provider(pDBManager).WorkOrderInfo_Return(pCRUD, pPLANORDER, pPARTCODE, pucWorkOrderInfoPopup_T04Entity);
                    return pDataTableSet;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucWorkOrderInfoPopup_T04Provider(pDBManager).WorkOrderInfo_Return(pCRUD, pPARTCODE)", pException);
            }
        }

        public bool ucWorkOrderInfoPopup_T04_Save(ucWorkOrderInfoPopup_T04Entity pucWorkOrderInfoPopup_T04Entity, DataTable pDataTable)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ucWorkOrderInfoPopup_T04Provider(pDBManager).WorkOrderInfo_Save(pucWorkOrderInfoPopup_T04Entity, pDataTable);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucWorkOrderInfoPopup_T04_Save(ucWorkOrderInfoPopup_T04Entity pucWorkOrderInfoPopup_T04Entity, DataTable pDataTable)", pException);
            }
        }
    }

    public class ProductionResultState_T50Business
    {

        #region ○ 화면명에 맞는 엑셀파일 불러오기
        public DataTable Sheet_Info_Sheet(ProductionResultState_T50Entity pWorkOrdersRegister_T50Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pdatatable = new ProductionResultState_T50Provider(pDBManager).Sheet_Info_sheet(pWorkOrdersRegister_T50Entity);
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

        #region ○ 목표금액
        public DataTable SSP_PIVOT_RETURN_R10(string condition)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pdatatable = new ProductionResultState_T50Provider(pDBManager).SSP_PIVOT_RETURN_R10(condition);
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

        #region 생산실적 테이블 조회
        public DataTable USP_product_inout_R10(string condition)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pdatatable = new ProductionResultState_T50Provider(pDBManager).USP_product_inout_R10(condition);
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

        #region 마스터 정보 조회 - Sample_Info(WorkOrdersRegister_T50Entity pWorkOrdersRegister_T50Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(WorkOrdersRegister_T50Entity pWorkOrdersRegister_T50Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkOrdersRegister_T50Provider(pDBManager).Sample_Info_Mst(pWorkOrdersRegister_T50Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(WorkOrdersRegister_T50Entity pWorkOrdersRegister_T50Entity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(MaterialOrderStatusEntity pMaterialOrderStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(WorkOrdersRegister_T50Entity pWorkOrdersRegister_T50Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkOrdersRegister_T50Provider(pDBManager).Sample_Info_Mst(pWorkOrdersRegister_T50Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(WorkOrdersRegister_T50Entity pWorkOrdersRegister_T50Entity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(WorkOrdersRegister_T50Entity pWorkOrdersRegister_T50Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new WorkOrdersRegister_T50Provider(pDBManager).Sample_Info_Save(pWorkOrdersRegister_T50Entity);
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
        public WorkOrdersRegister_T50Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                WorkOrdersRegister_T50Entity pWorkOrdersRegister_T50Entity = new WorkOrdersRegister_T50Provider(null).GetEntity(pDataRow);
                return pWorkOrdersRegister_T50Entity;
            }
            catch (Exception pException)
            {
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

    public class ProductionStatusBusiness
    {
        #region 화면명에 맞는 엑셀파일 불러오기
        public DataTable ProductionStatus_Info_Filename(ProductionStatusEntity pWorkOrdersRegister_T50Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pdatatable = new ProductionStatusProvider(pDBManager).ProductionStatus_Info_Filename(pWorkOrdersRegister_T50Entity);
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
        public WorkOrdersRegister_T50Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                WorkOrdersRegister_T50Entity pWorkOrdersRegister_T50Entity = new WorkOrdersRegister_T50Provider(null).GetEntity(pDataRow);
                return pWorkOrdersRegister_T50Entity;
            }
            catch (Exception pException)
            {
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
