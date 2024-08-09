using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizelyCommerceProject.Core.Constants;

//TODO add strongly typed attributes to reduce contstansts usage in code
public class Globals
{
    [GroupDefinitions]
    public static class PageGroupNames
    {
        [Display(Name = "Default", Order = 100)]
        public const string Default = "Default";
        [Display(Name = "Content", Order = 200)]
        public const string Content = "Content";

        [Display(Name = "Navigation", Order = 700)]
        public const string Navigation = "Navigation";
        [Display(Name = "SiteSettings", Order = 800)]
        public const string SiteSettings = "SiteSettings";

        [Display(Name = "Specialized", Order = 900)]
        public const string Specialized = "Specialized";

        [Display(Name = "SEO", Order = 1000)]
        public const string SEO = "SEO";
        [Display(Name = "Settings", Order = 1100)]
        public const string Settings = "Settings";
    }

    public static class PropertyGroupNames
    {
        [Display(Name = "Default", Order = 100)]
        public const string Default = "Default";
        [Display(Name = "Content", Order = 200)]
        public const string Content = SystemTabNames.Content;
        [Display(Name = "Site Settings", Order = 800)]
        public const string SiteSettings = "Site Settings";
        [Display(Name = "Settings", Order = 900)]
        public const string Settings = "Settings";
        [Display(Name = "SEO", Order = 1000)]
        public const string SEO = "SEO";
    }

    public static class BlockGroupNames
    {
        [Display(Name = "Default", Order = 0)]
        public const string Default = "Default";
        [Display(Name = "Banner", Order = 100)]
        public const string Banner = "Banner";
        [Display(Name = "Content", Order = 200)]
        public const string Content = "Content";
        [Display(Name = "Navigation", Order = 800)]
        public const string Navigation = "Navigation";
        [Display(Name = "Specialized", Order = 900)]
        public const string Specialized = "Specialized";
    }
}
