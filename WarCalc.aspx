<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WarCalc.aspx.cs" MasterPageFile="MasterPage.master" Inherits="WarCalc" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        <asp:Label Text="Population: " Width="80" Style="text-align: right; margin-left: 18px;" runat="server"/>
        <asp:TextBox runat="server" ID="tbPopulation" CssClass="TextBox" Width="100" MaxLength="9"/>
    </div>
    <br />
    <div>
        <asp:Button runat="server" ID="btnGaCalc" Width="85" Style="margin-left: 65px;" OnClick="btnGaCalc_Click" Text="Calculate" CssClass="Button"/>
    </div>
    <br />
    <div>
        <asp:Label Text="Number of GA Attacks: " ID="lblGa" Width="165" Style="text-align: right;" runat="server" Visible="false"/>
        <asp:Label ID="lblGaAttacks" runat="server" Width="50" Style="text-align: center;" Visible="false"/>
    </div>
    <br />
     <div>
        <asp:Label Text="Land: " Width="80" Style="text-align: right; margin-left: 18px;" runat="server"/>
        <asp:TextBox runat="server" ID="tbLand" CssClass="TextBox" Width="100" MaxLength="7"/>
    </div>
    <br />
    <div>
        <asp:Button runat="server" ID="btnArCalc" Width="85" Style="margin-left: 65px;" OnClick="btnArCalc_Click" Text="Calculate" CssClass="Button"/>
    </div>
    <br />
    <div>
        <asp:Label Text="Number of AR Attacks: " ID="lblAr" Width="165" Style="text-align: right;" runat="server" Visible="false"/>
        <asp:Label ID="lblArAttacks" runat="server" Width="50" Style="text-align: center;" Visible="false"/>
    </div>
</asp:Content>
