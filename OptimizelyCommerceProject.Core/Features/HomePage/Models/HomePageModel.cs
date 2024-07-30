using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using OptimizelyCommerceProject.Core.Constants;
using OptimizelyCommerceProject.Core.Features.SEO;
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
    GroupName = Globals.GroupNames.Default)]
public class HomePageModel : SEOModel
{
    [Display(
    GroupName = SystemTabNames.Content,
    Order = 320)]
    [CultureSpecific]
    public virtual ContentArea MainContentArea { get; set; }

    
}
