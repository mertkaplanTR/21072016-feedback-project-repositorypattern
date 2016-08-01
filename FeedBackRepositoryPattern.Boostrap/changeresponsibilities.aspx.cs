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
    public partial class changeresponsibilities : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadProgrammersFunction();
            LoadProjectFunction();
        }


        protected void LoadProgrammersFunction()
        {
            ProgrammerService _ProgrammerService = new ProgrammerService();
            ddlProgammers.DataSource = _ProgrammerService.GetProgammerList();
            ddlProgammers.DataValueField = "ProgrammerID"; // hafızadan tutalacak şey
            ddlProgammers.DataTextField = "ProgrammerName"; // WEB KISMINDA GOSTERILECEK KOLON
            ddlProgammers.DataBind();
        }

        protected void LoadProjectFunction()
        {
            ProjectService _ProjectService = new ProjectService();
            ddlProjects.DataSource = _ProjectService.GetProjectList();
            ddlProjects.DataValueField = "ProjectID";  // hafızadan tutalacak şey
            ddlProjects.DataTextField = "ProjectTitle";   //gösterilecek şey
            ddlProjects.DataBind();
        }


        protected void btnSaveProgrammerToProject_Click(object sender, EventArgs e)
        {
            ReportService _ReportService = new ReportService();
            ProgrammerProjectAddDTO _ProgrammerProjectAddDTO = new ProgrammerProjectAddDTO();
            _ReportService.EnterProgrammerIDtoProjectID(int.Parse(ddlProgammers.SelectedValue), int.Parse(ddlProjects.SelectedValue));
        }
    }
}