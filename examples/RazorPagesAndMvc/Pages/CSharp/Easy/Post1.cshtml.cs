using Microsoft.AspNetCore.Mvc.RazorPages;
using Brupper.AspNetCore.Breadcrumbs.Attributes;

namespace RazorPagesAndMvc.Pages.CSharp.Easy
{
    [Breadcrumb("Post 1", FromPage = typeof(IndexModel))]
    public class Post1Model : PageModel
    {

        public void OnGet()
        {

        }

    }
}