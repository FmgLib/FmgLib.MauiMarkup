namespace FmgLib.MauiMarkup;

public static class ImageExtension
{
    public static T Aspect<T>(this T self, Aspect aspect) where T : Image
    {
        self.SetValue(Image.AspectProperty, aspect);
        return self;
    }

    public static T Aspect<T>(this T self, Func<PropertyContext<Aspect>, IPropertyBuilder<Aspect>> configure) where T : Image
    {
        PropertyContext<Aspect> arg = new PropertyContext<Aspect>(self, Image.AspectProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> Aspect<T>(this SettersContext<T> self, Aspect aspect) where T : Image
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Image.AspectProperty,
            Value = aspect
        });
        return self;
    }

    public static SettersContext<T> Aspect<T>(this SettersContext<T> self, Func<PropertySettersContext<Aspect>, IPropertySettersBuilder<Aspect>> configure) where T : Image
    {
        PropertySettersContext<Aspect> arg = new PropertySettersContext<Aspect>(self.XamlSetters, Image.AspectProperty);
        configure(arg).Build();
        return self;
    }

    public static T IsOpaque<T>(this T self, bool isOpaque) where T : Image
    {
        self.SetValue(Image.IsOpaqueProperty, isOpaque);
        return self;
    }

    public static T IsOpaque<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure) where T : Image
    {
        PropertyContext<bool> arg = new PropertyContext<bool>(self, Image.IsOpaqueProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> IsOpaque<T>(this SettersContext<T> self, bool isOpaque) where T : Image
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Image.IsOpaqueProperty,
            Value = isOpaque
        });
        return self;
    }

    public static SettersContext<T> IsOpaque<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure) where T : Image
    {
        PropertySettersContext<bool> arg = new PropertySettersContext<bool>(self.XamlSetters, Image.IsOpaqueProperty);
        configure(arg).Build();
        return self;
    }

    public static T IsAnimationPlaying<T>(this T self, bool isAnimationPlaying) where T : Image
    {
        self.SetValue(Image.IsAnimationPlayingProperty, isAnimationPlaying);
        return self;
    }

    public static T IsAnimationPlaying<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure) where T : Image
    {
        PropertyContext<bool> arg = new PropertyContext<bool>(self, Image.IsAnimationPlayingProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> IsAnimationPlaying<T>(this SettersContext<T> self, bool isAnimationPlaying) where T : Image
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Image.IsAnimationPlayingProperty,
            Value = isAnimationPlaying
        });
        return self;
    }

    public static SettersContext<T> IsAnimationPlaying<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure) where T : Image
    {
        PropertySettersContext<bool> arg = new PropertySettersContext<bool>(self.XamlSetters, Image.IsAnimationPlayingProperty);
        configure(arg).Build();
        return self;
    }

    public static T Source<T>(this T self, ImageSource source) where T : Image
    {
        self.SetValue(Image.SourceProperty, source);
        return self;
    }

    public static T Source<T>(this T self, Func<PropertyContext<ImageSource>, IPropertyBuilder<ImageSource>> configure) where T : Image
    {
        PropertyContext<ImageSource> arg = new PropertyContext<ImageSource>(self, Image.SourceProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> Source<T>(this SettersContext<T> self, ImageSource source) where T : Image
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Image.SourceProperty,
            Value = source
        });
        return self;
    }

    public static SettersContext<T> Source<T>(this SettersContext<T> self, Func<PropertySettersContext<ImageSource>, IPropertySettersBuilder<ImageSource>> configure) where T : Image
    {
        PropertySettersContext<ImageSource> arg = new PropertySettersContext<ImageSource>(self.XamlSetters, Image.SourceProperty);
        configure(arg).Build();
        return self;
    }
}
