using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using BlazorWinForms5.RazorLib.Data;

namespace BlazorWinForms5;

public static class Startup
{
    public static IServiceProvider? Services { get; private set; }

    public static void Init()
    {
        var host = Host.CreateDefaultBuilder()
                       .ConfigureServices(WireupServices)
                       .Build();
        Services = host.Services;
    }

    private static void WireupServices(IServiceCollection services)
    {
        services.AddWindowsFormsBlazorWebView();
        services.AddSingleton<WeatherForecastService>();

#if DEBUG
        services.AddBlazorWebViewDeveloperTools();
#endif
    }
}
