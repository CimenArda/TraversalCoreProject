using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Guide")]
    public class GuideController : Controller
    {
        private readonly IGuideService _guideService;

        public GuideController(IGuideService guideService)
        {
            _guideService = guideService;
        }

        [Route("Index")]
        public IActionResult Index()
        {
            var values =  _guideService.TGetAllList();
            return View(values);

            
        }

        [HttpGet]
        [Route("AddGuide")]

        public IActionResult AddGuide()
        {
            return View();
        }
        [HttpPost]
        [Route("AddGuide")]
        public IActionResult AddGuide(Guid g)
        {
            _guideService.TInsert(g);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditGuide(int id)
        {
          var values =  _guideService.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditGuide(Guid g)
        {
            _guideService.TUpdate(g);

            return RedirectToAction("Index");
        }

        public IActionResult ChangeToTrue(int id)
        {
            return RedirectToAction("Index");

        }
        public IActionResult ChangeToFalse(int id)
        {
            return RedirectToAction("Index");

        }
    }
}
