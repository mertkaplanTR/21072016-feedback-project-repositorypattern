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


namespace FeedBackRepositoryPattern.Service
{

    public class ProgrammerService
    {
        ProgrammerRepository _ProgrammerRepository = new ProgrammerRepository();

        public IList<ProgrammerListDTO> GetProgammerList()
        {
            return _ProgrammerRepository.GetList().Select(
                x => new ProgrammerListDTO
                {
                    ProgrammerID = x.ProgrammerID,
                    ProgrammerName = x.ProgrammerName,
                    ProgrammerEmail = x.ProgrammerEmail,
                    CreatedDate = Convert.ToDateTime(x.CreatedDate),
                    ModifiedDate = Convert.ToDateTime(x.ModifiedDate)
                }
                ).ToList();
        }

        //public IList<ProgrammerSendMailDTO> GetProgrammerMails(ProgrammerSendMailDTO entity)
        //{
        //    return _ProgrammerRepository.GetList().Select(   // TUM MAILLERI LISTELER ISTENILEN MAILLERI LISTEYENI REPORT SERVICEDE
        //        x => new ProgrammerSendMailDTO
        //        {
        //            ProgrammerEmail = x.ProgrammerEmail
        //        }).ToList();
        //}

        public void sendMail(ProgrammerSendMailDTO entity)
        {
            var x = entity.ProgrammerEmail;
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Host = "smtp.live.com";
            client.EnableSsl = true;
            client.Timeout = 50000;
            client.Credentials = new NetworkCredential("rdcpartner@outlook.com", "FeedBackRepositoryPattern");
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("rdcpartner@outlook.com", "rdcpartner@outlook.com");
            mail.To.Add("mertkaplan.tr@gmail.com");
            mail.Subject = "demo";
            client.Send(mail);
        }
    }
}



