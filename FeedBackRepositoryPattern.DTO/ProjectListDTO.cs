using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace FeedBackRepositoryPattern.DTO
{
    public class ProjectListDTO
    {
        public int ProjectID { get; set; }
        public string ProjectTitle { get; set; }
        public string ProjectExplanation { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        //image için bul... system.drawing?
    }
}
