using EPiServer;
using EPiServer.Cms.Shell.UI.Rest.Internal;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizelyCommerceProject.Core.Features.Settings;

public interface ISettingsService
{

}
internal class SettingsService : ISettingsService
{
    private readonly IContentRepository _contentRepository;

    public SiteSettings GetSiteSettings()
    {
        var siteSettings = _contentRepository.Get<SiteSettings>(ContentReference.RootPage);
        return siteSettings;
    }
}
