using Nation_Wars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WarAttacks : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnWarReCalculate_Click(object sender, EventArgs e)
    {
        FillWarEnemyInformation(sender, true);
    }

    protected void btnWarCalculate_Click(object sender, EventArgs e)
    {
        FillWarEnemyInformation(sender, false);
        defWarArmyInfo.ReadOnly = true;
        btnWarCalculate.Visible = false;
        btnWarReCalculate.Visible = true;
    }
    public void FillWarEnemyInformation(object sender, Boolean recalculate = false)
    {
        if (defWarArmyInfo.Text.Length > 0)
        {

            string str = defWarArmyInfo.Text;
            Regex espRgx = new Regex("Espionage");
            Match match;

            match = espRgx.Match(str);
            if (match.Success)
            {
                try
                {
                    double readiness = 0;
                    if (!recalculate)
                    {
                        string segment;
                        Regex rgx = new Regex("[0-9]+\\.*[0-9]*\\.*[0-9]*");

                        int startChar;
                        int endChar;


                        // Find State Name and Cut String
                        string stateStr = "State: ";
                        startChar = str.IndexOf(stateStr);
                        string readyStr = "Readiness";
                        endChar = str.IndexOf(readyStr);
                        lblWarStateName.Text = str.Substring(startChar + stateStr.Length, endChar - startChar - stateStr.Length).Trim();
                        segment = str.Substring(endChar + readyStr.Length, str.Length - (endChar + readyStr.Length));

                        match = rgx.Match(segment);

                        #region Get Readiness
                        if (match.Success)
                        {
                            startChar = segment.IndexOf(match.Value);

                            if (tbWarEnemyReadiness.Text.Length > 0)
                            {
                                readiness = Convert.ToDouble(tbWarEnemyReadiness.Text.Replace("%", "").Trim()) / 100;
                                if (readiness == 0)
                                {
                                    tbWarEnemyReadiness.Text = "0%";
                                }
                                else
                                {
                                    tbWarEnemyReadiness.Text = readiness.ToString("###%");
                                }
                            }
                            else
                            {
                                readiness = Convert.ToDouble(match.Value.Replace(".", ",").Trim()) / 100;
                                tbWarEnemyReadiness.Text = readiness.ToString("###%");
                            }
                            segment = segment.Substring(startChar + match.Value.Length);
                            match = rgx.Match(segment);
                        }
                        #endregion

                        //Get to the troop info
                        startChar = str.IndexOf("Spies");
                        segment = str.Substring(startChar, (str.Length - startChar));
                        match = rgx.Match(segment);

                        #region Gather Enemy Spies Info
                        if (match.Success)
                        {
                            startChar = segment.IndexOf(match.Value);
                            tbWarDefSpyCount.Text = match.Value.Replace(".", ",").Trim();
                            segment = segment.Substring(startChar + match.Value.Length);
                            match = rgx.Match(segment);
                        }
                        if (match.Success)
                        {
                            startChar = segment.IndexOf(match.Value);
                            tbWarDefNaSpyCount.Text = match.Value.Replace(".", ",").Trim();
                            segment = segment.Substring(startChar + match.Value.Length);
                            match = rgx.Match(segment);
                        }
                        if (match.Success)
                        {
                            startChar = segment.IndexOf(match.Value);
                            lblWarDefSpyLvl.Text = match.Value.Replace(".", ",").Trim();
                            segment = segment.Substring(startChar + match.Value.Length);
                            match = rgx.Match(segment);
                        }
                        #endregion

                        #region Gather Enemy Infantry Info
                        if (match.Success)
                        {
                            startChar = segment.IndexOf(match.Value);
                            tbWarDefInfCount.Text = match.Value.Replace(".", ",").Trim();
                            segment = segment.Substring(startChar + match.Value.Length);
                            match = rgx.Match(segment);
                        }
                        if (match.Success)
                        {
                            startChar = segment.IndexOf(match.Value);
                            tbWarDefNaInfCount.Text = match.Value.Replace(".", ",").Trim();
                            segment = segment.Substring(startChar + match.Value.Length);
                            match = rgx.Match(segment);
                        }
                        if (match.Success)
                        {
                            startChar = segment.IndexOf(match.Value);
                            lblWarDefInfLvl.Text = match.Value.Replace(".", ",").Trim();
                            segment = segment.Substring(startChar + match.Value.Length);
                            match = rgx.Match(segment);
                        }
                        #endregion

                        #region Gather Enemy Tanks Info
                        if (match.Success)
                        {
                            startChar = segment.IndexOf(match.Value);
                            tbWarDefTankCount.Text = match.Value.Replace(".", ",").Trim();
                            segment = segment.Substring(startChar + match.Value.Length);
                            match = rgx.Match(segment);
                        }
                        if (match.Success)
                        {
                            startChar = segment.IndexOf(match.Value);
                            tbWarDefNaTankCount.Text = match.Value.Replace(".", ",").Trim();
                            segment = segment.Substring(startChar + match.Value.Length);
                            match = rgx.Match(segment);
                        }
                        if (match.Success)
                        {
                            startChar = segment.IndexOf(match.Value);
                            lblWarDefTankLvl.Text = match.Value.Replace(".", ",").Trim();
                            segment = segment.Substring(startChar + match.Value.Length);
                            match = rgx.Match(segment);
                        }
                        #endregion

                        #region Gather Enemy Jets Info
                        if (match.Success)
                        {
                            startChar = segment.IndexOf(match.Value);
                            tbWarDefJetCount.Text = match.Value.Replace(".", ",").Trim();
                            segment = segment.Substring(startChar + match.Value.Length);
                            match = rgx.Match(segment);
                        }
                        if (match.Success)
                        {
                            startChar = segment.IndexOf(match.Value);
                            tbWarDefNaJetCount.Text = match.Value.Replace(".", ",").Trim();
                            segment = segment.Substring(startChar + match.Value.Length);
                            match = rgx.Match(segment);
                        }
                        if (match.Success)
                        {
                            startChar = segment.IndexOf(match.Value);
                            lblWarDefJetLvl.Text = match.Value.Replace(".", ",").Trim();
                            segment = segment.Substring(startChar + match.Value.Length);
                            match = rgx.Match(segment);
                        }
                        #endregion

                        #region Gather Enemy Bombers Info
                        if (match.Success)
                        {
                            startChar = segment.IndexOf(match.Value);
                            tbWarDefBombCount.Text = match.Value.Replace(".", ",").Trim();
                            segment = segment.Substring(startChar + match.Value.Length);
                            match = rgx.Match(segment);
                        }
                        if (match.Success)
                        {
                            startChar = segment.IndexOf(match.Value);
                            tbWarDefNaBombCount.Text = match.Value.Replace(".", ",").Trim();
                            segment = segment.Substring(startChar + match.Value.Length);
                            match = rgx.Match(segment);
                        }
                        if (match.Success)
                        {
                            startChar = segment.IndexOf(match.Value);
                            lblWarDefBombLvl.Text = match.Value.Replace(".", ",").Trim();
                            segment = segment.Substring(startChar + match.Value.Length);
                            match = rgx.Match(segment);
                        }
                        #endregion

                        #region Gather Enemy SAMS Info
                        if (match.Success)
                        {
                            startChar = segment.IndexOf(match.Value);
                            tbWarDefSamCount.Text = match.Value.Replace(".", ",").Trim();
                            segment = segment.Substring(startChar + match.Value.Length);
                            match = rgx.Match(segment);
                        }
                        if (match.Success)
                        {
                            startChar = segment.IndexOf(match.Value);
                            tbWarDefNaSamCount.Text = match.Value.Replace(".", ",").Trim();
                            segment = segment.Substring(startChar + match.Value.Length);
                            match = rgx.Match(segment);
                        }
                        if (match.Success)
                        {
                            startChar = segment.IndexOf(match.Value);
                            lblWarDefSamLvl.Text = match.Value.Replace(".", ",").Trim();
                            segment = segment.Substring(startChar + match.Value.Length);
                            match = rgx.Match(segment);
                        }
                        #endregion

                        #region Gather Enemy Ships Info
                        if (match.Success)
                        {
                            startChar = segment.IndexOf(match.Value);
                            tbWarDefShipCount.Text = match.Value.Replace(".", ",").Trim();
                            segment = segment.Substring(startChar + match.Value.Length);
                            match = rgx.Match(segment);
                        }
                        if (match.Success)
                        {
                            startChar = segment.IndexOf(match.Value);
                            tbWarDefNaShipCount.Text = match.Value.Replace(".", ",").Trim();
                            segment = segment.Substring(startChar + match.Value.Length);
                            match = rgx.Match(segment);
                        }
                        if (match.Success)
                        {
                            startChar = segment.IndexOf(match.Value);
                            lblWarDefShipLvl.Text = match.Value.Replace(".", ",").Trim();
                            segment = segment.Substring(startChar + match.Value.Length);
                            match = rgx.Match(segment);
                        }
                        #endregion
                    }
                    else
                    {
                        tbWarDefSpyCount.Text = Convert.ToInt32(tbWarDefSpyCount.Text.Replace(",", "").Insert(0, "0")).ToString("#,##0");
                        tbWarDefNaSpyCount.Text = Convert.ToInt32(tbWarDefNaSpyCount.Text.Replace(",", "").Insert(0, "0")).ToString("#,##0");
                        tbWarDefInfCount.Text = Convert.ToInt32(tbWarDefInfCount.Text.Replace(",", "").Insert(0, "0")).ToString("#,##0");
                        tbWarDefNaInfCount.Text = Convert.ToInt32(tbWarDefNaInfCount.Text.Replace(",", "").Insert(0, "0")).ToString("#,##0");
                        tbWarDefTankCount.Text = Convert.ToInt32(tbWarDefTankCount.Text.Replace(",", "").Insert(0, "0")).ToString("#0");
                        tbWarDefNaTankCount.Text = Convert.ToInt32(tbWarDefNaTankCount.Text.Replace(",", "").Insert(0, "0")).ToString("#,##0");
                        tbWarDefJetCount.Text = Convert.ToInt32(tbWarDefJetCount.Text.Replace(",", "").Insert(0, "0")).ToString("#,##0");
                        tbWarDefNaJetCount.Text = Convert.ToInt32(tbWarDefNaJetCount.Text.Replace(",", "").Insert(0, "0")).ToString("#,##0");
                        tbWarDefBombCount.Text = Convert.ToInt32(tbWarDefBombCount.Text.Replace(",", "").Insert(0, "0")).ToString("#,##0");
                        tbWarDefNaBombCount.Text = Convert.ToInt32(tbWarDefNaBombCount.Text.Replace(",", "").Insert(0, "0")).ToString("#,##0");
                        tbWarDefSamCount.Text = Convert.ToInt32(tbWarDefSamCount.Text.Replace(",", "").Insert(0, "0")).ToString("#,##0");
                        tbWarDefNaSamCount.Text = Convert.ToInt32(tbWarDefNaSamCount.Text.Replace(",", "").Insert(0, "0")).ToString("#,##0");
                        tbWarDefShipCount.Text = Convert.ToInt32(tbWarDefShipCount.Text.Replace(",", "").Insert(0, "0")).ToString("#,##0");
                        tbWarDefNaShipCount.Text = Convert.ToInt32(tbWarDefNaShipCount.Text.Replace(",", "").Insert(0, "0")).ToString("#,##0");
                        readiness = Convert.ToDouble(tbWarEnemyReadiness.Text.Replace("%", "").Trim()) / 100;
                        tbWarEnemyReadiness.Text = readiness.ToString("###%");
                    }

                    #region Create Enemy State

                    Spies spy = new Spies(Convert.ToInt32(tbWarDefSpyCount.Text.ToString().Replace(",", "")), Convert.ToInt32(lblWarDefSpyLvl.Text.ToString().Replace(",", "")), Convert.ToInt32(tbWarDefNaSpyCount.Text.ToString().Replace(",", "")));
                    Infantry inf = new Infantry(Convert.ToInt32(tbWarDefInfCount.Text.ToString().Replace(",", "")), Convert.ToInt32(lblWarDefInfLvl.Text.ToString().Replace(",", "")), Convert.ToInt32(tbWarDefNaInfCount.Text.ToString().Replace(",", "")));
                    Tanks tank = new Tanks(Convert.ToInt32(tbWarDefTankCount.Text.ToString().Replace(",", "")), Convert.ToInt32(lblWarDefTankLvl.Text.ToString().Replace(",", "")), Convert.ToInt32(tbWarDefNaTankCount.Text.ToString().Replace(",", "")));
                    Jets jet = new Jets(Convert.ToInt32(tbWarDefJetCount.Text.ToString().Replace(",", "")), Convert.ToInt32(lblWarDefJetLvl.Text.ToString().Replace(",", "")), Convert.ToInt32(tbWarDefNaJetCount.Text.ToString().Replace(",", "")));
                    Bombers bomb = new Bombers(Convert.ToInt32(tbWarDefBombCount.Text.ToString().Replace(",", "")), Convert.ToInt32(lblWarDefBombLvl.Text.ToString().Replace(",", "")), Convert.ToInt32(tbWarDefNaBombCount.Text.ToString().Replace(",", "")));
                    Sams sam = new Sams(Convert.ToInt32(tbWarDefSamCount.Text.ToString().Replace(",", "")), Convert.ToInt32(lblWarDefSamLvl.Text.ToString().Replace(",", "")), Convert.ToInt32(tbWarDefNaSamCount.Text.ToString().Replace(",", "")));
                    Ships ship = new Ships(Convert.ToInt32(tbWarDefShipCount.Text.ToString().Replace(",", "")), Convert.ToInt32(lblWarDefShipLvl.Text.ToString().Replace(",", "")), Convert.ToInt32(tbWarDefNaShipCount.Text.ToString().Replace(",", "")));

                    State enemyState = new State(spy, inf, tank, jet, bomb, sam, ship);
                    enemyState.Readiness = readiness;
                    enemyState.UserDefPwr *= enemyState.Readiness;
                    enemyState.UserGADefPwr *= enemyState.Readiness;
                    enemyState.UserARDefPwr *= enemyState.Readiness;
                    enemyState.UserAADefPwr *= enemyState.Readiness;

                    if (enemyState.UserGADefPwr == 0)
                    {
                        lblWarGADefPwr.Text = "0";
                    }
                    else
                    {
                        lblWarGADefPwr.Text = enemyState.UserGADefPwr.ToString("###,###,###,###");
                    }

                    if (enemyState.UserARDefPwr == 0)
                    {
                        lblWarARDefPwr.Text = "0";
                    }
                    else
                    {
                        lblWarARDefPwr.Text = enemyState.UserARDefPwr.ToString("###,###,###,###");
                    }

                    if (enemyState.UserAADefPwr == 0)
                    {
                        lblWarAADefPwr.Text = "0";
                    }
                    else
                    {
                        lblWarAADefPwr.Text = enemyState.UserAADefPwr.ToString("###,###,###,###");
                    }
                    #endregion

                    if (defWarArmyInfo.Text.Length > 0)
                    {
                        calcWarBreaks();
                    }
                }
                catch
                {
                    //clearWarEnemyInfo();

                }
            }
            else
            {
                //clearWarEnemyInfo();
            }
        }
    }

    public void calcWarBreaks()
    {
        double tempGAEnemyPwr = Math.Round(Convert.ToInt64(lblWarGADefPwr.Text.ToString().Replace(",", "")) * 1.11, 2);
        double tempAREnemyPwr = Math.Round(Convert.ToInt64(lblWarARDefPwr.Text.ToString().Replace(",", "")) * 1.11, 2);
        double tempAAEnemyPwr = Math.Round(Convert.ToInt64(lblWarAADefPwr.Text.ToString().Replace(",", "")) * 1.11, 2);

        if (tempGAEnemyPwr == 0)
        {
            lblWarInfLvl1Count.Text = "1";
            lblWarInfLvl2Count.Text = "1";
            lblWarInfLvl3Count.Text = "1";
            lblWarInfLvl4Count.Text = "1";
            lblWarInfLvl5Count.Text = "1";
            lblWarInfLvl6Count.Text = "1";
            lblWarInfLvl7Count.Text = "1";
            lblWarInfLvl8Count.Text = "1";
            lblWarTankLvl1Count.Text = "1";
            lblWarTankLvl2Count.Text = "1";
            lblWarTankLvl3Count.Text = "1";
            lblWarTankLvl4Count.Text = "1";
            lblWarTankLvl5Count.Text = "1";
            lblWarTankLvl6Count.Text = "1";
            lblWarTankLvl7Count.Text = "1";
            lblWarTankLvl8Count.Text = "1";
        }
        else
        {
            calcGABreak(tempGAEnemyPwr);
        }
        if (tempAREnemyPwr == 0)
        {
            lblWarJetLvl1Count.Text = "1";
            lblWarJetLvl2Count.Text = "1";
            lblWarJetLvl3Count.Text = "1";
            lblWarJetLvl4Count.Text = "1";
            lblWarJetLvl5Count.Text = "1";
            lblWarJetLvl6Count.Text = "1";
            lblWarJetLvl7Count.Text = "1";
            lblWarJetLvl8Count.Text = "1";
            lblWarJetLvl12Count.Text = "1";
            lblWarBombLvl1Count.Text = "1";
            lblWarBombLvl2Count.Text = "1";
            lblWarBombLvl3Count.Text = "1";
            lblWarBombLvl4Count.Text = "1";
            lblWarBombLvl5Count.Text = "1";
            lblWarBombLvl6Count.Text = "1";
            lblWarBombLvl7Count.Text = "1";
            lblWarBombLvl8Count.Text = "1";
            lblWarBombLvl12Count.Text = "1";
        }
        else
        {
            calcARBreak(tempAREnemyPwr);
        }
        if (tempAAEnemyPwr == 0)
        {
            lblWarShipLvl1Count.Text = "1";
            lblWarShipLvl2Count.Text = "1";
            lblWarShipLvl3Count.Text = "1";
            lblWarShipLvl4Count.Text = "1";
            lblWarShipLvl5Count.Text = "1";
            lblWarShipLvl6Count.Text = "1";
            lblWarShipLvl7Count.Text = "1";
            lblWarShipLvl8Count.Text = "1";
        }
        else
        {
            calcAABreak(tempAAEnemyPwr);
        }
    }

    public void calcGABreak(double tempGADefPwr)
    {
        Infantry inf = new Infantry(0, 1, 0);
        lblWarInfLvl1Count.Text = Math.Round(Math.Ceiling((tempGADefPwr / inf.InfUserPwr)) / 1.5, 0).ToString("###,###,###,###");
        inf = new Infantry(0, 2, 0);
        lblWarInfLvl2Count.Text = Math.Round(Math.Ceiling((tempGADefPwr / inf.InfUserPwr)) / 1.5, 0).ToString("###,###,###,###");
        inf = new Infantry(0, 3, 0);
        lblWarInfLvl3Count.Text = Math.Round(Math.Ceiling((tempGADefPwr / inf.InfUserPwr)) / 1.5, 0).ToString("###,###,###,###");
        inf = new Infantry(0, 4, 0);
        lblWarInfLvl4Count.Text = Math.Round(Math.Ceiling((tempGADefPwr / inf.InfUserPwr)) / 1.5, 0).ToString("###,###,###,###");
        inf = new Infantry(0, 5, 0);
        lblWarInfLvl5Count.Text = Math.Round(Math.Ceiling((tempGADefPwr / inf.InfUserPwr)) / 1.5, 0).ToString("###,###,###,###");
        inf = new Infantry(0, 6, 0);
        lblWarInfLvl6Count.Text = Math.Round(Math.Ceiling((tempGADefPwr / inf.InfUserPwr)) / 1.5, 0).ToString("###,###,###,###");
        inf = new Infantry(0, 7, 0);
        lblWarInfLvl7Count.Text = Math.Round(Math.Ceiling((tempGADefPwr / inf.InfUserPwr)) / 1.5, 0).ToString("###,###,###,###");
        inf = new Infantry(0, 8, 0);
        lblWarInfLvl8Count.Text = Math.Round(Math.Ceiling((tempGADefPwr / inf.InfUserPwr)) / 1.5, 0).ToString("###,###,###,###");

        Tanks tank = new Tanks(0, 1, 0);
        lblWarTankLvl1Count.Text = Math.Round(Math.Ceiling((tempGADefPwr / tank.TankUserPwr)) / 1.5, 0).ToString("###,###,###,###");
        tank = new Tanks(0, 2, 0);
        lblWarTankLvl2Count.Text = Math.Round(Math.Ceiling((tempGADefPwr / tank.TankUserPwr)) / 1.5, 0).ToString("###,###,###,###");
        tank = new Tanks(0, 3, 0);
        lblWarTankLvl3Count.Text = Math.Round(Math.Ceiling((tempGADefPwr / tank.TankUserPwr)) / 1.5, 0).ToString("###,###,###,###");
        tank = new Tanks(0, 4, 0);
        lblWarTankLvl4Count.Text = Math.Round(Math.Ceiling((tempGADefPwr / tank.TankUserPwr)) / 1.5, 0).ToString("###,###,###,###");
        tank = new Tanks(0, 5, 0);
        lblWarTankLvl5Count.Text = Math.Round(Math.Ceiling((tempGADefPwr / tank.TankUserPwr)) / 1.5, 0).ToString("###,###,###,###");
        tank = new Tanks(0, 6, 0);
        lblWarTankLvl6Count.Text = Math.Round(Math.Ceiling((tempGADefPwr / tank.TankUserPwr)) / 1.5, 0).ToString("###,###,###,###");
        tank = new Tanks(0, 7, 0);
        lblWarTankLvl7Count.Text = Math.Round(Math.Ceiling((tempGADefPwr / tank.TankUserPwr)) / 1.5, 0).ToString("###,###,###,###");
        tank = new Tanks(0, 8, 0);
        lblWarTankLvl8Count.Text = Math.Round(Math.Ceiling((tempGADefPwr / tank.TankUserPwr)) / 1.5, 0).ToString("###,###,###,###");
    }

    public void calcARBreak(double tempARDefPwr)
    {
        Jets jet = new Jets(0, 1, 0);
        lblWarJetLvl1Count.Text = Math.Round(Math.Ceiling((tempARDefPwr / jet.JetUserPwr)) / 1.5, 0).ToString("###,###,###,###");
        jet = new Jets(0, 2, 0);
        lblWarJetLvl2Count.Text = Math.Round(Math.Ceiling((tempARDefPwr / jet.JetUserPwr)) / 1.5, 0).ToString("###,###,###,###");
        jet = new Jets(0, 3, 0);
        lblWarJetLvl3Count.Text = Math.Round(Math.Ceiling((tempARDefPwr / jet.JetUserPwr)) / 1.5, 0).ToString("###,###,###,###");
        jet = new Jets(0, 4, 0);
        lblWarJetLvl4Count.Text = Math.Round(Math.Ceiling((tempARDefPwr / jet.JetUserPwr)) / 1.5, 0).ToString("###,###,###,###");
        jet = new Jets(0, 5, 0);
        lblWarJetLvl5Count.Text = Math.Round(Math.Ceiling((tempARDefPwr / jet.JetUserPwr)) / 1.5, 0).ToString("###,###,###,###");
        jet = new Jets(0, 6, 0);
        lblWarJetLvl6Count.Text = Math.Round(Math.Ceiling((tempARDefPwr / jet.JetUserPwr)) / 1.5, 0).ToString("###,###,###,###");
        jet = new Jets(0, 7, 0);
        lblWarJetLvl7Count.Text = Math.Round(Math.Ceiling((tempARDefPwr / jet.JetUserPwr)) / 1.5, 0).ToString("###,###,###,###");
        jet = new Jets(0, 8, 0);
        lblWarJetLvl8Count.Text = Math.Round(Math.Ceiling((tempARDefPwr / jet.JetUserPwr)) / 1.5, 0).ToString("###,###,###,###");
        jet = new Jets(0, 12, 0);
        lblWarJetLvl12Count.Text = Math.Round(Math.Ceiling((tempARDefPwr / jet.JetUserPwr)) / 1.5, 0).ToString("###,###,###,###");

        Bombers bomber = new Bombers(0, 1, 0);
        lblWarBombLvl1Count.Text = Math.Round(Math.Ceiling((tempARDefPwr / bomber.BombUserPwr)) / 1.5, 0).ToString("###,###,###,###");
        bomber = new Bombers(0, 2, 0);
        lblWarBombLvl2Count.Text = Math.Round(Math.Ceiling((tempARDefPwr / bomber.BombUserPwr)) / 1.5, 0).ToString("###,###,###,###");
        bomber = new Bombers(0, 3, 0);
        lblWarBombLvl3Count.Text = Math.Round(Math.Ceiling((tempARDefPwr / bomber.BombUserPwr)) / 1.5, 0).ToString("###,###,###,###");
        bomber = new Bombers(0, 4, 0);
        lblWarBombLvl4Count.Text = Math.Round(Math.Ceiling((tempARDefPwr / bomber.BombUserPwr)) / 1.5, 0).ToString("###,###,###,###");
        bomber = new Bombers(0, 5, 0);
        lblWarBombLvl5Count.Text = Math.Round(Math.Ceiling((tempARDefPwr / bomber.BombUserPwr)) / 1.5, 0).ToString("###,###,###,###");
        bomber = new Bombers(0, 6, 0);
        lblWarBombLvl6Count.Text = Math.Round(Math.Ceiling((tempARDefPwr / bomber.BombUserPwr)) / 1.5, 0).ToString("###,###,###,###");
        bomber = new Bombers(0, 7, 0);
        lblWarBombLvl7Count.Text = Math.Round(Math.Ceiling((tempARDefPwr / bomber.BombUserPwr)) / 1.5, 0).ToString("###,###,###,###");
        bomber = new Bombers(0, 8, 0);
        lblWarBombLvl8Count.Text = Math.Round(Math.Ceiling((tempARDefPwr / bomber.BombUserPwr)) / 1.5, 0).ToString("###,###,###,###");
        bomber = new Bombers(0, 12, 0);
        lblWarBombLvl12Count.Text = Math.Round(Math.Ceiling((tempARDefPwr / bomber.BombUserPwr)) / 1.5, 0).ToString("###,###,###,###");
    }

    public void calcAABreak(double tempAADefPwr)
    {
        Ships ship = new Ships(0, 1, 0);
        lblWarShipLvl1Count.Text = Math.Round(Math.Ceiling((tempAADefPwr / ship.ShipUserPwr)) / 1.5, 0).ToString("###,###,###,###");
        ship = new Ships(0, 2, 0);
        lblWarShipLvl2Count.Text = Math.Round(Math.Ceiling((tempAADefPwr / ship.ShipUserPwr)) / 1.5, 0).ToString("###,###,###,###");
        ship = new Ships(0, 3, 0);
        lblWarShipLvl3Count.Text = Math.Round(Math.Ceiling((tempAADefPwr / ship.ShipUserPwr)) / 1.5, 0).ToString("###,###,###,###");
        ship = new Ships(0, 4, 0);
        lblWarShipLvl4Count.Text = Math.Round(Math.Ceiling((tempAADefPwr / ship.ShipUserPwr)) / 1.5, 0).ToString("###,###,###,###");
        ship = new Ships(0, 5, 0);
        lblWarShipLvl5Count.Text = Math.Round(Math.Ceiling((tempAADefPwr / ship.ShipUserPwr)) / 1.5, 0).ToString("###,###,###,###");
        ship = new Ships(0, 6, 0);
        lblWarShipLvl6Count.Text = Math.Round(Math.Ceiling((tempAADefPwr / ship.ShipUserPwr)) / 1.5, 0).ToString("###,###,###,###");
        ship = new Ships(0, 7, 0);
        lblWarShipLvl7Count.Text = Math.Round(Math.Ceiling((tempAADefPwr / ship.ShipUserPwr)) / 1.5, 0).ToString("###,###,###,###");
        ship = new Ships(0, 8, 0);
        lblWarShipLvl8Count.Text = Math.Round(Math.Ceiling((tempAADefPwr / ship.ShipUserPwr)) / 1.5, 0).ToString("###,###,###,###");
    }

    public void clearWarEnemyInfo()
    {
        defWarArmyInfo.Text = "";
    }

    public void clearWarEnemyLabels()
    {
        lblWarStateName.Text = "";
        tbWarDefSpyCount.Text = "";
        tbWarDefNaSpyCount.Text = "";
        lblWarDefSpyLvl.Text = "";
        tbWarDefInfCount.Text = "";
        tbWarDefNaInfCount.Text = "";
        lblWarDefInfLvl.Text = "";
        tbWarDefTankCount.Text = "";
        tbWarDefNaTankCount.Text = "";
        lblWarDefTankLvl.Text = "";
        tbWarDefJetCount.Text = "";
        tbWarDefNaJetCount.Text = "";
        lblWarDefJetLvl.Text = "";
        tbWarDefBombCount.Text = "";
        tbWarDefNaBombCount.Text = "";
        lblWarDefBombLvl.Text = "";
        tbWarDefSamCount.Text = "";
        tbWarDefNaSamCount.Text = "";
        lblWarDefSamLvl.Text = "";
        tbWarDefShipCount.Text = "";
        tbWarDefNaShipCount.Text = "";
        lblWarDefShipLvl.Text = "";
        tbWarEnemyReadiness.Text = "";
        lblWarInfLvl1Count.Text = "";
        lblWarTankLvl1Count.Text = "";
        lblWarJetLvl1Count.Text = "";
        lblWarBombLvl1Count.Text = "";
        lblWarShipLvl1Count.Text = "";
        lblWarInfLvl2Count.Text = "";
        lblWarTankLvl2Count.Text = "";
        lblWarJetLvl2Count.Text = "";
        lblWarBombLvl2Count.Text = "";
        lblWarShipLvl2Count.Text = "";
        lblWarInfLvl3Count.Text = "";
        lblWarTankLvl3Count.Text = "";
        lblWarJetLvl3Count.Text = "";
        lblWarBombLvl3Count.Text = "";
        lblWarShipLvl3Count.Text = "";
        lblWarInfLvl4Count.Text = "";
        lblWarTankLvl4Count.Text = "";
        lblWarJetLvl4Count.Text = "";
        lblWarBombLvl4Count.Text = "";
        lblWarShipLvl4Count.Text = "";
        lblWarInfLvl5Count.Text = "";
        lblWarTankLvl5Count.Text = "";
        lblWarJetLvl5Count.Text = "";
        lblWarBombLvl5Count.Text = "";
        lblWarShipLvl5Count.Text = "";
        lblWarInfLvl6Count.Text = "";
        lblWarTankLvl6Count.Text = "";
        lblWarJetLvl6Count.Text = "";
        lblWarBombLvl6Count.Text = "";
        lblWarShipLvl6Count.Text = "";
        lblWarInfLvl7Count.Text = "";
        lblWarTankLvl7Count.Text = "";
        lblWarJetLvl7Count.Text = "";
        lblWarBombLvl7Count.Text = "";
        lblWarShipLvl7Count.Text = "";
        lblWarInfLvl8Count.Text = "";
        lblWarTankLvl8Count.Text = "";
        lblWarJetLvl8Count.Text = "";
        lblWarBombLvl8Count.Text = "";
        lblWarShipLvl8Count.Text = "";
        lblWarJetLvl12Count.Text = "";
        lblWarBombLvl12Count.Text = "";
        lblWarGADefPwr.Text = "";
        lblWarARDefPwr.Text = "";
        lblWarAADefPwr.Text = "";

    }

    protected void defWarClearBtn_Click(object sender, EventArgs e)
    {
        clearWarEnemyInfo();
        clearWarEnemyLabels();
        btnWarCalculate.Visible = true;
        btnWarReCalculate.Visible = false;
        defWarArmyInfo.ReadOnly = false;
    }
}