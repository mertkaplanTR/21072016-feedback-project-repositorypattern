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
            //yukarıdaki verileri database'e ekle.DONE.



            int SelectedProjectID = int.Parse(ddlProjects.SelectedValue);
            _ReportService.SendProjectID(SelectedProjectID);
            //test string is ok, duzeltdi

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Seçilen projeyi fonksiyona gönderme kodu.
            ProgrammerService _ProgrammerService = new ProgrammerService();
            ProgrammerSendMailDTO _ProgrammerSendMailDTO = new ProgrammerSendMailDTO();
            _ProgrammerSendMailDTO.ProgrammerEmail = ddlProjects.SelectedValue;

            //linke tıklayınca mail gönderme fonksiyonu
            foreach (var programmerEmailAdresses in _ProgrammerService.GetProgrammerMails(_ProgrammerSendMailDTO))
            {
                ///DO IT HERE
            }



            /*
        //     * Maile gönderme fonksiyonu seçilen id'ye göre. 
        //    ProgrammerService _ProgrammerService = new ProgrammerService();
        //    foreach (var emailAdresses in _ProgrammerService.GetProgrammerMails())
        //    {
        //        _ProgrammerService.sendMail(emailAdresses);
        //    }
        //    */



            //}

        }

        
    }
}