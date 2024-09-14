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
    public class NewsLetterManager : INewsLetterService
    {
        private readonly INewsLetterDal _NewsLetterDal;

        public NewsLetterManager(INewsLetterDal NewsLetterDal)
        {
            _NewsLetterDal = NewsLetterDal;
        }

        public List<NewsLetter> TGetAllList()
        {
            return _NewsLetterDal.GetAllList();
        }

        public NewsLetter TGetById(int id)
        {
            return _NewsLetterDal.GetById(id);
        }

        public void TInsert(NewsLetter entity)
        {
            _NewsLetterDal.Insert(entity);
        }

        public void TRemove(NewsLetter entity)
        {
            _NewsLetterDal.Remove(entity);
        }

        public void TUpdate(NewsLetter entity)
        {
            _NewsLetterDal.Update(entity);
        }
    }
}
