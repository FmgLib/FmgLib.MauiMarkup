namespace FmgLib.MauiMarkup;

public static partial class ClickGestureRecognizerExtension
{
    public static ClickGestureRecognizer Command(this ClickGestureRecognizer self,
        System.Windows.Input.ICommand command)
    {
        self.SetValue(ClickGestureRecognizer.CommandProperty, command);
        return self;
    }
    
    public static ClickGestureRecognizer Command(this ClickGestureRecognizer self, Func<PropertyContext<System.Windows.Input.ICommand>, IPropertyBuilder<System.Windows.Input.ICommand>> configure)
    {
        var context = new PropertyContext<System.Windows.Input.ICommand>(self, ClickGestureRecognizer.CommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<ClickGestureRecognizer> Command(this SettersContext<ClickGestureRecognizer> self,
        System.Windows.Input.ICommand command)
    {
        self.XamlSetters.Add(new Setter { Property = ClickGestureRecognizer.CommandProperty, Value = command });
        return self;
    }
    
    public static SettersContext<ClickGestureRecognizer> Command(this SettersContext<ClickGestureRecognizer> self, Func<PropertySettersContext<System.Windows.Input.ICommand>, IPropertySettersBuilder<System.Windows.Input.ICommand>> configure)
    {
        var context = new PropertySettersContext<System.Windows.Input.ICommand>(self.XamlSetters, ClickGestureRecognizer.CommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static ClickGestureRecognizer CommandParameter(this ClickGestureRecognizer self,
        object commandParameter)
    {
        self.SetValue(ClickGestureRecognizer.CommandParameterProperty, commandParameter);
        return self;
    }
    
    public static ClickGestureRecognizer CommandParameter(this ClickGestureRecognizer self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
    {
        var context = new PropertyContext<object>(self, ClickGestureRecognizer.CommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<ClickGestureRecognizer> CommandParameter(this SettersContext<ClickGestureRecognizer> self,
        object commandParameter)
    {
        self.XamlSetters.Add(new Setter { Property = ClickGestureRecognizer.CommandParameterProperty, Value = commandParameter });
        return self;
    }
    
    public static SettersContext<ClickGestureRecognizer> CommandParameter(this SettersContext<ClickGestureRecognizer> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, ClickGestureRecognizer.CommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static ClickGestureRecognizer NumberOfClicksRequired(this ClickGestureRecognizer self,
        int numberOfClicksRequired)
    {
        self.SetValue(ClickGestureRecognizer.NumberOfClicksRequiredProperty, numberOfClicksRequired);
        return self;
    }
    
    public static ClickGestureRecognizer NumberOfClicksRequired(this ClickGestureRecognizer self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
    {
        var context = new PropertyContext<int>(self, ClickGestureRecognizer.NumberOfClicksRequiredProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<ClickGestureRecognizer> NumberOfClicksRequired(this SettersContext<ClickGestureRecognizer> self,
        int numberOfClicksRequired)
    {
        self.XamlSetters.Add(new Setter { Property = ClickGestureRecognizer.NumberOfClicksRequiredProperty, Value = numberOfClicksRequired });
        return self;
    }
    
    public static SettersContext<ClickGestureRecognizer> NumberOfClicksRequired(this SettersContext<ClickGestureRecognizer> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure)
    {
        var context = new PropertySettersContext<int>(self.XamlSetters, ClickGestureRecognizer.NumberOfClicksRequiredProperty);
        configure(context).Build();
        return self;
    }
    
    public static ClickGestureRecognizer Buttons(this ClickGestureRecognizer self,
        ButtonsMask buttons)
    {
        self.SetValue(ClickGestureRecognizer.ButtonsProperty, buttons);
        return self;
    }
    
    public static ClickGestureRecognizer Buttons(this ClickGestureRecognizer self, Func<PropertyContext<ButtonsMask>, IPropertyBuilder<ButtonsMask>> configure)
    {
        var context = new PropertyContext<ButtonsMask>(self, ClickGestureRecognizer.ButtonsProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<ClickGestureRecognizer> Buttons(this SettersContext<ClickGestureRecognizer> self,
        ButtonsMask buttons)
    {
        self.XamlSetters.Add(new Setter { Property = ClickGestureRecognizer.ButtonsProperty, Value = buttons });
        return self;
    }
    
    public static SettersContext<ClickGestureRecognizer> Buttons(this SettersContext<ClickGestureRecognizer> self, Func<PropertySettersContext<ButtonsMask>, IPropertySettersBuilder<ButtonsMask>> configure)
    {
        var context = new PropertySettersContext<ButtonsMask>(self.XamlSetters, ClickGestureRecognizer.ButtonsProperty);
        configure(context).Build();
        return self;
    }
    
    public static ClickGestureRecognizer OnClicked(this ClickGestureRecognizer self, EventHandler handler)
    {
        self.Clicked += handler;
        return self;
    }
    
    public static ClickGestureRecognizer OnClicked(this ClickGestureRecognizer self, Action<ClickGestureRecognizer> action)
    {
        self.Clicked += (o, arg) => action(self);
        return self;
    }
    
}