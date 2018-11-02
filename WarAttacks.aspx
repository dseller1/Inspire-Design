<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WarAttacks.aspx.cs" MasterPageFile="MasterPage.master" Inherits="WarAttacks" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div aria-orientation="vertical">
        <div aria-orientation="horizontal">
            <div aria-orientation="vertical">
                <div aria-orientation="horizontal">
                    <asp:Label runat="server" Text="Paste Espionage Info" Width="155" />
                    <asp:TextBox runat="server" ID="defWarArmyInfo" CssClass="TextBox" Width="100" />
                    <asp:Button runat="server" ID="defWarClearBtn" Background="GhostWhite" Text="Clear" OnClick="defWarClearBtn_Click" CssClass="Button" />
                    <asp:Button runat="server" ID="btnWarCalculate" Background="GhostWhite" Text="Calculate" OnClick="btnWarCalculate_Click" CssClass="Button" />
                </div>
                <div aria-orientation="horizontal">
                    <asp:Label runat="server" ID="lblWarStateName" Height="26" FontWeight="Bold" />
                </div>
                <div aria-orientation="horizontal">
                    <asp:Label runat="server" Style="margin-left: 80px;" Text="Enemy Army" Width="100" />
                    <asp:Label runat="server" Style="margin-left: 5px;" Text="Nation Army" Width="100" />
                </div>
                <div aria-orientation="horizontal">
                    <asp:Label runat="server" Text="Spies: " Width="70" />
                    <asp:TextBox runat="server" ID="tbWarDefSpyCount" Height="20" Width="100" CssClass="TextBox" />
                    <asp:TextBox runat="server" ID="tbWarDefNaSpyCount" Height="20" Width="100" CssClass="TextBox" />
                    <asp:Label runat="server" Text="Level: " Margin="5,0,0,0" Width="40" />
                    <asp:Label runat="server" ID="lblWarDefSpyLvl" Width="30" HorizontalAlignment="Center" />
                </div>
                <div aria-orientation="horizontal">
                    <asp:Label runat="server" Text="Infantry: " Width="70" />
                    <asp:TextBox runat="server" ID="tbWarDefInfCount" Height="20" Width="100" CssClass="TextBox" />
                    <asp:TextBox runat="server" ID="tbWarDefNaInfCount" Height="20" Width="100" CssClass="TextBox" />
                    <asp:Label runat="server" Text="Level: " Margin="5,0,0,0" Width="40" />
                    <asp:Label runat="server" ID="lblWarDefInfLvl" Width="30" HorizontalAlignment="Center" />
                </div>
                <div aria-orientation="horizontal">
                    <asp:Label runat="server" Text="Tanks: " Width="70" />
                    <asp:TextBox runat="server" ID="tbWarDefTankCount" Height="20" Width="100" CssClass="TextBox" />
                    <asp:TextBox runat="server" ID="tbWarDefNaTankCount" Height="20" Width="100" CssClass="TextBox" />
                    <asp:Label runat="server" Text="Level: " Margin="5,0,0,0" Width="40" />
                    <asp:Label runat="server" ID="lblWarDefTankLvl" Width="30" HorizontalAlignment="Center" />
                </div>
                <div aria-orientation="horizontal">
                    <asp:Label runat="server" Text="Jets: " Width="70" />
                    <asp:TextBox runat="server" ID="tbWarDefJetCount" Height="20" Width="100" CssClass="TextBox" />
                    <asp:TextBox runat="server" ID="tbWarDefNaJetCount" Height="20" Width="100" CssClass="TextBox" />
                    <asp:Label runat="server" Text="Level: " Margin="5,0,0,0" Width="40" />
                    <asp:Label runat="server" ID="lblWarDefJetLvl" Width="30" HorizontalAlignment="Center" />
                </div>
                <div aria-orientation="horizontal">
                    <asp:Label runat="server" Text="Bombers: " Width="70" />
                    <asp:TextBox runat="server" ID="tbWarDefBombCount" Height="20" Width="100" CssClass="TextBox" />
                    <asp:TextBox runat="server" ID="tbWarDefNaBombCount" Height="20" Width="100" CssClass="TextBox" />
                    <asp:Label runat="server" Text="Level: " Margin="5,0,0,0" Width="40" />
                    <asp:Label runat="server" ID="lblWarDefBombLvl" Width="30" HorizontalAlignment="Center" />
                </div>
                <div aria-orientation="horizontal">
                    <asp:Label runat="server" Text="SAMs: " Width="70" />
                    <asp:TextBox runat="server" ID="tbWarDefSamCount" Height="20" Width="100" CssClass="TextBox" />
                    <asp:TextBox runat="server" ID="tbWarDefNaSamCount" Height="20" Width="100" CssClass="TextBox" />
                    <asp:Label runat="server" Text="Level: " Margin="5,0,0,0" Width="40" />
                    <asp:Label runat="server" ID="lblWarDefSamLvl" Width="30" HorizontalAlignment="Center" />
                </div>
                <div aria-orientation="horizontal">
                    <asp:Label runat="server" Text="Ships: " Width="70" />
                    <asp:TextBox runat="server" ID="tbWarDefShipCount" Height="20" Width="100" CssClass="TextBox" />
                    <asp:TextBox runat="server" ID="tbWarDefNaShipCount" Height="20" Width="100" CssClass="TextBox" />
                    <asp:Label runat="server" Text="Level: " Margin="5,0,0,0" Width="40" />
                    <asp:Label runat="server" ID="lblWarDefShipLvl" Width="30" HorizontalAlignment="Center" />
                </div>
            </div>
        </div>
        <br />
        <div aria-orientation="vertical">
            <div aria-orientation="horizontal">
                <asp:Label runat="server" Text="Readiness:" HorizontalContentAlignment="Right" />
                <asp:TextBox runat="server" ID="tbWarEnemyReadiness" Background="GhostWhite" HorizontalAlignment="Center" VerticalAlignment="Center" MaxLength="4" Width="41" Height="20" />
            </div>
            <div aria-orientation="horizontal">
                <asp:Button runat="server" ID="btnWarReCalculate" Background="GhostWhite" Text="Recalculate" OnClick="btnWarReCalculate_Click" CssClass="Button" Visible="false" />
            </div>
            <br />
            <div>
                <div>
                    <asp:Label runat="server" Text="Assumes Full NA Coverage" Style="text-align: center;" HorizontalContentAlignment="Center" FontWeight="Bold" Foreground="Blue" FontSize="16" Width="855" />
                </div>
                <br />
                <div aria-orientation="horizontal">
                    <div>
                        <asp:Label runat="server" Text="GA Break" Style="text-align: center;" HorizontalContentAlignment="Center" FontWeight="Bold" Width="330" />
                        <asp:Label runat="server" Text="AR Break" Style="text-align: center;" HorizontalContentAlignment="Center" FontWeight="Bold" Width="330" />
                        <asp:Label runat="server" Text="AA Break" Style="text-align: center;" HorizontalContentAlignment="Center" FontWeight="Bold" Width="195" />
                        <div aria-orientation="horizontal">
                            <asp:Label runat="server" Text="Attack Power: " Width="100" Style="margin-left: 68px;"></asp:Label>
                            <asp:Label runat="server" ID="lblWarGADefPwr" HorizontalContentAlignment="Left" Width="95" />
                            <asp:Label runat="server" Text="Attack Power: " Width="100" Style="margin-left: 136px;"></asp:Label>
                            <asp:Label runat="server" ID="lblWarARDefPwr" HorizontalContentAlignment="Left" Width="95" />
                            <asp:Label runat="server" Text="Attack Power: " Width="100" Style="margin-left: 65px;"></asp:Label>
                            <asp:Label runat="server" ID="lblWarAADefPwr" HorizontalContentAlignment="Left" Width="95" />
                        </div>
                        <br />
                        <div aria-orientation="horizontal">
                            <div>
                                <asp:Label runat="server" Text="Infantry" HorizontalContentAlignment="Center" Width="163" />
                                <asp:Label runat="server" Text="Tanks" HorizontalContentAlignment="Center" Width="166" />
                                <asp:Label runat="server" Text="Jets" HorizontalContentAlignment="Center" Width="164" />
                                <asp:Label runat="server" Text="Bombers" HorizontalContentAlignment="Center" Width="164" />
                                <asp:Label runat="server" Text="Ships" HorizontalContentAlignment="Center" Width="164" />
                                <div aria-orientation="horizontal">
                                    <asp:Label runat="server" Text="Level 1:" HorizontalContentAlignment="Left" Width="65" />
                                    <asp:Label runat="server" ID="lblWarInfLvl1Count" Width="95" HorizontalContentAlignment="Left"/>
                                    <asp:Label runat="server" Text="Level 1:" HorizontalContentAlignment="Left" Width="65" />
                                    <asp:Label runat="server" ID="lblWarTankLvl1Count" Width="95" HorizontalContentAlignment="Left"/>
                                    <asp:Label runat="server" Text="Level 1:" HorizontalContentAlignment="Left" Width="65" />
                                    <asp:Label runat="server" ID="lblWarJetLvl1Count" Width="95" HorizontalContentAlignment="Left"  />
                                    <asp:Label runat="server" Text="Level 1:" HorizontalContentAlignment="Left" Width="65" />
                                    <asp:Label runat="server" ID="lblWarBombLvl1Count" Width="95" HorizontalContentAlignment="Left" />
                                    <asp:Label runat="server" Text="Level 1:" HorizontalContentAlignment="Left" Width="65" />
                                    <asp:Label runat="server" ID="lblWarShipLvl1Count" Width="95" HorizontalContentAlignment="Left" />
                                </div>
                                <div aria-orientation="horizontal">
                                    <asp:Label runat="server" Text="Level 2:" HorizontalContentAlignment="Left" Width="65" />
                                    <asp:Label runat="server" ID="lblWarInfLvl2Count" Width="95" HorizontalContentAlignment="Left" />
                                    <asp:Label runat="server" Text="Level 2:" HorizontalContentAlignment="Left" Width="65" />
                                    <asp:Label runat="server" ID="lblWarTankLvl2Count" Width="95" HorizontalContentAlignment="Left" />
                                    <asp:Label runat="server" Text="Level 2:" HorizontalContentAlignment="Left" Width="65" />
                                    <asp:Label runat="server" ID="lblWarJetLvl2Count" Width="95" HorizontalContentAlignment="Left" />
                                    <asp:Label runat="server" Text="Level 2:" HorizontalContentAlignment="Left" Width="65" />
                                    <asp:Label runat="server" ID="lblWarBombLvl2Count" Width="95" HorizontalContentAlignment="Left" />
                                    <asp:Label runat="server" Text="Level 2:" HorizontalContentAlignment="Left" Width="65" />
                                    <asp:Label runat="server" ID="lblWarShipLvl2Count" Width="95" HorizontalContentAlignment="Left" />
                                </div>
                                <div aria-orientation="horizontal">
                                    <asp:Label runat="server" Text="Level 3:" HorizontalContentAlignment="Left" Width="65" />
                                    <asp:Label runat="server" ID="lblWarInfLvl3Count" Width="95" HorizontalContentAlignment="Left" />
                                    <asp:Label runat="server" Text="Level 3:" HorizontalContentAlignment="Left" Width="65" />
                                    <asp:Label runat="server" ID="lblWarTankLvl3Count" Width="95" HorizontalContentAlignment="Left" />
                                    <asp:Label runat="server" Text="Level 3:" HorizontalContentAlignment="Left" Width="65" />
                                    <asp:Label runat="server" ID="lblWarJetLvl3Count" Width="95" HorizontalContentAlignment="Left" />
                                    <asp:Label runat="server" Text="Level 3:" HorizontalContentAlignment="Left" Width="65" />
                                    <asp:Label runat="server" ID="lblWarBombLvl3Count" Width="95" HorizontalContentAlignment="Left" />
                                    <asp:Label runat="server" Text="Level 3:" HorizontalContentAlignment="Left" Width="65" />
                                    <asp:Label runat="server" ID="lblWarShipLvl3Count" Width="95" HorizontalContentAlignment="Left" />
                                </div>
                                <div aria-orientation="horizontal">
                                    <asp:Label runat="server" Text="Level 4:" HorizontalContentAlignment="Left" Width="65" />
                                    <asp:Label runat="server" ID="lblWarInfLvl4Count" Width="95" HorizontalContentAlignment="Left" />
                                    <asp:Label runat="server" Text="Level 4:" HorizontalContentAlignment="Left" Width="65" />
                                    <asp:Label runat="server" ID="lblWarTankLvl4Count" Width="95" HorizontalContentAlignment="Left" />
                                    <asp:Label runat="server" Text="Level 4:" HorizontalContentAlignment="Left" Width="65" />
                                    <asp:Label runat="server" ID="lblWarJetLvl4Count" Width="95" HorizontalContentAlignment="Left" />
                                    <asp:Label runat="server" Text="Level 4:" HorizontalContentAlignment="Left" Width="65" />
                                    <asp:Label runat="server" ID="lblWarBombLvl4Count" Width="95" HorizontalContentAlignment="Left" />
                                    <asp:Label runat="server" Text="Level 4:" HorizontalContentAlignment="Left" Width="65" />
                                    <asp:Label runat="server" ID="lblWarShipLvl4Count" Width="95" HorizontalContentAlignment="Left" />
                                </div>
                                <div aria-orientation="horizontal">
                                    <asp:Label runat="server" Text="Level 5:" HorizontalContentAlignment="Left" Width="65" />
                                    <asp:Label runat="server" ID="lblWarInfLvl5Count" Width="95" HorizontalContentAlignment="Left" />
                                    <asp:Label runat="server" Text="Level 5:" HorizontalContentAlignment="Left" Width="65" />
                                    <asp:Label runat="server" ID="lblWarTankLvl5Count" Width="95" HorizontalContentAlignment="Left" />
                                    <asp:Label runat="server" Text="Level 5:" HorizontalContentAlignment="Left" Width="65" />
                                    <asp:Label runat="server" ID="lblWarJetLvl5Count" Width="95" HorizontalContentAlignment="Left" />
                                    <asp:Label runat="server" Text="Level 5:" HorizontalContentAlignment="Left" Width="65" />
                                    <asp:Label runat="server" ID="lblWarBombLvl5Count" Width="95" HorizontalContentAlignment="Left" />
                                    <asp:Label runat="server" Text="Level 5:" HorizontalContentAlignment="Left" Width="65" />
                                    <asp:Label runat="server" ID="lblWarShipLvl5Count" Width="95" HorizontalContentAlignment="Left" />
                                </div>
                                <div aria-orientation="horizontal">
                                    <asp:Label runat="server" Text="Level 6:" HorizontalContentAlignment="Left" Width="65" />
                                    <asp:Label runat="server" ID="lblWarInfLvl6Count" Width="95" HorizontalContentAlignment="Left" />
                                    <asp:Label runat="server" Text="Level 6:" HorizontalContentAlignment="Left" Width="65" />
                                    <asp:Label runat="server" ID="lblWarTankLvl6Count" Width="95" HorizontalContentAlignment="Left" />
                                    <asp:Label runat="server" Text="Level 6:" HorizontalContentAlignment="Left" Width="65" />
                                    <asp:Label runat="server" ID="lblWarJetLvl6Count" Width="95" HorizontalContentAlignment="Left" />
                                    <asp:Label runat="server" Text="Level 6:" HorizontalContentAlignment="Left" Width="65" />
                                    <asp:Label runat="server" ID="lblWarBombLvl6Count" Width="95" HorizontalContentAlignment="Left" />
                                    <asp:Label runat="server" Text="Level 6:" HorizontalContentAlignment="Left" Width="65" />
                                    <asp:Label runat="server" ID="lblWarShipLvl6Count" Width="95" HorizontalContentAlignment="Left" />
                                </div>
                                <div aria-orientation="horizontal">
                                    <asp:Label runat="server" Text="Level 7:" HorizontalContentAlignment="Left" Width="65" />
                                    <asp:Label runat="server" ID="lblWarInfLvl7Count" Width="95" HorizontalContentAlignment="Left" />
                                    <asp:Label runat="server" Text="Level 7:" HorizontalContentAlignment="Left" Width="65" />
                                    <asp:Label runat="server" ID="lblWarTankLvl7Count" Width="95" HorizontalContentAlignment="Left" />
                                    <asp:Label runat="server" Text="Level 7:" HorizontalContentAlignment="Left" Width="65" />
                                    <asp:Label runat="server" ID="lblWarJetLvl7Count" Width="95" HorizontalContentAlignment="Left" />
                                    <asp:Label runat="server" Text="Level 7:" HorizontalContentAlignment="Left" Width="65" />
                                    <asp:Label runat="server" ID="lblWarBombLvl7Count" Width="95" HorizontalContentAlignment="Left" />
                                    <asp:Label runat="server" Text="Level 7:" HorizontalContentAlignment="Left" Width="65" />
                                    <asp:Label runat="server" ID="lblWarShipLvl7Count" Width="95" HorizontalContentAlignment="Left" />
                                </div>
                                <div aria-orientation="horizontal">
                                    <asp:Label runat="server" Text="Level 8:" HorizontalContentAlignment="Left" Width="65" />
                                    <asp:Label runat="server" ID="lblWarInfLvl8Count" Width="95" HorizontalContentAlignment="Left" />
                                    <asp:Label runat="server" Text="Level 8:" HorizontalContentAlignment="Left" Width="65" />
                                    <asp:Label runat="server" ID="lblWarTankLvl8Count" Width="95" HorizontalContentAlignment="Left" />
                                    <asp:Label runat="server" Text="Level 8:" HorizontalContentAlignment="Left" Width="65" />
                                    <asp:Label runat="server" ID="lblWarJetLvl8Count" Width="95" HorizontalContentAlignment="Left" />
                                    <asp:Label runat="server" Text="Level 8:" HorizontalContentAlignment="Left" Width="65" />
                                    <asp:Label runat="server" ID="lblWarBombLvl8Count" Width="95" HorizontalContentAlignment="Left" />
                                    <asp:Label runat="server" Text="Level 8:" HorizontalContentAlignment="Left" Width="65" />
                                    <asp:Label runat="server" ID="lblWarShipLvl8Count" Width="95" HorizontalContentAlignment="Left" />
                                </div>
                                <div aria-orientation="horizontal">
                                    <asp:Label runat="server" Text="Level 12:" HorizontalContentAlignment="Left" Style="margin-left: 338px" Width="65" />
                                    <asp:Label runat="server" ID="lblWarJetLvl12Count" Width="95" HorizontalContentAlignment="Left" />
                                    <asp:Label runat="server" Text="Level 12:" HorizontalContentAlignment="Left" Width="65" />
                                    <asp:Label runat="server" ID="lblWarBombLvl12Count" Width="95" HorizontalContentAlignment="Left" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
