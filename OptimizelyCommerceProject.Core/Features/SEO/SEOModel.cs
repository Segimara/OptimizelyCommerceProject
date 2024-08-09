using EPiServer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPiServer.DataAnnotations;
using OptimizelyCommerceProject.Core.Constants;
using EPiServer.DataAbstraction;
using System.ComponentModel.DataAnnotations;

namespace OptimizelyCommerceProject.Core.Features.SEO;

[ContentType(GroupName = Globals.PageGroupNames.SEO)]
public abstract class SEOModel : PageData
{
    [Display(
        GroupName = Globals.PropertyGroupNames.SEO,
        Order = 100)]
    [CultureSpecific]
    public virtual string MetaTitle { get; set; }

    [Display(
        GroupName = Globals.PropertyGroupNames.SEO,
        Order = 200)]
    [CultureSpecific]
    public virtual string MetaDescription { get; set; }

}
