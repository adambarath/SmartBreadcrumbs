using Microsoft.AspNetCore.Mvc.Infrastructure;
using SmartBreadcrumbs;
using System;
using System.Reflection;

namespace Microsoft.Extensions.DependencyInjection.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddBreadcrumbs(this IServiceCollection services, params Assembly[] assemblies)
        => AddBreadcrumbs(services, new BreadcrumbOptions(), assemblies);

    public static void AddBreadcrumbs(this IServiceCollection services, Action<BreadcrumbOptions> optionsSetter, params Assembly[] assemblies)
    {
        var options = new BreadcrumbOptions();
        optionsSetter.Invoke(options);
        AddBreadcrumbs(services, options, assemblies);
    }

    private static void AddBreadcrumbs(IServiceCollection services, BreadcrumbOptions options, params Assembly[] assemblies)
    {
        var bm = new BreadcrumbManager(options);
        bm.Initialize(assemblies);
        services.AddSingleton(bm);

        services.TryAddSingleton<IActionContextAccessor, ActionContextAccessor>();
    }
}
