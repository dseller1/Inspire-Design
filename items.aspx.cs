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
    product_image p = new product_image();
    database myDB;
    user curUser;
    string boardName;
    elements el = new elements();
    protected void Page_Load(object sender, EventArgs e)
    {
        myDB = (database)Session["myDB"];
        curUser = (user)Session["curUser"];
        boardName = (string)Session["boardName"];
        images = (List<product_image>)Session["allItems"];
        imgColl = myDB.getImagesCollection();
        usersBoardColl = myDB.getUsersBoardCollection(curUser);
        board_item.loadBoards(usersBoardColl, boardNameList);
        elements.loadElements(imgColl, colorList, lineList, lightList, formList, spaceList, textureList, patternList, massList, balanceList, unityList, harmonyList, rhythmList, proportionList, varietyList, emphasisList, scaleList, typeList);
        boardNameLbl.Text = "Selected Board: " + boardName;
    }
    public DataTable getItemsData()
    {
        DataTable dt = new DataTable();
        int i = 1;
        images = product_image.queryProducts(images, el);
        int itemsCount = images.Count;
        dt.Columns.Add(new DataColumn("PictureURL1", typeof(string)));
        DataRow dr = dt.NewRow();
        foreach (product_image item in images)
        {
            dr["PictureURL" + i.ToString()] = item.Image_Link;
            dt.Rows.Add(dr);
            dr = dt.NewRow();
        }
        return dt;
    }
    protected void showItemsBtn_Click(object sender, EventArgs e)
    {
        elements.setElements(colorList, lineList, lightList, formList, spaceList, textureList, patternList, massList, balanceList, unityList, harmonyList, rhythmList, proportionList, varietyList, emphasisList, scaleList, typeList, el);
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
        boardPnl.Visible = false;
        optionsPnl.Visible = true;
        itemsGrid.Visible = true;
        boardName = boardNameList.SelectedItem.Value;
        Session["boardName"] = boardName;
        Response.Redirect(Request.RawUrl);
    }
    protected void changeBoardBtn_Click(object sender, EventArgs e)
    {
        boardPnl.Visible = true;
        itemsGrid.Visible = false;
        optionsPnl.Visible = false;
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
}