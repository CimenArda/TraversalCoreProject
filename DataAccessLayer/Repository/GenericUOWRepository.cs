using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericUOWRepository<T> : IGenericUOWDal<T> where T : class
    {
        private readonly Context _context;

        public GenericUOWRepository(Context context)
        {
            _context = context;
        }

        public T GetByID(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Insert(T entity)
        {
            _context.Add(entity);

        }

        public void MultiUpdate(List<T> entites)
        {
            _context.UpdateRange(entites);
        }

        public void Update(T entity)
        {
            _context.Update(entity);
        }
    }
}
