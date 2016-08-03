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
    public partial class listreports : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadReportList();
        }

        void LoadReportList()
        {
            ReportService _ReportService = new ReportService();
            grdListReport.DataSource = _ReportService.GetReportList();
            grdListReport.DataBind();
        }

        protected void grdListReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}