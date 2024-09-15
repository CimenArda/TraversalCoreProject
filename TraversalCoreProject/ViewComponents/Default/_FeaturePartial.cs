using DataAccessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _FeaturePartial : ViewComponent
    {
        private readonly IFeatureDal _featureDal;

        public _FeaturePartial(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public IViewComponentResult Invoke()
        {
            
            return View();
        }
    }
}
