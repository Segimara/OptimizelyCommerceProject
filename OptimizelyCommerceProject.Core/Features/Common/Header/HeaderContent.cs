using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using OptimizelyCommerceProject.Core.Constants;
using OptimizelyCommerceProject.Core.Features.Common.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizelyCommerceProject.Core.Features.Common.Header;

[ContentType(DisplayName = "Header Content",
    GUID = "9007224C-7C0E-431D-8A1E-71BC1BA460DE",
    GroupName = Globals.PageGroupNames.Default)]
[AvailableContentTypes(Availability.Specific
    )]
public class HeaderContent : PageData
{
}
