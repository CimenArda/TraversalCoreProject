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
    public class GuideManager : IGuideService
    {
        private readonly IGuideDal _GuidDal;

        public GuideManager(IGuideDal GuidDal)
        {
            _GuidDal = GuidDal;
        }

        public List<EntityLayer.Concrete.Guid> TGetAllList()
        {
            return _GuidDal.GetAllList();
        }

        public EntityLayer.Concrete.Guid TGetById(int id)
        {
            return _GuidDal.GetById(id);
        }

        public void TInsert(EntityLayer.Concrete.Guid entity)
        {
            _GuidDal.Insert(entity);
        }

        public void TRemove(EntityLayer.Concrete.Guid entity)
        {
            _GuidDal.Remove(entity);
        }

        public void TUpdate(EntityLayer.Concrete.Guid entity)
        {
            _GuidDal.Update(entity);
        }
    }
}
