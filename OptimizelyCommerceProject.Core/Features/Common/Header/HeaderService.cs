using EPiServer;
using EPiServer.Commerce.Bolt;
using EPiServer.ServiceLocation;
using Microsoft.Extensions.DependencyInjection;
using OptimizelyCommerceProject.Core.Features.Components.Header.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizelyCommerceProject.Core.Features.Common.Header;

internal interface IHeaderService
{

}


[ServiceConfiguration(ServiceType = typeof(IHeaderService), Lifecycle = ServiceInstanceScope.Transient)]
internal class HeaderService : IHeaderService
{
    private readonly IContentLoader _contentLoader;


    public HeaderService(IContentLoader contentLoader)
    {
        _contentLoader = contentLoader;
    }

    public HeaderViewModel GetHeaderViewModel()
    {
        var header = ;
        return new HeaderViewModel
        {

        };
    }
}
