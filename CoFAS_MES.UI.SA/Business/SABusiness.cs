using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using CoFAS_MES.UI.SA.Data;
using CoFAS_MES.UI.SA.Entity;

using CoFAS_MES.CORE.Entity;
using CoFAS_MES.CORE.Function;

namespace CoFAS_MES.UI.SA.Business
{
    public class LanguageInfoRegisterBusiness
    {
        #region 언어 정보 조회 - Language_Info(LanguageInfoRegisterEntity pLanguageInfoRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Language_Info(LanguageInfoRegisterEntity pLanguageInfoRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new LanguageInfoRegisterProvider(pDBManager).Language_Info(pLanguageInfoRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Language_Info(LanguageInfoRegisterEntity pLanguageInfoRegisterEntity)", pException);
            }
        }

        #endregion

        #region 언어 정보 저장 - Language_Info_Save(LanguageInfoRegisterEntity pLanguageInfoRegisterEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Language_Info_Save(LanguageInfoRegisterEntity pLanguageInfoRegisterEntity, DataTable dt)
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

                if(dtTemp.Rows.Count > 0)
                {
                    using (DBManager pDBManager = new DBManager())
                    {
                        isReturn = new LanguageInfoRegisterProvider(pDBManager).Language_Info_Save(pLanguageInfoRegisterEntity, dtTemp);
                        return isReturn;
                    }
                }else
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
                throw new ExceptionManager(this, "Language_Info_Save(LanguageInfoRegisterEntity pLanguageInfoRegisterEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public LanguageInfoRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                LanguageInfoRegisterEntity pLanguageInfonRegisterEntity = new LanguageInfoRegisterProvider(null).GetEntity(pDataRow);
                return pLanguageInfonRegisterEntity;
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

    public class MessageInfoRegisterBusiness
    {
        #region 메세지 정보 조회 - Message_Info(MessageInfoRegisterEntity pMessageInfoRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Message_Info(MessageInfoRegisterEntity pMessageInfoRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MessageInfoRegisterProvider(pDBManager).Message_Info(pMessageInfoRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Message_Info(MessageInfoRegisterEntity pMessageInfoRegisterEntity)", pException);
            }
        }

        #endregion

        #region 메세지 정보 저장 - Message_Info_Save(MessageInfoRegisterEntity pMessageInfoRegisterEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Message_Info_Save(MessageInfoRegisterEntity pMessageInfoRegisterEntity, DataTable dt)
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

                //if (dtTemp.Rows.Count > 0)
                //{
                    using (DBManager pDBManager = new DBManager())
                    {
                        isReturn = new MessageInfoRegisterProvider(pDBManager).Message_Info_Save(pMessageInfoRegisterEntity, dtTemp);
                        return isReturn;
                    }
                //}
                //else
               // {
                //    return isReturn;
               // }

            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Message_Info_Save(MessageInfoRegisterEntity pMessageInfoRegisterEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public MessageInfoRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                MessageInfoRegisterEntity pMessageInfoRegisterEntity = new MessageInfoRegisterProvider(null).GetEntity(pDataRow);
                return pMessageInfoRegisterEntity;
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

    public class GridInfoRegisterBusiness
    {
        #region 마스터 정보 조회 - Grid_Info(GridInfoRegisterEntity pGridInfoRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Grid_Info_Mst(GridInfoRegisterEntity pGridInfoRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new GridInfoRegisterProvider(pDBManager).Grid_Info_Mst(pGridInfoRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Grid_Info_Mst(GridInfoRegisterEntity pGridInfoRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - Grid_Info_Sub(GridInfoRegisterEntity pGridInfoRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable Grid_Info_Sub(GridInfoRegisterEntity pGridInfoRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new GridInfoRegisterProvider(pDBManager).Grid_Info_Sub(pGridInfoRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Grid_Info_Sub(GridInfoRegisterEntity pGridInfoRegisterEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - Grid_Info_Save(GridInfoRegisterEntity pGridInfoRegisterEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool Grid_Info_Save(GridInfoRegisterEntity pGridInfoRegisterEntity, DataTable dt)
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

                if ((pGridInfoRegisterEntity.CRUD == "C" || pGridInfoRegisterEntity.CRUD == "U") || dtTemp.Rows.Count > 0)
                {

                    using (DBManager pDBManager = new DBManager())
                    {
                        isReturn = new GridInfoRegisterProvider(pDBManager).Grid_Info_Save(pGridInfoRegisterEntity, dtTemp);
                        return isReturn;
                    }
                }else
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
                throw new ExceptionManager(this, "Grid_Info_Save(GridInfoRegisterEntity pGridInfoRegisterEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public GridInfoRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                GridInfoRegisterEntity pGridInfoRegisterEntity = new GridInfoRegisterProvider(null).GetEntity(pDataRow);
                return pGridInfoRegisterEntity;
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

    public class DynamicColumnInfoRegisterBusiness
    {
        #region 프로그램 동적 상세 정보 조회 - DynamicColumn_Info(DynamicColumnInfoRegisterEntity pDynamicColumnInfoRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable DynamicColumn_Info(DynamicColumnInfoRegisterEntity pDynamicColumnInfoRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new DynamicColumnInfoRegisterProvider(pDBManager).DynamicColumn_Info(pDynamicColumnInfoRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "DynamicColumn_Info(DynamicColumnInfoRegisterEntity pDynamicColumnInfoRegisterEntity)", pException);
            }
        }

        #endregion

        #region 프로그램 동적 상세 정보 저장 - DynamicColumn_Info_Save(DynamicColumnInfoRegisterEntity pDynamicColumnInfoRegisterEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool DynamicColumn_Info_Save(DynamicColumnInfoRegisterEntity pDynamicColumnInfoRegisterEntity, DataTable dt)
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
                    bool isReturn = new DynamicColumnInfoRegisterProvider(pDBManager).DynamicColumn_Info_Save(pDynamicColumnInfoRegisterEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "DynamicColumn_Info_Save(DynamicColumnInfoRegisterEntity pDynamicColumnInfoRegisterEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public DynamicColumnInfoRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                DynamicColumnInfoRegisterEntity pDynamicColumnInfoRegisterEntity = new DynamicColumnInfoRegisterProvider(null).GetEntity(pDataRow);
                return pDynamicColumnInfoRegisterEntity;
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

    public class MenuRegisterBusiness
    {
        #region 마스터 정보 조회 - MenuRegister_Info(MenuRegisterEntity pMenuRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable MenuRegister_Info(MenuRegisterEntity pMenuRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MenuRegisterProvider(pDBManager).MenuRegister_Info_Mst(pMenuRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MenuRegister_Info(MenuRegisterEntity pMenuRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - MenuRegister_Info_Sub(MenuRegisterEntity pMenuRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable MenuRegister_Info_Sub(MenuRegisterEntity pMenuRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MenuRegisterProvider(pDBManager).MenuRegister_Info_Sub(pMenuRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MenuRegistere_Info_Sub(MenuRegisterEntity pMenuRegisterEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - MenuRegister_Info_Save(MenuRegisterEntity pMenuRegisterEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool MenuRegister_Info_Save(MenuRegisterEntity pMenuRegisterEntity, DataTable dt)
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
                    bool isReturn = new MenuRegisterProvider(pDBManager).MenuRegister_Info_Save(pMenuRegisterEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MenuRegister_Info_Save(MenuRegisterEntity pMenuRegisterEntity, DataTable dt)", pException);
            }
        }

        #endregion


        #region OPENBUTTON으로 XML파일 다운로드 - MenuRegister_Templete_Download(MenuRegisterEntity pMenuRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public object MenuRegister_Templete_Download(MenuRegisterEntity pMenuRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    object pObject = new MenuRegisterProvider(pDBManager).MenuRegister_Templete_Download(pMenuRegisterEntity);
                    return pObject;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MenuRegister_Templete_Download(MenuRegisterEntity pMenuRegisterEntity)", pException);
            }
        }

        #endregion

        #region OPENBUTTON으로 XML파일,파일명 삭제 - MenuRegister_Templete_Delete(MenuRegisterEntity pMenuRegisterEntity)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool MenuRegister_Templete_Delete(MenuRegisterEntity pMenuRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new MenuRegisterProvider(pDBManager).MenuRegister_Templete_Delete(pMenuRegisterEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MenuRegister_Templete_Delete(MenuRegisterEntity pMenuRegisterEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public MenuRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                MenuRegisterEntity pSampleRegisterEntity = new MenuRegisterProvider(null).GetEntity(pDataRow);
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

    public class MenuInfoRegisterBusiness
    {
        #region 마스터 정보 조회 - MenuInfoRegister_Info(MenuInfoRegisterEntity pMenuInfoRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable MenuInfoRegister_Info_left(MenuInfoRegisterEntity pMenuInfoRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MenuInfoRegisterProvider(pDBManager).MenuInfoRegister_Info_left(pMenuInfoRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MenuInfoRegister_Info(MenuInfoRegisterEntity pMenuInfoRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - MenuInfoRegister_Info_Mst(MenuInfoRegisterEntity pMenuInfoRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable MenuInfoRegister_Info_Mst(MenuInfoRegisterEntity pMenuInfoRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MenuInfoRegisterProvider(pDBManager).MenuInfoRegister_Info_Mst(pMenuInfoRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MenuInfoRegister_Info_Mst(MenuInfoRegisterEntity pMenuInfoRegisterEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - MenuInfoRegister_Info_Sub(MenuInfoRegisterEntity pMenuInfoRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable MenuInfoRegister_Info_Sub(MenuInfoRegisterEntity pMenuInfoRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MenuInfoRegisterProvider(pDBManager).MenuInfoRegister_Info_Sub(pMenuInfoRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MenuInfoRegister_Info_Sub(MenuInfoRegisterEntity pMenuInfoRegisterEntity)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - MenuInfoRegister_Info_Save(MenuInfoRegisterEntity pMenuInfoRegisterEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool MenuInfoRegister_Info_Save(MenuInfoRegisterEntity pMenuInfoRegisterEntity, DataTable dt)
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
                    bool isReturn = new MenuInfoRegisterProvider(pDBManager).MenuInfoRegister_Info_Save(pMenuInfoRegisterEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MenuInfoRegister_Info_Save(MenuInfoRegisterEntity pMenuInfoRegisterEntity, DataTable dt)", pException);
            }
        }

        #endregion

        #region 그리드 정보 저장 - MenuInfoRegister_Info_Delete(MenuInfoRegisterEntity pMenuInfoRegisterEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool MenuInfoRegister_Info_Delete(MenuInfoRegisterEntity pMenuInfoRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    bool isReturn = new MenuInfoRegisterProvider(pDBManager).File_Delete(pMenuInfoRegisterEntity);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MenuInfoRegister_Info_Delete(MenuInfoRegisterEntity pMenuInfoRegisterEntity)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public MenuInfoRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                MenuInfoRegisterEntity pMenuInfoRegisterEntity = new MenuInfoRegisterProvider(null).GetEntity(pDataRow);
                return pMenuInfoRegisterEntity;
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

    public class MonitoringDesignerBusiness
    {
        #region 마스터 정보 조회 - MonitoringDesigner_Info(MonitoringDesignerEntity pMonitoringDesignerEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable MonitoringDesigner_Info(MonitoringDesignerEntity pMonitoringDesignerEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MonitoringDesignerProvider(pDBManager).MonitoringDesigner_Info_Mst(pMonitoringDesignerEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MonitoringDesigner_Info(MonitoringDesignerEntity pMonitoringDesignerEntity)", pException);
            }
        }

        #endregion

        #region 상세 정보 조회 - MonitoringDesigner_Info_Sub(MonitoringDesignerEntity pMonitoringDesignerEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable MonitoringDesigner_Info_Sub(MonitoringDesignerEntity pMonitoringDesignerEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MonitoringDesignerProvider(pDBManager).MonitoringDesigner_Info_Mst(pMonitoringDesignerEntity);
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

        #region 그리드 정보 저장 - MonitoringDesigner_Info_Save(MonitoringDesignerEntity pMonitoringDesignerEntity, DataTable dt)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool MonitoringDesigner_Info_Save(MonitoringDesignerEntity pMonitoringDesignerEntity, DataTable dt)
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
                    bool isReturn = new MonitoringDesignerProvider(pDBManager).MonitoringDesigner_Info_Save(pMonitoringDesignerEntity, dtTemp);
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
        public MonitoringDesignerEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                MonitoringDesignerEntity pMonitoringDesignerEntity = new MonitoringDesignerProvider(null).GetEntity(pDataRow);
                return pMonitoringDesignerEntity;
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
        public DataTable MonitoringDesigner_Info_Filename(MonitoringDesignerEntity pMonitoringDesignerEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new MonitoringDesignerProvider(pDBManager).MonitoringDesigner_Info_Filename(pMonitoringDesignerEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "MonitoringDesigner_Info_Filename(MonitoringDesignerEntity pMonitoringDesignerEntity)", pException);
            }
        }

        #endregion

        #region XML파일 다운로드 - Templete_Download(MonitoringDesignerEntity pMonitoringDesignerEntity, string pMENU_NO, string pDSP_SORT)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public object Templete_Download(MonitoringDesignerEntity pMonitoringDesignerEntity, string pMENU_NO, string pDSP_SORT)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    object pObject = new MonitoringDesignerProvider(pDBManager).Templete_Download(pMonitoringDesignerEntity, pMENU_NO, pDSP_SORT);
                    return pObject;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "Templete_Download(MonitoringDesignerEntity pMonitoringDesignerEntity, string pMENU_NO, string pDSP_SORT)", pException);
            }
        }

        #endregion
    }

    public class SystemCodeRegisterBusiness
    {
        #region 대분류 코드 조회 - SystemCode_Info_First(SystemCodeRegisterEntity pSystemCodeRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable SystemCode_Info_First(SystemCodeRegisterEntity pSystemCodeRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new SystemCodeRegisterProvider(pDBManager).SystemCode_Info_First(pSystemCodeRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "SystemCode_Info_First(SystemCodeRegisterEntity pSystemCodeRegisterEntity)", pException);
            }
        }

        #endregion



        #region 중분류 코드 조회 - SystemCode_Info_Second(SystemCodeRegisterEntity pSystemCodeRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable SystemCode_Info_Second(SystemCodeRegisterEntity pSystemCodeRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new SystemCodeRegisterProvider(pDBManager).SystemCode_Info_Second(pSystemCodeRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "SystemCode_Info_Second(SystemCodeRegisterEntity pSystemCodeRegisterEntity)", pException);
            }
        }

        #endregion

        #region 소분류 코드 조회 - SystemCode_Info_Third(SystemCodeRegisterEntity pSystemCodeRegisterEntity)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable SystemCode_Info_Third(SystemCodeRegisterEntity pSystemCodeRegisterEntity)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new SystemCodeRegisterProvider(pDBManager).SystemCode_Info_Third(pSystemCodeRegisterEntity);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "SystemCode_Info_Third(SystemCodeRegisterEntity pSystemCodeRegisterEntity)", pException);
            }
        }

        #endregion

        #region 공통코드 저장 - SystemCode_Info_Save(SystemCodeRegisterEntity pSystemCodeRegisterEntity, DataTable dt, string code)

        /// <summary>
        /// 언어 정보 저장
        /// </summary>
        public bool SystemCode_Info_Save(SystemCodeRegisterEntity pSystemCodeRegisterEntity, DataTable dt, string code)
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
                    bool isReturn = new SystemCodeRegisterProvider(pDBManager).SystemCode_Info_Save(pSystemCodeRegisterEntity, dtTemp, code);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "SystemCode_Info_Save(SystemCodeRegisterEntity pSystemCodeRegisterEntity, DataTable dt, string code)", pException);
            }
        }

        public bool SystemCode_Info_Save(SystemCodeRegisterEntity pSystemCodeRegisterEntity, DataTable dtFirst, DataTable dtSecond, DataTable dtThird)
        {
            try
            {
                DataTable dtTemp = null;
                DataTable dtWork = null;
                bool isChack = false;

                for (int a = 0; a < 3; a++)
                {
                    switch (a)
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
                    bool isReturn = new SystemCodeRegisterProvider(pDBManager).SystemCode_Info_Save(pSystemCodeRegisterEntity, dtTemp);
                    return isReturn;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "SystemCode_Info_Save(SystemCodeRegisterEntity pSystemCodeRegisterEntity, DataTable dtFirst, DataTable dtSecond, DataTable dtThird)", pException);
            }
        }

        #endregion

        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public SystemCodeRegisterEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                SystemCodeRegisterEntity pCommonCodeRegisterEntity = new SystemCodeRegisterProvider(null).GetEntity(pDataRow);
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

    public class SystemLogInfoStatusBusiness
    {
        #region 사용자 조회 - SystemLogInfoStatus_R10(SystemLogInfoStatusEntity pSystemLogInfoStatus)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable SystemLogInfoStatus_R10(SystemLogInfoStatusEntity pSystemLogInfoStatus)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new SystemLogInfoStatusProvider(pDBManager).SystemLogInfoStatus_R10(pSystemLogInfoStatus);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "SystemLogInfoStatus_R10(SystemLogInfoStatusEntity pSystemLogInfoStatus)", pException);
            }
        }

        #endregion

        #region 메뉴권한 조회 - SystemLoginfoStatus_R20(SystemLogInfoStatusEntity pSystemLogInfoStatus)

        /// <summary>
        /// 언어 정보 조회
        /// </summary>
        public DataTable SystemLoginfoStatus_R20(SystemLogInfoStatusEntity pSystemLogInfoStatus)
        {
            try
            {
                using (DBManager pDBManager = new DBManager())
                {
                    DataTable pDataTable = new SystemLogInfoStatusProvider(pDBManager).SystemLoginfoStatus_R20(pSystemLogInfoStatus);
                    return pDataTable;
                }
            }
            catch (ExceptionManager pExceptionManager)
            {
                throw pExceptionManager;
            }
            catch (Exception pException)
            {
                throw new ExceptionManager(this, "SystemLoginfoStatus_R20(SystemLogInfoStatusEntity pSystemLogInfoStatus)", pException);
            }
        }

        #endregion
        
        #region 개체 구하기 - GetEntity(pDataRow)

        /// <summary>
        /// 개체 구하기
        /// </summary>
        /// <param name="pDataRow">데이타 로우</param>
        /// <returns>메뉴 설정 개체</returns>
        public SystemLogInfoStatusEntity GetEntity(DataRow pDataRow)
        {
            try
            {
                SystemLogInfoStatusEntity pSystemLogInfoStatusEntity = new SystemLogInfoStatusProvider(null).GetEntity(pDataRow);
                return pSystemLogInfoStatusEntity;
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
