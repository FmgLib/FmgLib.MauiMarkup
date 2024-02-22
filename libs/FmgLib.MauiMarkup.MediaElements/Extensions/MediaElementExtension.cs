using CommunityToolkit.Maui.Core.Primitives;
using CommunityToolkit.Maui.Views;
using System.Windows.Input;

namespace FmgLib.MauiMarkup.MediaElements;

public static partial class MediaElementExtension
{
    public static T AspectFmg<T>(this T self, Aspect aspect) where T : MediaElement
    {
        self.SetValue(MediaElement.AspectProperty, aspect);
        return self;
    }

    public static T AspectFmg<T>(this T self, Func<PropertyContext<Aspect>, IPropertyBuilder<Aspect>> configure) where T : MediaElement
    {
        PropertyContext<Aspect> arg = new PropertyContext<Aspect>(self, MediaElement.AspectProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> AspectFmg<T>(this SettersContext<T> self, Aspect aspect) where T : MediaElement
    {
        self.XamlSetters.Add(new Setter
        {
            Property = MediaElement.AspectProperty,
            Value = aspect
        });
        return self;
    }

    public static SettersContext<T> AspectFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Aspect>, IPropertySettersBuilder<Aspect>> configure) where T : MediaElement
    {
        PropertySettersContext<Aspect> arg = new PropertySettersContext<Aspect>(self.XamlSetters, MediaElement.AspectProperty);
        configure(arg).Build();
        return self;
    }

    public static T DurationFmg<T>(this T self,
        TimeSpan time)
        where T : MediaElement
    {
        self.SetValue(MediaElement.DurationProperty, time);
        return self;
    }

    public static T DurationFmg<T>(this T self, Func<PropertyContext<TimeSpan>, IPropertyBuilder<TimeSpan>> configure)
        where T : MediaElement
    {
        var context = new PropertyContext<TimeSpan>(self, MediaElement.DurationProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> DurationFmg<T>(this SettersContext<T> self,
        TimeSpan time)
        where T : MediaElement
    {
        self.XamlSetters.Add(new Setter { Property = MediaElement.DurationProperty, Value = time });
        return self;
    }

    public static SettersContext<T> DurationFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<TimeSpan>, IPropertySettersBuilder<TimeSpan>> configure)
        where T : MediaElement
    {
        var context = new PropertySettersContext<TimeSpan>(self.XamlSetters, MediaElement.DurationProperty);
        configure(context).Build();
        return self;
    }

    public static T CurrentStateFmg<T>(this T self, MediaElementState state) where T : MediaElement
    {
        self.SetValue(MediaElement.CurrentStateProperty, state);
        return self;
    }

    public static T CurrentStateFmg<T>(this T self, Func<PropertyContext<MediaElementState>, IPropertyBuilder<MediaElementState>> configure) where T : MediaElement
    {
        PropertyContext<MediaElementState> arg = new PropertyContext<MediaElementState>(self, MediaElement.CurrentStateProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> CurrentStateFmg<T>(this SettersContext<T> self, MediaElementState state) where T : MediaElement
    {
        self.XamlSetters.Add(new Setter
        {
            Property = MediaElement.CurrentStateProperty,
            Value = state
        });
        return self;
    }

    public static SettersContext<T> CurrentStateFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<MediaElementState>, IPropertySettersBuilder<MediaElementState>> configure) where T : MediaElement
    {
        PropertySettersContext<MediaElementState> arg = new PropertySettersContext<MediaElementState>(self.XamlSetters, MediaElement.CurrentStateProperty);
        configure(arg).Build();
        return self;
    }

    public static T ShouldAutoPlayFmg<T>(this T self,
        bool shouldAutoPlay)
        where T : MediaElement
    {
        self.SetValue(MediaElement.ShouldAutoPlayProperty, shouldAutoPlay);
        return self;
    }

    public static T ShouldAutoPlayFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : MediaElement
    {
        var context = new PropertyContext<bool>(self, MediaElement.ShouldAutoPlayProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ShouldAutoPlayFmg<T>(this SettersContext<T> self,
        bool shouldAutoPlay)
        where T : MediaElement
    {
        self.XamlSetters.Add(new Setter { Property = MediaElement.ShouldAutoPlayProperty, Value = shouldAutoPlay });
        return self;
    }

    public static SettersContext<T> ShouldAutoPlayFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : MediaElement
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, MediaElement.ShouldAutoPlayProperty);
        configure(context).Build();
        return self;
    }

    public static T ShouldLoopPlaybackFmg<T>(this T self,
        bool shouldLoopPlayback)
        where T : MediaElement
    {
        self.SetValue(MediaElement.ShouldLoopPlaybackProperty, shouldLoopPlayback);
        return self;
    }

    public static T ShouldLoopPlaybackFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : MediaElement
    {
        var context = new PropertyContext<bool>(self, MediaElement.ShouldLoopPlaybackProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ShouldLoopPlaybackFmg<T>(this SettersContext<T> self,
        bool shouldLoopPlayback)
        where T : MediaElement
    {
        self.XamlSetters.Add(new Setter { Property = MediaElement.ShouldLoopPlaybackProperty, Value = shouldLoopPlayback });
        return self;
    }

    public static SettersContext<T> ShouldLoopPlaybackFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : MediaElement
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, MediaElement.ShouldLoopPlaybackProperty);
        configure(context).Build();
        return self;
    }

    public static T ShouldKeepScreenOnFmg<T>(this T self,
        bool shouldKeepScreenOn)
        where T : MediaElement
    {
        self.SetValue(MediaElement.ShouldKeepScreenOnProperty, shouldKeepScreenOn);
        return self;
    }

    public static T ShouldKeepScreenOnFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : MediaElement
    {
        var context = new PropertyContext<bool>(self, MediaElement.ShouldKeepScreenOnProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ShouldKeepScreenOnFmg<T>(this SettersContext<T> self,
        bool shouldKeepScreenOn)
        where T : MediaElement
    {
        self.XamlSetters.Add(new Setter { Property = MediaElement.ShouldKeepScreenOnProperty, Value = shouldKeepScreenOn });
        return self;
    }

    public static SettersContext<T> ShouldKeepScreenOnFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : MediaElement
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, MediaElement.ShouldKeepScreenOnProperty);
        configure(context).Build();
        return self;
    }

    public static T ShouldMuteFmg<T>(this T self,
        bool shouldMute)
        where T : MediaElement
    {
        self.SetValue(MediaElement.ShouldMuteProperty, shouldMute);
        return self;
    }

    public static T ShouldMuteFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : MediaElement
    {
        var context = new PropertyContext<bool>(self, MediaElement.ShouldMuteProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ShouldMuteFmg<T>(this SettersContext<T> self,
        bool shouldMute)
        where T : MediaElement
    {
        self.XamlSetters.Add(new Setter { Property = MediaElement.ShouldMuteProperty, Value = shouldMute });
        return self;
    }

    public static SettersContext<T> ShouldMuteFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : MediaElement
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, MediaElement.ShouldMuteProperty);
        configure(context).Build();
        return self;
    }

    public static T PositionFmg<T>(this T self, TimeSpan time)
        where T : MediaElement
    {
        self.SetValue(MediaElement.PositionProperty, time);
        return self;
    }

    public static T PositionFmg<T>(this T self, Func<PropertyContext<TimeSpan>, IPropertyBuilder<TimeSpan>> configure)
        where T : MediaElement
    {
        var context = new PropertyContext<TimeSpan>(self, MediaElement.PositionProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> PositionFmg<T>(this SettersContext<T> self,
        TimeSpan time)
        where T : MediaElement
    {
        self.XamlSetters.Add(new Setter { Property = MediaElement.PositionProperty, Value = time });
        return self;
    }

    public static SettersContext<T> PositionFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<TimeSpan>, IPropertySettersBuilder<TimeSpan>> configure)
        where T : MediaElement
    {
        var context = new PropertySettersContext<TimeSpan>(self.XamlSetters, MediaElement.PositionProperty);
        configure(context).Build();
        return self;
    }

    public static T ShouldShowPlaybackControlsFmg<T>(this T self,
        bool shouldShowPlaybackControls)
        where T : MediaElement
    {
        self.SetValue(MediaElement.ShowsPlaybackControlsProperty, shouldShowPlaybackControls);
        return self;
    }

    public static T ShouldShowPlaybackControlsFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : MediaElement
    {
        var context = new PropertyContext<bool>(self, MediaElement.ShowsPlaybackControlsProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ShouldShowPlaybackControlsFmg<T>(this SettersContext<T> self,
        bool shouldShowPlaybackControls)
        where T : MediaElement
    {
        self.XamlSetters.Add(new Setter { Property = MediaElement.ShowsPlaybackControlsProperty, Value = shouldShowPlaybackControls });
        return self;
    }

    public static SettersContext<T> ShouldShowPlaybackControlsFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : MediaElement
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, MediaElement.ShowsPlaybackControlsProperty);
        configure(context).Build();
        return self;
    }

    public static T SourceFmg<T>(this T self, MediaSource source) where T : MediaElement
    {
        self.SetValue(MediaElement.SourceProperty, source);
        return self;
    }

    public static T SourceFmg<T>(this T self, Func<PropertyContext<MediaSource>, IPropertyBuilder<MediaSource>> configure) where T : MediaElement
    {
        PropertyContext<MediaSource> arg = new PropertyContext<MediaSource>(self, MediaElement.SourceProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> SourceFmg<T>(this SettersContext<T> self, MediaSource source) where T : MediaElement
    {
        self.XamlSetters.Add(new Setter
        {
            Property = MediaElement.SourceProperty,
            Value = source
        });
        return self;
    }

    public static SettersContext<T> SourceFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<MediaSource>, IPropertySettersBuilder<MediaSource>> configure) where T : MediaElement
    {
        PropertySettersContext<MediaSource> arg = new PropertySettersContext<MediaSource>(self.XamlSetters, MediaElement.SourceProperty);
        configure(arg).Build();
        return self;
    }

    public static T SpeedFmg<T>(this T self,
        double speed)
        where T : MediaElement
    {
        self.SetValue(MediaElement.SpeedProperty, speed);
        return self;
    }

    public static T SpeedFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : MediaElement
    {
        var context = new PropertyContext<double>(self, MediaElement.SpeedProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> SpeedFmg<T>(this SettersContext<T> self,
        double speed)
        where T : MediaElement
    {
        self.XamlSetters.Add(new Setter { Property = MediaElement.SpeedProperty, Value = speed });
        return self;
    }

    public static SettersContext<T> SpeedFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : MediaElement
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, MediaElement.SpeedProperty);
        configure(context).Build();
        return self;
    }

    public static T MediaHeightFmg<T>(this T self,
        int height)
        where T : MediaElement
    {
        self.SetValue(MediaElement.MediaHeightProperty, height);
        return self;
    }

    public static T MediaHeightFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
        where T : MediaElement
    {
        var context = new PropertyContext<int>(self, MediaElement.MediaHeightProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> MediaHeightFmg<T>(this SettersContext<T> self,
        int height)
        where T : MediaElement
    {
        self.XamlSetters.Add(new Setter { Property = MediaElement.MediaHeightProperty, Value = height });
        return self;
    }

    public static SettersContext<T> MediaHeightFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure)
        where T : MediaElement
    {
        var context = new PropertySettersContext<int>(self.XamlSetters, MediaElement.MediaHeightProperty);
        configure(context).Build();
        return self;
    }

    public static T MediaWidthFmg<T>(this T self,
        int width)
        where T : MediaElement
    {
        self.SetValue(MediaElement.MediaWidthProperty, width);
        return self;
    }

    public static T MediaWidthFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
        where T : MediaElement
    {
        var context = new PropertyContext<int>(self, MediaElement.MediaWidthProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> MediaWidthFmg<T>(this SettersContext<T> self,
        int width)
        where T : MediaElement
    {
        self.XamlSetters.Add(new Setter { Property = MediaElement.MediaWidthProperty, Value = width });
        return self;
    }

    public static SettersContext<T> MediaWidthFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure)
        where T : MediaElement
    {
        var context = new PropertySettersContext<int>(self.XamlSetters, MediaElement.MediaWidthProperty);
        configure(context).Build();
        return self;
    }

    public static T VolumeFmg<T>(this T self,
        double volume)
        where T : MediaElement
    {
        self.SetValue(MediaElement.VolumeProperty, volume);
        return self;
    }

    public static T VolumeFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : MediaElement
    {
        var context = new PropertyContext<double>(self, MediaElement.VolumeProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> VolumeFmg<T>(this SettersContext<T> self,
        double volume)
        where T : MediaElement
    {
        self.XamlSetters.Add(new Setter { Property = MediaElement.VolumeProperty, Value = volume });
        return self;
    }

    public static SettersContext<T> VolumeFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : MediaElement
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, MediaElement.VolumeProperty);
        configure(context).Build();
        return self;
    }
}
