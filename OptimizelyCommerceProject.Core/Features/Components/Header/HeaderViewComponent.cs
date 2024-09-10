using Microsoft.AspNetCore.Mvc;
using OptimizelyCommerceProject.Core.Features.Common;
using OptimizelyCommerceProject.Core.Features.Common.Header;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizelyCommerceProject.Core.Features.Components.Header;
public class HeaderViewComponent : BaseViewComponent
{
    private readonly IHeaderService _headerService;

    public HeaderViewComponent(IHeaderService headerService)
    {
        _headerService = headerService;
    }

    public override async Task<IViewComponentResult> InvokeAsync()
    {
        var model = _headerService.GetHeaderViewModel();
        return View(model, "Header");
    }
}
