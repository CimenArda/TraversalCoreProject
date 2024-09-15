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
    public class SubAboutManager : ISubAboutService
    {
        private readonly ISubAboutDal _SubAboutDal;

        public SubAboutManager(ISubAboutDal SubAboutDal)
        {
            _SubAboutDal = SubAboutDal;
        }

        public List<SubAbout> TGetAllList()
        {
            return _SubAboutDal.GetAllList();
        }

        public SubAbout TGetById(int id)
        {
            return _SubAboutDal.GetById(id);
        }

        public void TInsert(SubAbout entity)
        {
            _SubAboutDal.Insert(entity);
        }

        public void TRemove(SubAbout entity)
        {
            _SubAboutDal.Remove(entity);
        }

        public void TUpdate(SubAbout entity)
        {
            _SubAboutDal.Update(entity);
        }
    }
}
