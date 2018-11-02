<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LandGrab.aspx.cs" MasterPageFile="MasterPage.master" Inherits="LandGrab" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        <asp:Label Text="Your Land: " Width="115" Style="text-align: right;" runat="server"/>
        <asp:TextBox runat="server" ID="tbUserLand" CssClass="TextBox" Width="85" MaxLength="7"/>
    </div>
    <br />
    <div>
        <asp:Label Text="Target Land: " Width="115" Style="text-align: right;" runat="server"/>
        <asp:TextBox runat="server" ID="tbTargetLand" CssClass="TextBox" Width="85" MaxLength="7"/>
    </div>
    <br />
    <div>
        <asp:Label Text="Attacks Against: " Width="115" Style="text-align: right;" runat="server"/>
        <asp:TextBox runat="server"  ID="tbAttacks" CssClass="TextBox" Width="85" MaxLength="2"/>
        
    </div>
    <br />
    <div>
        <asp:Label Text="Est Grab: " Width="115" Style="text-align: right;" runat="server"/>
        <asp:Label ID="lblEstGrab" runat="server" Width="85" Style="text-align: center;"/>
    </div>
    <br />
    <div>
        <asp:Button runat="server" ID="btnLandGrab" Width="85" Style="margin-left: 115px;" Text="Calculate" OnClick="btnLandGrab_Click" CssClass="Button"/>
    </div>
</asp:Content>
