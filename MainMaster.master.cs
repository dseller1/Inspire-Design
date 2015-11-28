using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using user_class;

public partial class MasterPage : System.Web.UI.MasterPage
{
    user curUser;

    protected void Page_Load(object sender, EventArgs e)
    {
        curUser = (user)Session["curUser"];
        if (curUser.Account_Type == "designer")
        {
            accountTypeLink.InnerText = "Designer";
            accountTypeLink.HRef = "designer.aspx";
        }
        else
        {
            accountTypeLink.InnerText = "Maps";
            accountTypeLink.HRef = "maps.aspx";
        }
    }
    protected void logoutBtn_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/login.aspx");
    }

    protected void settingsBtn_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("~/account.aspx");
    }
}
