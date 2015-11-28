using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MongoDB.Driver;
using database_class;
using board_class;
using product_class;
using user_class;
using elements_class;

public partial class ElementsPage : System.Web.UI.Page
{
    elements el = new elements();
    product_image p = new product_image();
    database myDB;
    user curUser;
    user designUser;
    IMongoCollection<product_image> imgColl;
    List<product_image> allItems;
    IMongoCollection<board_item> usersBoardColl;
    IMongoCollection<user> userInfoColl;
    string boardName;

    protected void Page_Load(object sender, EventArgs e)
    {
        myDB = (database)Session["myDB"];
        curUser = (user)Session["curUser"];
        designUser = (user)Session["designUser"];
        userInfoColl = myDB.getUserInfoCollection();
        imgColl = myDB.getImagesCollection();
        allItems = product_image.getItems(imgColl);
        Session["imgColl"] = imgColl;
        Session["allItems"] = allItems;

        elements.loadElements(imgColl, colorList, lineList, lightList, formList, spaceList, textureList, patternList, massList, balanceList, unityList, harmonyList, rhythmList, proportionList, varietyList, emphasisList, scaleList, typeList);
        if (curUser.Account_Type == "client")
        {
            boardPnl.Visible = true;
            usersBoardColl = myDB.getUsersBoardCollection(curUser);
            board_item.loadBoards(usersBoardColl, boardNameList);
        }
        else if (curUser.Account_Type == "designer")
        {
            designerPnl.Visible = true;
            user.loadUsers(userInfoColl, designerUserList, curUser);
        }
    }
    protected void createBoardBtn_Click(object sender, EventArgs e)
    {
        newBoardPnl.Visible = true;
    }
    protected void newBoardBtn_Click(object sender, EventArgs e)
    {
        if (!boardNameList.Items.Contains(new ListItem(newBoardTxt.Text)))
        {
            boardNameList.Items.Add(new ListItem(newBoardTxt.Text));
            boardLbl.Text = "Board created successfully.";
        }
        else
        {
            boardLbl.Text = "Board already exists.";
        }
        newBoardPnl.Visible = false;
    }
    protected void elementsBtn_Click(object sender, EventArgs e)
    {
        Page page = (Page)HttpContext.Current.Handler;
        elements.setElements(colorList, lineList, lightList, formList, spaceList, textureList, patternList, massList, balanceList, unityList, harmonyList, rhythmList, proportionList, varietyList, emphasisList, scaleList, typeList, el, page);
        Session["el"] = el;
        List<product_image> queryItems = allItems;
        queryItems = product_image.queryProducts(queryItems, el);
        p = queryItems[0];
        if (p.ID != 0)
        {
            int i = 0;
            Session["i"] = i;
            Session["p"] = p;
            Session["queryItems"] = queryItems;
            Response.Redirect("~/main.aspx");
        }
        else
        {
            label1.Text = "No items exist with those elements/principles.";
        }
    }
    protected void chooseBrdBtn_Click(object sender, EventArgs e)
    {
        if (boardNameList.SelectedItem.Value != "null")
        {
            boardPnl.Visible = false;
            optionsPnl.Visible = true;
           // buttonsPnl.Visible = true;
            boardName = boardNameList.SelectedItem.Value;
            Session["boardName"] = boardName;
        }
        else
        {
            boardLbl.Text = "Please select a board.";
        }
    }
    protected void changeBoardBtn_Click(object sender, EventArgs e)
    {
        boardPnl.Visible = true;
        optionsPnl.Visible = false;
        boardNameList.ClearSelection();
       // buttonsPnl.Visible = false;
    }
    protected void selectUsrBtn_Click(object sender, EventArgs e)
    {
        if (designerUserList.SelectedItem.Value != "null")
        {
            designUser = user.findUser(userInfoColl, designerUserList.SelectedItem.Text);
            Session["designUser"] = designUser;
            usersBoardColl = myDB.getUsersBoardCollection(designUser);
            board_item.loadBoards(usersBoardColl, boardNameList);
            userPnl.Visible = false;
            boardPnl.Visible = true;
        }
        else
        {
            userLbl.Text = "Please select a user.";
        }
    }
    protected void clearSelectionsBtn_Click(object sender, EventArgs e)
    {
        colorList.ClearSelection();
        lineList.ClearSelection();
        lightList.ClearSelection();
        formList.ClearSelection();
        spaceList.ClearSelection();
        textureList.ClearSelection();
        patternList.ClearSelection();
        massList.ClearSelection();
        balanceList.ClearSelection();
        unityList.ClearSelection();
        harmonyList.ClearSelection();
        rhythmList.ClearSelection();
        proportionList.ClearSelection();
        varietyList.ClearSelection();
        emphasisList.ClearSelection();
        scaleList.ClearSelection();
    }
    protected void accountsBtn_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/account.aspx");
    }
}