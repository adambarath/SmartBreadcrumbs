using Brupper.AspNetCore.Breadcrumbs.Nodes;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Brupper.AspNetCore.Breadcrumbs;

public static class ViewDataDictionaryExtensions
{
    internal const string BreadcrumbNodeKey = "BreadcrumbNode";

    public static void SetBreadcrumbs(this ViewDataDictionary viewData, BreadcrumbNode breadcrumb) => viewData[BreadcrumbNodeKey] = breadcrumb;

    public static bool TryGetBreadcrumbs(this ViewDataDictionary viewData, out BreadcrumbNode breadcrumb)
    {
        var result = viewData.TryGetValue(BreadcrumbNodeKey, out var breadcrumbObject);

        breadcrumb = breadcrumbObject as BreadcrumbNode;

        return result;
    }
}