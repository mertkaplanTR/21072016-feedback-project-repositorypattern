using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FeedBackRepositoryPattern.ORM;

namespace FeedBackRepositoryPattern.Repository
{
    public class ProgrammerRepository : RepositoryBase<Programmers>
    {
        public Programmers GetProgrammersFunction(int ProgrammerID)
        {
            return DataContex.Set<Programmers>().Where(x => x.ProgrammerID == ProgrammerID).SingleOrDefault();
        }



    }
}