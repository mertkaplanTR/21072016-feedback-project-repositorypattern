using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FeedBackRepositoryPattern.ORM;
using FeedBackRepositoryPattern.DTO;
using FeedBackRepositoryPattern.Repository;

namespace FeedBackRepositoryPattern.Service
{
    public class ProjectService
    {
        ProjectsRepository _ProjectsRepository = new ProjectsRepository();

        public IList<ProjectListDTO> GetProjectList()
        {
            return _ProjectsRepository.GetList().Select(
               x => new ProjectListDTO
               {
                   ProjectID = x.ProjectID,
                   ProjectTitle = x.ProjectTitle,
                   ProjectExplanation = x.ProjectExplanation,
                   CreatedDate = Convert.ToDateTime(x.CreatedDate),
                   ModifiedDate= Convert.ToDateTime(x.ModifiedDate)
               }).ToList();
        }
    }
}
 