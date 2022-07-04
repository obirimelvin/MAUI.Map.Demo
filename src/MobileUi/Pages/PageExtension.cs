namespace MobileUi3.Pages;
public static class PageExtension
{
    public static MauiAppBuilder AddPages(this MauiAppBuilder builder)
    {        
        builder.Services.AddTransient<PerformanceDetailPage>();        
        return builder;
    }
}
