using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoFAS_MES.AUTO.DWL.Entity
{
    public class AutoDownloadEntity
    {
        #region Property

        //사용자 설정 엔티티
        public String CORP_CODE { get; set; } // 업체코드
        public String FILE_TYPE { get; set; } // 파일타입
        public String FILENAME { get; set; } // 파일명칭
        public String FILE_PATH { get; set; } // 파일 위치

    #endregion

    #region 생성자 - AutoDownloadEntity()

    public AutoDownloadEntity()
        {
        }

        #endregion

        #region 생성자 - AutoDownloadEntity(pAutoDownloadEntity)

        public AutoDownloadEntity(AutoDownloadEntity pAutoDownloadEntity)
        {
            CORP_CODE = pAutoDownloadEntity.CORP_CODE;
            FILE_TYPE = pAutoDownloadEntity.FILE_TYPE;
            FILENAME = pAutoDownloadEntity.FILENAME;
            FILE_PATH = pAutoDownloadEntity.FILE_PATH;
        }

        #endregion
    }
}
