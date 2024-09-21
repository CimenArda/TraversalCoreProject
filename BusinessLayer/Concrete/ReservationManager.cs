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
    public class ReservationManager : IReservationService
    {
        private readonly IReservationDal _reservationDal;

        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }

        public List<Reservation> GetListApprovalReservation(int id)
        {
           return _reservationDal.GetListByFilter(x=>x.AppUserId == id && x.Status=="Onay Bekliyor");

        }

        public List<Reservation> GetReservationWithReservationByAccepted(int id)
        {
            return _reservationDal.GetReservationWithReservationByAccepted(id);

        }

        public List<Reservation> GetReservationWithReservationByWaitPrevious(int id)
        {
            return _reservationDal.GetReservationWithReservationByWaitPrevious(id);

        }

        public List<Reservation> TGetAllList()
        {
            return _reservationDal.GetAllList();
        }

        public Reservation TGetById(int id)
        {
            return _reservationDal.GetById(id);
        }

        public List<Reservation> TGetReservationWithReservationByWaitApproval(int id)
        {
            return _reservationDal.GetReservationWithReservationByWaitApproval(id);
        }

        public void TInsert(Reservation entity)
        {
            _reservationDal.Insert(entity);
        }

        public void TRemove(Reservation entity)
        {
            _reservationDal.Remove(entity);
        }

        public void TUpdate(Reservation entity)
        {
            _reservationDal.Update(entity);
        }
    }
}
