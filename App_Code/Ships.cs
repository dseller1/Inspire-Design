using System;

public class Ships
{
    public Ships(int shipCount, int shipLvl, int naShipCount)
    {
        this.ShipCount = shipCount;
        this.ShipLvl = shipLvl;
        this.ShipBasePwr = 7;
        this.ShipBaseCost = 0.5;
        this.ShipBaseFood = 0.0075;
        this.ShipBaseOil = 0.0075;
        this.ShipBaseNet = 1.29;

        this.ShipUserPwr = Math.Round(this.ShipBasePwr + (this.ShipBasePwr / 10 * (this.ShipLvl - 1)), 3);
        this.ShipUserCost = Math.Round(this.ShipBaseCost + (this.ShipBaseCost / 10 * (this.ShipLvl - 1)), 5);
        this.ShipUserFood = Math.Round(this.ShipBaseFood + (this.ShipBaseFood / 10 * (this.ShipLvl - 1)), 5);
        this.ShipUserOil = Math.Round(this.ShipBaseOil + (this.ShipBaseOil / 10 * (this.ShipLvl - 1)), 5);
        this.ShipUserNet = Math.Round(this.ShipBaseNet + (this.ShipBaseNet / 10 * (this.ShipLvl - 1)), 5);
        this.NaShipCount = naShipCount;
        if (this.ShipCount <= this.NaShipCount)
        {
            this.NaShipPwr = Math.Round((this.ShipCount / 2) * this.ShipUserPwr, 2);
        }
        else
        {
            this.NaShipPwr = Math.Round((this.NaShipCount / 2) * this.ShipUserPwr, 2);
        }
        this.ShipAttPwr = Math.Round(this.ShipCount * this.ShipUserPwr + this.NaShipPwr, 2);
        this.ShipTotCost = this.ShipCount * this.ShipUserCost;
        this.ShipTotFood = this.ShipCount * this.ShipUserFood;
        this.ShipTotOil = this.ShipCount * this.ShipUserOil;
        this.ShipTotNet = this.ShipCount * this.ShipUserNet;
    }

    public int ShipCount { get; set; }
    public int ShipLvl { get; set; }
    public double ShipBasePwr { get; set; }
    public double ShipUserPwr { get; set; }
    public double ShipAttPwr { get; set; }
    public int NaShipCount { get; set; }
    public double NaShipPwr { get; set; }
    public double ShipBaseCost { get; set; }
    public double ShipUserCost { get; set; }
    public double ShipBaseFood { get; set; }
    public double ShipUserFood { get; set; }
    public double ShipBaseOil { get; set; }
    public double ShipUserOil { get; set; }
    public double ShipTotCost { get; set; }
    public double ShipTotFood { get; set; }
    public double ShipTotOil { get; set; }
    public double ShipBaseNet { get; set; }
    public double ShipUserNet { get; set; }
    public double ShipTotNet { get; set; }
}