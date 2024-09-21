using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IReservationDal : IGenericDal<Reservation>
    {

        List<Reservation> GetReservationWithReservationByWaitApproval(int id);
        List<Reservation> GetReservationWithReservationByAccepted(int id);
        List<Reservation> GetReservationWithReservationByWaitPrevious(int id);
    }
}
