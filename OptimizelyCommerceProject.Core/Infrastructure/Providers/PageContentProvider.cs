using EPiServer;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using Microsoft.EntityFrameworkCore.Query.Internal;
using OptimizelyCommerceProject.Core.Features.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizelyCommerceProject.Core.Infrastructure.Providers;

[ServiceConfiguration(ServiceType = typeof(PageContentProvider), Lifecycle = ServiceInstanceScope.Transient)]
internal class PageContentProvider
{
    private readonly IContentRepository _contentRepository;

    public PageContentProvider(IContentRepository contentRepository)
    {
        _contentRepository = contentRepository;
    }

    public SiteSettings GetSiteSettings()
    {
        var siteSettings = _contentRepository.Get<SiteSettings>(ContentReference.RootPage);
        return siteSettings;
    }

    public T? GetContent<T>(ContentReference startPage, params Type[] pagePathTypes) where T : PageData
    {
        PageData? page = null;
        if (startPage != null) {
            foreach (var pagePathType in pagePathTypes) {
                page = _contentRepository.GetChildren<T>(page?.ContentLink).FirstOrDefault();
                if (page != null) {
                    break;
                }
            }
        }
        return page as T;
    }
}
