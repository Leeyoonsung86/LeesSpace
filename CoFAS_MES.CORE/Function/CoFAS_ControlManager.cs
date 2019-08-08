using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DevExpress.XtraEditors;

using DevExpress.XtraLayout;
using DevExpress.XtraTab;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraGrid.Views.Grid;
using CoFAS_MES.CORE.BaseControls;
using System.Drawing;

namespace CoFAS_MES.CORE.Function
{
    public static class CoFAS_ControlManager
    {
        public static void InvokeIfNeeded(Control control, Action action)
        {
            if (control.InvokeRequired)
                control.Invoke(action);
            else
                action();
        }

        public static void InvokeIfNeeded(UserControl uccontrol, Action action)
        {
            if (uccontrol.InvokeRequired)
                uccontrol.Invoke(action);
            else
                action();
        }

        public static void InvokeIfNeeded<T>(Control control, Action<T> action, T arg)
        {
            if (control.InvokeRequired)
                control.Invoke(action, arg);
            else
                action(arg);
        }

        public static IEnumerable<T> FindControls<T>(Control control) where T : Control
        {
            // we can't cast here because some controls in here will most likely not be <T>
            var controls = control.Controls.Cast<Control>();

            var enumerable = controls as Control[] ?? controls.ToArray();

            return enumerable.SelectMany(FindControls<T>).Concat(enumerable).Where(c => c.GetType() == typeof(T)).Cast<T>();
        }

        /// <summary>
        /// form 기준 언어 변환
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="frm"></param>
        public static void Language_Info(DataTable dt, Form frm)
        {
            
            foreach (DataRow dr in dt.Rows)
            {
                switch (dr["control_type"].ToString())
                {
                    case "_bt":

                        SimpleButton xsbt = frm.Controls.Find(dr["control_id"].ToString(), true).FirstOrDefault() as SimpleButton;
                        if (xsbt != null) xsbt.Text = dr["control_name"].ToString();

                        break;
                    case "_ucbt":

                        ucSimpleButton xucsbt = frm.Controls.Find(dr["control_id"].ToString(), true).FirstOrDefault() as ucSimpleButton;
                        if (xucsbt != null) xucsbt.Text = dr["control_name"].ToString();

                        break;
                    case "_ck":
                        CheckEdit xch = frm.Controls.Find(dr["control_id"].ToString(), true).FirstOrDefault() as CheckEdit;
                        if(xch != null) xch.Text = dr["control_name"].ToString();
                        break;
                    case "_lb":

                        LabelControl xlb = frm.Controls.Find(dr["control_id"].ToString(), true).FirstOrDefault() as LabelControl;
                        if (xlb != null) xlb.Text = dr["control_name"].ToString();

                        break;
                    case "_txt":

                        TextEdit xtxt = frm.Controls.Find(dr["control_id"].ToString(), true).FirstOrDefault() as TextEdit;
                        if (xtxt != null) xtxt.Text = dr["control_name"].ToString();

                        break;
                    case "_tp":

                        XtraTabPage xtp = frm.Controls.Find(dr["control_id"].ToString(), true).FirstOrDefault() as XtraTabPage;
                        if (xtp != null) xtp.Text = dr["control_name"].ToString();

                        break;

                    case "_lci":
                    case "_lcg":

                        var cArray = FindControls<LayoutControl>(frm);

                        foreach (LayoutControl ctrl in cArray)
                        {
                            if (ctrl.Items.FindByName(dr["control_id"].ToString()) != null)
                            {
                                ctrl.Items.FindByName(dr["control_id"].ToString()).Text = dr["control_name"].ToString();
                                if (dr["control_key"].ToString() == "Y")
                                {
                                    ctrl.Items.FindByName(dr["control_id"].ToString()).AppearanceItemCaption.ForeColor = Color.Red;
                                }
                            }
                        }
                        break;
                }
            }

        }
        public static void Language_Info(DataTable dt, Form frm, string language)
        {
            foreach (DataRow dr in dt.Rows)
            {
                switch (dr["control_type"].ToString())
                {
                    case "_bt":

                        SimpleButton xsbt = frm.Controls.Find(dr["control_id"].ToString(), true).FirstOrDefault() as SimpleButton;
                        //if (xsbt != null) xsbt.Text = language == "한국어" ? dr["control_name"].ToString() : dr["control_name2"].ToString();
                        if (xsbt != null) xsbt.Text = dr["control_name"].ToString();

                        break;
                    case "_ucbt":

                        ucSimpleButton xucsbt = frm.Controls.Find(dr["control_id"].ToString(), true).FirstOrDefault() as ucSimpleButton;
                        if (xucsbt != null) xucsbt.Text = dr["control_name"].ToString();

                        break;
                    case "_ck":
                        CheckEdit xch = frm.Controls.Find(dr["control_id"].ToString(), true).FirstOrDefault() as CheckEdit;
                        if (xch != null) xch.Text = dr["control_name"].ToString();
                        break;
                    case "_lb":

                        LabelControl xlb = frm.Controls.Find(dr["control_id"].ToString(), true).FirstOrDefault() as LabelControl;
                        if (xlb != null) xlb.Text = dr["control_name"].ToString();

                        break;
                    case "_txt":

                        TextEdit xtxt = frm.Controls.Find(dr["control_id"].ToString(), true).FirstOrDefault() as TextEdit;
                        if (xtxt != null) xtxt.Text = dr["control_name"].ToString();

                        break;
                    case "_tp":

                        XtraTabPage xtp = frm.Controls.Find(dr["control_id"].ToString(), true).FirstOrDefault() as XtraTabPage;
                        if (xtp != null) xtp.Text = dr["control_name"].ToString();

                        break;

                    case "_lci":
                    case "_lcg":

                        var cArray = FindControls<LayoutControl>(frm);

                        foreach (LayoutControl ctrl in cArray)
                        {
                            if (ctrl.Items.FindByName(dr["control_id"].ToString()) != null)
                            {
                                ctrl.Items.FindByName(dr["control_id"].ToString()).Text = dr["control_name"].ToString(); ;

                                if (dr["control_key"].ToString() == "Y")
                                {
                                    ctrl.Items.FindByName(dr["control_id"].ToString()).AppearanceItemCaption.ForeColor = Color.Red;
                                }
                            }
                        }
                        break;
                }
            }

        }
        /// <summary>
        /// userControl 기준 언어 변환
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="uc"></param>
        public static void Language_Info(DataTable dt, UserControl uc)
        {

            foreach (DataRow dr in dt.Rows)
            {
                switch (dr["control_type"].ToString())
                {
                    case "_bt":

                        SimpleButton xsbt = uc.Controls.Find(dr["control_id"].ToString(), true).FirstOrDefault() as SimpleButton;
                        if (xsbt != null) xsbt.Text = dr["control_name"].ToString();

                        break;
                    case "_ucbt":

                        ucSimpleButton xucsbt = uc.Controls.Find(dr["control_id"].ToString(), true).FirstOrDefault() as ucSimpleButton;
                        if (xucsbt != null) xucsbt.Text = dr["control_name"].ToString();

                        break;
                    case "_ck":
                        CheckEdit xch = uc.Controls.Find(dr["control_id"].ToString(), true).FirstOrDefault() as CheckEdit;
                        if (xch != null) xch.Text = dr["control_name"].ToString();
                        break;
                    case "_lb":

                        LabelControl xlb = uc.Controls.Find(dr["control_id"].ToString(), true).FirstOrDefault() as LabelControl;
                        if (xlb != null) xlb.Text = dr["control_name"].ToString();

                        break;
                    case "_txt":

                        TextEdit xtxt = uc.Controls.Find(dr["control_id"].ToString(), true).FirstOrDefault() as TextEdit;
                        if (xtxt != null) xtxt.Text = dr["control_name"].ToString();

                        break;
                    case "_tp":

                        XtraTabPage xtp = uc.Controls.Find(dr["control_id"].ToString(), true).FirstOrDefault() as XtraTabPage;
                        if (xtp != null) xtp.Text = dr["control_name"].ToString();

                        break;

                    case "_lci":
                    case "_lcg":

                        var cArray = FindControls<LayoutControl>(uc);

                        foreach (LayoutControl ctrl in cArray)
                        {
                            if (ctrl.Items.FindByName(dr["control_id"].ToString()) != null)
                            {
                                ctrl.Items.FindByName(dr["control_id"].ToString()).Text = dr["control_name"].ToString();

                                if (dr["control_key"].ToString() == "Y")
                                {
                                    ctrl.Items.FindByName(dr["control_id"].ToString()).AppearanceItemCaption.ForeColor = Color.Red;
                                }
                            }
                        }
                        break;
                }
            }

        }
        public static void Language_Info(DataTable dt, UserControl uc, string language)
        {

            foreach (DataRow dr in dt.Rows)
            {
                switch (dr["control_type"].ToString())
                {
                    case "_bt":

                        SimpleButton xsbt = uc.Controls.Find(dr["control_id"].ToString(), true).FirstOrDefault() as SimpleButton;
                        if (xsbt != null) xsbt.Text = dr["control_name"].ToString();

                        break;
                    case "_ucbt":

                        ucSimpleButton xucsbt = uc.Controls.Find(dr["control_id"].ToString(), true).FirstOrDefault() as ucSimpleButton;
                        if (xucsbt != null) xucsbt.Text = dr["control_name"].ToString();

                        break;
                    case "_ck":
                        CheckEdit xch = uc.Controls.Find(dr["control_id"].ToString(), true).FirstOrDefault() as CheckEdit;
                        if (xch != null) xch.Text = dr["control_name"].ToString();
                        break;
                    case "_lb":

                        LabelControl xlb = uc.Controls.Find(dr["control_id"].ToString(), true).FirstOrDefault() as LabelControl;
                        if (xlb != null) xlb.Text = dr["control_name"].ToString();

                        break;
                    case "_txt":

                        TextEdit xtxt = uc.Controls.Find(dr["control_id"].ToString(), true).FirstOrDefault() as TextEdit;
                        if (xtxt != null) xtxt.Text = dr["control_name"].ToString();

                        break;
                    case "_tp":

                        XtraTabPage xtp = uc.Controls.Find(dr["control_id"].ToString(), true).FirstOrDefault() as XtraTabPage;
                        if (xtp != null) xtp.Text = dr["control_name"].ToString();

                        break;

                    case "_lci":
                    case "_lcg":

                        var cArray = FindControls<LayoutControl>(uc);

                        foreach (LayoutControl ctrl in cArray)
                        {
                            if (ctrl.Items.FindByName(dr["control_id"].ToString()) != null)
                            {
                                ctrl.Items.FindByName(dr["control_id"].ToString()).Text = dr["control_name"].ToString();

                                if (dr["control_key"].ToString() == "Y")
                                {
                                    ctrl.Items.FindByName(dr["control_id"].ToString()).AppearanceItemCaption.ForeColor = Color.Red;
                                }
                            }
                        }
                        break;
                }
            }

        }
        /// <summary>
        /// form 기준 그리드 데이터 컨트롤러에 바인딩
        /// </summary>
        /// <param name="gv"></param>
        /// <param name="isInit"></param>
        /// <param name="frm"></param>
        public static void Controls_Binding(GridView gv, bool isInit, Form frm)
        {
            int iCnt = gv.Columns.Count();

            for (int a = 0; a < iCnt; a++)
            {
                string strName = gv.Columns[a].Name.ToString();
                string strSearchName = "_lu" + strName;

                if (frm.Controls.Find(strSearchName, true).Length > 0)
                {
                    string strValue = frm.Controls.Find(strSearchName, true).FirstOrDefault().GetType().Name.ToString();

                    switch (strValue)
                    {
                        case "TextEdit":
                            TextEdit xtxt = frm.Controls.Find(strSearchName, true).FirstOrDefault() as TextEdit;
                            if (xtxt != null)
                            {
                                if (isInit)
                                {
                                    xtxt.Text = "";
                                }
                                else
                                {
                                    xtxt.Text = gv.GetFocusedRowCellValue(strName).ToString();
                                }
                            }

                            break;
                        case "ucTextEdit":
                            ucTextEdit xuctxt = frm.Controls.Find(strSearchName, true).FirstOrDefault() as ucTextEdit;
                            if (xuctxt != null)
                            {
                                if (isInit)
                                {
                                    xuctxt.Text = "";
                                }
                                else
                                {
                                    xuctxt.Text = gv.GetFocusedRowCellValue(strName).ToString();
                                }
                            }

                            break;
                        case "SimpleButton":
                            SimpleButton xsimplebutton = frm.Controls.Find(strSearchName, true).FirstOrDefault() as SimpleButton;
                            if (xsimplebutton != null)
                            {
                                if (isInit)
                                {
                                    xsimplebutton.Text = "";
                                }
                                else
                                {
                                    xsimplebutton.Text = gv.GetFocusedRowCellValue(strName).ToString();
                                }
                            }

                            break;
                        case "ucSimpleButton":
                            ucSimpleButton xucsimplebutton = frm.Controls.Find(strSearchName, true).FirstOrDefault() as ucSimpleButton;
                            if (xucsimplebutton != null)
                            {
                                if (isInit)
                                {
                                    xucsimplebutton.Text = "";
                                }
                                else
                                {
                                    xucsimplebutton.Text = gv.GetFocusedRowCellValue(strName).ToString();
                                }
                            }

                            break;

                        case "MemoEdit":
                            MemoEdit xMemotxt = frm.Controls.Find(strSearchName, true).FirstOrDefault() as MemoEdit;
                            if (xMemotxt != null)
                            {
                                if (isInit)
                                {
                                    xMemotxt.Text = "";
                                }
                                else
                                {
                                    xMemotxt.Text = gv.GetFocusedRowCellValue(strName).ToString();
                                }
                            }

                            break;
                        case "ucMemoEdit":
                            ucMemoEdit xucMemotxt = frm.Controls.Find(strSearchName, true).FirstOrDefault() as ucMemoEdit;
                            if (xucMemotxt != null)
                            {
                                if (isInit)
                                {
                                    xucMemotxt.Text = "";
                                }
                                else
                                {
                                    xucMemotxt.Text = gv.GetFocusedRowCellValue(strName).ToString();
                                }
                            }

                            break;

                        case "LookUpEdit":
                            //주의 : value값은 int형으로 받으면 안되며, 문자형으로 바꿔야함
                            //Convert(컬럼,char)와 같이 프로시져에서 문자열로 변환
                            LookUpEdit xlue = frm.Controls.Find(strSearchName, true).FirstOrDefault() as LookUpEdit;
                            if (xlue != null)
                            {
                                if (isInit)
                                {
                                    xlue.EditValue = null;
                                }
                                else
                                {
                                    xlue.EditValue = gv.GetFocusedRowCellValue(strName).ToString();
                                }
                            }

                            break;
                        case "ucLookUpEdit":
                            //주의 : value값은 int형으로 받으면 안되며, 문자형으로 바꿔야함
                            //Convert(컬럼,char)와 같이 프로시져에서 문자열로 변환
                            ucLookUpEdit xuclue = frm.Controls.Find(strSearchName, true).FirstOrDefault() as ucLookUpEdit;
                            if (xuclue != null)
                            {
                                if (isInit)
                                {
                                    xuclue.SetValue("");
                                }
                                else
                                {
                                    xuclue.SetValue(gv.GetFocusedRowCellValue(strName).ToString());
                                }
                            }

                            break;

                        case "ucDateEdit":
                            ucDateEdit xucdate = frm.Controls.Find(strSearchName, true).FirstOrDefault() as ucDateEdit;
                            if (xucdate != null)
                            {
                                if (isInit)
                                {
                                    xucdate.DateTime = DateTime.Now;
                                }
                                else
                                {
                                    xucdate.DateTime = CoFAS_ConvertManager.String2Date(gv.GetFocusedRowCellValue(strName).ToString(), CoFAS_ConvertManager.enDateType.Date);
                                }
                            }

                            break;
                        case "ButtonEdit":
                            ButtonEdit xbuttonedit = frm.Controls.Find(strSearchName, true).FirstOrDefault() as ButtonEdit;
                            if (xbuttonedit != null)
                            {
                                if (isInit)
                                {
                                    xbuttonedit.Text = "";
                                }
                                else
                                {
                                    xbuttonedit.Text = gv.GetFocusedRowCellValue(strName).ToString();
                                }
                            }
                            break;
                        case "ucOpenButtonEdit":
                            ucOpenButtonEdit xucopenbuttonedit = frm.Controls.Find(strSearchName, true).FirstOrDefault() as ucOpenButtonEdit;
                            if (xucopenbuttonedit != null)
                            {
                                if (isInit)
                                {
                                    xucopenbuttonedit.Text = "";
                                }
                                else
                                {
                                    xucopenbuttonedit.Text = gv.GetFocusedRowCellValue(strName).ToString();
                                }
                            }
                            break;
                        case "ucButtonEdit":
                            ucButtonEdit xucbuttonedit = frm.Controls.Find(strSearchName, true).FirstOrDefault() as ucButtonEdit;
                            if (xucbuttonedit != null)
                            {
                                if (isInit)
                                {
                                    xucbuttonedit.Text = "";
                                }
                                else
                                {
                                    xucbuttonedit.Text = gv.GetFocusedRowCellValue(strName).ToString();
                                }
                            }
                            break;
                        case "ucImageOpenButtonEdit":
                            ucImageOpenButtonEdit xucimageopenbuttonedit = frm.Controls.Find(strSearchName, true).FirstOrDefault() as ucImageOpenButtonEdit;
                            if (xucimageopenbuttonedit != null)
                            {
                                if (isInit)
                                {
                                    xucimageopenbuttonedit.Text = "";
                                }
                                else
                                {
                                    xucimageopenbuttonedit.Text = gv.GetFocusedRowCellValue(strName).ToString();
                                }
                            }
                            break;
                        case "ucImageOpenDeleteButtonEdit":
                            ucImageOpenDeleteButtonEdit xucimageopendeletebuttonedit = frm.Controls.Find(strSearchName, true).FirstOrDefault() as ucImageOpenDeleteButtonEdit;
                            if (xucimageopendeletebuttonedit != null)
                            {
                                if (isInit)
                                {
                                    xucimageopendeletebuttonedit.Text = "";
                                }
                                else
                                {
                                    xucimageopendeletebuttonedit.Text = gv.GetFocusedRowCellValue(strName).ToString();
                                }
                            }
                            break;
                        case "ucPictureEdit":
                            ucPictureEdit xucpictureedit = frm.Controls.Find(strSearchName, true).FirstOrDefault() as ucPictureEdit;
                            Image img = null;
                            if (xucpictureedit != null)
                            {
                                if (isInit)
                                {
                                    xucpictureedit.Image = Properties.Resources.None;
                                }
                                else
                                {
                                    img = CoFAS_ConvertManager.byteArrayToImage((byte[])gv.GetFocusedRowCellValue(strName));

                                    if (img == null)
                                    {
                                        xucpictureedit.Image = Properties.Resources.None;
                                    }
                                    else
                                    {
                                        xucpictureedit.Image = img;
                                    }
                                }
                            }
                            break;
                        case "SpinEdit":
                            SpinEdit xspe = frm.Controls.Find(strSearchName, true).FirstOrDefault() as SpinEdit;
                            if (xspe != null)
                            {
                                if (isInit)
                                {
                                    xspe.Value = 0;
                                }
                                else
                                {
                                    xspe.Value = Convert.ToDecimal(gv.GetFocusedRowCellValue(strName).ToString());
                                }
                            }

                            break;
                        case "ucSpinEdit":
                            ucSpinEdit xucspe = frm.Controls.Find(strSearchName, true).FirstOrDefault() as ucSpinEdit;
                            if (xucspe != null)
                            {
                                if (isInit)
                                {
                                    xucspe.Value = 0;
                                }
                                else
                                {
                                    xucspe.Value = Convert.ToDecimal(gv.GetFocusedRowCellValue(strName).ToString());
                                }
                            }

                            break;
                        case "CheckEdit":
                            CheckEdit xcheckedit = frm.Controls.Find(strSearchName, true).FirstOrDefault() as CheckEdit;
                            if(xcheckedit != null)
                            {
                                if (isInit)
                                {
                                    xcheckedit.Checked = false;
                                }
                                else
                                {
                                    if(gv.GetFocusedRowCellValue(strName).ToString().Equals("Y"))
                                    {
                                        xcheckedit.Checked = true;
                                    }else
                                    {
                                        xcheckedit.Checked = false;
                                    }
                                }
                            }
                            break;

                        default:
                            break;
                    }
                }

            }

        }

        /// <summary>
        /// userControl 기준 그리드 데이터 컨트롤러 바인딩
        /// </summary>
        /// <param name="gv"></param>
        /// <param name="isInit"></param>
        /// <param name="uc"></param>
        public static void Controls_Binding(GridView gv, bool isInit, UserControl uc)
        {
            int iCnt = gv.Columns.Count();

            for (int a = 0; a < iCnt; a++)
            {
                string strName = gv.Columns[a].Name.ToString();
                string strSearchName = "_lu" + strName;

                if (uc.Controls.Find(strSearchName, true).Length > 0)
                {
                    string strValue = uc.Controls.Find(strSearchName, true).FirstOrDefault().GetType().Name.ToString();

                    switch (strValue)
                    {
                        case "TextEdit":
                            TextEdit xtxt = uc.Controls.Find(strSearchName, true).FirstOrDefault() as TextEdit;
                            if (xtxt != null)
                            {
                                if (isInit)
                                {
                                    xtxt.Text = "";
                                }
                                else
                                {
                                    xtxt.Text = gv.GetFocusedRowCellValue(strName).ToString();
                                }
                            }

                            break;
                        case "ucTextEdit":
                            ucTextEdit xuctxt = uc.Controls.Find(strSearchName, true).FirstOrDefault() as ucTextEdit;
                            if (xuctxt != null)
                            {
                                if (isInit)
                                {
                                    xuctxt.Text = "";
                                }
                                else
                                {
                                    xuctxt.Text = gv.GetFocusedRowCellValue(strName).ToString();
                                }
                            }

                            break;
                        case "SimpleButton":
                            SimpleButton xsimplebutton = uc.Controls.Find(strSearchName, true).FirstOrDefault() as SimpleButton;
                            if (xsimplebutton != null)
                            {
                                if (isInit)
                                {
                                    xsimplebutton.Text = "";
                                }
                                else
                                {
                                    xsimplebutton.Text = gv.GetFocusedRowCellValue(strName).ToString();
                                }
                            }

                            break;
                        case "ucSimpleButton":
                            ucSimpleButton xucsimplebutton = uc.Controls.Find(strSearchName, true).FirstOrDefault() as ucSimpleButton;
                            if (xucsimplebutton != null)
                            {
                                if (isInit)
                                {
                                    xucsimplebutton.Text = "";
                                }
                                else
                                {
                                    xucsimplebutton.Text = gv.GetFocusedRowCellValue(strName).ToString();
                                }
                            }

                            break;

                        case "MemoEdit":
                            MemoEdit xMemotxt = uc.Controls.Find(strSearchName, true).FirstOrDefault() as MemoEdit;
                            if (xMemotxt != null)
                            {
                                if (isInit)
                                {
                                    xMemotxt.Text = "";
                                }
                                else
                                {
                                    xMemotxt.Text = gv.GetFocusedRowCellValue(strName).ToString();
                                }
                            }

                            break;

                        case "ucMemoEdit":
                            ucMemoEdit xucMemotxt = uc.Controls.Find(strSearchName, true).FirstOrDefault() as ucMemoEdit;
                            if (xucMemotxt != null)
                            {
                                if (isInit)
                                {
                                    xucMemotxt.Text = "";
                                }
                                else
                                {
                                    xucMemotxt.Text = gv.GetFocusedRowCellValue(strName).ToString();
                                }
                            }
                            break;

                        case "LookUpEdit":
                            LookUpEdit xlue = uc.Controls.Find(strSearchName, true).FirstOrDefault() as LookUpEdit;
                            if (xlue != null)
                            {
                                if (isInit)
                                {
                                    xlue.EditValue = null;
                                }
                                else
                                {
                                    xlue.EditValue = gv.GetFocusedRowCellValue(strName).ToString();
                                }
                            }

                            break;
                        case "ucLookUpEdit":
                            ucLookUpEdit xuclue = uc.Controls.Find(strSearchName, true).FirstOrDefault() as ucLookUpEdit;
                            if (xuclue != null)
                            {
                                if (isInit)
                                {
                                    xuclue.SetValue("");
                                }
                                else
                                {
                                    xuclue.SetValue(gv.GetFocusedRowCellValue(strName).ToString());
                                }
                            }

                            break;
                        case "ucDateEdit":
                            ucDateEdit xucdate = uc.Controls.Find(strSearchName, true).FirstOrDefault() as ucDateEdit;
                            if (xucdate != null)
                            {
                                if (isInit)
                                {
                                    xucdate.DateTime = DateTime.Now;
                                }
                                else
                                {
                                    xucdate.DateTime = CoFAS_ConvertManager.String2Date(gv.GetFocusedRowCellValue(strName).ToString(), CoFAS_ConvertManager.enDateType.Date);
                                }
                            }

                            break;
                        case "ButtonEdit":
                            ButtonEdit xbuttonedit = uc.Controls.Find(strSearchName, true).FirstOrDefault() as ButtonEdit;
                            if (xbuttonedit != null)
                            {
                                if (isInit)
                                {
                                    xbuttonedit.Text = "";
                                }
                                else
                                {
                                    xbuttonedit.Text = gv.GetFocusedRowCellValue(strName).ToString();
                                }
                            }
                            break;
                        case "ucOpenButtonEdit":
                            ucOpenButtonEdit xucopenbuttonedit = uc.Controls.Find(strSearchName, true).FirstOrDefault() as ucOpenButtonEdit;
                            if (xucopenbuttonedit != null)
                            {
                                if (isInit)
                                {
                                    xucopenbuttonedit.Text = "";
                                }
                                else
                                {
                                    xucopenbuttonedit.Text = gv.GetFocusedRowCellValue(strName).ToString();
                                }
                            }
                            break;
                        case "ucButtonEdit":
                            ucButtonEdit xucbuttonedit = uc.Controls.Find(strSearchName, true).FirstOrDefault() as ucButtonEdit;
                            if (xucbuttonedit != null)
                            {
                                if (isInit)
                                {
                                    xucbuttonedit.Text = "";
                                }
                                else
                                {
                                    xucbuttonedit.Text = gv.GetFocusedRowCellValue(strName).ToString();
                                }
                            }
                            break;
                        case "ucImageOpenButtonEdit":
                            ucImageOpenButtonEdit xucimageopenbuttonedit = uc.Controls.Find(strSearchName, true).FirstOrDefault() as ucImageOpenButtonEdit;
                            if (xucimageopenbuttonedit != null)
                            {
                                if (isInit)
                                {
                                    xucimageopenbuttonedit.Text = "";
                                }
                                else
                                {
                                    xucimageopenbuttonedit.Text = gv.GetFocusedRowCellValue(strName).ToString();
                                }
                            }
                            break;
                        case "ucImageOpenDeleteButtonEdit":
                            ucImageOpenDeleteButtonEdit xucimageopendeletebuttonedit = uc.Controls.Find(strSearchName, true).FirstOrDefault() as ucImageOpenDeleteButtonEdit;
                            if (xucimageopendeletebuttonedit != null)
                            {
                                if (isInit)
                                {
                                    xucimageopendeletebuttonedit.Text = "";
                                }
                                else
                                {
                                    xucimageopendeletebuttonedit.Text = gv.GetFocusedRowCellValue(strName).ToString();
                                }
                            }
                            break;
                        case "ucPictureEdit":
                            ucPictureEdit xucpictureedit = uc.Controls.Find(strSearchName, true).FirstOrDefault() as ucPictureEdit;
                            Image img = null;
                            if (xucpictureedit != null)
                            {
                                if (isInit)
                                {
                                    xucpictureedit.Image = Properties.Resources.None;
                                }
                                else
                                {
                                    img = CoFAS_ConvertManager.byteArrayToImage((byte[])gv.GetFocusedRowCellValue(strName));

                                    if (img == null)
                                    {
                                        xucpictureedit.Image = Properties.Resources.None;
                                    }
                                    else
                                    {
                                        xucpictureedit.Image = img;
                                    }
                                }
                            }
                            break;
                        case "SpinEdit":
                            SpinEdit xspe = uc.Controls.Find(strSearchName, true).FirstOrDefault() as SpinEdit;
                            if (xspe != null)
                            {
                                if (isInit)
                                {
                                    xspe.Value = 0;
                                }
                                else
                                {
                                    xspe.Value = Convert.ToDecimal(gv.GetFocusedRowCellValue(strName).ToString());
                                }
                            }

                            break;
                        case "ucSpinEdit":
                            ucSpinEdit xucspe = uc.Controls.Find(strSearchName, true).FirstOrDefault() as ucSpinEdit;
                            if (xucspe != null)
                            {
                                if (isInit)
                                {
                                    xucspe.Value = 0;
                                }
                                else
                                {
                                    xucspe.Value = Convert.ToDecimal(gv.GetFocusedRowCellValue(strName).ToString());
                                }
                            }

                            break;

                        default:
                            break;

                    }
                }

            }

        }

        /// <summary>
        /// form 기준 데이터테이블 데이터 컨트롤러에 바인딩
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="isInit"></param>
        /// <param name="frm"></param>
        public static void Controls_Binding(DataTable dt, bool isInit, Form frm)
        {
            int iCnt = dt.Columns.Count;

            for (int a = 0; a < iCnt; a++)
            {
                string strName = dt.Columns[a].ColumnName.ToString();
                string strSearchName = "_lu" + strName;

                if (frm.Controls.Find(strSearchName, true).Length > 0)
                {
                    string strValue = frm.Controls.Find(strSearchName, true).FirstOrDefault().GetType().Name.ToString();

                    switch (strValue)
                    {
                        case "TextEdit":
                            TextEdit xtxt = frm.Controls.Find(strSearchName, true).FirstOrDefault() as TextEdit;
                            if (xtxt != null)
                            {
                                if (isInit)
                                {
                                    xtxt.Text = "";
                                }
                                else
                                {
                                    xtxt.Text = dt.Rows[0][strName].ToString();
                                }
                            }

                            break;
                        case "ucTextEdit":
                            ucTextEdit xuctxt = frm.Controls.Find(strSearchName, true).FirstOrDefault() as ucTextEdit;
                            if (xuctxt != null)
                            {
                                if (isInit)
                                {
                                    xuctxt.Text = "";
                                }
                                else
                                {
                                    xuctxt.Text = dt.Rows[0][strName].ToString();
                                }
                            }
                            break;

                        case "SimpleButton":
                            SimpleButton xsimplebutton = frm.Controls.Find(strSearchName, true).FirstOrDefault() as SimpleButton;
                            if (xsimplebutton != null)
                            {
                                if (isInit)
                                {
                                    xsimplebutton.Text = "";
                                }
                                else
                                {
                                    xsimplebutton.Text = dt.Rows[0][strName].ToString();
                                }
                            }

                            break;
                        case "ucSimpleButton":
                            ucSimpleButton xucsimplebutton = frm.Controls.Find(strSearchName, true).FirstOrDefault() as ucSimpleButton;
                            if (xucsimplebutton != null)
                            {
                                if (isInit)
                                {
                                    xucsimplebutton.Text = "";
                                }
                                else
                                {
                                    xucsimplebutton.Text = dt.Rows[0][strName].ToString();
                                }
                            }

                            break;
                        case "MemoEdit":
                            MemoEdit xMemotxt = frm.Controls.Find(strSearchName, true).FirstOrDefault() as MemoEdit;
                            if (xMemotxt != null)
                            {
                                if (isInit)
                                {
                                    xMemotxt.Text = "";
                                }
                                else
                                {
                                    xMemotxt.Text = dt.Rows[0][strName].ToString();
                                }
                            }

                            break;
                        case "ucMemoEdit":
                            ucMemoEdit xucMemotxt = frm.Controls.Find(strSearchName, true).FirstOrDefault() as ucMemoEdit;
                            if (xucMemotxt != null)
                            {
                                if (isInit)
                                {
                                    xucMemotxt.Text = "";
                                }
                                else
                                {
                                    xucMemotxt.Text = dt.Rows[0][strName].ToString();
                                }
                            }

                            break;

                        case "LookUpEdit":
                            LookUpEdit xlue = frm.Controls.Find(strSearchName, true).FirstOrDefault() as LookUpEdit;
                            if (xlue != null)
                            {
                                if (isInit)
                                {
                                    xlue.EditValue = null;
                                }
                                else
                                {
                                    xlue.EditValue = dt.Rows[0][strName].ToString();
                                }
                            }

                            break;
                        case "ucLookUpEdit":
                            ucLookUpEdit xuclue = frm.Controls.Find(strSearchName, true).FirstOrDefault() as ucLookUpEdit;
                            if (xuclue != null)
                            {
                                if (isInit)
                                {
                                    xuclue.SetValue("");
                                }
                                else
                                {
                                    xuclue.SetValue(dt.Rows[0][strName].ToString());
                                }
                            }

                            break;
                        case "ucDateEdit":
                            ucDateEdit xucdateedit = frm.Controls.Find(strSearchName, true).FirstOrDefault() as ucDateEdit;
                            if (xucdateedit != null)
                            {
                                if (isInit)
                                {
                                    xucdateedit.DateTime = DateTime.Now;
                                }
                                else
                                {
                                    xucdateedit.DateTime = CoFAS_ConvertManager.String2Date(dt.Rows[0][strName].ToString(), CoFAS_ConvertManager.enDateType.Date);
                                }
                            }

                            break;
                        case "ButtonEdit":
                            ButtonEdit xbuttonedit = frm.Controls.Find(strSearchName, true).FirstOrDefault() as ButtonEdit;
                            if (xbuttonedit != null)
                            {
                                if (isInit)
                                {
                                    xbuttonedit.Text = "";
                                }
                                else
                                {
                                    xbuttonedit.Text = dt.Rows[0][strName].ToString();
                                }
                            }
                            break;
                        case "ucOpenButtonEdit":
                            ucOpenButtonEdit xucopenbuttonedit = frm.Controls.Find(strSearchName, true).FirstOrDefault() as ucOpenButtonEdit;
                            if (xucopenbuttonedit != null)
                            {
                                if (isInit)
                                {
                                    xucopenbuttonedit.Text = "";
                                }
                                else
                                {
                                    xucopenbuttonedit.Text = dt.Rows[0][strName].ToString();
                                }
                            }
                            break;

                        case "ucButtonEdit":
                            ucButtonEdit xucbuttonedit = frm.Controls.Find(strSearchName, true).FirstOrDefault() as ucButtonEdit;
                            if (xucbuttonedit != null)
                            {
                                if (isInit)
                                {
                                    xucbuttonedit.Text = "";
                                }
                                else
                                {
                                    xucbuttonedit.Text = dt.Rows[0][strName].ToString();
                                }
                            }
                            break;
                        case "ucImageOpenButtonEdit":
                            ucImageOpenButtonEdit xucimageopenbuttonedit = frm.Controls.Find(strSearchName, true).FirstOrDefault() as ucImageOpenButtonEdit;
                            if (xucimageopenbuttonedit != null)
                            {
                                if (isInit)
                                {
                                    xucimageopenbuttonedit.Text = "";
                                }
                                else
                                {
                                    xucimageopenbuttonedit.Text = dt.Rows[0][strName].ToString();
                                }
                            }
                            break;
                        case "ucImageOpenDeleteButtonEdit":
                            ucImageOpenDeleteButtonEdit xucimageopendeletebuttonedit = frm.Controls.Find(strSearchName, true).FirstOrDefault() as ucImageOpenDeleteButtonEdit;
                            if (xucimageopendeletebuttonedit != null)
                            {
                                if (isInit)
                                {
                                    xucimageopendeletebuttonedit.Text = "";
                                }
                                else
                                {
                                    xucimageopendeletebuttonedit.Text = dt.Rows[0][strName].ToString();
                                }
                            }
                            break;
                        case "ucPictureEdit":
                            ucPictureEdit xucpictureedit = frm.Controls.Find(strSearchName, true).FirstOrDefault() as ucPictureEdit;
                            Image img = null;
                            if (xucpictureedit != null)
                            {
                                if (isInit)
                                {
                                    xucpictureedit.Image = Properties.Resources.None;
                                }
                                else
                                {
                                    if (dt.Rows[0][strName].ToString() != "" && ((byte[])dt.Rows[0][strName]).Length > 0)
                                    {
                                        img = CoFAS_ConvertManager.byteArrayToImage((byte[])dt.Rows[0][strName]);
                                    }
                                    else
                                    {
                                        img = null;
                                    }

                                    if (img == null)
                                    {
                                        xucpictureedit.Image = Properties.Resources.None;
                                    }
                                    else
                                    {
                                        xucpictureedit.Image = img;
                                    }
                                }
                            }
                            break;
                        case "SpinEdit":
                            SpinEdit xspe = frm.Controls.Find(strSearchName, true).FirstOrDefault() as SpinEdit;
                            if (xspe != null)
                            {
                                if (isInit)
                                {
                                    xspe.Value = 0;
                                }
                                else
                                {
                                    xspe.Value = Convert.ToDecimal(dt.Rows[0][strName].ToString());
                                }
                            }

                            break;
                        case "ucSpinEdit":
                            ucSpinEdit xucspe = frm.Controls.Find(strSearchName, true).FirstOrDefault() as ucSpinEdit;
                            if (xucspe != null)
                            {
                                if (isInit)
                                {
                                    xucspe.Value = 0;
                                }
                                else
                                {
                                    xucspe.Value = Convert.ToDecimal(dt.Rows[0][strName].ToString() == "" ? "0": dt.Rows[0][strName].ToString());
                                }
                            }

                            break;
                        default:
                            break;

                    }
                }

            }

        }

        /// <summary>
        /// userControl 기준 데이터테이블 데이터  컨트롤러 바인딩
        /// </summary>
        /// <param name="gv"></param>
        /// <param name="isInit"></param>
        /// <param name="uc"></param>
        public static void Controls_Binding(DataTable dt, bool isInit, UserControl uc)
        {
            int iCnt = dt.Columns.Count;

            for (int a = 0; a < iCnt; a++)
            {
                string strName = dt.Columns[a].ColumnName.ToString();
                string strSearchName = "_lu" + strName;

                if (uc.Controls.Find(strSearchName, true).Length > 0)
                {
                    string strValue = uc.Controls.Find(strSearchName, true).FirstOrDefault().GetType().Name.ToString();

                    switch (strValue)
                    {
                        case "TextEdit":
                            TextEdit xtxt = uc.Controls.Find(strSearchName, true).FirstOrDefault() as TextEdit;
                            if (xtxt != null)
                            {
                                if (isInit)
                                {
                                    xtxt.Text = "";
                                }
                                else
                                {
                                    xtxt.Text = dt.Rows[0][strName].ToString();
                                }
                            }

                            break;
                        case "ucTextEdit":
                            ucTextEdit xuctxt = uc.Controls.Find(strSearchName, true).FirstOrDefault() as ucTextEdit;
                            if (xuctxt != null)
                            {
                                if (isInit)
                                {
                                    xuctxt.Text = "";
                                }
                                else
                                {
                                    xuctxt.Text = dt.Rows[0][strName].ToString();
                                }
                            }

                            break;

                        case "SimpleButton":
                            SimpleButton xsimplebutton = uc.Controls.Find(strSearchName, true).FirstOrDefault() as SimpleButton;
                            if (xsimplebutton != null)
                            {
                                if (isInit)
                                {
                                    xsimplebutton.Text = "";
                                }
                                else
                                {
                                    xsimplebutton.Text = dt.Rows[0][strName].ToString();
                                }
                            }

                            break;
                        case "ucSimpleButton":
                            ucSimpleButton xucsimplebutton = uc.Controls.Find(strSearchName, true).FirstOrDefault() as ucSimpleButton;
                            if (xucsimplebutton != null)
                            {
                                if (isInit)
                                {
                                    xucsimplebutton.Text = "";
                                }
                                else
                                {
                                    xucsimplebutton.Text = dt.Rows[0][strName].ToString();
                                }
                            }

                            break;

                        case "MemoEdit":
                            MemoEdit xMemotxt = uc.Controls.Find(strSearchName, true).FirstOrDefault() as MemoEdit;
                            if (xMemotxt != null)
                            {
                                if (isInit)
                                {
                                    xMemotxt.Text = "";
                                }
                                else
                                {
                                    xMemotxt.Text = dt.Rows[0][strName].ToString();
                                }
                            }

                            break;
                        case "ucMemoEdit":
                            ucMemoEdit xucMemotxt = uc.Controls.Find(strSearchName, true).FirstOrDefault() as ucMemoEdit;
                            if (xucMemotxt != null)
                            {
                                if (isInit)
                                {
                                    xucMemotxt.Text = "";
                                }
                                else
                                {
                                    xucMemotxt.Text = dt.Rows[0][strName].ToString();
                                }
                            }

                            break;

                        case "LookUpEdit":
                            LookUpEdit xlue = uc.Controls.Find(strSearchName, true).FirstOrDefault() as LookUpEdit;
                            if (xlue != null)
                            {
                                if (isInit)
                                {
                                    xlue.EditValue = null;
                                }
                                else
                                {
                                    xlue.EditValue = dt.Rows[0][strName].ToString();
                                }
                            }

                            break;
                        case "ucLookUpEdit":
                            ucLookUpEdit xuclue = uc.Controls.Find(strSearchName, true).FirstOrDefault() as ucLookUpEdit;
                            if (xuclue != null)
                            {
                                if (isInit)
                                {
                                    xuclue.SetValue("");
                                }
                                else
                                {
                                    xuclue.SetValue(dt.Rows[0][strName].ToString());
                                }
                            }

                            break;
                        case "ucDateEdit":
                            ucDateEdit xucdateedit = uc.Controls.Find(strSearchName, true).FirstOrDefault() as ucDateEdit;
                            if (xucdateedit != null)
                            {
                                if (isInit)
                                {
                                    xucdateedit.DateTime = DateTime.Now;
                                }
                                else
                                {
                                    xucdateedit.DateTime = CoFAS_ConvertManager.String2Date(dt.Rows[0][strName].ToString(), CoFAS_ConvertManager.enDateType.Date);
                                }
                            }

                            break;
                        case "ButtonEdit":
                            ButtonEdit xbuttonedit = uc.Controls.Find(strSearchName, true).FirstOrDefault() as ButtonEdit;
                            if (xbuttonedit != null)
                            {
                                if (isInit)
                                {
                                    xbuttonedit.Text = "";
                                }
                                else
                                {
                                    xbuttonedit.Text = dt.Rows[0][strName].ToString();
                                }
                            }
                            break;
                        case "ucOpenButtonEdit":
                            ucOpenButtonEdit xucopenbuttonedit = uc.Controls.Find(strSearchName, true).FirstOrDefault() as ucOpenButtonEdit;
                            if (xucopenbuttonedit != null)
                            {
                                if (isInit)
                                {
                                    xucopenbuttonedit.Text = "";
                                }
                                else
                                {
                                    xucopenbuttonedit.Text = dt.Rows[0][strName].ToString();
                                }
                            }
                            break;

                        case "ucButtonEdit":
                            ucButtonEdit xucbuttonedit = uc.Controls.Find(strSearchName, true).FirstOrDefault() as ucButtonEdit;
                            if (xucbuttonedit != null)
                            {
                                if (isInit)
                                {
                                    xucbuttonedit.Text = "";
                                }
                                else
                                {
                                    xucbuttonedit.Text = dt.Rows[0][strName].ToString();
                                }
                            }
                            break;
                        case "ucImageOpenButtonEdit":
                            ucImageOpenButtonEdit xucimageopenbuttonedit = uc.Controls.Find(strSearchName, true).FirstOrDefault() as ucImageOpenButtonEdit;
                            if (xucimageopenbuttonedit != null)
                            {
                                if (isInit)
                                {
                                    xucimageopenbuttonedit.Text = "";
                                }
                                else
                                {
                                    xucimageopenbuttonedit.Text = dt.Rows[0][strName].ToString();
                                }
                            }
                            break;
                        case "ucImageOpenDeleteButtonEdit":
                            ucImageOpenDeleteButtonEdit xucimageopendeletebuttonedit = uc.Controls.Find(strSearchName, true).FirstOrDefault() as ucImageOpenDeleteButtonEdit;
                            if (xucimageopendeletebuttonedit != null)
                            {
                                if (isInit)
                                {
                                    xucimageopendeletebuttonedit.Text = "";
                                }
                                else
                                {
                                    xucimageopendeletebuttonedit.Text = dt.Rows[0][strName].ToString();
                                }
                            }
                            break;
                        case "ucPictureEdit":
                            ucPictureEdit xucpictureedit = uc.Controls.Find(strSearchName, true).FirstOrDefault() as ucPictureEdit;
                            Image img = null;
                            if (xucpictureedit != null)
                            {
                                if (isInit)
                                {
                                    xucpictureedit.Image = Properties.Resources.None;
                                }
                                else
                                {
                                    img = CoFAS_ConvertManager.byteArrayToImage((byte[])dt.Rows[0][strName]);

                                    if(img == null)
                                    {
                                        xucpictureedit.Image = Properties.Resources.None;
                                    }
                                    else
                                    {
                                        xucpictureedit.Image = img;
                                    }
                                }
                            }
                            break;
                        case "SpinEdit":
                            SpinEdit xspe = uc.Controls.Find(strSearchName, true).FirstOrDefault() as SpinEdit;
                            if (xspe != null)
                            {
                                if (isInit)
                                {
                                    xspe.Value = 0;
                                }
                                else
                                {
                                    xspe.Value = Convert.ToDecimal(dt.Rows[0][strName].ToString());
                                }
                            }

                            break;
                        case "ucSpinEdit":
                            ucSpinEdit xucspe = uc.Controls.Find(strSearchName, true).FirstOrDefault() as ucSpinEdit;
                            if (xucspe != null)
                            {
                                if (isInit)
                                {
                                    xucspe.Value = 0;
                                }
                                else
                                {
                                    xucspe.Value = Convert.ToDecimal(dt.Rows[0][strName].ToString());
                                }
                            }

                            break;
                        default:
                            break;

                    }
                }

            }

        }

        /// <summary>
        /// 컨트롤러 폰트 일괄 변경
        /// </summary>
        /// <param name="controls"></param>
        /// <param name="font"></param>
        public static void SetFontInControls(Control.ControlCollection controls, Font font)
        {
            foreach (Control childControl in controls)
            {
                childControl.Font = font;

                if (childControl.HasChildren)
                {
                    SetFontInControls(childControl.Controls, font);
                }
            }
        }


    }
}
