<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Casher.aspx.cs" MasterPageFile="MasterPage.master" Inherits="Casher" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        <asp:Label Text="Total Land: " Width="115" Style="text-align: right;" runat="server"/>
        <asp:TextBox runat="server" ID="tbTotalLand" CssClass="TextBox" Width="85" MaxLength="7"/>
    </div>
    <br />
    <div>
        <asp:Label Text="CS: " Width="115" Style="text-align: right;" runat="server"/>
        <asp:TextBox runat="server" ID="tbCS" CssClass="TextBox" Width="85" MaxLength="7"/>
    </div>
    <br />
    <div>
        <asp:Label Text="BPT: " Width="115" Style="text-align: right;" runat="server"/>
        <asp:Label ID="lblBPT" runat="server" Width="85" Style="text-align: center;"/>
    </div>
    <br />
    <div>
        <asp:Label Text="Current Comm: " Width="115" Style="text-align: right;" runat="server"/>
        <asp:TextBox runat="server" ID="tbCurrentComm" CssClass="TextBox" Width="85" MaxLength="7"/>
    </div>
    <br />
    <div>
        <asp:Label Text="Current Res: " Width="115" Style="text-align: right;" runat="server"/>
        <asp:TextBox runat="server" ID="tbCurrentRes" CssClass="TextBox" Width="85" MaxLength="7"/>
    </div>
    <br />
    <div>
        <asp:Label Text="Target Comm: " Width="115" Style="text-align: right;" runat="server"/>
        <asp:Label ID="lblTargetComm" runat="server" Width="85" Style="text-align: center;"/>
    </div>
    <br />
    <div>
        <asp:Label Text="Target Res: " Width="115" Style="text-align: right;" runat="server"/>
        <asp:Label ID="lblTargetRes" runat="server" Width="85" Style="text-align: center;"/>
    </div>
    <br />
    <div>
        <asp:Label Text="Comm To Build: " Width="115" Style="text-align: right;" runat="server"/>
        <asp:Label ID="lblCommToBuild" runat="server" Width="85" Style="text-align: center;"/>
    </div>
    <br />
    <div>
        <asp:Label Text="Res To Build: " Width="115" Style="text-align: right;" runat="server"/>
        <asp:Label ID="lblResToBuild" runat="server" Width="85" Style="text-align: center;"/>
    </div>
    <br />
    <div>
        <asp:Button runat="server" ID="btnCasher" Width="85" Style="margin-left: 115px;" Text="Calculate" OnClick="btnCasher_Click" CssClass="Button"/>
    </div>
</asp:Content>
