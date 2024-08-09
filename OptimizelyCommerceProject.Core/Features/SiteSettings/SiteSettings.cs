using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using OptimizelyCommerceProject.Core.Constants;
using OptimizelyCommerceProject.Core.Features.Common.Header;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizelyCommerceProject.Core.Features.SiteSettings;

[ContentType(GUID = "439B1DE1-ED06-4AF3-B346-D6D7D464B72B",
    DisplayName = "Site Settings",
    GroupName = Globals.PageGroupNames.SiteSettings)]
[AvailableContentTypes(Availability = Availability.Specific,
    Include = new[] {
        typeof(HeaderContent)
    }
    )]
public class SiteSettings : PageData
{
    [Display(
        GroupName = Globals.PropertyGroupNames.SiteSettings,
        Order = 100)]
    [CultureSpecific]
    public virtual string SiteName { get; set; }
}
