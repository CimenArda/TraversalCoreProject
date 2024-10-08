using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TraversalCoreProject.Controllers
{
    [AllowAnonymous]
    public class DestinationController : Controller
    {
        private readonly IDestinationService _destinationService;
        private readonly UserManager<AppUser> _userManager;

        public DestinationController(IDestinationService destinationService, UserManager<AppUser> userManager)
        {
            _destinationService = destinationService;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var values =_destinationService.TGetAllList();
            return View(values);
        }

        [HttpGet]
        public async Task<IActionResult> DestinationDetails(int id)
        {
            var appuserValues = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.userId = appuserValues.Id;

            var values = _destinationService.TGetById(id);

            ViewBag.DestId = values.DestinationID;

            var values2 = _destinationService.TGetDestinationWithGuide(id);
            return View(values2);
            
        }
        [HttpPost]
        public IActionResult DestinationDetails(Destination p)
        {

            return View();
        }
    }
}
