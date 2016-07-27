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

        protected void btnSendReport_Click(object sender, EventArgs e)
        {
            ReportService _ReportService = new ReportService();
            
            ReportAddDTO _ReportAddDTO = new ReportAddDTO();

            _ReportAddDTO.FullName = txtFullName.Text;
            _ReportAddDTO.Company = txtCompany.Text;
            _ReportAddDTO.EmailAddress = txtEmail.Text;
            _ReportAddDTO.Description = txtProblem.Text;
            _ReportAddDTO.ContactNumber = txtContactNumber.Text;
            _ReportAddDTO.Subject = txtSubject.Text;
            _ReportAddDTO.CreatedDate = DateTime.Now;
            int x = Convert.ToInt32(ddlProjects.SelectedValue);


            _ReportService.AddFunctionReportService(_ReportAddDTO);
            //seçilen selectedvalue'yi nasıl göndericem 
        }
    }
}