namespace FmgLib.MauiMarkup;



public static partial class SliderExtension
{
    public static T MinimumTrackColor<T>(this T self,
        Color minimumTrackColor)
        where T : Slider
    {
        self.SetValue(Slider.MinimumTrackColorProperty, minimumTrackColor);
        return self;
    }
    
    public static T MinimumTrackColor<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : Slider
    {
        var context = new PropertyContext<Color>(self, Slider.MinimumTrackColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> MinimumTrackColor<T>(this SettersContext<T> self,
        Color minimumTrackColor)
        where T : Slider
    {
        self.XamlSetters.Add(new Setter { Property = Slider.MinimumTrackColorProperty, Value = minimumTrackColor });
        return self;
    }
    
    public static SettersContext<T> MinimumTrackColor<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : Slider
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, Slider.MinimumTrackColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateMinimumTrackColorTo<T>(this T self, Color value, uint length = 250, Easing? easing = null)
        where T : Slider
    {
        Color fromValue = self.MinimumTrackColor;
        var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
        var callback = (Color actValue) => { self.MinimumTrackColor = actValue; };
        return Transformations.AnimateAsync<Color>(self, "AnimateMinimumTrackColorTo", transform, callback, length, easing);
    }
    
    public static T MaximumTrackColor<T>(this T self,
        Color maximumTrackColor)
        where T : Slider
    {
        self.SetValue(Slider.MaximumTrackColorProperty, maximumTrackColor);
        return self;
    }
    
    public static T MaximumTrackColor<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : Slider
    {
        var context = new PropertyContext<Color>(self, Slider.MaximumTrackColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> MaximumTrackColor<T>(this SettersContext<T> self,
        Color maximumTrackColor)
        where T : Slider
    {
        self.XamlSetters.Add(new Setter { Property = Slider.MaximumTrackColorProperty, Value = maximumTrackColor });
        return self;
    }
    
    public static SettersContext<T> MaximumTrackColor<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : Slider
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, Slider.MaximumTrackColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateMaximumTrackColorTo<T>(this T self, Color value, uint length = 250, Easing? easing = null)
        where T : Slider
    {
        Color fromValue = self.MaximumTrackColor;
        var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
        var callback = (Color actValue) => { self.MaximumTrackColor = actValue; };
        return Transformations.AnimateAsync<Color>(self, "AnimateMaximumTrackColorTo", transform, callback, length, easing);
    }
    
    public static T ThumbColor<T>(this T self,
        Color thumbColor)
        where T : Slider
    {
        self.SetValue(Slider.ThumbColorProperty, thumbColor);
        return self;
    }
    
    public static T ThumbColor<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : Slider
    {
        var context = new PropertyContext<Color>(self, Slider.ThumbColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ThumbColor<T>(this SettersContext<T> self,
        Color thumbColor)
        where T : Slider
    {
        self.XamlSetters.Add(new Setter { Property = Slider.ThumbColorProperty, Value = thumbColor });
        return self;
    }
    
    public static SettersContext<T> ThumbColor<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : Slider
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, Slider.ThumbColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateThumbColorTo<T>(this T self, Color value, uint length = 250, Easing? easing = null)
        where T : Slider
    {
        Color fromValue = self.ThumbColor;
        var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
        var callback = (Color actValue) => { self.ThumbColor = actValue; };
        return Transformations.AnimateAsync<Color>(self, "AnimateThumbColorTo", transform, callback, length, easing);
    }
    
    public static T ThumbImageSource<T>(this T self,
        ImageSource thumbImageSource)
        where T : Slider
    {
        self.SetValue(Slider.ThumbImageSourceProperty, thumbImageSource);
        return self;
    }
    
    public static T ThumbImageSource<T>(this T self, Func<PropertyContext<ImageSource>, IPropertyBuilder<ImageSource>> configure)
        where T : Slider
    {
        var context = new PropertyContext<ImageSource>(self, Slider.ThumbImageSourceProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ThumbImageSource<T>(this SettersContext<T> self,
        ImageSource thumbImageSource)
        where T : Slider
    {
        self.XamlSetters.Add(new Setter { Property = Slider.ThumbImageSourceProperty, Value = thumbImageSource });
        return self;
    }
    
    public static SettersContext<T> ThumbImageSource<T>(this SettersContext<T> self, Func<PropertySettersContext<ImageSource>, IPropertySettersBuilder<ImageSource>> configure)
        where T : Slider
    {
        var context = new PropertySettersContext<ImageSource>(self.XamlSetters, Slider.ThumbImageSourceProperty);
        configure(context).Build();
        return self;
    }
    
    public static T DragStartedCommand<T>(this T self,
        System.Windows.Input.ICommand dragStartedCommand)
        where T : Slider
    {
        self.SetValue(Slider.DragStartedCommandProperty, dragStartedCommand);
        return self;
    }
    
    public static T DragStartedCommand<T>(this T self, Func<PropertyContext<System.Windows.Input.ICommand>, IPropertyBuilder<System.Windows.Input.ICommand>> configure)
        where T : Slider
    {
        var context = new PropertyContext<System.Windows.Input.ICommand>(self, Slider.DragStartedCommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> DragStartedCommand<T>(this SettersContext<T> self,
        System.Windows.Input.ICommand dragStartedCommand)
        where T : Slider
    {
        self.XamlSetters.Add(new Setter { Property = Slider.DragStartedCommandProperty, Value = dragStartedCommand });
        return self;
    }
    
    public static SettersContext<T> DragStartedCommand<T>(this SettersContext<T> self, Func<PropertySettersContext<System.Windows.Input.ICommand>, IPropertySettersBuilder<System.Windows.Input.ICommand>> configure)
        where T : Slider
    {
        var context = new PropertySettersContext<System.Windows.Input.ICommand>(self.XamlSetters, Slider.DragStartedCommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static T DragCompletedCommand<T>(this T self,
        System.Windows.Input.ICommand dragCompletedCommand)
        where T : Slider
    {
        self.SetValue(Slider.DragCompletedCommandProperty, dragCompletedCommand);
        return self;
    }
    
    public static T DragCompletedCommand<T>(this T self, Func<PropertyContext<System.Windows.Input.ICommand>, IPropertyBuilder<System.Windows.Input.ICommand>> configure)
        where T : Slider
    {
        var context = new PropertyContext<System.Windows.Input.ICommand>(self, Slider.DragCompletedCommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> DragCompletedCommand<T>(this SettersContext<T> self,
        System.Windows.Input.ICommand dragCompletedCommand)
        where T : Slider
    {
        self.XamlSetters.Add(new Setter { Property = Slider.DragCompletedCommandProperty, Value = dragCompletedCommand });
        return self;
    }
    
    public static SettersContext<T> DragCompletedCommand<T>(this SettersContext<T> self, Func<PropertySettersContext<System.Windows.Input.ICommand>, IPropertySettersBuilder<System.Windows.Input.ICommand>> configure)
        where T : Slider
    {
        var context = new PropertySettersContext<System.Windows.Input.ICommand>(self.XamlSetters, Slider.DragCompletedCommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static T Maximum<T>(this T self,
        double maximum)
        where T : Slider
    {
        self.SetValue(Slider.MaximumProperty, maximum);
        return self;
    }
    
    public static T Maximum<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Slider
    {
        var context = new PropertyContext<double>(self, Slider.MaximumProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Maximum<T>(this SettersContext<T> self,
        double maximum)
        where T : Slider
    {
        self.XamlSetters.Add(new Setter { Property = Slider.MaximumProperty, Value = maximum });
        return self;
    }
    
    public static SettersContext<T> Maximum<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Slider
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Slider.MaximumProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateMaximumTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : Slider
    {
        double fromValue = self.Maximum;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.Maximum = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateMaximumTo", transform, callback, length, easing);
    }
    
    public static T Minimum<T>(this T self,
        double minimum)
        where T : Slider
    {
        self.SetValue(Slider.MinimumProperty, minimum);
        return self;
    }
    
    public static T Minimum<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Slider
    {
        var context = new PropertyContext<double>(self, Slider.MinimumProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Minimum<T>(this SettersContext<T> self,
        double minimum)
        where T : Slider
    {
        self.XamlSetters.Add(new Setter { Property = Slider.MinimumProperty, Value = minimum });
        return self;
    }
    
    public static SettersContext<T> Minimum<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Slider
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Slider.MinimumProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateMinimumTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : Slider
    {
        double fromValue = self.Minimum;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.Minimum = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateMinimumTo", transform, callback, length, easing);
    }
    
    public static T Value<T>(this T self,
        double value)
        where T : Slider
    {
        self.SetValue(Slider.ValueProperty, value);
        return self;
    }
    
    public static T Value<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Slider
    {
        var context = new PropertyContext<double>(self, Slider.ValueProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Value<T>(this SettersContext<T> self,
        double value)
        where T : Slider
    {
        self.XamlSetters.Add(new Setter { Property = Slider.ValueProperty, Value = value });
        return self;
    }
    
    public static SettersContext<T> Value<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Slider
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Slider.ValueProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateValueTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : Slider
    {
        double fromValue = self.Value;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.Value = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateValueTo", transform, callback, length, easing);
    }
    
    public static T OnValueChanged<T>(this T self, EventHandler<ValueChangedEventArgs> handler)
        where T : Slider
    {
        self.ValueChanged += handler;
        return self;
    }
    
    public static T OnValueChanged<T>(this T self, Action<T> action)
        where T : Slider
    {
        self.ValueChanged += (o, arg) => action(self);
        return self;
    }
    
    public static T OnDragStarted<T>(this T self, EventHandler handler)
        where T : Slider
    {
        self.DragStarted += handler;
        return self;
    }
    
    public static T OnDragStarted<T>(this T self, Action<T> action)
        where T : Slider
    {
        self.DragStarted += (o, arg) => action(self);
        return self;
    }
    
    public static T OnDragCompleted<T>(this T self, EventHandler handler)
        where T : Slider
    {
        self.DragCompleted += handler;
        return self;
    }
    
    public static T OnDragCompleted<T>(this T self, Action<T> action)
        where T : Slider
    {
        self.DragCompleted += (o, arg) => action(self);
        return self;
    }
    
}
