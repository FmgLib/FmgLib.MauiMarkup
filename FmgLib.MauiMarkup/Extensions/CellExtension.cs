namespace FmgLib.MauiMarkup;

public static partial class CellExtension
{
    public static T ContextActionsFmg<T>(this T self,
        IList<MenuItem> contextActions)
        where T : Cell
    {
        foreach (var item in contextActions)
            self.ContextActions.Add(item);
        return self;
    }

    public static T ContextActionsFmg<T>(this T self,
        params MenuItem[] contextActions)
        where T : Cell
    {
        foreach (var item in contextActions)
            self.ContextActions.Add(item);
        return self;
    }
    
    public static T IsContextActionsLegacyModeEnabledFmg<T>(this T self,
        bool isContextActionsLegacyModeEnabled)
        where T : Cell
    {
        self.IsContextActionsLegacyModeEnabled = isContextActionsLegacyModeEnabled;
        return self;
    }
    
    public static T HeightFmg<T>(this T self,
        double height)
        where T : Cell
    {
        self.Height = height;
        return self;
    }
    
    public static T IsEnabledFmg<T>(this T self,
        bool isEnabled)
        where T : Cell
    {
        self.SetValue(Cell.IsEnabledProperty, isEnabled);
        return self;
    }
    
    public static T IsEnabledFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : Cell
    {
        var context = new PropertyContext<bool>(self, Cell.IsEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> IsEnabledFmg<T>(this SettersContext<T> self,
        bool isEnabled)
        where T : Cell
    {
        self.XamlSetters.Add(new Setter { Property = Cell.IsEnabledProperty, Value = isEnabled });
        return self;
    }
    
    public static SettersContext<T> IsEnabledFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : Cell
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, Cell.IsEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static T OnAppearingFmg<T>(this T self, EventHandler handler)
        where T : Cell
    {
        self.Appearing += handler;
        return self;
    }
    
    public static T OnAppearingFmg<T>(this T self, Action<T> action)
        where T : Cell
    {
        self.Appearing += (o, arg) => action(self);
        return self;
    }
    
    public static T OnDisappearingFmg<T>(this T self, EventHandler handler)
        where T : Cell
    {
        self.Disappearing += handler;
        return self;
    }
    
    public static T OnDisappearingFmg<T>(this T self, Action<T> action)
        where T : Cell
    {
        self.Disappearing += (o, arg) => action(self);
        return self;
    }
    
    public static T OnForceUpdateSizeRequestedFmg<T>(this T self, EventHandler handler)
        where T : Cell
    {
        self.ForceUpdateSizeRequested += handler;
        return self;
    }
    
    public static T OnForceUpdateSizeRequestedFmg<T>(this T self, Action<T> action)
        where T : Cell
    {
        self.ForceUpdateSizeRequested += (o, arg) => action(self);
        return self;
    }
    
    public static T OnTappedFmg<T>(this T self, EventHandler handler)
        where T : Cell
    {
        self.Tapped += handler;
        return self;
    }
    
    public static T OnTappedFmg<T>(this T self, Action<T> action)
        where T : Cell
    {
        self.Tapped += (o, arg) => action(self);
        return self;
    }
    
}