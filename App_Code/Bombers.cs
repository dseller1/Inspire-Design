using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Bombers
{
    public Bombers(int bombCount, int bombLvl, int naBombCount)
    {
        this.BombCount = bombCount;
        this.BombLvl = bombLvl;
        this.BombBasePwr = 5;
        this.BombBaseCost = 0.15;
        this.BombBaseFood = 0.003;
        this.BombBaseOil = 0.004;
        this.BombBaseNet = .6;

        this.BombUserPwr = Math.Round(this.BombBasePwr + (this.BombBasePwr / 10 * (this.BombLvl - 1)), 3);
        this.BombUserCost = Math.Round(this.BombBaseCost + (this.BombBaseCost / 10 * (this.BombLvl - 1)), 5);
        this.BombUserFood = Math.Round(this.BombBaseFood + (this.BombBaseFood / 10 * (this.BombLvl - 1)), 5);
        this.BombUserOil = Math.Round(this.BombBaseOil + (this.BombBaseOil / 10 * (this.BombLvl - 1)), 5);
        this.BombUserNet = Math.Round(this.BombBaseNet + (this.BombBaseNet / 10 * (this.BombLvl - 1)), 5);
        this.NaBombCount = naBombCount;
        if (this.BombCount <= this.NaBombCount)
        {
            this.NaBombPwr = Math.Round((this.BombCount / 2) * this.BombUserPwr, 2);
        }
        else
        {
            this.NaBombPwr = Math.Round((this.NaBombCount / 2) * this.BombUserPwr, 2);
        }
        this.BombAttPwr = Math.Round(this.BombCount * this.BombUserPwr + this.NaBombPwr, 2);
        this.BombTotCost = this.BombCount * this.BombUserCost;
        this.BombTotFood = this.BombCount * this.BombUserFood;
        this.BombTotOil = this.BombCount * this.BombUserOil;
        this.BombTotNet = this.BombCount * this.BombUserNet;
    }

    public int BombCount { get; set; }
    public int BombLvl { get; set; }
    public double BombBasePwr { get; set; }
    public double BombUserPwr { get; set; }
    public double BombAttPwr { get; set; }
    public int NaBombCount { get; set; }
    public double NaBombPwr { get; set; }
    public double BombBaseCost { get; set; }
    public double BombUserCost { get; set; }
    public double BombBaseFood { get; set; }
    public double BombUserFood { get; set; }
    public double BombBaseOil { get; set; }
    public double BombUserOil { get; set; }
    public double BombTotCost { get; set; }
    public double BombTotFood { get; set; }
    public double BombTotOil { get; set; }
    public double BombBaseNet { get; set; }
    public double BombUserNet { get; set; }
    public double BombTotNet { get; set; }
}