using Brupper.AspNetCore.Breadcrumbs.Attributes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;

namespace Brupper.AspNetCore.Breadcrumbs.Nodes;

public class MvcControllerBreadcrumbNode : BreadcrumbNode
{
    #region Properties
    public string Controller { get; set; }

    #endregion

    internal MvcControllerBreadcrumbNode(string controller, BreadcrumbAttribute attr) : base(attr)
    {
        Controller = controller;
    }

    public MvcControllerBreadcrumbNode(string controller, string title, bool overwriteTitleOnExactMatch = false, string iconClasses = null, string areaName = null)
        : base(title, overwriteTitleOnExactMatch, iconClasses, areaName)
    {
        Controller = controller;
    }

    #region Public Methods
    public override string GetUrl(IUrlHelper urlHelper) => urlHelper.Action(new UrlActionContext() { Action = BreadcrumbManager.Options.DefaultAction, Controller = Controller, Values = RouteValues });
    #endregion
}
