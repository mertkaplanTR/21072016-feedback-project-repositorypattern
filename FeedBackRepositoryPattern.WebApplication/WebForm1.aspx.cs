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
            
            obj.Username = txtAddUsername.Text;
            obj.Password = txtAddPassword.Text;
            obj.EmailAddress = txtAddEmailaddress.Text;
            obj.isActive = true;
            obj.AdminRole = 1;
            obj.CreatedDate = DateTime.Now;
            obj.ModifiedDate = DateTime.Now;
            admin.AddAdminServiceFunction(obj);
        }

        protected void DeleteButton_Click(object sender, EventArgs e)
        {

            AdminService admin = new AdminService();
            AdminDeleteDTO obj = new AdminDeleteDTO();
            obj.UserID = Convert.ToInt32(txtAddID.Text);
            admin.DeleteAdminServiceFunction(obj);
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            AdminService admin = new AdminService();
            AdminUpdateDTO obj2 = new AdminUpdateDTO();
            obj2.UserID = Convert.ToInt32(txtAddID.Text);
            obj2.Username = txtAddUsername.Text;
            obj2.Password = txtAddPassword.Text;
            obj2.EmailAddress = txtAddEmailaddress.Text;
            if (isActiveDropDown.Text == "active")
            {
                obj2.isActive = true;
            }
            else
                obj2.isActive = false;
           // obj2.isActive = Convert.ToBoolean(txtAddIsActive);
            obj2.AdminRole = Convert.ToInt32(txtAddAdminRole.Text);
            //obj2.CreatedDate = DateTime.Now;
            obj2.ModifiedDate = DateTime.Now;
            admin.UpdateAdminServiceFunction(obj2);
        }

 
    }




}