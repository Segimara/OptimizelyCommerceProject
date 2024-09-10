using EPiServer.Core;
using Microsoft.EntityFrameworkCore.Query.Internal;
using OptimizelyCommerceProject.Core.Features.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizelyCommerceProject.Core.Infrastructure.Providers;
internal class ContentProvider
{
    public SiteSettings GetSiteSettings()
    {
        return new SiteSettings();
    }

    private T GetContent<T>(ContentReference startPage, params Type[] pagePathTypes) where T : class
    {
        return null;
    }
}
