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
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDal _TestimonialDal;

        public TestimonialManager(ITestimonialDal TestimonialDal)
        {
            _TestimonialDal = TestimonialDal;
        }

        public List<Testimonial> TGetAllList()
        {
            return _TestimonialDal.GetAllList();
        }

        public Testimonial TGetById(int id)
        {
            return _TestimonialDal.GetById(id);
        }

        public void TInsert(Testimonial entity)
        {
            _TestimonialDal.Insert(entity);
        }

        public void TRemove(Testimonial entity)
        {
            _TestimonialDal.Remove(entity);
        }

        public void TUpdate(Testimonial entity)
        {
            _TestimonialDal.Update(entity);
        }
    }
}
