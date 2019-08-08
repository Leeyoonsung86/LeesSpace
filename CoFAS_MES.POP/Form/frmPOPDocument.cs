using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CoFAS_MES.CORE.BaseForm;
using CoFAS_MES.CORE.Function;

using CoFAS_MES.POP.Business;
using CoFAS_MES.POP.Data;
using CoFAS_MES.POP.Entity;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;

namespace CoFAS_MES.POP
{
    public partial class frmPOPDocument : frmBaseSingle
    {
        public frmPOPDocument()
        {
            InitializeComponent();

        }

        #region ○ 버튼 클릭시

        private void btnCmd_Click(object pSender, EventArgs pEventArgs)
        {
            SimpleButton pCmd = pSender as SimpleButton;

            string sCls = pCmd.Name.Substring(6, 2);
            switch (sCls)
            {
                case "10":
                    // 위로
                    break;

                case "20":
                    // 아래로
                    break;

                default: break;
            }

        }

        #endregion
    }
}
