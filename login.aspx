<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" MasterPageFile="LoginMaster.master" Inherits="StartPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        <asp:Label ID="usernameLbl" runat="server" Text="Enter Username: " Width="160px" />
        <asp:TextBox ID="usernameTxt" runat="server" CssClass="TextBox"></asp:TextBox>
        <asp:RequiredFieldValidator ID="usernameFieldValidator" runat="server" ErrorMessage="Username is required." ControlToValidate="usernameTxt" CssClass="Validator" />
        <br />
        <br />
        <asp:Label ID="passwordLbl" runat="server" Text="Enter Password: " Width="160px" />
        <asp:TextBox ID="passwordTxt" runat="server" TextMode="Password" CssClass="TextBox"></asp:TextBox>
    </div>
    <div>
        <br />
        <asp:Label runat="server" Width="67px"/>
        <asp:Button ID="loginBtn" runat="server" OnClick="loginBtn_Click" Text="Login" class="Button" Width="75px" />
        <asp:Label runat="server" Width="30px"/>
        <asp:Button ID="registerBtn" runat="server" OnClick="registerBtn_Click" CausesValidation="false" Text="Register" class="Button" Width="100px" />
        <asp:Label ID="errorTxt" runat="server" CssClass="Label"></asp:Label>
    </div>
</asp:Content>
