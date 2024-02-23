using ZXing.Net.Maui;
using ZXing.Net.Maui.Controls;

namespace FmgLib.MauiMarkup.ZXing;

public static partial class CameraViewExtension
{
    public static T IsTorchOnFmg<T>(this T self,
        bool isTorchOn)
        where T : CameraView
    {
        self.SetValue(CameraView.IsTorchOnProperty, isTorchOn);
        return self;
    }

    public static T IsTorchOnFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : CameraView
    {
        var context = new PropertyContext<bool>(self, CameraView.IsTorchOnProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IsTorchOnFmg<T>(this SettersContext<T> self,
        bool isTorchOn)
        where T : CameraView
    {
        self.XamlSetters.Add(new Setter { Property = CameraView.IsTorchOnProperty, Value = isTorchOn });
        return self;
    }

    public static SettersContext<T> IsTorchOnFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : CameraView
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, CameraView.IsTorchOnProperty);
        configure(context).Build();
        return self;
    }

    public static T CameraLocationFmg<T>(this T self,
        CameraLocation cameraLocation)
        where T : CameraView
    {
        self.SetValue(CameraView.CameraLocationProperty, cameraLocation);
        return self;
    }

    public static T CameraLocationFmg<T>(this T self, Func<PropertyContext<CameraLocation>, IPropertyBuilder<CameraLocation>> configure)
        where T : CameraView
    {
        var context = new PropertyContext<CameraLocation>(self, CameraView.CameraLocationProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> CameraLocationFmg<T>(this SettersContext<T> self,
        CameraLocation cameraLocation)
        where T : CameraView
    {
        self.XamlSetters.Add(new Setter { Property = CameraView.CameraLocationProperty, Value = cameraLocation });
        return self;
    }

    public static SettersContext<T> CameraLocationFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<CameraLocation>, IPropertySettersBuilder<CameraLocation>> configure)
        where T : CameraView
    {
        var context = new PropertySettersContext<CameraLocation>(self.XamlSetters, CameraView.CameraLocationProperty);
        configure(context).Build();
        return self;
    }
}
