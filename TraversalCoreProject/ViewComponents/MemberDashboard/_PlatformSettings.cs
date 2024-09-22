using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.MemberDashboard
{
    public class _PlatformSettings :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
