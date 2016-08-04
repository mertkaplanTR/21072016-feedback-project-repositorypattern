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

            GetDropdown();
        }

        protected void GetDropdown()
        {
            ProjectService _ProjectService = new ProjectService();

            ddlProjects.DataSource = _ProjectService.GetProjectList();
            ddlProjects.DataValueField = "ProjectID";  // hafızadan tutalacak şey
            ddlProjects.DataTextField = "ProjectTitle";   //gösterilecek şey
            ddlProjects.DataBind();
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
            _ReportService.AddFunctionReportService(_ReportAddDTO);

            ProgrammerService _ProgrammerService = new ProgrammerService();
            List<ProgrammerSendMailDTO> _ProgrammerSendMailDTO = new List<ProgrammerSendMailDTO>();
            _ReportService.SendSelectedProjectID(int.Parse(ddlProjects.SelectedValue));
            //_ReportService.SendSelectedProjectID(int.Parse(ddlProjects.SelectedValue));
            //yukarıdaki kod ddlproject isimli dropdowndan alınan ID'nin int'e çevirilip reportservice 
            //içindeki sendselectedpoint isimli fonksiyonuna gönderilmesini sağlar.
            //bu fonksiyon sonucunda null dönse dahi reportrepository incelenirse eğer 
            //foreach yapısı ile tum seçilen projedeki kişilere mail gönderildiği gözlemlenebilir.
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            AdminService _AdminService = new AdminService();
            AdminCheckDTO _AdminCheckDTO = new AdminCheckDTO();
            _AdminCheckDTO.Username = txtUsername.Text;
            _AdminCheckDTO.Password = txtPassword.Text;
            bool x=_AdminService.AdminCheckFunction(_AdminCheckDTO);

        }
    }
}