using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guid = EntityLayer.Concrete.Guid;

namespace DataAccessLayer.Abstract
{
    public interface IGuideDal:IGenericDal<Guid>
    {
    }
}
