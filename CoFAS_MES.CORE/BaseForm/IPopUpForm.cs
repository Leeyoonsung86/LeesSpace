using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoFAS_MES.CORE.BaseForm
{
    public interface IPopUpForm
    {
        string PageSetting_WINDOW_NAME { get; set; }
        string PageSetting_USER_CODE { get; set; }
        string PageSetting_LANGUAGE { get; set; }
        Font PageSetting_FONT { get; set; }

    }
}
