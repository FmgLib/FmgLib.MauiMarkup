using ZXing.Net.Maui;
using ZXing.Net.Maui.Controls;

namespace FmgLib.MauiMarkup.ZXing;

public static partial class BarcodeGeneratorViewExtension
{
    public static T FormatFmg<T>(this T self,
        BarcodeFormat format)
        where T : BarcodeGeneratorView
    {
        self.SetValue(BarcodeGeneratorView.FormatProperty, format);
        return self;
    }

    public static T FormatFmg<T>(this T self, Func<PropertyContext<BarcodeFormat>, IPropertyBuilder<BarcodeFormat>> configure)
        where T : BarcodeGeneratorView
    {
        var context = new PropertyContext<BarcodeFormat>(self, BarcodeGeneratorView.FormatProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> FormatFmg<T>(this SettersContext<T> self,
        BarcodeFormat format)
        where T : BarcodeGeneratorView
    {
        self.XamlSetters.Add(new Setter { Property = BarcodeGeneratorView.FormatProperty, Value = format });
        return self;
    }

    public static SettersContext<T> FormatFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<BarcodeFormat>, IPropertySettersBuilder<BarcodeFormat>> configure)
        where T : BarcodeGeneratorView
    {
        var context = new PropertySettersContext<BarcodeFormat>(self.XamlSetters, BarcodeGeneratorView.FormatProperty);
        configure(context).Build();
        return self;
    }

    public static T ValueFmg<T>(this T self,
        string value)
        where T : BarcodeGeneratorView
    {
        self.SetValue(BarcodeGeneratorView.ValueProperty, value);
        return self;
    }

    public static T ValueFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : BarcodeGeneratorView
    {
        var context = new PropertyContext<string>(self, BarcodeGeneratorView.ValueProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ValueFmg<T>(this SettersContext<T> self,
        string value)
        where T : BarcodeGeneratorView
    {
        self.XamlSetters.Add(new Setter { Property = BarcodeGeneratorView.ValueProperty, Value = value });
        return self;
    }

    public static SettersContext<T> ValueFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : BarcodeGeneratorView
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, BarcodeGeneratorView.ValueProperty);
        configure(context).Build();
        return self;
    }

    public static T ForegroundColorFmg<T>(this T self,
        Color color)
        where T : BarcodeGeneratorView
    {
        self.SetValue(BarcodeGeneratorView.ForegroundColorProperty, color);
        return self;
    }

    public static T ForegroundColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : BarcodeGeneratorView
    {
        var context = new PropertyContext<Color>(self, BarcodeGeneratorView.ForegroundColorProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ForegroundColorFmg<T>(this SettersContext<T> self,
        Color color)
        where T : BarcodeGeneratorView
    {
        self.XamlSetters.Add(new Setter { Property = BarcodeGeneratorView.ForegroundColorProperty, Value = color });
        return self;
    }

    public static SettersContext<T> ForegroundColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : BarcodeGeneratorView
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, BarcodeGeneratorView.ForegroundColorProperty);
        configure(context).Build();
        return self;
    }

    public static T BackgroundColorFmg<T>(this T self,
        Color backgroundColor)
        where T : BarcodeGeneratorView
    {
        self.SetValue(BarcodeGeneratorView.BackgroundColorProperty, backgroundColor);
        return self;
    }

    public static T BackgroundColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : BarcodeGeneratorView
    {
        var context = new PropertyContext<Color>(self, BarcodeGeneratorView.BackgroundColorProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> BackgroundColorFmg<T>(this SettersContext<T> self,
        Color backgroundColor)
        where T : BarcodeGeneratorView
    {
        self.XamlSetters.Add(new Setter { Property = BarcodeGeneratorView.BackgroundColorProperty, Value = backgroundColor });
        return self;
    }

    public static SettersContext<T> BackgroundColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : BarcodeGeneratorView
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, BarcodeGeneratorView.BackgroundColorProperty);
        configure(context).Build();
        return self;
    }

    public static T BarcodeMarginFmg<T>(this T self,
        int barcodeMargin)
        where T : BarcodeGeneratorView
    {
        self.SetValue(BarcodeGeneratorView.BarcodeMarginProperty, barcodeMargin);
        return self;
    }

    public static T BarcodeMarginFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
        where T : BarcodeGeneratorView
    {
        var context = new PropertyContext<int>(self, BarcodeGeneratorView.BarcodeMarginProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> BarcodeMarginFmg<T>(this SettersContext<T> self,
        int barcodeMargin)
        where T : BarcodeGeneratorView
    {
        self.XamlSetters.Add(new Setter { Property = BarcodeGeneratorView.BarcodeMarginProperty, Value = barcodeMargin });
        return self;
    }

    public static SettersContext<T> BarcodeMarginFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure)
        where T : BarcodeGeneratorView
    {
        var context = new PropertySettersContext<int>(self.XamlSetters, BarcodeGeneratorView.BarcodeMarginProperty);
        configure(context).Build();
        return self;
    }
}
