using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }
        //public IActionResult SignUp()
        //{
        //    return View();
        //}
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }
        //public IActionResult SignIn()
        //{
        //    return View();
        //}



    }
}
