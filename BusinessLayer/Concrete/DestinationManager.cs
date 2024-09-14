using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class DestinationManager : IDestinationService
    {
        private readonly IDestinationDal _DestinationDal;

        public DestinationManager(IDestinationDal DestinationDal)
        {
            _DestinationDal = DestinationDal;
        }

        public List<Destination> TGetAllList()
        {
            return _DestinationDal.GetAllList();
        }

        public Destination TGetById(int id)
        {
            return _DestinationDal.GetById(id);
        }

        public void TInsert(Destination entity)
        {
            _DestinationDal.Insert(entity);
        }

        public void TRemove(Destination entity)
        {
            _DestinationDal.Remove(entity);
        }

        public void TUpdate(Destination entity)
        {
            _DestinationDal.Update(entity);
        }
    }
}
