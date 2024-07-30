using EPiServer.Core;
using EPiServer.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizelyCommerceProject.Core.Features.DefaultPage;
public class BasePageController<T> : PageController<T> where T : PageData
{
    public IActionResult Index(T currentPage)
    {
        return View(currentPage);
    }
}
