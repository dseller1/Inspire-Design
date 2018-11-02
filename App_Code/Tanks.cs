using System;


public class Tanks
{
    public Tanks(int tankCount, int tankLvl, int naTankCount)
    {
        this.TankCount = tankCount;
        this.TankLvl = tankLvl;
        this.TankBasePwr = 5;
        this.TankBaseCost = 0.2;
        this.TankBaseFood = 0.002;
        this.TankBaseOil = 0.0025;
        this.TankBaseNet = .72;

        this.TankUserPwr = Math.Round(this.TankBasePwr + (this.TankBasePwr / 10 * (this.TankLvl - 1)), 3);
        this.TankUserCost = Math.Round(this.TankBaseCost + (this.TankBaseCost / 10 * (this.TankLvl - 1)), 5);
        this.TankUserFood = Math.Round(this.TankBaseFood + (this.TankBaseFood / 10 * (this.TankLvl - 1)), 5);
        this.TankUserOil = Math.Round(this.TankBaseOil + (this.TankBaseOil / 10 * (this.TankLvl - 1)), 5);
        this.TankUserNet = Math.Round(this.TankBaseNet + (this.TankBaseNet / 10 * (this.TankLvl - 1)), 5);
        this.NaTankCount = naTankCount;
        if (this.TankCount <= this.NaTankCount)
        {
            this.NaTankPwr = Math.Round((this.TankCount / 2) * this.TankUserPwr, 2);
        }
        else
        {
            this.NaTankPwr = Math.Round((this.NaTankCount / 2) * this.TankUserPwr, 2);
        }
        this.TankAttPwr = Math.Round(this.TankCount * this.TankUserPwr + this.NaTankPwr, 2);
        this.TankTotCost = this.TankCount * this.TankUserCost;
        this.TankTotFood = this.TankCount * this.TankUserFood;
        this.TankTotOil = this.TankCount * this.TankUserOil;
        this.TankTotNet = this.TankCount * this.TankUserNet;
    }

    public int TankCount { get; set; }
    public int TankLvl { get; set; }
    public double TankBasePwr { get; set; }
    public double TankUserPwr { get; set; }
    public double TankAttPwr { get; set; }
    public int NaTankCount { get; set; }
    public double NaTankPwr { get; set; }
    public double TankBaseCost { get; set; }
    public double TankUserCost { get; set; }
    public double TankBaseFood { get; set; }
    public double TankUserFood { get; set; }
    public double TankBaseOil { get; set; }
    public double TankUserOil { get; set; }
    public double TankTotCost { get; set; }
    public double TankTotFood { get; set; }
    public double TankTotOil { get; set; }
    public double TankBaseNet { get; set; }
    public double TankUserNet { get; set; }
    public double TankTotNet { get; set; }
}
