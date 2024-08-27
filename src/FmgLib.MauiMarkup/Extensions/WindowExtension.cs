namespace FmgLib.MauiMarkup;

public static partial class WindowExtension
{
    public static T Title<T>(this T self,
        string? title)
        where T : Window
    {
        self.SetValue(Window.TitleProperty, title);
        return self;
    }
    
    public static T Title<T>(this T self, Func<PropertyContext<string?>, IPropertyBuilder<string?>> configure)
        where T : Window
    {
        var context = new PropertyContext<string?>(self, Window.TitleProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Title<T>(this SettersContext<T> self,
        string? title)
        where T : Window
    {
        self.XamlSetters.Add(new Setter { Property = Window.TitleProperty, Value = title });
        return self;
    }
    
    public static SettersContext<T> Title<T>(this SettersContext<T> self, Func<PropertySettersContext<string?>, IPropertySettersBuilder<string?>> configure)
        where T : Window
    {
        var context = new PropertySettersContext<string?>(self.XamlSetters, Window.TitleProperty);
        configure(context).Build();
        return self;
    }
    
    public static T Page<T>(this T self,
        Func<Page?> configure)
        where T : Window
    {
        var page = configure();
        self.SetValue(Window.PageProperty, page);
        return self;
    }
    
    public static T Page<T>(this T self,
        Page? page)
        where T : Window
    {
        self.SetValue(Window.PageProperty, page);
        return self;
    }
    
    public static T Page<T>(this T self, Func<PropertyContext<Page?>, IPropertyBuilder<Page?>> configure)
        where T : Window
    {
        var context = new PropertyContext<Page?>(self, Window.PageProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Page<T>(this SettersContext<T> self,
        Page? page)
        where T : Window
    {
        self.XamlSetters.Add(new Setter { Property = Window.PageProperty, Value = page });
        return self;
    }
    
    public static SettersContext<T> Page<T>(this SettersContext<T> self, Func<PropertySettersContext<Page?>, IPropertySettersBuilder<Page?>> configure)
        where T : Window
    {
        var context = new PropertySettersContext<Page?>(self.XamlSetters, Window.PageProperty);
        configure(context).Build();
        return self;
    }
    
    public static T X<T>(this T self,
        double x)
        where T : Window
    {
        self.SetValue(Window.XProperty, x);
        return self;
    }
    
    public static T X<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Window
    {
        var context = new PropertyContext<double>(self, Window.XProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> X<T>(this SettersContext<T> self,
        double x)
        where T : Window
    {
        self.XamlSetters.Add(new Setter { Property = Window.XProperty, Value = x });
        return self;
    }
    
    public static SettersContext<T> X<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Window
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Window.XProperty);
        configure(context).Build();
        return self;
    }
    
    public static T Y<T>(this T self,
        double y)
        where T : Window
    {
        self.SetValue(Window.YProperty, y);
        return self;
    }
    
    public static T Y<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Window
    {
        var context = new PropertyContext<double>(self, Window.YProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Y<T>(this SettersContext<T> self,
        double y)
        where T : Window
    {
        self.XamlSetters.Add(new Setter { Property = Window.YProperty, Value = y });
        return self;
    }
    
    public static SettersContext<T> Y<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Window
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Window.YProperty);
        configure(context).Build();
        return self;
    }
    
    public static T Width<T>(this T self,
        double width)
        where T : Window
    {
        self.SetValue(Window.WidthProperty, width);
        return self;
    }
    
    public static T Width<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Window
    {
        var context = new PropertyContext<double>(self, Window.WidthProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Width<T>(this SettersContext<T> self,
        double width)
        where T : Window
    {
        self.XamlSetters.Add(new Setter { Property = Window.WidthProperty, Value = width });
        return self;
    }
    
    public static SettersContext<T> Width<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Window
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Window.WidthProperty);
        configure(context).Build();
        return self;
    }
    
    public static T Height<T>(this T self,
        double height)
        where T : Window
    {
        self.SetValue(Window.HeightProperty, height);
        return self;
    }
    
    public static T Height<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Window
    {
        var context = new PropertyContext<double>(self, Window.HeightProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Height<T>(this SettersContext<T> self,
        double height)
        where T : Window
    {
        self.XamlSetters.Add(new Setter { Property = Window.HeightProperty, Value = height });
        return self;
    }
    
    public static SettersContext<T> Height<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Window
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Window.HeightProperty);
        configure(context).Build();
        return self;
    }
    
    public static T MaximumWidth<T>(this T self,
        double maximumWidth)
        where T : Window
    {
        self.SetValue(Window.MaximumWidthProperty, maximumWidth);
        return self;
    }
    
    public static T MaximumWidth<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Window
    {
        var context = new PropertyContext<double>(self, Window.MaximumWidthProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> MaximumWidth<T>(this SettersContext<T> self,
        double maximumWidth)
        where T : Window
    {
        self.XamlSetters.Add(new Setter { Property = Window.MaximumWidthProperty, Value = maximumWidth });
        return self;
    }
    
    public static SettersContext<T> MaximumWidth<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Window
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Window.MaximumWidthProperty);
        configure(context).Build();
        return self;
    }
    
    public static T MaximumHeight<T>(this T self,
        double maximumHeight)
        where T : Window
    {
        self.SetValue(Window.MaximumHeightProperty, maximumHeight);
        return self;
    }
    
    public static T MaximumHeight<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Window
    {
        var context = new PropertyContext<double>(self, Window.MaximumHeightProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> MaximumHeight<T>(this SettersContext<T> self,
        double maximumHeight)
        where T : Window
    {
        self.XamlSetters.Add(new Setter { Property = Window.MaximumHeightProperty, Value = maximumHeight });
        return self;
    }
    
    public static SettersContext<T> MaximumHeight<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Window
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Window.MaximumHeightProperty);
        configure(context).Build();
        return self;
    }
    
    public static T MinimumWidth<T>(this T self,
        double minimumWidth)
        where T : Window
    {
        self.SetValue(Window.MinimumWidthProperty, minimumWidth);
        return self;
    }
    
    public static T MinimumWidth<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Window
    {
        var context = new PropertyContext<double>(self, Window.MinimumWidthProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> MinimumWidth<T>(this SettersContext<T> self,
        double minimumWidth)
        where T : Window
    {
        self.XamlSetters.Add(new Setter { Property = Window.MinimumWidthProperty, Value = minimumWidth });
        return self;
    }
    
    public static SettersContext<T> MinimumWidth<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Window
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Window.MinimumWidthProperty);
        configure(context).Build();
        return self;
    }
    
    public static T MinimumHeight<T>(this T self,
        double minimumHeight)
        where T : Window
    {
        self.SetValue(Window.MinimumHeightProperty, minimumHeight);
        return self;
    }
    
    public static T MinimumHeight<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Window
    {
        var context = new PropertyContext<double>(self, Window.MinimumHeightProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> MinimumHeight<T>(this SettersContext<T> self,
        double minimumHeight)
        where T : Window
    {
        self.XamlSetters.Add(new Setter { Property = Window.MinimumHeightProperty, Value = minimumHeight });
        return self;
    }
    
    public static SettersContext<T> MinimumHeight<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Window
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Window.MinimumHeightProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FlowDirection<T>(this T self,
        FlowDirection flowDirection)
        where T : Window
    {
        self.SetValue(Window.FlowDirectionProperty, flowDirection);
        return self;
    }
    
    public static T FlowDirection<T>(this T self, Func<PropertyContext<FlowDirection>, IPropertyBuilder<FlowDirection>> configure)
        where T : Window
    {
        var context = new PropertyContext<FlowDirection>(self, Window.FlowDirectionProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FlowDirection<T>(this SettersContext<T> self,
        FlowDirection flowDirection)
        where T : Window
    {
        self.XamlSetters.Add(new Setter { Property = Window.FlowDirectionProperty, Value = flowDirection });
        return self;
    }
    
    public static SettersContext<T> FlowDirection<T>(this SettersContext<T> self, Func<PropertySettersContext<FlowDirection>, IPropertySettersBuilder<FlowDirection>> configure)
        where T : Window
    {
        var context = new PropertySettersContext<FlowDirection>(self.XamlSetters, Window.FlowDirectionProperty);
        configure(context).Build();
        return self;
    }
    
    public static T OnSizeChanged<T>(this T self, EventHandler? handler)
        where T : Window
    {
        self.SizeChanged += handler;
        return self;
    }
    
    public static T OnSizeChanged<T>(this T self, Action<T> action)
        where T : Window
    {
        self.SizeChanged += (o, arg) => action(self);
        return self;
    }
    
    public static T OnModalPopped<T>(this T self, EventHandler<ModalPoppedEventArgs>? handler)
        where T : Window
    {
        self.ModalPopped += handler;
        return self;
    }
    
    public static T OnModalPopped<T>(this T self, Action<T> action)
        where T : Window
    {
        self.ModalPopped += (o, arg) => action(self);
        return self;
    }
    
    public static T OnModalPopping<T>(this T self, EventHandler<ModalPoppingEventArgs>? handler)
        where T : Window
    {
        self.ModalPopping += handler;
        return self;
    }
    
    public static T OnModalPopping<T>(this T self, Action<T> action)
        where T : Window
    {
        self.ModalPopping += (o, arg) => action(self);
        return self;
    }
    
    public static T OnModalPushed<T>(this T self, EventHandler<ModalPushedEventArgs>? handler)
        where T : Window
    {
        self.ModalPushed += handler;
        return self;
    }
    
    public static T OnModalPushed<T>(this T self, Action<T> action)
        where T : Window
    {
        self.ModalPushed += (o, arg) => action(self);
        return self;
    }
    
    public static T OnModalPushing<T>(this T self, EventHandler<ModalPushingEventArgs>? handler)
        where T : Window
    {
        self.ModalPushing += handler;
        return self;
    }
    
    public static T OnModalPushing<T>(this T self, Action<T> action)
        where T : Window
    {
        self.ModalPushing += (o, arg) => action(self);
        return self;
    }
    
    public static T OnPopCanceled<T>(this T self, EventHandler? handler)
        where T : Window
    {
        self.PopCanceled += handler;
        return self;
    }
    
    public static T OnPopCanceled<T>(this T self, Action<T> action)
        where T : Window
    {
        self.PopCanceled += (o, arg) => action(self);
        return self;
    }
    
    public static T OnCreated<T>(this T self, EventHandler? handler)
        where T : Window
    {
        self.Created += handler;
        return self;
    }
    
    public static T OnCreated<T>(this T self, Action<T> action)
        where T : Window
    {
        self.Created += (o, arg) => action(self);
        return self;
    }
    
    public static T OnResumed<T>(this T self, EventHandler? handler)
        where T : Window
    {
        self.Resumed += handler;
        return self;
    }
    
    public static T OnResumed<T>(this T self, Action<T> action)
        where T : Window
    {
        self.Resumed += (o, arg) => action(self);
        return self;
    }
    
    public static T OnActivated<T>(this T self, EventHandler? handler)
        where T : Window
    {
        self.Activated += handler;
        return self;
    }
    
    public static T OnActivated<T>(this T self, Action<T> action)
        where T : Window
    {
        self.Activated += (o, arg) => action(self);
        return self;
    }
    
    public static T OnDeactivated<T>(this T self, EventHandler? handler)
        where T : Window
    {
        self.Deactivated += handler;
        return self;
    }
    
    public static T OnDeactivated<T>(this T self, Action<T> action)
        where T : Window
    {
        self.Deactivated += (o, arg) => action(self);
        return self;
    }
    
    public static T OnStopped<T>(this T self, EventHandler? handler)
        where T : Window
    {
        self.Stopped += handler;
        return self;
    }
    
    public static T OnStopped<T>(this T self, Action<T> action)
        where T : Window
    {
        self.Stopped += (o, arg) => action(self);
        return self;
    }
    
    public static T OnDestroying<T>(this T self, EventHandler? handler)
        where T : Window
    {
        self.Destroying += handler;
        return self;
    }
    
    public static T OnDestroying<T>(this T self, Action<T> action)
        where T : Window
    {
        self.Destroying += (o, arg) => action(self);
        return self;
    }
    
    public static T OnBackgrounding<T>(this T self, EventHandler<BackgroundingEventArgs>? handler)
        where T : Window
    {
        self.Backgrounding += handler;
        return self;
    }
    
    public static T OnBackgrounding<T>(this T self, Action<T> action)
        where T : Window
    {
        self.Backgrounding += (o, arg) => action(self);
        return self;
    }
    
    public static T OnDisplayDensityChanged<T>(this T self, EventHandler<DisplayDensityChangedEventArgs>? handler)
        where T : Window
    {
        self.DisplayDensityChanged += handler;
        return self;
    }
    
    public static T OnDisplayDensityChanged<T>(this T self, Action<T> action)
        where T : Window
    {
        self.DisplayDensityChanged += (o, arg) => action(self);
        return self;
    }
    
}
