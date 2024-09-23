using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    public class ReservationController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        private readonly IReservationService _reservationService;
        private readonly IDestinationService _destinationService;

        public ReservationController(UserManager<AppUser> userManager, IReservationService reservationService, IDestinationService destinationService)
        {
            _userManager = userManager;
            _reservationService = reservationService;
            _destinationService = destinationService;
        }

        public async Task<IActionResult> MyCurrentReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = _reservationService.GetReservationWithReservationByAccepted(values.Id);
            return View(valuesList);

        }
        public async Task<IActionResult> MyOldReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = _reservationService.GetReservationWithReservationByWaitPrevious(values.Id);
            return View(valuesList);
        }

        public async Task<IActionResult> MyApprovalReservation()
        {

            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = _reservationService.TGetReservationWithReservationByWaitApproval(values.Id);

            return View(valuesList);
        }


        [HttpGet]
        public IActionResult NewReservation()
        {
            List<SelectListItem> values = (from x in _destinationService.TGetAllList()
                                           select new SelectListItem
                                           {
                                               Text = x.City,
                                               Value = x.DestinationID.ToString()
                                           }).ToList();

            ViewBag.values = values;
            return View();
        }

        [HttpPost]
        public IActionResult NewReservation(Reservation p)
        {
            p.AppUserId = 1;
            p.Status = "Onay Bekliyor";
            _reservationService.TInsert(p);

            return RedirectToAction("MyCurrentReservation");
        }





    }
}
