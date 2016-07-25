using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FeedBackRepositoryPattern.ORM;

namespace FeedBackRepositoryPattern.Repository
{
    public class AdminRepository : RepositoryBase<Admin>
    {
        public Admin GetAdminFunction(int userID)
        {
            return DataContex.Set<Admin>().Where(x => x.UserID == userID).SingleOrDefault();
        }
    }
}
