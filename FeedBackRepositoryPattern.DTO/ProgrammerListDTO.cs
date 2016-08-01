using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace FeedBackRepositoryPattern.DTO
{
    public class ProgrammerListDTO
    {
        public int ProgrammerID { get; set; }
        public string ProgrammerName { get; set; }
        public  string ProgrammerEmail { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
