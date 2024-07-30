using EPiServer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPiServer.DataAnnotations;
using OptimizelyCommerceProject.Core.Constants;

namespace OptimizelyCommerceProject.Core.Features.SEO;

[ContentType(GroupName = Globals.GroupNames.SEO)]
public abstract class SEOModel : PageData
{
}
