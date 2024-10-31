using Microsoft.AspNetCore.Mvc;
using Brupper.AspNetCore.Breadcrumbs.Attributes;

namespace RazorPagesAndMvc.Controllers.Java
{
    [Route("Java")]
    public class JavaController : Controller
    {

        [Breadcrumb("Java")]
        public IActionResult Index()
        {
            return View();
        }

    }
}