using EPiServer;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using OptimizelyCommerceProject.Core.Features.Common.Header;
using OptimizelyCommerceProject.Core.Features.Common.Navigation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizelyCommerceProject.Core.Features.Common.Navigation;

public interface INavogationService
{
    NavigationViewModel GetNavigationViewModel();
}


[ServiceConfiguration(ServiceType = typeof(INavogationService), Lifecycle = ServiceInstanceScope.Transient)]
public class NavigationService : INavogationService
{
    private readonly IContentRepository _contentRepository;
    public NavigationViewModel GetNavigationViewModel()
    {
        return null;
    }
}
