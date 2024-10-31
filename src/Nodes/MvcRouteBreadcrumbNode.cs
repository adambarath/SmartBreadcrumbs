using Brupper.AspNetCore.Breadcrumbs.Attributes;
using Microsoft.AspNetCore.Mvc;

namespace Brupper.AspNetCore.Breadcrumbs.Nodes;

public class MvcRouteBreadcrumbNode : BreadcrumbNode
{

    #region Properties

    public string RouteName { get; set; }


    #endregion

    internal MvcRouteBreadcrumbNode(string routeName, BreadcrumbAttribute attr) : base(attr)
    {
        RouteName = routeName;
    }

    public MvcRouteBreadcrumbNode(string routeName, string title, bool overwriteTitleOnExactMatch = false, string iconClasses = null, string areaName = null)
        : base(title, overwriteTitleOnExactMatch, iconClasses, areaName)
    {
        RouteName = routeName;
    }

    #region Public Methods

    public override string GetUrl(IUrlHelper urlHelper) => urlHelper.RouteUrl(RouteName, RouteValues);

    #endregion
}
