using Microsoft.AspNetCore.Mvc.RazorPages;
using Brupper.AspNetCore.Breadcrumbs.Attributes;

namespace RazorPagesAndMvc.Pages.CSharp.Advanced
{
    [Breadcrumb("Advanced", FromPage = typeof(CSharp.IndexModel))]
    public class IndexModel : PageModel
    {

        public void OnGet()
        {

        }

    }
}