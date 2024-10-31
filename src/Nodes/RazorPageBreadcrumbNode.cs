using Brupper.AspNetCore.Breadcrumbs.Attributes;
using Microsoft.AspNetCore.Mvc;

namespace Brupper.AspNetCore.Breadcrumbs.Nodes;

public class RazorPageBreadcrumbNode : BreadcrumbNode
{

    #region Properties

    public string Path { get; set; }

    #endregion

    internal RazorPageBreadcrumbNode(string path, BreadcrumbAttribute attr) : base(attr)
    {
        Path = path;
    }

    public RazorPageBreadcrumbNode(string path, string title, bool overwriteTitleOnExactMatch = false, string iconClasses = null, string areaName = null)
        : base(title, overwriteTitleOnExactMatch, iconClasses, areaName)
    {
        Path = path;
    }

    #region Public Methods

    public override string GetUrl(IUrlHelper urlHelper) => urlHelper.Page(Path, RouteValues);

    #endregion

}
