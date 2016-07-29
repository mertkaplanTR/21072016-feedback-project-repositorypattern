using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FeedBackRepositoryPattern.DTO
{
    public class ReportAddDTO
    {
        public string FullName { get; set; }
        public string Company { get; set; }
        public string EmailAddress { get; set; }
        public string ContactNumber { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
       
    }
}
