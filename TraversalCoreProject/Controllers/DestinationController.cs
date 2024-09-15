using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Controllers
{
    public class DestinationController : Controller
    {
        private readonly IDestinationService _destinationService;

        public DestinationController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            var values =_destinationService.TGetAllList();
            return View(values);
        }

        [HttpGet]
        public IActionResult DestinationDetails(int id)
        {

            return View();
        }
        [HttpPost]
        public IActionResult DestinationDetails(Destination p)
        {

            return View();
        }
    }
}
