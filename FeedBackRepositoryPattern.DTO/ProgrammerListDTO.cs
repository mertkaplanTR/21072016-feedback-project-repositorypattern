using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FeedBackRepositoryPattern.DTO
{
    public class ProgrammerListDTO
    {
        int ProgrammerID { get; set; }
        string ProgrammerName { get; set; }
        string ProgrammerEmail { get; set; }
        DateTime CreatedDate { get; set; }
        DateTime ModifiedDate { get; set; }
    }
}
