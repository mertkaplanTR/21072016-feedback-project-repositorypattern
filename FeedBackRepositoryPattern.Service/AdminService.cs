using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FeedBackRepositoryPattern.ORM;
using FeedBackRepositoryPattern.DTO;
using FeedBackRepositoryPattern.Repository;

namespace FeedBackRepositoryPattern.Service
{
    public class AdminService
    {
        AdminRepository datacontex = new AdminRepository();

        public IList<AdminListDTO> GetAdminList()
        {
            return datacontex.GetList().Select(
                x => new AdminListDTO
                {
                    UserID = x.UserID,
                    Username = x.Username,
                    Password = x.Password,
                    EmailAddress = x.EmailAddress,
                    AdminRole = Convert.ToInt32(x.AdminRole), //converted because of in db isActive can be null.
                    isActive = Convert.ToBoolean(x.isActive), // <-- that should be true or false
                    CreatedDate = Convert.ToDateTime(x.CreatedDate), 
                    ModifiedDate = Convert.ToDateTime(x.ModifiedDate),
                }).ToList();
        }
        
        public void AddAdminServiceFunction(AdminAddDTO entity)
        {
            Admin admin = new Admin
            {
                Username = entity.Username,
                Password=entity.Password,
                EmailAddress=entity.EmailAddress,
                isActive=entity.isActive,
                AdminRole = entity.AdminRole,
                CreatedDate=entity.CreatedDate,
                ModifiedDate=entity.ModifiedDate
            };
            datacontex.AddSomething(admin);
        }

        public void DeleteAdminServiceFunction(AdminDeleteDTO entity)
        {
            //repository'e gönderilecek olan parametre
            Admin admin = new Admin 
            {
                UserID=entity.UserID,
                Username=entity.Username,
                Password=entity.Password,
                EmailAddress=entity.EmailAddress,
                isActive=entity.isActive,
                AdminRole=entity.AdminRole,
                CreatedDate=entity.CreatedDate,
                ModifiedDate=entity.ModifiedDate
         
            };
            datacontex.DeleteSomething(admin);
        }

        public void UpdateAdminServiceFunction(AdminUpdateDTO entity)
        {
            Admin admin = new Admin
            {
                Username = entity.Username,
                Password = entity.Password,
                EmailAddress = entity.EmailAddress,
                isActive = entity.isActive,
                AdminRole = entity.AdminRole,
                ModifiedDate = entity.ModifiedDate
            };
            datacontex.UpdateSomething(admin);
        }
    }
}
