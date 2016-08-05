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
        AdminRepository _AdminRepository = new AdminRepository();

        public IList<AdminListDTO> GetAdminList()
        {
            return _AdminRepository.GetList().Select(
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

        public bool AdminCheckFunction(AdminCheckDTO entity)
        {
            Admin admin = new Admin
            {
                
                Username = entity.Username,
                Password = entity.Password,
            };

            _AdminRepository.CheckAdminFunction(admin);
            if (_AdminRepository.CheckAdminFunction(admin) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void AddAdminServiceFunction(AdminAddDTO entity)
        {
            Admin admin = new Admin
            {
                Username = entity.Username,
                Password = entity.Password,
                EmailAddress = entity.EmailAddress,
                isActive = entity.isActive,
                AdminRole = entity.AdminRole,
                CreatedDate = entity.CreatedDate,
                ModifiedDate = entity.ModifiedDate
            };
            _AdminRepository.AddSomething(admin);
        }

        public void DeleteAdminServiceFunction(AdminDeleteDTO entity)
        {
            //repository'e gönderilecek olan parametre
            var admin = _AdminRepository.GetAdminFunction(entity.UserID);
            _AdminRepository.DeleteSomething(admin);
        }

        public void UpdateAdminServiceFunction(AdminUpdateDTO entity)
        {
            var request = _AdminRepository.GetAdminFunction(entity.UserID);
            request.Username = entity.Username;
            request.Password = entity.Password;
            request.EmailAddress = entity.EmailAddress;
            _AdminRepository.UpdateSomething(request);
        }

        public int SendUserDetailsandGetUserID(AdminCheckDTO entity)
        {
            Admin admin = new Admin
            {
                Username = entity.Username,
                Password = entity.Password
            };
            var x= _AdminRepository.ReturnTypeFunction(admin);
            if (x.AdminRole == 1)
            {
                return 1;
            }
            else
                return 0;
           ////////////// 
        }
    }
}