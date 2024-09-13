using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using OptimizelyCommerceProject.Core.Constants;
using OptimizelyCommerceProject.Core.Features.Common.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizelyCommerceProject.Core.Features.Common.Header;

[ContentType(DisplayName = "Header Content",
    GUID = "9007224C-7C0E-431D-8A1E-71BC1BA460DE",
    GroupName = Globals.PageGroupNames.Default)]
[AvailableContentTypes(Availability.Specific
    )]
public class HeaderModel : PageData
{
    [Display(
        GroupName = SystemTabNames.Content,
        Order = 100)]
    public virtual string Logo { get; set; }

    [Display(
        GroupName = SystemTabNames.Content,
        Order = 200)]
    public virtual string Url { get; set; }

    [Display(
        GroupName = SystemTabNames.Content,
        Order = 300)]
    public virtual string Target { get; set; }

    [Display(
        GroupName = SystemTabNames.Content,
        Order = 400)]
    public virtual ContentArea Navigation { get; set; }
}
