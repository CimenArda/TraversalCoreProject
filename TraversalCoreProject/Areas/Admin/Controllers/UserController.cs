using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class UserController : Controller
    {
    
        private readonly IAppUserService _userService;
        private readonly IReservationService _reservationService;

        public UserController(IAppUserService userService, IReservationService reservationService)
        {
            _userService = userService;
            _reservationService = reservationService;
        }

        public IActionResult Index()
        {
            var values = _userService.TGetAllList();
            
            return View(values);
        }

        public IActionResult DeleteUser(int id)
        {
            var values = _userService.TGetById(id);
            _userService.TRemove(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditUser(int id)
        {
            var values = _userService.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult EditUser(AppUser appUser)
        {
            _userService.TUpdate(appUser);
            return RedirectToAction("Index");
        }

        public IActionResult CommentUser(int id)
        {
            _userService.TGetAllList();
            return View();
        }

        public IActionResult ReservationUser(int id)
        {
        var value =_userService.TGetById(id);
          ViewBag.NameSurname = value.Name + " " + value.Surname;
         var values =_reservationService.GetReservationWithReservationByAccepted(id);
            return View(values);

        }
    }
}
