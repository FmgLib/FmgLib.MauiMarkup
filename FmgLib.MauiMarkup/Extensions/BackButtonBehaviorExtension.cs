namespace FmgLib.MauiMarkup;

public static partial class BackButtonBehaviorExtension
{
    public static T CommandFmg<T>(this T self,
        System.Windows.Input.ICommand command)
        where T : BackButtonBehavior
    {
        self.SetValue(BackButtonBehavior.CommandProperty, command);
        return self;
    }
    
    public static T CommandFmg<T>(this T self, Func<PropertyContext<System.Windows.Input.ICommand>, IPropertyBuilder<System.Windows.Input.ICommand>> configure)
        where T : BackButtonBehavior
    {
        var context = new PropertyContext<System.Windows.Input.ICommand>(self, BackButtonBehavior.CommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> CommandFmg<T>(this SettersContext<T> self,
        System.Windows.Input.ICommand command)
        where T : BackButtonBehavior
    {
        self.XamlSetters.Add(new Setter { Property = BackButtonBehavior.CommandProperty, Value = command });
        return self;
    }
    
    public static SettersContext<T> CommandFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<System.Windows.Input.ICommand>, IPropertySettersBuilder<System.Windows.Input.ICommand>> configure)
        where T : BackButtonBehavior
    {
        var context = new PropertySettersContext<System.Windows.Input.ICommand>(self.XamlSetters, BackButtonBehavior.CommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static T CommandParameterFmg<T>(this T self,
        object commandParameter)
        where T : BackButtonBehavior
    {
        self.SetValue(BackButtonBehavior.CommandParameterProperty, commandParameter);
        return self;
    }
    
    public static T CommandParameterFmg<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        where T : BackButtonBehavior
    {
        var context = new PropertyContext<object>(self, BackButtonBehavior.CommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> CommandParameterFmg<T>(this SettersContext<T> self,
        object commandParameter)
        where T : BackButtonBehavior
    {
        self.XamlSetters.Add(new Setter { Property = BackButtonBehavior.CommandParameterProperty, Value = commandParameter });
        return self;
    }
    
    public static SettersContext<T> CommandParameterFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        where T : BackButtonBehavior
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, BackButtonBehavior.CommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static T IconOverrideFmg<T>(this T self,
        ImageSource iconOverride)
        where T : BackButtonBehavior
    {
        self.SetValue(BackButtonBehavior.IconOverrideProperty, iconOverride);
        return self;
    }
    
    public static T IconOverrideFmg<T>(this T self, Func<PropertyContext<ImageSource>, IPropertyBuilder<ImageSource>> configure)
        where T : BackButtonBehavior
    {
        var context = new PropertyContext<ImageSource>(self, BackButtonBehavior.IconOverrideProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> IconOverrideFmg<T>(this SettersContext<T> self,
        ImageSource iconOverride)
        where T : BackButtonBehavior
    {
        self.XamlSetters.Add(new Setter { Property = BackButtonBehavior.IconOverrideProperty, Value = iconOverride });
        return self;
    }
    
    public static SettersContext<T> IconOverrideFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ImageSource>, IPropertySettersBuilder<ImageSource>> configure)
        where T : BackButtonBehavior
    {
        var context = new PropertySettersContext<ImageSource>(self.XamlSetters, BackButtonBehavior.IconOverrideProperty);
        configure(context).Build();
        return self;
    }
    
    public static T IsEnabledFmg<T>(this T self,
        bool isEnabled)
        where T : BackButtonBehavior
    {
        self.SetValue(BackButtonBehavior.IsEnabledProperty, isEnabled);
        return self;
    }
    
    public static T IsEnabledFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : BackButtonBehavior
    {
        var context = new PropertyContext<bool>(self, BackButtonBehavior.IsEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> IsEnabledFmg<T>(this SettersContext<T> self,
        bool isEnabled)
        where T : BackButtonBehavior
    {
        self.XamlSetters.Add(new Setter { Property = BackButtonBehavior.IsEnabledProperty, Value = isEnabled });
        return self;
    }
    
    public static SettersContext<T> IsEnabledFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : BackButtonBehavior
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, BackButtonBehavior.IsEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static T IsVisibleFmg<T>(this T self,
        bool isVisible)
        where T : BackButtonBehavior
    {
        self.SetValue(BackButtonBehavior.IsVisibleProperty, isVisible);
        return self;
    }
    
    public static T IsVisibleFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : BackButtonBehavior
    {
        var context = new PropertyContext<bool>(self, BackButtonBehavior.IsVisibleProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> IsVisibleFmg<T>(this SettersContext<T> self,
        bool isVisible)
        where T : BackButtonBehavior
    {
        self.XamlSetters.Add(new Setter { Property = BackButtonBehavior.IsVisibleProperty, Value = isVisible });
        return self;
    }
    
    public static SettersContext<T> IsVisibleFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : BackButtonBehavior
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, BackButtonBehavior.IsVisibleProperty);
        configure(context).Build();
        return self;
    }
    
    public static T TextOverrideFmg<T>(this T self,
        string textOverride)
        where T : BackButtonBehavior
    {
        self.SetValue(BackButtonBehavior.TextOverrideProperty, textOverride);
        return self;
    }
    
    public static T TextOverrideFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : BackButtonBehavior
    {
        var context = new PropertyContext<string>(self, BackButtonBehavior.TextOverrideProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> TextOverrideFmg<T>(this SettersContext<T> self,
        string textOverride)
        where T : BackButtonBehavior
    {
        self.XamlSetters.Add(new Setter { Property = BackButtonBehavior.TextOverrideProperty, Value = textOverride });
        return self;
    }
    
    public static SettersContext<T> TextOverrideFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : BackButtonBehavior
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, BackButtonBehavior.TextOverrideProperty);
        configure(context).Build();
        return self;
    }
    
}