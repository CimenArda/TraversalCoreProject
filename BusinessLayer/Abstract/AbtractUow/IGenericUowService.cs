using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract.AbtractUow
{
    public interface IGenericUowService<T> 
    {
        void TInsert(T entity);
        void TUpdate(T entity);
        T TGetByID(int id);

        void TMultiUpdate(List<T> entites);
    }
}
