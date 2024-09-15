using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _PopularDestinations :ViewComponent
    {
        private readonly IDestinationService _destinationService;

        Context context =new Context();
        public _PopularDestinations(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IViewComponentResult Invoke()
        {
         var values = context.Destinations.Where(x=>x.Status==true).ToList();
            return View(values);
        }
    }
}
