using Brupper.AspNetCore.Breadcrumbs;
using Brupper.AspNetCore.Breadcrumbs.Attributes;
using Brupper.AspNetCore.Breadcrumbs.Nodes;
using Microsoft.AspNetCore.Mvc;
using RazorPagesAndMvc.Pages.CSharp;
using System;

namespace RazorPagesAndMvc.Controllers.Other
{
    [Route("Other/[action]")]
    public class OtherController : Controller
    {

        [Breadcrumb("<script>alert('test')</script>", FromPage = typeof(IndexModel))]
        public IActionResult XssTest()
        {
            var builder = new FluentBreadcrumbNodeBuilder()
            .AddMvcNode("Index", "Project", "Java")
                .AddMvcNode(nameof(Index), "EasyJava", "Easy")
                    .AddMvcNode(nameof(XssTest), "EasyJava", "Post 2")
                    .EndNode()
                .EndNode()
            .EndNode();

            // Manually create the nodes (assuming you used the attribute to create a Default node, otherwise create it manually too).
            var childNode1 = new MvcBreadcrumbNode("Action 1", "Home", "Action1");
            childNode1.Parent = builder.Build();

            // When manually creating nodes, you have the option to use route values in case you need them
            var childNode2 = new MvcBreadcrumbNode("<script>alert('test')</script>", "Home", "Action2");
            childNode2.RouteValues = new { id = 10 };
            childNode2.Parent = childNode1;

            //All you have to do now is tell SmartBreadcrumbs about this
            ViewData.SetBreadcrumbs(childNode2);

            return View();
        }

    }
}