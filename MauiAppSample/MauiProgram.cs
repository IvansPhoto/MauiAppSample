using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Markup;
using Microsoft.Extensions.Logging;

namespace MauiAppSample;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>();
        builder.ConfigureFonts(fonts =>
        {
            fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
        });
        builder.UseMauiCommunityToolkit(options =>
        {
            options.SetShouldSuppressExceptionsInConverters(false);
            options.SetShouldSuppressExceptionsInBehaviors(false);
            options.SetShouldSuppressExceptionsInAnimations(false);
        });
        builder.UseMauiCommunityToolkitMarkup();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}