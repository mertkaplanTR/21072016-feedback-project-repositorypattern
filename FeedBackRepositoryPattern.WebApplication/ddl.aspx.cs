﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FeedBackRepositoryPattern.Service;
using FeedBackRepositoryPattern.DTO;

namespace FeedBackRepositoryPattern.WebApplication
{
    public partial class ddl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AdminService service = new AdminService();
            DropDownList1.DataSource = service.GetAdminList();
            DropDownList1.DataValueField = "UserID";
            DropDownList1.DataTextField = "Username"; //gosterilecek şey
            
            DropDownList1.DataBind();
            int x = Convert.ToInt32(DropDownList1.SelectedValue);
        }
    }
}