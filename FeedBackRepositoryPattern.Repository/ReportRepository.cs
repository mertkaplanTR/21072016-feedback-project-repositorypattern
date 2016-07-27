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
    }
}
