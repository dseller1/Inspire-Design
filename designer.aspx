<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.master" AutoEventWireup="true" CodeFile="designer.aspx.cs" Inherits="designer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Panel ID="buttonsPnl" runat="server" Visible="true">
        <asp:Button ID="addItemDbBtn" runat="server" Text="Add Item to Database" OnClick="addItemDbBtn_Click" CssClass="Button" Width="164px" />
    </asp:Panel>
    <asp:Panel ID="urlPnl" runat="server" Visible="false">
        <asp:ValidationSummary ID="validationSummary1" runat="server" DisplayMode="List" CssClass="Validator"/>
        <br />
        <asp:TextBox ID="imageUrlTxt" runat="server" TextMode="Url" placeholder="Enter Image URL.." CssClass="TextBox" />
        <br />
        <asp:RequiredFieldValidator ID="imageUrlFieldValidator" runat="server" ControlToValidate="imageUrlTxt" ErrorMessage="Image URL is required." Display="None" />
        <br />
        <asp:TextBox id="descriptTxt" runat="server" TextMode="MultiLine" CssClass="TextBox" placeholder="Enter Description.." />
        <asp:RequiredFieldValidator ID="descriptFieldValidator" runat="server" ControlToValidate="descriptTxt" ErrorMessage="Description is required." Display="None" />
        <asp:Button ID="urlSbmtBtn" runat="server" Text="Submit" OnClick="urlSbmtBtn_Click" style="position: relative; top: -9px;" CssClass="Button" />
    </asp:Panel>
    <asp:Panel ID="addItemPnl" runat="server" Visible="false" Style="text-align: center;">
        <asp:ValidationSummary ID="validationSummary2" runat="server" DisplayMode="List" CssClass="Validator"/>
        <div id="Elements">
            <h2>Elements</h2>
            <asp:DropDownList ID="colorList" runat="server" Visible="false" />
            <asp:TextBox ID="colorTxt" runat="server" CssClass="TextBox" placeholder="Enter Color.." />
            <asp:RequiredFieldValidator ID="colorFieldValidator" runat="server" ControlToValidate="colorTxt" ErrorMessage="Color is required." Display="None" />
            <br />
            <br />
            <asp:DropDownList ID="typeList" runat="server" required="true" CssClass="DropDownList">
                <asp:ListItem Text="Select Type.." Value="null"></asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="typeFieldValidator" runat="server" ControlToValidate="typeList" InitialValue="null" ErrorMessage="Type is required." Display="None" />
            <br />
            <br />
            <asp:DropDownList ID="lineList" runat="server" required="true" CssClass="DropDownList">
                <asp:ListItem Text="Select Line Structure.." Value="null"></asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="lineFieldValidator" runat="server" ControlToValidate="lineList" InitialValue="null" ErrorMessage="Line Structure is required." Display="None" />
            <br />
            <br />
            <asp:DropDownList ID="lightList" runat="server" CssClass="DropDownList">
                <asp:ListItem Text="Select Light.." Value="null"></asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="lightFieldValidator" runat="server" ControlToValidate="lightList" InitialValue="null" ErrorMessage="Light is required." Display="None" />
            <br />
            <br />
            <asp:DropDownList ID="formList" runat="server" CssClass="DropDownList">
                <asp:ListItem Text="Select Form.." Value="null"></asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="formFieldValidator" runat="server" ControlToValidate="formList" InitialValue="null" ErrorMessage="Form is required." Display="None" />
            <br />
            <br />
            <asp:DropDownList ID="spaceList" runat="server" CssClass="DropDownList">
                <asp:ListItem Text="Select Space.." Value="null"></asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="spaceFieldValidator" runat="server" ControlToValidate="spaceList" InitialValue="null" ErrorMessage="Space is required." Display="None" />
            <br />
            <br />
            <asp:DropDownList ID="textureList" runat="server" CssClass="DropDownList">
                <asp:ListItem Text="Select Texture.." Value="null"></asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="textureFieldValidator" runat="server" ControlToValidate="textureList" InitialValue="null" ErrorMessage="Texture is required." Display="None" />
            <br />
            <br />
            <asp:DropDownList ID="patternList" runat="server" CssClass="DropDownList">
                <asp:ListItem Text="Select Pattern.." Value="null"></asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="patternFieldValidator" runat="server" ControlToValidate="patternList" InitialValue="null" ErrorMessage="Pattern is required." Display="None" />
            <br />
            <br />
            <asp:DropDownList ID="massList" runat="server" CssClass="DropDownList">
                <asp:ListItem Text="Select Mass.." Value="null"></asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="massFieldValidator" runat="server" ControlToValidate="massList" InitialValue="null" ErrorMessage="Mass is required." Display="None" />
            <br />
            <br />
        </div>
        <div id="Principles" runat="server">
            <br />
            <h2>Principles</h2>
            <asp:DropDownList ID="balanceList" runat="server" CssClass="DropDownList">
                <asp:ListItem Text="Select Balance.." Value="null"></asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="balanceFieldValidator" runat="server" ControlToValidate="balanceList" InitialValue="null" ErrorMessage="Balance is required." Display="None" />
            <br />
            <br />
            <asp:DropDownList ID="unityList" runat="server" CssClass="DropDownList">
                <asp:ListItem Text="Select Unity.." Value="null"></asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="unityFieldValidator" runat="server" ControlToValidate="unityList" InitialValue="null" ErrorMessage="Unity is required." Display="None" />
            <br />
            <br />
            <asp:DropDownList ID="harmonyList" runat="server" CssClass="DropDownList">
                <asp:ListItem Text="Select Harmony.." Value="null"></asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="harmonyFieldValidator" runat="server" ControlToValidate="harmonyList" InitialValue="null" ErrorMessage="Harmony is required." Display="None" />
            <br />
            <br />
            <asp:DropDownList ID="rhythmList" runat="server" CssClass="DropDownList">
                <asp:ListItem Text="Select Rhythm.." Value="null"></asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="rhythmFieldValidator" runat="server" ControlToValidate="rhythmList" InitialValue="null" ErrorMessage="Rhythm is required." Display="None" />
            <br />
            <br />
            <asp:DropDownList ID="proportionList" runat="server" CssClass="DropDownList">
                <asp:ListItem Text="Select Proportion.." Value="null"></asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="proportionFieldValidator" runat="server" ControlToValidate="proportionList" InitialValue="null" ErrorMessage="Proportion is required." Display="None" />
            <br />
            <br />
            <asp:DropDownList ID="varietyList" runat="server" CssClass="DropDownList">
                <asp:ListItem Text="Select Variety.." Value="null"></asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="varietyFieldValidator" runat="server" ControlToValidate="varietyList" InitialValue="null" ErrorMessage="Variety is required." Display="None" />
            <br />
            <br />
            <asp:DropDownList ID="emphasisList" runat="server" CssClass="DropDownList">
                <asp:ListItem Text="Select Emphasis.." Value="null"></asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="emphasisFieldValidator" runat="server" ControlToValidate="emphasisList" InitialValue="null" ErrorMessage="Emphasis is required." Display="None" />
            <br />
            <br />
            <asp:DropDownList ID="scaleList" runat="server" CssClass="DropDownList">
                <asp:ListItem Text="Select Scale.." Value="null"></asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="scaleFieldValidator" runat="server" ControlToValidate="scaleList" InitialValue="null" ErrorMessage="Scale is required." Display="None" />
            <br />
            <br />
        </div>
        <div id="Buttons" style="text-align: center;">
            <br />
            <br />
            <asp:Button ID="addItemBtn" runat="server" OnClick="addItemBtn_Click" CssClass="Button" Text="Submit Item" Width="130px" />
        </div>
    </asp:Panel>
    <asp:Panel ID="confirmPnl" runat="server" Visible="false">
        <asp:Image id="itemImage" runat="server" />
        <br />
        <asp:Label ID="descriptLbl" runat="server" Text="Description: "/>
        <br />
        <asp:Label ID="typeLbl" runat="server" Text="Type: "/>
        <br />
        <asp:Label ID="colorLbl" runat="server" Text="Color: " />
        <br />
        <asp:Label ID="lineLbl" runat="server" Text="Line Structure: " />
        <br />
        <asp:Label ID="lightLbl" runat="server" Text="Light: " />
        <br />
        <asp:Label ID="formLbl" runat="server" Text="Form: " />
        <br />
        <asp:Label ID="spaceLbl" runat="server" Text="Space: " />
        <br />
        <asp:Label ID="textureLbl" runat="server" Text="Texture: " />
        <br />
        <asp:Label ID="patternLbl" runat="server" Text="Pattern: " />
        <br />
        <asp:Label ID="massLbl" runat="server" Text="Mass: " />
        <br />
        <asp:Label ID="balanceLbl" runat="server" Text="Balance: " />
        <br />
        <asp:Label ID="unityLbl" runat="server" Text="Unity: " />
        <br />
        <asp:Label ID="harmonyLbl" runat="server" Text="Harmony: " />
        <br />
        <asp:Label ID="rhythmLbl" runat="server" Text="Rhythm: " />
        <br />
        <asp:Label ID="proportionLbl" runat="server" Text="Proportion: " />
        <br />
        <asp:Label ID="varietyLbl" runat="server" Text="Variety: " />
        <br />
        <asp:Label ID="emphasisLbl" runat="server" Text="Emphasis: " />
        <br />
        <asp:Label ID="scaleLbl" runat="server" Text="Scale: " />
        <br />
        <asp:Button ID="submitItemBtn" runat="server" OnClick="submitItemBtn_Click" Text="Add Item" CssClass="Button" />
    </asp:Panel>
</asp:Content>

