using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using EntityLayer.Concrete;
using FluentValidation.Results;
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
            GuideValidator validationRules = new GuideValidator();

            ValidationResult result = validationRules.Validate(g);
            if (result.IsValid)
            {
                _guideService.TInsert(g);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);

                }
            }
            return View();
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

        [Route("ChangeToTrue/{id}")]
        public IActionResult ChangeToTrue(int id)
        {
            _guideService.TChangeToTrueByGuide(id);
            return RedirectToAction("Index");

        }

        [Route("ChangeToFalse/{id}")]
        public IActionResult ChangeToFalse(int id)
        {
            _guideService.TChangeToFalseByGuide(id);
            return RedirectToAction("Index");

        }
    }
}
