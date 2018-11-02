using System;

public class Spies
{
    public Spies(int spyCount, int spyLvl, int naSpyCount)
    {
        this.SpyCount = spyCount;
        this.SpyLvl = spyLvl;
        this.SpyBasePwr = 5;
        this.SpyBaseCost = 0.2;
        this.SpyBaseFood = 0.0055;
        this.SpyBaseOil = 0.001;
        this.SpyBaseNet = .49;

        this.SpyUserPwr = Math.Round(this.SpyBasePwr + (this.SpyBasePwr / 10 * (this.SpyLvl - 1)), 3);
        this.SpyUserCost = Math.Round(this.SpyBaseCost + (this.SpyBaseCost / 10 * (this.SpyLvl - 1)), 5);
        this.SpyUserFood = Math.Round(this.SpyBaseFood + (this.SpyBaseFood / 10 * (this.SpyLvl - 1)), 5);
        this.SpyUserOil = Math.Round(this.SpyBaseOil + (this.SpyBaseOil / 10 * (this.SpyLvl - 1)), 5);
        this.SpyUserNet = Math.Round(this.SpyBaseNet + (this.SpyBaseNet / 10 * (this.SpyLvl - 1)), 5);
        this.NaSpyCount = naSpyCount;
        if (this.SpyCount <= this.NaSpyCount)
        {
            this.NaSpyPwr = Math.Round((this.SpyCount / 2) * this.SpyUserPwr, 2);
        }
        else
        {
            this.NaSpyPwr = Math.Round((this.NaSpyCount / 2) * this.SpyUserPwr, 2);
        }
        this.SpyAttPwr = Math.Round(this.SpyCount * this.SpyUserPwr + this.NaSpyPwr, 2);
        this.SpyTotCost = this.SpyCount * this.SpyUserCost;
        this.SpyTotFood = this.SpyCount * this.SpyUserFood;
        this.SpyTotOil = this.SpyCount * this.SpyUserOil;
        this.SpyTotNet = this.SpyCount * this.SpyUserNet;
    }

    public int SpyCount { get; set; }
    public int SpyLvl { get; set; }
    public double SpyBasePwr { get; set; }
    public double SpyUserPwr { get; set; }
    public double SpyAttPwr { get; set; }
    public int NaSpyCount { get; set; }
    public double NaSpyPwr { get; set; }
    public double SpyBaseCost { get; set; }
    public double SpyUserCost { get; set; }
    public double SpyTotCost { get; set; }
    public double SpyBaseFood { get; set; }
    public double SpyUserFood { get; set; }
    public double SpyTotFood { get; set; }
    public double SpyBaseOil { get; set; }
    public double SpyUserOil { get; set; }
    public double SpyTotOil { get; set; }
    public double SpyBaseNet { get; set; }
    public double SpyUserNet { get; set; }
    public double SpyTotNet { get; set; }
}