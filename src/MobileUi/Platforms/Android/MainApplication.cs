using Android.App;
using Android.Runtime;

namespace MobileUi3;
[Application]
public class MainApplication : MauiApplication
{
    public MainApplication(IntPtr handle, JniHandleOwnership ownership)
        : base(handle, ownership)
    {
    }    

    protected override MauiApp CreateMauiApp() => MobileUi3.MauiProgram.CreateMauiApp();
}
