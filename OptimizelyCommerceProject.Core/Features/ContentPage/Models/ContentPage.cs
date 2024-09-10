
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using OptimizelyCommerceProject.Core.Constants;
using OptimizelyCommerceProject.Core.Features.Common.Models;
using OptimizelyCommerceProject.Core.Features.SEO;
using System.ComponentModel.DataAnnotations;

namespace OptimizelyCommerceProject.Core.Features.ContentPage.Models;

[ContentType(
    GUID = "19CEEB06-990D-4105-9943-7F8264FC9B4C",
    DisplayName = "Content Page",
    GroupName = Globals.PageGroupNames.Content)]
[AvailableContentTypes(
    Availability = Availability.Specific,
    Include = new[] {
        typeof(ContentPage),
    })]
public class ContentPage : BasePageModel
{
    [Display(
        Name = "Headline",
    GroupName = SystemTabNames.Content,
    Order = 200)]
    public virtual string Headline { get; set; }
    [Display(
        Name = "Content",
    GroupName = SystemTabNames.Content,
    Order = 300)]
    public virtual XhtmlString Content { get; set; }
}
