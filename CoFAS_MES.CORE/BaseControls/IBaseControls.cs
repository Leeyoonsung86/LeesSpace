using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoFAS_MES.CORE.BaseControls
{
    public interface IBaseControls
    {

        #region 스프레드 시트 셀 클릭시 이벤트 발생시키기 - RaiseSpreadSheetCellClickedEvent()

        /// <summary>
        /// 조회 버튼 클릭시 이벤트 발생시키기
        /// </summary>
        /// <param name="pSender">이벤트 발생자</param>
        /// <param name="pEventArgs">이벤트 인자</param>
        void RaiseSpreadSheetCellClickedEvent();

        #endregion

    }
}
