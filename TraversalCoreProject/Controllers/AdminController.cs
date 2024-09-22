using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Controllers
{
    public class AdminController : Controller
    {
        public PartialViewResult _PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult _PartialAppBrandDemo()
        {
            return PartialView();
        }

        public PartialViewResult _PartialSidebar()
        {
            return PartialView();
        }


        public PartialViewResult _PartialNavbar()
        {
            return PartialView();
        }

        public PartialViewResult _PartialFooter()
        {
            return PartialView();
        }

        public PartialViewResult _PartialScript()
        {
            return PartialView();
        }
    }
}
