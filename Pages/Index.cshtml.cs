using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorApp.Pages;

public class IndexModel : PageModel
{
    // automatically bound to the form data
    [BindProperty]
    public string? Company { get; set; }

    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        ViewData["MyName"] = "Isaac Rudy";
        Company = "Microsoft";
    }

    public void OnPost()
    {
        // var name = Request.Form["name"];
        // var email = Request.Form["email"];
        // var message = Request.Form["message"];
    }
}
