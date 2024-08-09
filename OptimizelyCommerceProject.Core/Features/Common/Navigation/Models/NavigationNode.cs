using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using OptimizelyCommerceProject.Core.Constants;
using System.ComponentModel.DataAnnotations;

namespace OptimizelyCommerceProject.Core.Features.Common.Navigation.Models;
[ContentType(GroupName = Globals.PageGroupNames.Navigation,
             GUID = "7AB38115-F1A9-4FBC-9458-405489801704")]
[AvailableContentTypes(
    Availability = Availability.Specific,
    Include = new[] {
        typeof(NavigationNode),
    })]
public class NavigationNode : PageData
{
    [Display(
        Name = "Link",
        GroupName = SystemTabNames.Content,
        Order = 100)]
    public virtual Url Link { get; set; }
}
