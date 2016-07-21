using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FeedBackRepositoryPattern.ORM;

namespace FeedBackRepositoryPattern.Repository
{
    public class RepositoryBase <T> where T:class
    {
        private static feedbackdatabaseEntities datacontex;

        public feedbackdatabaseEntities DataContex
        {
            get
            {
                if (DataContex==null)
                {
                    datacontex = new feedbackdatabaseEntities();
                }
                return datacontex;
            }
            set
            {
                datacontex = value;
            }
        }

        public IList<T> GetList()
        {
            return DataContex.Set<T>().ToList();
        }

        public void AddSomething(T entity)
        {
            DataContex.Set<T>().Add(entity);
            DataContex.SaveChanges();
            DataContex = new feedbackdatabaseEntities(); //refresh
        }

        public void DeleteSomething(T entity)
        {
            DataContex.Set<T>().Remove(entity);
            DataContex.SaveChanges();
            DataContex = new feedbackdatabaseEntities(); //refresh
        }

        public void Refresh()
        {
            DataContex.SaveChanges();
            DataContex = new feedbackdatabaseEntities();
        }
    }
}
