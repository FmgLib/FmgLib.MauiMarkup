namespace FmgLib.MauiMarkup;



public static partial class MenuItemExtension
{
    public static T Command<T>(this T self,
        System.Windows.Input.ICommand command)
        where T : MenuItem
    {
        self.SetValue(MenuItem.CommandProperty, command);
        return self;
    }
    
    public static T Command<T>(this T self, Func<PropertyContext<System.Windows.Input.ICommand>, IPropertyBuilder<System.Windows.Input.ICommand>> configure)
        where T : MenuItem
    {
        var context = new PropertyContext<System.Windows.Input.ICommand>(self, MenuItem.CommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Command<T>(this SettersContext<T> self,
        System.Windows.Input.ICommand command)
        where T : MenuItem
    {
        self.XamlSetters.Add(new Setter { Property = MenuItem.CommandProperty, Value = command });
        return self;
    }
    
    public static SettersContext<T> Command<T>(this SettersContext<T> self, Func<PropertySettersContext<System.Windows.Input.ICommand>, IPropertySettersBuilder<System.Windows.Input.ICommand>> configure)
        where T : MenuItem
    {
        var context = new PropertySettersContext<System.Windows.Input.ICommand>(self.XamlSetters, MenuItem.CommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static T CommandParameter<T>(this T self,
        object commandParameter)
        where T : MenuItem
    {
        self.SetValue(MenuItem.CommandParameterProperty, commandParameter);
        return self;
    }
    
    public static T CommandParameter<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        where T : MenuItem
    {
        var context = new PropertyContext<object>(self, MenuItem.CommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> CommandParameter<T>(this SettersContext<T> self,
        object commandParameter)
        where T : MenuItem
    {
        self.XamlSetters.Add(new Setter { Property = MenuItem.CommandParameterProperty, Value = commandParameter });
        return self;
    }
    
    public static SettersContext<T> CommandParameter<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        where T : MenuItem
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, MenuItem.CommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static T IconImageSource<T>(this T self,
        ImageSource iconImageSource)
        where T : MenuItem
    {
        self.SetValue(MenuItem.IconImageSourceProperty, iconImageSource);
        return self;
    }
    
    public static T IconImageSource<T>(this T self, Func<PropertyContext<ImageSource>, IPropertyBuilder<ImageSource>> configure)
        where T : MenuItem
    {
        var context = new PropertyContext<ImageSource>(self, MenuItem.IconImageSourceProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> IconImageSource<T>(this SettersContext<T> self,
        ImageSource iconImageSource)
        where T : MenuItem
    {
        self.XamlSetters.Add(new Setter { Property = MenuItem.IconImageSourceProperty, Value = iconImageSource });
        return self;
    }
    
    public static SettersContext<T> IconImageSource<T>(this SettersContext<T> self, Func<PropertySettersContext<ImageSource>, IPropertySettersBuilder<ImageSource>> configure)
        where T : MenuItem
    {
        var context = new PropertySettersContext<ImageSource>(self.XamlSetters, MenuItem.IconImageSourceProperty);
        configure(context).Build();
        return self;
    }
    
    public static T IsDestructive<T>(this T self,
        bool isDestructive)
        where T : MenuItem
    {
        self.SetValue(MenuItem.IsDestructiveProperty, isDestructive);
        return self;
    }
    
    public static T IsDestructive<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : MenuItem
    {
        var context = new PropertyContext<bool>(self, MenuItem.IsDestructiveProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> IsDestructive<T>(this SettersContext<T> self,
        bool isDestructive)
        where T : MenuItem
    {
        self.XamlSetters.Add(new Setter { Property = MenuItem.IsDestructiveProperty, Value = isDestructive });
        return self;
    }
    
    public static SettersContext<T> IsDestructive<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : MenuItem
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, MenuItem.IsDestructiveProperty);
        configure(context).Build();
        return self;
    }
    
    public static T Text<T>(this T self,
        string text)
        where T : MenuItem
    {
        self.SetValue(MenuItem.TextProperty, text);
        return self;
    }
    
    public static T Text<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : MenuItem
    {
        var context = new PropertyContext<string>(self, MenuItem.TextProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Text<T>(this SettersContext<T> self,
        string text)
        where T : MenuItem
    {
        self.XamlSetters.Add(new Setter { Property = MenuItem.TextProperty, Value = text });
        return self;
    }
    
    public static SettersContext<T> Text<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : MenuItem
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, MenuItem.TextProperty);
        configure(context).Build();
        return self;
    }
    
    public static T IsEnabled<T>(this T self,
        bool isEnabled)
        where T : MenuItem
    {
        self.SetValue(MenuItem.IsEnabledProperty, isEnabled);
        return self;
    }
    
    public static T IsEnabled<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : MenuItem
    {
        var context = new PropertyContext<bool>(self, MenuItem.IsEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> IsEnabled<T>(this SettersContext<T> self,
        bool isEnabled)
        where T : MenuItem
    {
        self.XamlSetters.Add(new Setter { Property = MenuItem.IsEnabledProperty, Value = isEnabled });
        return self;
    }
    
    public static SettersContext<T> IsEnabled<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : MenuItem
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, MenuItem.IsEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static T StyleClass<T>(this T self,
        IList<string> styleClass)
        where T : MenuItem
    {
        foreach (var item in styleClass)
            self.StyleClass.Add(item);
        return self;
    }

    public static T StyleClass<T>(this T self,
        params string[] styleClass)
        where T : MenuItem
    {
        foreach (var item in styleClass)
            self.StyleClass.Add(item);
        return self;
    }
    
    public static T @class<T>(this T self,
        IList<string> @class)
        where T : MenuItem
    {
        foreach (var item in @class)
            self.@class.Add(item);
        return self;
    }

    public static T @class<T>(this T self,
        params string[] @class)
        where T : MenuItem
    {
        foreach (var item in @class)
            self.@class.Add(item);
        return self;
    }
    
    public static T OnClicked<T>(this T self, EventHandler handler)
        where T : MenuItem
    {
        self.Clicked += handler;
        return self;
    }
    
    public static T OnClicked<T>(this T self, Action<T> action)
        where T : MenuItem
    {
        self.Clicked += (o, arg) => action(self);
        return self;
    }
    
}
