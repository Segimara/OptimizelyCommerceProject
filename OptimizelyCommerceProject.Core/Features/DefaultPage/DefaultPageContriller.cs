using EPiServer;
using EPiServer.Framework.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using OptimizelyCommerceProject.Core.Features.SEO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizelyCommerceProject.Core.Features.DefaultPage;
[TemplateDescriptor(Inherited = true)]
public class DefaultPageContriller : BasePageController<SEOModel>
{
    public ViewResult Index(SEOModel currentPage)
    {
        return View($"~/Views/{currentPage.GetOriginalType().Name}/Index.cshtml", currentPage);
    }

}