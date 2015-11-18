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
    IMongoCollection<user> userInfoColl;
    user designUser;

    protected void Page_Load(object sender, EventArgs e)
    {
        myDB = (database)Session["myDB"];
        boardName = (string)Session["boardName"];
        curUser = (user)Session["curUser"];
        designUser = (user)Session["designUser"];
        userInfoColl = myDB.getUserInfoCollection();
        boardNameLbl.Text = boardName;
        userNameLbl.Text = curUser.Username;
        userErrLbl.Text = "";
        boardErrLbl.Text = "";
        if (curUser.Account_Type == "client")
        {
            userNamePnl.Visible = false;
            usersBoardColl = myDB.getUsersBoardCollection(curUser);
            board_item.loadBoards(usersBoardColl, boardNameList);
        }
        else if (curUser.Account_Type == "designer")
        {
            userNamePnl.Visible = true;
            switchUserBtn.Visible = true;
            if (designUser != null)
            {
                usersBoardColl = myDB.getUsersBoardCollection(designUser);
                userNameLbl.Text = designUser.Username;
            }
            else
            {
                usersBoardColl = myDB.getUsersBoardCollection(curUser);
            }
            user.loadUsers(userInfoColl, designerUserList, curUser);
        }
        if (!Page.IsPostBack)
        {

            boardNamePnl.Visible = true;
            resetBoard();
            if (boardName != null)
            {
                loadImages(usersBoardColl, boardName);
                inspirationPnl.Visible = true;
            }
            else
            {
                inspirationPnl.Visible = false;
                userNamePnl.Visible = false;
                boardNamePnl.Visible = false;
                changeBoardBtn.Visible = false;
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
                colorPlace2.ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/70/Solid_white.svg/2000px-Solid_white.svg.png";
            }
            else if (i == 2)
            {
                colorPlace2.ImageUrl = color.Image_Link;
                i++;
                colorPlace3.ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/70/Solid_white.svg/2000px-Solid_white.svg.png";
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
                chairPlace2.ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/70/Solid_white.svg/2000px-Solid_white.svg.png";
            }
            else if (i == 2)
            {
                chairPlace2.ImageUrl = chair.Image_Link;
                i++;
                chairPlace3.ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/70/Solid_white.svg/2000px-Solid_white.svg.png";
            }
            else if (i == 3)
            {
                chairPlace3.ImageUrl = chair.Image_Link;
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
                ottomanPlace2.ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/70/Solid_white.svg/2000px-Solid_white.svg.png";
            }
            else if (i == 2)
            {
                ottomanPlace2.ImageUrl = otm.Image_Link;
                i++;
                ottomanPlace3.ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/70/Solid_white.svg/2000px-Solid_white.svg.png";
            }
            else if (i == 3)
            {
                ottomanPlace3.ImageUrl = otm.Image_Link;
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
                rugPlace2.ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/70/Solid_white.svg/2000px-Solid_white.svg.png";
            }
            else if (i == 2)
            {
                rugPlace2.ImageUrl = rug.Image_Link;
                i++;
                rugPlace3.ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/70/Solid_white.svg/2000px-Solid_white.svg.png";
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
                patternPlace2.ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/70/Solid_white.svg/2000px-Solid_white.svg.png";
            }
            else if (i == 2)
            {
                patternPlace2.ImageUrl = pattern.Image_Link;
                i++;
                patternPlace3.ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/70/Solid_white.svg/2000px-Solid_white.svg.png";
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
                roomPlace2.ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/70/Solid_white.svg/2000px-Solid_white.svg.png";
            }
            else if (i == 2)
            {
                roomPlace2.ImageUrl = room.Image_Link;
                i++;
                roomPlace3.ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/70/Solid_white.svg/2000px-Solid_white.svg.png";
            }
            else if (i == 3)
            {
                roomPlace3.ImageUrl = room.Image_Link;
            }
        }
    }

    public void resetBoard()
    {
        colorPlace1.ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/70/Solid_white.svg/2000px-Solid_white.svg.png";
        colorPlace2.ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/70/Solid_white.svg/2000px-Solid_white.svg.png";
        colorPlace3.ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/70/Solid_white.svg/2000px-Solid_white.svg.png";
        chairPlace1.ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/70/Solid_white.svg/2000px-Solid_white.svg.png";
        chairPlace2.ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/70/Solid_white.svg/2000px-Solid_white.svg.png";
        chairPlace3.ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/70/Solid_white.svg/2000px-Solid_white.svg.png";
        rugPlace1.ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/70/Solid_white.svg/2000px-Solid_white.svg.png";
        rugPlace2.ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/70/Solid_white.svg/2000px-Solid_white.svg.png";
        rugPlace3.ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/70/Solid_white.svg/2000px-Solid_white.svg.png";
        patternPlace1.ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/70/Solid_white.svg/2000px-Solid_white.svg.png";
        patternPlace2.ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/70/Solid_white.svg/2000px-Solid_white.svg.png";
        patternPlace3.ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/70/Solid_white.svg/2000px-Solid_white.svg.png";
        roomPlace1.ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/70/Solid_white.svg/2000px-Solid_white.svg.png";
        roomPlace2.ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/70/Solid_white.svg/2000px-Solid_white.svg.png";
        roomPlace3.ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/70/Solid_white.svg/2000px-Solid_white.svg.png";
        ottomanPlace1.ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/70/Solid_white.svg/2000px-Solid_white.svg.png";
        ottomanPlace2.ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/70/Solid_white.svg/2000px-Solid_white.svg.png";
        ottomanPlace3.ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/70/Solid_white.svg/2000px-Solid_white.svg.png";
    }
    protected void changeBoardBtn_Click(object sender, EventArgs e)
    {
        resetBoard();
        boardName = null;
        Session["boardName"] = boardName;
        if (curUser.Account_Type == "designer")
        {
            usersBoardColl = myDB.getUsersBoardCollection(designUser);
            board_item.loadBoards(usersBoardColl, boardNameList);
            userNamePnl.Visible = true;
        }
        boardNameList.ClearSelection();
        boardNamePnl.Visible = false;
        changeBoardBtn.Visible = false;
        inspirationPnl.Visible = false;
        changeBoardPnl.Visible = true;
    }
    protected void boardSbmtBtn_Click(object sender, EventArgs e)
    {
        if (boardNameList.SelectedItem.Value != "null")
        {
            boardName = boardNameList.SelectedItem.Value;
            Session["boardName"] = boardName;
            boardNameLbl.Text = boardName;
            if (curUser.Account_Type == "designer")
            {
                userNamePnl.Visible = true;
            }
            changeBoardPnl.Visible = false;
            changeBoardBtn.Visible = true;
            inspirationPnl.Visible = true;
            boardNamePnl.Visible = true;
            changeBoardBtn.Visible = true;
            switchUserPnl.Visible = false;
            loadImages(usersBoardColl, boardName);
        }
        else
        {
            boardErrLbl.Text = "Please select a board.";
        }
    }
    protected void selectUsrBtn_Click(object sender, EventArgs e)
    {
        if (designerUserList.SelectedItem.Value != "null")
        {
            designUser = user.findUser(userInfoColl, designerUserList.SelectedItem.Value);
            Session["designUser"] = designUser;
            usersBoardColl = myDB.getUsersBoardCollection(designUser);
            board_item.loadBoards(usersBoardColl, boardNameList);
            changeBoardPnl.Visible = true;
            userNamePnl.Visible = true;
            boardNamePnl.Visible = false;
            userNameLbl.Text = designUser.Username;
            switchUserPnl.Visible = false;
            userLbl.Visible = true;
        }
        else
        {
            userErrLbl.Text = "Please select a user.";
        }
    }
    protected void switchUserBtn_Click(object sender, EventArgs e)
    {
        userErrLbl.Text = "";
        designerUserList.ClearSelection();
        designUser = null;
        Session["designUser"] = designUser;
        ListItem def = boardNameList.Items[0];
        boardNameList.Items.Clear();
        boardNameList.Items.Add(def);
        boardNameList.ClearSelection();
        userNamePnl.Visible = false;
        boardNamePnl.Visible = false;
        changeBoardBtn.Visible = false;
        changeBoardPnl.Visible = false;
        switchUserPnl.Visible = true;
    }
}
