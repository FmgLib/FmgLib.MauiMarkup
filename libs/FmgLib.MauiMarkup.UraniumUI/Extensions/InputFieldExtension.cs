using UraniumUI.Material.Controls;

namespace FmgLib.MauiMarkup.UraniumUI;

public static partial class InputFieldExtension
{
    public static T TitleFmg<T>(this T self,
        string title)
        where T : InputField
    {
        self.SetValue(InputField.TitleProperty, title);
        return self;
    }

    public static T TitleFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : InputField
    {
        var context = new PropertyContext<string>(self, InputField.TitleProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> TitleFmg<T>(this SettersContext<T> self,
        string title)
        where T : InputField
    {
        self.XamlSetters.Add(new Setter { Property = InputField.TitleProperty, Value = title });
        return self;
    }

    public static SettersContext<T> TitleFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : InputField
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, InputField.TitleProperty);
        configure(context).Build();
        return self;
    }

    public static T TitleColorFmg<T>(this T self,
        Color titleColor)
        where T : InputField
    {
        self.SetValue(InputField.TitleColorProperty, titleColor);
        return self;
    }

    public static T TitleColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : InputField
    {
        var context = new PropertyContext<Color>(self, InputField.TitleColorProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> TitleColorFmg<T>(this SettersContext<T> self,
        Color titleColor)
        where T : InputField
    {
        self.XamlSetters.Add(new Setter { Property = InputField.TitleColorProperty, Value = titleColor });
        return self;
    }

    public static SettersContext<T> TitleColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : InputField
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, InputField.TitleColorProperty);
        configure(context).Build();
        return self;
    }

    public static T AccentColorFmg<T>(this T self,
        Color accentColor)
        where T : InputField
    {
        self.SetValue(InputField.AccentColorProperty, accentColor);
        return self;
    }

    public static T AccentColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : InputField
    {
        var context = new PropertyContext<Color>(self, InputField.AccentColorProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> AccentColorFmg<T>(this SettersContext<T> self,
        Color accentColor)
        where T : InputField
    {
        self.XamlSetters.Add(new Setter { Property = InputField.AccentColorProperty, Value = accentColor });
        return self;
    }

    public static SettersContext<T> AccentColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : InputField
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, InputField.AccentColorProperty);
        configure(context).Build();
        return self;
    }

    public static T BorderColorFmg<T>(this T self, Color borderColor)
        where T : InputField
    {
        self.SetValue(InputField.BorderColorProperty, borderColor);
        return self;
    }

    public static T BorderColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : InputField
    {
        var context = new PropertyContext<Color>(self, InputField.BorderColorProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> BorderColorFmg<T>(this SettersContext<T> self,
        Color borderColor)
        where T : InputField
    {
        self.XamlSetters.Add(new Setter { Property = InputField.BorderColorProperty, Value = borderColor });
        return self;
    }

    public static SettersContext<T> BorderColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : InputField
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, InputField.BorderColorProperty);
        configure(context).Build();
        return self;
    }

    public static T BorderThicknessFmg<T>(this T self,
        double borderThickness)
        where T : InputField
    {
        self.SetValue(InputField.BorderThicknessProperty, borderThickness);
        return self;
    }

    public static T BorderThicknessFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : InputField
    {
        var context = new PropertyContext<double>(self, InputField.BorderThicknessProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> BorderThicknessFmg<T>(this SettersContext<T> self,
        double borderThickness)
        where T : InputField
    {
        self.XamlSetters.Add(new Setter { Property = InputField.BorderThicknessProperty, Value = borderThickness });
        return self;
    }

    public static SettersContext<T> BorderThicknessFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : InputField
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, InputField.BorderThicknessProperty);
        configure(context).Build();
        return self;
    }

    public static T InputBackgroundColorFmg<T>(this T self,
        Color inputBackgroundColor)
        where T : InputField
    {
        self.SetValue(InputField.InputBackgroundColorProperty, inputBackgroundColor);
        return self;
    }

    public static T InputBackgroundColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : InputField
    {
        var context = new PropertyContext<Color>(self, InputField.InputBackgroundColorProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> InputBackgroundColorFmg<T>(this SettersContext<T> self,
        Color inputBackgroundColor)
        where T : InputField
    {
        self.XamlSetters.Add(new Setter { Property = InputField.InputBackgroundColorProperty, Value = inputBackgroundColor });
        return self;
    }

    public static SettersContext<T> InputBackgroundColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : InputField
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, InputField.InputBackgroundColorProperty);
        configure(context).Build();
        return self;
    }

    public static T InputBackgroundFmg<T>(this T self,
        Brush inputBackground)
        where T : InputField
    {
        self.SetValue(InputField.InputBackgroundProperty, inputBackground);
        return self;
    }

    public static T InputBackgroundFmg<T>(this T self, Func<PropertyContext<Brush>, IPropertyBuilder<Brush>> configure)
        where T : InputField
    {
        var context = new PropertyContext<Brush>(self, InputField.InputBackgroundProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> InputBackgroundFmg<T>(this SettersContext<T> self,
        Brush inputBackground)
        where T : InputField
    {
        self.XamlSetters.Add(new Setter { Property = InputField.InputBackgroundProperty, Value = inputBackground });
        return self;
    }

    public static SettersContext<T> InputBackgroundFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Brush>, IPropertySettersBuilder<Brush>> configure)
        where T : InputField
    {
        var context = new PropertySettersContext<Brush>(self.XamlSetters, InputField.InputBackgroundProperty);
        configure(context).Build();
        return self;
    }

    public static T IconFmg<T>(this T self,
        ImageSource iconImageSource)
        where T : InputField
    {
        self.SetValue(InputField.IconProperty, iconImageSource);
        return self;
    }

    public static T IconFmg<T>(this T self, Func<PropertyContext<ImageSource>, IPropertyBuilder<ImageSource>> configure)
        where T : InputField
    {
        var context = new PropertyContext<ImageSource>(self, InputField.IconProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IconFmg<T>(this SettersContext<T> self,
        ImageSource iconImageSource)
        where T : InputField
    {
        self.XamlSetters.Add(new Setter { Property = InputField.IconProperty, Value = iconImageSource });
        return self;
    }

    public static SettersContext<T> IconFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ImageSource>, IPropertySettersBuilder<ImageSource>> configure)
        where T : InputField
    {
        var context = new PropertySettersContext<ImageSource>(self.XamlSetters, InputField.IconProperty);
        configure(context).Build();
        return self;
    }

    public static T CornerRadiusFmg<T>(this T self,
        int cornerRadius)
        where T : InputField
    {
        self.SetValue(InputField.CornerRadiusProperty, cornerRadius);
        return self;
    }

    public static T CornerRadiusFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
        where T : InputField
    {
        var context = new PropertyContext<int>(self, InputField.CornerRadiusProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> CornerRadiusFmg<T>(this SettersContext<T> self,
        int cornerRadius)
        where T : InputField
    {
        self.XamlSetters.Add(new Setter { Property = InputField.CornerRadiusProperty, Value = cornerRadius });
        return self;
    }

    public static SettersContext<T> CornerRadiusFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure)
        where T : InputField
    {
        var context = new PropertySettersContext<int>(self.XamlSetters, InputField.CornerRadiusProperty);
        configure(context).Build();
        return self;
    }

    public static T TitleFontSizeFmg<T>(this T self,
        double fontSize)
        where T : InputField
    {
        self.SetValue(InputField.TitleFontSizeProperty, fontSize);
        return self;
    }

    public static T TitleFontSizeFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : InputField
    {
        var context = new PropertyContext<double>(self, InputField.TitleFontSizeProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> TitleFontSizeFmg<T>(this SettersContext<T> self,
        double fontSize)
        where T : InputField
    {
        self.XamlSetters.Add(new Setter { Property = InputField.TitleFontSizeProperty, Value = fontSize });
        return self;
    }

    public static SettersContext<T> TitleFontSizeFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : InputField
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, InputField.TitleFontSizeProperty);
        configure(context).Build();
        return self;
    }
}
