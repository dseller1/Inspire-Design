<%@ Page Language="C#" AutoEventWireup="true" CodeFile="register.aspx.cs" MasterPageFile="LoginMaster.master" Inherits="RegisterPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Label ID="usernameLbl" runat="server" Text="Enter Username: " Width="160px" />
    <asp:TextBox ID="usernameTxt" runat="server" CssClass="TextBox"></asp:TextBox>
    <asp:RequiredFieldValidator ID="usernameFieldValidator" runat="server" ControlToValidate="usernameTxt" ErrorMessage="Username is required." CssClass="Validator" />
    <br />
    <br />
    <asp:Label ID="passwordLbl" runat="server" Text="Enter Password: " Width="160px" />
    <asp:TextBox ID="passwordTxt" runat="server" TextMode="Password" CssClass="TextBox"></asp:TextBox>
    <asp:RequiredFieldValidator ID="passwordFieldValidator" runat="server" ControlToValidate="passwordTxt" ErrorMessage="Password is required." CssClass="Validator" />
    <br />
    <br />
    <asp:Label ID="cnfrmPassLbl" runat="server" Text="Confirm Password: " Width="160px" />
    <asp:TextBox ID="cnfrmPassTxt" runat="server" TextMode="Password" CssClass="TextBox"></asp:TextBox>
    <asp:RequiredFieldValidator ID="cnfrmPassFieldValidator" runat="server" ControlToValidate="cnfrmPassTxt" ErrorMessage="Password is required." CssClass="Validator" />
    <br />
    <br />
    <asp:Label ID="emailLbl" runat="server" Text="Enter E-mail Address: " Width="160px" />
    <asp:TextBox ID="emailTxt" runat="server" TextMode="Email" CssClass="TextBox"></asp:TextBox>
    <asp:RequiredFieldValidator ID="emailFieldValidator" runat="server" ControlToValidate="emailTxt" ErrorMessage="Email address is required." CssClass="Validator" />
    <br />
    <br />
    <asp:Label ID="phoneLbl" runat="server" Text="Enter Phone #: " Width="160px" />
    <asp:TextBox ID="phoneTxt" runat="server" CssClass="TextBox"></asp:TextBox>
    <br />
    <br />
    <asp:Label runat="server" Width="26px" />
    <asp:Button ID="createAccBtn" runat="server" OnClick="createAccBtn_Click" Text="Create Account" class="Button" Width="125px" />
    <asp:Label runat="server" Width="26px" />
    <asp:Button ID="backToLoginBtn" runat="server" OnClick="backToLoginBtn_Click" CausesValidation="false" Text="Back To Login Page" class="Button" Width="155px" />
    <asp:Label ID="errorTxt" runat="server" CssClass="Label"></asp:Label>
</asp:Content>


