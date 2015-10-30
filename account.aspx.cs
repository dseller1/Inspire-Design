using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MongoDB.Driver;
using MongoDB.Bson;
using product_class;
using user_class;
using elements_class;
using database_class;

public partial class account : System.Web.UI.Page
{
    database myDB;
    user curUser;
    protected void Page_Load(object sender, EventArgs e)
    {
        myDB = (database)Session["myDB"];
        curUser = (user)Session["curUser"];
        usernameLbl.Text = curUser.Username;
        emailAddressLbl.Text = curUser.Email;
        phoneLbl.Text = curUser.Phone;
    }
    protected void changeEmailBtn_Click(object sender, EventArgs e)
    {
        emailAddressLbl.Visible = false;
        emailAddressTxt.Visible = true;
        emailAddressTxt.Text = curUser.Email;
        changeEmailBtn.Visible = false;
        changeEmailNoBtn.Visible = true;
        changeEmailYesBtn.Visible = true;
    }
    protected void changePhoneBtn_Click(object sender, EventArgs e)
    {
        phoneLbl.Visible = false;
        phoneTxt.Visible = true;
        phoneTxt.Text = curUser.Phone;
        changePhoneBtn.Visible = false;
        changePhoneNoBtn.Visible = true;
        changePhoneYesBtn.Visible = true;
    }
    protected void changeEmailNoBtn_Click(object sender, ImageClickEventArgs e)
    {
        emailAddressTxt.Visible = false;
        emailAddressLbl.Visible = true;
        changeEmailNoBtn.Visible = false;
        changeEmailYesBtn.Visible = false;
        changeEmailBtn.Visible = true;
    }
    protected void changeEmailYesBtn_Click(object sender, ImageClickEventArgs e)
    {
        
    }
    protected void changePhoneNoBtn_Click(object sender, ImageClickEventArgs e)
    {
        phoneTxt.Visible = false;
        phoneLbl.Visible = true;
        changePhoneNoBtn.Visible = false;
        changePhoneYesBtn.Visible = false;
        changePhoneBtn.Visible = true;
    }
    protected void changePhoneYesBtn_Click(object sender, ImageClickEventArgs e)
    {

    }
}