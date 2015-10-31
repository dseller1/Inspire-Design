using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using System.Web.Security;
using MongoDB.Driver;
using MongoDB.Bson;
using product_class;
using database_class;
using user_class;
using board_class;

public partial class StartPage : System.Web.UI.Page
{
    database myDB = new database();
    user curUser = new user();
    board_item myBoard = new board_item();
    IMongoCollection<user> userInfoColl;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            // Connect to the Products databases
            myDB.connectToProductsDatabase();
            // Connect to the Accounts database
            myDB.connectToAccountsDatabase();
        }
        catch (Exception ex)
        {
            errorTxt.Text = ex.Message;
        }

        // Get the Users Info collection and store it in userInfoColl;
        userInfoColl = myDB.getUserInfoCollection();

        // Store the myDB variable for use in other pages
        Session["myDB"] = myDB;
    }
    protected void loginBtn_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            curUser = user.findUser(userInfoColl, usernameTxt.Text);

            if (user.ValidatePassword(passwordTxt.Text, curUser.Password) == true && curUser != null)
            {
                try
                {
                    myDB.connectToBoardsDatabase(curUser);
                    Session["myBoard"] = myBoard;
                    Session["curUser"] = curUser;
                    // Move to the MainPage
                    Response.Redirect("~/elements.aspx");
                }
                catch (Exception ex)
                {
                    errorTxt.Text = ex.Message;
                }
            }
            else
            {
                errorTxt.Text = "Incorrect Username and/or Password.";
            }
        }
    }


    protected void registerBtn_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/register.aspx");
    }
}