using Microsoft.AspNetCore.Mvc.RazorPages;
using Brupper.AspNetCore.Breadcrumbs.Attributes;

namespace RazorPagesAndMvc.Pages
{
    [Breadcrumb("About")]
    public class AboutModel : PageModel
    {

        public void OnGet()
        {
        }

    }
}