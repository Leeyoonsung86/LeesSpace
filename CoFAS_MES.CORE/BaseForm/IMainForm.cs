using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CoFAS_MES.CORE.Entity;

namespace CoFAS_MES.CORE.BaseForm
{
    /// <summary>
    /// 메인 폼 인터페이스
    /// </summary>
    public interface IMainForm
    {
        //////////////////////////////////////////////////////////////////////////////////////////////////// Property

        #region 사용자 개체 - UserEntity

        /// <summary>
        /// 사용자 개체
        /// </summary>
        UserEntity UserEntity { get; set; }

        #endregion

        #region 메세지 개체 - MessageEntity

        /// <summary>
        /// 사용자 개체
        /// </summary>
        MessageEntity MessageEntity { get; set; }

        #endregion

        //////////////////////////////////////////////////////////////////////////////////////////////////// Method

        #region 버튼 설정 설정하기 - SetButtonSetting(MainFormButtonSetting pButtonSetting)

        /// <summary>
        /// 버튼 설정 설정하기
        /// </summary>
        /// <param name="pButtonSetting">버튼 설정</param>
        void SetButtonSetting(MainFormButtonSetting pButtonSetting);

        #endregion
    }
}
