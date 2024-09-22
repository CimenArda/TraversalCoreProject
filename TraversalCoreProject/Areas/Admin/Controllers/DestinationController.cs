using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class DestinationController : Controller
    {
        private readonly IDestinationService _destinationService;

        public DestinationController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            var values = _destinationService.TGetAllList();
            return View(values);
        }


        public IActionResult AddDestination()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddDestination(Destination destination)
        {
            _destinationService.TInsert(destination);
            return RedirectToAction("Index", "Destination", new { area = "Admin" });
        }



        public IActionResult DeleteDestination(int id)
        {
            var destinationBul = _destinationService.TGetById(id);
            _destinationService.TRemove(destinationBul);
            return RedirectToAction("Index", "Destination", new { area = "Admin" });

        }



        public IActionResult UpdateDestination(int id)
        {
            var destinationBul = _destinationService.TGetById(id);

            return View(destinationBul);
        }

        [HttpPost]
        public IActionResult UpdateDestination(Destination destination)
        {
            _destinationService.TUpdate(destination);
            return RedirectToAction("Index", "Destination", new { area = "Admin" });
        }
















    }
}
