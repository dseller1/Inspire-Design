using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LandGrab : System.Web.UI.Page
{

    public void btnLandGrab_Click(object sender, EventArgs e)
    {
        lblEstGrab.Text = "";
        if (tbAttacks.Text.Length > 0)
        {
            if (!Validation.validateNumber(tbAttacks.Text))
            {
                errorMessage(1);
            }
        }
        if (tbUserLand.Text.Length > 0 && tbTargetLand.Text.Length > 0)
        {
            if (Validation.validateNumber(tbUserLand.Text) && Validation.validateNumber(tbTargetLand.Text))
            {
                int attacks = 0;
                if (tbAttacks.Text.Length > 0)
                {
                    if (Validation.validateNumber(tbAttacks.Text))
                    {
                        attacks = Convert.ToInt32(tbAttacks.Text);
                    }
                }
                calcLandGrab(Convert.ToDouble(tbUserLand.Text), Convert.ToDouble(tbTargetLand.Text), attacks);
            }
            else
            {
                errorMessage(1);
            }
        }
    }

    public void calcLandGrab(double userLand, double targetLand, int attacks)
    {
        double estGrab;

        estGrab = Math.Round((targetLand / userLand) * (targetLand * 0.14) * Math.Pow(.7, attacks), 0);

        lblEstGrab.Text = estGrab.ToString("#,##0");
    }

    public void errorMessage(int errorCode)
    {
        //switch (errorCode)
        //{
        //    case 1:
        //        MessageBox.Show("All inputs must be valid numbers");
        //        break;
        //    case 2:
        //        MessageBox.Show("All inputs are required.");
        //        break;
        //}
    }
}