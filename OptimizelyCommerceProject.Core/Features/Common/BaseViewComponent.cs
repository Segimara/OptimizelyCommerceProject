using EPiServer;
using EPiServer.Core;
using Microsoft.AspNetCore.Mvc;
using OptimizelyCommerceProject.Core.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizelyCommerceProject.Core.Features.Common;
public class BaseViewComponent : ViewComponent
{
    private string DefaultViewPathTemplate = "~/Views/Shared/Components/{0}.cshtml";

    public virtual async Task<IViewComponentResult> InvokeAsync()
    {
        return View();
    }

    public IViewComponentResult View<T>(T currentPage, string? viewName = null) where T : class
    {
        var viewPath = string.Format(DefaultViewPathTemplate, viewName ?? currentPage.GetOriginalType().Name);
        return base.View(viewPath, currentPage);
    }

    public IViewComponentResult View<PageT, ViewModelT>(PageT currentPage, ViewModelT viewModel) where PageT : PageData
    {
        var viewPath = string.Format(DefaultViewPathTemplate, currentPage.GetOriginalType().Name);
        var model = new ComposedPageViewModel<PageT, ViewModelT>(currentPage, viewModel);
        return base.View(viewPath, currentPage);
    }
}
