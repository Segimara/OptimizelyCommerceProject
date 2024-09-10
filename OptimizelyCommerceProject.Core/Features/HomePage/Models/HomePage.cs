using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using OptimizelyCommerceProject.Core.Constants;
using OptimizelyCommerceProject.Core.Features.Common.Models;
using OptimizelyCommerceProject.Core.Features.SEO;
using OptimizelyCommerceProject.Core.Features.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizelyCommerceProject.Core.Features.HomePage.Models;

[ContentType(
    GUID = "B41FB992-F74F-4B5C-A50B-1A85773921A7",
    DisplayName = "Home Page",
    GroupName = Globals.PageGroupNames.Specialized),
    ]
[AvailableContentTypes(
    Availability = Availability.Specific,
    Include = new[] { 
        typeof(SiteSettings),
        typeof(ContentPage.Models.ContentPage), 
    })]
public class HomePage : BasePageModel
{
    [Display(
    GroupName = Globals.PropertyGroupNames.Content,
    Order = 300)]
    [CultureSpecific]
    public virtual ContentArea MainContentArea { get; set; }
}
