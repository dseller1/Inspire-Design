<%@ Page Language="C#" AutoEventWireup="true" CodeFile="account.aspx.cs" MasterPageFile="~/MainMaster.master" Inherits="account" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Label ID="username" runat="server" Text="Username: " Width="100px" />
    <asp:Label ID="usernameLbl" runat="server" />
    <br />
    <asp:Label ID="pass" runat="server" Text="Password: " Width="100px" />
    <asp:Label ID="passwordLbl" runat="server" />
    <br />
    <asp:Label ID="email" runat="server" Text="E-mail: " Width="100px" />
    <asp:Label ID="emailAddressLbl" runat="server" />
    <asp:TextBox ID="emailAddressTxt" TextMode="Email" runat="server" Visible="false" />
    <asp:Button ID="changeEmailBtn" runat="server" Text="Edit" OnClick="changeEmailBtn_Click" CssClass="Button" />
    <asp:ImageButton ID="changeEmailYesBtn" runat="server" OnClick="changeEmailYesBtn_Click" Visible="false" Width="32px" Height="32px" ImageUrl="~/Images/checkmark.png" />
    <asp:ImageButton ID="changeEmailNoBtn" runat="server" OnClick="changeEmailNoBtn_Click" Visible="false" Width="32px" Height="32px" ImageUrl="~/Images/Letter-X-icon.png" />
    <br />
    <asp:Label ID="phone" runat="server" Text="Phone #: " Width="100px" />
    <asp:Label ID="phoneLbl" runat="server" />
    <asp:TextBox ID="phoneTxt" runat="server" Visible="false" />
    <asp:Button ID="changePhoneBtn" runat="server" Text="Edit" OnClick="changePhoneBtn_Click" CssClass="Button" />
    <asp:ImageButton ID="changePhoneYesBtn" runat="server" OnClick="changePhoneYesBtn_Click" Visible="false" Width="32px" Height="32px" ImageUrl="~/Images/checkmark.png" />
    <asp:ImageButton ID="changePhoneNoBtn" runat="server" OnClick="changePhoneNoBtn_Click" Visible="false" Width="32px" Height="32px" ImageUrl="~/Images/Letter-X-icon.png" />
    <br />
    <asp:Label ID="designer" runat="server" Text="Designer: " Width="100px" />
    <asp:Label ID="designerLbl" runat="server" />
</asp:Content>
