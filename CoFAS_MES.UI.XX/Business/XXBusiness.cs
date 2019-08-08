using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CoFAS_MES.UI.XX.Data;
using CoFAS_MES.UI.XX.Entity;

using CoFAS_MES.CORE.Entity;
using CoFAS_MES.CORE.Function;
using System.Data;

namespace CoFAS_MES.UI.XX.Business
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

        #region 마스터 정보 조회 - Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new SampleRegisterProvider(pDBManager).Sample_Info_Filename(pSampleRegisterEntity);
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
        public object Templete_Download(SampleRegisterEntity pSampleRegisterEntity, string pMENU_NO, string pDSP_SORT)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    object pObject = new SampleRegisterProvider(pDBManager).Templete_Download(pSampleRegisterEntity, pMENU_NO, pDSP_SORT);
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
    }

    public class UsingExcelBusiness
    {
        #region 마스터 정보 조회 - UsingExcel_Mst(UsingExcelEntity pUsingExcelEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable UsingExcel_Mst(UsingExcelEntity pUsingExcelEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new UsingExcelProvider(pDBManager).UsingExcel_Mst(pUsingExcelEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "UsingExcel_Mst(UsingExcelEntity pUsingExcelEntity)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - UsingExcel_Mst(UsingExcelEntity pUsingExcelEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ExcelForm_Mst(UsingExcelEntity pUsingExcelEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new UsingExcelProvider(pDBManager).ExcelForm_Mst(pUsingExcelEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ExcelForm_Mst(UsingExcelEntity pUsingExcelEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - UsingExcel_Sub(UsingExcelEntity pUsingExcelEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        //public DataTable UsingExcel_Sub(UsingExcelEntity pUsingExcelEntity)
        //{
        //    try
        //    {
        //        using (DBManager pDBManager = new DBManager())
        //        {
        //            //DataTable pDataTable = new UsingExcelProvider(pDBManager).Sample_Info_Sub(pUsingExcelEntity);
        //            //return pDataTable;
        //        }
        //    }
        //    catch (ExceptionManager pExceptionManager)
        //    {
        //        throw pExceptionManager;
        //    }
        //    catch (Exception pException)
        //    {
        //        throw new ExceptionManager(this, "UsingExcel_Sub(UsingExcelEntity pUsingExcelEntity)", pException);
        //    }
        //}

        #endregion

        #region 그리드 정보 저장 - UsingExcel_Save(SampleRegisterEntity pSampleRegisterEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool UsingExcel_Save(UsingExcelEntity pUsingExcelEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new UsingExcelProvider(pDBManager).UsingExcel_Save(pUsingExcelEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "UsingExcel_Save(UsingExcelEntity pUsingExcelEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public UsingExcelEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                UsingExcelEntity pUsingExcelEntity = new UsingExcelProvider(null).GetEntity(pDataRow);
                return pUsingExcelEntity;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager
                (
                    this,
                    "GetEntity(pDataRow)",
                    pException
                );
            }
        }
        #endregion
    }



    public class SampleExcelBindingBusiness
    {
        #region 마스터 정보 조회 - Sample_Info(SampleExcelBindingEntity pSampleExcelBindingEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(SampleExcelBindingEntity pSampleExcelBindingEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new SampleExcelBindingProvider(pDBManager).Sample_Info_Mst(pSampleExcelBindingEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(SampleExcelBindingEntity pSampleRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(SampleExcelBindingEntity pSampleExcelBindingEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(SampleExcelBindingEntity pSampleExcelBindingEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new SampleExcelBindingProvider(pDBManager).Sample_Info_Mst(pSampleExcelBindingEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(SampleExcelBindingEntity pSampleExcelBindingEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(SampleExcelBindingEntity pSampleExcelBindingEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(SampleExcelBindingEntity pSampleExcelBindingEntity, DataTable dt)
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
                    bool isReturn = new SampleExcelBindingProvider(pDBManager).Sample_Info_Save(pSampleExcelBindingEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(SampleExcelBindingEntity pSampleExcelBindingEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public SampleExcelBindingEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                SampleExcelBindingEntity pSampleRegisterEntity = new SampleExcelBindingProvider(null).GetEntity(pDataRow);
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
        public DataTable Sheet_Info_Sheet(SampleExcelBindingEntity pSampleExcelBindingEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pdatatable = new SampleExcelBindingProvider(pDBManager).Sheet_Info_sheet(pSampleExcelBindingEntity);
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
        //public DataTable Sheet_Info_Sheet_Data(SampleExcelBindingEntity pSampleExcelBindingEntity)
        public DataSet Sheet_Info_Sheet_Data(SampleExcelBindingEntity pSampleExcelBindingEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    // DataTable pDataTable = new SampleExcelBindingProvider(pDBManager).Sheet_Info_Sheet_Data(pSampleExcelBindingEntity);
                    DataSet pDataSet = new SampleExcelBindingProvider(pDBManager).Sheet_Info_Sheet_Data(pSampleExcelBindingEntity);
                    return pDataSet;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sheet_Info_Sheet_Data(SampleExcelBindingEntity pSampleExcelBindingEntity)", pException);
            }
        }

        #endregion

       

    }
    
    #region o 작업실적조회
    public class WorkResultViewBusiness
    {

        #region 정보 조회 - ContractMst_Info(WorkResultViewEntity pWorkResultViewEntity)

        /// <summary>
        /// 언어 정보 조회
        public DataTable ContractMst_Info(WorkResultViewEntity pWorkResultViewEntity)
        /// </summary>
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkResultViewProvider(pDBManager).WorkResultView_Info_Mst(pWorkResultViewEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ContractMst_Info(WorkResultViewEntity pWorkResultViewEntity)", pException);
            }
        }

        #endregion

        #region ○ 정보 저장 - ContractMst_Save(WorkResultViewEntity pContractMstReigsterEntity)

        public bool ContractMst_Save(WorkResultViewEntity pContractMstReigsterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new WorkResultViewProvider(pDBManager).WorkResultView_Save(pContractMstReigsterEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ContractMst_Save(WorkResultViewEntity pContractMstReigsterEntity)", pException);
            }
        }

        #endregion
    }

    #endregion

    #region o 작업실적조회2
    public class WorkResultView2Business
    {

        #region 정보 조회 - ContractMst_Info(WorkResultView2Entity pWorkResultView2Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ContractMst_Info(WorkResultView2Entity pWorkResultView2Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new WorkResultView2Provider(pDBManager).WorkResultView2_Info_Mst(pWorkResultView2Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ContractMst_Info(WorkResultView2Entity pWorkResultView2Entity)", pException);
            }
        }

        #endregion

        #region ○ 정보 저장 - ContractMst_Save(WorkResultView2Entity pContractMstReigsterEntity)

        public bool ContractMst_Save(WorkResultView2Entity pContractMstReigsterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new WorkResultView2Provider(pDBManager).WorkResultView2_Save(pContractMstReigsterEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ContractMst_Save(WorkResultView2Entity pContractMstReigsterEntity)", pException);
            }
        }

        #endregion
    }

    #endregion


    public class TestDataStatusBusiness
    {
        #region 마스터 정보 조회 - Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable TestDataStatus_Info_Filename(TestDataStatusEntity pTestDataStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new TestDataStatusProvider(pDBManager).TestDataStatus_Info_Filename(pTestDataStatusEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "TestDataStatus_Info_Filename(TestDataStatusEntity pTestDataStatusEntity)", pException);
            }
        }

        #endregion
        
        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public TestDataStatusEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                TestDataStatusEntity pSampleRegisterEntity = new TestDataStatusProvider(null).GetEntity(pDataRow);
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



}
