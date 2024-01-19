namespace FmgLib.MauiMarkup;



public static partial class SwipeGestureRecognizerExtension
{
    public static SwipeGestureRecognizer CommandFmg(this SwipeGestureRecognizer self,
        System.Windows.Input.ICommand command)
    {
        self.SetValue(SwipeGestureRecognizer.CommandProperty, command);
        return self;
    }
    
    public static SwipeGestureRecognizer CommandFmg(this SwipeGestureRecognizer self, Func<PropertyContext<System.Windows.Input.ICommand>, IPropertyBuilder<System.Windows.Input.ICommand>> configure)
    {
        var context = new PropertyContext<System.Windows.Input.ICommand>(self, SwipeGestureRecognizer.CommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<SwipeGestureRecognizer> CommandFmg(this SettersContext<SwipeGestureRecognizer> self,
        System.Windows.Input.ICommand command)
    {
        self.XamlSetters.Add(new Setter { Property = SwipeGestureRecognizer.CommandProperty, Value = command });
        return self;
    }
    
    public static SettersContext<SwipeGestureRecognizer> CommandFmg(this SettersContext<SwipeGestureRecognizer> self, Func<PropertySettersContext<System.Windows.Input.ICommand>, IPropertySettersBuilder<System.Windows.Input.ICommand>> configure)
    {
        var context = new PropertySettersContext<System.Windows.Input.ICommand>(self.XamlSetters, SwipeGestureRecognizer.CommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static SwipeGestureRecognizer CommandParameterFmg(this SwipeGestureRecognizer self,
        object commandParameter)
    {
        self.SetValue(SwipeGestureRecognizer.CommandParameterProperty, commandParameter);
        return self;
    }
    
    public static SwipeGestureRecognizer CommandParameterFmg(this SwipeGestureRecognizer self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
    {
        var context = new PropertyContext<object>(self, SwipeGestureRecognizer.CommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<SwipeGestureRecognizer> CommandParameterFmg(this SettersContext<SwipeGestureRecognizer> self,
        object commandParameter)
    {
        self.XamlSetters.Add(new Setter { Property = SwipeGestureRecognizer.CommandParameterProperty, Value = commandParameter });
        return self;
    }
    
    public static SettersContext<SwipeGestureRecognizer> CommandParameterFmg(this SettersContext<SwipeGestureRecognizer> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, SwipeGestureRecognizer.CommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static SwipeGestureRecognizer DirectionFmg(this SwipeGestureRecognizer self,
        Microsoft.Maui.SwipeDirection direction)
    {
        self.SetValue(SwipeGestureRecognizer.DirectionProperty, direction);
        return self;
    }
    
    public static SwipeGestureRecognizer DirectionFmg(this SwipeGestureRecognizer self, Func<PropertyContext<Microsoft.Maui.SwipeDirection>, IPropertyBuilder<Microsoft.Maui.SwipeDirection>> configure)
    {
        var context = new PropertyContext<Microsoft.Maui.SwipeDirection>(self, SwipeGestureRecognizer.DirectionProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<SwipeGestureRecognizer> DirectionFmg(this SettersContext<SwipeGestureRecognizer> self,
        Microsoft.Maui.SwipeDirection direction)
    {
        self.XamlSetters.Add(new Setter { Property = SwipeGestureRecognizer.DirectionProperty, Value = direction });
        return self;
    }
    
    public static SettersContext<SwipeGestureRecognizer> DirectionFmg(this SettersContext<SwipeGestureRecognizer> self, Func<PropertySettersContext<Microsoft.Maui.SwipeDirection>, IPropertySettersBuilder<Microsoft.Maui.SwipeDirection>> configure)
    {
        var context = new PropertySettersContext<Microsoft.Maui.SwipeDirection>(self.XamlSetters, SwipeGestureRecognizer.DirectionProperty);
        configure(context).Build();
        return self;
    }
    
    public static SwipeGestureRecognizer ThresholdFmg(this SwipeGestureRecognizer self,
        uint threshold)
    {
        self.SetValue(SwipeGestureRecognizer.ThresholdProperty, threshold);
        return self;
    }
    
    public static SwipeGestureRecognizer ThresholdFmg(this SwipeGestureRecognizer self, Func<PropertyContext<uint>, IPropertyBuilder<uint>> configure)
    {
        var context = new PropertyContext<uint>(self, SwipeGestureRecognizer.ThresholdProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<SwipeGestureRecognizer> ThresholdFmg(this SettersContext<SwipeGestureRecognizer> self,
        uint threshold)
    {
        self.XamlSetters.Add(new Setter { Property = SwipeGestureRecognizer.ThresholdProperty, Value = threshold });
        return self;
    }
    
    public static SettersContext<SwipeGestureRecognizer> ThresholdFmg(this SettersContext<SwipeGestureRecognizer> self, Func<PropertySettersContext<uint>, IPropertySettersBuilder<uint>> configure)
    {
        var context = new PropertySettersContext<uint>(self.XamlSetters, SwipeGestureRecognizer.ThresholdProperty);
        configure(context).Build();
        return self;
    }
    
    public static SwipeGestureRecognizer OnSwipedFmg(this SwipeGestureRecognizer self, EventHandler<SwipedEventArgs> handler)
    {
        self.Swiped += handler;
        return self;
    }
    
    public static SwipeGestureRecognizer OnSwipedFmg(this SwipeGestureRecognizer self, Action<SwipeGestureRecognizer> action)
    {
        self.Swiped += (o, arg) => action(self);
        return self;
    }
    
}
