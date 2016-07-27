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

        public IList<ProgrammerSendMailDTO> SendEmailFunction()
        {
            return _ProgrammerRepository.GetList().Select(
                x => new ProgrammerSendMailDTO
                {
                    ProgrammerID = x.ProgrammerID,
                    ProgrammerName=x.ProgrammerName,
                    ProgrammerEmail = x.ProgrammerEmail 
                   
                }).ToList();
           ////////////buradan email gonder add functionuna gönderin oradan yapmak lazım
        }

    

        }

        
        
    }

