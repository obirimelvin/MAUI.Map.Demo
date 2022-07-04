#if __IOS__ || MACCATALYST
using PlatformView = Microsoft.Maui.Platform.MauiLabel;
#elif ANDROID
using PlatformView = Android.Gms.Maps.MapView;
#elif WINDOWS
using PlatformView = Microsoft.UI.Xaml.Controls.TextBlock;
#elif TIZEN
using PlatformView = Tizen.UIExtensions.ElmSharp.Label;
#elif (NETSTANDARD || !PLATFORM) || (NET6_0_OR_GREATER && !IOS && !TIZEN)
using PlatformView = System.Object;
#endif

using MobileUi3.View.Interfaces;
namespace MobileUi3.View.Handlers;
public interface IMapHandler : IViewHandler
{
    new IMapView VirtualView { get; }
    new PlatformView PlatformView { get; }
}
