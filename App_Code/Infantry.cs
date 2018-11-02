using System;

public class Infantry
{
    public Infantry(int infCount, int infLvl, int naInfCount)
    {
        this.InfCount = infCount;
        this.InfLvl = infLvl;
        this.InfBasePwr = 0.85;
        this.InfBaseCost = 0.02;
        this.InfBaseFood = 0.0005;
        this.InfBaseOil = 0.0002;
        this.InfBaseNet = .1;

        this.InfUserPwr = Math.Round(this.InfBasePwr + (this.InfBasePwr / 10 * (this.InfLvl - 1)), 3);
        this.InfUserCost = Math.Round(this.InfBaseCost + (this.InfBaseCost / 10 * (this.InfLvl - 1)), 5);
        this.InfUserFood = Math.Round(this.InfBaseFood + (this.InfBaseFood / 10 * (this.InfLvl - 1)), 5);
        this.InfUserOil = Math.Round(this.InfBaseOil + (this.InfBaseOil / 10 * (this.InfLvl - 1)), 5);
        this.InfUserNet = Math.Round(this.InfBaseNet + (this.InfBaseNet / 10 * (this.InfLvl - 1)), 5);
        this.NaInfCount = naInfCount;
        if (this.InfCount <= this.NaInfCount)
        {
            this.NaInfPwr = Math.Round((this.InfCount / 2) * this.InfUserPwr, 2);
        }
        else
        {
            this.NaInfPwr = Math.Round((this.NaInfCount / 2) * this.InfUserPwr, 2);
        }
        this.InfAttPwr = Math.Round(this.InfCount * this.InfUserPwr + this.NaInfPwr, 2);
        this.InfTotCost = this.InfCount * this.InfUserCost;
        this.InfTotFood = this.InfCount * this.InfUserFood;
        this.InfTotOil = this.InfCount * this.InfUserOil;
        this.InfTotNet = this.InfCount * this.InfUserNet;
    }

    public int InfCount { get; set; }
    public int InfLvl { get; set; }
    public double InfBasePwr { get; set; }
    public double InfUserPwr { get; set; }
    public double InfAttPwr { get;set; }
    public int NaInfCount { get; set; }
    public double NaInfPwr { get; set; }
    public double InfBaseCost { get; set; }
    public double InfUserCost { get; set; }
    public double InfBaseFood { get; set; }
    public double InfUserFood { get; set; }
    public double InfBaseOil { get; set; }
    public double InfUserOil { get; set; }
    public double InfTotCost { get; set; }
    public double InfTotFood { get; set; }
    public double InfTotOil { get; set; }
    public double InfBaseNet { get; set; }
    public double InfUserNet { get; set; }
    public double InfTotNet { get; set; }
}