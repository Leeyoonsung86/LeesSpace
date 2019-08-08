using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using CoFAS_MES.UI.IM.Data;
using CoFAS_MES.UI.IM.Entity;

using CoFAS_MES.CORE.Entity;
using CoFAS_MES.CORE.Function;

using DevExpress.Spreadsheet;

namespace CoFAS_MES.UI.IM.Business
{
    public class PartMstDownLoadBusiness
    {
        #region ○ 출하지시정보 조회

        public DataTable PartMstDownLoad_Info_Mst(PartMstDownLoadEntity pPartMstDownLoadEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new PartMstDownLoadProvider(pDBManager).PartMstDownLoad_Info_Mst(pPartMstDownLoadEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "PartMstDownLoad_Info_Mst(PartMstDownLoadEntity pPartMstDownLoadEntity)", pException);
            }
        }

        #endregion

        #region ○ 출하지시정보 저장

        public bool PartMstDownLoad_Info_Save(PartMstDownLoadEntity pPartMstDownLoadEntity)
        {
            try
            {

                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new PartMstDownLoadProvider(pDBManager).PartMstDownLoad_Info_Save(pPartMstDownLoadEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "PartMstDownLoad_Info_Save(PartMstDownLoadEntity pPartMstDownLoadEntity)", pException);
            }
        }

        #endregion
    }

    public class DocumentInfoRegisterBusiness
    {
        #region 정보 조회 - Document_Info_Main(DocumentInfoRegisterEntity pDocumentInfoRegisterEntity)

        /// <summary>
        /// 정보 조회
        /// </summary>
        public DataTable Document_Info_Main(DocumentInfoRegisterEntity pDocumentInfoRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new DocumentInfoRegisterProvider(pDBManager).Document_Info_Main(pDocumentInfoRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Document_Info_Main(DocumentInfoRegisterEntity pDocumentInfoRegisterEntity)", pException);
            }
        }

        #endregion

        #region 정보 조회 - Document_Info_Sub(DocumentInfoRegisterEntity pDocumentInfoRegisterEntity)

        /// <summary>
        /// 정보 조회
        /// </summary>
        public DataTable Document_Info_Sub(DocumentInfoRegisterEntity pDocumentInfoRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new DocumentInfoRegisterProvider(pDBManager).Document_Info_Sub(pDocumentInfoRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Document_Info_Sub(DocumentInfoRegisterEntity pDocumentInfoRegisterEntity)", pException);
            }
        }

        #endregion

        #region 언어 정보 저장 - Document_Info_Save(DocumentInfoRegisterEntity pDocumentInfoRegisterEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Document_Info_Save(DocumentInfoRegisterEntity pDocumentInfoRegisterEntity, DataTable dt)
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
                        isReturn = new DocumentInfoRegisterProvider(pDBManager).Document_Info_Save(pDocumentInfoRegisterEntity, dtTemp);
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

        #region OPENBUTTON으로 파일,파일명 삭제 - Document_File_Delete(DocumentInfoRegisterEntity pDocumentInfoRegisterEntity)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Document_File_Delete(DocumentInfoRegisterEntity pDocumentInfoRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new DocumentInfoRegisterProvider(pDBManager).Document_File_Delete(pDocumentInfoRegisterEntity);
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
        public DocumentInfoRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                DocumentInfoRegisterEntity pDocumentInfoRegisterEntity = new DocumentInfoRegisterProvider(null).GetEntity(pDataRow);
                return pDocumentInfoRegisterEntity;
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

    public class VendorInformationBusiness
    {
        #region 마스터 정보 조회 - Vend_Info_Mst(VendorInformationEntity pVendorInformationEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Vend_Info_Mst(VendorInformationEntity pVendorInformationEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new VendorInformationProvider(pDBManager).Vend_Info_Mst(pVendorInformationEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Vend_Info_Mst(VendorInformationEntity pVendorInformationEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Vend_Info_Sub(VendorInformationEntity pVendorInformationEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Vend_Info_Sub(VendorInformationEntity pVendorInformationEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new VendorInformationProvider(pDBManager).Vend_Info_Sub(pVendorInformationEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Vend_Info_Sub(VendorInformationEntity pVendorInformationEntity)", pException);
            }
        }

        #endregion

        #region 거래처 중복 체크 - Vend_Info_chk(VendorInformationEntity pVendorInformationEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Vend_Info_chk(VendorInformationEntity pVendorInformationEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new VendorInformationProvider(pDBManager).Vend_Info_Chk(pVendorInformationEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Vend_Info_chk(VendorInformationEntity pVendorInformationEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Grid_Info_Save(GridInfoRegisterEntity pGridInfoRegisterEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Vend_Info_Save(VendorInformationEntity pVendorInformationEntity, DataTable dt)
        {
            try
            {

                DataTable dtTemp = null;

                bool isChack = CoFAS_ConvertManager.DataTable_FindCount(dt, "CRUD ='C' or CRUD ='U' or CRUD ='D'", "");

                if (isChack)
                {
                    dtTemp = CoFAS_ConvertManager.DataTable_FindValue(dt, "CRUD ='C' or CRUD ='U' or CRUD ='D'", ""); // 신규 and 수정 항목 데이터 테이블 화
                }

                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new VendorInformationProvider(pDBManager).Vend_Info_Save(pVendorInformationEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Vend_Info_Save(VendorInformationEntity pVendorInformationEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public VendorInformationEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                VendorInformationEntity pVendorInformationEntity = new VendorInformationProvider(null).GetEntity(pDataRow);
                return pVendorInformationEntity;
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

    public class VendorInformation_T01Business
    {
        #region 마스터 정보 조회 - Vend_Info_Mst(VendorInformation_T01Entity pVendorInformation_T01Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Vend_Info_Mst(VendorInformation_T01Entity pVendorInformation_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new VendorInformation_T01Provider(pDBManager).Vend_Info_Mst(pVendorInformation_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Vend_Info_Mst(VendorInformation_T01Entity pVendorInformation_T01Entity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Vend_Info_Sub(VendorInformation_T01Entity pVendorInformation_T01Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Vend_Info_Sub(VendorInformation_T01Entity pVendorInformation_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new VendorInformation_T01Provider(pDBManager).Vend_Info_Sub(pVendorInformation_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Vend_Info_Sub(VendorInformation_T01Entity pVendorInformation_T01Entity)", pException);
            }
        }

        #endregion

        #region 거래처 중복 체크 - Vend_Info_chk(VendorInformationEntity pVendorInformationEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Vend_Info_chk(VendorInformation_T01Entity pVendorInformation_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new VendorInformation_T01Provider(pDBManager).Vend_Info_Chk(pVendorInformation_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Vend_Info_chk(VendorInformation_T01Entity pVendorInformation_T01Entity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Grid_Info_Save(GridInfoRegisterEntity pGridInfoRegisterEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Vend_Info_Save(VendorInformation_T01Entity pVendorInformation_T01Entity, DataTable dt)
        {
            try
            {

                DataTable dtTemp = null;

                bool isChack = CoFAS_ConvertManager.DataTable_FindCount(dt, "CRUD ='C' or CRUD ='U' or CRUD ='D'", "");

                if (isChack)
                {
                    dtTemp = CoFAS_ConvertManager.DataTable_FindValue(dt, "CRUD ='C' or CRUD ='U' or CRUD ='D'", ""); // 신규 and 수정 항목 데이터 테이블 화
                }

                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new VendorInformation_T01Provider(pDBManager).Vend_Info_Save(pVendorInformation_T01Entity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Vend_Info_Save(VendorInformation_T01Entity pVendorInformation_T01Entity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public VendorInformation_T01Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                VendorInformation_T01Entity pVendorInformation_T01Entity = new VendorInformation_T01Provider(null).GetEntity(pDataRow);
                return pVendorInformation_T01Entity;
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


    public class GatheringInformationBusiness
    {
        #region 마스터 정보 조회 - Gathering_Info_Mst(VendorInformationEntity pVendorInformationEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Gathering_Info_Mst(GatheringInformationEntity pGatheringInformationEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new GatheringInformationProvider(pDBManager).Gathering_Info_Mst(pGatheringInformationEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Gathering_Info_Mst(GatheringInformationEntity pGatheringInformationEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Gathering_Info_Sub(GatheringInformationEntity pGatheringInformationEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Gathering_Info_Sub(GatheringInformationEntity pGatheringInformationEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new GatheringInformationProvider(pDBManager).Gathering_Info_Sub(pGatheringInformationEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Gathering_Info_Sub(GatheringInformationEntity pGatheringInformationEntity)", pException);
            }
        }

        #endregion

        #region 거래처 중복 체크 - Gathering_Info_chk(GatheringInformationEntity pGatheringInformationEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Gathering_Info_chk(GatheringInformationEntity pGatheringInformationEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new GatheringInformationProvider(pDBManager).Gathering_Info_Chk(pGatheringInformationEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Gathering_Info_chk(GatheringInformationEntity pGatheringInformationEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Grid_Info_Save(GridInfoRegisterEntity pGridInfoRegisterEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Gathering_Info_Save(GatheringInformationEntity pGatheringInformationEntity, DataTable dt)
        {
            try
            {

                DataTable dtTemp = null;

                bool isChack = CoFAS_ConvertManager.DataTable_FindCount(dt, "CRUD ='C' or CRUD ='U' or CRUD ='D'", "");

                if (isChack)
                {
                    dtTemp = CoFAS_ConvertManager.DataTable_FindValue(dt, "CRUD ='C' or CRUD ='U' or CRUD ='D'", ""); // 신규 and 수정 항목 데이터 테이블 화
                }

                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new GatheringInformationProvider(pDBManager).Gathering_Info_Save(pGatheringInformationEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Gathering_Info_Save(GatheringInformationEntity pGatheringInformationEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public GatheringInformationEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                GatheringInformationEntity pGatheringInformationEntity = new GatheringInformationProvider(null).GetEntity(pDataRow);
                return pGatheringInformationEntity;
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

    public class ProcessCodeMstRegisterBusiness
    {
        #region 마스터 정보 조회 - Process_Info_Mst(ProcessCodeMstRegisterEntity pProcessCodeMstRegisterEntity)

        /// <summary>
        /// 프로세스 정보 조회
        /// </summary>
        public DataTable Process_Info_Mst(ProcessCodeMstRegisterEntity pProcessCodeMstRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProcessCodeMstRegisterProvider(pDBManager).Process_Info_Mst(pProcessCodeMstRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Process_Info_Mst(ProcessCodeMstRegisterEntity pProcessCodeMstRegisterEntity)", pException);
            }
        }

        #endregion

        #region 마스터 바인딩 정보 조회 - Process_Info_Mst_Binding(ProcessCodeMstRegisterEntity pProcessCodeMstRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Process_Info_Mst_Binding(ProcessCodeMstRegisterEntity pProcessCodeMstRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProcessCodeMstRegisterProvider(pDBManager).Process_Info_Mst_Binding(pProcessCodeMstRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Process_Info_Mst_Binding(ProcessCodeMstRegisterEntity pProcessCodeMstRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Process_Info_Detail(ProcessCodeMstRegisterEntity pProcessCodeMstRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Process_Info_Detail(ProcessCodeMstRegisterEntity pProcessCodeMstRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProcessCodeMstRegisterProvider(pDBManager).Process_Info_Detail(pProcessCodeMstRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Process_Info_Mst(ProcessCodeMstRegisterEntity pProcessCodeMstRegisterEntity)", pException);
            }
        }

        #endregion


        #region 그리드 정보 저장 - Process_Info_Save(ProcessCodeMstRegisterEntity pProcessCodeMstRegisterEntity, DataTable dt)

        /// <summary>
        /// 정보 저장
        /// </summary>
        public bool Process_Info_Save(ProcessCodeMstRegisterEntity pProcessCodeMstRegisterEntity, DataTable dt)
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
                    bool isReturn = new ProcessCodeMstRegisterProvider(pDBManager).Process_Info_Save(pProcessCodeMstRegisterEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Process_Info_Save(ProcessCodeMstRegisterEntity pProcessCodeMstRegisterEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ProcessCodeMstRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ProcessCodeMstRegisterEntity pProcessCodeMstRegisterEntity = new ProcessCodeMstRegisterProvider(null).GetEntity(pDataRow);
                return pProcessCodeMstRegisterEntity;
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

    public class TerminalInfoMstRegisterBusiness
    {
        #region 마스터 정보 조회 - Terminal_Info_Mst(TerminalInfoMstRegisterEntity pTerminalInfoMstRegisterEntity)

        /// <summary>
        /// 프로세스 정보 조회
        /// </summary>
        public DataTable Terminal_Info_Mst(TerminalInfoMstRegisterEntity pTerminalInfoMstRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new TerminalInfoMstRegisterProvider(pDBManager).Terminal_Info_Mst(pTerminalInfoMstRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Terminal_Info_Mst(TerminalInfoMstRegisterEntity pTerminalInfoMstRegisterEntity)", pException);
            }
        }

        #endregion

        #region 마스터 바인딩 정보 조회 - Terminal_Info_Mst_Binding(TerminalInfoMstRegisterEntity pTerminalInfoMstRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Terminal_Info_Mst_Binding(TerminalInfoMstRegisterEntity pTerminalInfoMstRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new TerminalInfoMstRegisterProvider(pDBManager).Terminal_Info_Mst_Binding(pTerminalInfoMstRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Terminal_Info_Mst_Binding(TerminalInfoMstRegisterEntity pTerminalInfoMstRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 -  Terminal_Info_Detail(TerminalInfoMstRegisterEntity pTerminalInfoMstRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Terminal_Info_Detail(TerminalInfoMstRegisterEntity pTerminalInfoMstRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new TerminalInfoMstRegisterProvider(pDBManager).Terminal_Info_Detail(pTerminalInfoMstRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Terminal_Info_Detail(TerminalInfoMstRegisterEntity pTerminalInfoMstRegisterEntity)", pException);
            }
        }

        #endregion


        #region 그리드 정보 저장 - Terminal_Info_Save(TerminalInfoMstRegisterEntity pTerminalInfoMstRegisterEntity, DataTable dt)

        /// <summary>
        /// 정보 저장
        /// </summary>
        public bool Terminal_Info_Save(TerminalInfoMstRegisterEntity pTerminalInfoMstRegisterEntity, DataTable dt)
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
                    bool isReturn = new TerminalInfoMstRegisterProvider(pDBManager).Terminal_Info_Save(pTerminalInfoMstRegisterEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Terminal_Info_Save(TerminalInfoMstRegisterEntity pTerminalInfoMstRegisterEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public TerminalInfoMstRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                TerminalInfoMstRegisterEntity pTerminalInfoMstRegisterEntity = new TerminalInfoMstRegisterProvider(null).GetEntity(pDataRow);
                return pTerminalInfoMstRegisterEntity;
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

    public class ToolInfoMstRegisterBusiness
    {
        #region 마스터 정보 조회 - Tool_Info_Mst(ToolInfoMstRegisterEntity pToolInfoMstRegisterEntity)

        /// <summary>
        /// 프로세스 정보 조회
        /// </summary>
        public DataTable Tool_Info_Mst(ToolInfoMstRegisterEntity pToolInfoMstRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ToolInfoMstRegisterProvider(pDBManager).Tool_Info_Mst(pToolInfoMstRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Tool_Info_Mst(ToolInfoMstRegisterEntity pToolInfoMstRegisterEntity)", pException);
            }
        }

        #endregion

        #region 마스터 바인딩 정보 조회 - Tool_Info_Mst_Binding(ToolInfoMstRegisterEntity pToolInfoMstRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Tool_Info_Mst_Binding(ToolInfoMstRegisterEntity pToolInfoMstRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ToolInfoMstRegisterProvider(pDBManager).Tool_Info_Mst_Binding(pToolInfoMstRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Tool_Info_Mst_Binding(ToolInfoMstRegisterEntity pToolInfoMstRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 -  Tool_Info_Detail(ToolInfoMstRegisterEntity pToolInfoMstRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Tool_Info_Detail(ToolInfoMstRegisterEntity pToolInfoMstRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ToolInfoMstRegisterProvider(pDBManager).Tool_Info_Detail(pToolInfoMstRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Tool_Info_Detail(ToolInfoMstRegisterEntity pToolInfoMstRegisterEntity)", pException);
            }
        }

        #endregion


        #region 그리드 정보 저장 - Tool_Info_Save(ToolInfoMstRegisterEntity pToolInfoMstRegisterEntity, DataTable dt)

        /// <summary>
        /// 정보 저장
        /// </summary>
        public bool Tool_Info_Save(ToolInfoMstRegisterEntity pToolInfoMstRegisterEntity, DataTable dt)
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
                    bool isReturn = new ToolInfoMstRegisterProvider(pDBManager).Tool_Info_Save(pToolInfoMstRegisterEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Tool_Info_Save(ToolInfoMstRegisterEntity pToolInfoMstRegisterEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ToolInfoMstRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ToolInfoMstRegisterEntity pToolInfoMstRegisterEntity = new ToolInfoMstRegisterProvider(null).GetEntity(pDataRow);
                return pToolInfoMstRegisterEntity;
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

    public class ToolInfoMstRegister_T01Business
    {
        #region 마스터 정보 조회 - Tool_Info_Mst(ToolInfoMstRegisterEntity pToolInfoMstRegisterEntity)

        /// <summary>
        /// 프로세스 정보 조회
        /// </summary>
        public DataTable Tool_Info_Mst(ToolInfoMstRegister_T01Entity pToolInfoMstRegister_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ToolInfoMstRegister_T01Provider(pDBManager).Tool_Info_Mst(pToolInfoMstRegister_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Tool_Info_Mst(ToolInfoMstRegister_T01Entity pToolInfoMstRegister_T01Entity)", pException);
            }
        }

        #endregion

        #region 마스터 바인딩 정보 조회 - Tool_Info_Mst_Binding(ToolInfoMstRegister_T01Entity pToolInfoMstRegister_T01Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Tool_Info_Mst_Binding(ToolInfoMstRegister_T01Entity pToolInfoMstRegister_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ToolInfoMstRegister_T01Provider(pDBManager).Tool_Info_Mst_Binding(pToolInfoMstRegister_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Tool_Info_Mst_Binding(ToolInfoMstRegister_T01Entity pToolInfoMstRegister_T01Entity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 -  Tool_Info_Detail(ToolInfoMstRegister_T01Entity pToolInfoMstRegister_T01Entity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Tool_Info_Detail(ToolInfoMstRegister_T01Entity pToolInfoMstRegister_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ToolInfoMstRegister_T01Provider(pDBManager).Tool_Info_Detail(pToolInfoMstRegister_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Tool_Info_Detail(ToolInfoMstRegister_T01Entity pToolInfoMstRegister_T01Entity)", pException);
            }
        }

        #endregion


        #region 그리드 정보 저장 - Tool_Info_Save(ToolInfoMstRegisterEntity pToolInfoMstRegisterEntity, DataTable dt)

        /// <summary>
        /// 정보 저장
        /// </summary>
        public bool Tool_Info_Save(ToolInfoMstRegister_T01Entity pToolInfoMstRegister_T01Entity, DataTable dt)
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
                    bool isReturn = new ToolInfoMstRegister_T01Provider(pDBManager).Tool_Info_Save(pToolInfoMstRegister_T01Entity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Tool_Info_Save(ToolInfoMstRegister_T01Entity pToolInfoMstRegister_T01Entity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ToolInfoMstRegister_T01Entity GetEntity(DataRow pDataRow)
        {
            try
            {
                ToolInfoMstRegister_T01Entity pToolInfoMstRegister_T01Entity = new ToolInfoMstRegister_T01Provider(null).GetEntity(pDataRow);
                return pToolInfoMstRegister_T01Entity;
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


    public class ProcessConfigurationRegisterBusiness
    {
        #region 마스터 라우팅 정보 조회 - ProcessConfigurationRegister_Info_Main(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)

        /// <summary>
        /// 공정 구성 정보 조회
        /// </summary>
        public DataTable ProcessConfigurationRegister_Info_Main(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProcessConfigurationRegisterProvider(pDBManager).ProcessConfigurationRegister_Info_Main(pProcessConfigurationRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProcessConfigurationRegister_Info_Main(ProductBOMRegisterEntity pProductBOMRegisterEntity)", pException);
            }
        }

        #endregion

        #region 구성 정보 조회 - ProcessConfigurationRegister_Info_SUB01(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)

        /// <summary>
        /// 공정 구성 정보 조회
        /// </summary>
        public DataTable ProcessConfigurationRegister_Info_SUB01(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProcessConfigurationRegisterProvider(pDBManager).ProcessConfigurationRegister_Info_SUB01(pProcessConfigurationRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProcessConfigurationRegister_Info_SUB01(ProductBOMRegisterEntity pProductBOMRegisterEntity)", pException);
            }
        }

        #endregion

        #region 구성 정보 조회 - ProcessConfigurationRegister_Info_SUB02(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)

        /// <summary>
        /// 공정 구성 정보 조회
        /// </summary>
        public DataTable ProcessConfigurationRegister_Info_SUB02(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProcessConfigurationRegisterProvider(pDBManager).ProcessConfigurationRegister_Info_SUB02(pProcessConfigurationRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProcessConfigurationRegister_Info_SUB02(ProductBOMRegisterEntity pProductBOMRegisterEntity)", pException);
            }
        }

        #endregion

        #region 구성 정보 조회 - ProcessConfigurationRegister_Info_WorkCenter_SUB02(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)

        /// <summary>
        /// 공정 구성 정보 조회
        /// </summary>
        public DataTable ProcessConfigurationRegister_Info_WorkCenter_SUB02(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProcessConfigurationRegisterProvider(pDBManager).ProcessConfigurationRegister_Info_WorkCenter_SUB02(pProcessConfigurationRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProcessConfigurationRegister_Info_WorkCenter_SUB02(ProductBOMRegisterEntity pProductBOMRegisterEntity)", pException);
            }
        }

        #endregion



        #region 구성 정보 조회 - ProcessConfigurationRegister_Info_SUB03(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)

        /// <summary>
        /// 공정 구성 정보 조회
        /// </summary>
        public DataTable ProcessConfigurationRegister_Info_SUB03(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProcessConfigurationRegisterProvider(pDBManager).ProcessConfigurationRegister_Info_SUB03(pProcessConfigurationRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProcessConfigurationRegister_Info_SUB03(ProductBOMRegisterEntity pProductBOMRegisterEntity)", pException);
            }
        }

        #endregion

        #region 구성 정보 조회 - ProcessConfigurationRegister_Info_SUB04(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)

        /// <summary>
        /// 공정 구성 정보 조회
        /// </summary>
        public DataTable ProcessConfigurationRegister_Info_SUB04(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProcessConfigurationRegisterProvider(pDBManager).ProcessConfigurationRegister_Info_SUB04(pProcessConfigurationRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProcessConfigurationRegister_Info_SUB04(ProductBOMRegisterEntity pProductBOMRegisterEntity)", pException);
            }
        }

        #endregion

        #region 구성 정보 조회 - ProcessConfigurationRegister_Info_SUB05(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)

        /// <summary>
        /// 공정 구성 정보 조회
        /// </summary>
        public DataTable ProcessConfigurationRegister_Info_SUB05(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProcessConfigurationRegisterProvider(pDBManager).ProcessConfigurationRegister_Info_SUB05(pProcessConfigurationRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProcessConfigurationRegister_Info_SUB05(ProductBOMRegisterEntity pProductBOMRegisterEntity)", pException);
            }
        }

        #endregion

        #region 구성 정보 조회 - ProcessConfigurationRegister_Info_SUB06(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)

        /// <summary>
        /// 공정 구성 정보 조회
        /// </summary>
        public DataTable ProcessConfigurationRegister_Info_SUB06(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProcessConfigurationRegisterProvider(pDBManager).ProcessConfigurationRegister_Info_SUB06(pProcessConfigurationRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProcessConfigurationRegister_Info_SUB06(ProductBOMRegisterEntity pProductBOMRegisterEntity)", pException);
            }
        }

        #endregion

        #region 공정 라우팅 정보 조회하기 - ProcessConfigurationRegister_Info_Process(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)

        /// <summary>
        /// 공정 라우팅 정보 조회
        /// </summary>
        public DataTable ProcessConfigurationRegister_Info_Process(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProcessConfigurationRegisterProvider(pDBManager).ProcessConfigurationRegister_Info_Process(pProcessConfigurationRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProcessConfigurationRegister_Info_Process(ProductBOMRegisterEntity pProductBOMRegisterEntity)", pException);
            }
        }

        #endregion


        #region 공정 라우팅 마스터 정보 조회 - ProcessConfigurationRegister_Routing_Mst(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)

        /// <summary>
        /// 트리리스트 라우팅 입력용 정보 조회
        /// </summary>
        public DataTable ProcessConfigurationRegister_Routing_Mst(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProcessConfigurationRegisterProvider(pDBManager).ProcessConfigurationRegister_Routing_Mst(pProcessConfigurationRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProcessConfigurationRegister_Routing_Mst(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)", pException);
            }
        }

        #endregion

        #region 트리리스트 라우팅 입력용 정보 조회 - ProcessConfigurationRegister_Routing_Tree(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)

        /// <summary>
        /// 트리리스트 라우팅 입력용 정보 조회
        /// </summary>
        public DataTable ProcessConfigurationRegister_Routing_Tree(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProcessConfigurationRegisterProvider(pDBManager).ProcessConfigurationRegister_Routing_Tree(pProcessConfigurationRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProcessConfigurationRegister_Routing_Tree(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)", pException);
            }
        }

        #endregion




        #region 공정 라우팅 구성 마스터 정보 조회하기 - ProcessConfigurationRegister_Info_Routing_MST(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)

        /// <summary>
        /// 공정 구성 정보 조회
        /// </summary>
        public DataTable ProcessConfigurationRegister_Info_Routing_MST(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProcessConfigurationRegisterProvider(pDBManager).ProcessConfigurationRegister_Info_Routing_MST(pProcessConfigurationRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProcessConfigurationRegister_Info_Routing_MST(ProductBOMRegisterEntity pProductBOMRegisterEntity)", pException);
            }
        }

        #endregion

        #region 트리리스트 공정 순서 입력용 정보 조회 - ProcessConfigurationRegister_Info_Routing_DETAIL(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)

        /// <summary>
        /// 트리리스트 BOM 신규 입력용 정보 조회
        /// </summary>
        public DataTable ProcessConfigurationRegister_Info_Routing_DETAIL(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProcessConfigurationRegisterProvider(pDBManager).ProcessConfigurationRegister_Info_Routing_DETAIL(pProcessConfigurationRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProcessConfigurationRegister_Info_Routing_DETAIL(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - ProcessConfigurationRegister_Info_Sub(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProcessConfigurationRegister_Info_Sub(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProcessConfigurationRegisterProvider(pDBManager).ProcessConfigurationRegister_Info_Sub(pProcessConfigurationRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProcessConfigurationRegister_Info_Sub(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)", pException);
            }
        }

        #endregion

        #region 정보 저장 - ProcessConfigurationRegister_Info_Save(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool ProcessConfigurationRegister_Info_Save(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity, DataTable dt)
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
                    // bool isReturn = new ProductBOMRegisterProvider(pDBManager).ProductBOMRegister_Info_Save(pProductBOMRegisterEntity, dtTemp);
                    bool isReturn = new ProcessConfigurationRegisterProvider(pDBManager).ProcessConfigurationRegister_Info_Save(pProcessConfigurationRegisterEntity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProcessConfigurationRegister_Info_Save(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 정보 저장 - ProcessConfigurationRegister_Info_Enable(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)
        public bool ProcessConfigurationRegister_Info_Enable(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ProcessConfigurationRegisterProvider(pDBManager).ProcessConfigurationRegister_Info_Enable(pProcessConfigurationRegisterEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProcessConfigurationRegister_Info_Enable(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity)", pException);
            }
        }
        #endregion

        #region 구성 정보 저장 - ProcessConfigurationRegister_Configuration_Save(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool ProcessConfigurationRegister_Configuration_Save(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity, DataTable dt)
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
                    // bool isReturn = new ProductBOMRegisterProvider(pDBManager).ProductBOMRegister_Info_Save(pProductBOMRegisterEntity, dtTemp);
                    bool isReturn = new ProcessConfigurationRegisterProvider(pDBManager).ProcessConfigurationRegister_Configuration_Save(pProcessConfigurationRegisterEntity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProcessConfigurationRegister_Configuration_Save(ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity, DataTable dt)", pException);
            }
        }

        #endregion



        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ProcessConfigurationRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity = new ProcessConfigurationRegisterProvider(null).GetEntity(pDataRow);
                return pProcessConfigurationRegisterEntity;
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

    public class ProcessRoutingRegisterBusiness
    {
        #region 마스터 라우팅 정보 조회 - ProcessRoutingRegister_Info_Main(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)

        /// <summary>
        /// 공정 구성 정보 조회
        /// </summary>
        public DataTable ProcessRoutingRegister_Info_Main(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProcessRoutingRegisterProvider(pDBManager).ProcessRoutingRegister_Info_Main(pProcessRoutingRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProcessRoutingRegister_Info_Main(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)", pException);
            }
        }

        #endregion

        #region 구성 정보 조회 - ProcessRoutingRegister_Info_SUB01(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)

        /// <summary>
        /// 공정 구성 정보 조회
        /// </summary>
        public DataTable ProcessRoutingRegister_Info_SUB01(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProcessRoutingRegisterProvider(pDBManager).ProcessRoutingRegister_Info_SUB01(pProcessRoutingRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProcessRoutingRegister_Info_SUB01(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)", pException);
            }
        }

        #endregion

        #region 구성 정보 조회 - ProcessRoutingRegister_Info_SUB02(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)

        /// <summary>
        /// 공정 구성 정보 조회
        /// </summary>
        public DataTable ProcessRoutingRegister_Info_SUB02(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProcessRoutingRegisterProvider(pDBManager).ProcessRoutingRegister_Info_SUB02(pProcessRoutingRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProcessRoutingRegister_Info_SUB02(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)", pException);
            }
        }

        #endregion

        #region 구성 정보 조회 - ProcessRoutingRegister_Info_WorkCenter_SUB02(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)

        /// <summary>
        /// 공정 구성 정보 조회
        /// </summary>
        public DataTable ProcessRoutingRegister_Info_WorkCenter_SUB02(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProcessRoutingRegisterProvider(pDBManager).ProcessRoutingRegister_Info_WorkCenter_SUB02(pProcessRoutingRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProcessRoutingRegister_Info_WorkCenter_SUB02(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)", pException);
            }
        }

        #endregion



        #region 구성 정보 조회 - ProcessRoutingRegister_Info_SUB03(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)

        /// <summary>
        /// 공정 구성 정보 조회
        /// </summary>
        public DataTable ProcessRoutingRegister_Info_SUB03(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProcessRoutingRegisterProvider(pDBManager).ProcessRoutingRegister_Info_SUB03(pProcessRoutingRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProcessRoutingRegister_Info_SUB03(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)", pException);
            }
        }

        #endregion

        #region 구성 정보 조회 - ProcessRoutingRegister_Info_SUB04(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)

        /// <summary>
        /// 공정 구성 정보 조회
        /// </summary>
        public DataTable ProcessRoutingRegister_Info_SUB04(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProcessRoutingRegisterProvider(pDBManager).ProcessRoutingRegister_Info_SUB04(pProcessRoutingRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProcessRoutingRegister_Info_SUB04(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)", pException);
            }
        }

        #endregion

        #region 구성 정보 조회 - ProcessRoutingRegister_Info_SUB05(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)

        /// <summary>
        /// 공정 구성 정보 조회
        /// </summary>
        public DataTable ProcessRoutingRegister_Info_SUB05(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProcessRoutingRegisterProvider(pDBManager).ProcessRoutingRegister_Info_SUB05(pProcessRoutingRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProcessRoutingRegister_Info_SUB05(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)", pException);
            }
        }

        #endregion

        #region 구성 정보 조회 - ProcessRoutingRegister_Info_SUB06(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)

        /// <summary>
        /// 공정 구성 정보 조회
        /// </summary>
        public DataTable ProcessRoutingRegister_Info_SUB06(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProcessRoutingRegisterProvider(pDBManager).ProcessRoutingRegister_Info_SUB06(pProcessRoutingRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProcessRoutingRegister_Info_SUB06(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)", pException);
            }
        }

        #endregion

        #region 공정 라우팅 정보 조회하기 - ProcessRoutingRegister_Info_Process(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)

        /// <summary>
        /// 공정 라우팅 정보 조회
        /// </summary>
        public DataTable ProcessRoutingRegister_Info_Process(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProcessRoutingRegisterProvider(pDBManager).ProcessRoutingRegister_Info_Process(pProcessRoutingRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProcessRoutingRegister_Info_Process(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)", pException);
            }
        }

        #endregion


        #region 공정 라우팅 마스터 정보 조회 - ProcessRoutingRegister_Routing_Mst(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)

        /// <summary>
        /// 트리리스트 라우팅 입력용 정보 조회
        /// </summary>
        public DataTable ProcessRoutingRegister_Routing_Mst(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProcessRoutingRegisterProvider(pDBManager).ProcessRoutingRegister_Routing_Mst(pProcessRoutingRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProcessRoutingRegister_Routing_Mst(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)", pException);
            }
        }

        #endregion

        #region 트리리스트 라우팅 입력용 정보 조회 - ProcessRoutingRegister_Routing_Tree(ProcessRoutingRegisterEntity pProcessRoutingRegisterRegisterEntity)

        /// <summary>
        /// 트리리스트 라우팅 입력용 정보 조회
        /// </summary>
        public DataTable ProcessRoutingRegister_Routing_Tree(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProcessRoutingRegisterProvider(pDBManager).ProcessRoutingRegister_Routing_Tree(pProcessRoutingRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProcessRoutingRegister_Routing_Tree(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)", pException);
            }
        }

        #endregion




        #region 공정 라우팅 구성 마스터 정보 조회하기 - ProcessRoutingRegister_Info_Routing_MST(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)

        /// <summary>
        /// 공정 구성 정보 조회
        /// </summary>
        public DataTable ProcessRoutingRegister_Info_Routing_MST(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProcessRoutingRegisterProvider(pDBManager).ProcessRoutingRegister_Info_Routing_MST(pProcessRoutingRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProcessRoutingRegister_Info_Routing_MST(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)", pException);
            }
        }

        #endregion

        #region 트리리스트 공정 순서 입력용 정보 조회 - ProcessRoutingRegister_Info_Routing_DETAIL(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)

        /// <summary>
        /// 트리리스트 BOM 신규 입력용 정보 조회
        /// </summary>
        public DataTable ProcessRoutingRegister_Info_Routing_DETAIL(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProcessRoutingRegisterProvider(pDBManager).ProcessRoutingRegister_Info_Routing_DETAIL(pProcessRoutingRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProcessRoutingRegister_Info_Routing_DETAIL(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - ProcessRoutingRegister_Info_Sub(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ProcessRoutingRegister_Info_Sub(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProcessRoutingRegisterProvider(pDBManager).ProcessRoutingRegister_Info_Sub(pProcessRoutingRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProcessRoutingRegister_Info_Sub(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)", pException);
            }
        }

        #endregion

        #region 정보 저장 - ProcessRoutingRegister_Info_Save(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool ProcessRoutingRegister_Info_Save(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity, DataTable dt)
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
                    // bool isReturn = new ProductBOMRegisterProvider(pDBManager).ProductBOMRegister_Info_Save(pProductBOMRegisterEntity, dtTemp);
                    bool isReturn = new ProcessRoutingRegisterProvider(pDBManager).ProcessRoutingRegister_Info_Save(pProcessRoutingRegisterEntity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProcessRoutingRegister_Info_Save(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 정보 저장 - ProcessRoutingRegister_Info_Enable(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)
        public bool ProcessRoutingRegister_Info_Enable(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ProcessRoutingRegisterProvider(pDBManager).ProcessRoutingRegister_Info_Enable(pProcessRoutingRegisterEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProcessRoutingRegister_Info_Enable(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity)", pException);
            }
        }
        #endregion

        #region 구성 정보 저장 - ProcessRoutingRegister_Configuration_Save(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool ProcessRoutingRegister_Configuration_Save(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity, DataTable dt)
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
                    // bool isReturn = new ProductBOMRegisterProvider(pDBManager).ProductBOMRegister_Info_Save(pProductBOMRegisterEntity, dtTemp);
                    bool isReturn = new ProcessRoutingRegisterProvider(pDBManager).ProcessRoutingRegister_Configuration_Save(pProcessRoutingRegisterEntity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProcessRoutingRegister_Configuration_Save(ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity, DataTable dt)", pException);
            }
        }

        #endregion



        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ProcessRoutingRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ProcessRoutingRegisterEntity pProcessRoutingRegisterEntity = new ProcessRoutingRegisterProvider(null).GetEntity(pDataRow);
                return pProcessRoutingRegisterEntity;
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
    public class ProcessConfigurationRegister_T01Business
    {
        #region 마스터 라우팅 정보 조회 - ProcessConfigurationRegister_T01_Info_Main(ProcessConfigurationRegister_T01Entity pProcessConfigurationRegister_T01Entity)

        /// <summary>
        /// 공정 구성 정보 조회
        /// </summary>
        public DataTable ProcessConfigurationRegister_T01_Info_Main(ProcessConfigurationRegister_T01Entity pProcessConfigurationRegister_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProcessConfigurationRegister_T01Provider(pDBManager).ProcessConfigurationRegister_T01_Info_Main(pProcessConfigurationRegister_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProcessConfigurationRegister_T01_Info_Main(ProcessConfigurationRegister_T01Entity pProcessConfigurationRegister_T01Entity)", pException);
            }
        }

        #endregion

        #region 공정 라우팅 구성 마스터 정보 조회하기 - ProcessConfigurationRegister_T01_Info_Routing_MST(ProcessConfigurationRegister_T01Entity pProcessConfigurationRegister_T01Entity)

        /// <summary>
        /// 공정 구성 정보 조회
        /// </summary>
        public DataTable ProcessConfigurationRegister_T01_Info_Routing_MST(ProcessConfigurationRegister_T01Entity pProcessConfigurationRegister_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProcessConfigurationRegister_T01Provider(pDBManager).ProcessConfigurationRegister_T01_Info_Routing_MST(pProcessConfigurationRegister_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProcessConfigurationRegister_T01_Info_Routing_MST(ProcessConfigurationRegister_T01Entity pProcessConfigurationRegister_T01Entity)", pException);
            }
        }

        #endregion

        #region 트리리스트 공정 순서 입력용 정보 조회 - ProcessConfigurationRegister_T01_Info_Routing_DETAIL(ProcessConfigurationRegister_T01Entity pProcessConfigurationRegister_T01Entity)

        /// <summary>
        /// 트리리스트 BOM 신규 입력용 정보 조회
        /// </summary>
        public DataTable ProcessConfigurationRegister_T01_Info_Routing_DETAIL(ProcessConfigurationRegister_T01Entity pProcessConfigurationRegister_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProcessConfigurationRegister_T01Provider(pDBManager).ProcessConfigurationRegister_T01_Info_Routing_DETAIL(pProcessConfigurationRegister_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProcessConfigurationRegister_T01_Info_Routing_DETAIL(ProcessConfigurationRegister_T01Entity pProcessConfigurationRegister_T01Entity)", pException);
            }
        }

        #endregion

     
        #region 정보 저장 - ProcessConfigurationRegister_T01_Info_Save(ProcessConfigurationRegister_T01Entity pProcessConfigurationRegister_T01Entity, DataTable dtDetail, DataTable dtRouting)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool ProcessConfigurationRegister_T01_Info_Save(ProcessConfigurationRegister_T01Entity pProcessConfigurationRegister_T01Entity, DataTable dtDetail, DataTable dtRoutingt, bool isEditcheck)
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
                    // bool isReturn = new ProductBOMRegisterProvider(pDBManager).ProductBOMRegister_Info_Save(pProductBOMRegisterEntity, dtTemp);
                    bool isReturn = new ProcessConfigurationRegister_T01Provider(pDBManager).ProcessConfigurationRegister_T01_Info_Save(pProcessConfigurationRegister_T01Entity, dtDetail, dtRoutingt, isEditcheck);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProcessConfigurationRegister_T01_Info_Save(ProcessConfigurationRegister_T01Entity pProcessConfigurationRegister_T01Entity, DataTable dtDetail, DataTable dtRoutingt)", pException);
            }
        }

        #endregion
        
        #region 마스터 정보 수정 - ProcessConfigurationRegister_T01_Info_MST_Save(ProcessConfigurationRegister_T01Entity pProcessConfigurationRegister_T01Entity)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool ProcessConfigurationRegister_T01_Info_MST_Save(ProcessConfigurationRegister_T01Entity pProcessConfigurationRegister_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ProcessConfigurationRegister_T01Provider(pDBManager).ProcessConfigurationRegister_T01_Info_MST_Save(pProcessConfigurationRegister_T01Entity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProcessConfigurationRegister_T01_Info_MST_Save(ProcessConfigurationRegister_T01Entity pProcessConfigurationRegister_T01Entity)", pException);
            }
        }

        #endregion

        #region 품목구성 확인
        public DataTable ProcessConfigurationRegister_T01_Info_Main_MappingCheck(ProcessConfigurationRegister_T01Entity pProcessConfigurationRegister_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProcessConfigurationRegister_T01Provider(pDBManager).ProcessConfigurationRegister_T01_Info_Main_MappingCheck(pProcessConfigurationRegister_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProcessConfigurationRegister_T01_Info_Main_MappingCheck(ProcessConfigurationRegister_T01Entity pProcessConfigurationRegister_T01Entity)", pException);
            }
        }
        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ProcessConfigurationRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity = new ProcessConfigurationRegisterProvider(null).GetEntity(pDataRow);
                return pProcessConfigurationRegisterEntity;
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

    public class ProcessConfigurationRegister_T50Business
    {
        #region 마스터 라우팅 정보 조회 - ProcessConfigurationRegister_T50_Info_Main(ProcessConfigurationRegister_T50Entity pProcessConfigurationRegister_T50Entity)

        /// <summary>
        /// 공정 구성 정보 조회
        /// </summary>
        public DataTable ProcessConfigurationRegister_T50_Info_Main(ProcessConfigurationRegister_T50Entity pProcessConfigurationRegister_T50Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProcessConfigurationRegister_T50Provider(pDBManager).ProcessConfigurationRegister_T50_Info_Main(pProcessConfigurationRegister_T50Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProcessConfigurationRegister_T50_Info_Main(ProcessConfigurationRegister_T50Entity pProcessConfigurationRegister_T50Entity)", pException);
            }
        }

        #endregion

        #region 공정 라우팅 구성 마스터 정보 조회하기 - ProcessConfigurationRegister_T50_Info_Routing_MST(ProcessConfigurationRegister_T50Entity pProcessConfigurationRegister_T50Entity)

        /// <summary>
        /// 공정 구성 정보 조회
        /// </summary>
        public DataTable ProcessConfigurationRegister_T50_Info_Routing_MST(ProcessConfigurationRegister_T50Entity pProcessConfigurationRegister_T50Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProcessConfigurationRegister_T50Provider(pDBManager).ProcessConfigurationRegister_T50_Info_Routing_MST(pProcessConfigurationRegister_T50Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProcessConfigurationRegister_T50_Info_Routing_MST(ProcessConfigurationRegister_T50Entity pProcessConfigurationRegister_T50Entity)", pException);
            }
        }

        #endregion

        #region 트리리스트 공정 순서 입력용 정보 조회 - ProcessConfigurationRegister_T50_Info_Routing_DETAIL(ProcessConfigurationRegister_T50Entity pProcessConfigurationRegister_T50Entity)

        /// <summary>
        /// 트리리스트 BOM 신규 입력용 정보 조회
        /// </summary>
        public DataTable ProcessConfigurationRegister_T50_Info_Routing_DETAIL(ProcessConfigurationRegister_T50Entity pProcessConfigurationRegister_T50Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ProcessConfigurationRegister_T50Provider(pDBManager).ProcessConfigurationRegister_T50_Info_Routing_DETAIL(pProcessConfigurationRegister_T50Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProcessConfigurationRegister_T50_Info_Routing_DETAIL(ProcessConfigurationRegister_T50Entity pProcessConfigurationRegister_T50Entity)", pException);
            }
        }

        #endregion


        #region 정보 저장 - ProcessConfigurationRegister_T50_Info_Save(ProcessConfigurationRegister_T50Entity pProcessConfigurationRegister_T50Entity, DataTable dtDetail, DataTable dtRouting)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool ProcessConfigurationRegister_T50_Info_Save(ProcessConfigurationRegister_T50Entity pProcessConfigurationRegister_T50Entity, DataTable dtSave)
        {
            try
            {


                DataTable dtTemp = null;

                //bool isChack = CoFAS_ConvertManager.DataTable_FindCount(dtSave, "CRUD IN ('C','U','D')", "");

                //if (isChack)
                //{
                //    dtTemp = CoFAS_ConvertManager.DataTable_FindValue(dtSave, "CRUD IN ('C','U','D')", ""); // 신규 and 수정 항목 데이터 테이블 화
                //}

                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ProcessConfigurationRegister_T50Provider(pDBManager).ProcessConfigurationRegister_T50_Info_Save(pProcessConfigurationRegister_T50Entity, dtSave);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProcessConfigurationRegister_T50_Info_Save(ProcessConfigurationRegister_T50Entity pProcessConfigurationRegister_T50Entity, DataTable dtDetail, DataTable dtRoutingt)", pException);
            }
        }

        #endregion
        #region 마스터 정보 수정 - ProcessConfigurationRegister_T50_Info_MST_Save(ProcessConfigurationRegister_T50Entity pProcessConfigurationRegister_T50Entity)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool ProcessConfigurationRegister_T50_Info_MST_Save(ProcessConfigurationRegister_T50Entity pProcessConfigurationRegister_T50Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ProcessConfigurationRegister_T50Provider(pDBManager).ProcessConfigurationRegister_T50_Info_MST_Save(pProcessConfigurationRegister_T50Entity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ProcessConfigurationRegister_T50_Info_MST_Save(ProcessConfigurationRegister_T50Entity pProcessConfigurationRegister_T50Entity)", pException);
            }
        }

        #endregion


        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ProcessConfigurationRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ProcessConfigurationRegisterEntity pProcessConfigurationRegisterEntity = new ProcessConfigurationRegisterProvider(null).GetEntity(pDataRow);
                return pProcessConfigurationRegisterEntity;
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

    public class DataDictionaryBusiness
    {
        #region 마스터 정보 조회 - Sample_Info(DataDictionaryEntity pDataDictionaryEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info(DataDictionaryEntity pDataDictionaryEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new DataDictionaryProvider(pDBManager).Sample_Info_Mst(pDataDictionaryEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(DataDictionaryEntity pDataDictionaryEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(DataDictionaryEntity pDataDictionaryEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(DataDictionaryEntity pDataDictionaryEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new DataDictionaryProvider(pDBManager).Sample_Info_Mst(pDataDictionaryEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(DataDictionaryEntity pDataDictionaryEntity))", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Sample_Info_Save(DataDictionaryEntity pDataDictionaryEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Sample_Info_Save(DataDictionaryEntity pDataDictionaryEntity, DataTable dt)
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
                    bool isReturn = new DataDictionaryProvider(pDBManager).Sample_Info_Save(pDataDictionaryEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Save(DataDictionaryEntity pDataDictionaryEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public DataDictionaryEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                DataDictionaryEntity pDataDictionaryEntity = new DataDictionaryProvider(null).GetEntity(pDataRow);
                return pDataDictionaryEntity;
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

    public class RuleGeneratorBusiness
    {
        #region 룰 사전 정보 조회 - Dictionary_Info(RuleGeneratorEntity pRuleGeneratorEntity)

        /// <summary>
        /// 리스트 조건 조회
        /// </summary>
        public DataTable Dictionary_Info(RuleGeneratorEntity pRuleGeneratorEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new RuleGeneratorProvider(pDBManager).Dictionary_Info_Mst(pRuleGeneratorEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(RuleGeneratorEntity pRuleGeneratorEntity)", pException);
            }
        }

        #endregion

        #region 룰 사전 정보 조회 - Dictionary_Info(RuleGeneratorEntity pRuleGeneratorEntity)

        /// <summary>
        /// 리스트 조건 조회
        /// </summary>
        public DataTable Dictionary_Info_Sub(RuleGeneratorEntity pRuleGeneratorEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new RuleGeneratorProvider(pDBManager).Dictionary_Info_Sub(pRuleGeneratorEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info(RuleGeneratorEntity pRuleGeneratorEntity)", pException);
            }
        }

        #endregion

        #region 마스터 정보 조회 - RuleGenerator_Info(RuleGeneratorEntity pRuleGeneratorEntity)

        /// <summary>
        /// 리스트 조건 조회
        /// </summary>
        public DataTable RuleGenerator_Info(RuleGeneratorEntity pRuleGeneratorEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new RuleGeneratorProvider(pDBManager).RuleGenerator_Info_Mst(pRuleGeneratorEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "RuleGenerator_Info(RuleGeneratorEntity pRuleGeneratorEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - RuleGenerator_Info_Sub(RuleGeneratorEntity pRuleGeneratorEntity)

        /// <summary>
        /// 로우 상세 조회
        /// </summary>
        public DataTable RuleGenerator_Info_Sub(RuleGeneratorEntity pRuleGeneratorEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new RuleGeneratorProvider(pDBManager).RuleGenerator_Info_SUB(pRuleGeneratorEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "RuleGenerator_Info_Sub(RuleGeneratorEntity pRuleGeneratorEntity))", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - RuleGenerator_Info_Save(RuleGeneratorEntity pRuleGeneratorEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool RuleGenerator_Info_Save(RuleGeneratorEntity pRuleGeneratorEntity, DataTable dt)
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
                    bool isReturn = new RuleGeneratorProvider(pDBManager).RuleGenerator_Info_Save(pRuleGeneratorEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "RuleGenerator_Info_Save(RuleGeneratorEntity pRuleGeneratorEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public RuleGeneratorEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                RuleGeneratorEntity pRuleGeneratorEntity = new RuleGeneratorProvider(null).GetEntity(pDataRow);
                return pRuleGeneratorEntity;
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

    public class RuleOptionSettingBusiness
    {
        #region 룰 사전 정보 조회 - RuleOptionSetting_Info(RuleOptionSettingEntity pRuleOptionSettingEntity)

        /// <summary>
        /// 리스트 조건 조회
        /// </summary>
        public DataTable RuleOptionSetting_Info(RuleOptionSettingEntity pRuleOptionSettingEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new RuleOptionSettingProvider(pDBManager).RuleOptionSetting_Info_Mst(pRuleOptionSettingEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "RuleOptionSetting_Info(RuleOptionSettingEntity pRuleOptionSettingEntity)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public RuleOptionSettingEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                RuleOptionSettingEntity pRuleOptionSettingEntity = new RuleOptionSettingProvider(null).GetEntity(pDataRow);
                return pRuleOptionSettingEntity;
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

    public class ResourceCodeMstRegisterBusiness
    {
        #region 마스터 정보 조회 - Resource_Info_Mst(ResourceCodeMstRegisterEntity pResourceCodeMstRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Resource_Info_Mst(ResourceCodeMstRegisterEntity pResourceCodeMstRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ResourceCodeMstRegisterProvider(pDBManager).Resource_Info_Mst(pResourceCodeMstRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Resource_Info_Mst(ResourceCodeMstRegisterEntity pResourceCodeMstRegisterEntity)", pException);
            }
        }

        public DataTable Resource_Info_Binding(ResourceCodeMstRegisterEntity pResourceCodeMstRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ResourceCodeMstRegisterProvider(pDBManager).Resource_Info_Binding(pResourceCodeMstRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Resource_Info_Binding(ResourceCodeMstRegisterEntity pResourceCodeMstRegisterEntity)", pException);
            }
        }

        public DataTable Resource_Info_Detail(ResourceCodeMstRegisterEntity pResourceCodeMstRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ResourceCodeMstRegisterProvider(pDBManager).Resource_Info_Detail(pResourceCodeMstRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sensor_Info_Detail(ResourceCodeMstRegisterEntity pResourceCodeMstRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Vend_Info_Sub(VendorInformationEntity pVendorInformationEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Vend_Info_Sub(VendorInformationEntity pVendorInformationEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new VendorInformationProvider(pDBManager).Vend_Info_Sub(pVendorInformationEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Vend_Info_Sub(VendorInformationEntity pVendorInformationEntity)", pException);
            }
        }

        #endregion

        #region 리소스 정보 저장 - Resource_Info_Save(ResourceCodeMstRegisterEntity pResourceCodeMstRegisterEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Resource_Info_Save(ResourceCodeMstRegisterEntity pResourceCodeMstRegisterEntity, DataTable dt)
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
                    bool isReturn = new ResourceCodeMstRegisterProvider(pDBManager).Sensor_Resource_Info_Save(pResourceCodeMstRegisterEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Resource_Info_Save(ResourceCodeMstRegisterEntity pResourceCodeMstRegisterEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ResourceCodeMstRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ResourceCodeMstRegisterEntity pResourceCodeMstRegisterEntity = new ResourceCodeMstRegisterProvider(null).GetEntity(pDataRow);
                return pResourceCodeMstRegisterEntity;
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

    public class BadCodeMstRegisterBusiness
    {
        #region 마스터 정보 조회 - BadCode_Info_Mst(BadCodeMstRegisterEntity pBadCodeMstRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable BadCode_Info_Mst(BadCodeMstRegisterEntity pBadCodeMstRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new BadCodeMstRegisterProvider(pDBManager).BadCode_Info_Mst(pBadCodeMstRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "BadCode_Info_Mst(BadCodeMstRegisterEntity pBadCodeMstRegisterEntity)", pException);
            }
        }
        #endregion

        #region 마스터 바인딩 정보 조회 - BadCode_Info_Mst_Binding(BadCodeMstRegisterEntity pBadCodeMstRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable BadCode_Info_Mst_Binding(BadCodeMstRegisterEntity pBadCodeMstRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new BadCodeMstRegisterProvider(pDBManager).BadCode_Info_Mst_Binding(pBadCodeMstRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "BadCode_Info_Mst_Binding(BadCodeMstRegisterEntity pBadCodeMstRegisterEntity)", pException);
            }
        }

        #endregion

        #region 서브 정보 조회  - BadCode_Info_Detail(BadCodeMstRegisterEntity pBadCodeMstRegisterEntity)
        public DataTable BadCode_Info_Detail(BadCodeMstRegisterEntity pBadCodeMstRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new BadCodeMstRegisterProvider(pDBManager).BadCode_Info_Detail(pBadCodeMstRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "BadCode_Info_Detail(BadCodeMstRegisterEntity pBadCodeMstRegisterEntity)", pException);
            }
        }
        #endregion

        #region 그리드 저장 - BadCode_Info_Save(BadCodeMstRegisterEntity pBadCodeMstRegisterEntity, DataSet ds)
        public bool BadCode_Info_Save(BadCodeMstRegisterEntity pBadCodeMstRegisterEntity, DataTable dt)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new BadCodeMstRegisterProvider(pDBManager).BadCode_Info_Save(pBadCodeMstRegisterEntity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "BadCode_Info_Save(BadCodeMstRegisterEntity pBadCodeMstRegisterEntity, DataTable dt)", pException);
            }
        }
        #endregion
    }

    public class InspectCodeMstRegisterBusiness
    {
        #region 마스터 정보 조회 - Inspect_Info_Mst(InspectCodeMstRegisterEntity pInspectCodeMstRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Inspect_Info_Mst(InspectCodeMstRegisterEntity pInspectCodeMstRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new InspectCodeMstRegisterProvider(pDBManager).Inspect_Info_Mst(pInspectCodeMstRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Inspect_Info_Mst(InspectCodeMstRegisterEntity pInspectCodeMstRegisterEntity)", pException);
            }
        }
        #endregion

        #region 마스터 바인딩 정보 조회 - Inspect_Info_Mst_Binding(InspectCodeMstRegisterEntity pInspectCodeMstRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Inspect_Info_Mst_Binding(InspectCodeMstRegisterEntity pInspectCodeMstRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new InspectCodeMstRegisterProvider(pDBManager).Inspect_Info_Mst_Binding(pInspectCodeMstRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Inspect_Info_Mst_Binding(InspectCodeMstRegisterEntity pInspectCodeMstRegisterEntity)", pException);
            }
        }

        #endregion

        #region 서브 정보 조회  - Inspect_Info_Detail(InspectCodeMstRegisterEntity pInspectCodeMstRegisterEntity)
        public DataTable Inspect_Info_Detail(InspectCodeMstRegisterEntity pInspectCodeMstRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new InspectCodeMstRegisterProvider(pDBManager).Inspect_Info_Detail(pInspectCodeMstRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Inspect_Info_Detail(InspectCodeMstRegisterEntity pInspectCodeMstRegisterEntity)", pException);
            }
        }
        #endregion

        #region 그리드 저장 - Inspect_Info_Save(InspectCodeMstRegisterEntity pInspectCodeMstRegisterEntity, DataSet ds)
        public bool Inspect_Info_Save(InspectCodeMstRegisterEntity pInspectCodeMstRegisterEntity, DataTable dt)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new InspectCodeMstRegisterProvider(pDBManager).Inspect_Info_Save(pInspectCodeMstRegisterEntity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Inspect_Info_Save(InspectCodeMstRegisterEntity pInspectCodeMstRegisterEntity, DataTable dt)", pException);
            }
        }
        #endregion
    }

    public class EquipmentStopCodeMstRegisterBusiness
    {
        #region 마스터 정보 조회 - Equipment_Stop_Info_Mst(EquipmentStopCodeMstRegisterBusiness pEquipmentStopCodeMstRegisterBusiness)
        public DataTable Equipment_Stop_Info_Mst(EquipmentStopCodeMstRegisterEntity pEquipmentStopCodeMstRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new EquipmentStopCodeMstRegisterProvider(pDBManager).Equip_Stop_Info_Mst(pEquipmentStopCodeMstRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Equip_Stop_Info_Mst(EquipmentStopCodeMstRegisterEntity pEquipmentStopCodeMstRegisterEntity)", pException);
            }
        }

        #endregion

        #region 마스터 바인딩 정보 조회 - Equipment_Stop_Info_Mst_Binding(EquipmentStopCodeMstRegisterEntity pEquipmentStopCodeMstRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Equipment_Stop_Info_Mst_Binding(EquipmentStopCodeMstRegisterEntity pEquipmentStopCodeMstRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new EquipmentStopCodeMstRegisterProvider(pDBManager).Equip_Stop_Info_Mst_binding(pEquipmentStopCodeMstRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "BadCode_Info_Mst_Binding(BadCodeMstRegisterEntity pBadCodeMstRegisterEntity)", pException);
            }
        }

        #endregion

        #region 서브 정보 조회 - Equipment_Stop_Info_Detail(EquipmentStopCodeMstRegisterEntity pEquipmentStopCodeMstRegisterEntity)
        public DataTable Equipment_Stop_Info_Detail(EquipmentStopCodeMstRegisterEntity pEquipmentStopCodeMstRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new EquipmentStopCodeMstRegisterProvider(pDBManager).Equip_Stop_Info_Detail(pEquipmentStopCodeMstRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Equip_Stop_Info_Mst(EquipmentStopCodeMstRegisterEntity pEquipmentStopCodeMstRegisterEntity)", pException);
            }
        }

        #endregion

        #region 그리드 저장 - Equipment_Stop_Info_Save(EquipmentStopCodeMstRegisterEntity pEquipmentStopCodeMstRegisterEntity, DataSet ds)
        public bool Equipment_Stop_Info_Save(EquipmentStopCodeMstRegisterEntity pEquipmentStopCodeMstRegisterEntity, DataTable dt)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new EquipmentStopCodeMstRegisterProvider(pDBManager).Equip_Stop_Info_Save(pEquipmentStopCodeMstRegisterEntity, dt);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Equip_Stop_Info_Save(EquipmentStopCodeMstRegisterEntity pEquipmentStopCodeMstRegisterEntity, DataTable dt)", pException);
            }
        }
        #endregion
    }

    public class InspectPartMappingRegisterBusiness
    {
        #region ○ 품목조회

        public DataTable InspectPart_Info_Mst(InspectPartMappingRegisterEntity pInspectPartMappingRegister)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new InspectPartMappingRegisterProvider(pDBManager).InspectPart_Info_Mst(pInspectPartMappingRegister);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "InspectPart_Info_Mst(InspectPartMappingRegisterEntity pInspectPartMappingRegister)", pException);
            }
        }

        #endregion

        #region ○ 시험검사항목 조회

        public DataTable InspectPart_Info_Sub1(InspectPartMappingRegisterEntity pInspectPartMappingRegister)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new InspectPartMappingRegisterProvider(pDBManager).InspectPart_Info_Sub1(pInspectPartMappingRegister);
                    return pDataTable;
                }
            }
            catch(ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "InspectPart_Info_Sub1(InspectPartMappingRegisterEntity pInspectPartMappingRegister)", pException);
            }
        }

        #endregion

        #region ○ 품목별시험검사항목 조회

        public DataTable InspectPart_Info_Sub2(InspectPartMappingRegisterEntity pInspectPartMappingRegister)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new InspectPartMappingRegisterProvider(pDBManager).InspectPart_Info_Sub2(pInspectPartMappingRegister);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "InspectPart_Info_Sub2(InspectPartMappingRegisterEntity pInspectPartMappingRegister)", pException);
            }
        }

        #endregion

        #region ○ 품목별시험검사항목 저장

        public bool InspectPart_Info_Save(InspectPartMappingRegisterEntity pInspectPartMappingRegisterEntity, DataTable pDataTable)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new InspectPartMappingRegisterProvider(pDBManager).InspectPart_Info_Save(pInspectPartMappingRegisterEntity, pDataTable);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "InspectPart_Info_Save(InspectPartMappingRegisterEntity pInspectPartMappingRegisterEntity, DataTable pDataTable)", pException);
            }
        }

        #endregion
    }
    public class PartInformationMappingRegisterBusiness
    {
        #region ○ 품목조회

        public DataTable InspectPart_Info_Mst(PartInformationMappingRegisterEntity pPartInformationMappingRegister)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new PartInformationMappingRegisterProvider(pDBManager).InspectPart_Info_Mst(pPartInformationMappingRegister);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "InspectPart_Info_Mst(PartInformationMappingRegisterEntity pPartInformationMappingRegister)", pException);
            }
        }

        #endregion

        #region ○ 시험검사항목 조회

        public DataTable InspectPart_Info_Sub1(PartInformationMappingRegisterEntity pPartInformationMappingRegister)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new PartInformationMappingRegisterProvider(pDBManager).InspectPart_Info_Sub1(pPartInformationMappingRegister);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "InspectPart_Info_Sub1(PartInformationMappingRegisterEntity pPartInformationMappingRegister)", pException);
            }
        }

        #endregion

        #region ○ 품목별시험검사항목 조회

        public DataTable InspectPart_Info_Sub2(PartInformationMappingRegisterEntity pPartInformationMappingRegister)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new PartInformationMappingRegisterProvider(pDBManager).InspectPart_Info_Sub2(pPartInformationMappingRegister);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "InspectPart_Info_Sub2(PartInformationMappingRegisterEntity pPartInformationMappingRegister)", pException);
            }
        }

        #endregion

        #region ○ 품목별시험검사항목 저장

        public bool InspectPart_Info_Save(PartInformationMappingRegisterEntity pPartInformationMappingRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new PartInformationMappingRegisterProvider(pDBManager).InspectPart_Info_Save(pPartInformationMappingRegisterEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "InspectPart_Info_Save(PartInformationMappingRegisterEntity pPartInformationMappingRegisterEntity, DataTable pDataTable)", pException);
            }
        }

        #endregion
    }

    public class ucPartProcessMapping_PopUpBusiness
    {
        #region ○ 품목조회

        public DataTable PartProcessMapping_Info_MST(ucPartProcessMapping_PopUpEntity pucPartProcessMapping_PopUpEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucPartProcessMapping_PopUpProvider(pDBManager).PartProcessMapping_Info_MST(pucPartProcessMapping_PopUpEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "PartProcessMapping_Info_MST(ucPartProcessMapping_PopUpEntity pucPartProcessMapping_PopUpEntity)", pException);
            }
        }

        #endregion

        #region ○ 품목별 라우팅 항목 저장

        public bool PartProcessMapping_Info_Save(ucPartProcessMapping_PopUpEntity pucPartProcessMapping_PopUpEntity, DataTable pDataTable)
        {
            try
            {

                DataTable dtTemp = null;
                
                //bool isChack = CoFAS_ConvertManager.DataTable_FindCount(pDataTable, "PART_CHECK = 'Y'", "");
                bool isChack = CoFAS_ConvertManager.DataTable_FindCount(pDataTable, "CRUD IN ('C','U','D')", "");

                if (isChack)
                {
                    //dtTemp = CoFAS_ConvertManager.DataTable_FindValue(pDataTable, "PART_CHECK = 'Y'", ""); // 신규 and 수정 항목 데이터 테이블 화
                    dtTemp = CoFAS_ConvertManager.DataTable_FindValue(pDataTable, "CRUD IN ('C','U','D')", ""); // 신규 and 수정 항목 데이터 테이블 화
                }

                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ucPartProcessMapping_PopUpProvider(pDBManager).PartProcessMapping_Info_Save(pucPartProcessMapping_PopUpEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "PartProcessMapping_Info_Save(ucPartProcessMapping_PopUpEntity pucPartProcessMapping_PopUpEntity, DataTable pDataTable)", pException);
            }
        }

        #endregion
    }

    public class ucPartProcessMapping_PopUp_T01Business
    {
        #region ○ 품목조회

        public DataTable PartProcessMapping_Info_MST(ucPartProcessMapping_PopUp_T01Entity pucPartProcessMapping_PopUp_T01Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucPartProcessMapping_PopUp_T01Provider(pDBManager).PartProcessMapping_Info_MST(pucPartProcessMapping_PopUp_T01Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "PartProcessMapping_Info_MST(ucPartProcessMapping_PopUp_T01Entity pucPartProcessMapping_PopUp_T01Entity)", pException);
            }
        }

        #endregion

        #region ○ 품목별 라우팅 항목 저장

        public bool PartProcessMapping_Info_Save(ucPartProcessMapping_PopUp_T01Entity pucPartProcessMapping_PopUp_T01Entity, DataTable pDataTable)
        {
            try
            {

                DataTable dtTemp = null;

                //bool isChack = CoFAS_ConvertManager.DataTable_FindCount(pDataTable, "PART_CHECK = 'Y'", "");
                bool isChack = CoFAS_ConvertManager.DataTable_FindCount(pDataTable, "CRUD IN ('C','U','D')", "");

                if (isChack)
                {
                    //dtTemp = CoFAS_ConvertManager.DataTable_FindValue(pDataTable, "PART_CHECK = 'Y'", ""); // 신규 and 수정 항목 데이터 테이블 화
                    dtTemp = CoFAS_ConvertManager.DataTable_FindValue(pDataTable, "CRUD IN ('C','U','D')", ""); // 신규 and 수정 항목 데이터 테이블 화
                }

                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ucPartProcessMapping_PopUp_T01Provider(pDBManager).PartProcessMapping_Info_Save(pucPartProcessMapping_PopUp_T01Entity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "PartProcessMapping_Info_Save(ucPartProcessMapping_PopUp_T01Entity pucPartProcessMapping_PopUp_T01Entity, DataTable pDataTable)", pException);
            }
        }

        #endregion
    }


    public class LabelCodeRegisterBusiness
    {

        #region 마스터 정보 조회 - LabelCodeRegister_Info(LabelCodeRegisterEntity pLabelCodeRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable LabelCodeRegister_Info_Mst(LabelCodeRegisterEntity pLabelCodeRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new LabelCodeRegisterProvider(pDBManager).LabelCodeRegister_Info_Mst(pLabelCodeRegisterEntity);
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

        #region 그리드 정보 저장 - LabelCodeRegister_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool LabelCodeRegister_Info_Save(LabelCodeRegisterEntity pLabelCodeRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new LabelCodeRegisterProvider(pDBManager).LabelCodeRegister_Info_Save(pLabelCodeRegisterEntity);
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
        public LabelCodeRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                LabelCodeRegisterEntity pLabelCodeRegisterEntity = new LabelCodeRegisterProvider(null).GetEntity(pDataRow);
                return pLabelCodeRegisterEntity;
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
    
    public class BarcodePrintRegisterBusiness
    {

        #region 마스터 정보 조회 - BarcodePrintRegister_Info(BarcodePrintRegisterEntity pBarcodePrintRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable BarcodePrintRegister_Info_Mst(BarcodePrintRegisterEntity pBarcodePrintRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new BarcodePrintRegisterProvider(pDBManager).BarcodePrintRegister_Info_Mst(pBarcodePrintRegisterEntity);
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

        #region 바코드 정보 조회 - BarcodePrintRegister_Info(BarcodePrintRegisterEntity pBarcodePrintRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable BarcodePrintRegister_Info(BarcodePrintRegisterEntity pBarcodePrintRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new BarcodePrintRegisterProvider(pDBManager).BarcodePrintRegister_Info(pBarcodePrintRegisterEntity);
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

        #region 터미널 정보 조회 - BarcodePrintRegister_Info_sub(BarcodePrintRegisterEntity pBarcodePrintRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable BarcodePrintRegister_Info_sub(BarcodePrintRegisterEntity pBarcodePrintRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new BarcodePrintRegisterProvider(pDBManager).BarcodePrintRegister_Info_sub(pBarcodePrintRegisterEntity);
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

        #region 업체번호 조회 - BarcodePrintRegister_Info_sub(BarcodePrintRegisterEntity pBarcodePrintRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable BarcodePrintRegister_Vend_Info(string partCode)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new BarcodePrintRegisterProvider(pDBManager).BarcodePrintRegister_Vend_Info(partCode);
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

        #region 그리드 정보 저장 - BarcodePrintRegister_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool BarcodePrintRegister_Info_Save(BarcodePrintRegisterEntity pBarcodePrintRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new BarcodePrintRegisterProvider(pDBManager).BarcodePrintRegister_Info_Save(pBarcodePrintRegisterEntity);
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
        public BarcodePrintRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                BarcodePrintRegisterEntity pBarcodePrintRegisterEntity = new BarcodePrintRegisterProvider(null).GetEntity(pDataRow);
                return pBarcodePrintRegisterEntity;
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

    public class ucTerminalDetailInfoPopupBusiness
    {
        #region ○ 터미널 조회

        public DataTable ucTerminalDetailInfoPopup_Info_MST(ucTerminalDetailInfoPopup_Entity pucTerminalDetailInfoPopup_Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucTerminalDetailInfoPopupProvider(pDBManager).ucTerminalDetailInfoPopup_Info_MST(pucTerminalDetailInfoPopup_Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "PartProcessMapping_Info_MST(ucTerminalDetailInfoPopup_Entity pucTerminalDetailInfoPopup_Entity)", pException);
            }
        }

        #endregion

        #region 터미널 상세 바인딩 정보 조회 - ucTerminalDetailInfoPopup_Info_Mst_Binding(ucTerminalDetailInfoPopup_Entity pTerminalInfoMstRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ucTerminalDetailInfoPopup_Info_Mst_Binding(ucTerminalDetailInfoPopup_Entity pucTerminalDetailInfoPopup_Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucTerminalDetailInfoPopupProvider(pDBManager).ucTerminalDetailInfoPopup_Info_Mst_Binding(pucTerminalDetailInfoPopup_Entity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucTerminalDetailInfoPopup_Info_Mst_Binding(ucTerminalDetailInfoPopup_Entity pucTerminalDetailInfoPopup_Entity)", pException);
            }
        }

        #endregion

        #region ○ 품목별 라우팅 항목 저장

        public bool ucTerminalDetailInfoPopup_Info_Save(ucTerminalDetailInfoPopup_Entity pucTerminalDetailInfoPopup_Entity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new ucTerminalDetailInfoPopupProvider(pDBManager).ucTerminalDetailInfoPopup_Info_Save(pucTerminalDetailInfoPopup_Entity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "PartProcessMapping_Info_Save(ucTerminalDetailInfoPopup_Entity pucTerminalDetailInfoPopup_Entity, DataTable pDataTable)", pException);
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

    public class NoticeRegisterBusiness
    {

        #region 마스터 정보 조회 - NoticeRegister_Info(NoticeRegisterEntity pNoticeRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable NoticeRegister_Info_Mst(NoticeRegisterEntity pNoticeRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new NoticeRegisterProvider(pDBManager).NoticeRegister_Info_Mst(pNoticeRegisterEntity);
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

        #region 그리드 정보 저장 - NoticeRegister_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool NoticeRegister_Info_Save(NoticeRegisterEntity pNoticeRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new NoticeRegisterProvider(pDBManager).NoticeRegister_Info_Save(pNoticeRegisterEntity);
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
        public NoticeRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                NoticeRegisterEntity pNoticeRegisterEntity = new NoticeRegisterProvider(null).GetEntity(pDataRow);
                return pNoticeRegisterEntity;
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

    public class CommentInfoRegisterBusiness
    {

        #region 마스터 정보 조회 - CommentInfoRegister_Info(CommentInfoRegisterEntity pCommentInfoRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable CommentInfoRegister_Info_Mst(CommentInfoRegisterEntity pCommentInfoRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new CommentInfoRegisterProvider(pDBManager).CommentInfoRegister_Info_Mst(pCommentInfoRegisterEntity);
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

        #region 그리드 정보 저장 - CommentInfoRegister_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool CommentInfoRegister_Info_Save(CommentInfoRegisterEntity pCommentInfoRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new CommentInfoRegisterProvider(pDBManager).CommentInfoRegister_Info_Save(pCommentInfoRegisterEntity);
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
        public CommentInfoRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                CommentInfoRegisterEntity pCommentInfoRegisterEntity = new CommentInfoRegisterProvider(null).GetEntity(pDataRow);
                return pCommentInfoRegisterEntity;
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

    public class POP_NoticeRegisterBusiness
    {

        #region 마스터 정보 조회 - NoticeRegister_Info(NoticeRegisterEntity pNoticeRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable POP_NoticeRegister_Info_Mst(POP_NoticeRegisterEntity pPOP_NoticeRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new POP_NoticeRegisterProvider(pDBManager).POP_NoticeRegister_Info_Mst(pPOP_NoticeRegisterEntity);
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

        #region 그리드 정보 저장 - NoticeRegister_Info_Save(MaterialOrderStatusEntity pMaterialOrderStatusEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool POP_NoticeRegister_Info_Save(POP_NoticeRegisterEntity pPOP_NoticeRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new POP_NoticeRegisterProvider(pDBManager).POP_NoticeRegister_Info_Save(pPOP_NoticeRegisterEntity);
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
        public POP_NoticeRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                POP_NoticeRegisterEntity pPOP_NoticeRegisterEntity = new POP_NoticeRegisterProvider(null).GetEntity(pDataRow);
                return pPOP_NoticeRegisterEntity;
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

    public class ucProcessDocumentListPopupBusiness
    {
        #region 메인 정보 조회 - ucProcessDocumentListPopup_Info_Main(ucProcessDocumentListPopupEntity pucProcessDocumentListPopupEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ucProcessDocumentListPopup_Info_Main(ucProcessDocumentListPopupEntity pucProcessDocumentListPopupEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucProcessDocumentListPopupProvider(pDBManager).ucProcessDocumentListPopup_Info_Main(pucProcessDocumentListPopupEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucProcessDocumentListPopup_Info_Main(ucProcessDocumentListPopupEntity pucProcessDocumentListPopupEntity)", pException);
            }
        }

        #endregion

        #region 서브 정보 조회 - ucProcessDocumentListPopup_Info_Sub(ucProcessDocumentListPopupEntity pucProcessDocumentListPopupEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ucProcessDocumentListPopup_Info_Sub(ucProcessDocumentListPopupEntity pucProcessDocumentListPopupEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucProcessDocumentListPopupProvider(pDBManager).ucProcessDocumentListPopup_Info_Sub(pucProcessDocumentListPopupEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucProcessDocumentListPopup_Info_Sub(ucProcessDocumentListPopupEntity pucProcessDocumentListPopupEntity)", pException);
            }
        }

        #endregion

        #region 정보 저장 - ucProcessDocumentListPopup_Info_Save(ucProcessDocumentListPopupEntity pucProcessDocumentListPopupEntity, DataTable dt)

        /// <summary>
        /// 정보 저장
        /// </summary>
        public bool ucProcessDocumentListPopup_Info_Save(ucProcessDocumentListPopupEntity pucProcessDocumentListPopupEntity, DataTable dt)
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
                    bool isReturn = new ucProcessDocumentListPopupProvider(pDBManager).ucProcessDocumentListPopup_Info_Save(pucProcessDocumentListPopupEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucProcessDocumentListPopup_Info_Save(ucProcessDocumentListPopupEntity pucProcessDocumentListPopupEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ucProcessDocumentListPopupEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ucProcessDocumentListPopupEntity pucProcessDocumentListPopupEntity = new ucProcessDocumentListPopupProvider(null).GetEntity(pDataRow);
                return pucProcessDocumentListPopupEntity;
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

    public class ucProRoutingDocumentListPopupBusiness
    {
        #region 메인 정보 조회 - ucProRoutingDocumentListPopup_Info_Main(ucProRoutingDocumentListPopupEntity pucProRoutingDocumentListPopupEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ucProRoutingDocumentListPopup_Info_Main(ucProRoutingDocumentListPopupEntity pucProRoutingDocumentListPopupEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucProRoutingDocumentListPopupProvider(pDBManager).ucProRoutingDocumentListPopup_Info_Main(pucProRoutingDocumentListPopupEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucProRoutingDocumentListPopup_Info_Main(ucProRoutingDocumentListPopupEntity pucProRoutingDocumentListPopupEntity)", pException);
            }
        }

        #endregion

        #region 서브 정보 조회 - ucProRoutingDocumentListPopup_Info_Sub(ucProRoutingDocumentListPopupEntity pucProRoutingDocumentListPopupEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ucProRoutingDocumentListPopup_Info_Sub(ucProRoutingDocumentListPopupEntity pucProRoutingDocumentListPopupEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucProRoutingDocumentListPopupProvider(pDBManager).ucProRoutingDocumentListPopup_Info_Sub(pucProRoutingDocumentListPopupEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucProRoutingDocumentListPopup_Info_Sub(ucProRoutingDocumentListPopupEntity pucProRoutingDocumentListPopupEntity)", pException);
            }
        }

        #endregion

        #region 정보 저장 - ucProRoutingDocumentListPopup_Info_Save(ucProRoutingDocumentListPopupEntity pucProRoutingDocumentListPopupEntity, DataTable dt)

        /// <summary>
        /// 정보 저장
        /// </summary>
        public bool ucProRoutingDocumentListPopup_Info_Save(ucProRoutingDocumentListPopupEntity pucProRoutingDocumentListPopupEntity, DataTable dt)
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
                    bool isReturn = new ucProRoutingDocumentListPopupProvider(pDBManager).ucProRoutingDocumentListPopup_Info_Save(pucProRoutingDocumentListPopupEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucProRoutingDocumentListPopup_Info_Save(ucProRoutingDocumentListPopupEntity pucProRoutingDocumentListPopupEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ucProcessDocumentListPopupEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ucProcessDocumentListPopupEntity pucProcessDocumentListPopupEntity = new ucProcessDocumentListPopupProvider(null).GetEntity(pDataRow);
                return pucProcessDocumentListPopupEntity;
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

    public class ucToolDocumentListPopupBusiness
    {
        #region 메인 정보 조회 - ucToolDocumentListPopup_Info_Main(ucToolDocumentListPopupEntity pucToolDocumentListPopupEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ucToolDocumentListPopup_Info_Main(ucToolDocumentListPopupEntity pucToolDocumentListPopupEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucToolDocumentListPopupProvider(pDBManager).ucToolDocumentListPopup_Info_Main(pucToolDocumentListPopupEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucToolDocumentListPopup_Info_Main(ucToolDocumentListPopupEntity pucToolDocumentListPopupEntity)", pException);
            }
        }

        #endregion

        #region 서브 정보 조회 - ucToolDocumentListPopup_Info_Sub(ucToolDocumentListPopupEntity pucToolDocumentListPopupEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ucToolDocumentListPopup_Info_Sub(ucToolDocumentListPopupEntity pucToolDocumentListPopupEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucToolDocumentListPopupProvider(pDBManager).ucToolDocumentListPopup_Info_Sub(pucToolDocumentListPopupEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucToolDocumentListPopup_Info_Sub(ucToolDocumentListPopupEntity pucToolDocumentListPopupEntity)", pException);
            }
        }

        #endregion

        #region 정보 저장 - ucToolDocumentListPopup_Info_Save(ucToolDocumentListPopupEntity pucToolDocumentListPopupEntity, DataTable dt)

        /// <summary>
        /// 정보 저장
        /// </summary>
        public bool ucToolDocumentListPopup_Info_Save(ucToolDocumentListPopupEntity pucToolDocumentListPopupEntity, DataTable dt)
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
                    bool isReturn = new ucToolDocumentListPopupProvider(pDBManager).ucToolDocumentListPopup_Info_Save(pucToolDocumentListPopupEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucToolDocumentListPopup_Info_Save(ucToolDocumentListPopupEntity pucToolDocumentListPopupEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ucToolDocumentListPopupEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ucToolDocumentListPopupEntity pucToolDocumentListPopupEntity = new ucToolDocumentListPopupProvider(null).GetEntity(pDataRow);
                return pucToolDocumentListPopupEntity;
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

    public class ucVendDocumentListPopupBusiness
    {
        #region 메인 정보 조회 - ucVendDocumentListPopup_Info_Main(ucVendDocumentListPopupEntity pucVemdDocumentListPopupEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ucVendDocumentListPopup_Info_Main(ucVendDocumentListPopupEntity pucVemdDocumentListPopupEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucVendDocumentListPopupProvider(pDBManager).ucVendDocumentListPopup_Info_Main(pucVemdDocumentListPopupEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucVendDocumentListPopup_Info_Main(ucVendDocumentListPopupEntity pucVemdDocumentListPopupEntity)", pException);
            }
        }

        #endregion

        #region 서브 정보 조회 - ucVendDocumentListPopup_Info_Sub(ucVendDocumentListPopupEntity pucVendDocumentListPopupEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable ucVendDocumentListPopup_Info_Sub(ucVendDocumentListPopupEntity pucVendDocumentListPopupEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new ucVendDocumentListPopupProvider(pDBManager).ucVendDocumentListPopup_Info_Sub(pucVendDocumentListPopupEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucVendDocumentListPopup_Info_Sub(ucVendDocumentListPopupEntity pucVendDocumentListPopupEntity)", pException);
            }
        }

        #endregion

        #region 정보 저장 - ucVendDocumentListPopup_Info_Save(ucVendDocumentListPopupEntity pucVendDocumentListPopupEntity, DataTable dt)

        /// <summary>
        /// 정보 저장
        /// </summary>
        public bool ucVendDocumentListPopup_Info_Save(ucVendDocumentListPopupEntity pucVendDocumentListPopupEntity, DataTable dt)
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
                    bool isReturn = new ucVendDocumentListPopupProvider(pDBManager).ucVendDocumentListPopup_Info_Save(pucVendDocumentListPopupEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "ucVendDocumentListPopup_Info_Save(ucVendDocumentListPopupEntity pucVendDocumentListPopupEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public ucVendDocumentListPopupEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                ucVendDocumentListPopupEntity pucVendDocumentListPopupEntity = new ucVendDocumentListPopupProvider(null).GetEntity(pDataRow);
                return pucVendDocumentListPopupEntity;
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

    public class TabletBasedSensorInfoRegisterBusiness
    {
        
        #region 마스터 정보 조회 - TabletBasedSensorInfoRegister_Info(TabletBasedSensorInfoRegisterEntity pTabletBasedSensorInfoRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable TabletBasedSensorInfoRegister_Info(TabletBasedSensorInfoRegisterEntity pTabletBasedSensorInfoRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new TabletBasedSensorInfoRegisterProvider(pDBManager).TabletBasedSensorInfoRegister_Info_Mst(pTabletBasedSensorInfoRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "TabletBasedSensorInfoRegister_Info(TabletBasedSensorInfoRegisterEntity pTabletBasedSensorInfoRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Sample_Info_Sub(TabletBasedSensorInfoRegisterEntity pTabletBasedSensorInfoRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Sample_Info_Sub(TabletBasedSensorInfoRegisterEntity pTabletBasedSensorInfoRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new TabletBasedSensorInfoRegisterProvider(pDBManager).TabletBasedSensorInfoRegister_Info_Mst(pTabletBasedSensorInfoRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Sample_Info_Sub(TabletBasedSensorInfoRegisterEntity pTabletBasedSensorInfoRegisterEntity)", pException);
            }
        }

        #endregion
        
        #region 단일 데이터 정보 저장 - Sample_Info_Save(TabletBasedSensorInfoRegisterEntity pTabletBasedSensorInfoRegisterEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool TabletBasedSensorInfoRegister_Info_One_Save(TabletBasedSensorInfoRegisterEntity pTabletBasedSensorInfoRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new TabletBasedSensorInfoRegisterProvider(pDBManager).TabletBasedSensorInfoRegister_Info_One_Save(pTabletBasedSensorInfoRegisterEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "TabletBasedSensorInfoRegister_Info_One_Save(TabletBasedSensorInfoRegisterEntity pTabletBasedSensorInfoRegisterEntity, DataTable dt)", pException);
            }
        }

        #endregion
        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public TabletBasedSensorInfoRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                TabletBasedSensorInfoRegisterEntity pTabletBasedSensorInfoRegisterEntity = new TabletBasedSensorInfoRegisterProvider(null).GetEntity(pDataRow);
                return pTabletBasedSensorInfoRegisterEntity;
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

    public class frmCategorySensorSettingsBusiness
    {
        #region 마스터 정보 조회 - frmCategorySensorSettings_Info(frmCategorySensorSettingsEntity pfrmCategorySensorSettingsEntity)

        /// <summary>
        /// 프로세스 정보 조회
        /// </summary>
        public DataTable frmCategorySensorSettings_Info(frmCategorySensorSettingsEntity pfrmCategorySensorSettingsEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new frmCategorySensorSettingsProvider(pDBManager).frmCategorySensorSettings_Info(pfrmCategorySensorSettingsEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "frmCategorySensorSettings_Info(frmCategorySensorSettingsEntity pfrmCategorySensorSettingsEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - frmCategorySensorSettings_Info_Save(frmCategorySensorSettingsEntity pfrmCategorySensorSettingsEntity, DataTable dt)

        /// <summary>
        /// 정보 저장
        /// </summary>
        public bool frmCategorySensorSettings_Info_Save(frmCategorySensorSettingsEntity pfrmCategorySensorSettingsEntity, DataTable dt)
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
                    bool isReturn = new frmCategorySensorSettingsProvider(pDBManager).frmCategorySensorSettings_Info_Save(pfrmCategorySensorSettingsEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "frmCategorySensorSettings_Info_Save(frmCategorySensorSettingsEntity pfrmCategorySensorSettingsEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public frmCategorySensorSettingsEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                frmCategorySensorSettingsEntity pfrmCategorySensorSettingsEntity = new frmCategorySensorSettingsProvider(null).GetEntity(pDataRow);
                return pfrmCategorySensorSettingsEntity;
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
        public DataSet ucWorkOrderDocRegPopup_Return2(string pCRUD, string pLANGUAGE_TYPE, string pPART_CODE, string pPROCESS_CODE_MST)
        {
            try
            {

                using (DBManager pDBManager = new DBManager())
                {
                    DataSet pDataTableSet = new ucWorkOrderDocRegPopupProvider(pDBManager).ucWorkOrderDocRegPopup_Return2(pCRUD, pLANGUAGE_TYPE, pPART_CODE, pPROCESS_CODE_MST);
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
                    bool isReturn = new ucWorkOrderDocRegPopupProvider(pDBManager).WorkResultInfo_Save(ucWorkOrderDocRegPopupEntity, pSheet);
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

    public class InspectProcessMappingRegisterBusiness
    {
        #region ○ 설비정보 조회하기

        public DataTable InspectProcess_Info_Mst(InspectProcessMappingRegisterEntity pInspectProcessMappingRegister)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new InspectProcessMappingRegisterProvider(pDBManager).InspectProcess_Info_Mst(pInspectProcessMappingRegister);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "InspectProcess_Info_Mst(InspectProcessMappingRegisterEntity pInspectProcessMappingRegister)", pException);
            }
        }

        #endregion

        #region ○ 점검항목 조회하기

        public DataTable InspectProcess_Info_Sub1(InspectProcessMappingRegisterEntity pInspectProcessMappingRegister)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new InspectProcessMappingRegisterProvider(pDBManager).InspectProcess_Info_Sub1(pInspectProcessMappingRegister);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "InspectProcess_Info_Sub1(InspectProcessMappingRegisterEntity pInspectProcessMappingRegister)", pException);
            }
        }

        #endregion

        #region ○ 설비별 점검항목 조회하기

        public DataTable InspectProcess_Info_Sub2(InspectProcessMappingRegisterEntity pInspectProcessMappingRegister)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new InspectProcessMappingRegisterProvider(pDBManager).InspectProcess_Info_Sub2(pInspectProcessMappingRegister);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "InspectProcess_Info_Sub2(InspectProcessMappingRegisterEntity pInspectProcessMappingRegister)", pException);
            }
        }

        #endregion

        #region ○ 설비별 점검항목 저장하기

        public bool InspectProcess_Info_Save(InspectProcessMappingRegisterEntity pInspectProcessMappingRegisterEntity, DataTable pDataTable)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new InspectProcessMappingRegisterProvider(pDBManager).InspectProcess_Info_Save(pInspectProcessMappingRegisterEntity, pDataTable);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "InspectProcess_Info_Save(InspectProcessMappingRegisterEntity pInspectProcessMappingRegisterEntity, DataTable pDataTable)", pException);
            }
        }

        #endregion
    }

    public class frmResourceMst_PopupBusiness
    {
        #region 마스터 정보 조회 - frmResourceMst_Popup_Info(frmCategorySensorSettingsEntity pfrmCategorySensorSettingsEntity)

        /// <summary>
        /// 프로세스 정보 조회
        /// </summary>
        public DataTable frmResourceMst_Popup_Info(frmResourceMst_PopupEntity pfrmResourceMst_PopupEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new frmResourceMst_PopupProvider(pDBManager).frmResourceMst_Popup_Info(pfrmResourceMst_PopupEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "frmResourceMst_Popup_Info(frmResourceMst_PopupEntity pfrmResourceMst_PopupEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - frmResourceMst_Popup_Info_Save(frmResourceMst_PopupEntity pfrmResourceMst_PopupEntity, DataTable dt)

        /// <summary>
        /// 정보 저장
        /// </summary>
        public bool frmResourceMst_Popup_Info_Save(frmResourceMst_PopupEntity pfrmResourceMst_PopupEntity, DataTable dt)
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
                    bool isReturn = new frmResourceMst_PopupProvider(pDBManager).frmResourceMst_Popup_Info_Save(pfrmResourceMst_PopupEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "frmCategorySensorSettings_Info_Save(frmResourceMst_PopupEntity pfrmResourceMst_PopupEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public frmResourceMst_PopupEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                frmResourceMst_PopupEntity pfrmResourceMst_PopupEntity = new frmResourceMst_PopupProvider(null).GetEntity(pDataRow);
                return pfrmResourceMst_PopupEntity;
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