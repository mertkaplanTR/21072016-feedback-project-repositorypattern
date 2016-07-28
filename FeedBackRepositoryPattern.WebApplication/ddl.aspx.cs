using System;
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
            GetDropdown();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string x = DropDownList1.SelectedValue;
        }


        protected void GetDropdown()
        {
            ProjectService _ProjectService = new ProjectService();

            DropDownList1.DataSource = _ProjectService.GetProjectList();
            DropDownList1.DataValueField = "ProjectID";  // hafızadan tutalacak şey
            DropDownList1.DataTextField = "ProjectTitle";   //gösterilecek şey
            DropDownList1.DataBind();
        }

        protected void _OnSelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}