using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizelyCommerceProject.Core.Features.Common.Navigation.Models;
public class NavigationViewModel
{
    public string Title { get; set; } = string.Empty;
    public string Url { get; set; } = "#";
    public List<NavigationViewModel> Children { get; set; }
    public string Target { get; set; } = "_self";
}
