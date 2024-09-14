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
    public class About2Manager : IAbout2Service
    {
        private readonly IAbout2Dal _About2Dal;

        public About2Manager(IAbout2Dal About2Dal)
        {
            _About2Dal = About2Dal;
        }

        public List<About2> TGetAllList()
        {
            return _About2Dal.GetAllList();
        }

        public About2 TGetById(int id)
        {
            return _About2Dal.GetById(id);
        }

        public void TInsert(About2 entity)
        {
            _About2Dal.Insert(entity);
        }

        public void TRemove(About2 entity)
        {
            _About2Dal.Remove(entity);
        }

        public void TUpdate(About2 entity)
        {
            _About2Dal.Update(entity);
        }
    }
}
