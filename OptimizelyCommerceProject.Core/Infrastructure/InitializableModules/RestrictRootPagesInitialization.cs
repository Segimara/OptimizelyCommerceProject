using EPiServer.DataAbstraction;
using EPiServer.Framework.Initialization;
using EPiServer.Framework;
using EPiServer.Initialization;
using EPiServer.Shell.ViewComposition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPiServer.ServiceLocation;
using OptimizelyCommerceProject.Core.Features.HomePage.Models;

namespace OptimizelyCommerceProject.Core.Infrastructure.InitializableModules;
[InitializableModule]
[ModuleDependency(typeof(CmsCoreInitialization))]
public class RestrictRootPagesInitialization : IInitializableModule
{
    public void Initialize(InitializationEngine context)
    {
        var contentTypeRepository = context.Locate.Advanced.GetInstance<IContentTypeRepository>();

        var sysRoot = contentTypeRepository.Load("SysRoot") as PageType;

        var setting = new AvailableSetting { Availability = Availability.Specific };
        setting.AllowedContentTypeNames.Add(contentTypeRepository.Load<HomePage>().Name);

        var availableSettingsRepository = context.Locate.Advanced.GetInstance<IAvailableSettingsRepository>();
        availableSettingsRepository.RegisterSetting(sysRoot, setting);
    }

    public void Uninitialize(InitializationEngine context)
    {
    }
}