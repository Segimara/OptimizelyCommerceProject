using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using OptimizelyCommerceProject.Core.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizelyCommerceProject.Core.Features.Common.Footer;
[ContentType(DisplayName = "Footer Content",
    GUID = "AEB4B22F-DC66-48D2-99D7-32A39AC7911F",
    GroupName = Globals.PageGroupNames.Default)]
[AvailableContentTypes(Availability.Specific
    )]
public class Footer : PageData
{
}
