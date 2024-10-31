using Microsoft.AspNetCore.Mvc;
using Brupper.AspNetCore.Breadcrumbs.Attributes;

namespace Brupper.AspNetCore.Breadcrumbs.UnitTests
{
    [DefaultBreadcrumb]
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return Ok();
        }

        [Breadcrumb]
        public IActionResult Privacy()
        {
            return Ok();
        }
    }

    [Breadcrumb]
    public class SecondController : Controller
    {
        public IActionResult Index()
        {
            return Ok();
        }

        [Breadcrumb(FromAction = nameof(MainController.Privacy), FromController = typeof(MainController))]
        public IActionResult Privacy()
        {
            return Ok();
        }

        [Breadcrumb]
        public IActionResult About()
        {
            return Ok();
        }
    }

    public class TestController : Controller
    {

        public IActionResult MyAction()
        {
            return Ok();
        }

    }
}

namespace Brupper.AspNetCore.Breadcrumbs.Controllers.SubFolder
{

    public class TestTwoController : Controller
    {

        public IActionResult MyActionTwo()
        {
            return Ok();
        }

    }

}