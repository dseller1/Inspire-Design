<%@ Page Language="C#" AutoEventWireup="true" CodeFile="inspiration.aspx.cs" MasterPageFile="MainMaster.master" Inherits="inspiration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="inspiration">
        <asp:Panel ID="userNamePnl" runat="server" Visible="false">
            <asp:Label ID="userLbl" runat="server" Text="Selected User: " />
            <asp:Label ID="userNameLbl" runat="server" />
        </asp:Panel>
        <asp:Panel ID="boardNamePnl" runat="server" Visible="false">
            <asp:Label ID="boardLbl" runat="server" Text="Selected Board: " />
            <asp:Label ID="boardNameLbl" runat="server"></asp:Label><br />
        </asp:Panel>
        <asp:Button ID="changeBoardBtn" runat="server" Text="Change Board" CssClass="Button" Height="35px" Width="123px" OnClick="changeBoardBtn_Click" />
        <asp:Panel ID="changeBoardPnl" runat="server" Visible="false">
            <asp:DropDownList ID="boardNameList" runat="server" CssClass="DropDownList">
                <asp:ListItem Text="Select Board.." Value="null"></asp:ListItem>
            </asp:DropDownList>
            <asp:Button ID="boardSbmtBtn" runat="server" CssClass="Button" OnClick="boardSbmtBtn_Click" Text="Display Board" Width="115px" />
            <asp:Button ID="switchUserBtn" runat="server" CssClass="Button" OnClick="switchUserBtn_Click" Text="Switch User" Width="107px" Visible="false" />
            <asp:Label ID="boardErrLbl" runat="server" CssClass="Label"></asp:Label>
        </asp:Panel>
        <asp:Panel ID="switchUserPnl" runat="server" Visible="false">
            <asp:DropDownList ID="designerUserList" runat="server" CssClass="DropDownList">
                <asp:ListItem Text="Select User.." Value="null"></asp:ListItem>
            </asp:DropDownList>
            &nbsp;&nbsp;
           
        <asp:Button ID="selectUsrBtn" runat="server" Text="Select User" OnClick="selectUsrBtn_Click" CssClass="Button" Width="110px" />
            <asp:Label ID="userErrLbl" runat="server" CssClass="Label"></asp:Label>
        </asp:Panel>
        <asp:Panel ID="inspirationPnl" runat="server" Height="830px">
            <asp:Image ID="colorPlace1" runat="server" CssClass="colorSwatch1" />
            <asp:Image ID="colorPlace2" runat="server" CssClass="colorSwatch2" />
            <asp:Image ID="colorPlace3" runat="server" CssClass="colorSwatch3" />
            <asp:Image ID="roomPlace1" runat="server" CssClass="roomSwatch1" />
            <asp:Image ID="roomPlace2" runat="server" CssClass="roomSwatch2" />
            <asp:Image ID="roomPlace3" runat="server" CssClass="roomSwatch3" />
            <asp:Image ID="patternPlace1" runat="server" CssClass="patternSwatch1" />
            <asp:Image ID="patternPlace2" runat="server" CssClass="patternSwatch2" />
            <asp:Image ID="patternPlace3" runat="server" CssClass="patternSwatch3" />
            <asp:Image ID="chairPlace1" runat="server" CssClass="chairSwatch1" />
            <asp:Image ID="chairPlace2" runat="server" CssClass="chairSwatch2" />
            <asp:Image ID="chairPlace3" runat="server" CssClass="chairSwatch3" />
            <asp:Image ID="ottomanPlace1" runat="server" CssClass="ottomanSwatch1" />
            <asp:Image ID="ottomanPlace2" runat="server" CssClass="ottomanSwatch2" />
            <asp:Image ID="ottomanPlace3" runat="server" CssClass="ottomanSwatch3" />
            <asp:Image ID="rugPlace1" runat="server" CssClass="rugSwatch1" />
            <asp:Image ID="rugPlace2" runat="server" CssClass="rugSwatch2" />
            <asp:Image ID="rugPlace3" runat="server" CssClass="rugSwatch3" />
        </asp:Panel>
    </div>
</asp:Content>

