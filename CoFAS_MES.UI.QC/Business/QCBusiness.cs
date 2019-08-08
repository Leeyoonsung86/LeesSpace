using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CoFAS_MES.UI.QC.Data;
using CoFAS_MES.UI.QC.Entity;

using CoFAS_MES.CORE.Entity;
using CoFAS_MES.CORE.Function;
using System.Data;
using DevExpress.Spreadsheet;

namespace CoFAS_MES.UI.QC.Business
{
    
    #region o 공정온습도모니터링현황
    public class ProcessTempManagementBusiness
    {

        #region 마스터 정보 조회 - Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProcessTempManagement_Info_Filename(ProcessTempManagementEntity pProcessTempManagementEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProcessTempManagementProvider(pDBManager).ProcessTempManagement_Info_Filename(pProcessTempManagementEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProcessTempManagement_Info_Filename(ProcessTempManagementEntity pProcessTempManagementEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(ProcessTempManagementEntity pProcessTempManagementEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(ProcessTempManagementEntity pProcessTempManagementEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProcessTempManagementProvider(pDBManager).Sample_Info_Mst(pProcessTempManagementEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(ProcessTempManagementEntity pProcessTempManagementEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(ProcessTempManagementEntity pProcessTempManagementEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(ProcessTempManagementEntity pProcessTempManagementEntity, DataTable dt)
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
                    bool isReturn = new ProcessTempManagementProvider(pDBManager).Sample_Info_Save(pProcessTempManagementEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(ProcessTempManagementEntity pProcessTempManagementEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region XML파일 다운로드 - Templete_Download(ProcessTempManagementEntity pProcessTempManagementEntity, string pMENU_NO, string pDSP_SORT)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public object Templete_Download(ProcessTempManagementEntity pProcessTempManagementEntity, string pMENU_NO, string pDSP_SORT)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    object pObject = new ProcessTempManagementProvider(pDBManager).Templete_Download(pProcessTempManagementEntity, pMENU_NO, pDSP_SORT);
                    return pObject;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProcessTempManagementProvider(pDBManager).Templete_Download(pProcessTempManagementEntity, pMENU_NO, pDSP_SORT)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ProcessTempManagementEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ProcessTempManagementEntity pSampleRegisterEntity = new ProcessTempManagementProvider(null).GetEntity(pDataRow);
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

    #region 검사데이터업로드화면

    public class CheckDataRegisterBusiness
    {
        #region Excel Data Insert - Mst

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Excel_Info_Mst_Save(CheckDataRegisterEntity pCheckDataRegisterEntity, DataTable dt1, DataTable dt2)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new CheckDataRegisterlProvider(pDBManager).Excel_Info_Mst_Save(pCheckDataRegisterEntity, dt1, dt2);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Excel_Info_Mst_Save(CheckDataRegisterEntity pCheckDataRegisterEntity, DataTable dt1, DataTable dt2)", pException);
            }
        }

        #endregion
    }

    #endregion

    #region
    public class FBDDataRegisterBusiness
    { 
        public bool FBDExcel_Data_Save(FBDDataRegisterEntity pFBDDataRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new FBDDataRegisterProvider(pDBManager).MstCodeCreate(pFBDDataRegisterEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "FBDExcel_Data_Save(FBDDataRegisterEntity pFBDDataRegisterEntity, object[,] data)", pException);
            }
        }
        public bool FBDExcel_LaguageData_Save(FBDDataRegisterEntity pFBDDataRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new FBDDataRegisterProvider(pDBManager).LanguageInfoCreate(pFBDDataRegisterEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "FBDExcel_Data_Save(FBDDataRegisterEntity pFBDDataRegisterEntity, object[,] data)", pException);
            }
        }
        public bool FBDExcel_ClassificationData_Save(FBDDataRegisterEntity pFBDDataRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new FBDDataRegisterProvider(pDBManager).ClassificationCreate(pFBDDataRegisterEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "FBDExcel_Data_Save(FBDDataRegisterEntity pFBDDataRegisterEntity, object[,] data)", pException);
            }
        }
        public bool FBDExcel_Data_Save2(FBDDataRegisterEntity pFBDDataRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new FBDDataRegisterProvider(pDBManager).MstCodeCreate2(pFBDDataRegisterEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "FBDExcel_Data_Save(FBDDataRegisterEntity pFBDDataRegisterEntity, object[,] data)", pException);
            }
        }

        public bool FBDExcel_Data_Delete(object[,] data)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new FBDDataRegisterProvider(pDBManager).MstCodeDelete(data[6,6].ToString());
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "FBDExcel_Data_Delete(FBDDataRegisterEntity pFBDDataRegisterEntity, object[,] data)", pException);
            }
        }
        public bool FBDStructure_Save(FBDDataRegisterEntity pFBDDataRegisterEntity, DataTable dataTable, string filename)
        { 
            try
            {
                foreach (DataRow dr in dataTable.Rows)
                {
                    using (DBManager pDBManager = new DBManager())
                    {
                        if (!new FBDDataRegisterProvider(pDBManager).StructureCreate(pFBDDataRegisterEntity, dr, filename))
                        {
                            return true;
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
                throw new ExceptionManager(this, "FBDExcel_Data_Delete(FBDDataRegisterEntity pFBDDataRegisterEntity, object[,] data)", pException);
            }
             
            return false;
        }
        public bool FBDMemo_Save(string assignName, string filename, string memo, string usercode)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    if (!new FBDDataRegisterProvider(pDBManager).MemoCreate(assignName, filename, memo, usercode))
                    {
                        return true;
                    }
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "FBDExcel_Data_Delete(FBDDataRegisterEntity pFBDDataRegisterEntity, object[,] data)", pException);
            }

            return false;
        }

        public DataTable FBDExcel_Data_Read(FBDDataRegisterEntity pFBDDataRegisterEntity, string classifi)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new FBDDataRegisterProvider(pDBManager).FBDDataRead(pFBDDataRegisterEntity, classifi);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "FBDExcel_Data_Read(FBDDataRegisterEntity pFBDDataRegisterEntity)", pException);
            }
        }

        public DataTable Structure_Data_Read(FBDDataRegisterEntity pFBDDataRegisterEntity, string filename, int index)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new FBDDataRegisterProvider(pDBManager).StructureRead(pFBDDataRegisterEntity, filename, index);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Structure_Data_Read(FBDDataRegisterEntity pFBDDataRegisterEntity)", pException);
            }
        }

        public bool USP_recursive_test_I10(DataTable dataTable)
        {
            try
            {
                foreach (DataRow dr in dataTable.Rows)
                {
                    using (DBManager pDBManager = new DBManager())
                    {
                        if (!new FBDDataRegisterProvider(pDBManager).USP_recursive_test_I10(dr))
                        {
                            return true;
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
                throw new ExceptionManager(this, "FBDExcel_Data_Delete(FBDDataRegisterEntity pFBDDataRegisterEntity, object[,] data)", pException);
            }

            return false;
        }
        public bool USP_fbd_standard_structure_I10(DataRow dr)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    if (!new FBDDataRegisterProvider(pDBManager).USP_fbd_standard_structure_I10(dr))
                    {
                        return true;
                    }
                }
                
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "FBDExcel_Data_Delete(FBDDataRegisterEntity pFBDDataRegisterEntity, object[,] data)", pException);
            }

            return false;
        }
        public bool USP_FBS_standard_I10(DataTable dataTable, string _pLANGUAGE_TYPE)
        {
            try
            {
                foreach (DataRow dr in dataTable.Rows)
                {
                    using (DBManager pDBManager = new DBManager())
                    {
                        if (!new FBDDataRegisterProvider(pDBManager).USP_FBS_standard_I10(dr, _pLANGUAGE_TYPE))
                        {
                            return true;
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
                throw new ExceptionManager(this, "FBDExcel_Data_Delete(FBDDataRegisterEntity pFBDDataRegisterEntity, object[,] data)", pException);
            }

            return false;
        }
    }
    #endregion


    #region 검사의뢰 조회

    public class ucInspectRequestInfoPopupBusiness
    {
        #region 시험의뢰 조회 

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public DataSet ucInspectRequestInfo_Return(string pCRUD, string pFromDate, string pToDate, string pPART_NAME,string pPART_TYPE)
        {
            try
            {

                using (DBManager pDBManager = new DBManager())
                {
                    DataSet pDataTableSet = new ucInspectRequestInfoPopupProvider(pDBManager).ucInspectRequestInfo_Return(pCRUD, pFromDate, pToDate, pPART_NAME,pPART_TYPE);
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
        public bool InspectRequeestInfoPopup_Check_Save(ucInspectRequestInfoPopupEntity pucInspectRequestInfoPopupEntity, DataTable dt)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ucInspectRequestInfoPopupProvider(pDBManager).ucInspectRequeest_Info_Check_Save(pucInspectRequestInfoPopupEntity, dt);
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

    public class ucInspectRequestInfoPopup_T01Business
    {
        #region 시험의뢰 조회 

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public DataSet ucInspectRequestInfo_Return(string pCRUD, string pFromDate, string pToDate, string pPART_NAME, string pPART_TYPE)
        {
            try
            {

                using (DBManager pDBManager = new DBManager())
                {
                    DataSet pDataTableSet = new ucInspectRequestInfoPopup_T01Provider(pDBManager).ucInspectRequestInfo_Return(pCRUD, pFromDate, pToDate, pPART_NAME, pPART_TYPE);
                    return pDataTableSet;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucInspectRequestInfo_Return(string pCRUD, string pFromDate, string pToDate, string pPART_NAME, string pPART_TYPE)", pException);
            }
        }

        #endregion
        #region 시험의뢰 접수 Insert - Mst

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool InspectRequeestInfoPopup_Check_Save(ucInspectRequestInfoPopup_T01Entity pucInspectRequestInfoPopup_T01Entity, DataTable dt)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ucInspectRequestInfoPopup_T01Provider(pDBManager).ucInspectRequeest_Info_Check_Save(pucInspectRequestInfoPopup_T01Entity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "InspectRequeestInfoPopup_Check_Save(ucInspectRequestInfoPopup_T01Entity pucInspectRequestInfoPopup_T01Entity, DataTable dt)", pException);
            }
        }

        #endregion
    }


    #endregion

    #region o 초중종물검사등록_T02
    public class FirstMiddleLastInspectRegister_T02Business
    {
        #region 마스터 정보 조회 - Sample_Info(FirstMiddleLastInspectRegister_T02Entity pFirstMiddleLastInspectRegister_T02Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(FirstMiddleLastInspectRegister_T02Entity pFirstMiddleLastInspectRegister_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new FirstMiddleLastInspectRegister_T02Provider(pDBManager).Sample_Info_Mst(pFirstMiddleLastInspectRegister_T02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(FirstMiddleLastInspectRegister_T02Entity pSampleRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(FirstMiddleLastInspectRegister_T02Entity pFirstMiddleLastInspectRegister_T02Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(FirstMiddleLastInspectRegister_T02Entity pFirstMiddleLastInspectRegister_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new FirstMiddleLastInspectRegister_T02Provider(pDBManager).Sample_Info_Mst(pFirstMiddleLastInspectRegister_T02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(FirstMiddleLastInspectRegister_T02Entity pFirstMiddleLastInspectRegister_T02Entity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(FirstMiddleLastInspectRegister_T02Entity pFirstMiddleLastInspectRegister_T02Entity, pDataTable)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(FirstMiddleLastInspectRegister_T02Entity pFirstMiddleLastInspectRegister_T02Entity, DataTable pDataTable)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new FirstMiddleLastInspectRegister_T02Provider(pDBManager).Sample_Info_Save(pFirstMiddleLastInspectRegister_T02Entity, pDataTable);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "FirstMiddleLastInspectRegister_T02_Save(FirstMiddleLastInspectRegister_T02Entity pFirstMiddleLastInspectRegister_T02Entity, DataTable pDataTable)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable FirstMiddleLastInspectRegister_T02_Info_Filename(FirstMiddleLastInspectRegister_T02Entity pFirstMiddleLastInspectRegister_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new FirstMiddleLastInspectRegister_T02Provider(pDBManager).FirstMiddleLastInspectRegister_T02_Info_Filename(pFirstMiddleLastInspectRegister_T02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "FirstMiddleLastInspectRegister_T02_Info_Filename(FirstMiddleLastInspectRegister_T02Entity pFirstMiddleLastInspectRegister_T02Entity)", pException);
            }
        }

        #endregion

        #region XML파일 다운로드 - Templete_Download(FirstMiddleLastInspectRegister_T02Entity pFirstMiddleLastInspectRegister_T02Entity, string pMENU_NO, string pDSP_SORT)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public object Templete_Download(FirstMiddleLastInspectRegister_T02Entity pFirstMiddleLastInspectRegister_T02Entity, string pMENU_NO, string pDSP_SORT)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    object pObject = new FirstMiddleLastInspectRegister_T02Provider(pDBManager).Templete_Download(pFirstMiddleLastInspectRegister_T02Entity, pMENU_NO, pDSP_SORT);
                    return pObject;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "FirstMiddleLastInspectRegister_T02Provider(pDBManager).Templete_Download(pFirstMiddleLastInspectRegister_T02Entity, pMENU_NO, pDSP_SORT)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public FirstMiddleLastInspectRegister_T02Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                FirstMiddleLastInspectRegister_T02Entity pSampleRegisterEntity = new FirstMiddleLastInspectRegister_T02Provider(null).GetEntity(pDataRow);
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


    public class RawMaterialInspectRegisterBusiness
    {
        #region ○ 화면명에 맞는 엑셀파일 불러오기
        public DataTable Sheet_Info_Sheet(RawMaterialInspectRegisterEntity pRawMaterialInspectRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pdatatable = new RawMaterialInspectRegisterProvider(pDBManager).Sheet_Info_sheet(pRawMaterialInspectRegisterEntity);
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


        #region 마스터 정보 조회 - Sample_Info(RawMaterialInspectRegisterEntity pRawMaterialInspectRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(RawMaterialInspectRegisterEntity pRawMaterialInspectRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new RawMaterialInspectRegisterProvider(pDBManager).Sample_Info_Mst(pRawMaterialInspectRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(RawMaterialInspectRegisterEntity pRawMaterialInspectRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(MaterialOrderStatusEntity pMaterialOrderStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(RawMaterialInspectRegisterEntity pRawMaterialInspectRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new RawMaterialInspectRegisterProvider(pDBManager).Sample_Info_Mst(pRawMaterialInspectRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(RawMaterialInspectRegisterEntity pRawMaterialInspectRegisterEntity)", pException);
            }
        }

        #endregion

        #region 검사의뢰 마스터 정보 저장 - Sample_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool RawMaterialInspectRegister_Info_Mst_Save(RawMaterialInspectRegisterEntity pRawMaterialInspectRegisterEntity, Worksheet sheet_1)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new RawMaterialInspectRegisterProvider(pDBManager).RawMaterialInspectRegister_Info_Mst_Save(pRawMaterialInspectRegisterEntity, sheet_1);
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
        public bool RawMaterialInspectRegister_Info_Detail_Save(RawMaterialInspectRegisterEntity pRawMaterialInspectRegisterEntity, Worksheet sheet_1)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new RawMaterialInspectRegisterProvider(pDBManager).RawMaterialInspectRegister_Info_Detail_Save(pRawMaterialInspectRegisterEntity, sheet_1);
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
        public RawMaterialInspectRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                RawMaterialInspectRegisterEntity pRawMaterialInspectRegisterEntity = new RawMaterialInspectRegisterProvider(null).GetEntity(pDataRow);
                return pRawMaterialInspectRegisterEntity;
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


    public class ucImportInspectInfoPopupBusiness
    {
        #region 시험의뢰 조회 

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public DataSet ucImportInspectInfo_Return(string pCRUD, string pFromDate, string pToDate, string pPART_NAME, string pPART_TYPE)
        {
            try
            {

                using (DBManager pDBManager = new DBManager())
                {
                    DataSet pDataTableSet = new ucImportInspectInfoPopupProvider(pDBManager).ucImportInspectInfo_Return(pCRUD, pFromDate, pToDate, pPART_NAME, pPART_TYPE);
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

    }



    public class RawMaterialInspectRegisterT01Business
    {
    
        #region 마스터 정보 조회 - Sample_Info(RawMaterialInspectRegisterEntity pRawMaterialInspectRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(RawMaterialInspectRegisterT01Entity pRawMaterialInspectRegisterT01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new RawMaterialInspectRegisterT01Provider(pDBManager).Sample_Info_Mst(pRawMaterialInspectRegisterT01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "DataTable Sample_Info(RawMaterialInspectRegisterT01Entity pRawMaterialInspectRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(RawMaterialInspectRegisterT01Entity pRawMaterialInspectRegisterT01Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(RawMaterialInspectRegisterT01Entity pRawMaterialInspectRegisterT01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new RawMaterialInspectRegisterT01Provider(pDBManager).Sample_Info_Sub(pRawMaterialInspectRegisterT01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(RawMaterialInspectRegisterT01Entity pRawMaterialInspectRegisterT01Entity)", pException);
            }
        }

        #endregion

        #region 마스터 정보 저장 - Sample_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool RawMaterialInspectRegisterT01_Info_Mst_Save(RawMaterialInspectRegisterT01Entity pRawMaterialInspectRegisterT01Entity, DataTable dt)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new RawMaterialInspectRegisterT01Provider(pDBManager).RawMaterialInspectRegisterT01_Info_Mst_Save(pRawMaterialInspectRegisterT01Entity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "RawMaterialInspectT01Register_Info_Mst_Save(RawMaterialInspectRegisterT01Entity pRawMaterialInspectRegisterT01Entity)", pException);
            }
        }

        #endregion

        #region 서브 정보 저장 - Sample_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool RawMaterialInspectRegisterT01_Info_Detail_Save(RawMaterialInspectRegisterT01Entity pRawMaterialInspectRegisterT01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new RawMaterialInspectRegisterT01Provider(pDBManager).RawMaterialInspectRegisterT01_Info_Detail_Save(pRawMaterialInspectRegisterT01Entity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "RawMaterialInspectRegisterT01_Info_Detail_Save(RawMaterialInspectRegisterT01Entity pRawMaterialInspectRegisterT01Entity)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public RawMaterialInspectRegisterT01Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                RawMaterialInspectRegisterT01Entity pRawMaterialInspectRegisterT01Entity = new RawMaterialInspectRegisterT01Provider(null).GetEntity(pDataRow);
                return pRawMaterialInspectRegisterT01Entity;
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

    public class ucInspectPartListPopupBusiness
    {
        #region 정보 조회 - ucInspectPartListPopup_Info_Return(ucInspectPartListPopupEntity pucInspectPartListPopupEntity)

        /// <summary>
        /// 정보 조회
        /// </summary>
        public DataTable ucInspectPartListPopup_Info_Return(ucInspectPartListPopupEntity pucInspectPartListPopupEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucInspectPartListPopupProvider(pDBManager).ucInspectPartListPopup_Info_Return(pucInspectPartListPopupEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucInspectPartListPopup_Info_Return(ucInspectPartListPopupEntity pucInspectPartListPopupEntity)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ucInspectPartListPopupEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ucInspectPartListPopupEntity ucInspectPartListPopupEntity = new ucInspectPartListPopupProvider(null).GetEntity(pDataRow);
                return ucInspectPartListPopupEntity;
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



    public class MaterialInspectRegisterBusiness
    {

        #region ○ 화면명에 맞는 엑셀파일 불러오기
        public DataTable Sheet_Info_Sheet(MaterialInspectRegisterEntity pMaterialInspectRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pdatatable = new MaterialInspectRegisterProvider(pDBManager).Sheet_Info_sheet(pMaterialInspectRegisterEntity);
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


        #region 마스터 정보 조회 - Sample_Info(MaterialInspectRegisterEntity pMaterialInspectRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(MaterialInspectRegisterEntity pMaterialInspectRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialInspectRegisterProvider(pDBManager).Sample_Info_Mst(pMaterialInspectRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(MaterialInspectRegisterEntity pMaterialInspectRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(MaterialOrderStatusEntity pMaterialOrderStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(MaterialInspectRegisterEntity pMaterialInspectRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialInspectRegisterProvider(pDBManager).Sample_Info_Mst(pMaterialInspectRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(MaterialInspectRegisterEntity pMaterialInspectRegisterEntity)", pException);
            }
        }

        #endregion

        #region 검사의뢰 마스터 정보 저장 - Sample_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool MaterialInspectRegister_Info_Mst_Save(MaterialInspectRegisterEntity pMaterialInspectRegisterEntity, Worksheet sheet_1)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new MaterialInspectRegisterProvider(pDBManager).MaterialInspectRegister_Info_Mst_Save(pMaterialInspectRegisterEntity, sheet_1);
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
        public bool MaterialInspectRegister_Info_Detail_Save(MaterialInspectRegisterEntity pMaterialInspectRegisterEntity, Worksheet sheet_1)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new MaterialInspectRegisterProvider(pDBManager).MaterialInspectRegister_Info_Detail_Save(pMaterialInspectRegisterEntity, sheet_1);
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
        public MaterialInspectRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                MaterialInspectRegisterEntity pMaterialInspectRegisterEntity = new MaterialInspectRegisterProvider(null).GetEntity(pDataRow);
                return pMaterialInspectRegisterEntity;
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
    public class SemiProductInspectRegisterBusiness
    {
        #region ○ 화면명에 맞는 엑셀파일 불러오기
        public DataTable Sheet_Info_Sheet(SemiProductInspectRegisterEntity pSemiProductInspectRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pdatatable = new SemiProductInspectRegisterProvider(pDBManager).Sheet_Info_sheet(pSemiProductInspectRegisterEntity);
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


        #region 마스터 정보 조회 - Sample_Info(SemiProductInspectRegisterEntity pSemiProductInspectRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(SemiProductInspectRegisterEntity pSemiProductInspectRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new SemiProductInspectRegisterProvider(pDBManager).Sample_Info_Mst(pSemiProductInspectRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(SemiProductInspectRegisterEntity pSemiProductInspectRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(MaterialOrderStatusEntity pMaterialOrderStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(SemiProductInspectRegisterEntity pSemiProductInspectRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new SemiProductInspectRegisterProvider(pDBManager).Sample_Info_Mst(pSemiProductInspectRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(SemiProductInspectRegisterEntity pSemiProductInspectRegisterEntity)", pException);
            }
        }

        #endregion

        #region 검사의뢰 마스터 정보 저장 - Sample_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool SemiProductInspectRegister_Info_Mst_Save(SemiProductInspectRegisterEntity pSemiProductInspectRegisterEntity, Worksheet sheet_1)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new SemiProductInspectRegisterProvider(pDBManager).SemiProductInspectRegister_Info_Mst_Save(pSemiProductInspectRegisterEntity, sheet_1);
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
        public bool SemiProductInspectRegister_Info_Detail_Save(SemiProductInspectRegisterEntity pSemiProductInspectRegisterEntity, Worksheet sheet_1)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new SemiProductInspectRegisterProvider(pDBManager).SemiProductInspectRegister_Info_Detail_Save(pSemiProductInspectRegisterEntity, sheet_1);
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
        public SemiProductInspectRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                SemiProductInspectRegisterEntity pSemiProductInspectRegisterEntity = new SemiProductInspectRegisterProvider(null).GetEntity(pDataRow);
                return pSemiProductInspectRegisterEntity;
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
    public class ProductInspectRegisterBusiness
    {
        #region ○ 화면명에 맞는 엑셀파일 불러오기
        public DataTable Sheet_Info_Sheet(ProductInspectRegisterEntity pProductInspectRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pdatatable = new ProductInspectRegisterProvider(pDBManager).Sheet_Info_sheet(pProductInspectRegisterEntity);
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

        #region 마스터 정보 조회 - Sample_Info(ProductInspectRegisterEntity pProductInspectRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(ProductInspectRegisterEntity pProductInspectRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductInspectRegisterProvider(pDBManager).Sample_Info_Mst(pProductInspectRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(ProductInspectRegisterEntity pProductInspectRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(MaterialOrderStatusEntity pMaterialOrderStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(ProductInspectRegisterEntity pProductInspectRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductInspectRegisterProvider(pDBManager).Sample_Info_Mst(pProductInspectRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(ProductInspectRegisterEntity pProductInspectRegisterEntity)", pException);
            }
        }

        #endregion

        #region 검사의뢰 마스터 정보 저장 - Sample_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool ProductInspectRegister_Info_Mst_Save(ProductInspectRegisterEntity pProductInspectRegisterEntity, Worksheet sheet_1)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ProductInspectRegisterProvider(pDBManager).ProductInspectRegister_Info_Mst_Save(pProductInspectRegisterEntity, sheet_1);
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
        public bool ProductInspectRegister_Info_Detail_Save(ProductInspectRegisterEntity pProductInspectRegisterEntity, Worksheet sheet_1)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ProductInspectRegisterProvider(pDBManager).ProductInspectRegister_Info_Detail_Save(pProductInspectRegisterEntity, sheet_1);
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
        public ProductInspectRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ProductInspectRegisterEntity pProductInspectRegisterEntity = new ProductInspectRegisterProvider(null).GetEntity(pDataRow);
                return pProductInspectRegisterEntity;
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

    public class InspectFinalApprovalRegisterBusiness
    {

        #region ○ 화면명에 맞는 엑셀파일 불러오기
        public DataTable Sheet_Info_Sheet(string crud, string p_window_name, string p_language_type)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pdatatable = new InspectFinalApprovalRegisterProvider(pDBManager).Sheet_Info_sheet(crud,p_window_name, p_language_type);
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


        #region 마스터 정보 조회 - Sample_Info(InspectFinalApprovalRegisterEntity pInspectFinalApprovalRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(InspectFinalApprovalRegisterEntity pInspectFinalApprovalRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new InspectFinalApprovalRegisterProvider(pDBManager).Sample_Info_Mst(pInspectFinalApprovalRegisterEntity);
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
                    DataTable pDataTable = new InspectFinalApprovalRegisterProvider(pDBManager).GetUserImage(CRUD,USER_CODE);
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

        #region 상세 정보 조회 - Sample_Info_Sub(MaterialOrderStatusEntity pMaterialOrderStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(InspectFinalApprovalRegisterEntity pInspectFinalApprovalRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new InspectFinalApprovalRegisterProvider(pDBManager).Sample_Info_Mst(pInspectFinalApprovalRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(InspectFinalApprovalRegisterEntity pInspectFinalApprovalRegisterEntity)", pException);
            }
        }

        #endregion

        #region 검사의뢰 마스터 정보 저장 - Sample_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool InspectFinalApprovalRegister_Info_Mst_Save(InspectFinalApprovalRegisterEntity pInspectFinalApprovalRegisterEntity, Worksheet sheet_1)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new InspectFinalApprovalRegisterProvider(pDBManager).InspectFinalApprovalRegister_Info_Mst_Save(pInspectFinalApprovalRegisterEntity, sheet_1);
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
        public bool InspectFinalApprovalRegister_Info_Detail_Save(InspectFinalApprovalRegisterEntity pInspectFinalApprovalRegisterEntity, Worksheet sheet_1)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new InspectFinalApprovalRegisterProvider(pDBManager).InspectFinalApprovalRegister_Info_Detail_Save(pInspectFinalApprovalRegisterEntity, sheet_1);
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
 
        #region 검사의뢰 마스터 정보 저장 - Sample_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool InspectFinalApprovalRegister_Info_Delay_Save(InspectFinalApprovalRegisterEntity pInspectFinalApprovalRegisterEntity, Worksheet sheet_1)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new InspectFinalApprovalRegisterProvider(pDBManager).InspectFinalApprovalRegister_Info_Delay_Save(pInspectFinalApprovalRegisterEntity, sheet_1);
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
        public InspectFinalApprovalRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                InspectFinalApprovalRegisterEntity pInspectFinalApprovalRegisterEntity = new InspectFinalApprovalRegisterProvider(null).GetEntity(pDataRow);
                return pInspectFinalApprovalRegisterEntity;
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

    public class InspectFinalApprovalRegisterT01Business
    {

        #region 마스터 정보 조회 - InspectFinalApprovalRegisterT01_Mst_info(InspectFinalApprovalRegisterT01Entity pInspectFinalApprovalRegisterT01Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable InspectFinalApprovalRegisterT01_Mst_info(InspectFinalApprovalRegisterT01Entity pInspectFinalApprovalRegisterT01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new InspectFinalApprovalRegisterT01Provider(pDBManager).InspectFinalApprovalRegisterT01_Mst_info(pInspectFinalApprovalRegisterT01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "InspectFinalApprovalRegisterT01_mst_info(InspectFinalApprovalRegisterT01Entity pInspectFinalApprovalRegisterT01Entity)", pException);
            }
        }

        #endregion

        #region 마스터 정보 저장 -InspectFinalApprovalRegisterT01_Mst_Info_Save(InspectFinalApprovalRegisterT01Entity pInspectFinalApprovalRegisterT01Entity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool InspectFinalApprovalRegisterT01_Mst_Info_Save(InspectFinalApprovalRegisterT01Entity pInspectFinalApprovalRegisterT01Entity, DataTable dt)
        {
            try
            {
                DataTable dtTemp = dt;

                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new InspectFinalApprovalRegisterT01Provider(pDBManager).InspectFinalApprovalRegisterT01_Info_Mst_Save(pInspectFinalApprovalRegisterT01Entity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "InspectFinalApprovalRegisterT01_Mst_Info_Save(InspectFinalApprovalRegisterT01Entity pInspectFinalApprovalRegisterT01Entity, DataTable dt)", pException);
            }
        }

        #endregion
        
        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public InspectFinalApprovalRegisterT01Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                InspectFinalApprovalRegisterT01Entity pInspectFinalApprovalRegisterT01Entity = new InspectFinalApprovalRegisterT01Provider(null).GetEntity(pDataRow);
                return pInspectFinalApprovalRegisterT01Entity;
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

    public class ucMatInspectDocumentListPopupBusiness
    {
        #region 메인 정보 조회 - ucMatInspectDocumentListPopup_Info_Main(ucMatInspectDocumentListPopupEntity pucMatInspectDocumentListPopupEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ucMatInspectDocumentListPopup_Info_Main(ucMatInspectDocumentListPopupEntity pucMatInspectDocumentListPopupEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucMatInspectDocumentListPopupProvider(pDBManager).ucMatInspectDocumentListPopup_Info_Main(pucMatInspectDocumentListPopupEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucMatInspectDocumentListPopup_Info_Main(ucMatInspectDocumentListPopupEntity pucMatInspectDocumentListPopupEntity)", pException);
            }
        }

        #endregion

        #region 서브 정보 조회 - ucMatInspectDocumentListPopup_Info_Sub(ucMatInspectDocumentListPopupEntity pucMatInspectDocumentListPopupEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ucMatInspectDocumentListPopup_Info_Sub(ucMatInspectDocumentListPopupEntity pucMatInspectDocumentListPopupEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucMatInspectDocumentListPopupProvider(pDBManager).ucMatInspectDocumentListPopup_Info_Sub(pucMatInspectDocumentListPopupEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucMatInspectDocumentListPopup_Info_Sub(ucMatInspectDocumentListPopupEntity pucMatInspectDocumentListPopupEntity)", pException);
            }
        }

        #endregion

        #region 정보 저장 - ucMatInspectDocumentListPopup_Info_Save(ucMatInspectDocumentListPopupEntity pucMatInspectDocumentListPopupEntity, DataTable dt)

        /// <summary>
        /// 정보 저장
        /// </summary>
        public bool ucMatInspectDocumentListPopup_Info_Save(ucMatInspectDocumentListPopupEntity pucMatInspectDocumentListPopupEntity, DataTable dt)
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
                    bool isReturn = new ucMatInspectDocumentListPopupProvider(pDBManager).ucMatInspectDocumentListPopup_Info_Save(pucMatInspectDocumentListPopupEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucMatInspectDocumentListPopup_Info_Save(ucMatInspectDocumentListPopupEntity pucMatInspectDocumentListPopupEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ucMatInspectDocumentListPopupEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ucMatInspectDocumentListPopupEntity pucMatInspectDocumentListPopupEntity = new ucMatInspectDocumentListPopupProvider(null).GetEntity(pDataRow);
                return pucMatInspectDocumentListPopupEntity;
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
        #region 정보 조회 - ucQCMaterialPartListPopup_Info_Return(ucQCMaterialPartListPopupEntity pucQCMaterialPartListPopupEntity)
        /// <summary>
        /// 정보 조회
        /// </summary>
        public DataTable ucQCMaterialPartListPopup_Info_Return(ucQCMaterialPartListPopupEntity pucQCMaterialPartListPopupEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucQCMaterialPartListPopupProvider(pDBManager).ucQCMaterialPartListPopup_Info_Return(pucQCMaterialPartListPopupEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucQCMaterialPartListPopup_Info_Return(ucQCMaterialPartListPopupEntity pucQCMaterialPartListPopupEntity)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ucQCMaterialPartListPopupEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ucQCMaterialPartListPopupEntity pucQCMaterialPartListPopupEntity = new ucQCMaterialPartListPopupProvider(null).GetEntity(pDataRow);
                return pucQCMaterialPartListPopupEntity;
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
    public class CheckDataViewBusiness
    {
        #region 마스터 정보 조회

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Excel_Json_Mst_Info(CheckDataViewEntity pCheckDataViewEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new CheckDataViewProvider(pDBManager).Excel_Json_Mst_Info(pCheckDataViewEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Excel_Json_Mst_Info(RawMaterialInspectRegisterEntity pRawMaterialInspectRegisterEntity)", pException);
            }
        }

        #endregion

        #region 마스터 디테일 정보 조회

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Excel_Json_Mst_Sub_Info(CheckDataViewEntity pCheckDataViewEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new CheckDataViewProvider(pDBManager).Excel_Json_Mst_Sub_Info(pCheckDataViewEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Excel_Json_Mst_Sub_Info(RawMaterialInspectRegisterEntity pRawMaterialInspectRegisterEntity)", pException);
            }
        }

        #endregion

        #region 디테일 정보 조회

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Excel_Json_Sub_Info(CheckDataViewEntity pCheckDataViewEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new CheckDataViewProvider(pDBManager).Excel_Json_Sub_Info(pCheckDataViewEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Excel_Json_Sub_Info(RawMaterialInspectRegisterEntity pRawMaterialInspectRegisterEntity)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public CheckDataViewEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                CheckDataViewEntity pCheckDataViewEntity = new CheckDataViewProvider(null).GetEntity(pDataRow);
                return pCheckDataViewEntity;
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
        public DataTable Sheet_Info_Sheet(CheckDataViewEntity pCheckDataViewEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pdatatable = new CheckDataViewProvider(pDBManager).Sheet_Info_sheet(pCheckDataViewEntity);
                    return pdatatable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sheet_Info_Sheet(CheckDataViewEntity pCheckDataViewEntity)", pException);
            }
        }

        #endregion
    }

    public class CCPRegisterBusiness
    {
        #region 마스터 정보 조회 - Sample_Info(CCPRegisterEntity pCCPRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable CCPRegister_Info(CCPRegisterEntity pCCPRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new CCPRegisterProvider(pDBManager).CCPRegister_Info(pCCPRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(CCPRegisterEntity pSampleRegisterEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(CCPRegisterEntity pCCPRegisterEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool CCPRegister_Info_Save(CCPRegisterEntity pCCPRegisterEntity)
        {
            try
            {

                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new CCPRegisterProvider(pDBManager).CCPRegister_Info_Save(pCCPRegisterEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(ProductOutRegisterEntity pCCPRegisterEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public CCPRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                CCPRegisterEntity pSampleRegisterEntity = new CCPRegisterProvider(null).GetEntity(pDataRow);
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


    public class CCPDetectionRegisterBusiness
    {
        #region 마스터 정보 조회 - Sample_Info(CCPDetectionRegisterEntity pCCPDetectionRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable CCPDetectionRegister_Info(CCPDetectionRegisterEntity pCCPDetectionRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new CCPDetectionRegisterProvider(pDBManager).CCPDetectionRegister_Info(pCCPDetectionRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(CCPDetectionRegisterEntity pSampleRegisterEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(CCPDetectionRegisterEntity pCCPDetectionRegisterEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool CCPDetectionRegister_Info_Save(CCPDetectionRegisterEntity pCCPDetectionRegisterEntity)
        {
            try
            {

                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new CCPDetectionRegisterProvider(pDBManager).CCPDetectionRegister_Info_Save(pCCPDetectionRegisterEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(ProductOutRegisterEntity pCCPDetectionRegisterEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public CCPDetectionRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                CCPDetectionRegisterEntity pSampleRegisterEntity = new CCPDetectionRegisterProvider(null).GetEntity(pDataRow);
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

    #region o MaterialInspectRegister_T01
    public class MaterialInspectRegister_T01Business
    {

        #region 정보 조회 - ContractMst_Info(MaterialInspectRegister_T01Entity pMaterialInspectRegister_T01Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ContractMst_Info(MaterialInspectRegister_T01Entity pMaterialInspectRegister_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialInspectRegister_T01Provider(pDBManager).MaterialInspectRegister_T01_Info_Mst(pMaterialInspectRegister_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ContractMst_Info(MaterialInspectRegister_T01Entity pMaterialInspectRegister_T01Entity)", pException);
            }
        }

        #endregion

        #region ○ 정보 저장 - ContractMst_Save(MaterialInspectRegister_T01Entity pContractMstReigsterEntity)

        public bool ContractMst_Save(MaterialInspectRegister_T01Entity pContractMstReigsterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new MaterialInspectRegister_T01Provider(pDBManager).MaterialInspectRegister_T01_Save(pContractMstReigsterEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ContractMst_Save(MaterialInspectRegister_T01Entity pContractMstReigsterEntity)", pException);
            }
        }

        #endregion

    }

    #endregion

    #region o 초중종물검사등록
    public class FirstMiddleLastInspectRegisterBusiness
    {

        #region 정보 조회 - ContractMst_Info(FirstMiddleLastInspectRegisterEntity pFirstMiddleLastInspectRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ContractMst_Info(FirstMiddleLastInspectRegisterEntity pFirstMiddleLastInspectRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new FirstMiddleLastInspectRegisterProvider(pDBManager).FirstMiddleLastInspectRegister_Info_Mst(pFirstMiddleLastInspectRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ContractMst_Info(FirstMiddleLastInspectRegisterEntity pFirstMiddleLastInspectRegisterEntity)", pException);
            }
        }

        #endregion

        

        #region ○ 정보 저장 - ContractMst_Save(FirstMiddleLastInspectRegisterEntity pContractMstReigsterEntity)

        public bool ContractMst_Save(FirstMiddleLastInspectRegisterEntity pFirstMiddleLastInspectRegister_SaveEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new FirstMiddleLastInspectRegisterProvider(pDBManager).FirstMiddleLastInspectRegister_Save(pFirstMiddleLastInspectRegister_SaveEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ContractMst_Save(FirstMiddleLastInspectRegisterEntity pFirstMiddleLastInspectRegister_SaveEntity)", pException);
            }
        }

        #endregion

    }

    #endregion


    public class MixingDegreeRegisterBusiness
    {
        #region 마스터 정보 조회 - MixingDegreeRegister_Info(MixingDegreeRegisterEntity pMixingDegreeRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable MixingDegreeRegister_Info(MixingDegreeRegisterEntity pMixingDegreeRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MixingDegreeRegisterProvider(pDBManager).MixingDegreeRegister_Info(pMixingDegreeRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MixingDegreeRegister_Info(MixingDegreeRegisterEntity pMixingDegreeRegisterEntity)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - MixingDegreeRegister_Info(MixingDegreeRegisterEntity pMixingDegreeRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable MixingDegreeRegister_Info_Sub(MixingDegreeRegisterEntity pMixingDegreeRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MixingDegreeRegisterProvider(pDBManager).MixingDegreeRegister_Info_Sub(pMixingDegreeRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MixingDegreeRegister_Info(MixingDegreeRegisterEntity pMixingDegreeRegisterEntity)", pException);
            }
        }
        #endregion

        #region 그리드 정보 저장 - MixingDegreeRegister_Info_Save(MixingDegreeRegisterEntity pMixingDegreeRegisterEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool MixingDegreeRegister_Info_Save(MixingDegreeRegisterEntity pMixingDegreeRegisterEntity, DataTable dt)
        {
            try
            {

                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new MixingDegreeRegisterProvider(pDBManager).MixingDegreeRegister_Info_Save(pMixingDegreeRegisterEntity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MixingDegreeRegister_Info_Save(MixingDegreeRegisterEntity pMixingDegreeRegisterEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public MixingDegreeRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                MixingDegreeRegisterEntity pMixingDegreeRegisterEntity = new MixingDegreeRegisterProvider(null).GetEntity(pDataRow);
                return pMixingDegreeRegisterEntity;
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

    public class ManufacturingHistoryBusiness
    {
        #region 마스터 정보 조회 - ManufacturingHistory_Info(ManufacturingHistoryEntity pManufacturingHistoryEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ManufacturingHistory_Info(ManufacturingHistoryEntity pManufacturingHistoryEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ManufacturingHistoryProvider(pDBManager).ManufacturingHistory_Info(pManufacturingHistoryEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ManufacturingHistory_Info(ManufacturingHistoryEntity pManufacturingHistoryEntity)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - ManufacturingHistory_Sub(ManufacturingHistoryEntity pManufacturingHistoryEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ManufacturingHistory_Info_Sub(ManufacturingHistoryEntity pManufacturingHistoryEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ManufacturingHistoryProvider(pDBManager).ManufacturingHistory_Info_Sub(pManufacturingHistoryEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ManufacturingHistory_Info(ManufacturingHistoryEntity pManufacturingHistoryEntity)", pException);
            }
        }
        #endregion

        #region 마스터 정보 조회 - ManufacturingHistory_Sub2(ManufacturingHistoryEntity pManufacturingHistoryEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ManufacturingHistory_Info_Sub2(ManufacturingHistoryEntity pManufacturingHistoryEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ManufacturingHistoryProvider(pDBManager).ManufacturingHistory_Info_Sub2(pManufacturingHistoryEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ManufacturingHistory_Info(ManufacturingHistoryEntity pManufacturingHistoryEntity)", pException);
            }
        }
        #endregion

        #region 그리드 정보 저장 - ManufacturingHistory_Info_Save(ManufacturingHistoryEntity pManufacturingHistoryEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool ManufacturingHistory_Info_Save(ManufacturingHistoryEntity pManufacturingHistoryEntity, DataTable dt)
        {
            try
            {

                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ManufacturingHistoryProvider(pDBManager).ManufacturingHistory_Info_Save(pManufacturingHistoryEntity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ManufacturingHistory_Info_Save(ManufacturingHistoryEntity pManufacturingHistoryEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ManufacturingHistoryEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ManufacturingHistoryEntity pManufacturingHistoryEntity = new ManufacturingHistoryProvider(null).GetEntity(pDataRow);
                return pManufacturingHistoryEntity;
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

    public class ManufacturingHistory_T01Business
    {
        #region 마스터 정보 조회 - ManufacturingHistory_Info(ManufacturingHistoryEntity pManufacturingHistoryEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ManufacturingHistory_T01_Info(ManufacturingHistory_T01Entity pManufacturingHistory_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ManufacturingHistory_T01Provider(pDBManager).ManufacturingHistory_T01_Info(pManufacturingHistory_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ManufacturingHistory_Info(ManufacturingHistoryEntity pManufacturingHistoryEntity)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - ManufacturingHistory_Sub(ManufacturingHistoryEntity pManufacturingHistoryEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ManufacturingHistory_T01_Info_Sub(ManufacturingHistory_T01Entity pManufacturingHistory_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ManufacturingHistory_T01Provider(pDBManager).ManufacturingHistory_T01_Info_Sub(pManufacturingHistory_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ManufacturingHistory_Info(ManufacturingHistoryEntity pManufacturingHistoryEntity)", pException);
            }
        }
        #endregion

        #region 마스터 정보 조회 - ManufacturingHistory_Sub2(ManufacturingHistoryEntity pManufacturingHistoryEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ManufacturingHistory_T01_Info_Sub2(ManufacturingHistory_T01Entity pManufacturingHistory_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ManufacturingHistory_T01Provider(pDBManager).ManufacturingHistory_T01_Info_Sub2(pManufacturingHistory_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ManufacturingHistory_Info(ManufacturingHistoryEntity pManufacturingHistoryEntity)", pException);
            }
        }
        #endregion

        #region 그리드 정보 저장 - ManufacturingHistory_Info_Save(ManufacturingHistoryEntity pManufacturingHistoryEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool ManufacturingHistory_Info_Save(ManufacturingHistoryEntity pManufacturingHistoryEntity, DataTable dt)
        {
            try
            {

                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ManufacturingHistoryProvider(pDBManager).ManufacturingHistory_Info_Save(pManufacturingHistoryEntity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ManufacturingHistory_Info_Save(ManufacturingHistoryEntity pManufacturingHistoryEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ManufacturingHistory_T01Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                ManufacturingHistory_T01Entity pManufacturingHistory_T01Entity = new ManufacturingHistory_T01Provider(null).GetEntity(pDataRow);
                return pManufacturingHistory_T01Entity;
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

    public class FirstMiddleLastItemBusiness
    {
        #region 마스터 정보 조회 - ManufacturingHistory_Info(ManufacturingHistoryEntity pManufacturingHistoryEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable FirstMiddleLast_Item_Info(FirstMiddleLastItemEntity pFirstMiddleLastItemEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new FirstMiddleLastItemProvider(pDBManager).FirstMiddleLast_Item_Info(pFirstMiddleLastItemEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ManufacturingHistory_Info(ManufacturingHistoryEntity pManufacturingHistoryEntity)", pException);
            }
        }

        #endregion



        #region 그리드 정보 저장 - ManufacturingHistory_Info_Save(ManufacturingHistoryEntity pManufacturingHistoryEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool FirstMiddleLast_Item_Info_Save(FirstMiddleLastItemEntity pFirstMiddleLastEntity, DataTable dt)
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
                        isReturn = new FirstMiddleLastItemProvider(pDBManager).FirstMiddleLast_Item_Info_Save(pFirstMiddleLastEntity, dtTemp);
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
                throw new ExceptionManager(this, "ManufacturingHistory_Info_Save(ManufacturingHistoryEntity pManufacturingHistoryEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public FirstMiddleLastItemEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                FirstMiddleLastItemEntity pFirstMiddleLastItemEntity = new FirstMiddleLastItemProvider(null).GetEntity(pDataRow);
                return pFirstMiddleLastItemEntity;
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

    public class QualityInspectBusiness
    {
        #region 마스터 정보 조회 - QualityInspect_Info(QualityInspectEntity pQualityInspectEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable QualityInspect_Info(QualityInspectEntity pQualityInspectEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new QualityInspectProvider(pDBManager).QualityInspect_Info(pQualityInspectEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "QualityInspect_Info(QualityInspectEntity pQualityInspectEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - QualityInspect_Info_Save(QualityInspectEntity pQualityInspectEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool QualityInspect_Info_Save(QualityInspectEntity pQualityInspectEntity, DataTable dt)
        {
            try
            {

                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new QualityInspectProvider(pDBManager).QualityInspect_Info_Save(pQualityInspectEntity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "QualityInspect_Info_Save(QualityInspectEntity pQualityInspectEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public QualityInspectEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                QualityInspectEntity pQualityInspectEntity = new QualityInspectProvider(null).GetEntity(pDataRow);
                return pQualityInspectEntity;
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

    public class ImportInspectRegisterBusiness
    {
        #region 마스터 정보 조회 - ImportInspectRegister_Info(ImportInspectRegisterEntity _pImportInspectRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable _pImportInspectRegister_Info(ImportInspectRegisterEntity _pImportInspectRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ImportInspectRegisterProvider(pDBManager).ImportInspectRegister_Info(_pImportInspectRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ImportInspectRegisterEntity_Info(ImportInspectRegisterEntity pImportInspectRegisterEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - QualityInspect_Info_Save(QualityInspectEntity pQualityInspectEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool ImportInspect_Info_Save(ImportInspectRegisterEntity _pImportInspectRegisterEntity)
        {
            try
            {

                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ImportInspectRegisterProvider(pDBManager).ImportInspectRegister_Info_Save(_pImportInspectRegisterEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "QualityInspect_Info_Save(QualityInspectEntity pQualityInspectEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ImportInspectRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ImportInspectRegisterEntity pImportInspectRegisterEntity = new ImportInspectRegisterProvider(null).GetEntity(pDataRow);
                return pImportInspectRegisterEntity;
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



    public class HACCPCheckRegisterBusiness
    {
        #region ○ 화면명에 맞는 엑셀파일 불러오기
        public DataTable Sheet_Info_Sheet(HACCPCheckRegisterEntity pHACCPCheckRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pdatatable = new HACCPCheckRegisterProvider(pDBManager).Sheet_Info_sheet(pHACCPCheckRegisterEntity);
                    return pdatatable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sheet_Info_Sheet(HACCPCheckRegisterEntity _pHACCPCheckRegisterEntity)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - HACCPCheckRegister_Info(HACCPCheckRegisterEntity pHACCPCheckRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable HACCPCheckRegister_Info(HACCPCheckRegisterEntity pHACCPCheckRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new HACCPCheckRegisterProvider(pDBManager).HACCPCheckRegister_Info_Mst(pHACCPCheckRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "HACCPCheckRegister_Info(HACCPCheckRegisterEntity pHACCPCheckRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(HACCPCheckRegisterEntity pHACCPCheckRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(HACCPCheckRegisterEntity pHACCPCheckRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new HACCPCheckRegisterProvider(pDBManager).HACCPCheckRegister_Info_Mst(pHACCPCheckRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(HACCPCheckRegisterEntity pHACCPCheckRegisterEntity)", pException);
            }
        }

        #endregion

        #region 검사의뢰 마스터 정보 저장 - Sample_Info_Save(HACCPCheckRegisterEntity pHACCPCheckRegisterEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool HACCPCheckRegister_Info_Mst_Save(HACCPCheckRegisterEntity pHACCPCheckRegisterEntity, Worksheet sheet_1)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new HACCPCheckRegisterProvider(pDBManager).HACCPCheckRegister_Info_Mst_Save(pHACCPCheckRegisterEntity, sheet_1);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "HACCPCheckRegister_Info_Save(HACCPCheckRegisterEntity pHACCPCheckRegisterEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 검사의뢰 검사결과 정보 저장 - Sample_Info_Save(HACCPCheckRegisterEntity pHACCPCheckRegisterEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool HACCPCheckRegister_Info_Detail_Save(HACCPCheckRegisterEntity pHACCPCheckRegisterEntity, Worksheet sheet_1)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new HACCPCheckRegisterProvider(pDBManager).HACCPCheckRegister_Info_Detail_Save(pHACCPCheckRegisterEntity, sheet_1);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "HACCPCheckRegister_Info_Save(HACCPCheckRegisterEntity pHACCPCheckRegisterEntity, DataTable dt)", pException);
            }
        }

        #endregion
        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public HACCPCheckRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                HACCPCheckRegisterEntity pHACCPCheckRegisterEntity = new HACCPCheckRegisterProvider(null).GetEntity(pDataRow);
                return pHACCPCheckRegisterEntity;
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

    public class HACCPCheckRegisterT01Business
    {
        #region ○ 화면명에 맞는 엑셀파일 불러오기
        public DataTable Sheet_Info_Sheet(HACCPCheckRegisterT01Entity pHACCPCheckRegisterT01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pdatatable = new HACCPCheckRegisterT01Provider(pDBManager).Sheet_Info_sheet(pHACCPCheckRegisterT01Entity);
                    return pdatatable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sheet_Info_Sheet(HACCPCheckRegisterT01Entity _pHACCPCheckRegisterT01Entity)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - HACCPCheckRegister_Info(HACCPCheckRegisterT01Entity pHACCPCheckRegisterT01Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable HACCPCheckRegister_Info(HACCPCheckRegisterT01Entity pHACCPCheckRegisterT01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new HACCPCheckRegisterT01Provider(pDBManager).HACCPCheckRegister_Info_Mst(pHACCPCheckRegisterT01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "HACCPCheckRegister_Info(HACCPCheckRegisterT01Entity pHACCPCheckRegisterT01Entity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(HACCPCheckRegisterT01Entity pHACCPCheckRegisterT01Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(HACCPCheckRegisterT01Entity pHACCPCheckRegisterT01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new HACCPCheckRegisterT01Provider(pDBManager).HACCPCheckRegister_Info_Mst(pHACCPCheckRegisterT01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(HACCPCheckRegisterT01Entity pHACCPCheckRegisterT01Entity)", pException);
            }
        }

        #endregion

        #region 검사의뢰 마스터 정보 저장 - Sample_Info_Save(HACCPCheckRegisterT01Entity pHACCPCheckRegisterT01Entity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool HACCPCheckRegister_Info_Mst_Save(HACCPCheckRegisterT01Entity pHACCPCheckRegisterT01Entity, Worksheet sheet_1)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new HACCPCheckRegisterT01Provider(pDBManager).HACCPCheckRegister_Info_Mst_Save(pHACCPCheckRegisterT01Entity, sheet_1);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "HACCPCheckRegister_Info_Save(HACCPCheckRegisterT01Entity pHACCPCheckRegisterT01Entity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 검사의뢰 검사결과 정보 저장 - Sample_Info_Save(HACCPCheckRegisterT01Entity pHACCPCheckRegisterT01Entity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool HACCPCheckRegister_Info_Detail_Save(HACCPCheckRegisterT01Entity pHACCPCheckRegisterT01Entity, Worksheet sheet_1)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new HACCPCheckRegisterT01Provider(pDBManager).HACCPCheckRegister_Info_Detail_Save(pHACCPCheckRegisterT01Entity, sheet_1);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "HACCPCheckRegister_Info_Save(HACCPCheckRegisterT01Entity pHACCPCheckRegisterT01Entity, DataTable dt)", pException);
            }
        }

        #endregion
        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public HACCPCheckRegisterT01Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                HACCPCheckRegisterT01Entity pHACCPCheckRegisterT01Entity = new HACCPCheckRegisterT01Provider(null).GetEntity(pDataRow);
                return pHACCPCheckRegisterT01Entity;
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

    public class HACCPCheckRegisterT02Business
    {
        #region ○ 화면명에 맞는 엑셀파일 불러오기
        public DataTable Sheet_Info_Sheet(HACCPCheckRegisterT02Entity pHACCPCheckRegisterT02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pdatatable = new HACCPCheckRegisterT02Provider(pDBManager).Sheet_Info_sheet(pHACCPCheckRegisterT02Entity);
                    return pdatatable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sheet_Info_Sheet(HACCPCheckRegisterT02Entity _pHACCPCheckRegisterT02Entity)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - HACCPCheckRegister_Info(HACCPCheckRegisterT02Entity pHACCPCheckRegisterT02Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable HACCPCheckRegister_Info(HACCPCheckRegisterT02Entity pHACCPCheckRegisterT02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new HACCPCheckRegisterT02Provider(pDBManager).HACCPCheckRegister_Info_Mst(pHACCPCheckRegisterT02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "HACCPCheckRegister_Info(HACCPCheckRegisterT02Entity pHACCPCheckRegisterT02Entity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(HACCPCheckRegisterT02Entity pHACCPCheckRegisterT02Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(HACCPCheckRegisterT02Entity pHACCPCheckRegisterT02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new HACCPCheckRegisterT02Provider(pDBManager).HACCPCheckRegister_Info_Mst(pHACCPCheckRegisterT02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(HACCPCheckRegisterT02Entity pHACCPCheckRegisterT02Entity)", pException);
            }
        }

        #endregion

        #region 검사의뢰 마스터 정보 저장 - Sample_Info_Save(HACCPCheckRegisterT02Entity pHACCPCheckRegisterT02Entity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool HACCPCheckRegister_Info_Mst_Save(HACCPCheckRegisterT02Entity pHACCPCheckRegisterT02Entity, Worksheet sheet_1)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new HACCPCheckRegisterT02Provider(pDBManager).HACCPCheckRegister_Info_Mst_Save(pHACCPCheckRegisterT02Entity, sheet_1);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "HACCPCheckRegister_Info_Save(HACCPCheckRegisterT02Entity pHACCPCheckRegisterT02Entity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 검사의뢰 검사결과 정보 저장 - Sample_Info_Save(HACCPCheckRegisterT02Entity pHACCPCheckRegisterT02Entity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool HACCPCheckRegister_Info_Detail_Save(HACCPCheckRegisterT02Entity pHACCPCheckRegisterT02Entity, Worksheet sheet_1)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new HACCPCheckRegisterT02Provider(pDBManager).HACCPCheckRegister_Info_Detail_Save(pHACCPCheckRegisterT02Entity, sheet_1);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "HACCPCheckRegister_Info_Save(HACCPCheckRegisterT02Entity pHACCPCheckRegisterT02Entity, DataTable dt)", pException);
            }
        }

        #endregion
        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public HACCPCheckRegisterT02Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                HACCPCheckRegisterT02Entity pHACCPCheckRegisterT02Entity = new HACCPCheckRegisterT02Provider(null).GetEntity(pDataRow);
                return pHACCPCheckRegisterT02Entity;
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

    public class HACCPCheckRegisterT03Business
    {
        #region ○ 화면명에 맞는 엑셀파일 불러오기
        public DataTable Sheet_Info_Sheet(HACCPCheckRegisterT03Entity pHACCPCheckRegisterT03Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pdatatable = new HACCPCheckRegisterT03Provider(pDBManager).Sheet_Info_sheet(pHACCPCheckRegisterT03Entity);
                    return pdatatable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sheet_Info_Sheet(HACCPCheckRegisterT03Entity _pHACCPCheckRegisterT03Entity)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - HACCPCheckRegister_Info(HACCPCheckRegisterT03Entity pHACCPCheckRegisterT03Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable HACCPCheckRegister_Info(HACCPCheckRegisterT03Entity pHACCPCheckRegisterT03Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new HACCPCheckRegisterT03Provider(pDBManager).HACCPCheckRegister_Info_Mst(pHACCPCheckRegisterT03Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "HACCPCheckRegister_Info(HACCPCheckRegisterT03Entity pHACCPCheckRegisterT03Entity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(HACCPCheckRegisterT03Entity pHACCPCheckRegisterT03Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(HACCPCheckRegisterT03Entity pHACCPCheckRegisterT03Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new HACCPCheckRegisterT03Provider(pDBManager).HACCPCheckRegister_Info_Mst(pHACCPCheckRegisterT03Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(HACCPCheckRegisterT03Entity pHACCPCheckRegisterT03Entity)", pException);
            }
        }

        #endregion

        #region 검사의뢰 마스터 정보 저장 - Sample_Info_Save(HACCPCheckRegisterT03Entity pHACCPCheckRegisterT03Entity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool HACCPCheckRegister_Info_Mst_Save(HACCPCheckRegisterT03Entity pHACCPCheckRegisterT03Entity, Worksheet sheet_1)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new HACCPCheckRegisterT03Provider(pDBManager).HACCPCheckRegister_Info_Mst_Save(pHACCPCheckRegisterT03Entity, sheet_1);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "HACCPCheckRegister_Info_Save(HACCPCheckRegisterT03Entity pHACCPCheckRegisterT03Entity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 검사의뢰 검사결과 정보 저장 - Sample_Info_Save(HACCPCheckRegisterT03Entity pHACCPCheckRegisterT03Entity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool HACCPCheckRegister_Info_Detail_Save(HACCPCheckRegisterT03Entity pHACCPCheckRegisterT03Entity, Worksheet sheet_1)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new HACCPCheckRegisterT03Provider(pDBManager).HACCPCheckRegister_Info_Detail_Save(pHACCPCheckRegisterT03Entity, sheet_1);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "HACCPCheckRegister_Info_Save(HACCPCheckRegisterT03Entity pHACCPCheckRegisterT03Entity, DataTable dt)", pException);
            }
        }

        #endregion
        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public HACCPCheckRegisterT03Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                HACCPCheckRegisterT03Entity pHACCPCheckRegisterT03Entity = new HACCPCheckRegisterT03Provider(null).GetEntity(pDataRow);
                return pHACCPCheckRegisterT03Entity;
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

    public class HACCPCheckRegisterT04Business
    {
        #region ○ 화면명에 맞는 엑셀파일 불러오기
        public DataTable Sheet_Info_Sheet(HACCPCheckRegisterT04Entity pHACCPCheckRegisterT04Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pdatatable = new HACCPCheckRegisterT04Provider(pDBManager).Sheet_Info_sheet(pHACCPCheckRegisterT04Entity);
                    return pdatatable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sheet_Info_Sheet(HACCPCheckRegisterT04Entity _pHACCPCheckRegisterT04Entity)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - HACCPCheckRegister_Info(HACCPCheckRegisterT04Entity pHACCPCheckRegisterT04Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable HACCPCheckRegister_Info(HACCPCheckRegisterT04Entity pHACCPCheckRegisterT04Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new HACCPCheckRegisterT04Provider(pDBManager).HACCPCheckRegister_Info_Mst(pHACCPCheckRegisterT04Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "HACCPCheckRegister_Info(HACCPCheckRegisterT04Entity pHACCPCheckRegisterT04Entity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(HACCPCheckRegisterT04Entity pHACCPCheckRegisterT04Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(HACCPCheckRegisterT04Entity pHACCPCheckRegisterT04Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new HACCPCheckRegisterT04Provider(pDBManager).HACCPCheckRegister_Info_Mst(pHACCPCheckRegisterT04Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(HACCPCheckRegisterT04Entity pHACCPCheckRegisterT04Entity)", pException);
            }
        }

        #endregion

        #region 검사의뢰 마스터 정보 저장 - Sample_Info_Save(HACCPCheckRegisterT04Entity pHACCPCheckRegisterT04Entity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool HACCPCheckRegister_Info_Mst_Save(HACCPCheckRegisterT04Entity pHACCPCheckRegisterT04Entity, Worksheet sheet_1)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new HACCPCheckRegisterT04Provider(pDBManager).HACCPCheckRegister_Info_Mst_Save(pHACCPCheckRegisterT04Entity, sheet_1);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "HACCPCheckRegister_Info_Save(HACCPCheckRegisterT04Entity pHACCPCheckRegisterT04Entity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 검사의뢰 검사결과 정보 저장 - Sample_Info_Save(HACCPCheckRegisterT04Entity pHACCPCheckRegisterT04Entity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool HACCPCheckRegister_Info_Detail_Save(HACCPCheckRegisterT04Entity pHACCPCheckRegisterT04Entity, Worksheet sheet_1)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new HACCPCheckRegisterT04Provider(pDBManager).HACCPCheckRegister_Info_Detail_Save(pHACCPCheckRegisterT04Entity, sheet_1);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "HACCPCheckRegister_Info_Save(HACCPCheckRegisterT04Entity pHACCPCheckRegisterT04Entity, DataTable dt)", pException);
            }
        }

        #endregion
        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public HACCPCheckRegisterT04Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                HACCPCheckRegisterT04Entity pHACCPCheckRegisterT04Entity = new HACCPCheckRegisterT04Provider(null).GetEntity(pDataRow);
                return pHACCPCheckRegisterT04Entity;
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

    public class HACCPCheckRegisterT05Business
    {
        #region ○ 화면명에 맞는 엑셀파일 불러오기
        public DataTable Sheet_Info_Sheet(HACCPCheckRegisterT05Entity pHACCPCheckRegisterT05Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pdatatable = new HACCPCheckRegisterT05Provider(pDBManager).Sheet_Info_sheet(pHACCPCheckRegisterT05Entity);
                    return pdatatable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sheet_Info_Sheet(HACCPCheckRegisterT05Entity _pHACCPCheckRegisterT05Entity)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - HACCPCheckRegister_Info(HACCPCheckRegisterT05Entity pHACCPCheckRegisterT05Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable HACCPCheckRegister_Info(HACCPCheckRegisterT05Entity pHACCPCheckRegisterT05Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new HACCPCheckRegisterT05Provider(pDBManager).HACCPCheckRegister_Info_Mst(pHACCPCheckRegisterT05Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "HACCPCheckRegister_Info(HACCPCheckRegisterT05Entity pHACCPCheckRegisterT05Entity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(HACCPCheckRegisterT05Entity pHACCPCheckRegisterT05Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(HACCPCheckRegisterT05Entity pHACCPCheckRegisterT05Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new HACCPCheckRegisterT05Provider(pDBManager).HACCPCheckRegister_Info_Mst(pHACCPCheckRegisterT05Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(HACCPCheckRegisterT05Entity pHACCPCheckRegisterT05Entity)", pException);
            }
        }

        #endregion

        #region 검사의뢰 마스터 정보 저장 - Sample_Info_Save(HACCPCheckRegisterT05Entity pHACCPCheckRegisterT05Entity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool HACCPCheckRegister_Info_Mst_Save(HACCPCheckRegisterT05Entity pHACCPCheckRegisterT05Entity, Worksheet sheet_1)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new HACCPCheckRegisterT05Provider(pDBManager).HACCPCheckRegister_Info_Mst_Save(pHACCPCheckRegisterT05Entity, sheet_1);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "HACCPCheckRegister_Info_Save(HACCPCheckRegisterT05Entity pHACCPCheckRegisterT05Entity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 검사의뢰 검사결과 정보 저장 - Sample_Info_Save(HACCPCheckRegisterT05Entity pHACCPCheckRegisterT05Entity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool HACCPCheckRegister_Info_Detail_Save(HACCPCheckRegisterT05Entity pHACCPCheckRegisterT05Entity, Worksheet sheet_1)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new HACCPCheckRegisterT05Provider(pDBManager).HACCPCheckRegister_Info_Detail_Save(pHACCPCheckRegisterT05Entity, sheet_1);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "HACCPCheckRegister_Info_Save(HACCPCheckRegisterT05Entity pHACCPCheckRegisterT05Entity, DataTable dt)", pException);
            }
        }

        #endregion
        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public HACCPCheckRegisterT05Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                HACCPCheckRegisterT05Entity pHACCPCheckRegisterT05Entity = new HACCPCheckRegisterT05Provider(null).GetEntity(pDataRow);
                return pHACCPCheckRegisterT05Entity;
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

    public class HACCPCheckRegisterT06Business
    {
        #region ○ 화면명에 맞는 엑셀파일 불러오기
        public DataTable Sheet_Info_Sheet(HACCPCheckRegisterT06Entity pHACCPCheckRegisterT06Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pdatatable = new HACCPCheckRegisterT06Provider(pDBManager).Sheet_Info_sheet(pHACCPCheckRegisterT06Entity);
                    return pdatatable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sheet_Info_Sheet(HACCPCheckRegisterT06Entity _pHACCPCheckRegisterT06Entity)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - HACCPCheckRegister_Info(HACCPCheckRegisterT06Entity pHACCPCheckRegisterT06Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable HACCPCheckRegister_Info(HACCPCheckRegisterT06Entity pHACCPCheckRegisterT06Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new HACCPCheckRegisterT06Provider(pDBManager).HACCPCheckRegister_Info_Mst(pHACCPCheckRegisterT06Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "HACCPCheckRegister_Info(HACCPCheckRegisterT06Entity pHACCPCheckRegisterT06Entity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(HACCPCheckRegisterT06Entity pHACCPCheckRegisterT06Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(HACCPCheckRegisterT06Entity pHACCPCheckRegisterT06Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new HACCPCheckRegisterT06Provider(pDBManager).HACCPCheckRegister_Info_Mst(pHACCPCheckRegisterT06Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(HACCPCheckRegisterT06Entity pHACCPCheckRegisterT06Entity)", pException);
            }
        }

        #endregion

        #region 검사의뢰 마스터 정보 저장 - Sample_Info_Save(HACCPCheckRegisterT06Entity pHACCPCheckRegisterT06Entity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool HACCPCheckRegister_Info_Mst_Save(HACCPCheckRegisterT06Entity pHACCPCheckRegisterT06Entity, Worksheet sheet_1)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new HACCPCheckRegisterT06Provider(pDBManager).HACCPCheckRegister_Info_Mst_Save(pHACCPCheckRegisterT06Entity, sheet_1);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "HACCPCheckRegister_Info_Save(HACCPCheckRegisterT06Entity pHACCPCheckRegisterT06Entity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 검사의뢰 검사결과 정보 저장 - Sample_Info_Save(HACCPCheckRegisterT06Entity pHACCPCheckRegisterT06Entity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool HACCPCheckRegister_Info_Detail_Save(HACCPCheckRegisterT06Entity pHACCPCheckRegisterT06Entity, Worksheet sheet_1)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new HACCPCheckRegisterT06Provider(pDBManager).HACCPCheckRegister_Info_Detail_Save(pHACCPCheckRegisterT06Entity, sheet_1);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "HACCPCheckRegister_Info_Save(HACCPCheckRegisterT06Entity pHACCPCheckRegisterT06Entity, DataTable dt)", pException);
            }
        }

        #endregion
        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public HACCPCheckRegisterT06Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                HACCPCheckRegisterT06Entity pHACCPCheckRegisterT06Entity = new HACCPCheckRegisterT06Provider(null).GetEntity(pDataRow);
                return pHACCPCheckRegisterT06Entity;
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

    public class HACCPCheckRegisterT07Business
    {
        #region ○ 화면명에 맞는 엑셀파일 불러오기
        public DataTable Sheet_Info_Sheet(HACCPCheckRegisterT07Entity pHACCPCheckRegisterT07Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pdatatable = new HACCPCheckRegisterT07Provider(pDBManager).Sheet_Info_sheet(pHACCPCheckRegisterT07Entity);
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

        #region 마스터 정보 조회 - HACCPCheckRegister_Info(HACCPCheckRegisterT07Entity pHACCPCheckRegisterT07Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable HACCPCheckRegister_Info(HACCPCheckRegisterT07Entity pHACCPCheckRegisterT07Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new HACCPCheckRegisterT07Provider(pDBManager).HACCPCheckRegister_Info_Mst(pHACCPCheckRegisterT07Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "HACCPCheckRegister_Info(HACCPCheckRegisterT07Entity pHACCPCheckRegisterT07Entity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(HACCPCheckRegisterT07Entity pHACCPCheckRegisterT07Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(HACCPCheckRegisterT07Entity pHACCPCheckRegisterT07Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new HACCPCheckRegisterT07Provider(pDBManager).HACCPCheckRegister_Info_Mst(pHACCPCheckRegisterT07Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(HACCPCheckRegisterT07Entity pHACCPCheckRegisterT07Entity)", pException);
            }
        }

        #endregion

        #region 검사의뢰 마스터 정보 저장 - Sample_Info_Save(HACCPCheckRegisterT07Entity pHACCPCheckRegisterT07Entity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool HACCPCheckRegister_Info_Mst_Save(HACCPCheckRegisterT07Entity pHACCPCheckRegisterT07Entity, Worksheet sheet_1)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new HACCPCheckRegisterT07Provider(pDBManager).HACCPCheckRegister_Info_Mst_Save(pHACCPCheckRegisterT07Entity, sheet_1);
                    return isReturn;
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

        #region 검사의뢰 검사결과 정보 저장 - Sample_Info_Save(HACCPCheckRegisterT07Entity pHACCPCheckRegisterT07Entity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool HACCPCheckRegister_Info_Detail_Save(HACCPCheckRegisterT07Entity pHACCPCheckRegisterT07Entity, Worksheet sheet_1)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new HACCPCheckRegisterT07Provider(pDBManager).HACCPCheckRegister_Info_Detail_Save(pHACCPCheckRegisterT07Entity, sheet_1);
                    return isReturn;
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
        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public HACCPCheckRegisterT07Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                HACCPCheckRegisterT07Entity pHACCPCheckRegisterT07Entity = new HACCPCheckRegisterT07Provider(null).GetEntity(pDataRow);
                return pHACCPCheckRegisterT07Entity;
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

    public class HACCPCheckRegisterT08Business
    {
        #region ○ 화면명에 맞는 엑셀파일 불러오기
        public DataTable Sheet_Info_Sheet(HACCPCheckRegisterT08Entity pHACCPCheckRegisterT08Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pdatatable = new HACCPCheckRegisterT08Provider(pDBManager).Sheet_Info_sheet(pHACCPCheckRegisterT08Entity);
                    return pdatatable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sheet_Info_Sheet(HACCPCheckRegisterT08Entity _pHACCPCheckRegisterT08Entity)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - HACCPCheckRegister_Info(HACCPCheckRegisterT08Entity pHACCPCheckRegisterT08Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable HACCPCheckRegister_Info(HACCPCheckRegisterT08Entity pHACCPCheckRegisterT08Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new HACCPCheckRegisterT08Provider(pDBManager).HACCPCheckRegister_Info_Mst(pHACCPCheckRegisterT08Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "HACCPCheckRegister_Info(HACCPCheckRegisterT08Entity pHACCPCheckRegisterT08Entity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(HACCPCheckRegisterT08Entity pHACCPCheckRegisterT08Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(HACCPCheckRegisterT08Entity pHACCPCheckRegisterT08Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new HACCPCheckRegisterT08Provider(pDBManager).HACCPCheckRegister_Info_Mst(pHACCPCheckRegisterT08Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(HACCPCheckRegisterT08Entity pHACCPCheckRegisterT08Entity)", pException);
            }
        }

        #endregion

        #region 검사의뢰 마스터 정보 저장 - Sample_Info_Save(HACCPCheckRegisterT08Entity pHACCPCheckRegisterT08Entity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool HACCPCheckRegister_Info_Mst_Save(HACCPCheckRegisterT08Entity pHACCPCheckRegisterT08Entity, Worksheet sheet_1)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new HACCPCheckRegisterT08Provider(pDBManager).HACCPCheckRegister_Info_Mst_Save(pHACCPCheckRegisterT08Entity, sheet_1);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "HACCPCheckRegister_Info_Save(HACCPCheckRegisterT08Entity pHACCPCheckRegisterT08Entity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 검사의뢰 검사결과 정보 저장 - Sample_Info_Save(HACCPCheckRegisterT08Entity pHACCPCheckRegisterT08Entity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool HACCPCheckRegister_Info_Detail_Save(HACCPCheckRegisterT08Entity pHACCPCheckRegisterT08Entity, Worksheet sheet_1)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new HACCPCheckRegisterT08Provider(pDBManager).HACCPCheckRegister_Info_Detail_Save(pHACCPCheckRegisterT08Entity, sheet_1);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "HACCPCheckRegister_Info_Save(HACCPCheckRegisterT08Entity pHACCPCheckRegisterT08Entity, DataTable dt)", pException);
            }
        }

        #endregion
        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public HACCPCheckRegisterT08Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                HACCPCheckRegisterT08Entity pHACCPCheckRegisterT08Entity = new HACCPCheckRegisterT08Provider(null).GetEntity(pDataRow);
                return pHACCPCheckRegisterT08Entity;
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

    public class HACCPCheckRegisterT09Business
    {
        #region ○ 화면명에 맞는 엑셀파일 불러오기
        public DataTable Sheet_Info_Sheet(HACCPCheckRegisterT09Entity pHACCPCheckRegisterT09Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pdatatable = new HACCPCheckRegisterT09Provider(pDBManager).Sheet_Info_sheet(pHACCPCheckRegisterT09Entity);
                    return pdatatable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sheet_Info_Sheet(HACCPCheckRegisterT09Entity _pHACCPCheckRegisterT09Entity)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - HACCPCheckRegister_Info(HACCPCheckRegisterT09Entity pHACCPCheckRegisterT09Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable HACCPCheckRegister_Info(HACCPCheckRegisterT09Entity pHACCPCheckRegisterT09Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new HACCPCheckRegisterT09Provider(pDBManager).HACCPCheckRegister_Info_Mst(pHACCPCheckRegisterT09Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "HACCPCheckRegister_Info(HACCPCheckRegisterT09Entity pHACCPCheckRegisterT09Entity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(HACCPCheckRegisterT09Entity pHACCPCheckRegisterT09Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(HACCPCheckRegisterT09Entity pHACCPCheckRegisterT09Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new HACCPCheckRegisterT09Provider(pDBManager).HACCPCheckRegister_Info_Mst(pHACCPCheckRegisterT09Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(HACCPCheckRegisterT09Entity pHACCPCheckRegisterT09Entity)", pException);
            }
        }

        #endregion

        #region 검사의뢰 마스터 정보 저장 - Sample_Info_Save(HACCPCheckRegisterT09Entity pHACCPCheckRegisterT09Entity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool HACCPCheckRegister_Info_Mst_Save(HACCPCheckRegisterT09Entity pHACCPCheckRegisterT09Entity, Worksheet sheet_1)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new HACCPCheckRegisterT09Provider(pDBManager).HACCPCheckRegister_Info_Mst_Save(pHACCPCheckRegisterT09Entity, sheet_1);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "HACCPCheckRegister_Info_Save(HACCPCheckRegisterT09Entity pHACCPCheckRegisterT09Entity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 검사의뢰 검사결과 정보 저장 - Sample_Info_Save(HACCPCheckRegisterT09Entity pHACCPCheckRegisterT09Entity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool HACCPCheckRegister_Info_Detail_Save(HACCPCheckRegisterT09Entity pHACCPCheckRegisterT09Entity, Worksheet sheet_1)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new HACCPCheckRegisterT09Provider(pDBManager).HACCPCheckRegister_Info_Detail_Save(pHACCPCheckRegisterT09Entity, sheet_1);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "HACCPCheckRegister_Info_Save(HACCPCheckRegisterT09Entity pHACCPCheckRegisterT09Entity, DataTable dt)", pException);
            }
        }

        #endregion
        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public HACCPCheckRegisterT09Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                HACCPCheckRegisterT09Entity pHACCPCheckRegisterT09Entity = new HACCPCheckRegisterT09Provider(null).GetEntity(pDataRow);
                return pHACCPCheckRegisterT09Entity;
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

    public class BarcodeLabelPrintBusiness
    {

        #region 마스터 정보 조회 - BarcodeLabelPrint_Info(BarcodeLabelPrintEntity pBarcodeLabelPrintEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable BarcodeLabelPrint_Info_Mst(BarcodeLabelPrintEntity pBarcodeLabelPrintEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new BarcodeLabelPrintProvider(pDBManager).BarcodeLabelPrint_Info_Mst(pBarcodeLabelPrintEntity);
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

        #region 마스터 정보 조회 - BarcodeLabelPrint_Info(BarcodeLabelPrintEntity pBarcodeLabelPrintEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable BarcodeLabelPrint_COM_Info(BarcodeLabelPrintEntity pBarcodeLabelPrintEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new BarcodeLabelPrintProvider(pDBManager).BarcodeLabelPrint_COM_Info(pBarcodeLabelPrintEntity);
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

        #region 바코드 정보 조회 - BarcodeLabelPrint_Info(BarcodeLabelPrintEntity pBarcodeLabelPrintEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable BarcodeLabelPrint_Info(BarcodeLabelPrintEntity pBarcodeLabelPrintEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new BarcodeLabelPrintProvider(pDBManager).BarcodeLabelPrint_Info(pBarcodeLabelPrintEntity);
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

        #region 터미널 정보 조회 - BarcodeLabelPrint_Info_sub(BarcodeLabelPrintEntity pBarcodeLabelPrintEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable BarcodeLabelPrint_Info_sub(BarcodeLabelPrintEntity pBarcodeLabelPrintEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new BarcodeLabelPrintProvider(pDBManager).BarcodeLabelPrint_Info_sub(pBarcodeLabelPrintEntity);
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

        #region 업체번호 조회 - BarcodeLabelPrint_Info_sub(BarcodeLabelPrintEntity pBarcodeLabelPrintEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable BarcodeLabelPrint_Vend_Info(string partCode)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new BarcodeLabelPrintProvider(pDBManager).BarcodeLabelPrint_Vend_Info(partCode);
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

        #region 그리드 정보 저장 - BarcodeLabelPrint_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool BarcodeLabelPrint_Info_Save(BarcodeLabelPrintEntity pBarcodeLabelPrintEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new BarcodeLabelPrintProvider(pDBManager).BarcodeLabelPrint_Info_Save(pBarcodeLabelPrintEntity);
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
        public BarcodeLabelPrintEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                BarcodeLabelPrintEntity pBarcodeLabelPrintEntity = new BarcodeLabelPrintProvider(null).GetEntity(pDataRow);
                return pBarcodeLabelPrintEntity;
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

    #region o 월별 생산계획/실적및 평균
    public class ProductBadMonthStatusBusiness
    {
        #region 마스터 정보 조회 - Sample_Info(ProductBadMonthStatusEntity pProductBadMonthStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(ProductBadMonthStatusEntity pProductBadMonthStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductBadMonthStatusProvider(pDBManager).Sample_Info_Mst(pProductBadMonthStatusEntity);
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

        #region 상세 정보 조회 - Sample_Info_Sub(ResultStatusPlanResultEntity pProductBadMonthStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(ProductBadMonthStatusEntity pProductBadMonthStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductBadMonthStatusProvider(pDBManager).Sample_Info_Mst(pProductBadMonthStatusEntity);
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
        public DataTable ProductBadMonthStatus_Info_Filename(ProductBadMonthStatusEntity pProductBadMonthStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProductBadMonthStatusProvider(pDBManager).ProductBadMonthStatus_Info_Filename(pProductBadMonthStatusEntity);
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
        public object Templete_Download(ProductBadMonthStatusEntity pProductBadMonthStatusEntity, string pMENU_NO, string pDSP_SORT)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    object pObject = new ProductBadMonthStatusProvider(pDBManager).Templete_Download(pProductBadMonthStatusEntity, pMENU_NO, pDSP_SORT);
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
        public ProductBadMonthStatusEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ProductBadMonthStatusEntity pSampleRegisterEntity = new ProductBadMonthStatusProvider(null).GetEntity(pDataRow);
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

    #region o 초중종물검사등록_T01
    public class FirstMiddleLastInspectRegister_T01Business
    {

        #region 정보 조회 - FirstMiddleLastInspectMst_Info(FirstMiddleLastInspectRegister_T01Entity pFirstMiddleLastInspectRegister_T01Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable FirstMiddleLastInspectMst_Info(FirstMiddleLastInspectRegister_T01Entity pFirstMiddleLastInspectRegister_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new FirstMiddleLastInspectRegister_T01Provider(pDBManager).FirstMiddleLastInspectRegister_T01_Info_Mst(pFirstMiddleLastInspectRegister_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "FirstMiddleLastInspectMst_Info(FirstMiddleLastInspectRegister_T01Entity pFirstMiddleLastInspectRegister_T01Entity)", pException);
            }
        }

        #endregion

        #region ○ 정보 저장 - FirstMiddleLastInspectRegister_T01Mst_Save(FirstMiddleLastInspectRegister_T01Entity pFirstMiddleLastInspectRegister_T01Entity)

        public bool FirstMiddleLastInspectRegister_T01Mst_Save(FirstMiddleLastInspectRegister_T01Entity pFirstMiddleLastInspectRegister_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new FirstMiddleLastInspectRegister_T01Provider(pDBManager).FirstMiddleLastInspectRegister_T01_Save(pFirstMiddleLastInspectRegister_T01Entity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "FirstMiddleLastInspectRegister_T01Mst_Save(FirstMiddleLastInspectRegister_T01Entity pFirstMiddleLastInspectRegister_T01Entity)", pException);
            }
        }

        #endregion

        #region ○ 수주정보 수정 시, 해당 수주번호로 내려진 생산계획이 있는지 조회- Sample_Check_Next_Process(FirstMiddleLastInspectRegister_T01Entity pContractMstReigsterEntity) 

        public DataTable Sample_Check_Next_Process(FirstMiddleLastInspectRegister_T01Entity pContractMstReigsterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new FirstMiddleLastInspectRegister_T01Provider(pDBManager).Sample_Check_Next_Process(pContractMstReigsterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Check_Next_Process(FirstMiddleLastInspectRegister_T01Entity pContractMstReigsterEntity)", pException);
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

    #region o 초중종물검사등록_T01 에서 작업지시 불러오기 팝업 pucProductionOrderInfoPopup_T08
    public class pucProductionOrderInfoPopup_T08Business
    {
        public DataSet ucProductionOrderInfoPopup_T08_Select(ucProductionOrderInfoPopup_T08_Entity pucProductionOrderInfoPopup_T08_Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataSet pDataTableSet = new ucProductionOrderInfoPopup_T08Provider(pDBManager).pucProductionOrderInfoPopup_T08_Return(pucProductionOrderInfoPopup_T08_Entity);
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


    #region 설비이력조회
    public class QualityAnalysisBusiness
    {
        #region 마스터 정보 조회 - EquipmentCheck_Mst(QualityAnalsisEntity _pQualityAnalsisEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable QualityAnalysis_Mst(QualityAnalsisEntity _pQualityAnalsisEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new QualityAnalsisProvider(pDBManager).QualityAnalsis_Mst(_pQualityAnalsisEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "EquipmentCheck_Sub(EquipmentCheckEntity pEquipmentCheckEntity)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public QualityAnalsisEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                QualityAnalsisEntity _pQualityAnalsisEntity = new QualityAnalsisProvider(null).GetEntity(pDataRow);
                return _pQualityAnalsisEntity;
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

    public class MaterialInspectRegister_T02Business
    {

        #region ○ 화면명에 맞는 엑셀파일 불러오기
        public DataTable Sheet_Info_Sheet(MaterialInspectRegister_T02Entity pMaterialInspectRegister_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pdatatable = new MaterialInspectRegister_T02Provider(pDBManager).Sheet_Info_sheet(pMaterialInspectRegister_T02Entity);
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


        #region 마스터 정보 조회 - Sample_Info(MaterialInspectRegister_T02Entity pMaterialInspectRegister_T02Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(MaterialInspectRegister_T02Entity pMaterialInspectRegister_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialInspectRegister_T02Provider(pDBManager).Sample_Info_Mst(pMaterialInspectRegister_T02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(MaterialInspectRegister_T02Entity pMaterialInspectRegister_T02Entity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(MaterialOrderStatusEntity pMaterialOrderStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(MaterialInspectRegister_T02Entity pMaterialInspectRegister_T02Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialInspectRegister_T02Provider(pDBManager).Sample_Info_Mst(pMaterialInspectRegister_T02Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(MaterialInspectRegister_T02Entity pMaterialInspectRegister_T02Entity)", pException);
            }
        }

        #endregion

        #region 검사의뢰 마스터 정보 저장 - Sample_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool MaterialInspectRegister_T02_Info_Mst_Save(MaterialInspectRegister_T02Entity pMaterialInspectRegister_T02Entity, Worksheet sheet_1)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new MaterialInspectRegister_T02Provider(pDBManager).MaterialInspectRegister_T02_Info_Mst_Save(pMaterialInspectRegister_T02Entity, sheet_1);
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
        public bool MaterialInspectRegister_T02_Info_Detail_Save(MaterialInspectRegister_T02Entity pMaterialInspectRegister_T02Entity, Worksheet sheet_1)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new MaterialInspectRegister_T02Provider(pDBManager).MaterialInspectRegister_T02_Info_Detail_Save(pMaterialInspectRegister_T02Entity, sheet_1);
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
        public MaterialInspectRegister_T02Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                MaterialInspectRegister_T02Entity pMaterialInspectRegister_T02Entity = new MaterialInspectRegister_T02Provider(null).GetEntity(pDataRow);
                return pMaterialInspectRegister_T02Entity;
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

    public class MaterialInspectRegister_T03Business
    {

        #region ○ 화면명에 맞는 엑셀파일 불러오기
        public DataTable Sheet_Info_Sheet(MaterialInspectRegister_T03Entity pMaterialInspectRegister_T03Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pdatatable = new MaterialInspectRegister_T03Provider(pDBManager).Sheet_Info_sheet(pMaterialInspectRegister_T03Entity);
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


        #region 마스터 정보 조회 - Sample_Info(MaterialInspectRegister_T03Entity pMaterialInspectRegister_T03Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(MaterialInspectRegister_T03Entity pMaterialInspectRegister_T03Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialInspectRegister_T03Provider(pDBManager).Sample_Info_Mst(pMaterialInspectRegister_T03Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(MaterialInspectRegister_T03Entity pMaterialInspectRegister_T03Entity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(MaterialOrderStatusEntity pMaterialOrderStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(MaterialInspectRegister_T03Entity pMaterialInspectRegister_T03Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MaterialInspectRegister_T03Provider(pDBManager).Sample_Info_Mst(pMaterialInspectRegister_T03Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(MaterialInspectRegister_T03Entity pMaterialInspectRegister_T03Entity)", pException);
            }
        }

        #endregion

        #region 검사의뢰 마스터 정보 저장 - Sample_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool MaterialInspectRegister_T03_Info_Mst_Save(MaterialInspectRegister_T03Entity pMaterialInspectRegister_T03Entity, Worksheet sheet_1)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new MaterialInspectRegister_T03Provider(pDBManager).MaterialInspectRegister_T03_Info_Mst_Save(pMaterialInspectRegister_T03Entity, sheet_1);
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
        public bool MaterialInspectRegister_T03_Info_Detail_Save(MaterialInspectRegister_T03Entity pMaterialInspectRegister_T03Entity, Worksheet sheet_1)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new MaterialInspectRegister_T03Provider(pDBManager).MaterialInspectRegister_T03_Info_Detail_Save(pMaterialInspectRegister_T03Entity, sheet_1);
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
        public MaterialInspectRegister_T03Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                MaterialInspectRegister_T03Entity pMaterialInspectRegister_T03Entity = new MaterialInspectRegister_T03Provider(null).GetEntity(pDataRow);
                return pMaterialInspectRegister_T03Entity;
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

    #region 초중종물이력조회
    public class FirstMiddleLastInspectStatusBusiness
    {
        #region 마스터 정보 조회 - EquipmentCheck_Mst(FirstMiddleLastInspectStatusEntity _pFirstMiddleLastInspectStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable FirstMiddleLastInspectStatus_Mst(FirstMiddleLastInspectStatusEntity _pFirstMiddleLastInspectStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new FirstMiddleLastInspectStatusProvider(pDBManager).FirstMiddleLastInspectStatus_Mst(_pFirstMiddleLastInspectStatusEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "EquipmentCheck_Sub(EquipmentCheckEntity pEquipmentCheckEntity)", pException);
            }
        }

        #endregion

        //#region 서식파일 조회 - EquipmentChange_Sub(EquipmentChangeEntity pEquipmentChangeEntity)
        //public DataTable EquipmentCheck_Sub(EquipmentCheckEntity pEquipmentCheckEntity)
        //{
        //    try
        //    {
        //        using (DBManager pDBManager = new DBManager())
        //        {
        //            DataTable pDataTable = new EquipmentCheckProvider(pDBManager).EquipmentCheck_Sub(pEquipmentCheckEntity);
        //            return pDataTable;
        //        }
        //    }
        //    catch (ExceptionManager pExceptionManager)
        //    {
        //        throw pExceptionManager;
        //    }
        //    catch (Exception pException)
        //    {
        //        throw new ExceptionManager(this, "EquipmentCheck_Sub(EquipmentCheckEntity pEquipmentCheckEntity)", pException);
        //    }
        //}

        //#endregion

        //#region 그리드 정보 저장 - EquipmentCheck_Save(EquipmentCheckEntity pEquipmentCheckEntity)

        ///// <summary>
        ///// 언어 정보 저장
        ///// </summary>
        //public bool EquipmentCheck_Save(EquipmentCheckEntity pEquipmentCheckEntity)
        //{
        //    try
        //    {
        //        using (DBManager pDBManager = new DBManager())
        //        {
        //            bool isReturn = new EquipmentCheckProvider(pDBManager).EquipmentCheck_Save(pEquipmentCheckEntity);
        //            return isReturn;
        //        }
        //    }
        //    catch (ExceptionManager pExceptionManager)
        //    {
        //        throw pExceptionManager;
        //    }
        //    catch (Exception pException)
        //    {
        //        throw new ExceptionManager(this, "EquipmentCheck_Save(EquipmentCheckEntity pEquipmentCheckEntity)", pException);
        //    }
        //}

        //#endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public FirstMiddleLastInspectStatusEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                FirstMiddleLastInspectStatusEntity _pFirstMiddleLastInspectStatusEntity = new FirstMiddleLastInspectStatusProvider(null).GetEntity(pDataRow);
                return _pFirstMiddleLastInspectStatusEntity;
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
        public DataTable Sheet_Info_Sheet(FirstMiddleLastInspectStatusEntity _pFirstMiddleLastInspectStatusEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pdatatable = new FirstMiddleLastInspectStatusProvider(pDBManager).Sheet_Info_sheet(_pFirstMiddleLastInspectStatusEntity);
                    return pdatatable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sheet_Info_Sheet(FirstMiddleLastInspectStatusEntity _pFirstMiddleLastInspectStatusEntity)", pException);
            }
        }

        #endregion
    }
    #endregion


    public class GatheringEquationRegisterBusiness
    {
        #region ○ 화면명에 맞는 엑셀파일 불러오기
        public DataTable Sheet_Info_Sheet(GatheringEquationRegisterEntity pGatheringEquationRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pdatatable = new GatheringEquationRegisterProvider(pDBManager).Sheet_Info_sheet(pGatheringEquationRegisterEntity);
                    return pdatatable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sheet_Info_Sheet(GatheringEquationRegisterEntity _pGatheringEquationRegisterEntity)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - GatheringEquationRegister_Info(GatheringEquationRegisterEntity pGatheringEquationRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable GatheringEquationRegister_Info(GatheringEquationRegisterEntity pGatheringEquationRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new GatheringEquationRegisterProvider(pDBManager).GatheringEquationRegister_Info_Mst(pGatheringEquationRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "GatheringEquationRegister_Info(GatheringEquationRegisterEntity pGatheringEquationRegisterEntity)", pException);
            }
        }

        #endregion
        
        #region 마스터 정보 저장 - Sample_Info_Save(GatheringEquationRegisterEntity pGatheringEquationRegisterEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool GatheringEquationRegister_Info_Save(GatheringEquationRegisterEntity pGatheringEquationRegisterEntity, Worksheet sheet_1)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new GatheringEquationRegisterProvider(pDBManager).GatheringEquationRegister_Info_Save(pGatheringEquationRegisterEntity, sheet_1);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "GatheringEquationRegister_Info_Save(GatheringEquationRegisterEntity pGatheringEquationRegisterEntity, DataTable dt)", pException);
            }
        }

        #endregion
        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public GatheringEquationRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                GatheringEquationRegisterEntity pGatheringEquationRegisterEntity = new GatheringEquationRegisterProvider(null).GetEntity(pDataRow);
                return pGatheringEquationRegisterEntity;
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

    public class KPIDataRegisterBusiness
    {
        #region 마스터 정보 조회

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Excel_Json_Mst_Info(KPIDataRegisterEntity pKPIDataRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new KPIDataRegisterProvider(pDBManager).Excel_Json_Mst_Info(pKPIDataRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Excel_Json_Mst_Info(RawMaterialInspectRegisterEntity pRawMaterialInspectRegisterEntity)", pException);
            }
        }

        #endregion

        #region 마스터 디테일 정보 조회

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Excel_Json_Mst_Sub_Info(KPIDataRegisterEntity pKPIDataRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new KPIDataRegisterProvider(pDBManager).Excel_Json_Mst_Sub_Info(pKPIDataRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Excel_Json_Mst_Sub_Info(RawMaterialInspectRegisterEntity pRawMaterialInspectRegisterEntity)", pException);
            }
        }

        #endregion

        #region 디테일 정보 조회

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Excel_Json_Sub_Info(KPIDataRegisterEntity pKPIDataRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new KPIDataRegisterProvider(pDBManager).Excel_Json_Sub_Info(pKPIDataRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Excel_Json_Sub_Info(RawMaterialInspectRegisterEntity pRawMaterialInspectRegisterEntity)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public KPIDataRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                KPIDataRegisterEntity pKPIDataRegisterEntity = new KPIDataRegisterProvider(null).GetEntity(pDataRow);
                return pKPIDataRegisterEntity;
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
        public DataTable Sheet_Info_Sheet(KPIDataRegisterEntity pKPIDataRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pdatatable = new KPIDataRegisterProvider(pDBManager).Sheet_Info_sheet(pKPIDataRegisterEntity);
                    return pdatatable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sheet_Info_Sheet(KPIDataRegisterEntity pKPIDataRegisterEntity)", pException);
            }
        }

        #endregion
    }

    public class EquipmentInspectRegisterBusiness
    {

        #region ○ 화면명에 맞는 엑셀파일 불러오기
        public DataTable Sheet_Info_Sheet(EquipmentInspectRegisterEntity pEquipmentInspectRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pdatatable = new EquipmentInspectRegisterProvider(pDBManager).Sheet_Info_sheet(pEquipmentInspectRegisterEntity);
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

        #region 마스터 정보 조회 - Sample_Info(EquipmentInspectRegisterEntity pEquipmentInspectRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(EquipmentInspectRegisterEntity pEquipmentInspectRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new EquipmentInspectRegisterProvider(pDBManager).Sample_Info_Mst(pEquipmentInspectRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(EquipmentInspectRegisterEntity pEquipmentInspectRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(MaterialOrderStatusEntity pMaterialOrderStatusEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(EquipmentInspectRegisterEntity pEquipmentInspectRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new EquipmentInspectRegisterProvider(pDBManager).Sample_Info_Mst(pEquipmentInspectRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(EquipmentInspectRegisterEntity pEquipmentInspectRegisterEntity)", pException);
            }
        }

        #endregion

        #region 점검 정보 저장 - Sample_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool EquipmentInspectRegister_Info_Mst_Save(EquipmentInspectRegisterEntity pEquipmentInspectRegisterEntity, Worksheet sheet_2)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new EquipmentInspectRegisterProvider(pDBManager).EquipmentInspectRegister_Info_Mst_Save(pEquipmentInspectRegisterEntity, sheet_2);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "EquipmentInspectRegister_Info_Mst_Save(EquipmentInspectRegisterEntity pEquipmentInspectRegisterEntity, Worksheet sheet_2)", pException);
            }
        }

        #endregion

        #region 점검 검사결과 정보 저장 - Sample_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool EquipmentInspectRegister_Info_Detail_Save(EquipmentInspectRegisterEntity pEquipmentInspectRegisterEntity, Worksheet sheet_2)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new EquipmentInspectRegisterProvider(pDBManager).EquipmentInspectRegister_Info_Detail_Save(pEquipmentInspectRegisterEntity, sheet_2);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "quipmentInspectRegister_Info_Detail_Save(EquipmentInspectRegisterEntity pEquipmentInspectRegisterEntity, Worksheet sheet_2)", pException);
            }
        }

        #endregion

        #region 점검 상태 정보 저장 - EquipmentInspect_Info_Save(EquipmentInspectRegisterEntity pEquipmentInspectRegisterEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool EquipmentInspect_Info_Save(EquipmentInspectRegisterEntity pEquipmentInspectRegisterEntity, DataTable dt)
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
                    bool isReturn = new EquipmentInspectRegisterProvider(pDBManager).EquipmentInspect_Info_Save(pEquipmentInspectRegisterEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "EquipmentInspect_Info_Save(EquipmentInspectRegisterEntity pEquipmentInspectRegisterEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public EquipmentInspectRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                EquipmentInspectRegisterEntity pEquipmentInspectRegisterEntity = new EquipmentInspectRegisterProvider(null).GetEntity(pDataRow);
                return pEquipmentInspectRegisterEntity;
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
