using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.OutputCaching;

namespace YouTubeVideoPlaybackProxy.Pages
{
    public class IndexModel : PageModel
    {
        [OutputCache(VaryByQueryKeys = ["v"], Duration = 100)]
        public void OnGet()
        {
            var videoId = Request.Query["v"].FirstOrDefault() ?? "";
            ViewData["VideoId"] = videoId;
        }
    }
}
