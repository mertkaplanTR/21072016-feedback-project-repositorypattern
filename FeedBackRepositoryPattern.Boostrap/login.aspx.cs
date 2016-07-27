using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FeedBackRepositoryPattern.Service;
using FeedBackRepositoryPattern.DTO;

namespace FeedBackRepositoryPattern.Boostrap
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ProjectService _ProjectService = new ProjectService();
            ddlProjects.DataSource = _ProjectService.GetProjectList();
            ddlProjects.DataValueField = "ProjectID";  // hafızadan tutalacak şey
            ddlProjects.DataTextField = "ProjectTitle";   //gösterilecek şey

            ddlProjects.DataBind();
            int x = Convert.ToInt32(ddlProjects.SelectedValue);
        }
    }
}