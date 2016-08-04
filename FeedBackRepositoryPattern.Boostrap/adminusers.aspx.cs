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
            string x = row.Cells[1].Text;
            _AdminDeleteDTO.UserID= int.Parse(row.Cells[1].Text);
            //_AdminDeleteDTO.Username = row.Cells[1].Text;
            //_AdminDeleteDTO.Password = row.Cells[2].Text;
            //_AdminDeleteDTO.EmailAddress = row.Cells[3].Text;
            //_AdminDeleteDTO.isActive = true;
            //_AdminDeleteDTO.AdminRole = 6; ////değiş 1 yap
            //_AdminDeleteDTO.ModifiedDate = Convert.ToDateTime(row.Cells[7].Text);
            //_AdminDeleteDTO.CreatedDate = Convert.ToDateTime(row.Cells[6].Text);
            //_AdminService.DeleteAdminServiceFunction(_AdminDeleteDTO);
            _AdminService.DeleteAdminServiceFunction(_AdminDeleteDTO);
        }
    }
}