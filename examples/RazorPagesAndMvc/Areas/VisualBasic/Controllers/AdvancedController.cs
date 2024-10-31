﻿using Microsoft.AspNetCore.Mvc;
using Brupper.AspNetCore.Breadcrumbs.Attributes;

namespace RazorPagesAndMvc.Areas.VisualBasic.Controllers
{
    [Area("VisualBasic")]
    public class AdvancedController : Controller
    {
        public AdvancedController()
        {

        }
        
        [HttpGet]
        [Breadcrumb("Advanced", AreaName = "VisualBasic", FromAction = "Index", FromController = typeof(HomeController))]
        public IActionResult Index()
        {
            return View();
        }
    }
}
