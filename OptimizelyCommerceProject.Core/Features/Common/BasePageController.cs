using EPiServer;
using EPiServer.Core;
using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizelyCommerceProject.Core.Features.Common;
public class BasePageController<T> : PageController<T> where T : PageData
{
    private string DefaultViewPathTemplate = "~/Views/Pages/{0}.cshtml";
    public IActionResult Index(T currentPage)
    {
        return View(currentPage);
    }

    public ViewResult View<PageT>(PageT currentPage) where PageT : class
    {
        var viewPath = string.Format(DefaultViewPathTemplate, currentPage.GetOriginalType().Name);
        return base.View(viewPath, currentPage);
    }
}
