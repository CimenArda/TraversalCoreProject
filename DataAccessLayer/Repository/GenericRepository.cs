using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        
        public List<T> GetAllList()
        {
            using var c = new Context();
           return c.Set<T>().ToList();
        }

        public T GetById(T entity)
        {
            using var c = new Context();

            return c.Set<T>().Find(entity);
        }

        public void Insert(T entity)
        {
            using var c = new Context();

            c.Add(entity);
            c.SaveChanges();
        }

        public void Remove(T entity)
        {
            using var c = new Context();

            c.Remove(entity);
            c.SaveChanges();
        }

        public void Update(T entity)
        {
            using var c = new Context();

          c.Update(entity);
            c.SaveChanges();
        }
    }
}
