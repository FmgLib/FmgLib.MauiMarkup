namespace FmgLib.MauiMarkup;



public static partial class TapGestureRecognizerExtension
{
    public static TapGestureRecognizer CommandFmg(this TapGestureRecognizer self,
        System.Windows.Input.ICommand? command)
    {
        self.SetValue(TapGestureRecognizer.CommandProperty, command);
        return self;
    }
    
    public static TapGestureRecognizer CommandFmg(this TapGestureRecognizer self, Func<PropertyContext<System.Windows.Input.ICommand?>, IPropertyBuilder<System.Windows.Input.ICommand?>> configure)
    {
        var context = new PropertyContext<System.Windows.Input.ICommand?>(self, TapGestureRecognizer.CommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<TapGestureRecognizer> CommandFmg(this SettersContext<TapGestureRecognizer> self,
        System.Windows.Input.ICommand? command)
    {
        self.XamlSetters.Add(new Setter { Property = TapGestureRecognizer.CommandProperty, Value = command });
        return self;
    }
    
    public static SettersContext<TapGestureRecognizer> CommandFmg(this SettersContext<TapGestureRecognizer> self, Func<PropertySettersContext<System.Windows.Input.ICommand?>, IPropertySettersBuilder<System.Windows.Input.ICommand?>> configure)
    {
        var context = new PropertySettersContext<System.Windows.Input.ICommand?>(self.XamlSetters, TapGestureRecognizer.CommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static TapGestureRecognizer CommandParameterFmg(this TapGestureRecognizer self,
        object? commandParameter)
    {
        self.SetValue(TapGestureRecognizer.CommandParameterProperty, commandParameter);
        return self;
    }
    
    public static TapGestureRecognizer CommandParameterFmg(this TapGestureRecognizer self, Func<PropertyContext<object?>, IPropertyBuilder<object?>> configure)
    {
        var context = new PropertyContext<object?>(self, TapGestureRecognizer.CommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<TapGestureRecognizer> CommandParameterFmg(this SettersContext<TapGestureRecognizer> self,
        object? commandParameter)
    {
        self.XamlSetters.Add(new Setter { Property = TapGestureRecognizer.CommandParameterProperty, Value = commandParameter });
        return self;
    }
    
    public static SettersContext<TapGestureRecognizer> CommandParameterFmg(this SettersContext<TapGestureRecognizer> self, Func<PropertySettersContext<object?>, IPropertySettersBuilder<object?>> configure)
    {
        var context = new PropertySettersContext<object?>(self.XamlSetters, TapGestureRecognizer.CommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static TapGestureRecognizer NumberOfTapsRequiredFmg(this TapGestureRecognizer self,
        int numberOfTapsRequired)
    {
        self.SetValue(TapGestureRecognizer.NumberOfTapsRequiredProperty, numberOfTapsRequired);
        return self;
    }
    
    public static TapGestureRecognizer NumberOfTapsRequiredFmg(this TapGestureRecognizer self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
    {
        var context = new PropertyContext<int>(self, TapGestureRecognizer.NumberOfTapsRequiredProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<TapGestureRecognizer> NumberOfTapsRequiredFmg(this SettersContext<TapGestureRecognizer> self,
        int numberOfTapsRequired)
    {
        self.XamlSetters.Add(new Setter { Property = TapGestureRecognizer.NumberOfTapsRequiredProperty, Value = numberOfTapsRequired });
        return self;
    }
    
    public static SettersContext<TapGestureRecognizer> NumberOfTapsRequiredFmg(this SettersContext<TapGestureRecognizer> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure)
    {
        var context = new PropertySettersContext<int>(self.XamlSetters, TapGestureRecognizer.NumberOfTapsRequiredProperty);
        configure(context).Build();
        return self;
    }
    
    public static TapGestureRecognizer ButtonsFmg(this TapGestureRecognizer self,
        ButtonsMask buttons)
    {
        self.SetValue(TapGestureRecognizer.ButtonsProperty, buttons);
        return self;
    }
    
    public static TapGestureRecognizer ButtonsFmg(this TapGestureRecognizer self, Func<PropertyContext<ButtonsMask>, IPropertyBuilder<ButtonsMask>> configure)
    {
        var context = new PropertyContext<ButtonsMask>(self, TapGestureRecognizer.ButtonsProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<TapGestureRecognizer> ButtonsFmg(this SettersContext<TapGestureRecognizer> self,
        ButtonsMask buttons)
    {
        self.XamlSetters.Add(new Setter { Property = TapGestureRecognizer.ButtonsProperty, Value = buttons });
        return self;
    }
    
    public static SettersContext<TapGestureRecognizer> ButtonsFmg(this SettersContext<TapGestureRecognizer> self, Func<PropertySettersContext<ButtonsMask>, IPropertySettersBuilder<ButtonsMask>> configure)
    {
        var context = new PropertySettersContext<ButtonsMask>(self.XamlSetters, TapGestureRecognizer.ButtonsProperty);
        configure(context).Build();
        return self;
    }
    
    public static TapGestureRecognizer OnTappedFmg(this TapGestureRecognizer self, EventHandler<TappedEventArgs>? handler)
    {
        self.Tapped += handler;
        return self;
    }
    
    public static TapGestureRecognizer OnTappedFmg(this TapGestureRecognizer self, Action<TapGestureRecognizer> action)
    {
        self.Tapped += (o, arg) => action(self);
        return self;
    }
    
}
