﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfContactUsDal : GenericRepository<ContactUs>, IContactUsDal
    {
        public void ContactUsStatusChangeToFalse(int id)
        {
           throw new NotImplementedException();
        }

        public List<ContactUs> GetListContactUsByFalse()
        {
            using (var c = new Context())
            {
                var values = c.ContactUss.Where(x => x.Status == false).ToList();
                return values;

            }
        }

        public List<ContactUs> GetListContactUsByTrue()
        {
            using (var c = new Context())
            {
                var values = c.ContactUss.Where(x => x.Status == true).ToList();
                return values;

            }
        }
    }
}
