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

        public void UpdateAdminServiceFunction(UpdateAdminDTO entity)
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
