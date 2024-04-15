namespace FmgLib.MauiMarkup;



public static partial class PointerGestureRecognizerExtension
{
    public static PointerGestureRecognizer PointerEnteredCommand(this PointerGestureRecognizer self,
        System.Windows.Input.ICommand pointerEnteredCommand)
    {
        self.SetValue(PointerGestureRecognizer.PointerEnteredCommandProperty, pointerEnteredCommand);
        return self;
    }
    
    public static PointerGestureRecognizer PointerEnteredCommand(this PointerGestureRecognizer self, Func<PropertyContext<System.Windows.Input.ICommand>, IPropertyBuilder<System.Windows.Input.ICommand>> configure)
    {
        var context = new PropertyContext<System.Windows.Input.ICommand>(self, PointerGestureRecognizer.PointerEnteredCommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<PointerGestureRecognizer> PointerEnteredCommand(this SettersContext<PointerGestureRecognizer> self,
        System.Windows.Input.ICommand pointerEnteredCommand)
    {
        self.XamlSetters.Add(new Setter { Property = PointerGestureRecognizer.PointerEnteredCommandProperty, Value = pointerEnteredCommand });
        return self;
    }
    
    public static SettersContext<PointerGestureRecognizer> PointerEnteredCommand(this SettersContext<PointerGestureRecognizer> self, Func<PropertySettersContext<System.Windows.Input.ICommand>, IPropertySettersBuilder<System.Windows.Input.ICommand>> configure)
    {
        var context = new PropertySettersContext<System.Windows.Input.ICommand>(self.XamlSetters, PointerGestureRecognizer.PointerEnteredCommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static PointerGestureRecognizer PointerEnteredCommandParameter(this PointerGestureRecognizer self,
        System.Windows.Input.ICommand pointerEnteredCommandParameter)
    {
        self.SetValue(PointerGestureRecognizer.PointerEnteredCommandParameterProperty, pointerEnteredCommandParameter);
        return self;
    }
    
    public static PointerGestureRecognizer PointerEnteredCommandParameter(this PointerGestureRecognizer self, Func<PropertyContext<System.Windows.Input.ICommand>, IPropertyBuilder<System.Windows.Input.ICommand>> configure)
    {
        var context = new PropertyContext<System.Windows.Input.ICommand>(self, PointerGestureRecognizer.PointerEnteredCommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<PointerGestureRecognizer> PointerEnteredCommandParameter(this SettersContext<PointerGestureRecognizer> self,
        System.Windows.Input.ICommand pointerEnteredCommandParameter)
    {
        self.XamlSetters.Add(new Setter { Property = PointerGestureRecognizer.PointerEnteredCommandParameterProperty, Value = pointerEnteredCommandParameter });
        return self;
    }
    
    public static SettersContext<PointerGestureRecognizer> PointerEnteredCommandParameter(this SettersContext<PointerGestureRecognizer> self, Func<PropertySettersContext<System.Windows.Input.ICommand>, IPropertySettersBuilder<System.Windows.Input.ICommand>> configure)
    {
        var context = new PropertySettersContext<System.Windows.Input.ICommand>(self.XamlSetters, PointerGestureRecognizer.PointerEnteredCommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static PointerGestureRecognizer PointerExitedCommand(this PointerGestureRecognizer self,
        System.Windows.Input.ICommand pointerExitedCommand)
    {
        self.SetValue(PointerGestureRecognizer.PointerExitedCommandProperty, pointerExitedCommand);
        return self;
    }
    
    public static PointerGestureRecognizer PointerExitedCommand(this PointerGestureRecognizer self, Func<PropertyContext<System.Windows.Input.ICommand>, IPropertyBuilder<System.Windows.Input.ICommand>> configure)
    {
        var context = new PropertyContext<System.Windows.Input.ICommand>(self, PointerGestureRecognizer.PointerExitedCommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<PointerGestureRecognizer> PointerExitedCommand(this SettersContext<PointerGestureRecognizer> self,
        System.Windows.Input.ICommand pointerExitedCommand)
    {
        self.XamlSetters.Add(new Setter { Property = PointerGestureRecognizer.PointerExitedCommandProperty, Value = pointerExitedCommand });
        return self;
    }
    
    public static SettersContext<PointerGestureRecognizer> PointerExitedCommand(this SettersContext<PointerGestureRecognizer> self, Func<PropertySettersContext<System.Windows.Input.ICommand>, IPropertySettersBuilder<System.Windows.Input.ICommand>> configure)
    {
        var context = new PropertySettersContext<System.Windows.Input.ICommand>(self.XamlSetters, PointerGestureRecognizer.PointerExitedCommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static PointerGestureRecognizer PointerExitedCommandParameter(this PointerGestureRecognizer self,
        System.Windows.Input.ICommand pointerExitedCommandParameter)
    {
        self.SetValue(PointerGestureRecognizer.PointerExitedCommandParameterProperty, pointerExitedCommandParameter);
        return self;
    }
    
    public static PointerGestureRecognizer PointerExitedCommandParameter(this PointerGestureRecognizer self, Func<PropertyContext<System.Windows.Input.ICommand>, IPropertyBuilder<System.Windows.Input.ICommand>> configure)
    {
        var context = new PropertyContext<System.Windows.Input.ICommand>(self, PointerGestureRecognizer.PointerExitedCommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<PointerGestureRecognizer> PointerExitedCommandParameter(this SettersContext<PointerGestureRecognizer> self,
        System.Windows.Input.ICommand pointerExitedCommandParameter)
    {
        self.XamlSetters.Add(new Setter { Property = PointerGestureRecognizer.PointerExitedCommandParameterProperty, Value = pointerExitedCommandParameter });
        return self;
    }
    
    public static SettersContext<PointerGestureRecognizer> PointerExitedCommandParameter(this SettersContext<PointerGestureRecognizer> self, Func<PropertySettersContext<System.Windows.Input.ICommand>, IPropertySettersBuilder<System.Windows.Input.ICommand>> configure)
    {
        var context = new PropertySettersContext<System.Windows.Input.ICommand>(self.XamlSetters, PointerGestureRecognizer.PointerExitedCommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static PointerGestureRecognizer PointerMovedCommand(this PointerGestureRecognizer self,
        System.Windows.Input.ICommand pointerMovedCommand)
    {
        self.SetValue(PointerGestureRecognizer.PointerMovedCommandProperty, pointerMovedCommand);
        return self;
    }
    
    public static PointerGestureRecognizer PointerMovedCommand(this PointerGestureRecognizer self, Func<PropertyContext<System.Windows.Input.ICommand>, IPropertyBuilder<System.Windows.Input.ICommand>> configure)
    {
        var context = new PropertyContext<System.Windows.Input.ICommand>(self, PointerGestureRecognizer.PointerMovedCommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<PointerGestureRecognizer> PointerMovedCommand(this SettersContext<PointerGestureRecognizer> self,
        System.Windows.Input.ICommand pointerMovedCommand)
    {
        self.XamlSetters.Add(new Setter { Property = PointerGestureRecognizer.PointerMovedCommandProperty, Value = pointerMovedCommand });
        return self;
    }
    
    public static SettersContext<PointerGestureRecognizer> PointerMovedCommand(this SettersContext<PointerGestureRecognizer> self, Func<PropertySettersContext<System.Windows.Input.ICommand>, IPropertySettersBuilder<System.Windows.Input.ICommand>> configure)
    {
        var context = new PropertySettersContext<System.Windows.Input.ICommand>(self.XamlSetters, PointerGestureRecognizer.PointerMovedCommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static PointerGestureRecognizer PointerMovedCommandParameter(this PointerGestureRecognizer self,
        System.Windows.Input.ICommand pointerMovedCommandParameter)
    {
        self.SetValue(PointerGestureRecognizer.PointerMovedCommandParameterProperty, pointerMovedCommandParameter);
        return self;
    }
    
    public static PointerGestureRecognizer PointerMovedCommandParameter(this PointerGestureRecognizer self, Func<PropertyContext<System.Windows.Input.ICommand>, IPropertyBuilder<System.Windows.Input.ICommand>> configure)
    {
        var context = new PropertyContext<System.Windows.Input.ICommand>(self, PointerGestureRecognizer.PointerMovedCommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<PointerGestureRecognizer> PointerMovedCommandParameter(this SettersContext<PointerGestureRecognizer> self,
        System.Windows.Input.ICommand pointerMovedCommandParameter)
    {
        self.XamlSetters.Add(new Setter { Property = PointerGestureRecognizer.PointerMovedCommandParameterProperty, Value = pointerMovedCommandParameter });
        return self;
    }
    
    public static SettersContext<PointerGestureRecognizer> PointerMovedCommandParameter(this SettersContext<PointerGestureRecognizer> self, Func<PropertySettersContext<System.Windows.Input.ICommand>, IPropertySettersBuilder<System.Windows.Input.ICommand>> configure)
    {
        var context = new PropertySettersContext<System.Windows.Input.ICommand>(self.XamlSetters, PointerGestureRecognizer.PointerMovedCommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static PointerGestureRecognizer OnPointerEntered(this PointerGestureRecognizer self, EventHandler<PointerEventArgs>? handler)
    {
        self.PointerEntered += handler;
        return self;
    }
    
    public static PointerGestureRecognizer OnPointerEntered(this PointerGestureRecognizer self, Action<PointerGestureRecognizer> action)
    {
        self.PointerEntered += (o, arg) => action(self);
        return self;
    }
    
    public static PointerGestureRecognizer OnPointerExited(this PointerGestureRecognizer self, EventHandler<PointerEventArgs>? handler)
    {
        self.PointerExited += handler;
        return self;
    }
    
    public static PointerGestureRecognizer OnPointerExited(this PointerGestureRecognizer self, Action<PointerGestureRecognizer> action)
    {
        self.PointerExited += (o, arg) => action(self);
        return self;
    }
    
    public static PointerGestureRecognizer OnPointerMoved(this PointerGestureRecognizer self, EventHandler<PointerEventArgs>? handler)
    {
        self.PointerMoved += handler;
        return self;
    }
    
    public static PointerGestureRecognizer OnPointerMoved(this PointerGestureRecognizer self, Action<PointerGestureRecognizer> action)
    {
        self.PointerMoved += (o, arg) => action(self);
        return self;
    }
    
}
