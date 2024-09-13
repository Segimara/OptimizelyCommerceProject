using EPiServer;
using EPiServer.Commerce.Bolt;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using EPiServer.Web;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.DependencyInjection;
using OptimizelyCommerceProject.Core.Features.Common.Navigation.Models;
using OptimizelyCommerceProject.Core.Features.Components.Header.Models;
using OptimizelyCommerceProject.Core.Features.Settings;
using OptimizelyCommerceProject.Core.Infrastructure.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizelyCommerceProject.Core.Features.Common.Header;

public interface IHeaderService
{
    HeaderViewModel GetHeaderViewModel();
}


[ServiceConfiguration(ServiceType = typeof(IHeaderService), Lifecycle = ServiceInstanceScope.Transient)]
internal class HeaderService : IHeaderService
{
    private readonly IContentLoader _contentLoader;
    private readonly IContentRepository _contentRepository;
    private readonly PageContentProvider _pageContentProvider;

    public HeaderService(IContentLoader contentLoader, IContentRepository contentRepository, PageContentProvider contentProvider)
    {
        _contentLoader = contentLoader;
        _contentRepository = contentRepository;
        _pageContentProvider = contentProvider;
    }

    public HeaderViewModel? GetHeaderViewModel()
    {
        var settings = _pageContentProvider.GetSiteSettings();
        var header = _pageContentProvider.GetContent<HeaderModel>(settings?.ContentLink, typeof(HeaderModel));
        return new HeaderViewModel
        {

        };
    }
}