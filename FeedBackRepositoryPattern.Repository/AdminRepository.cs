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

        public Admin CheckAdminFunction(Admin admin)
        {
            return DataContex.Set<Admin>().Where(x => x.Username == admin.Username && x.Password == admin.Password).SingleOrDefault();
        }

        public Admin ReturnTypeFunction(Admin admin)
        {
            //var a= DataContex.Set<Admin>().Where(x => x.Username == admin.Username && x.Password == admin.Password).Select(x => new { x.AdminRole }).SingleOrDefault();
            return  DataContex.Set<Admin>().Where(x => x.Username == admin.Username && x.Password == admin.Password).SingleOrDefault();
        }
    }
}
