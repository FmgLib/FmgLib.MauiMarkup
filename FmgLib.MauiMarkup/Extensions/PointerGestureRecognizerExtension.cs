namespace FmgLib.MauiMarkup;



public static partial class PointerGestureRecognizerExtension
{
    public static PointerGestureRecognizer PointerEnteredCommandFmg(this PointerGestureRecognizer self,
        System.Windows.Input.ICommand pointerEnteredCommand)
    {
        self.SetValue(PointerGestureRecognizer.PointerEnteredCommandProperty, pointerEnteredCommand);
        return self;
    }
    
    public static PointerGestureRecognizer PointerEnteredCommandFmg(this PointerGestureRecognizer self, Func<PropertyContext<System.Windows.Input.ICommand>, IPropertyBuilder<System.Windows.Input.ICommand>> configure)
    {
        var context = new PropertyContext<System.Windows.Input.ICommand>(self, PointerGestureRecognizer.PointerEnteredCommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<PointerGestureRecognizer> PointerEnteredCommandFmg(this SettersContext<PointerGestureRecognizer> self,
        System.Windows.Input.ICommand pointerEnteredCommand)
    {
        self.XamlSetters.Add(new Setter { Property = PointerGestureRecognizer.PointerEnteredCommandProperty, Value = pointerEnteredCommand });
        return self;
    }
    
    public static SettersContext<PointerGestureRecognizer> PointerEnteredCommandFmg(this SettersContext<PointerGestureRecognizer> self, Func<PropertySettersContext<System.Windows.Input.ICommand>, IPropertySettersBuilder<System.Windows.Input.ICommand>> configure)
    {
        var context = new PropertySettersContext<System.Windows.Input.ICommand>(self.XamlSetters, PointerGestureRecognizer.PointerEnteredCommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static PointerGestureRecognizer PointerEnteredCommandParameterFmg(this PointerGestureRecognizer self,
        System.Windows.Input.ICommand pointerEnteredCommandParameter)
    {
        self.SetValue(PointerGestureRecognizer.PointerEnteredCommandParameterProperty, pointerEnteredCommandParameter);
        return self;
    }
    
    public static PointerGestureRecognizer PointerEnteredCommandParameterFmg(this PointerGestureRecognizer self, Func<PropertyContext<System.Windows.Input.ICommand>, IPropertyBuilder<System.Windows.Input.ICommand>> configure)
    {
        var context = new PropertyContext<System.Windows.Input.ICommand>(self, PointerGestureRecognizer.PointerEnteredCommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<PointerGestureRecognizer> PointerEnteredCommandParameterFmg(this SettersContext<PointerGestureRecognizer> self,
        System.Windows.Input.ICommand pointerEnteredCommandParameter)
    {
        self.XamlSetters.Add(new Setter { Property = PointerGestureRecognizer.PointerEnteredCommandParameterProperty, Value = pointerEnteredCommandParameter });
        return self;
    }
    
    public static SettersContext<PointerGestureRecognizer> PointerEnteredCommandParameterFmg(this SettersContext<PointerGestureRecognizer> self, Func<PropertySettersContext<System.Windows.Input.ICommand>, IPropertySettersBuilder<System.Windows.Input.ICommand>> configure)
    {
        var context = new PropertySettersContext<System.Windows.Input.ICommand>(self.XamlSetters, PointerGestureRecognizer.PointerEnteredCommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static PointerGestureRecognizer PointerExitedCommandFmg(this PointerGestureRecognizer self,
        System.Windows.Input.ICommand pointerExitedCommand)
    {
        self.SetValue(PointerGestureRecognizer.PointerExitedCommandProperty, pointerExitedCommand);
        return self;
    }
    
    public static PointerGestureRecognizer PointerExitedCommandFmg(this PointerGestureRecognizer self, Func<PropertyContext<System.Windows.Input.ICommand>, IPropertyBuilder<System.Windows.Input.ICommand>> configure)
    {
        var context = new PropertyContext<System.Windows.Input.ICommand>(self, PointerGestureRecognizer.PointerExitedCommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<PointerGestureRecognizer> PointerExitedCommandFmg(this SettersContext<PointerGestureRecognizer> self,
        System.Windows.Input.ICommand pointerExitedCommand)
    {
        self.XamlSetters.Add(new Setter { Property = PointerGestureRecognizer.PointerExitedCommandProperty, Value = pointerExitedCommand });
        return self;
    }
    
    public static SettersContext<PointerGestureRecognizer> PointerExitedCommandFmg(this SettersContext<PointerGestureRecognizer> self, Func<PropertySettersContext<System.Windows.Input.ICommand>, IPropertySettersBuilder<System.Windows.Input.ICommand>> configure)
    {
        var context = new PropertySettersContext<System.Windows.Input.ICommand>(self.XamlSetters, PointerGestureRecognizer.PointerExitedCommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static PointerGestureRecognizer PointerExitedCommandParameterFmg(this PointerGestureRecognizer self,
        System.Windows.Input.ICommand pointerExitedCommandParameter)
    {
        self.SetValue(PointerGestureRecognizer.PointerExitedCommandParameterProperty, pointerExitedCommandParameter);
        return self;
    }
    
    public static PointerGestureRecognizer PointerExitedCommandParameterFmg(this PointerGestureRecognizer self, Func<PropertyContext<System.Windows.Input.ICommand>, IPropertyBuilder<System.Windows.Input.ICommand>> configure)
    {
        var context = new PropertyContext<System.Windows.Input.ICommand>(self, PointerGestureRecognizer.PointerExitedCommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<PointerGestureRecognizer> PointerExitedCommandParameterFmg(this SettersContext<PointerGestureRecognizer> self,
        System.Windows.Input.ICommand pointerExitedCommandParameter)
    {
        self.XamlSetters.Add(new Setter { Property = PointerGestureRecognizer.PointerExitedCommandParameterProperty, Value = pointerExitedCommandParameter });
        return self;
    }
    
    public static SettersContext<PointerGestureRecognizer> PointerExitedCommandParameterFmg(this SettersContext<PointerGestureRecognizer> self, Func<PropertySettersContext<System.Windows.Input.ICommand>, IPropertySettersBuilder<System.Windows.Input.ICommand>> configure)
    {
        var context = new PropertySettersContext<System.Windows.Input.ICommand>(self.XamlSetters, PointerGestureRecognizer.PointerExitedCommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static PointerGestureRecognizer PointerMovedCommandFmg(this PointerGestureRecognizer self,
        System.Windows.Input.ICommand pointerMovedCommand)
    {
        self.SetValue(PointerGestureRecognizer.PointerMovedCommandProperty, pointerMovedCommand);
        return self;
    }
    
    public static PointerGestureRecognizer PointerMovedCommandFmg(this PointerGestureRecognizer self, Func<PropertyContext<System.Windows.Input.ICommand>, IPropertyBuilder<System.Windows.Input.ICommand>> configure)
    {
        var context = new PropertyContext<System.Windows.Input.ICommand>(self, PointerGestureRecognizer.PointerMovedCommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<PointerGestureRecognizer> PointerMovedCommandFmg(this SettersContext<PointerGestureRecognizer> self,
        System.Windows.Input.ICommand pointerMovedCommand)
    {
        self.XamlSetters.Add(new Setter { Property = PointerGestureRecognizer.PointerMovedCommandProperty, Value = pointerMovedCommand });
        return self;
    }
    
    public static SettersContext<PointerGestureRecognizer> PointerMovedCommandFmg(this SettersContext<PointerGestureRecognizer> self, Func<PropertySettersContext<System.Windows.Input.ICommand>, IPropertySettersBuilder<System.Windows.Input.ICommand>> configure)
    {
        var context = new PropertySettersContext<System.Windows.Input.ICommand>(self.XamlSetters, PointerGestureRecognizer.PointerMovedCommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static PointerGestureRecognizer PointerMovedCommandParameterFmg(this PointerGestureRecognizer self,
        System.Windows.Input.ICommand pointerMovedCommandParameter)
    {
        self.SetValue(PointerGestureRecognizer.PointerMovedCommandParameterProperty, pointerMovedCommandParameter);
        return self;
    }
    
    public static PointerGestureRecognizer PointerMovedCommandParameterFmg(this PointerGestureRecognizer self, Func<PropertyContext<System.Windows.Input.ICommand>, IPropertyBuilder<System.Windows.Input.ICommand>> configure)
    {
        var context = new PropertyContext<System.Windows.Input.ICommand>(self, PointerGestureRecognizer.PointerMovedCommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<PointerGestureRecognizer> PointerMovedCommandParameterFmg(this SettersContext<PointerGestureRecognizer> self,
        System.Windows.Input.ICommand pointerMovedCommandParameter)
    {
        self.XamlSetters.Add(new Setter { Property = PointerGestureRecognizer.PointerMovedCommandParameterProperty, Value = pointerMovedCommandParameter });
        return self;
    }
    
    public static SettersContext<PointerGestureRecognizer> PointerMovedCommandParameterFmg(this SettersContext<PointerGestureRecognizer> self, Func<PropertySettersContext<System.Windows.Input.ICommand>, IPropertySettersBuilder<System.Windows.Input.ICommand>> configure)
    {
        var context = new PropertySettersContext<System.Windows.Input.ICommand>(self.XamlSetters, PointerGestureRecognizer.PointerMovedCommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static PointerGestureRecognizer OnPointerEnteredFmg(this PointerGestureRecognizer self, EventHandler<PointerEventArgs>? handler)
    {
        self.PointerEntered += handler;
        return self;
    }
    
    public static PointerGestureRecognizer OnPointerEnteredFmg(this PointerGestureRecognizer self, Action<PointerGestureRecognizer> action)
    {
        self.PointerEntered += (o, arg) => action(self);
        return self;
    }
    
    public static PointerGestureRecognizer OnPointerExitedFmg(this PointerGestureRecognizer self, EventHandler<PointerEventArgs>? handler)
    {
        self.PointerExited += handler;
        return self;
    }
    
    public static PointerGestureRecognizer OnPointerExitedFmg(this PointerGestureRecognizer self, Action<PointerGestureRecognizer> action)
    {
        self.PointerExited += (o, arg) => action(self);
        return self;
    }
    
    public static PointerGestureRecognizer OnPointerMovedFmg(this PointerGestureRecognizer self, EventHandler<PointerEventArgs>? handler)
    {
        self.PointerMoved += handler;
        return self;
    }
    
    public static PointerGestureRecognizer OnPointerMovedFmg(this PointerGestureRecognizer self, Action<PointerGestureRecognizer> action)
    {
        self.PointerMoved += (o, arg) => action(self);
        return self;
    }
    
}
