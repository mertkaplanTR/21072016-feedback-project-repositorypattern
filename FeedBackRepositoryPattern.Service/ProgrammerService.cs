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
    /// <summary>
    /// //////////////////////////////////////////////////////where conditionunu yaz
    /// </summary>
    public class ProgrammerService
    {
        ProgrammerRepository _ProgrammerRepository = new ProgrammerRepository();

        public IList<ProgrammerSendMailDTO> GetProgrammerMails(ProgrammerSendMailDTO entity)
        {
            return _ProgrammerRepository.GetList().Select(   // sorguyu düzelt.
                x => new ProgrammerSendMailDTO
                {
                    ProgrammerEmail = x.ProgrammerEmail
                }).ToList();
        }


        //public void sendMail(ProgrammerSendMailDTO entity)
        //{
        //    SmtpClient client = new SmtpClient();
        //    client.Port = 587;
        //    client.Host = "smtp.live.com";
        //    client.EnableSsl = true;
        //    client.Timeout = 50000;
        //    client.Credentials = new NetworkCredential("rdcpartner@outlook.com", "passwordugirsilindi");
        //    MailMessage mail = new MailMessage();
        //    mail.From = new MailAddress("rdcpartner@outlook.com", "rdcpartner@outlook.com");
        //    mail.To.Add(entity.ProgrammerEmail);
        //    mail.Subject = "demo";
        //    client.Send(mail);

        //}

    }
}
        
    

