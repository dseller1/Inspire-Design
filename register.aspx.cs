using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using user_class;
using MongoDB.Driver;
using MongoDB.Bson;
using database_class;

public partial class RegisterPage : System.Web.UI.Page
{
    database myDB;
    IMongoCollection<user> userInfoColl;
    protected void Page_Load(object sender, EventArgs e)
    {
        myDB = (database)Session["myDB"];
        userInfoColl = myDB.getUserInfoCollection();
    }
    protected void createAccBtn_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            if (passwordTxt.Text == cnfrmPassTxt.Text)
            {
                user newUser = new user();
                newUser.Username = usernameTxt.Text;
                newUser.Password = user.HashPassword(passwordTxt.Text);
                newUser.Email = emailTxt.Text;
                newUser.Phone = phoneTxt.Text;
                if (accountTypeBox.Checked == true)
                {
                    newUser.Account_Type = "designer";
                }
                if (user.checkUsername(userInfoColl, newUser).Count() == 0)
                {
                    if (user.checkEmail(userInfoColl, newUser).Count() == 0)
                    {
                        myDB.insertUserInfoDoc(userInfoColl, newUser);
                        Response.Redirect("~/login.aspx");
                    }
                    else
                    {
                        errorTxt.Text = "Email is already in use.";
                    }
                }
                else
                {
                    errorTxt.Text = "Username is already taken.";
                }
            }
            else
            {
                errorTxt.Text = "Passwords do not match.";
            }
        }
    }
    protected void backToLoginBtn_Click(object sender, EventArgs e)
    {
        passwordFieldValidator.Enabled = false;
        Response.Redirect("~/login.aspx");
    }
}