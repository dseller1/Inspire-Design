<%@ Page Language="C#" AutoEventWireup="true" CodeFile="inspiration.aspx.cs" MasterPageFile="MainMaster.master" Inherits="inspiration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Panel ID="boardPnl" runat="server" Visible="true">
        <asp:Label ID="boardLbl" runat="server" Text="Selected Board: "></asp:Label>
        <asp:Label ID="boardNameLbl" runat="server"></asp:Label><br />
        <asp:Button ID="changeBoardBtn" runat="server" Text="Change Board" CssClass="Button" Height="35px" Width="123px" OnClick="changeBoardBtn_Click" />
    </asp:Panel>
    <asp:Panel ID="changeBoardPnl" runat="server" Visible="false">
        <asp:DropDownList ID="boardNameList" runat="server" CssClass="DropDownList">
            <asp:ListItem Text="Select Board.." Value="null"></asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="boardSbmtBtn" runat="server" CssClass="Button" OnClick="boardSbmtBtn_Click" Text="Display Board" Width="115px" />
        <asp:Label ID="boardErrLbl" runat="server" CssClass="Label"></asp:Label>
    </asp:Panel>
    <asp:Image ID="colorPlace1" runat="server" CssClass="colorSwatch" />
    <asp:Image ID="colorPlace2" runat="server" CssClass="colorSwatch" />
    <asp:Image ID="colorPlace3" runat="server" CssClass="colorSwatch" />
    <asp:Image ID="chairPlace1" runat="server" CssClass="chairSwatch" />
    <asp:Image ID="chairPlace2" runat="server" CssClass="chairSwatch" />
    <asp:Image ID="chairPlace3" runat="server" CssClass="chairSwatch" />
    <asp:Image ID="rugPlace1" runat="server" CssClass="rugSwatch" />
    <asp:Image ID="rugPlace2" runat="server" CssClass="rugSwatch" />
    <asp:Image ID="rugPlace3" runat="server" CssClass="rugSwatch" />
    <asp:Image ID="patternPlace1" runat="server" CssClass="patternSwatch" />
    <asp:Image ID="patternPlace2" runat="server" CssClass="patternSwatch" />
    <asp:Image ID="patternPlace3" runat="server" CssClass="patternSwatch" />
    <asp:Image ID="roomPlace1" runat="server" CssClass="roomSwatch" />
    <asp:Image ID="roomPlace2" runat="server" CssClass="roomSwatch" />
    <asp:Image ID="roomPlace3" runat="server" CssClass="roomSwatch" />
    <asp:Image ID="ottomanPlace1" runat="server" CssClass="ottomanSwatch" />
    <asp:Image ID="ottomanPlace2" runat="server" CssClass="ottomanSwatch" />
    <asp:Image ID="ottomanPlace3" runat="server" CssClass="ottomanSwatch" />

</asp:Content>

