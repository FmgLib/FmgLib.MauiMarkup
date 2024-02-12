using SkiaSharp;
using SkiaSharp.Extended.UI.Controls;

namespace FmgLib.MauiMarkup.SkiaSharp;

public static partial class SKLottieViewExtension
{
    public static T SourceFmg<T>(this T self,
        SKLottieImageSource source)
        where T : SKLottieView
    {
        self.SetValue(SKLottieView.SourceProperty, source);
        return self;
    }

    public static T SourceFmg<T>(this T self, Func<PropertyContext<SKLottieImageSource>, IPropertyBuilder<SKLottieImageSource>> configure)
        where T : SKLottieView
    {
        var context = new PropertyContext<SKLottieImageSource>(self, SKLottieView.SourceProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> SourceFmg<T>(this SettersContext<T> self,
        SKLottieImageSource source)
        where T : SKLottieView
    {
        self.XamlSetters.Add(new Setter { Property = SKLottieView.SourceProperty, Value = source });
        return self;
    }

    public static SettersContext<T> SourceFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<SKLottieImageSource>, IPropertySettersBuilder<SKLottieImageSource>> configure)
        where T : SKLottieView
    {
        var context = new PropertySettersContext<SKLottieImageSource>(self.XamlSetters, SKLottieView.SourceProperty);
        configure(context).Build();
        return self;
    }

    public static T DurationFmg<T>(this T self,
        TimeSpan duration)
        where T : SKLottieView
    {
        self.SetValue(SKLottieView.DurationProperty, duration);
        return self;
    }

    public static T DurationFmg<T>(this T self, Func<PropertyContext<TimeSpan>, IPropertyBuilder<TimeSpan>> configure)
        where T : SKLottieView
    {
        var context = new PropertyContext<TimeSpan>(self, SKLottieView.DurationProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> DurationFmg<T>(this SettersContext<T> self,
        TimeSpan duration)
        where T : SKLottieView
    {
        self.XamlSetters.Add(new Setter { Property = SKLottieView.DurationProperty, Value = duration });
        return self;
    }

    public static SettersContext<T> DurationFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<TimeSpan>, IPropertySettersBuilder<TimeSpan>> configure)
        where T : SKLottieView
    {
        var context = new PropertySettersContext<TimeSpan>(self.XamlSetters, SKLottieView.DurationProperty);
        configure(context).Build();
        return self;
    }

    public static T ProgressFmg<T>(this T self,
        TimeSpan time)
        where T : SKLottieView
    {
        self.SetValue(SKLottieView.ProgressProperty, time);
        return self;
    }

    public static T ProgressFmg<T>(this T self, Func<PropertyContext<TimeSpan>, IPropertyBuilder<TimeSpan>> configure)
        where T : SKLottieView
    {
        var context = new PropertyContext<TimeSpan>(self, SKLottieView.ProgressProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ProgressFmg<T>(this SettersContext<T> self,
        TimeSpan time)
        where T : SKLottieView
    {
        self.XamlSetters.Add(new Setter { Property = SKLottieView.ProgressProperty, Value = time });
        return self;
    }

    public static SettersContext<T> ProgressFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<TimeSpan>, IPropertySettersBuilder<TimeSpan>> configure)
        where T : SKLottieView
    {
        var context = new PropertySettersContext<TimeSpan>(self.XamlSetters, SKLottieView.ProgressProperty);
        configure(context).Build();
        return self;
    }

    public static T IsCompleteFmg<T>(this T self,
        bool isComplete)
        where T : SKLottieView
    {
        self.SetValue(SKLottieView.IsCompleteProperty, isComplete);
        return self;
    }

    public static T IsCompleteFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : SKLottieView
    {
        var context = new PropertyContext<bool>(self, SKLottieView.IsCompleteProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IsCompleteFmg<T>(this SettersContext<T> self,
        bool isComplete)
        where T : SKLottieView
    {
        self.XamlSetters.Add(new Setter { Property = SKLottieView.IsCompleteProperty, Value = isComplete });
        return self;
    }

    public static SettersContext<T> IsCompleteFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : SKLottieView
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, SKLottieView.IsCompleteProperty);
        configure(context).Build();
        return self;
    }

    public static T RepeatCountFmg<T>(this T self, int repeatCount) where T : SKLottieView
    {
        self.SetValue(SKLottieView.RepeatCountProperty, repeatCount);
        return self;
    }

    public static T RepeatCountFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure) where T : SKLottieView
    {
        var context = new PropertyContext<int>(self, SKLottieView.RepeatCountProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> RepeatCountFmg<T>(this SettersContext<T> self, int repeatCount) where T : SKLottieView
    {
        self.XamlSetters.Add(new Setter { Property = SKLottieView.RepeatCountProperty, Value = repeatCount });
        return self;
    }

    public static SettersContext<T> RepeatCountFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure) where T : SKLottieView
    {
        var context = new PropertySettersContext<int>(self.XamlSetters, SKLottieView.RepeatCountProperty);
        configure(context).Build();
        return self;
    }

    public static T RepeatModeFmg<T>(this T self,
        SKLottieRepeatMode repeatMode)
        where T : SKLottieView
    {
        self.SetValue(SKLottieView.RepeatModeProperty, repeatMode);
        return self;
    }

    public static T RepeatModeFmg<T>(this T self, Func<PropertyContext<SKLottieRepeatMode>, IPropertyBuilder<SKLottieRepeatMode>> configure)
        where T : SKLottieView
    {
        var context = new PropertyContext<SKLottieRepeatMode>(self, SKLottieView.RepeatModeProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> RepeatModeFmg<T>(this SettersContext<T> self,
        SKLottieRepeatMode repeatMode)
        where T : SKLottieView
    {
        self.XamlSetters.Add(new Setter { Property = SKLottieView.RepeatModeProperty, Value = repeatMode });
        return self;
    }

    public static SettersContext<T> RepeatModeFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<SKLottieRepeatMode>, IPropertySettersBuilder<SKLottieRepeatMode>> configure)
        where T : SKLottieView
    {
        var context = new PropertySettersContext<SKLottieRepeatMode>(self.XamlSetters, SKLottieView.RepeatModeProperty);
        configure(context).Build();
        return self;
    }
}
