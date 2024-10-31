using Microsoft.AspNetCore.Mvc;
using RazorPagesAndMvc.Pages;
using Brupper.AspNetCore.Breadcrumbs.Attributes;

namespace RazorPagesAndMvc.Areas.JavaScript.Controllers
{
    [Area("JavaScript")]
    [Route("Java-Script")]
    public class HomeController : Controller
    {
        public HomeController()
        {

        }

        [HttpGet]
        [Route("")]
        [Breadcrumb("JavaScript", AreaName = "JavaScript", FromPage = typeof(IndexModel))]
        public IActionResult Index()
        {
            return View();
        }
    }
}
