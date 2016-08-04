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
    public partial class adminusers : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            GetList();
        }
        
        void GetList()
        {
            AdminService _AdminService = new AdminService();
            grdAdminList.DataSource = _AdminService.GetAdminList();
            grdAdminList.DataBind();
            
        }

        protected void grdAdminList_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = grdAdminList.SelectedRow;
            string x = row.Cells[2].Text;
        }
    }
}