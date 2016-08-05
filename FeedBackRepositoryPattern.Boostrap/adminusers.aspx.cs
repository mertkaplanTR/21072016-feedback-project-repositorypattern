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
            AdminService _AdminService = new AdminService();
            AdminDeleteDTO _AdminDeleteDTO = new AdminDeleteDTO();
            GridViewRow row = grdAdminList.SelectedRow;
            //_AdminDeleteDTO.UserID= int.Parse(row.Cells[1].Text);
            //_AdminService.DeleteAdminServiceFunction(_AdminDeleteDTO);
            int GetSelectedID = int.Parse(row.Cells[1].Text);
            txtAdminUserName.Text = row.Cells[2].Text;
            txtAdminPassword.Text = row.Cells[3].Text;
            txtAdminEmailAddress.Text = row.Cells[4].Text;
        }



        protected void btnAdminAdd_Click(object sender, EventArgs e)
        {
            AdminService _AdminService = new AdminService();
            AdminAddDTO _AdminAddDTO = new AdminAddDTO();
            _AdminAddDTO.Username = txtAdminUserName.Text;
            _AdminAddDTO.Password = txtAdminPassword.Text;
            _AdminAddDTO.EmailAddress = txtAdminEmailAddress.Text;
            _AdminService.AddAdminServiceFunction(_AdminAddDTO);
            GetList();
        }


        protected void btnAdminUpdate_Click(object sender, EventArgs e)
        {
            AdminService _AdminService = new AdminService();
            AdminUpdateDTO _AdminUpdateDTO = new AdminUpdateDTO();
            GridViewRow row = grdAdminList.SelectedRow;
            _AdminUpdateDTO.UserID = int.Parse(row.Cells[1].Text);
            _AdminUpdateDTO.Username = txtAdminUserName.Text;
            _AdminUpdateDTO.Password = txtAdminPassword.Text;
            _AdminUpdateDTO.EmailAddress = txtAdminEmailAddress.Text;
            _AdminService.UpdateAdminServiceFunction(_AdminUpdateDTO);
            GetList();
        }

        protected void btnAdminDelete_Click(object sender, EventArgs e)
        {
            AdminService _AdminService = new AdminService();
            AdminDeleteDTO _AdminDeleteDTO = new AdminDeleteDTO();
            GridViewRow row = grdAdminList.SelectedRow;
            _AdminDeleteDTO.UserID= int.Parse(row.Cells[1].Text);
            if (_AdminDeleteDTO.UserID == 1)
            {
                txtAdminUserName.Text = "YOU CANNOT";
                txtAdminPassword.Text = "DELETE";
                txtAdminEmailAddress.Text = "FIST ADMIN";
            }
            else
            {
                _AdminService.DeleteAdminServiceFunction(_AdminDeleteDTO);
                GetList();
            }
        }


    }
}