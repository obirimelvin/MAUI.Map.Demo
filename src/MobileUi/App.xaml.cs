
using MobileUi3.Pages;

namespace MobileUi3;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new PerformanceDetailPage();
        
    }
}

