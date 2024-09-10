using EPiServer;
using EPiServer.Commerce.Bolt;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.DependencyInjection;
using OptimizelyCommerceProject.Core.Features.Common.Navigation.Models;
using OptimizelyCommerceProject.Core.Features.Components.Header.Models;
using OptimizelyCommerceProject.Core.Features.Settings;
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


    public HeaderService(IContentLoader contentLoader, IContentRepository contentRepository)
    {
        _contentLoader = contentLoader;
        _contentRepository = contentRepository;
    }

    public HeaderViewModel? GetHeaderViewModel()
    {
        var settings = 
        return new HeaderViewModel
        {

        };
    }
}