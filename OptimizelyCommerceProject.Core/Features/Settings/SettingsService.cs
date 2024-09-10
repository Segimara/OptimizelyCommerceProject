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
    private readonly ContentRootService _contentRootService;

    public void InitSettigs()
    {
        
    }
}
