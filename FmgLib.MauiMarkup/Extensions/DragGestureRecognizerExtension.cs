namespace FmgLib.MauiMarkup;

public static partial class DragGestureRecognizerExtension
{
    public static T CanDragFmg<T>(this T self,
        bool canDrag)
        where T : DragGestureRecognizer
    {
        self.SetValue(DragGestureRecognizer.CanDragProperty, canDrag);
        return self;
    }
    
    public static T CanDragFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : DragGestureRecognizer
    {
        var context = new PropertyContext<bool>(self, DragGestureRecognizer.CanDragProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> CanDragFmg<T>(this SettersContext<T> self,
        bool canDrag)
        where T : DragGestureRecognizer
    {
        self.XamlSetters.Add(new Setter { Property = DragGestureRecognizer.CanDragProperty, Value = canDrag });
        return self;
    }
    
    public static SettersContext<T> CanDragFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : DragGestureRecognizer
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, DragGestureRecognizer.CanDragProperty);
        configure(context).Build();
        return self;
    }
    
    public static T DropCompletedCommandFmg<T>(this T self,
        System.Windows.Input.ICommand dropCompletedCommand)
        where T : DragGestureRecognizer
    {
        self.SetValue(DragGestureRecognizer.DropCompletedCommandProperty, dropCompletedCommand);
        return self;
    }
    
    public static T DropCompletedCommandFmg<T>(this T self, Func<PropertyContext<System.Windows.Input.ICommand>, IPropertyBuilder<System.Windows.Input.ICommand>> configure)
        where T : DragGestureRecognizer
    {
        var context = new PropertyContext<System.Windows.Input.ICommand>(self, DragGestureRecognizer.DropCompletedCommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> DropCompletedCommandFmg<T>(this SettersContext<T> self,
        System.Windows.Input.ICommand dropCompletedCommand)
        where T : DragGestureRecognizer
    {
        self.XamlSetters.Add(new Setter { Property = DragGestureRecognizer.DropCompletedCommandProperty, Value = dropCompletedCommand });
        return self;
    }
    
    public static SettersContext<T> DropCompletedCommandFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<System.Windows.Input.ICommand>, IPropertySettersBuilder<System.Windows.Input.ICommand>> configure)
        where T : DragGestureRecognizer
    {
        var context = new PropertySettersContext<System.Windows.Input.ICommand>(self.XamlSetters, DragGestureRecognizer.DropCompletedCommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static T DropCompletedCommandParameterFmg<T>(this T self,
        object dropCompletedCommandParameter)
        where T : DragGestureRecognizer
    {
        self.SetValue(DragGestureRecognizer.DropCompletedCommandParameterProperty, dropCompletedCommandParameter);
        return self;
    }
    
    public static T DropCompletedCommandParameterFmg<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        where T : DragGestureRecognizer
    {
        var context = new PropertyContext<object>(self, DragGestureRecognizer.DropCompletedCommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> DropCompletedCommandParameterFmg<T>(this SettersContext<T> self,
        object dropCompletedCommandParameter)
        where T : DragGestureRecognizer
    {
        self.XamlSetters.Add(new Setter { Property = DragGestureRecognizer.DropCompletedCommandParameterProperty, Value = dropCompletedCommandParameter });
        return self;
    }
    
    public static SettersContext<T> DropCompletedCommandParameterFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        where T : DragGestureRecognizer
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, DragGestureRecognizer.DropCompletedCommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static T DragStartingCommandFmg<T>(this T self,
        System.Windows.Input.ICommand dragStartingCommand)
        where T : DragGestureRecognizer
    {
        self.SetValue(DragGestureRecognizer.DragStartingCommandProperty, dragStartingCommand);
        return self;
    }
    
    public static T DragStartingCommandFmg<T>(this T self, Func<PropertyContext<System.Windows.Input.ICommand>, IPropertyBuilder<System.Windows.Input.ICommand>> configure)
        where T : DragGestureRecognizer
    {
        var context = new PropertyContext<System.Windows.Input.ICommand>(self, DragGestureRecognizer.DragStartingCommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> DragStartingCommandFmg<T>(this SettersContext<T> self,
        System.Windows.Input.ICommand dragStartingCommand)
        where T : DragGestureRecognizer
    {
        self.XamlSetters.Add(new Setter { Property = DragGestureRecognizer.DragStartingCommandProperty, Value = dragStartingCommand });
        return self;
    }
    
    public static SettersContext<T> DragStartingCommandFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<System.Windows.Input.ICommand>, IPropertySettersBuilder<System.Windows.Input.ICommand>> configure)
        where T : DragGestureRecognizer
    {
        var context = new PropertySettersContext<System.Windows.Input.ICommand>(self.XamlSetters, DragGestureRecognizer.DragStartingCommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static T DragStartingCommandParameterFmg<T>(this T self,
        object dragStartingCommandParameter)
        where T : DragGestureRecognizer
    {
        self.SetValue(DragGestureRecognizer.DragStartingCommandParameterProperty, dragStartingCommandParameter);
        return self;
    }
    
    public static T DragStartingCommandParameterFmg<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        where T : DragGestureRecognizer
    {
        var context = new PropertyContext<object>(self, DragGestureRecognizer.DragStartingCommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> DragStartingCommandParameterFmg<T>(this SettersContext<T> self,
        object dragStartingCommandParameter)
        where T : DragGestureRecognizer
    {
        self.XamlSetters.Add(new Setter { Property = DragGestureRecognizer.DragStartingCommandParameterProperty, Value = dragStartingCommandParameter });
        return self;
    }
    
    public static SettersContext<T> DragStartingCommandParameterFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        where T : DragGestureRecognizer
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, DragGestureRecognizer.DragStartingCommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static T OnDropCompletedFmg<T>(this T self, EventHandler<DropCompletedEventArgs> handler)
        where T : DragGestureRecognizer
    {
        self.DropCompleted += handler;
        return self;
    }
    
    public static T OnDropCompletedFmg<T>(this T self, Action<T> action)
        where T : DragGestureRecognizer
    {
        self.DropCompleted += (o, arg) => action(self);
        return self;
    }
    
    public static T OnDragStartingFmg<T>(this T self, EventHandler<DragStartingEventArgs> handler)
        where T : DragGestureRecognizer
    {
        self.DragStarting += handler;
        return self;
    }
    
    public static T OnDragStartingFmg<T>(this T self, Action<T> action)
        where T : DragGestureRecognizer
    {
        self.DragStarting += (o, arg) => action(self);
        return self;
    }
    
}