using CommunityToolkit.Maui.Views;

namespace FmgLib.MauiMarkup.Views;

public static partial class AvatarViewExtension
{
    public static T BorderColorFmg<T>(this T self, Color color) where T : AvatarView
    {
        self.SetValue(AvatarView.BorderColorProperty, color);
        return self;
    }

    public static T BorderColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure) where T : AvatarView
    {
        PropertyContext<Color> arg = new PropertyContext<Color>(self, AvatarView.BorderColorProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> BorderColorFmg<T>(this SettersContext<T> self, Color color) where T : AvatarView
    {
        self.XamlSetters.Add(new Setter
        {
            Property = AvatarView.BorderColorProperty,
            Value = color
        });
        return self;
    }

    public static SettersContext<T> BorderColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure) where T : AvatarView
    {
        PropertySettersContext<Color> arg = new PropertySettersContext<Color>(self.XamlSetters, AvatarView.BorderColorProperty);
        configure(arg).Build();
        return self;
    }

    public static T BorderWidthFmg<T>(this T self, double width) where T : AvatarView
    {
        self.SetValue(AvatarView.BorderWidthProperty, width);
        return self;
    }

    public static T BorderWidthFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure) where T : AvatarView
    {
        PropertyContext<double> arg = new PropertyContext<double>(self, AvatarView.BorderWidthProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> BorderWidthFmg<T>(this SettersContext<T> self, double width) where T : AvatarView
    {
        self.XamlSetters.Add(new Setter
        {
            Property = AvatarView.BorderWidthProperty,
            Value = width
        });
        return self;
    }

    public static SettersContext<T> BorderWidthFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure) where T : AvatarView
    {
        PropertySettersContext<double> arg = new PropertySettersContext<double>(self.XamlSetters, AvatarView.BorderWidthProperty);
        configure(arg).Build();
        return self;
    }

    public static T CornerRadiusFmg<T>(this T self, int cornerRadius) where T : AvatarView
    {
        self.SetValue(AvatarView.CornerRadiusProperty, cornerRadius);
        return self;
    }

    public static T CornerRadiusFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure) where T : AvatarView
    {
        var context = new PropertyContext<int>(self, AvatarView.CornerRadiusProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> CornerRadiusFmg<T>(this SettersContext<T> self, int cornerRadius) where T : AvatarView
    {
        self.XamlSetters.Add(new Setter { Property = AvatarView.CornerRadiusProperty, Value = cornerRadius });
        return self;
    }

    public static SettersContext<T> CornerRadiusFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure) where T : AvatarView
    {
        var context = new PropertySettersContext<int>(self.XamlSetters, AvatarView.CornerRadiusProperty);
        configure(context).Build();
        return self;
    }

    public static T FontAttributesFmg<T>(this T self,
        FontAttributes fontAttributes)
        where T : AvatarView
    {
        self.SetValue(AvatarView.FontAttributesProperty, fontAttributes);
        return self;
    }

    public static T FontAttributesFmg<T>(this T self, Func<PropertyContext<FontAttributes>, IPropertyBuilder<FontAttributes>> configure)
        where T : AvatarView
    {
        var context = new PropertyContext<FontAttributes>(self, AvatarView.FontAttributesProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> FontAttributesFmg<T>(this SettersContext<T> self,
        FontAttributes fontAttributes)
        where T : AvatarView
    {
        self.XamlSetters.Add(new Setter { Property = AvatarView.FontAttributesProperty, Value = fontAttributes });
        return self;
    }

    public static SettersContext<T> FontAttributesFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<FontAttributes>, IPropertySettersBuilder<FontAttributes>> configure)
        where T : AvatarView
    {
        var context = new PropertySettersContext<FontAttributes>(self.XamlSetters, AvatarView.FontAttributesProperty);
        configure(context).Build();
        return self;
    }

    public static T FontAutoScalingEnabledFmg<T>(this T self,
        bool fontAutoScalingEnabled)
        where T : AvatarView
    {
        self.SetValue(AvatarView.FontAutoScalingEnabledProperty, fontAutoScalingEnabled);
        return self;
    }

    public static T FontAutoScalingEnabledFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : AvatarView
    {
        var context = new PropertyContext<bool>(self, AvatarView.FontAutoScalingEnabledProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> FontAutoScalingEnabledFmg<T>(this SettersContext<T> self,
        bool fontAutoScalingEnabled)
        where T : AvatarView
    {
        self.XamlSetters.Add(new Setter { Property = AvatarView.FontAutoScalingEnabledProperty, Value = fontAutoScalingEnabled });
        return self;
    }

    public static SettersContext<T> FontAutoScalingEnabledFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : AvatarView
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, AvatarView.FontAutoScalingEnabledProperty);
        configure(context).Build();
        return self;
    }

    public static T FontFamilyFmg<T>(this T self,
        string fontFamily)
        where T : AvatarView
    {
        self.SetValue(AvatarView.FontFamilyProperty, fontFamily);
        return self;
    }

    public static T FontFamilyFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : AvatarView
    {
        var context = new PropertyContext<string>(self, AvatarView.FontFamilyProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> FontFamilyFmg<T>(this SettersContext<T> self,
        string fontFamily)
        where T : AvatarView
    {
        self.XamlSetters.Add(new Setter { Property = AvatarView.FontFamilyProperty, Value = fontFamily });
        return self;
    }

    public static SettersContext<T> FontFamilyFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : AvatarView
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, AvatarView.FontFamilyProperty);
        configure(context).Build();
        return self;
    }

    public static T FontSizeFmg<T>(this T self,
        double fontSize)
        where T : AvatarView
    {
        self.SetValue(AvatarView.FontSizeProperty, fontSize);
        return self;
    }

    public static T FontSizeFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : AvatarView
    {
        var context = new PropertyContext<double>(self, AvatarView.FontSizeProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> FontSizeFmg<T>(this SettersContext<T> self,
        double fontSize)
        where T : AvatarView
    {
        self.XamlSetters.Add(new Setter { Property = AvatarView.FontSizeProperty, Value = fontSize });
        return self;
    }

    public static SettersContext<T> FontSizeFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : AvatarView
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, AvatarView.FontSizeProperty);
        configure(context).Build();
        return self;
    }

    public static T ImageSourceFmg<T>(this T self,
        ImageSource imageSource)
        where T : AvatarView
    {
        self.SetValue(AvatarView.ImageSourceProperty, imageSource);
        return self;
    }

    public static T ImageSourceFmg<T>(this T self, Func<PropertyContext<ImageSource>, IPropertyBuilder<ImageSource>> configure)
        where T : AvatarView
    {
        var context = new PropertyContext<ImageSource>(self, AvatarView.ImageSourceProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ImageSourceFmg<T>(this SettersContext<T> self,
        ImageSource imageSource)
        where T : AvatarView
    {
        self.XamlSetters.Add(new Setter { Property = AvatarView.ImageSourceProperty, Value = imageSource });
        return self;
    }

    public static SettersContext<T> ImageSourceFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ImageSource>, IPropertySettersBuilder<ImageSource>> configure)
        where T : AvatarView
    {
        var context = new PropertySettersContext<ImageSource>(self.XamlSetters, AvatarView.ImageSourceProperty);
        configure(context).Build();
        return self;
    }

    public static T TextFmg<T>(this T self, string text)
        where T : AvatarView
    {
        self.SetValue(AvatarView.TextProperty, text);
        return self;
    }

    public static T TextFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : AvatarView
    {
        var context = new PropertyContext<string>(self, AvatarView.TextProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> TextFmg<T>(this SettersContext<T> self,
        string text)
        where T : AvatarView
    {
        self.XamlSetters.Add(new Setter { Property = AvatarView.TextProperty, Value = text });
        return self;
    }

    public static SettersContext<T> TextFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : AvatarView
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, AvatarView.TextProperty);
        configure(context).Build();
        return self;
    }

    public static T TextColorFmg<T>(this T self,
        Color textColor)
        where T : AvatarView
    {
        self.SetValue(AvatarView.TextColorProperty, textColor);
        return self;
    }

    public static T TextColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : AvatarView
    {
        var context = new PropertyContext<Color>(self, AvatarView.TextColorProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> TextColorFmg<T>(this SettersContext<T> self,
        Color textColor)
        where T : AvatarView
    {
        self.XamlSetters.Add(new Setter { Property = AvatarView.TextColorProperty, Value = textColor });
        return self;
    }

    public static SettersContext<T> TextColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : AvatarView
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, AvatarView.TextColorProperty);
        configure(context).Build();
        return self;
    }

    public static T TextTransformFmg<T>(this T self,
        TextTransform textTransform)
        where T : AvatarView
    {
        self.SetValue(AvatarView.TextTransformProperty, textTransform);
        return self;
    }

    public static T TextTransformFmg<T>(this T self, Func<PropertyContext<TextTransform>, IPropertyBuilder<TextTransform>> configure)
        where T : AvatarView
    {
        var context = new PropertyContext<TextTransform>(self, AvatarView.TextTransformProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> TextTransformFmg<T>(this SettersContext<T> self,
        TextTransform textTransform)
        where T : AvatarView
    {
        self.XamlSetters.Add(new Setter { Property = AvatarView.TextTransformProperty, Value = textTransform });
        return self;
    }

    public static SettersContext<T> TextTransformFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<TextTransform>, IPropertySettersBuilder<TextTransform>> configure)
        where T : AvatarView
    {
        var context = new PropertySettersContext<TextTransform>(self.XamlSetters, AvatarView.TextTransformProperty);
        configure(context).Build();
        return self;
    }
}
