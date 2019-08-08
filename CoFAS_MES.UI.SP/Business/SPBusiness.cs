using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CoFAS_MES.UI.SP.Data;
using CoFAS_MES.UI.SP.Entity;

using CoFAS_MES.CORE.Entity;
using CoFAS_MES.CORE.Function;
using System.Data;

namespace CoFAS_MES.UI.SP.Business
{
    public class ShipmentPlanRegisterBusiness
    {
        #region 마스터 정보 조회 - Sample_Info(ShipmentPlanRegisterEntity pShipmentPlanRegister)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(ShipmentPlanRegisterEntity pShipmentPlanRegister)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ShipmentPlanRegisterProvider(pDBManager).Sample_Info_Mst(pShipmentPlanRegister);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(ShipmentPlanRegisterEntity pShipmentPlanRegister)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(ShipmentPlanRegisterEntity pShipmentPlanRegister)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ShipmentPlanRegisterProvider(pDBManager).Sample_Info_Mst(pShipmentPlanRegister);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(ShipmentPlanRegisterEntity pShipmentPlanRegister)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(SampleRegisterEntity pSampleRegisterEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(ShipmentPlanRegisterEntity pShipmentPlanRegister, DataTable dt)
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
                    bool isReturn = new ShipmentPlanRegisterProvider(pDBManager).Sample_Info_Save(pShipmentPlanRegister, dtTemp);
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
        public ShipmentPlanRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ShipmentPlanRegisterEntity pShipmentPlanRegisterEntity = new ShipmentPlanRegisterProvider(null).GetEntity(pDataRow);
                return pShipmentPlanRegisterEntity;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "GetEntity(pDataRow)",
                    pException
                );
            }
        }
        #endregion
    }

    public class ShipmentRegisterBusiness
    {
        #region ○ 출하지시정보 조회

        public DataTable ShipmentRegister_Info_Mst(ShipmentRegisterEntity pShipmentRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ShipmentRegisterProvider(pDBManager).ShipmentRegister_Info_Mst(pShipmentRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ShipmentRegister_Info_Mst(ShipmentRegisterEntity pShipmentRegisterEntity)", pException);
            }
        }

        #endregion

        #region ○ 출하지시정보 저장

        public bool ShipmentRegister_Info_Save(ShipmentRegisterEntity pShipmentRegisterEntity)
        {
            try
            {

                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ShipmentRegisterProvider(pDBManager).ShipmentRegister_Info_Save(pShipmentRegisterEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ShipmentRegister_Info_Save(ShipmentRegisterEntity pShipmentRegisterEntity)", pException);
            }
        }

        #endregion
    }

    public class ShipmentBaseRegister_T50Business
    {
        #region ○ 출하지시정보 조회

        public DataTable ShipmentBaseRegister_T50_Info_Mst(ShipmentBaseRegister_T50Entity pShipmentBaseRegister_T50Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ShipmentBaseRegister_T50Provider(pDBManager).ShipmentBaseRegister_T50_Info_Mst(pShipmentBaseRegister_T50Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ShipmentBaseRegister_T50_Info_Mst(ShipmentBaseRegister_T50Entity pShipmentBaseRegister_T50Entity)", pException);
            }
        }

        #endregion

        #region ○ 출하지시정보 저장

        public bool ShipmentBaseRegister_T50_Info_Save(ShipmentBaseRegister_T50Entity pShipmentBaseRegister_T50Entity)
        {
            try
            {

                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ShipmentBaseRegister_T50Provider(pDBManager).ShipmentBaseRegister_T50_Info_Save(pShipmentBaseRegister_T50Entity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ShipmentBaseRegister_T50_Info_Save(ShipmentBaseRegister_T50Entity pShipmentBaseRegister_T50Entity)", pException);
            }
        }

        #endregion
    }
    public class ShipmentRegister_T01Business
    {
        #region ○ 출하지시정보 조회

        public DataTable ShipmentRegister_T01_Info_Mst(ShipmentRegister_T01Entity pShipmentRegister_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ShipmentRegister_T01Provider(pDBManager).ShipmentRegister_T01_Info_Mst(pShipmentRegister_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ShipmentRegister_T01_Info_Mst(ShipmentRegister_T01Entity pShipmentRegister_T01Entity)", pException);
            }
        }

        #endregion

        #region ○ 출하재고정보 조회

        public DataTable ShipmentRegister_T01_Info_Sub(ShipmentRegister_T01Entity pShipmentRegister_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ShipmentRegister_T01Provider(pDBManager).ShipmentRegister_T01_Info_Sub(pShipmentRegister_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ShipmentRegister_T01_Info_Mst(ShipmentRegister_T01Entity pShipmentRegister_T01Entity)", pException);
            }
        }

        #endregion

        #region ○ 출하출고정보 조회

        public DataTable ShipmentRegister_T01_Info_Bot(ShipmentRegister_T01Entity pShipmentRegister_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ShipmentRegister_T01Provider(pDBManager).ShipmentRegister_T01_Info_Bot(pShipmentRegister_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ShipmentRegister_T01_Info_Mst(ShipmentRegister_T01Entity pShipmentRegister_T01Entity)", pException);
            }
        }

        #endregion

        #region ○ 출하지시정보 저장

        public bool ShipmentRegister_T01_Info_Save(ShipmentRegister_T01Entity pShipmentRegister_T01Entity, DataTable dt)
        {
            try
            {

                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ShipmentRegister_T01Provider(pDBManager).ShipmentRegister_T01_Info_Save(pShipmentRegister_T01Entity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ShipmentRegister_T01_Info_Save(ShipmentRegister_T01Entity pShipmentRegister_T01Entity)", pException);
            }
        }

        #endregion
    }

    public class ucShipmentRegisterInfoPopupBusiness
    {
        public DataTable ucShipmentRegisterInfoPopup_Info_Mst(ucShipmentRegisterInfoPopupEntity pucShipmentRegisterInfoPopupEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucShipmentRegisterInfoPopupProvider(pDBManager).ucShipmentRegisterInfoPopup_Info_Mst(pucShipmentRegisterInfoPopupEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch(Exception pException)
            {
                throw new ExceptionManager(this, "ucShipmentRegisterInfoPopup_Info_Mst(ucShipmentRegisterInfoPopupEntity pucShipmentRegisterInfoPopupEntity)", pException);
            }
        }
    }

    public class ucShipmentRegisterInfoPopup_T01Business
    {
        public DataTable ucShipmentRegisterInfoPopup_T01_Info_Mst(ucShipmentRegisterInfoPopup_T01Entity pucShipmentRegister_T01InfoPopupEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucShipmentRegisterInfoPopup_T01Provider(pDBManager).ucShipmentRegisterInfoPopup_T01_Info_Mst(pucShipmentRegister_T01InfoPopupEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucShipmentRegister_T01InfoPopup_Info_Mst(ucShipmentRegister_T01InfoPopupEntity pucShipmentRegister_T01InfoPopupEntity)", pException);
            }
        }
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
    public class ProductOutRegister_T01Business
    {

        #region ○ 화면명에 맞는 엑셀파일 불러오기
        public DataTable Sheet_Info_Sheet(ProductOutRegister_T01Entity pProductOutRegister_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductOutRegister_T01Provider(pDBManager).Sheet_Info_sheet(pProductOutRegister_T01Entity);
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
        public DataSet Sheet_Info_Sheet_Data(ProductOutRegister_T01Entity pProductOutRegister_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataSet pDataSet = new ProductOutRegister_T01Provider(pDBManager).Sheet_Info_Sheet_Data(pProductOutRegister_T01Entity);
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
        //#region 마스터 정보 조회 - Sample_Info(ProductOutRegister_T01Entity pProductOutRegister_T01Entity)

        ///// <summary>
        ///// 언어 정보 조회
        ///// </summary>
        //public DataTable Sample_Info(ProductOutRegister_T01Entity pProductOutRegister_T01Entity)
        //{
        //    try
        //    {
        //        using (DBManager pDBManager = new DBManager())
        //        {
        //            DataTable pDataTable = new ProductOutRegister_T01Provider(pDBManager).Sample_Info_Mst(pProductOutRegister_T01Entity);
        //            return pDataTable;
        //        }
        //    }
        //    catch (ExceptionManager pExceptionManager)
        //    {
        //        throw pExceptionManager;
        //    }
        //    catch (Exception pException)
        //    {
        //        throw new ExceptionManager(this, "Sample_Info(ProductOutRegister_T01Entity pProductOutRegister_T01Entity)", pException);
        //    }
        //}

        //#endregion

        #region 마스터 정보 조회 - ProductOutRegister_T01_Info(ProductOutRegister_T01Entity pProductOutRegister_T01Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProductOutRegister_T01_Info(ProductOutRegister_T01Entity pProductOutRegister_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductOutRegister_T01Provider(pDBManager).ProductOutRegister_T01_Info_Mst(pProductOutRegister_T01Entity);
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

        //#region 상세 정보 조회 - Sample_Info_Sub(ProductOutRegister_T01Entity pProductOutRegister_T01Entity)

        ///// <summary>
        ///// 언어 정보 조회
        ///// </summary>
        //public DataTable Sample_Info_Sub(ProductOutRegister_T01Entity pProductOutRegister_T01Entity)
        //{
        //    try
        //    {
        //        using (DBManager pDBManager = new DBManager())
        //        {
        //            DataTable pDataTable = new ProductOutRegister_T01Provider(pDBManager).Sample_Info_Mst(pProductOutRegister_T01Entity);
        //            return pDataTable;
        //        }
        //    }
        //    catch (ExceptionManager pExceptionManager)
        //    {
        //        throw pExceptionManager;
        //    }
        //    catch (Exception pException)
        //    {
        //        throw new ExceptionManager(this, "Sample_Info_Sub(ProductOutRegister_T01Entity pProductOutRegister_T01Entity)", pException);
        //    }
        //}

        //#endregion

        #region 그리드 정보 저장 - ProductOutRegister_T01_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool ProductOutRegister_T01_Info_Save(ProductOutRegister_T01Entity pProductOutRegister_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ProductOutRegister_T01Provider(pDBManager).ProductOutRegister_T01_Info_Save(pProductOutRegister_T01Entity);
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
        //public DataTable ProductOutRegister_T01_Info_Save(ProductOutRegister_T01Entity pProductOutRegister_T01Entity)
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
        //            DataTable isReturn = new ProductOutRegister_T01Provider(pDBManager).ProductOutRegister_T01_Info_Save(pProductOutRegister_T01Entity);
        //            return isReturn;
        //        }
        //    }
        //    catch (ExceptionManager pExceptionManager)
        //    {
        //        throw pExceptionManager;
        //    }
        //    catch (Exception pException)
        //    {
        //        throw new ExceptionManager(this, "Sample_Info_Save(ProductOutRegister_T01Entity pProductOutRegister_T01Entity, DataTable dt)", pException);
        //    }
        //}

        //#endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ProductOutRegister_T01Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                ProductOutRegister_T01Entity pProductOutRegister_T01Entity = new ProductOutRegister_T01Provider(null).GetEntity(pDataRow);
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
    public class ucProductionOrderInfoPopup_T05Business
    {
        public DataSet ucProductionOrderInfoPopup_T05_Select(ucProductionOrderInfoPopup_T05_Entity pucProductionOrderInfoPopup_T05_Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataSet pDataTableSet = new ucProductionOrderInfoPopup_T05Provider(pDBManager).ucProductionOrderInfoPopup_T05_Return(pucProductionOrderInfoPopup_T05_Entity);
                    return pDataTableSet;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucProductionOrderInfoPopup_T05_Select(ucProductionOrderInfoPopup_T05_Entity pucProductionOrderInfoPopup_T05_Entity)", pException);
            }
        }
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
}
