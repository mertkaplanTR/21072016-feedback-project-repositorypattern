using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using FeedBackRepositoryPattern.ORM;

namespace FeedBackRepositoryPattern.Repository
{
    public class RepositoryBase <T> where T:class
    {
        private static feedbackdatabaseEntities datacontex;

        protected virtual feedbackdatabaseEntities DataContex
        {
            get
            {
                if (datacontex==null)
                {
                    datacontex = new feedbackdatabaseEntities();
                }
                return datacontex;
            }
            set
            { datacontex = value; }
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

        public void UpdateSomething(T entity)
        {
            DataContex.Set<T>().Attach(entity);
            DataContex.Entry(entity).State = System.Data.EntityState.Modified;
            DataContex.SaveChanges();
            DataContex = new feedbackdatabaseEntities();
        }

    }
}
