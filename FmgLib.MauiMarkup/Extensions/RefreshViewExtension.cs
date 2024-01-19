namespace FmgLib.MauiMarkup;



public static partial class RefreshViewExtension
{
    public static T IsRefreshingFmg<T>(this T self,
        bool isRefreshing)
        where T : RefreshView
    {
        self.SetValue(RefreshView.IsRefreshingProperty, isRefreshing);
        return self;
    }
    
    public static T IsRefreshingFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : RefreshView
    {
        var context = new PropertyContext<bool>(self, RefreshView.IsRefreshingProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> IsRefreshingFmg<T>(this SettersContext<T> self,
        bool isRefreshing)
        where T : RefreshView
    {
        self.XamlSetters.Add(new Setter { Property = RefreshView.IsRefreshingProperty, Value = isRefreshing });
        return self;
    }
    
    public static SettersContext<T> IsRefreshingFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : RefreshView
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, RefreshView.IsRefreshingProperty);
        configure(context).Build();
        return self;
    }
    
    public static T CommandFmg<T>(this T self,
        System.Windows.Input.ICommand command)
        where T : RefreshView
    {
        self.SetValue(RefreshView.CommandProperty, command);
        return self;
    }
    
    public static T CommandFmg<T>(this T self, Func<PropertyContext<System.Windows.Input.ICommand>, IPropertyBuilder<System.Windows.Input.ICommand>> configure)
        where T : RefreshView
    {
        var context = new PropertyContext<System.Windows.Input.ICommand>(self, RefreshView.CommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> CommandFmg<T>(this SettersContext<T> self,
        System.Windows.Input.ICommand command)
        where T : RefreshView
    {
        self.XamlSetters.Add(new Setter { Property = RefreshView.CommandProperty, Value = command });
        return self;
    }
    
    public static SettersContext<T> CommandFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<System.Windows.Input.ICommand>, IPropertySettersBuilder<System.Windows.Input.ICommand>> configure)
        where T : RefreshView
    {
        var context = new PropertySettersContext<System.Windows.Input.ICommand>(self.XamlSetters, RefreshView.CommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static T CommandParameterFmg<T>(this T self,
        object commandParameter)
        where T : RefreshView
    {
        self.SetValue(RefreshView.CommandParameterProperty, commandParameter);
        return self;
    }
    
    public static T CommandParameterFmg<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        where T : RefreshView
    {
        var context = new PropertyContext<object>(self, RefreshView.CommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> CommandParameterFmg<T>(this SettersContext<T> self,
        object commandParameter)
        where T : RefreshView
    {
        self.XamlSetters.Add(new Setter { Property = RefreshView.CommandParameterProperty, Value = commandParameter });
        return self;
    }
    
    public static SettersContext<T> CommandParameterFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        where T : RefreshView
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, RefreshView.CommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static T RefreshColorFmg<T>(this T self,
        Color refreshColor)
        where T : RefreshView
    {
        self.SetValue(RefreshView.RefreshColorProperty, refreshColor);
        return self;
    }
    
    public static T RefreshColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : RefreshView
    {
        var context = new PropertyContext<Color>(self, RefreshView.RefreshColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> RefreshColorFmg<T>(this SettersContext<T> self,
        Color refreshColor)
        where T : RefreshView
    {
        self.XamlSetters.Add(new Setter { Property = RefreshView.RefreshColorProperty, Value = refreshColor });
        return self;
    }
    
    public static SettersContext<T> RefreshColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : RefreshView
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, RefreshView.RefreshColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateRefreshColorToFmg<T>(this T self, Color value, uint length = 250, Easing? easing = null)
        where T : RefreshView
    {
        Color fromValue = self.RefreshColor;
        var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
        var callback = (Color actValue) => { self.RefreshColor = actValue; };
        return Transformations.AnimateAsync<Color>(self, "AnimateRefreshColorTo", transform, callback, length, easing);
    }
    
    public static T OnRefreshingFmg<T>(this T self, EventHandler handler)
        where T : RefreshView
    {
        self.Refreshing += handler;
        return self;
    }
    
    public static T OnRefreshingFmg<T>(this T self, Action<T> action)
        where T : RefreshView
    {
        self.Refreshing += (o, arg) => action(self);
        return self;
    }
    
}
