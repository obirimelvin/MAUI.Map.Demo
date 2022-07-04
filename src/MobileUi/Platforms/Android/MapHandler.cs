using Android.Gms.Maps;
using Android.OS;
using Microsoft.Maui.Handlers;
using MobileUi3.View.Interfaces;
using GoogleMapView = Android.Gms.Maps.MapView;
using MapView = MobileUi3.View.Controls.MapView;

namespace MobileUi3.View.Handlers;
public partial class MapHandler : ViewHandler<IMapView, GoogleMapView>, IDisposable
{
    private MapHelper _mapHelper;

    internal static Bundle Bundle { get; set; }


    public MapHandler(IPropertyMapper mapper, CommandMapper commandMapper = null)
        : base(mapper, commandMapper)
    { }

    protected override GoogleMapView CreatePlatformView()
    {
        return new GoogleMapView(Context);
    }

    protected override void ConnectHandler(GoogleMapView platformView)
    {
        base.ConnectHandler(platformView);

        _mapHelper = new MapHelper(Bundle, platformView);
        _mapHelper.MapIsReady += _mapHelper_MapIsReady;
        _mapHelper.CallCreateMap();
    }

    private void _mapHelper_MapIsReady(object sender, EventArgs e)
    {
        _mapHelper.Map.UiSettings.ZoomControlsEnabled = true;
        _mapHelper.Map.UiSettings.CompassEnabled = true;
    }

    public void Dispose()
    {
        //throw new NotImplementedException();
    }
}

class MapHelper : Java.Lang.Object, IOnMapReadyCallback
{
    private Bundle _bundle;
    private GoogleMapView _mapView;

    public event EventHandler MapIsReady;

    public GoogleMap Map { get; set; }

    public MapHelper(Bundle bundle, GoogleMapView mapView)
    {
        _bundle = bundle;
        _mapView = mapView;
    }

    public void CallCreateMap()
    {
        _mapView.OnCreate(_bundle);
        _mapView.GetMapAsync(this);
    }

    public void OnMapReady(GoogleMap googleMap)
    {
        Map = googleMap;
        MapIsReady?.Invoke(this, EventArgs.Empty);
    }
}