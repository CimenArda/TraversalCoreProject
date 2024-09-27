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
    public class AnnouncementManager : IAnnouncementService
    {
        private readonly IAnnouncementDal _AnnouncementDal;

        public AnnouncementManager(IAnnouncementDal AnnouncementDal)
        {
            _AnnouncementDal = AnnouncementDal;
        }

        public List<Announcement> TGetAllList()
        {
            return _AnnouncementDal.GetAllList();
        }

        public Announcement TGetById(int id)
        {
            return _AnnouncementDal.GetById(id);
        }

        public void TInsert(Announcement entity)
        {
            _AnnouncementDal.Insert(entity);
        }

        public void TRemove(Announcement entity)
        {
            _AnnouncementDal.Remove(entity);
        }

        public void TUpdate(Announcement entity)
        {
            _AnnouncementDal.Update(entity);
        }
    }
}
