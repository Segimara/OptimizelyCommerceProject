using EPiServer.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizelyCommerceProject.Core.Constants;
public class Globals
{
    [GroupDefinitions]
    public static class GroupNames
    {
        [Display(Name = "Default", Order = 100)]
        public const string Default = "Default";
        [Display(Name = "Content", Order = 200)]
        public const string Content = "Content";

        [Display(Name = "SiteSettings", Order = 80)]
        public const string SiteSettings = "SiteSettings";

        [Display(Name = "Specialized", Order = 900)]
        public const string Specialized = "Specialized";

        [Display(Name = "SEO", Order = 1000)]
        public const string SEO = "SEO";
        [Display(Name = "Settings", Order = 1100)]
        public const string Settings = "Settings";

    }
}
