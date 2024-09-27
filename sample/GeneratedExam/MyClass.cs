using FmgLib.MauiMarkup;

namespace GeneratedExam;

[MauiMarkup(typeof(ZXing.Net.Maui.Controls.BarcodeGeneratorView))]
public class MyBarcodeGeneratorView { }

[MauiMarkup(typeof(ZXing.Net.Maui.Controls.CameraView))]
public class MyCameraView { }


[MauiMarkup(typeof(SkiaSharp.Extended.UI.Controls.SKLottieView), typeof(ZXing.Net.Maui.Controls.CameraBarcodeReaderView),typeof(KeyboardAccelerator))]
public class MySkLottieView { }
