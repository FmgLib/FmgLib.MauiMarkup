using CommunityToolkit.Maui.Behaviors;

namespace FmgLib.MauiMarkup.Views;

public static partial class ImageTouchBehaviorExtension
{
    public static T DefaultImageSourceFmg<T>(this T self,
        ImageSource imageSource)
        where T : ImageTouchBehavior
    {
        self.SetValue(ImageTouchBehavior.DefaultImageSourceProperty, imageSource);
        return self;
    }

    public static T DefaultImageSourceFmg<T>(this T self, Func<PropertyContext<ImageSource>, IPropertyBuilder<ImageSource>> configure)
        where T : ImageTouchBehavior
    {
        var context = new PropertyContext<ImageSource>(self, ImageTouchBehavior.DefaultImageSourceProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> DefaultImageSourceFmg<T>(this SettersContext<T> self,
        ImageSource imageSource)
        where T : ImageTouchBehavior
    {
        self.XamlSetters.Add(new Setter { Property = ImageTouchBehavior.DefaultImageSourceProperty, Value = imageSource });
        return self;
    }

    public static SettersContext<T> DefaultImageSourceFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ImageSource>, IPropertySettersBuilder<ImageSource>> configure)
        where T : ImageTouchBehavior
    {
        var context = new PropertySettersContext<ImageSource>(self.XamlSetters, ImageTouchBehavior.DefaultImageSourceProperty);
        configure(context).Build();
        return self;
    }

    public static T HoveredImageSourceFmg<T>(this T self,
        ImageSource imageSource)
        where T : ImageTouchBehavior
    {
        self.SetValue(ImageTouchBehavior.HoveredBackgroundImageSourceProperty, imageSource);
        return self;
    }

    public static T HoveredImageSourceFmg<T>(this T self, Func<PropertyContext<ImageSource>, IPropertyBuilder<ImageSource>> configure)
        where T : ImageTouchBehavior
    {
        var context = new PropertyContext<ImageSource>(self, ImageTouchBehavior.HoveredBackgroundImageSourceProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> HoveredImageSourceFmg<T>(this SettersContext<T> self,
        ImageSource imageSource)
        where T : ImageTouchBehavior
    {
        self.XamlSetters.Add(new Setter { Property = ImageTouchBehavior.HoveredBackgroundImageSourceProperty, Value = imageSource });
        return self;
    }

    public static SettersContext<T> HoveredImageSourceFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ImageSource>, IPropertySettersBuilder<ImageSource>> configure)
        where T : ImageTouchBehavior
    {
        var context = new PropertySettersContext<ImageSource>(self.XamlSetters, ImageTouchBehavior.HoveredBackgroundImageSourceProperty);
        configure(context).Build();
        return self;
    }

    public static T PressedImageSourceFmg<T>(this T self,
        ImageSource imageSource)
        where T : ImageTouchBehavior
    {
        self.SetValue(ImageTouchBehavior.PressedBackgroundImageSourceProperty, imageSource);
        return self;
    }

    public static T PressedImageSourceFmg<T>(this T self, Func<PropertyContext<ImageSource>, IPropertyBuilder<ImageSource>> configure)
        where T : ImageTouchBehavior
    {
        var context = new PropertyContext<ImageSource>(self, ImageTouchBehavior.PressedBackgroundImageSourceProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> PressedImageSourceFmg<T>(this SettersContext<T> self,
        ImageSource imageSource)
        where T : ImageTouchBehavior
    {
        self.XamlSetters.Add(new Setter { Property = ImageTouchBehavior.PressedBackgroundImageSourceProperty, Value = imageSource });
        return self;
    }

    public static SettersContext<T> PressedImageSourceFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ImageSource>, IPropertySettersBuilder<ImageSource>> configure)
        where T : ImageTouchBehavior
    {
        var context = new PropertySettersContext<ImageSource>(self.XamlSetters, ImageTouchBehavior.PressedBackgroundImageSourceProperty);
        configure(context).Build();
        return self;
    }

    public static T DefaultImageAspectFmg<T>(this T self,
        Aspect aspect)
        where T : ImageTouchBehavior
    {
        self.SetValue(ImageTouchBehavior.DefaultImageAspectProperty, aspect);
        return self;
    }

    public static T DefaultImageAspectFmg<T>(this T self, Func<PropertyContext<Aspect>, IPropertyBuilder<Aspect>> configure)
        where T : ImageTouchBehavior
    {
        var context = new PropertyContext<Aspect>(self, ImageTouchBehavior.DefaultImageAspectProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> DefaultImageAspectFmg<T>(this SettersContext<T> self,
        Aspect aspect)
        where T : ImageTouchBehavior
    {
        self.XamlSetters.Add(new Setter { Property = ImageTouchBehavior.DefaultImageAspectProperty, Value = aspect });
        return self;
    }

    public static SettersContext<T> DefaultImageAspectFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Aspect>, IPropertySettersBuilder<Aspect>> configure)
        where T : ImageTouchBehavior
    {
        var context = new PropertySettersContext<Aspect>(self.XamlSetters, ImageTouchBehavior.DefaultImageAspectProperty);
        configure(context).Build();
        return self;
    }

    public static T HoveredImageAspectFmg<T>(this T self,
        Aspect aspect)
        where T : ImageTouchBehavior
    {
        self.SetValue(ImageTouchBehavior.HoveredImageAspectProperty, aspect);
        return self;
    }

    public static T HoveredImageAspectFmg<T>(this T self, Func<PropertyContext<Aspect>, IPropertyBuilder<Aspect>> configure)
        where T : ImageTouchBehavior
    {
        var context = new PropertyContext<Aspect>(self, ImageTouchBehavior.HoveredImageAspectProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> HoveredImageAspectFmg<T>(this SettersContext<T> self,
        Aspect aspect)
        where T : ImageTouchBehavior
    {
        self.XamlSetters.Add(new Setter { Property = ImageTouchBehavior.HoveredImageAspectProperty, Value = aspect });
        return self;
    }

    public static SettersContext<T> HoveredImageAspectFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Aspect>, IPropertySettersBuilder<Aspect>> configure)
        where T : ImageTouchBehavior
    {
        var context = new PropertySettersContext<Aspect>(self.XamlSetters, ImageTouchBehavior.HoveredImageAspectProperty);
        configure(context).Build();
        return self;
    }

    public static T PressedImageAspectFmg<T>(this T self,
        Aspect aspect)
        where T : ImageTouchBehavior
    {
        self.SetValue(ImageTouchBehavior.PressedImageAspectProperty, aspect);
        return self;
    }

    public static T PressedImageAspectFmg<T>(this T self, Func<PropertyContext<Aspect>, IPropertyBuilder<Aspect>> configure)
        where T : ImageTouchBehavior
    {
        var context = new PropertyContext<Aspect>(self, ImageTouchBehavior.PressedImageAspectProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> PressedImageAspectFmg<T>(this SettersContext<T> self,
        Aspect aspect)
        where T : ImageTouchBehavior
    {
        self.XamlSetters.Add(new Setter { Property = ImageTouchBehavior.PressedImageAspectProperty, Value = aspect });
        return self;
    }

    public static SettersContext<T> PressedImageAspectFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Aspect>, IPropertySettersBuilder<Aspect>> configure)
        where T : ImageTouchBehavior
    {
        var context = new PropertySettersContext<Aspect>(self.XamlSetters, ImageTouchBehavior.PressedImageAspectProperty);
        configure(context).Build();
        return self;
    }

    public static T ShouldSetImageOnAnimationEndFmg<T>(this T self,
        bool shouldSetImageOnAnimationEnd)
        where T : ImageTouchBehavior
    {
        self.SetValue(ImageTouchBehavior.ShouldSetImageOnAnimationEndProperty, shouldSetImageOnAnimationEnd);
        return self;
    }

    public static T ShouldSetImageOnAnimationEndFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : ImageTouchBehavior
    {
        var context = new PropertyContext<bool>(self, ImageTouchBehavior.ShouldSetImageOnAnimationEndProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ShouldSetImageOnAnimationEndFmg<T>(this SettersContext<T> self,
        bool shouldSetImageOnAnimationEnd)
        where T : ImageTouchBehavior
    {
        self.XamlSetters.Add(new Setter { Property = ImageTouchBehavior.ShouldSetImageOnAnimationEndProperty, Value = shouldSetImageOnAnimationEnd });
        return self;
    }

    public static SettersContext<T> ShouldSetImageOnAnimationEndFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : ImageTouchBehavior
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, ImageTouchBehavior.ShouldSetImageOnAnimationEndProperty);
        configure(context).Build();
        return self;
    }
}
