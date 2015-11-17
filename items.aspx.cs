using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MongoDB.Driver;
using MongoDB.Bson;
using product_class;
using database_class;
using user_class;
using board_class;
using elements_class;

public partial class ItemsPage : System.Web.UI.Page
{
    List<product_image> images;
    IMongoCollection<product_image> imgColl;
    IMongoCollection<board_item> usersBoardColl;
    IMongoCollection<user> userInfoColl;
    product_image p = new product_image();
    database myDB;
    user curUser;
    user designUser;
    string boardName;
    elements el = new elements();
    protected void Page_Load(object sender, EventArgs e)
    {
        myDB = (database)Session["myDB"];
        boardName = (string)Session["boardName"];
        curUser = (user)Session["curUser"];
        designUser = (user)Session["designUser"];
        userInfoColl = myDB.getUserInfoCollection();
        images = (List<product_image>)Session["allItems"];
        imgColl = myDB.getImagesCollection();
        elements.loadElements(imgColl, colorList, lineList, lightList, formList, spaceList, textureList, patternList, massList, balanceList, unityList, harmonyList, rhythmList, proportionList, varietyList, emphasisList, scaleList, typeList);

        if (curUser.Account_Type == "client")
        {
            usersBoardColl = myDB.getUsersBoardCollection(curUser);
            userNameLbl.Text = curUser.Username;
            board_item.loadBoards(usersBoardColl, boardNameList);
        }
        else if (curUser.Account_Type == "designer")
        {
            if (designUser != null)
            {
                usersBoardColl = myDB.getUsersBoardCollection(designUser);
                userNameLbl.Text = designUser.Username;
            }
            else
            {
                userNameLbl.Text = curUser.Username;
                usersBoardColl = myDB.getUsersBoardCollection(curUser);
            }
            switchUserBtn.Visible = true;
            user.loadUsers(userInfoColl, designerUserList, curUser);
        }
        boardNameLbl.Text = boardName;

        if (boardName != null)
        {
            optionsPnl.Visible = true;
            boardNamePnl.Visible = true;
            if (curUser.Account_Type == "designer")
            {
                userNamePnl.Visible = true;
            }
        }
        else
        {
            boardNamePnl.Visible = false;
            userNamePnl.Visible = false;
            if (curUser.Account_Type == "designer")
            {
                switchUserPnl.Visible = true;
            }
            else
            {
                changeBoardPnl.Visible = true;
            }
        }
    }
    public DataTable getItemsData()
    {
        DataTable dt = new DataTable();
        int i = 1;
        images = product_image.queryProducts(images, el);
        int itemsCount = images.Count;
        dt.Columns.Add(new DataColumn("PictureURL1", typeof(string)));
        dt.Columns.Add(new DataColumn("PictureURL2", typeof(string)));
        dt.Columns.Add(new DataColumn("PictureURL3", typeof(string)));
        dt.Columns.Add(new DataColumn("PictureURL4", typeof(string)));
        DataRow dr = dt.NewRow();
        foreach (product_image item in images)
        {
            if (i <= 4)
            {
                if (itemsCount != 0)
                {
                    dr["PictureURL" + i.ToString()] = item.Image_Link;
                    i++;
                    itemsCount--;
                    if (itemsCount == 0)
                    {
                        dt.Rows.Add(dr);
                    }
                }
                else
                {
                    dt.Rows.Add(dr);
                }
            }
            else
            {
                i = 1;
                dt.Rows.Add(dr);
                dr = dt.NewRow();
                if (itemsCount != 0)
                {
                    dr["PictureURL" + i.ToString()] = item.Image_Link;
                    i++;
                    itemsCount--;
                }
                if (itemsCount == 0)
                {
                    dt.Rows.Add(dr);
                }
            }
        }
        return dt;
    }
    protected void showItemsBtn_Click(object sender, EventArgs e)
    {
        Page page = (Page)HttpContext.Current.Handler;
        elements.setElements(colorList, lineList, lightList, formList, spaceList, textureList, patternList, massList, balanceList, unityList, harmonyList, rhythmList, proportionList, varietyList, emphasisList, scaleList, typeList, el, page);
        Page.DataBind();
    }
    protected void backToElementsBtn_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/elements.aspx");
    }
    protected void itemsGrid_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Add_Item")
        {
            board_item b = new board_item();
            string link = e.CommandArgument.ToString();
            p = findItemAddToBoard(link, imgColl);
            b = board_item.productToBoardConversion(p);
            b.Board_Name = boardName;
            myDB.insertBoardDoc(usersBoardColl, b);
        }
    }
    protected product_image findItemAddToBoard(string link, IMongoCollection<product_image> coll)
    {
        product_image p = new product_image();
        List<product_image> items = coll.Find(itm => itm.Image_Link == link)
               .ToListAsync()
               .Result;
        foreach (product_image itm in items)
        {
            p = itm;
        }
        return p;
    }
    protected void chooseBrdBtn_Click(object sender, EventArgs e)
    {
        if (boardNameList.SelectedItem.Value != "null")
        {
            changeBoardPnl.Visible = false;
            optionsPnl.Visible = true;
            itemsGrid.Visible = true;
            boardName = boardNameList.SelectedItem.Value;
            boardNamePnl.Visible = true;
            Session["boardName"] = boardName;
            Response.Redirect(Request.RawUrl);
        }
        else
        {
            boardErrLbl.Text = "Please select a board.";
        }
    }
    protected void changeBoardBtn_Click(object sender, EventArgs e)
    {
        if (curUser.Account_Type == "designer")
        {
            board_item.loadBoards(usersBoardColl, boardNameList);
        }
        boardName = null;
        Session["boardName"] = boardName;
        changeBoardPnl.Visible = true;
        itemsGrid.Visible = false;
        optionsPnl.Visible = false;
        boardNamePnl.Visible = false;
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
            boardErrLbl.Text = "Board created successfully.";
        }
        else
        {
            boardErrLbl.Text = "Board already exists.";
        }
        newBoardPnl.Visible = false;
    }
    protected void itemsGrid_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        itemsGrid.PageIndex = e.NewPageIndex;
        itemsGrid.DataBind();
    }
    protected void selectUsrBtn_Click(object sender, EventArgs e)
    {
        if (designerUserList.SelectedItem.Value != "null")
        {
            designUser = user.findUser(userInfoColl, designerUserList.SelectedItem.Text);
            Session["designUser"] = designUser;
            userNameLbl.Text = designUser.Username;
            usersBoardColl = myDB.getUsersBoardCollection(designUser);
            board_item.loadBoards(usersBoardColl, boardNameList);
            changeBoardPnl.Visible = true;
            switchUserPnl.Visible = false;
            userNamePnl.Visible = true;
            boardNamePnl.Visible = false;
            optionsPnl.Visible = false;
        }
        else
        {
            userErrLbl.Text = "Please select a user.";
        }
    }
    protected void switchUserBtn_Click(object sender, EventArgs e)
    {
        boardName = null;
        Session["boardName"] = boardName;
        designUser = null;
        Session["designUser"] = designUser;
        boardNamePnl.Visible = false;
        userNamePnl.Visible = false;
        optionsPnl.Visible = false;
        switchUserPnl.Visible = true;
    }
}