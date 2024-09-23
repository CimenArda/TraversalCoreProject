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
    public class AppUserManager : IAppUserService
    {
        private readonly IAppUserDal _AppUserDal;

        public AppUserManager(IAppUserDal AppUserDal)
        {
            _AppUserDal = AppUserDal;
        }

        public List<AppUser> TGetAllList()
        {
            return _AppUserDal.GetAllList();
        }

        public AppUser TGetById(int id)
        {
            return _AppUserDal.GetById(id);
        }

        public void TInsert(AppUser entity)
        {
            _AppUserDal.Insert(entity);
        }

        public void TRemove(AppUser entity)
        {
            _AppUserDal.Remove(entity);
        }

        public void TUpdate(AppUser entity)
        {
            _AppUserDal.Update(entity);
        }
    }
}