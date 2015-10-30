using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MongoDB.Driver;
using database_class;
using board_class;
using user_class;
using product_class;

public partial class BoardsPage : System.Web.UI.Page
{
    IMongoCollection<board_item> usersBoardColl;
    IMongoCollection<user> userInfoColl;
    database myDB;
    user curUser;
    user designUser;

    protected void Page_Load(object sender, EventArgs e)
    {
        myDB = (database)Session["myDB"];
        curUser = (user)Session["curUser"];
        designUser = (user)Session["designUser"];
        userInfoColl = myDB.getUserInfoCollection();

        if (designUser != null)
        {
            usersBoardColl = myDB.getUsersBoardCollection(designUser);
        }
        if (curUser.Account_Type == "client")
        {
            boardPnl.Visible = true;
            usersBoardColl = myDB.getUsersBoardCollection(curUser);
            board_item.loadBoards(usersBoardColl, boardNameList);
        }
        else if (curUser.Account_Type == "designer")
        {
            designerPnl.Visible = true;
            switchUserBtn.Visible = true;
            user.loadUsers(userInfoColl, designerUserList, curUser);
        }
    }
    protected void boardSbmtBtn_Click(object sender, EventArgs e)
    {
        if (boardNameList.SelectedItem.Value != "null")
        {
            boardItemsGrid.Visible = true;
            Page.DataBind();
            boardLbl.Text = "";
        }
        else
        {
            boardLbl.Text = "Please select a board.";
        }
    }
    public DataTable getBoardData()
    {
        DataTable dt = new DataTable();
        List<board_item> items = board_item.findBoardItems(usersBoardColl, boardNameList.SelectedItem.Text);
        dt.Columns.Add(new DataColumn("ItemID", typeof(int)));
        dt.Columns.Add(new DataColumn("PictureURL", typeof(string)));
        dt.Columns.Add(new DataColumn("Description", typeof(string)));
        foreach (board_item item in items)
        {
            DataRow dr = dt.NewRow();
            dr["ItemID"] = item.ID;
            dr["PictureURL"] = item.Image_Link;
            dr["Description"] = item.Description;
            dt.Rows.Add(dr);
        }
        return dt;
    }
    protected void backToMainBtn_Click(object sender, EventArgs e)
    {
        Session["usersBoardColl"] = usersBoardColl;
        Response.Redirect("~/elements.aspx");
    }
    protected void boardItemsGrid_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Delete_Item")
        {
            int id = Convert.ToInt32(e.CommandArgument);
            myDB.deleteBoardDoc(usersBoardColl, id, boardNameList.SelectedItem.Value.ToString());
            Page.DataBind();
        }
    }
    protected void switchUserBtn_Click(object sender, EventArgs e)
    {
        userLbl.Text = "";
        designerUserList.ClearSelection();
        ListItem def = boardNameList.Items[0];
        boardNameList.Items.Clear();
        boardNameList.Items.Add(def);
        boardNameList.ClearSelection();
        boardPnl.Visible = false;
        userPnl.Visible = true;
        boardItemsGrid.Visible = false;
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
}