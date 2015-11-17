<%@ Page Language="C#" AutoEventWireup="true" CodeFile="account.aspx.cs" MasterPageFile="~/MainMaster.master" Inherits="account" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Label ID="username" runat="server" Text="Username: " Width="140px" />
    <asp:Label ID="usernameLbl" runat="server" Width="170px" />
    <br />
    <asp:Label ID="pass" runat="server" Text="Password: " Width="140px" />
    <asp:Label ID="passwordLbl" runat="server" Text="••••••••" Width="170px" />
    <asp:TextBox ID="passwordTxt" TextMode="Password" runat="server" Visible="false" />
    <asp:Button ID="changePassBtn" runat="server" Text="Edit" OnClick="changePassBtn_Click" CausesValidation="false" CssClass="Button" />
    <asp:Label runat="server" Width="68px" />
    <asp:RequiredFieldValidator ID="passwordFieldValidator" runat="server" ErrorMessage="Password is required." CssClass="Validator" />
    <asp:Panel ID="cnfrmPassPnl" runat="server" Visible="false">
        <asp:Label ID="cnfrmPass" runat="server" Text="Confirm Password: " Width="140px" />
        <asp:TextBox ID="cnfrmPassTxt" TextMode="Password" runat="server" />
        <asp:ImageButton ID="changePassYesBtn" runat="server" OnClick="changePassYesBtn_Click" Width="20px" Height="20px" ImageUrl="~/Images/greenmark.png" />
        <asp:ImageButton ID="changePassNoBtn" runat="server" OnClick="changePassNoBtn_Click" CausesValidation="false" Width="20px" Height="20px" ImageUrl="~/Images/redX.png" />
        <asp:RequiredFieldValidator ID="cnfrmPassFieldValidator" runat="server" ErrorMessage="Password is required." CssClass="Validator" />
        <asp:Label ID="passErrorLbl" runat="server" CssClass="Label"/>
    </asp:Panel>
    <br />
    <asp:Label ID="email" runat="server" Text="E-mail: " Width="140px" Height="18px" />
    <asp:Label ID="emailAddressLbl" runat="server" Width="170px" />
    <asp:TextBox ID="emailAddressTxt" TextMode="Email" runat="server" Visible="false" />
    <asp:Button ID="changeEmailBtn" runat="server" Text="Edit" OnClick="changeEmailBtn_Click" CausesValidation="false" CssClass="Button" />
    <asp:ImageButton ID="changeEmailYesBtn" runat="server" OnClick="changeEmailYesBtn_Click" Visible="false" Width="24px" Height="24px" ImageUrl="~/Images/greenmark.png" />
    <asp:ImageButton ID="changeEmailNoBtn" runat="server" OnClick="changeEmailNoBtn_Click" Visible="false" CausesValidation="false" Width="24px" Height="24px" ImageUrl="~/Images/redX.png" />
    <asp:RequiredFieldValidator ID="changeEmailFieldValidator" runat="server" ErrorMessage="Email address is required." CssClass="Validator" />
    <br />
    <asp:Label ID="phone" runat="server" Text="Phone #: " Width="140px" />
    <asp:Label ID="phoneLbl" runat="server" Width="170px" />
    <asp:TextBox ID="phoneTxt" runat="server" Visible="false" />
    <asp:Button ID="changePhoneBtn" runat="server" Text="Edit" OnClick="changePhoneBtn_Click" CausesValidation="false" CssClass="Button" />
    <asp:ImageButton ID="changePhoneYesBtn" runat="server" OnClick="changePhoneYesBtn_Click" CausesValidation="false" Visible="false" Width="24px" Height="24px" ImageUrl="~/Images/greenmark.png" />
    <asp:ImageButton ID="changePhoneNoBtn" runat="server" OnClick="changePhoneNoBtn_Click" CausesValidation="false" Visible="false" Width="24px" Height="24px" ImageUrl="~/Images/redX.png" />
    <br />
    <asp:Panel ID="clientPnl" runat="server" Visible="false">
        <asp:Label ID="designer" runat="server" Text="Designer: " Width="140px" />
        <asp:Label ID="designerLbl" runat="server" Width="170px" />
    </asp:Panel>
    <asp:Panel ID="designerPnl" runat="server" Visible="false">
        <asp:Label ID="clientLbl" runat="server" Text="Clients: " Width="140px" />
        <asp:ListBox ID="clientList" runat="server" CssClass="ListBox" />
        <asp:Button ID="addClientBtn" runat="server" OnClick="addClientBtn_Click" CausesValidation="false" Text="Add Client" CssClass="Button" Width="94px" />
        <asp:TextBox ID="addClientTxt" runat="server" Visible="false" />
        <asp:ImageButton ID="addClientYesBtn" runat="server" OnClick="addClientYesBtn_Click" CausesValidation="false" Visible="false" Width="24px" Height="24px" ImageUrl="~/Images/greenmark.png" />
        <asp:ImageButton ID="addClientNoBtn" runat="server" OnClick="addClientNoBtn_Click" CausesValidation="false" Visible="false" Width="24px" Height="24px" ImageUrl="~/Images/redX.png" />
        <asp:Label ID="errorLbl" runat="server" CssClass="Label" />
    </asp:Panel>
</asp:Content>
