using Microsoft.AspNetCore.Mvc.RazorPages;
using Brupper.AspNetCore.Breadcrumbs.Attributes;

namespace RazorPagesAndMvc.Pages
{
    [DefaultBreadcrumb("Index Page")]
    public class IndexModel : PageModel
    {

        public void OnGet()
        {

        }

    }
}
