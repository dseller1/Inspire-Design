using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MongoDB.Bson;
using MongoDB.Driver;
using database_class;
using board_class;
using user_class;
using product_class;

public partial class inspiration : System.Web.UI.Page
{
    database myDB;
    string boardName;
    user curUser;
    IMongoCollection<board_item> usersBoardColl;
    user designUser;

    protected void Page_Load(object sender, EventArgs e)
    {
        myDB = (database)Session["myDB"];
        boardName = (string)Session["boardName"];
        curUser = (user)Session["curUser"];
        designUser = (user)Session["designUser"];
        if (designUser != null)
        {
            usersBoardColl = myDB.getUsersBoardCollection(designUser);
        }
        else
        {
            usersBoardColl = myDB.getUsersBoardCollection(curUser);
        }
        if (curUser.Account_Type == "designer")
        {
            userPnl.Visible = true;
        }
        boardNameLbl.Text = boardName;
        userNameLbl.Text = curUser.Username;
        board_item.loadBoards(usersBoardColl, boardNameList);
        if (boardName != null)
        {
            loadImages(usersBoardColl, boardName);
        }
        else
        {
            boardPnl.Visible = false;
            changeBoardPnl.Visible = true;
        }
        
    }
    public void loadImages(IMongoCollection<board_item> coll, string boardName)
    {
        loadColors(usersBoardColl, boardName);
        loadChairs(usersBoardColl, boardName);
        loadRugs(usersBoardColl, boardName);
        loadPatterns(usersBoardColl, boardName);
        loadRooms(usersBoardColl, boardName);
        loadOttomans(usersBoardColl, boardName);
    }
    public void loadColors(IMongoCollection<board_item> coll, string boardName)
    {
        List<board_item> colors = coll.Find(brd => brd.Type == "Color" && brd.Board_Name == boardName)
            .ToListAsync()
            .Result;

        int i = 1;
        foreach (board_item color in colors)
        {
            if (i == 1)
            {
                colorPlace1.ImageUrl = color.Image_Link;
                i++;
            }
            else if (i == 2)
            {
                colorPlace2.ImageUrl = color.Image_Link;
                i++;
            }
            else if (i == 3)
            {
                colorPlace3.ImageUrl = color.Image_Link;
            }
        }
    }
    public void loadChairs(IMongoCollection<board_item> coll, string boardName)
    {
        List<board_item> chairs = coll.Find(brd => brd.Type == "Chair" && brd.Board_Name == boardName)
            .ToListAsync()
            .Result;

        int i = 1;
        foreach (board_item chair in chairs)
        {
            if (i == 1)
            {
                chairPlace1.ImageUrl = chair.Image_Link;
                i++;
            }
            else if (i == 2)
            {
                chairPlace2.ImageUrl = chair.Image_Link;
                i++;
            }
            else if (i == 3)
            {
                chairPlace3.ImageUrl = chair.Image_Link;
            }
        }
    }
    public void loadRugs(IMongoCollection<board_item> coll, string boardName)
    {
        List<board_item> rugs = coll.Find(brd => brd.Type == "Rugs" && brd.Board_Name == boardName)
            .ToListAsync()
            .Result;

        int i = 1;
        foreach (board_item rug in rugs)
        {
            if (i == 1)
            {
                rugPlace1.ImageUrl = rug.Image_Link;
                i++;
            }
            else if (i == 2)
            {
                rugPlace2.ImageUrl = rug.Image_Link;
                i++;
            }
            else if (i == 3)
            {
                rugPlace3.ImageUrl = rug.Image_Link;
            }
        }
    }
    public void loadPatterns(IMongoCollection<board_item> coll, string boardName)
    {
        List<board_item> patterns = coll.Find(brd => brd.Type == "Pattern" && brd.Board_Name == boardName)
            .ToListAsync()
            .Result;

        int i = 1;
        foreach (board_item pattern in patterns)
        {
            if (i == 1)
            {
                patternPlace1.ImageUrl = pattern.Image_Link;
                i++;
            }
            else if (i == 2)
            {
                patternPlace2.ImageUrl = pattern.Image_Link;
                i++;
            }
            else if (i == 3)
            {
                patternPlace3.ImageUrl = pattern.Image_Link;
            }
        }
    }
    public void loadRooms(IMongoCollection<board_item> coll, string boardName)
    {
        List<board_item> rooms = coll.Find(brd => brd.Type == "LivingRoom" && brd.Board_Name == boardName)
            .ToListAsync()
            .Result;

        int i = 1;
        foreach (board_item room in rooms)
        {
            if (i == 1)
            {
                roomPlace1.ImageUrl = room.Image_Link;
                i++;
            }
            else if (i == 2)
            {
                roomPlace2.ImageUrl = room.Image_Link;
                i++;
            }
            else if (i == 3)
            {
                roomPlace3.ImageUrl = room.Image_Link;
            }
        }
    }
    public void loadOttomans(IMongoCollection<board_item> coll, string boardName)
    {
        List<board_item> ottomans = coll.Find(brd => brd.Type == "Ottoman" && brd.Board_Name == boardName)
            .ToListAsync()
            .Result;

        int i = 1;
        foreach (board_item otm in ottomans)
        {
            if (i == 1)
            {
                ottomanPlace1.ImageUrl = otm.Image_Link;
                i++;
            }
            else if (i == 2)
            {
                ottomanPlace2.ImageUrl = otm.Image_Link;
                i++;
            }
            else if (i == 3)
            {
                ottomanPlace3.ImageUrl = otm.Image_Link;
            }
        }
    }

    protected void changeBoardBtn_Click(object sender, EventArgs e)
    {
        boardPnl.Visible = false;
        changeBoardPnl.Visible = true;
    }
    protected void boardSbmtBtn_Click(object sender, EventArgs e)
    {
        if (boardNameList.SelectedItem.Value != "null")
        {
            boardName = boardNameList.SelectedItem.Value.ToString();
            Session["boardName"] = boardName;
            changeBoardPnl.Visible = false;
            boardPnl.Visible = true;
            loadImages(usersBoardColl, boardName);
        }
        else
        {
            boardErrLbl.Text = "Please select a board.";
        }
    }
}