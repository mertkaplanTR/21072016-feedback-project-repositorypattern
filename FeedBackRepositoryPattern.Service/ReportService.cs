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
        public IList<ReportListDTO> GetReportList()
        {
            return _ReportRepository.GetList().Select(
                x => new ReportListDTO
                {
                    ReportID=x.ReportID,
                    FullName=x.FullName,
                    Company=x.Company,
                    EmailAddress=x.EmailAddress,
                    ContactNumber=x.ContactNumber,
                    CreatedDate=Convert.ToDateTime(x.CreatedDate),
                    Subject=x.Subject,
                    Description=x.Description
                }).ToList();
        }

        public void AddFunctionReportService(ReportAddDTO entity)
        {
            Reporter _reporter = new Reporter
            {
                FullName = entity.FullName,
                Company = entity.Company,
                EmailAddress = entity.EmailAddress,
                ContactNumber = entity.ContactNumber,
                CreatedDate = Convert.ToDateTime(entity.CreatedDate),
                Subject = entity.Subject,
                Description = entity.Description
            };
            _ReportRepository.AddSomething(_reporter);
        }

        public dynamic ProjectsToProgrammerListFunction()
        {
            return _ReportRepository.ProjectsToProgrammerListFunction();
        }

        public void EnterProgrammerIDtoProjectID(int ProgrammerID, int ProjectID)
        {
            _ReportRepository.SendProgrammerIDtoProjectID(ProgrammerID, ProjectID);

        }

        public dynamic SendSelectedProjectID(int ProjectID)
        {
            return _ReportRepository.GetAndSend(ProjectID);

        }

    }

}
