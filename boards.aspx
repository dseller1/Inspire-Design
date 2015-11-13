<%@ Page Language="C#" AutoEventWireup="true" CodeFile="boards.aspx.cs" MasterPageFile="MainMaster.master" Inherits="BoardsPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Panel ID="designerPnl" runat="server" Visible="false">
        <asp:Panel ID="userPnl" runat="server" Visible="true">
            <asp:DropDownList ID="designerUserList" runat="server" CssClass="DropDownList">
                <asp:ListItem Text="Select User.." Value="null"></asp:ListItem>
            </asp:DropDownList>
            &nbsp;&nbsp;
            <asp:Button ID="selectUsrBtn" runat="server" Text="Select User" OnClick="selectUsrBtn_Click" CssClass="Button" Width="110px" />
            <asp:Label ID="userLbl" runat="server" CssClass="Label"></asp:Label>
        </asp:Panel>
    </asp:Panel>

    <asp:Panel ID="boardPnl" runat="server" Visible="false">
        <asp:DropDownList ID="boardNameList" runat="server" CssClass="DropDownList">
            <asp:ListItem Text="Select Board.." Value="null"></asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Label ID="boardLbl" runat="server" CssClass="Label"></asp:Label>
        <br />
        <asp:Button ID="boardSbmtBtn" runat="server" CssClass="Button" OnClick="boardSbmtBtn_Click" Text="Display Board" Width="115px" />
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="switchUserBtn" runat="server" CssClass="Button" OnClick="switchUserBtn_Click" Text="Switch User" Visible="false" Width="115px" />
    </asp:Panel>
    <br />
    <asp:GridView ID="boardItemsGrid" runat="server" RowStyle-CssClass="itemsGrid" DataSource='<%# getBoardData() %>' AutoGenerateColumns="False" OnRowCommand="boardItemsGrid_RowCommand">
        <Columns>
            <asp:BoundField HeaderText="Item ID" DataField="ItemID" />
            <asp:ImageField HeaderText="Image" DataImageUrlField="PictureURL">
            </asp:ImageField>
            <asp:BoundField HeaderText="Item Description" DataField="Description" />
            <asp:TemplateField HeaderText="Delete">
                <ItemTemplate>
                    <asp:ImageButton ID="deleteBtn" runat="server" ImageUrl="~/Images/redX.png" CommandName="Delete_Item" CommandArgument='<%# Eval("ItemID") %>' OnClientClick="return confirm('Are you sure you want to delete this item?');" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
