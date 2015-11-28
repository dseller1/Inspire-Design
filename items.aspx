﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="items.aspx.cs" MasterPageFile="MainMaster.master" Inherits="ItemsPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Panel ID="userNamePnl" runat="server" Visible="false">
        <asp:Label ID="userLbl" runat="server" Text="Selected User: " />
        <asp:Label ID="userNameLbl" runat="server" />
    </asp:Panel>
    <asp:Panel ID="boardNamePnl" runat="server" Visible="false">
        <asp:Label ID="boardLbl" runat="server" Text="Selected Board: " />
        <asp:Label ID="boardNameLbl" runat="server" />
    </asp:Panel>
    <asp:Panel ID="changeBoardPnl" runat="server" Visible="false">
        <asp:DropDownList ID="boardNameList" runat="server" CssClass="DropDownList">
            <asp:ListItem Text="Select Board.." Value="null" />
        </asp:DropDownList>
        <asp:Button ID="chooseBrdBtn" runat="server" Text="Select Board" OnClick="chooseBrdBtn_Click" CssClass="Button" Width="115px" />
        <asp:Button ID="createBoardBtn" runat="server" Text="Create Board" OnClick="createBoardBtn_Click" CssClass="Button" Width="115px" />
        <asp:Label ID="boardErrLbl" runat="server" CssClass="Label" />
        <asp:Panel ID="newBoardPnl" runat="server" Visible="false" Width="413px" HorizontalAlign="Right">
            <asp:TextBox ID="newBoardTxt" runat="server" Width="80px" CssClass="TextBox" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="newBoardBtn" runat="server" Text="Submit" OnClick="newBoardBtn_Click" CssClass="Button" />
            &nbsp;&nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="newBoardFieldValidator" runat="server" ControlToValidate="newBoardTxt" ErrorMessage="Board name is required." CssClass="Validator" />
        </asp:Panel>
    </asp:Panel>
    <asp:Panel ID="switchUserPnl" runat="server" Visible="false">
        <asp:DropDownList ID="designerUserList" runat="server" CssClass="DropDownList">
            <asp:ListItem Text="Select User.." Value="null" />
        </asp:DropDownList>
        &nbsp;&nbsp;
           
        <asp:Button ID="selectUsrBtn" runat="server" Text="Select User" OnClick="selectUsrBtn_Click" CssClass="Button" Width="110px" />
        <asp:Label ID="userErrLbl" runat="server" CssClass="Label" />
    </asp:Panel>
    <asp:Panel ID="optionsPnl" runat="server" Visible="false">
        <asp:DropDownList ID="colorList" runat="server" CssClass="DropDownList">
            <asp:ListItem Text="Select Color.." Value="null" />
        </asp:DropDownList>
        <asp:DropDownList ID="lineList" runat="server" CssClass="DropDownList">
            <asp:ListItem Text="Select Line Structure.." Value="null" />
        </asp:DropDownList>
        <asp:DropDownList ID="lightList" runat="server" CssClass="DropDownList">
            <asp:ListItem Text="Select Light.." Value="null" />
        </asp:DropDownList>
        <asp:DropDownList ID="formList" runat="server" CssClass="DropDownList">
            <asp:ListItem Text="Select Form.." Value="null"></asp:ListItem>
        </asp:DropDownList>
        <asp:DropDownList ID="spaceList" runat="server" CssClass="DropDownList">
            <asp:ListItem Text="Select Space.." Value="null"></asp:ListItem>
        </asp:DropDownList>
        <asp:DropDownList ID="textureList" runat="server" CssClass="DropDownList">
            <asp:ListItem Text="Select Texture.." Value="null"></asp:ListItem>
        </asp:DropDownList>
        <asp:DropDownList ID="patternList" runat="server" CssClass="DropDownList">
            <asp:ListItem Text="Select Pattern.." Value="null"></asp:ListItem>
        </asp:DropDownList>
        <asp:DropDownList ID="massList" runat="server" CssClass="DropDownList">
            <asp:ListItem Text="Select Mass.." Value="null"></asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:DropDownList ID="balanceList" runat="server" CssClass="DropDownList">
            <asp:ListItem Text="Select Balance.." Value="null"></asp:ListItem>
        </asp:DropDownList>
        <asp:DropDownList ID="unityList" runat="server" CssClass="DropDownList">
            <asp:ListItem Text="Select Unity.." Value="null"></asp:ListItem>
        </asp:DropDownList>
        <asp:DropDownList ID="harmonyList" runat="server" CssClass="DropDownList">
            <asp:ListItem Text="Select Harmony.." Value="null"></asp:ListItem>
        </asp:DropDownList>
        <asp:DropDownList ID="rhythmList" runat="server" CssClass="DropDownList">
            <asp:ListItem Text="Select Rhythm.." Value="null"></asp:ListItem>
        </asp:DropDownList>
        <asp:DropDownList ID="proportionList" runat="server" CssClass="DropDownList">
            <asp:ListItem Text="Select Proportion.." Value="null"></asp:ListItem>
        </asp:DropDownList>
        <asp:DropDownList ID="varietyList" runat="server" CssClass="DropDownList">
            <asp:ListItem Text="Select Variety.." Value="null"></asp:ListItem>
        </asp:DropDownList>
        <asp:DropDownList ID="emphasisList" runat="server" CssClass="DropDownList">
            <asp:ListItem Text="Select Emphasis.." Value="null"></asp:ListItem>
        </asp:DropDownList>
        <asp:DropDownList ID="scaleList" runat="server" CssClass="DropDownList">
            <asp:ListItem Text="Select Scale.." Value="null"></asp:ListItem>
        </asp:DropDownList>
        <asp:DropDownList ID="typeList" runat="server" CssClass="DropDownList">
            <asp:ListItem Text="Select Type.." Value="null"></asp:ListItem>
        </asp:DropDownList>
        <br />

        <br />
        <asp:Button ID="showItemsBtn" runat="server" Text="Show Items" OnClick="showItemsBtn_Click" CssClass="Button" Width="115px" />
        <asp:Button ID="changeBoardBtn" runat="server" OnClick="changeBoardBtn_Click" Text="Change Board" CssClass="Button" Width="115px" />
        <asp:Button ID="switchUserBtn" runat="server" OnClick="switchUserBtn_Click" Text="Switch User" CssClass="Button" Width="107px" Visible="false" />
    </asp:Panel>
    <asp:GridView ID="itemGrid" runat="server" CellPadding="5" AutoGenerateColumns="False" DataSource='<%# getItemsData() %>' GridLines="None" OnRowCommand="itemGrid_RowCommand">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:ImageButton ID="PictureURL1" runat="server" ImageUrl='<%# Eval("PictureURL1") %>' CommandName="Add_Item" CommandArgument='<%# Eval("PictureURL1") %>' OnClientClick="return confirm('Are you sure you want to add this item?');" style="max-height: 251px; max-width: 251px;"/>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:ImageButton ID="PictureURL2" runat="server" ImageUrl='<%# Eval("PictureURL2") %>' CommandName="Add_Item" CommandArgument='<%# Eval("PictureURL2") %>' OnClientClick="return confirm('Are you sure you want to add this item?');" style="max-height: 251px; max-width: 251px;"/>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:ImageButton ID="PictureURL3" runat="server" ImageUrl='<%# Eval("PictureURL3") %>' CommandName="Add_Item" CommandArgument='<%# Eval("PictureURL3") %>' OnClientClick="return confirm('Are you sure you want to add this item?');" style="max-height: 251px; max-width: 251px;"/>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:ImageButton ID="PictureURL4" runat="server" ImageUrl='<%# Eval("PictureURL4") %>' CommandName="Add_Item" CommandArgument='<%# Eval("PictureURL4") %>' OnClientClick="return confirm('Are you sure you want to add this item?');" style="max-height: 251px; max-width: 251px;"/>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
