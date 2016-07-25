using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FeedBackRepositoryPattern.DTO;
using FeedBackRepositoryPattern.Service;


namespace FeedBackRepositoryPattern.Web
{
    public partial class adminlogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }


        protected void btnAdminLogin_Click(object sender, EventArgs e)
        {
            AdminService admin = new AdminService();
            AdminAddDTO obj = new AdminAddDTO();
            
            
     
        }


    }
}