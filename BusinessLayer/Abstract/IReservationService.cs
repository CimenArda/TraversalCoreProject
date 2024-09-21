using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IReservationService :IGenericService<Reservation>
    {

        List<Reservation> GetListApprovalReservation(int id);


        List<Reservation> TGetReservationWithReservationByWaitApproval(int id);
        List<Reservation> GetReservationWithReservationByAccepted(int id);
        List<Reservation> GetReservationWithReservationByWaitPrevious(int id);
    }
}
