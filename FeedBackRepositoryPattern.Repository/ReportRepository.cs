using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FeedBackRepositoryPattern.ORM;

namespace FeedBackRepositoryPattern.Repository
{
    public class ReportRepository : RepositoryBase<Reporter>
    {
        public Reporter GetProjectFunction(int ReportID)
        {
            return DataContex.Set<Reporter>().Where(x => x.ReportID == ReportID).SingleOrDefault();
        }

        public void SendProgrammerIDtoProjectID(int ProgrammerID,int ProjectID)
        {
            //PROJE 1'E Adam ekleme
            Programmers _Programmer= DataContex.Set<Programmers>().FirstOrDefault(x => x.ProgrammerID == ProgrammerID);
            DataContex.Projects.FirstOrDefault(a => a.ProjectID == ProjectID).Programmers.Add(_Programmer);
            DataContex.SaveChanges();
        }


        public void SendReportIDtoProjectID(int ReportID,int ProjectID)
        {
            //ProjeID'si 1 olana ProgrammerID'si 2 olanı atama
            //ilk önce projeyi çek
            //sonra programmer'i ata
            //aşağıdaki kod ise ilk önce kursu çek sonra programmer'i ata  
            Reporter _Reporter = DataContex.Reporter.Single(a => a.ReportID == ReportID);
            DataContex.Projects.FirstOrDefault(a => a.ProjectID == ProjectID).Reporter.Add(_Reporter);
            DataContex.SaveChanges();
        }


        public void dondur(int ProjeID)
          
        {
            var query =
                from a in DataContex.Programmers
                 from b in a.Projects
                 where b.ProjectID == ProjeID
                 select new
                 {
                     a.ProgrammerEmail
                 };
        }

    }

}
