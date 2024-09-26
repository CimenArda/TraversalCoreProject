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
    public class ContactUsManager : IContactUsService
    {
        private readonly IContactUsDal _ContactUsDal;

        public ContactUsManager(IContactUsDal ContactUsDal)
        {
            _ContactUsDal = ContactUsDal;
        }

        public void TContactUsStatusChangeToFalse(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContactUs> TGetAllList()
        {
            return _ContactUsDal.GetAllList();
        }

        public ContactUs TGetById(int id)
        {
            return _ContactUsDal.GetById(id);
        }

        public List<ContactUs> TGetListContactUsByFalse()
        {
            return _ContactUsDal.GetListContactUsByFalse();
        }

        public List<ContactUs> TGetListContactUsByTrue()
        {
            return _ContactUsDal.GetListContactUsByTrue();
        }

        public void TInsert(ContactUs entity)
        {
            _ContactUsDal.Insert(entity);
        }

        public void TRemove(ContactUs entity)
        {
            _ContactUsDal.Remove(entity);
        }

        public void TUpdate(ContactUs entity)
        {
            _ContactUsDal.Update(entity);
        }
    }
}

