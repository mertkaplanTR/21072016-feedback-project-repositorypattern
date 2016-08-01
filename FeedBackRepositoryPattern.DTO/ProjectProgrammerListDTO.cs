using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FeedBackRepositoryPattern.DTO
{
    public class ProjectProgrammerListDTO
    {
        public int ProgrammerID { get; set; }
        public string ProgrammerName { get; set; }
        public string ProgrammerEmail { get; set; }
        public int ProjectID { get; set; }
        public int ProjectTitle { get; set; }

    }
}
