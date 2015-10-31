<%@ Page Language="C#" AutoEventWireup="true" CodeFile="main.aspx.cs" MasterPageFile="MainMaster.master" Inherits="MainPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Panel ID="errorPnl" runat="server" Visible="false">
        <asp:Label ID="errorLbl" runat="server" Text="There are no more choices with these characteristics left to display." />
        <br />
        <br />
        <asp:Button ID="backToElementsBtn" runat="server" Text="Back To Elements Page" OnClick="backToElementsBtn_Click" CssClass="Button" />
    </asp:Panel>
    <asp:Panel ID="imagePnl" runat="server" Visible="true">
        <asp:Image ID="Image1" runat="server" Width="256px" Height="256px" />
        <br />
        <asp:Label ID="displayLbl" runat="server"></asp:Label><br />
        &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <asp:ImageButton ID="checkmarkButton" runat="server" OnClick="checkmarkButton_Click" Width="64px" Height="64px" ImageUrl="~/Images/checkmark.png" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="xButton" runat="server" OnClick="xButton_Click" Width="64px" Height="64px" ImageUrl="~/Images/Letter-X-icon.png" />
    </asp:Panel>
</asp:Content>
