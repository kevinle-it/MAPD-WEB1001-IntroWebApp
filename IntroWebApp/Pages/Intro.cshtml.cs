using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace IntroWebApp.Pages
{
    public class Intro : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public Intro(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            
        }
    }
}