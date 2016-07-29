using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FeedBackRepositoryPattern.ORM;
using FeedBackRepositoryPattern.DTO;
using FeedBackRepositoryPattern.Repository;

namespace FeedBackRepositoryPattern.Service
{
    public class ReportService
    {
        ReportRepository _ReportRepository = new ReportRepository();
         //ILISTI YAZILMADI DTIOYA GIT DTO YARATIP YAZ.


        public void AddFunctionReportService(ReportAddDTO entity)
        {
            Reporter _reporter = new Reporter
            {
                FullName = entity.FullName,
                Company=entity.Company,
                EmailAddress=entity.EmailAddress,
                ContactNumber=entity.ContactNumber,
                CreatedDate=Convert.ToDateTime(entity.CreatedDate),
                Subject=entity.Subject,
                Description=entity.Description
            };
            _ReportRepository.AddSomething(_reporter);
        }

        public void SendProjectID(int entity)
        {
            _ReportRepository.dondur(entity);   
        }

    }

}
