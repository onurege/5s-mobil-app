using DevExpress.Blazor;
using MauiApp4.Data;
using Microsoft.Extensions.Logging;
using Syncfusion.Blazor;
namespace MauiApp4
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif
            builder.Services.AddDevExpressBlazor(configure => configure.BootstrapVersion = BootstrapVersion.v5);
            builder.Services.AddSingleton<WeatherForecastService>();
            builder.Services.AddSingleton<QuestionList>();
            builder.Services.AddSyncfusionBlazor();
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NGaF1cVGhAYVF3WmFZfV1gc19FYVZTRGYuP1ZhSXxQdk1hW39Zc3ZURmBdUEY=");
            return builder.Build();
        }
    }
}