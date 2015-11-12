﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void logoutBtn_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Response.Redirect("~/login.aspx");
    }

    protected void settingsBtn_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("~/account.aspx");
    }
}
