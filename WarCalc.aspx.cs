using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HtmlAgilityPack;

public partial class WarCalc : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void btnArCalc_Click(object sender, EventArgs e)
    {
        if (tbLand.Text.Length > 0)
        {
            if (Validation.validateNumber(tbLand.Text))
            {
                getArAttacks(Convert.ToDouble(tbLand.Text));
            }
            else
            {
                //errorMessage(1);
            }
        }
        else
        {
            //errorMessage(2);
        }
    }

    public void btnGaCalc_Click(object sender, EventArgs e)
    {
        if (tbPopulation.Text.Length > 0)
        {
            if (Validation.validateNumber(tbPopulation.Text))
            {
                getGaAttacks(Convert.ToDouble(tbPopulation.Text));
                //createGaExcel(Convert.ToInt64(tbPopulation.Text));
            }
            else
            {
                //errorMessage(1);
            }
        }
        else
        {
            //errorMessage(2);
        }
    }

    public void getGaAttacks(double population)
    {
        double count = 0;
        double pop = 0;
        double popTaken = 0;
        if (population > 106538073)
        {
            count = Math.Round(32.83101874 * Math.Log(population / 35357), 0);
        }
        else
        {
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(Pages.Population);
            HtmlNode docNode = doc.DocumentNode;
            HtmlNode table = docNode.SelectSingleNode("//table[@width='95%']");
            HtmlNodeCollection tableRows = table.SelectNodes(".//tr");

            string attackStatus = "";
            int startRow = 0;
            foreach (HtmlNode row in tableRows)
            {
                if (startRow > 0)
                {
                    HtmlNodeCollection cells = row.SelectNodes(".//td");
                    if (cells.Count == 5)
                    {
                        if (population >= 0)
                        {
                            attackStatus = cells[3].InnerText;
                            if (attackStatus != "Defeat / ")
                            {
                                pop = Convert.ToInt32(attackStatus.Substring(attackStatus.IndexOf(",") + 1, attackStatus.IndexOf("C") - attackStatus.IndexOf(",") - 1).Replace(".", ""));
                                popTaken += pop;
                                population -= pop;
                                count += 1;
                            }
                        }
                    }
                }
                startRow = 1;
            }
        }
        lblGaAttacks.Text = count.ToString();
        lblGa.Visible = true;
        lblGaAttacks.Visible = true;
    }

    public void getArAttacks(double totalLand)
    {
        double count = 0;
        double land = 0;
        double landTaken = 0;
        if (totalLand > 36485)
        {
            count = Math.Round(70.33832735 * Math.Log(0.00159865 * totalLand), 0);
        }
        else
        {
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(Pages.Land);

            HtmlNode docNode = doc.DocumentNode;
            HtmlNode table = docNode.SelectSingleNode("//table[@width='95%']");
            HtmlNodeCollection tableRows = table.SelectNodes(".//tr");

            string attackStatus = "";
            int startRow = 0;
            foreach (HtmlNode row in tableRows)
            {
                if (startRow > 0)
                {
                    HtmlNodeCollection cells = row.SelectNodes(".//td");
                    if (cells.Count == 5)
                    {
                        if (totalLand >= 0)
                        {
                            attackStatus = cells[3].InnerText;
                            if (attackStatus != "Defeat / ")
                            {
                                land = Convert.ToInt32(attackStatus.Substring(0, attackStatus.IndexOf("L") - 1).Replace(".", ""));
                                landTaken += land;
                                totalLand -= land;
                                count += 1;
                            }
                        }
                    }
                }
                startRow = 1;
            }
        }
        lblArAttacks.Text = count.ToString();
        lblAr.Visible = true;
        lblArAttacks.Visible = true;
    }
}