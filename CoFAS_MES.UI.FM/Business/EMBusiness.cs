using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CoFAS_MES.UI.EM.Data;
using CoFAS_MES.UI.EM.Entity;

using CoFAS_MES.CORE.Entity;
using CoFAS_MES.CORE.Function;
using System.Data;

namespace CoFAS_MES.UI.EM.Business
{
    public class EquipmentCodeMstRegisterBusiness
    {
        #region 마스터 정보 조회 - Equipment_Info_Mst(EquipmentCodeMstRegisterEntity pEquipmentCodeMstRegisterEntity)

        /// <summary>
        /// 설비 마스터 정보 조회
        /// </summary>
        public DataTable Equipment_Info_Mst(EquipmentCodeMstRegisterEntity pEquipmentCodeMstRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new EquipmentCodeMstRegisterProvider(pDBManager).Equipment_Info_Mst(pEquipmentCodeMstRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Equipment_Info_Mst(EquipmentCodeMstRegisterEntity pEquipmentCodeMstRegisterEntity)", pException);
            }
        }

        #endregion

        #region 마스터 바인딩 정보 조회 - Equipment_Info_Mst_Binding(EquipmentCodeMstRegisterEntity pEquipmentCodeMstRegisterEntity)

        /// <summary>
        /// 설비 마스터 바인딩 정보 조회
        /// </summary>
        public DataTable Equipment_Info_Mst_Binding(EquipmentCodeMstRegisterEntity pEquipmentCodeMstRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new EquipmentCodeMstRegisterProvider(pDBManager).Equipment_Info_Mst_Binding(pEquipmentCodeMstRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Equipment_Info_Mst_Binding(EquipmentCodeMstRegisterEntity pEquipmentCodeMstRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Equipment_Info_Detail(EquipmentCodeMstRegisterEntity pEquipmentCodeMstRegisterEntity)

        /// <summary>
        /// 설비 상세 정보 조회
        /// </summary>
        public DataTable Equipment_Info_Detail(EquipmentCodeMstRegisterEntity pEquipmentCodeMstRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new EquipmentCodeMstRegisterProvider(pDBManager).Equipment_Info_Detail(pEquipmentCodeMstRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Equipment_Info_Detail(EquipmentCodeMstRegisterEntity pEquipmentCodeMstRegisterEntity)", pException);
            }
        }

        #endregion


        #region 그리드 정보 저장 - Equipment_Info_Save(EquipmentCodeMstRegisterEntity pEquipmentCodeMstRegisterEntity, DataTable dt)

        /// <summary>
        /// 정보 저장
        /// </summary>
        public bool Equipment_Info_Save(EquipmentCodeMstRegisterEntity pEquipmentCodeMstRegisterEntity, DataTable dt)
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
                    bool isReturn = new EquipmentCodeMstRegisterProvider(pDBManager).Equipment_Info_Save(pEquipmentCodeMstRegisterEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Equipment_Info_Save(EquipmentCodeMstRegisterEntity pEquipmentCodeMstRegisterEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public EquipmentCodeMstRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                EquipmentCodeMstRegisterEntity pEquipmentCodeMstRegisterEntity = new EquipmentCodeMstRegisterProvider(null).GetEntity(pDataRow);
                return pEquipmentCodeMstRegisterEntity;
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



        #region 이미지 삭제
        public bool Equipment_Info_Image_delete(EquipmentCodeMstRegisterEntity pEquipmentCodeMstRegisterEntity)
        {
            try
            {
                
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new EquipmentCodeMstRegisterProvider(pDBManager).Equipment_Info_Image_Delete(pEquipmentCodeMstRegisterEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Equipment_Info_Image_delete(EquipmentCodeMstRegisterEntity pEquipmentCodeMstRegisterEntity)", pException);
            }
        }

        #endregion  
    }


    public class EquipmentCheckBusiness
    {
        #region 마스터 정보 조회 - EquipmentCheck_Mst(EquipmentCheckEntity pEquipmentCheckEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable EquipmentCheck_Mst(EquipmentCheckEntity pEquipmentCheckEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new EquipmentCheckProvider(pDBManager).EquipmentCheck_Mst(pEquipmentCheckEntity);
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

        #region 서식파일 조회 - EquipmentChange_Sub(EquipmentChangeEntity pEquipmentChangeEntity)
        public DataTable EquipmentCheck_Sub(EquipmentCheckEntity pEquipmentCheckEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new EquipmentCheckProvider(pDBManager).EquipmentCheck_Sub(pEquipmentCheckEntity);
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

        #region 그리드 정보 저장 - EquipmentCheck_Save(EquipmentCheckEntity pEquipmentCheckEntity)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool EquipmentCheck_Save(EquipmentCheckEntity pEquipmentCheckEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new EquipmentCheckProvider(pDBManager).EquipmentCheck_Save(pEquipmentCheckEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "EquipmentCheck_Save(EquipmentCheckEntity pEquipmentCheckEntity)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public EquipmentCheckEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                EquipmentCheckEntity pListofManagementEntity = new EquipmentCheckProvider(null).GetEntity(pDataRow);
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

    public class EquipmentChangeBusiness
    {
        #region 마스터 정보 조회 - EquipmentChange_Mst(EquipmentChangeEntity pEquipmentChangeEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable EquipmentChange_Mst(EquipmentChangeEntity pEquipmentChangeEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new EquipmentChangeProvider(pDBManager).EquipmentChange_Mst(pEquipmentChangeEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "EquipmentChange_Mst(EquipmentChangeEntity pEquipmentChangeEntity)", pException);
            }
        }

        #endregion

        #region 서식파일 조회 - EquipmentChange_Sub(EquipmentChangeEntity pEquipmentChangeEntity)
        public DataTable EquipmentChange_Sub(EquipmentChangeEntity pEquipmentChangeEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new EquipmentChangeProvider(pDBManager).EquipmentChange_Sub(pEquipmentChangeEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "EquipmentChange_Sub(EquipmentChangeEntity pEquipmentChangeEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - EquipmentChange_Save(EquipmentChangeEntity pEquipmentChangeEntity)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool EquipmentChange_Save(EquipmentChangeEntity pEquipmentChangeEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new EquipmentChangeProvider(pDBManager).EquipmentChange_Save(pEquipmentChangeEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "EquipmentChange_Save(EquipmentChangeEntity pEquipmentChangeEntity)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public EquipmentChangeEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                EquipmentChangeEntity pListofManagementEntity = new EquipmentChangeProvider(null).GetEntity(pDataRow);
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
    
    public class ucEquipmentDocumentListPopupBusiness
    {
        #region 메인 정보 조회 - ucEquipmentDocumentListPopup_Info_Main(ucEquipmentDocumentListPopupEntity pucEquipmentDocumentListPopupEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ucEquipmentDocumentListPopup_Info_Main(ucEquipmentDocumentListPopupEntity pucEquipmentDocumentListPopupEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucEquipmentDocumentListPopupProvider(pDBManager).ucEquipmentDocumentListPopup_Info_Main(pucEquipmentDocumentListPopupEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucEquipmentDocumentListPopup_Info_Main(ucEquipmentDocumentListPopupEntity pucEquipmentDocumentListPopupEntity)", pException);
            }
        }

        #endregion

        #region 서브 정보 조회 - ucEquipmentDocumentListPopup_Info_Sub(ucEquipmentDocumentListPopupEntity pucEquipmentDocumentListPopupEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ucEquipmentDocumentListPopup_Info_Sub(ucEquipmentDocumentListPopupEntity pucEquipmentDocumentListPopupEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucEquipmentDocumentListPopupProvider(pDBManager).ucEquipmentDocumentListPopup_Info_Sub(pucEquipmentDocumentListPopupEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucEquipmentDocumentListPopup_Info_Sub(ucEquipmentDocumentListPopupEntity pucEquipmentDocumentListPopupEntity)", pException);
            }
        }

        #endregion

        #region 정보 저장 - ucEquipmentDocumentListPopup_Info_Save(ucEquipmentDocumentListPopupEntity pucEquipmentDocumentListPopupEntity, DataTable dt)

        /// <summary>
        /// 정보 저장
        /// </summary>
        public bool ucEquipmentDocumentListPopup_Info_Save(ucEquipmentDocumentListPopupEntity pucEquipmentDocumentListPopupEntity, DataTable dt)
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
                    bool isReturn = new ucEquipmentDocumentListPopupProvider(pDBManager).ucEquipmentDocumentListPopup_Info_Save(pucEquipmentDocumentListPopupEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucEquipmentDocumentListPopup_Info_Save(ucEquipmentDocumentListPopupEntity pucEquipmentDocumentListPopupEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ucEquipmentDocumentListPopupEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ucEquipmentDocumentListPopupEntity pucEquipmentDocumentListPopupEntity = new ucEquipmentDocumentListPopupProvider(null).GetEntity(pDataRow);
                return pucEquipmentDocumentListPopupEntity;
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

    #region o 설비예방보전_T01
    public class EquipmentCheck_T01Business
    {
        #region 마스터 정보 조회 - Sample_Info(EquipmentCheck_T01Entity pEquipmentCheck_T01Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(EquipmentCheck_T01Entity pEquipmentCheck_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new EquipmentCheck_T01Provider(pDBManager).Sample_Info_Mst(pEquipmentCheck_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(EquipmentCheck_T01Entity pSampleRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(EquipmentCheck_T01Entity pEquipmentCheck_T01Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(EquipmentCheck_T01Entity pEquipmentCheck_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new EquipmentCheck_T01Provider(pDBManager).Sample_Info_Mst(pEquipmentCheck_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(EquipmentCheck_T01Entity pEquipmentCheck_T01Entity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(EquipmentCheck_T01Entity pEquipmentCheck_T01Entity, pDataTable)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(EquipmentCheck_T01Entity pEquipmentCheck_T01Entity, DataTable pDataTable)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new EquipmentCheck_T01Provider(pDBManager).Sample_Info_Save(pEquipmentCheck_T01Entity, pDataTable);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "EquipmentCheck_T01_Save(EquipmentCheck_T01Entity pEquipmentCheck_T01Entity, DataTable pDataTable)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - Sample_Info_Filename(SampleRegisterEntity pSampleRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable EquipmentCheck_T01_Info_Filename(EquipmentCheck_T01Entity pEquipmentCheck_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new EquipmentCheck_T01Provider(pDBManager).EquipmentCheck_T01_Info_Filename(pEquipmentCheck_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "EquipmentCheck_T01_Info_Filename(EquipmentCheck_T01Entity pEquipmentCheck_T01Entity)", pException);
            }
        }

        #endregion

        #region XML파일 다운로드 - Templete_Download(EquipmentCheck_T01Entity pEquipmentCheck_T01Entity, string pMENU_NO, string pDSP_SORT)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public object Templete_Download(EquipmentCheck_T01Entity pEquipmentCheck_T01Entity, string pMENU_NO, string pDSP_SORT)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    object pObject = new EquipmentCheck_T01Provider(pDBManager).Templete_Download(pEquipmentCheck_T01Entity, pMENU_NO, pDSP_SORT);
                    return pObject;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "EquipmentCheck_T01Provider(pDBManager).Templete_Download(pEquipmentCheck_T01Entity, pMENU_NO, pDSP_SORT)", pException);
            }
        }

        #endregion
                
        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public EquipmentCheck_T01Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                EquipmentCheck_T01Entity pSampleRegisterEntity = new EquipmentCheck_T01Provider(null).GetEntity(pDataRow);
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


    #region 설비이력조회
    public class EquipmentHistoryBusiness
    {
        #region 마스터 정보 조회 - EquipmentCheck_Mst(EquipmentHistoryEntity _pEquipmentHistoryEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable EquipmentHistory_Mst(EquipmentHistoryEntity _pEquipmentHistoryEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new EquipmentHistoryProvider(pDBManager).EquipmentHistory_Mst(_pEquipmentHistoryEntity);
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

        #region 서식파일 조회 - EquipmentChange_Sub(EquipmentChangeEntity pEquipmentChangeEntity)
        public DataTable EquipmentCheck_Sub(EquipmentCheckEntity pEquipmentCheckEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new EquipmentCheckProvider(pDBManager).EquipmentCheck_Sub(pEquipmentCheckEntity);
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

        #region 그리드 정보 저장 - EquipmentCheck_Save(EquipmentCheckEntity pEquipmentCheckEntity)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool EquipmentCheck_Save(EquipmentCheckEntity pEquipmentCheckEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new EquipmentCheckProvider(pDBManager).EquipmentCheck_Save(pEquipmentCheckEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "EquipmentCheck_Save(EquipmentCheckEntity pEquipmentCheckEntity)", pException);
            }
        }

        #endregion
        #region ○ 화면명에 맞는 엑셀파일 불러오기
        public DataTable Sheet_Info_Sheet(EquipmentHistoryEntity _pEquipmentHistoryEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pdatatable = new EquipmentHistoryProvider(pDBManager).Sheet_Info_sheet(_pEquipmentHistoryEntity);
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
        public EquipmentHistoryEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                EquipmentHistoryEntity _pEquipmentHistoryEntity = new EquipmentHistoryProvider(null).GetEntity(pDataRow);
                return _pEquipmentHistoryEntity;
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

    #region 설비비가동이력조회
    public class EquipmentStopHistoryBusiness
    {
        #region 마스터 정보 조회 - EquipmentCheck_Mst(EquipmentHistoryEntity _pEquipmentHistoryEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable EquipmentStopHistory_Mst(EquipmentStopHistoryEntity _pEquipmentStopHistoryEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new EquipmentStopHistoryProvider(pDBManager).EquipmentStopHistory_Mst(_pEquipmentStopHistoryEntity);
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
        public EquipmentStopHistoryEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                EquipmentStopHistoryEntity _pEquipmentStopHistoryEntity = new EquipmentStopHistoryProvider(null).GetEntity(pDataRow);
                return _pEquipmentStopHistoryEntity;
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

    public class EquipmentBaseRegister_T50Business
    {
        #region 마스터 정보 조회 - EquipmentCheck_Mst(EquipmentBaseRegister_T50Entity _pEquipmentBaseRegister_T50Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable EquipmentBaseRegister_T50_Mst(EquipmentBaseRegister_T50Entity _pEquipmentBaseRegister_T50Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new EquipmentBaseRegister_T50Provider(pDBManager).EquipmentBaseRegister_T50_Mst(_pEquipmentBaseRegister_T50Entity);
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

        #region 그리드 정보 저장 - EquipmentBaseRegister_T50_Save(EquipmentCheckEntity pEquipmentCheckEntity)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool EquipmentBaseRegister_T50_Save(EquipmentBaseRegister_T50Entity pEquipmentBaseRegister_T50Entity, DataTable dt)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new EquipmentBaseRegister_T50Provider(pDBManager).EquipmentBaseRegister_T50_Save(pEquipmentBaseRegister_T50Entity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "EquipmentCheck_Save(EquipmentCheckEntity pEquipmentCheckEntity)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public EquipmentBaseRegister_T50Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                EquipmentBaseRegister_T50Entity _pEquipmentBaseRegister_T50Entity = new EquipmentBaseRegister_T50Provider(null).GetEntity(pDataRow);
                return _pEquipmentBaseRegister_T50Entity;
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

    //EquipmentCheckListMonth_T50Entity

    public class EquipmentCheckListMonth_T50Business
    {
        #region 마스터 정보 조회 - EquipmentCheck_Mst(EquipmentBaseRegister_T50Entity _pEquipmentBaseRegister_T50Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable EquipmentCheckListMonth_T50_Mst(EquipmentCheckListMonth_T50Entity _pEquipmentCheckListMonth_T50Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new EquipmentCheckListMonth_T50Provider(pDBManager).EquipmentCheckListMonth_T50_Mst(_pEquipmentCheckListMonth_T50Entity);
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

        #region 그리드 정보 저장 - EquipmentCheckListMonth_T50_Save(EquipmentCheckEntity pEquipmentCheckEntity)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool EquipmentCheckListMonth_T50_Save(EquipmentCheckListMonth_T50Entity pEquipmentCheckListMonth_T50Entity, DataTable dt)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new EquipmentCheckListMonth_T50Provider(pDBManager).EquipmentCheckListMonth_T50_Save(pEquipmentCheckListMonth_T50Entity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "EquipmentCheck_Save(EquipmentCheckEntity pEquipmentCheckEntity)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public EquipmentCheckListMonth_T50Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                EquipmentCheckListMonth_T50Entity _pEquipmentCheckListMonth_T50Entity = new EquipmentCheckListMonth_T50Provider(null).GetEntity(pDataRow);
                return _pEquipmentCheckListMonth_T50Entity;
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
        public DataTable Sheet_Info_Sheet(EquipmentCheckListMonth_T50Entity pEquipmentCheckListMonth_T50Entity, string equipment)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pdatatable = new EquipmentCheckListMonth_T50Provider(pDBManager).Sheet_Info_sheet(pEquipmentCheckListMonth_T50Entity, equipment);
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


        public DataTable USP_equipment_check_result_R10(string date, string equipment, int condition)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pdatatable = new EquipmentCheckListMonth_T50Provider(pDBManager).USP_equipment_check_result_R10(date, equipment, condition);
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
    }
}
