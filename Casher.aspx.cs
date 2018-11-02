using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Casher : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void btnCasher_Click(object sender, EventArgs e)
    {
        lblBPT.Text = "";
        lblTargetComm.Text = "";
        lblTargetRes.Text = "";
        lblCommToBuild.Text = "";
        lblResToBuild.Text = "";

        if (tbTotalLand.Text.Length > 0 && tbCS.Text.Length > 0 && tbCurrentComm.Text.Length > 0 && tbCurrentRes.Text.Length > 0)
        {
            if (Validation.validateNumber(tbTotalLand.Text) && Validation.validateNumber(tbCS.Text) && Validation.validateNumber(tbCurrentComm.Text) && Validation.validateNumber(tbCurrentRes.Text))
            {
                CasherState cash = new CasherState(Convert.ToDouble(tbTotalLand.Text), Convert.ToDouble(tbCS.Text), Convert.ToDouble(tbCurrentComm.Text), Convert.ToDouble(tbCurrentRes.Text));
                lblBPT.Text = cash.BPT.ToString("#,##0");
                lblTargetComm.Text = cash.TargetComm.ToString("#,##0");
                lblTargetRes.Text = cash.TargetRes.ToString("#,##0");
                lblCommToBuild.Text = cash.CommToBuild.ToString("#,##0");
                lblResToBuild.Text = cash.ResToBuild.ToString("#,##0");
            }
            else
            {
                //errorMessage(1);
            }
        }
    }
}