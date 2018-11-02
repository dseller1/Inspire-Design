using System;

public class Jets
{
    public Jets(int jetCount, int jetLvl, int naJetCount)
    {
        this.JetCount = jetCount;
        this.JetLvl = jetLvl;
        this.JetBasePwr = 2.6;
        this.JetBaseCost = 0.1;
        this.JetBaseFood = 0.0004;
        this.JetBaseOil = 0.0005;
        this.JetBaseNet = .28;

        this.JetUserPwr = Math.Round(this.JetBasePwr + (this.JetBasePwr / 10 * (this.JetLvl - 1)), 3);
        this.JetUserCost = Math.Round(this.JetBaseCost + (this.JetBaseCost / 10 * (this.JetLvl - 1)), 5);
        this.JetUserFood = Math.Round(this.JetBaseFood + (this.JetBaseFood / 10 * (this.JetLvl - 1)), 5);
        this.JetUserOil = Math.Round(this.JetBaseOil + (this.JetBaseOil / 10 * (this.JetLvl - 1)), 5);
        this.JetUserNet = Math.Round(this.JetBaseNet + (this.JetBaseNet / 10 * (this.JetLvl - 1)), 5);
        this.NaJetCount = naJetCount;
        if (this.JetCount <= this.NaJetCount)
        {
            this.NaJetPwr = Math.Round((this.JetCount / 2) * this.JetUserPwr, 2);
        }
        else
        {
            this.NaJetPwr = Math.Round((this.NaJetCount / 2) * this.JetUserPwr, 2);
        }
        this.JetAttPwr = Math.Round(this.JetCount * this.JetUserPwr + this.NaJetPwr, 2);
        this.JetTotCost = this.JetCount * this.JetUserCost;
        this.JetTotFood = this.JetCount * this.JetUserFood;
        this.JetTotOil = this.JetCount * this.JetUserOil;
        this.JetTotNet = this.JetCount * this.JetUserNet;
    }

    public int JetCount { get; set; }
    public int JetLvl { get; set; }
    public double JetBasePwr { get; set; }
    public double JetUserPwr { get; set; }
    public double JetAttPwr { get; set; }
    public int NaJetCount { get; set; }
    public double NaJetPwr { get; set; }
    public double JetBaseCost { get; set; }
    public double JetUserCost { get; set; }
    public double JetBaseFood { get; set; }
    public double JetUserFood { get; set; }
    public double JetBaseOil { get; set; }
    public double JetUserOil { get; set; }
    public double JetTotCost { get; set; }
    public double JetTotFood { get; set; }
    public double JetTotOil { get; set; }
    public double JetBaseNet { get; set; }
    public double JetUserNet { get; set; }
    public double JetTotNet { get; set; }
}