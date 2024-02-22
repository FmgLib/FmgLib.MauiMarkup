using ZXing.Net.Maui;
using ZXing.Net.Maui.Controls;

namespace FmgLib.MauiMarkup.ZXing;

public static partial class CameraBarcodeReaderViewExtension
{
    public static T OptionsFmg<T>(this T self,
        BarcodeReaderOptions options)
        where T : CameraBarcodeReaderView
    {
        self.SetValue(CameraBarcodeReaderView.OptionsProperty, options);
        return self;
    }

    public static T OptionsFmg<T>(this T self, Func<PropertyContext<BarcodeReaderOptions>, IPropertyBuilder<BarcodeReaderOptions>> configure)
        where T : CameraBarcodeReaderView
    {
        var context = new PropertyContext<BarcodeReaderOptions>(self, CameraBarcodeReaderView.OptionsProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> OptionsFmg<T>(this SettersContext<T> self,
        BarcodeReaderOptions options)
        where T : CameraBarcodeReaderView
    {
        self.XamlSetters.Add(new Setter { Property = CameraBarcodeReaderView.OptionsProperty, Value = options });
        return self;
    }

    public static SettersContext<T> OptionsFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<BarcodeReaderOptions>, IPropertySettersBuilder<BarcodeReaderOptions>> configure)
        where T : CameraBarcodeReaderView
    {
        var context = new PropertySettersContext<BarcodeReaderOptions>(self.XamlSetters, CameraBarcodeReaderView.OptionsProperty);
        configure(context).Build();
        return self;
    }

    public static T IsDetectingFmg<T>(this T self,
        bool isDetecting)
        where T : CameraBarcodeReaderView
    {
        self.SetValue(CameraBarcodeReaderView.IsDetectingProperty, isDetecting);
        return self;
    }

    public static T IsDetectingFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : CameraBarcodeReaderView
    {
        var context = new PropertyContext<bool>(self, CameraBarcodeReaderView.IsDetectingProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IsDetectingFmg<T>(this SettersContext<T> self,
        bool isDetecting)
        where T : CameraBarcodeReaderView
    {
        self.XamlSetters.Add(new Setter { Property = CameraBarcodeReaderView.IsDetectingProperty, Value = isDetecting });
        return self;
    }

    public static SettersContext<T> IsDetectingFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : CameraBarcodeReaderView
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, CameraBarcodeReaderView.IsDetectingProperty);
        configure(context).Build();
        return self;
    }

    public static T IsTorchOnFmg<T>(this T self,
        bool isTorchOn)
        where T : CameraBarcodeReaderView
    {
        self.SetValue(CameraBarcodeReaderView.IsTorchOnProperty, isTorchOn);
        return self;
    }

    public static T IsTorchOnFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : CameraBarcodeReaderView
    {
        var context = new PropertyContext<bool>(self, CameraBarcodeReaderView.IsTorchOnProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IsTorchOnFmg<T>(this SettersContext<T> self,
        bool isTorchOn)
        where T : CameraBarcodeReaderView
    {
        self.XamlSetters.Add(new Setter { Property = CameraBarcodeReaderView.IsTorchOnProperty, Value = isTorchOn });
        return self;
    }

    public static SettersContext<T> IsTorchOnFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : CameraBarcodeReaderView
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, CameraBarcodeReaderView.IsTorchOnProperty);
        configure(context).Build();
        return self;
    }

    public static T CameraLocationFmg<T>(this T self,
        CameraLocation cameraLocation)
        where T : CameraBarcodeReaderView
    {
        self.SetValue(CameraBarcodeReaderView.CameraLocationProperty, cameraLocation);
        return self;
    }

    public static T CameraLocationFmg<T>(this T self, Func<PropertyContext<CameraLocation>, IPropertyBuilder<CameraLocation>> configure)
        where T : CameraBarcodeReaderView
    {
        var context = new PropertyContext<CameraLocation>(self, CameraBarcodeReaderView.CameraLocationProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> CameraLocationFmg<T>(this SettersContext<T> self,
        CameraLocation cameraLocation)
        where T : CameraBarcodeReaderView
    {
        self.XamlSetters.Add(new Setter { Property = CameraBarcodeReaderView.CameraLocationProperty, Value = cameraLocation });
        return self;
    }

    public static SettersContext<T> CameraLocationFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<CameraLocation>, IPropertySettersBuilder<CameraLocation>> configure)
        where T : CameraBarcodeReaderView
    {
        var context = new PropertySettersContext<CameraLocation>(self.XamlSetters, CameraBarcodeReaderView.CameraLocationProperty);
        configure(context).Build();
        return self;
    }
}
