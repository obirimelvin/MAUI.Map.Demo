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

using Microsoft.Maui.Handlers;
using MobileUi3.View.Interfaces;

namespace MobileUi3.View.Handlers;
public partial class MapHandler : IMapHandler
{
    public static IPropertyMapper<IMapView, IMapHandler> Mapper = new PropertyMapper<IMapView, IMapHandler>(ViewHandler.ViewMapper)
    {

    };

    public static CommandMapper<IActivityIndicator, IMapHandler> CommandMapper = new(ViewCommandMapper)
    {
    };

    static MapHandler()
    {

    }

    public MapHandler() : base(Mapper)
    {
    }

    public MapHandler(IPropertyMapper? mapper = null) : base(mapper ?? Mapper)
    {
    }

    IMapView IMapHandler.VirtualView => VirtualView;    
    PlatformView IMapHandler.PlatformView => PlatformView;
}
