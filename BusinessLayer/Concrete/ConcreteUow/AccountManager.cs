using BusinessLayer.Abstract.AbtractUow;
using DataAccessLayer.Abstract;
using DataAccessLayer.UnitOfWork;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete.ConcreteUow
{
    public class AccountManager : IAccountService
    {
        private readonly IAccountDal _accountDal;
        private readonly IUowDal _uowDal;

        public AccountManager(IAccountDal accountDal, IUowDal uowDal)
        {
            _accountDal = accountDal;
            _uowDal = uowDal;
        }

        public Account TGetByID(int id)
        {
            return _accountDal.GetByID(id);
        }

        public void TInsert(Account entity)
        {
            _accountDal.Insert(entity);
            _uowDal.Save();

        }

        public void TMultiUpdate(List<Account> entites)
        {
            _accountDal.MultiUpdate(entites);
            _uowDal.Save();
        }

        public void TUpdate(Account entity)
        {
           _accountDal.Update(entity);
            _uowDal.Save();
        }
    }
}
