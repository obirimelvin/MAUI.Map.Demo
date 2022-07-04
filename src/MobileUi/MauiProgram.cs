using MobileUi3.Pages;
using CommunityToolkit.Maui;
using MobileUi3.View.Controls;
using MobileUi3.View.Handlers;
namespace MobileUi3;

public static class MauiProgram
{

    public static MauiApp CreateMauiApp()
    {
        MauiAppBuilder builder = MauiApp.CreateBuilder()
            .UseMauiApp<App>()            
            .AddPages()
            
            .ConfigureMauiHandlers(handlers =>
            {
                handlers.AddHandler(typeof(MapView), typeof(MapHandler));
            })
            .ConfigureEssentials()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

        // Initialise the toolkit
        builder.UseMauiApp<App>().UseMauiCommunityToolkit();      

        return builder.Build();
    }
}