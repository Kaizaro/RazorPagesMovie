using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesMovie.Constants;
using RazorPagesMovie.Utils;

namespace RazorPagesMovie.Pages;

public class PrivacyModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;
    private readonly string onGetTextPlaceholder = "OnGet method called.";

    public PrivacyModel(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        LogConsole.Log(onGetTextPlaceholder);
    }
}

