using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FeedBackRepositoryPattern.DTO
{
    public class AdminCheckDTO
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string EmailAddress { get; set; }
        public bool isActive { get; set; }
        public int AdminRole { get; set; }
    }
}
