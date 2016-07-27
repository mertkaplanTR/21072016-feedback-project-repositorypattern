using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FeedBackRepositoryPattern.ORM;

namespace FeedBackRepositoryPattern.Repository
{
    public class ProjectsRepository : RepositoryBase<Projects>
    {
        public Projects GetProjectsFunction(int ProjectID)
        {
            return DataContex.Set<Projects>().Where(x => x.ProjectID == ProjectID).SingleOrDefault();
        }
    }
}
