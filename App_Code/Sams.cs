using System;

public class Sams
{
    public Sams(int samCount, int samLvl, int naSamCount)
    {
        this.SamCount = samCount;
        this.SamLvl = samLvl;
        this.SamBasePwr = 3.35;
        this.SamBaseCost = 0.1;
        this.SamBaseFood = 0.0015;
        this.SamBaseOil = 0.0015;
        this.SamBaseNet = .36;

        this.SamUserPwr = Math.Round(this.SamBasePwr + (this.SamBasePwr / 10 * (this.SamLvl - 1)), 3);
        this.SamUserCost = Math.Round(this.SamBaseCost + (this.SamBaseCost / 10 * (this.SamLvl - 1)), 5);
        this.SamUserFood = Math.Round(this.SamBaseFood + (this.SamBaseFood / 10 * (this.SamLvl - 1)), 5);
        this.SamUserOil = Math.Round(this.SamBaseOil + (this.SamBaseOil / 10 * (this.SamLvl - 1)), 5);
        this.SamUserNet = Math.Round(this.SamBaseNet + (this.SamBaseNet / 10 * (this.SamLvl - 1)), 5);
        this.NaSamCount = naSamCount;
        if (this.SamCount <= this.NaSamCount)
        {
            this.NaSamPwr = Math.Round((this.SamCount / 2) * this.SamUserPwr, 2);
        }
        else
        {
            this.NaSamPwr = Math.Round((this.NaSamCount / 2) * this.SamUserPwr, 2);
        }
        this.SamAttPwr = Math.Round(this.SamCount * this.SamUserPwr + this.NaSamPwr, 2);
        this.SamTotCost = this.SamCount * this.SamUserCost;
        this.SamTotFood = this.SamCount * this.SamUserFood;
        this.SamTotOil = this.SamCount * this.SamUserOil;
        this.SamTotNet = this.SamCount * this.SamUserNet;
    }

    public int SamCount { get; set; }
    public int SamLvl { get; set; }
    public double SamBasePwr { get; set; }
    public double SamUserPwr { get; set; }
    public double SamAttPwr { get; set; }
    public int NaSamCount { get; set; }
    public double NaSamPwr { get; set; }
    public double SamBaseCost { get; set; }
    public double SamUserCost { get; set; }
    public double SamBaseFood { get; set; }
    public double SamUserFood { get; set; }
    public double SamBaseOil { get; set; }
    public double SamUserOil { get; set; }
    public double SamTotCost { get; set; }
    public double SamTotFood { get; set; }
    public double SamTotOil { get; set; }
    public double SamBaseNet { get; set; }
    public double SamUserNet { get; set; }
    public double SamTotNet { get; set; }
}