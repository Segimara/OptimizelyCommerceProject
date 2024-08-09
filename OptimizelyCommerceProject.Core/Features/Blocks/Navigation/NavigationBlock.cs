using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using OptimizelyCommerceProject.Core.Constants;
using OptimizelyCommerceProject.Core.Features.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizelyCommerceProject.Core.Features.Blocks.Navigation;

[ContentType(
    GUID = "EAE59686-9A06-4B2F-9C84-3970F3DED89D",
    DisplayName = "Navigation Block",
    GroupName = Globals.BlockGroupNames.Navigation
    )]
public class NavigationBlock : BaseBlockData
{
    [Display(
        GroupName = Globals.PropertyGroupNames.Content,
        Order = 10)]
    public virtual ContentReference Link { get; set; }
    [Display(
        GroupName = Globals.PropertyGroupNames.Content,
        Order = 25)]
    public virtual string Text { get; set; }

    [Display(
        GroupName = Globals.PropertyGroupNames.Content,
        Order = 50)]
    public virtual bool OpenInNewWindow { get; set; }

    [Display(
        GroupName = Globals.PropertyGroupNames.Content,
        Order = 100)]
     public virtual ContentArea ChildrenLink { get; set; }
}
