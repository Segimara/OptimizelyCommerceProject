using EPiServer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizelyCommerceProject.Core.Infrastructure.Models;
internal class ComposedPageViewModel<TPage, TViewModel>
    where TPage : PageData
{
    public ComposedPageViewModel(TPage page, TViewModel viewModel)
    {
        Page = page;
        ViewModel = viewModel;
    }
    public TPage Page { get; set; }

    public TViewModel ViewModel { get; set; }
}
