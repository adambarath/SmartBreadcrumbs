using Microsoft.AspNetCore.Mvc.ViewFeatures;
using SmartBreadcrumbs.Nodes;

namespace SmartBreadcrumbs;

public static class ViewDataDictionaryExtensions
{
    internal const string BreadcrumbNodeKey = "BreadcrumbNode";

    public static void SetBreadcrumbs(this ViewDataDictionary viewData, BreadcrumbNode breadcrumb) => viewData[BreadcrumbNodeKey] = breadcrumb;
}