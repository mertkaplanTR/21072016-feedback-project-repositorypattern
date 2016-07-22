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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void AdminAddButton_Click(object sender, EventArgs e)
        {
            AdminService admin = new AdminService();
            AdminAddDTO obj = new AdminAddDTO();
            
            obj.Username = TextBox1.Text;
            obj.Password = TextBox2.Text;
            obj.EmailAddress = TextBox3.Text;
            obj.isActive = true;
            obj.AdminRole = 1;
            obj.CreatedDate = DateTime.Now;
            obj.ModifiedDate = DateTime.Now;
            //admin.AddAdminServiceFunction("ne turden obj yaratıp buraya gondermeli");
            admin.AddAdminServiceFunction(obj);
        }
    }
}