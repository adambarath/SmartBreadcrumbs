using Brupper.AspNetCore.Breadcrumbs.Nodes;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Brupper.AspNetCore.Breadcrumbs;

public static class ViewContextExtensions
{
    public static BreadcrumbNode GetBreadcrumbs(this ViewContext viewContext, BreadcrumbManager breadcrumbManager)
    {
        var nodeKey = new NodeKey(viewContext.ActionDescriptor.RouteValues, viewContext.HttpContext.Request.Method);

        if (!viewContext.ViewData.TryGetBreadcrumbs(out var node))
        {
            node = breadcrumbManager.GetNode(nodeKey.Value);
        }

        return node;
    }
}