namespace FmgLib.MauiMarkup;



public static partial class RefreshViewExtension
{
    public static T IsRefreshEnabled<T>(this T self,
        bool isRefreshEnabled)
        where T : RefreshView
    {
        self.SetValue(RefreshView.IsRefreshEnabledProperty, isRefreshEnabled);
        return self;
    }

    public static T IsRefreshEnabled<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : RefreshView
    {
        var context = new PropertyContext<bool>(self, RefreshView.IsRefreshEnabledProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IsRefreshEnabled<T>(this SettersContext<T> self,
        bool isRefreshEnabled)
        where T : RefreshView
    {
        self.XamlSetters.Add(new Setter { Property = RefreshView.IsRefreshEnabledProperty, Value = isRefreshEnabled });
        return self;
    }

    public static SettersContext<T> IsRefreshEnabled<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : RefreshView
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, RefreshView.IsRefreshEnabledProperty);
        configure(context).Build();
        return self;
    }

    public static T IsRefreshing<T>(this T self,
        bool isRefreshing)
        where T : RefreshView
    {
        self.SetValue(RefreshView.IsRefreshingProperty, isRefreshing);
        return self;
    }
    
    public static T IsRefreshing<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : RefreshView
    {
        var context = new PropertyContext<bool>(self, RefreshView.IsRefreshingProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> IsRefreshing<T>(this SettersContext<T> self,
        bool isRefreshing)
        where T : RefreshView
    {
        self.XamlSetters.Add(new Setter { Property = RefreshView.IsRefreshingProperty, Value = isRefreshing });
        return self;
    }
    
    public static SettersContext<T> IsRefreshing<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : RefreshView
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, RefreshView.IsRefreshingProperty);
        configure(context).Build();
        return self;
    }
    
    public static T Command<T>(this T self,
        System.Windows.Input.ICommand command)
        where T : RefreshView
    {
        self.SetValue(RefreshView.CommandProperty, command);
        return self;
    }
    
    public static T Command<T>(this T self, Func<PropertyContext<System.Windows.Input.ICommand>, IPropertyBuilder<System.Windows.Input.ICommand>> configure)
        where T : RefreshView
    {
        var context = new PropertyContext<System.Windows.Input.ICommand>(self, RefreshView.CommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Command<T>(this SettersContext<T> self,
        System.Windows.Input.ICommand command)
        where T : RefreshView
    {
        self.XamlSetters.Add(new Setter { Property = RefreshView.CommandProperty, Value = command });
        return self;
    }
    
    public static SettersContext<T> Command<T>(this SettersContext<T> self, Func<PropertySettersContext<System.Windows.Input.ICommand>, IPropertySettersBuilder<System.Windows.Input.ICommand>> configure)
        where T : RefreshView
    {
        var context = new PropertySettersContext<System.Windows.Input.ICommand>(self.XamlSetters, RefreshView.CommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static T CommandParameter<T>(this T self,
        object commandParameter)
        where T : RefreshView
    {
        self.SetValue(RefreshView.CommandParameterProperty, commandParameter);
        return self;
    }
    
    public static T CommandParameter<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        where T : RefreshView
    {
        var context = new PropertyContext<object>(self, RefreshView.CommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> CommandParameter<T>(this SettersContext<T> self,
        object commandParameter)
        where T : RefreshView
    {
        self.XamlSetters.Add(new Setter { Property = RefreshView.CommandParameterProperty, Value = commandParameter });
        return self;
    }
    
    public static SettersContext<T> CommandParameter<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        where T : RefreshView
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, RefreshView.CommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static T RefreshColor<T>(this T self,
        Color refreshColor)
        where T : RefreshView
    {
        self.SetValue(RefreshView.RefreshColorProperty, refreshColor);
        return self;
    }
    
    public static T RefreshColor<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : RefreshView
    {
        var context = new PropertyContext<Color>(self, RefreshView.RefreshColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> RefreshColor<T>(this SettersContext<T> self,
        Color refreshColor)
        where T : RefreshView
    {
        self.XamlSetters.Add(new Setter { Property = RefreshView.RefreshColorProperty, Value = refreshColor });
        return self;
    }
    
    public static SettersContext<T> RefreshColor<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : RefreshView
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, RefreshView.RefreshColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateRefreshColorTo<T>(this T self, Color value, uint length = 250, Easing? easing = null)
        where T : RefreshView
    {
        Color fromValue = self.RefreshColor;
        var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
        var callback = (Color actValue) => { self.RefreshColor = actValue; };
        return Transformations.AnimateAsync<Color>(self, "AnimateRefreshColorTo", transform, callback, length, easing);
    }
    
    public static T OnRefreshing<T>(this T self, EventHandler handler)
        where T : RefreshView
    {
        self.Refreshing += handler;
        return self;
    }
    
    public static T OnRefreshing<T>(this T self, Action<T> action)
        where T : RefreshView
    {
        self.Refreshing += (o, arg) => action(self);
        return self;
    }
    
}
