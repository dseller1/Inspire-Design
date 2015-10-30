using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing.Drawing2D;
using MongoDB.Driver;
using MongoDB.Bson;
using product_class;
using database_class;
using user_class;
using board_class;
using elements_class;

public partial class MainPage : System.Web.UI.Page
{
    // Declare global variables
    database myDB;
    elements el;
    product_image p = new product_image();
    board_item myBoard = new board_item();
    List<product_image> allItems;
    IMongoCollection<board_item> usersBoardColl;
    user curUser;
    string boardName;

    protected void Page_Load(object sender, EventArgs e)
    {
        el = (elements)Session["el"];
        myDB = (database)Session["myDB"];
        curUser = (user)Session["curUser"];
        boardName = (string)Session["boardName"];
        allItems = (List<product_image>)Session["allItems"];
        usersBoardColl = myDB.getUsersBoardCollection(curUser);
        p = (product_image)Session["p"];
        setImage(p);
    }
    public void setImage(product_image p)
    {
        Image1.ImageUrl = p.Image_Link;
    }
    protected void checkmarkButton_Click(object sender, ImageClickEventArgs e)
    {
        myBoard = board_item.productToBoardConversion(p);
        myBoard.Board_Name = boardName;
        if (myDB.insertBoardDoc(usersBoardColl, myBoard))
        {
            displayLbl.Text = "Item added successfully.";
        }
        else
        {
            displayLbl.Text = "Item already exists in current board.";
        }
        p = p.findProduct(allItems, myDB, el);
        setImage(p);
        Session["p"] = p;
        Session["myDB"] = myDB;

    }
    protected void xButton_Click(object sender, ImageClickEventArgs e)
    {
        displayLbl.Text = "";
        p = p.findProduct(allItems, myDB, el);
        setImage(p);
        Session["p"] = p;
    }
    protected void showBoardsBtn_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/boards.aspx");
    }
    protected void logoutBtn_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/login.aspx");
    }
    protected void showItemsBtn_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/items.aspx");
    }
    protected void elementsBtn_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/elements.aspx");
    }

    protected void showInspiration_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/inspiration.aspx");
    }
}