using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Net.Mail;
using System.Net;

using FeedBackRepositoryPattern.ORM;
using FeedBackRepositoryPattern.DTO;
using FeedBackRepositoryPattern.Repository;

namespace FeedBackRepositoryPattern.Repository
{
    public class ReportRepository : RepositoryBase<Reporter>
    {
        public Reporter GetProjectFunction(int ReportID)
        {
            return DataContex.Set<Reporter>().Where(x => x.ReportID == ReportID).SingleOrDefault();
        }

        public void SendProgrammerIDtoProjectID(int ProgrammerID, int ProjectID)
        {
            //Gelen Value'lara göre Projeye Programmer Atama Fonksiyonu
            Programmers _Programmer = DataContex.Set<Programmers>().FirstOrDefault(x => x.ProgrammerID == ProgrammerID);
            DataContex.Projects.FirstOrDefault(a => a.ProjectID == ProjectID).Programmers.Add(_Programmer);
            DataContex.SaveChanges();
        }


        public void SendReportIDtoProjectID(int ReportID, int ProjectID)
        {
            //Proje raporlarını Project ID ile eşleştirip mapping tablosuna atama fonksiyonu.
            Reporter _Reporter = DataContex.Reporter.Single(a => a.ReportID == ReportID);
            DataContex.Projects.FirstOrDefault(a => a.ProjectID == ProjectID).Reporter.Add(_Reporter);
            DataContex.SaveChanges();
        }

        public dynamic ProjectsToProgrammerListFunction()
        //programmers hangi projeleri yapmıs gosterme fonksiyonu
        {
            return (from a in DataContex.Programmers
                    from b in a.Projects
                    select new
                    {
                        ProgrammerID = a.ProgrammerID,
                        ProgrammerName = a.ProgrammerName,
                        ProgammerEmail = a.ProgrammerEmail,
                        ProjectID = b.ProjectID,
                        ProjectTitle = b.ProjectTitle
                    }).ToList();

        }

        public dynamic GetAndSend(int ProjeID){
            var x= (from a in DataContex.Programmers
                from b in a.Projects
                where b.ProjectID == ProjeID
                select new
                {
                    a.ProgrammerEmail
                }).ToList();
            foreach (var programmerEmailAdress in x)
            {
                SmtpClient client = new SmtpClient();
                client.Port = 587;
                client.Host = "smtp.live.com";
                client.EnableSsl = true;
                client.Timeout = 50000;
                client.Credentials = new NetworkCredential("rdcpartner@outlook.com", "FeedBackRepositoryPattern");
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("rdcpartner@outlook.com", "rdcpartner@outlook.com");
                //string result = programmerEmailAdress.ProgrammerEmail.ToString(); //a.programmerEmail <--
                //mail.To.Add(result);
                mail.To.Add(programmerEmailAdress.ProgrammerEmail);
                mail.Subject = "demo";
                //client.Send(mail);
            }
            return null;
        }
    }
}
