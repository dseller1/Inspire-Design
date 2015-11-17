<%@ Page Language="C#" AutoEventWireup="true" CodeFile="elements.aspx.cs" MasterPageFile="MainMaster.master" Inherits="ElementsPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Panel ID="boardPnl" runat="server" Visible="false">
        <asp:DropDownList ID="boardNameList" runat="server" CssClass="DropDownList">
            <asp:ListItem Text="Select Board.." Value="null"></asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="boardLbl" runat="server" CssClass="Label"></asp:Label>
        <br />
        <br />
        <asp:Button ID="chooseBrdBtn" runat="server" Text="Select Board" OnClick="chooseBrdBtn_Click" CssClass="Button" Width="110px" />
        &nbsp;&nbsp;
        <asp:Button ID="createBoardBtn" runat="server" Text="Create Board" OnClick="createBoardBtn_Click" CssClass="Button" Width="110px" />
        &nbsp;
        
        <asp:Panel ID="newBoardPnl" runat="server" Visible="false" Width="413px" HorizontalAlign="Right">
            <asp:TextBox ID="newBoardTxt" runat="server" Width="80px" CssClass="TextBox" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="newBoardBtn" runat="server" Text="Submit" OnClick="newBoardBtn_Click" CssClass="Button" />
            &nbsp;&nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="newBoardFieldValidator" runat="server" ControlToValidate="newBoardTxt" ErrorMessage="Board name is required." CssClass="Validator" />
        </asp:Panel>
    </asp:Panel>
    <asp:Panel ID="designerPnl" runat="server" Visible="false">
        <asp:Panel ID="userPnl" runat="server" Visible="true" Height="56px">
            <asp:DropDownList ID="designerUserList" runat="server" CssClass="DropDownList">
                <asp:ListItem Text="Select User.." Value="null"></asp:ListItem>
            </asp:DropDownList>
            &nbsp;&nbsp;
            <asp:Button ID="selectUsrBtn" runat="server" Text="Select User" OnClick="selectUsrBtn_Click" CssClass="Button" Width="110px" />
            <asp:Label ID="userLbl" runat="server" CssClass="Label"></asp:Label>
        </asp:Panel>
    </asp:Panel>
    <asp:Panel ID="optionsPnl" runat="server" Visible="false">
        <div id="Elements">
            <h2>Elements</h2>
            Color:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:DropDownList ID="colorList" runat="server" CssClass="DropDownList">
                <asp:ListItem Text="Select Color.." Value="null"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            Line Structure:&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:DropDownList ID="lineList" runat="server" CssClass="DropDownList">
                <asp:ListItem Text="Select Line Structure.." Value="null"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            Light:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:DropDownList ID="lightList" runat="server" CssClass="DropDownList">
                <asp:ListItem Text="Select Light.." Value="null"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            Form:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="formList" runat="server" CssClass="DropDownList">
                <asp:ListItem Text="Select Form.." Value="null"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            Space:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="spaceList" runat="server" CssClass="DropDownList">
                <asp:ListItem Text="Select Space.." Value="null"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            Texture:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="textureList" runat="server" CssClass="DropDownList">
                <asp:ListItem Text="Select Texture.." Value="null"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            Pattern:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;&nbsp;&nbsp; &nbsp;
            <asp:DropDownList ID="patternList" runat="server" CssClass="DropDownList">
                <asp:ListItem Text="Select Pattern.." Value="null"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            Mass:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="massList" runat="server" CssClass="DropDownList">
                <asp:ListItem Text="Select Mass.." Value="null"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
        </div>
        <div id="Principles">
            <h2>Principles</h2>
            Balance:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="balanceList" runat="server" CssClass="DropDownList">
                <asp:ListItem Text="Select Balance.." Value="null"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            Unity:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="unityList" runat="server" CssClass="DropDownList">
                <asp:ListItem Text="Select Unity.." Value="null"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            Harmony:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:DropDownList ID="harmonyList" runat="server" CssClass="DropDownList">
                <asp:ListItem Text="Select Harmony.." Value="null"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            Rhythm:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:DropDownList ID="rhythmList" runat="server" CssClass="DropDownList">
                <asp:ListItem Text="Select Rhythm.." Value="null"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            Proportion:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="proportionList" runat="server" CssClass="DropDownList">
                <asp:ListItem Text="Select Proportion.." Value="null"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            Variety:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp;
            <asp:DropDownList ID="varietyList" runat="server" CssClass="DropDownList">
                <asp:ListItem Text="Select Variety.." Value="null"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            Emphasis:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="emphasisList" runat="server" CssClass="DropDownList">
                <asp:ListItem Text="Select Emphasis.." Value="null"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            Scale:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="scaleList" runat="server" CssClass="DropDownList">
                <asp:ListItem Text="Select Scale.." Value="null"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:DropDownList ID="typeList" runat="server" Visible="false"></asp:DropDownList>
        </div>
        <div id="Buttons">
            <br />
            <asp:Button ID="elementsBtn" runat="server" CssClass="Button" OnClick="elementsBtn_Click" Text="Submit Elements" Width="130px"/>
            &nbsp;&nbsp;
        <asp:Button ID="changeBoardBtn" runat="server" OnClick="changeBoardBtn_Click" Text="Change Board" CssClass="Button" Width="130px" />
            <br />
            <br />
            <asp:Label ID="label1" runat="server" class="Label" ></asp:Label>
        </div>
    </asp:Panel>
</asp:Content>
