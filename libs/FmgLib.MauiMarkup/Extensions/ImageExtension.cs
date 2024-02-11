namespace FmgLib.MauiMarkup;



public static partial class ImageExtension
{
    public static T AspectFmg<T>(this T self,
        Aspect aspect)
        where T : Image
    {
        self.SetValue(Image.AspectProperty, aspect);
        return self;
    }
    
    public static T AspectFmg<T>(this T self, Func<PropertyContext<Aspect>, IPropertyBuilder<Aspect>> configure)
        where T : Image
    {
        var context = new PropertyContext<Aspect>(self, Image.AspectProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> AspectFmg<T>(this SettersContext<T> self,
        Aspect aspect)
        where T : Image
    {
        self.XamlSetters.Add(new Setter { Property = Image.AspectProperty, Value = aspect });
        return self;
    }
    
    public static SettersContext<T> AspectFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Aspect>, IPropertySettersBuilder<Aspect>> configure)
        where T : Image
    {
        var context = new PropertySettersContext<Aspect>(self.XamlSetters, Image.AspectProperty);
        configure(context).Build();
        return self;
    }
    
    public static T IsOpaqueFmg<T>(this T self,
        bool isOpaque)
        where T : Image
    {
        self.SetValue(Image.IsOpaqueProperty, isOpaque);
        return self;
    }
    
    public static T IsOpaqueFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : Image
    {
        var context = new PropertyContext<bool>(self, Image.IsOpaqueProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> IsOpaqueFmg<T>(this SettersContext<T> self,
        bool isOpaque)
        where T : Image
    {
        self.XamlSetters.Add(new Setter { Property = Image.IsOpaqueProperty, Value = isOpaque });
        return self;
    }
    
    public static SettersContext<T> IsOpaqueFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : Image
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, Image.IsOpaqueProperty);
        configure(context).Build();
        return self;
    }
    
    public static T IsAnimationPlayingFmg<T>(this T self,
        bool isAnimationPlaying)
        where T : Image
    {
        self.SetValue(Image.IsAnimationPlayingProperty, isAnimationPlaying);
        return self;
    }
    
    public static T IsAnimationPlayingFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : Image
    {
        var context = new PropertyContext<bool>(self, Image.IsAnimationPlayingProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> IsAnimationPlayingFmg<T>(this SettersContext<T> self,
        bool isAnimationPlaying)
        where T : Image
    {
        self.XamlSetters.Add(new Setter { Property = Image.IsAnimationPlayingProperty, Value = isAnimationPlaying });
        return self;
    }
    
    public static SettersContext<T> IsAnimationPlayingFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : Image
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, Image.IsAnimationPlayingProperty);
        configure(context).Build();
        return self;
    }
    
    public static T SourceFmg<T>(this T self,
        ImageSource source)
        where T : Image
    {
        self.SetValue(Image.SourceProperty, source);
        return self;
    }
    
    public static T SourceFmg<T>(this T self, Func<PropertyContext<ImageSource>, IPropertyBuilder<ImageSource>> configure)
        where T : Image
    {
        var context = new PropertyContext<ImageSource>(self, Image.SourceProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> SourceFmg<T>(this SettersContext<T> self,
        ImageSource source)
        where T : Image
    {
        self.XamlSetters.Add(new Setter { Property = Image.SourceProperty, Value = source });
        return self;
    }
    
    public static SettersContext<T> SourceFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ImageSource>, IPropertySettersBuilder<ImageSource>> configure)
        where T : Image
    {
        var context = new PropertySettersContext<ImageSource>(self.XamlSetters, Image.SourceProperty);
        configure(context).Build();
        return self;
    }
    
}
