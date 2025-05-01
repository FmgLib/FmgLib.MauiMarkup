using Foundation;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace App1;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}