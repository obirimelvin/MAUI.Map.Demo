using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;

using MobileUi3.View.Handlers;


namespace MobileUi3;
[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    Intent serviceIntent;
    protected override void OnCreate(Bundle savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
                
        MapHandler.Bundle = savedInstanceState;
    }


}
