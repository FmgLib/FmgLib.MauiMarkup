# **FmgLib.MauiMarkup**
The constructor method of the MauiMarkup() attribute automatically generates extension methods for BindableProperties and Events found within the type provided as an argument. You can provide a minimum of 1 and a maximum of 5 types inside the constructor method. Multiple MauiMarkup attributes can be added to a single class.

**Example Code:**
```csharp
using FmgLib.MauiMarkup;

namespace GeneratedExam;

[MauiMarkup(typeof(ZXing.Net.Maui.Controls.BarcodeGeneratorView))]
public class MyBarcodeGeneratorView { }

[MauiMarkup(typeof(ZXing.Net.Maui.Controls.CameraView))]
public class MyCameraView { }


[MauiMarkup(typeof(ZXing.Net.Maui.Controls.CameraBarcodeReaderView))]
public class MyCameraBarcodeReaderView { }

[MauiMarkup(typeof(SkiaSharp.Extended.UI.Controls.SKLottieView))]
public class MySkLottieView { }

```

OR 

```csharp

using Microsoft.Extensions.Logging;
using FmgLib.MauiMarkup;
using SkiaSharp.Extended.UI.Controls;
using ZXing.Net.Maui.Controls;
using UraniumUI.Material.Controls;
namespace MauiApp1
{
    [MauiMarkup(typeof(CameraView))]
    [MauiMarkup(typeof(SKLottieView), typeof(DataGrid))]
    [MauiMarkup(typeof(SKConfettiView), typeof(BarcodeGeneratorView),typeof(InputField),typeof(EditorField),typeof(TextField))]
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            return builder.Build();
        }
    }
}
```