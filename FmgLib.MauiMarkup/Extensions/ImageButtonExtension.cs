using System.Windows.Input;

namespace FmgLib.MauiMarkup;

public static class ImageButtonExtension
{
    public static T BorderColorFmg<T>(this T self, Color borderColor) where T : ImageButton
    {
        self.SetValue(ImageButton.BorderColorProperty, borderColor);
        return self;
    }

    public static T BorderColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure) where T : ImageButton
    {
        PropertyContext<Color> arg = new PropertyContext<Color>(self, ImageButton.BorderColorProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> BorderColorFmg<T>(this SettersContext<T> self, Color borderColor) where T : ImageButton
    {
        self.XamlSetters.Add(new Setter
        {
            Property = ImageButton.BorderColorProperty,
            Value = borderColor
        });
        return self;
    }

    public static SettersContext<T> BorderColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure) where T : ImageButton
    {
        PropertySettersContext<Color> arg = new PropertySettersContext<Color>(self.XamlSetters, ImageButton.BorderColorProperty);
        configure(arg).Build();
        return self;
    }

    public static Task<bool> AnimateBorderColorToFmg<T>(this T self, Color value, uint length = 250u, Easing? easing = null) where T : ImageButton
    {
        Color value2 = value;
        T self2 = self;
        Color fromValue = self2.BorderColor;
        return Transformations.AnimateAsync(transform: (double t) => Transformations.ColorTransform(fromValue, value2, t), callback: delegate (Color actValue)
        {
            self2.BorderColor = actValue;
        }, element: self2, name: "AnimateBorderColorTo", length: length, easing: easing);
    }

    public static T CornerRadiusFmg<T>(this T self, int cornerRadius) where T : ImageButton
    {
        self.SetValue(ImageButton.CornerRadiusProperty, cornerRadius);
        return self;
    }

    public static T CornerRadiusFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure) where T : ImageButton
    {
        PropertyContext<int> arg = new PropertyContext<int>(self, ImageButton.CornerRadiusProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> CornerRadiusFmg<T>(this SettersContext<T> self, int cornerRadius) where T : ImageButton
    {
        self.XamlSetters.Add(new Setter
        {
            Property = ImageButton.CornerRadiusProperty,
            Value = cornerRadius
        });
        return self;
    }

    public static SettersContext<T> CornerRadiusFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure) where T : ImageButton
    {
        PropertySettersContext<int> arg = new PropertySettersContext<int>(self.XamlSetters, ImageButton.CornerRadiusProperty);
        configure(arg).Build();
        return self;
    }

    public static T BorderWidthFmg<T>(this T self, double borderWidth) where T : ImageButton
    {
        self.SetValue(ImageButton.BorderWidthProperty, borderWidth);
        return self;
    }

    public static T BorderWidthFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure) where T : ImageButton
    {
        PropertyContext<double> arg = new PropertyContext<double>(self, ImageButton.BorderWidthProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> BorderWidthFmg<T>(this SettersContext<T> self, double borderWidth) where T : ImageButton
    {
        self.XamlSetters.Add(new Setter
        {
            Property = ImageButton.BorderWidthProperty,
            Value = borderWidth
        });
        return self;
    }

    public static SettersContext<T> BorderWidthFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure) where T : ImageButton
    {
        PropertySettersContext<double> arg = new PropertySettersContext<double>(self.XamlSetters, ImageButton.BorderWidthProperty);
        configure(arg).Build();
        return self;
    }

    public static Task<bool> AnimateBorderWidthToFmg<T>(this T self, double value, uint length = 250u, Easing? easing = null) where T : ImageButton
    {
        T self2 = self;
        double fromValue = self2.BorderWidth;
        return Transformations.AnimateAsync(transform: (double t) => Transformations.DoubleTransform(fromValue, value, t), callback: delegate (double actValue)
        {
            self2.BorderWidth = actValue;
        }, element: self2, name: "AnimateBorderWidthTo", length: length, easing: easing);
    }

    public static T AspectFmg<T>(this T self, Aspect aspect) where T : ImageButton
    {
        self.SetValue(ImageButton.AspectProperty, aspect);
        return self;
    }

    public static T AspectFmg<T>(this T self, Func<PropertyContext<Aspect>, IPropertyBuilder<Aspect>> configure) where T : ImageButton
    {
        PropertyContext<Aspect> arg = new PropertyContext<Aspect>(self, ImageButton.AspectProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> AspectFmg<T>(this SettersContext<T> self, Aspect aspect) where T : ImageButton
    {
        self.XamlSetters.Add(new Setter
        {
            Property = ImageButton.AspectProperty,
            Value = aspect
        });
        return self;
    }

    public static SettersContext<T> AspectFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Aspect>, IPropertySettersBuilder<Aspect>> configure) where T : ImageButton
    {
        PropertySettersContext<Aspect> arg = new PropertySettersContext<Aspect>(self.XamlSetters, ImageButton.AspectProperty);
        configure(arg).Build();
        return self;
    }

    public static T IsOpaqueFmg<T>(this T self, bool isOpaque) where T : ImageButton
    {
        self.SetValue(ImageButton.IsOpaqueProperty, isOpaque);
        return self;
    }

    public static T IsOpaqueFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure) where T : ImageButton
    {
        PropertyContext<bool> arg = new PropertyContext<bool>(self, ImageButton.IsOpaqueProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> IsOpaqueFmg<T>(this SettersContext<T> self, bool isOpaque) where T : ImageButton
    {
        self.XamlSetters.Add(new Setter
        {
            Property = ImageButton.IsOpaqueProperty,
            Value = isOpaque
        });
        return self;
    }

    public static SettersContext<T> IsOpaqueFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure) where T : ImageButton
    {
        PropertySettersContext<bool> arg = new PropertySettersContext<bool>(self.XamlSetters, ImageButton.IsOpaqueProperty);
        configure(arg).Build();
        return self;
    }

    public static T CommandFmg<T>(this T self, ICommand command) where T : ImageButton
    {
        self.SetValue(ImageButton.CommandProperty, command);
        return self;
    }

    public static T CommandFmg<T>(this T self, Func<PropertyContext<ICommand>, IPropertyBuilder<ICommand>> configure) where T : ImageButton
    {
        PropertyContext<ICommand> arg = new PropertyContext<ICommand>(self, ImageButton.CommandProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> CommandFmg<T>(this SettersContext<T> self, ICommand command) where T : ImageButton
    {
        self.XamlSetters.Add(new Setter
        {
            Property = ImageButton.CommandProperty,
            Value = command
        });
        return self;
    }

    public static SettersContext<T> CommandFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ICommand>, IPropertySettersBuilder<ICommand>> configure) where T : ImageButton
    {
        PropertySettersContext<ICommand> arg = new PropertySettersContext<ICommand>(self.XamlSetters, ImageButton.CommandProperty);
        configure(arg).Build();
        return self;
    }

    public static T CommandParameterFmg<T>(this T self, object commandParameter) where T : ImageButton
    {
        self.SetValue(ImageButton.CommandParameterProperty, commandParameter);
        return self;
    }

    public static T CommandParameterFmg<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure) where T : ImageButton
    {
        PropertyContext<object> arg = new PropertyContext<object>(self, ImageButton.CommandParameterProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> CommandParameterFmg<T>(this SettersContext<T> self, object commandParameter) where T : ImageButton
    {
        self.XamlSetters.Add(new Setter
        {
            Property = ImageButton.CommandParameterProperty,
            Value = commandParameter
        });
        return self;
    }

    public static SettersContext<T> CommandParameterFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure) where T : ImageButton
    {
        PropertySettersContext<object> arg = new PropertySettersContext<object>(self.XamlSetters, ImageButton.CommandParameterProperty);
        configure(arg).Build();
        return self;
    }

    public static T SourceFmg<T>(this T self, ImageSource source) where T : ImageButton
    {
        self.SetValue(ImageButton.SourceProperty, source);
        return self;
    }

    public static T SourceFmg<T>(this T self, Func<PropertyContext<ImageSource>, IPropertyBuilder<ImageSource>> configure) where T : ImageButton
    {
        PropertyContext<ImageSource> arg = new PropertyContext<ImageSource>(self, ImageButton.SourceProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> SourceFmg<T>(this SettersContext<T> self, ImageSource source) where T : ImageButton
    {
        self.XamlSetters.Add(new Setter
        {
            Property = ImageButton.SourceProperty,
            Value = source
        });
        return self;
    }

    public static SettersContext<T> SourceFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ImageSource>, IPropertySettersBuilder<ImageSource>> configure) where T : ImageButton
    {
        PropertySettersContext<ImageSource> arg = new PropertySettersContext<ImageSource>(self.XamlSetters, ImageButton.SourceProperty);
        configure(arg).Build();
        return self;
    }

    public static T PaddingFmg<T>(this T self, Thickness padding) where T : ImageButton
    {
        self.SetValue(ImageButton.PaddingProperty, padding);
        return self;
    }

    public static T PaddingFmg<T>(this T self, Func<PropertyContext<Thickness>, IPropertyBuilder<Thickness>> configure) where T : ImageButton
    {
        PropertyContext<Thickness> arg = new PropertyContext<Thickness>(self, ImageButton.PaddingProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> PaddingFmg<T>(this SettersContext<T> self, Thickness padding) where T : ImageButton
    {
        self.XamlSetters.Add(new Setter
        {
            Property = ImageButton.PaddingProperty,
            Value = padding
        });
        return self;
    }

    public static SettersContext<T> PaddingFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Thickness>, IPropertySettersBuilder<Thickness>> configure) where T : ImageButton
    {
        PropertySettersContext<Thickness> arg = new PropertySettersContext<Thickness>(self.XamlSetters, ImageButton.PaddingProperty);
        configure(arg).Build();
        return self;
    }

    public static T OnClickedFmg<T>(this T self, EventHandler handler) where T : ImageButton
    {
        self.Clicked += handler;
        return self;
    }

    public static T OnClickedFmg<T>(this T self, Action<T> action) where T : ImageButton
    {
        Action<T> action2 = action;
        T self2 = self;
        self2.Clicked += delegate
        {
            action2(self2);
        };
        return self2;
    }

    public static T OnPressedFmg<T>(this T self, EventHandler handler) where T : ImageButton
    {
        self.Pressed += handler;
        return self;
    }

    public static T OnPressedFmg<T>(this T self, Action<T> action) where T : ImageButton
    {
        Action<T> action2 = action;
        T self2 = self;
        self2.Pressed += delegate
        {
            action2(self2);
        };
        return self2;
    }

    public static T OnReleasedFmg<T>(this T self, EventHandler handler) where T : ImageButton
    {
        self.Released += handler;
        return self;
    }

    public static T OnReleasedFmg<T>(this T self, Action<T> action) where T : ImageButton
    {
        Action<T> action2 = action;
        T self2 = self;
        self2.Released += delegate
        {
            action2(self2);
        };
        return self2;
    }
}
