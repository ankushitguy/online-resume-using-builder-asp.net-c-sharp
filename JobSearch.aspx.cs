﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class JobSearch : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.Page.User.Identity.IsAuthenticated)
        {
            Response.Redirect("~/LoginPlease.aspx");

        }
        else
        {
            Response.Redirect("http://www.careerjet.co.in/search/jobs?s=" + Application["Resume3"] + "&l=maharashtra");
        }
    }
}