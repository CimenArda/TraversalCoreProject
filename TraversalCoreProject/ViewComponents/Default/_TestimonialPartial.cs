﻿using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _TestimonialPartial :ViewComponent
    {
        private readonly ITestimonialService _testimonialService;

        public _TestimonialPartial(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _testimonialService.TGetAllList();
            return View(values);
        }
    }
}
