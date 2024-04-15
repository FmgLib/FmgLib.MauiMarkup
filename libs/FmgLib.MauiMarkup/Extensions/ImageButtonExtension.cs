namespace FmgLib.MauiMarkup;



public static partial class ImageButtonExtension
{
    public static T BorderColor<T>(this T self,
        Color borderColor)
        where T : ImageButton
    {
        self.SetValue(ImageButton.BorderColorProperty, borderColor);
        return self;
    }
    
    public static T BorderColor<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : ImageButton
    {
        var context = new PropertyContext<Color>(self, ImageButton.BorderColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> BorderColor<T>(this SettersContext<T> self,
        Color borderColor)
        where T : ImageButton
    {
        self.XamlSetters.Add(new Setter { Property = ImageButton.BorderColorProperty, Value = borderColor });
        return self;
    }
    
    public static SettersContext<T> BorderColor<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : ImageButton
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, ImageButton.BorderColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateBorderColorTo<T>(this T self, Color value, uint length = 250, Easing? easing = null)
        where T : ImageButton
    {
        Color fromValue = self.BorderColor;
        var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
        var callback = (Color actValue) => { self.BorderColor = actValue; };
        return Transformations.AnimateAsync<Color>(self, "AnimateBorderColorTo", transform, callback, length, easing);
    }
    
    public static T CornerRadius<T>(this T self,
        int cornerRadius)
        where T : ImageButton
    {
        self.SetValue(ImageButton.CornerRadiusProperty, cornerRadius);
        return self;
    }
    
    public static T CornerRadius<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
        where T : ImageButton
    {
        var context = new PropertyContext<int>(self, ImageButton.CornerRadiusProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> CornerRadius<T>(this SettersContext<T> self,
        int cornerRadius)
        where T : ImageButton
    {
        self.XamlSetters.Add(new Setter { Property = ImageButton.CornerRadiusProperty, Value = cornerRadius });
        return self;
    }
    
    public static SettersContext<T> CornerRadius<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure)
        where T : ImageButton
    {
        var context = new PropertySettersContext<int>(self.XamlSetters, ImageButton.CornerRadiusProperty);
        configure(context).Build();
        return self;
    }
    
    public static T BorderWidth<T>(this T self,
        double borderWidth)
        where T : ImageButton
    {
        self.SetValue(ImageButton.BorderWidthProperty, borderWidth);
        return self;
    }
    
    public static T BorderWidth<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : ImageButton
    {
        var context = new PropertyContext<double>(self, ImageButton.BorderWidthProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> BorderWidth<T>(this SettersContext<T> self,
        double borderWidth)
        where T : ImageButton
    {
        self.XamlSetters.Add(new Setter { Property = ImageButton.BorderWidthProperty, Value = borderWidth });
        return self;
    }
    
    public static SettersContext<T> BorderWidth<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : ImageButton
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, ImageButton.BorderWidthProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateBorderWidthTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : ImageButton
    {
        double fromValue = self.BorderWidth;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.BorderWidth = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateBorderWidthTo", transform, callback, length, easing);
    }
    
    public static T Aspect<T>(this T self,
        Aspect aspect)
        where T : ImageButton
    {
        self.SetValue(ImageButton.AspectProperty, aspect);
        return self;
    }
    
    public static T Aspect<T>(this T self, Func<PropertyContext<Aspect>, IPropertyBuilder<Aspect>> configure)
        where T : ImageButton
    {
        var context = new PropertyContext<Aspect>(self, ImageButton.AspectProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Aspect<T>(this SettersContext<T> self,
        Aspect aspect)
        where T : ImageButton
    {
        self.XamlSetters.Add(new Setter { Property = ImageButton.AspectProperty, Value = aspect });
        return self;
    }
    
    public static SettersContext<T> Aspect<T>(this SettersContext<T> self, Func<PropertySettersContext<Aspect>, IPropertySettersBuilder<Aspect>> configure)
        where T : ImageButton
    {
        var context = new PropertySettersContext<Aspect>(self.XamlSetters, ImageButton.AspectProperty);
        configure(context).Build();
        return self;
    }
    
    public static T IsOpaque<T>(this T self,
        bool isOpaque)
        where T : ImageButton
    {
        self.SetValue(ImageButton.IsOpaqueProperty, isOpaque);
        return self;
    }
    
    public static T IsOpaque<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : ImageButton
    {
        var context = new PropertyContext<bool>(self, ImageButton.IsOpaqueProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> IsOpaque<T>(this SettersContext<T> self,
        bool isOpaque)
        where T : ImageButton
    {
        self.XamlSetters.Add(new Setter { Property = ImageButton.IsOpaqueProperty, Value = isOpaque });
        return self;
    }
    
    public static SettersContext<T> IsOpaque<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : ImageButton
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, ImageButton.IsOpaqueProperty);
        configure(context).Build();
        return self;
    }
    
    public static T Command<T>(this T self,
        System.Windows.Input.ICommand command)
        where T : ImageButton
    {
        self.SetValue(ImageButton.CommandProperty, command);
        return self;
    }
    
    public static T Command<T>(this T self, Func<PropertyContext<System.Windows.Input.ICommand>, IPropertyBuilder<System.Windows.Input.ICommand>> configure)
        where T : ImageButton
    {
        var context = new PropertyContext<System.Windows.Input.ICommand>(self, ImageButton.CommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Command<T>(this SettersContext<T> self,
        System.Windows.Input.ICommand command)
        where T : ImageButton
    {
        self.XamlSetters.Add(new Setter { Property = ImageButton.CommandProperty, Value = command });
        return self;
    }
    
    public static SettersContext<T> Command<T>(this SettersContext<T> self, Func<PropertySettersContext<System.Windows.Input.ICommand>, IPropertySettersBuilder<System.Windows.Input.ICommand>> configure)
        where T : ImageButton
    {
        var context = new PropertySettersContext<System.Windows.Input.ICommand>(self.XamlSetters, ImageButton.CommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static T CommandParameter<T>(this T self,
        object commandParameter)
        where T : ImageButton
    {
        self.SetValue(ImageButton.CommandParameterProperty, commandParameter);
        return self;
    }
    
    public static T CommandParameter<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        where T : ImageButton
    {
        var context = new PropertyContext<object>(self, ImageButton.CommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> CommandParameter<T>(this SettersContext<T> self,
        object commandParameter)
        where T : ImageButton
    {
        self.XamlSetters.Add(new Setter { Property = ImageButton.CommandParameterProperty, Value = commandParameter });
        return self;
    }
    
    public static SettersContext<T> CommandParameter<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        where T : ImageButton
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, ImageButton.CommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static T Source<T>(this T self,
        ImageSource source)
        where T : ImageButton
    {
        self.SetValue(ImageButton.SourceProperty, source);
        return self;
    }
    
    public static T Source<T>(this T self, Func<PropertyContext<ImageSource>, IPropertyBuilder<ImageSource>> configure)
        where T : ImageButton
    {
        var context = new PropertyContext<ImageSource>(self, ImageButton.SourceProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Source<T>(this SettersContext<T> self,
        ImageSource source)
        where T : ImageButton
    {
        self.XamlSetters.Add(new Setter { Property = ImageButton.SourceProperty, Value = source });
        return self;
    }
    
    public static SettersContext<T> Source<T>(this SettersContext<T> self, Func<PropertySettersContext<ImageSource>, IPropertySettersBuilder<ImageSource>> configure)
        where T : ImageButton
    {
        var context = new PropertySettersContext<ImageSource>(self.XamlSetters, ImageButton.SourceProperty);
        configure(context).Build();
        return self;
    }
    
    public static T Padding<T>(this T self,
        Thickness padding)
        where T : ImageButton
    {
        self.SetValue(ImageButton.PaddingProperty, padding);
        return self;
    }
    
    public static T Padding<T>(this T self, Func<PropertyContext<Thickness>, IPropertyBuilder<Thickness>> configure)
        where T : ImageButton
    {
        var context = new PropertyContext<Thickness>(self, ImageButton.PaddingProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Padding<T>(this SettersContext<T> self,
        Thickness padding)
        where T : ImageButton
    {
        self.XamlSetters.Add(new Setter { Property = ImageButton.PaddingProperty, Value = padding });
        return self;
    }
    
    public static SettersContext<T> Padding<T>(this SettersContext<T> self, Func<PropertySettersContext<Thickness>, IPropertySettersBuilder<Thickness>> configure)
        where T : ImageButton
    {
        var context = new PropertySettersContext<Thickness>(self.XamlSetters, ImageButton.PaddingProperty);
        configure(context).Build();
        return self;
    }
    
    public static T OnClicked<T>(this T self, EventHandler handler)
        where T : ImageButton
    {
        self.Clicked += handler;
        return self;
    }
    
    public static T OnClicked<T>(this T self, Action<T> action)
        where T : ImageButton
    {
        self.Clicked += (o, arg) => action(self);
        return self;
    }
    
    public static T OnPressed<T>(this T self, EventHandler handler)
        where T : ImageButton
    {
        self.Pressed += handler;
        return self;
    }
    
    public static T OnPressed<T>(this T self, Action<T> action)
        where T : ImageButton
    {
        self.Pressed += (o, arg) => action(self);
        return self;
    }
    
    public static T OnReleased<T>(this T self, EventHandler handler)
        where T : ImageButton
    {
        self.Released += handler;
        return self;
    }
    
    public static T OnReleased<T>(this T self, Action<T> action)
        where T : ImageButton
    {
        self.Released += (o, arg) => action(self);
        return self;
    }
    
}