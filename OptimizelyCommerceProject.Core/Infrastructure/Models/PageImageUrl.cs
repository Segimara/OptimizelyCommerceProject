using EPiServer.DataAnnotations;

namespace OptimizelyCommerceProject.Core.Infrastructure.Models;

public class PageImageUrl : ImageUrlAttribute
{
    public PageImageUrl()
        : base("/gfx/page-type-thumbnail.png")
    {
    }

    public PageImageUrl(string path)
        : base(path)
    {
    }
}
