//(cwe352)
public void ConfigureServices(IServiceCollection services)
{
    // ...
    services.AddControllersWithViews(options => options.Filters.Add(new IgnoreAntiforgeryTokenAttribute())); // Sensitive
    // ...
}

[HttpPost, IgnoreAntiforgeryToken] // Sensitive
public IActionResult ChangeEmail(ChangeEmailModel model) => View("~/Views/...");