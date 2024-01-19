namespace FmgLib.MauiMarkup;



public static partial class SwipeItemViewExtension
{
    public static T Command<T>(this T self,
        System.Windows.Input.ICommand command)
        where T : SwipeItemView
    {
        self.SetValue(SwipeItemView.CommandProperty, command);
        return self;
    }
    
    public static T Command<T>(this T self, Func<PropertyContext<System.Windows.Input.ICommand>, IPropertyBuilder<System.Windows.Input.ICommand>> configure)
        where T : SwipeItemView
    {
        var context = new PropertyContext<System.Windows.Input.ICommand>(self, SwipeItemView.CommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Command<T>(this SettersContext<T> self,
        System.Windows.Input.ICommand command)
        where T : SwipeItemView
    {
        self.XamlSetters.Add(new Setter { Property = SwipeItemView.CommandProperty, Value = command });
        return self;
    }
    
    public static SettersContext<T> Command<T>(this SettersContext<T> self, Func<PropertySettersContext<System.Windows.Input.ICommand>, IPropertySettersBuilder<System.Windows.Input.ICommand>> configure)
        where T : SwipeItemView
    {
        var context = new PropertySettersContext<System.Windows.Input.ICommand>(self.XamlSetters, SwipeItemView.CommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static T CommandParameter<T>(this T self,
        object commandParameter)
        where T : SwipeItemView
    {
        self.SetValue(SwipeItemView.CommandParameterProperty, commandParameter);
        return self;
    }
    
    public static T CommandParameter<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        where T : SwipeItemView
    {
        var context = new PropertyContext<object>(self, SwipeItemView.CommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> CommandParameter<T>(this SettersContext<T> self,
        object commandParameter)
        where T : SwipeItemView
    {
        self.XamlSetters.Add(new Setter { Property = SwipeItemView.CommandParameterProperty, Value = commandParameter });
        return self;
    }
    
    public static SettersContext<T> CommandParameter<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        where T : SwipeItemView
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, SwipeItemView.CommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static T OnInvoked<T>(this T self, EventHandler<EventArgs> handler)
        where T : SwipeItemView
    {
        self.Invoked += handler;
        return self;
    }
    
    public static T OnInvoked<T>(this T self, Action<T> action)
        where T : SwipeItemView
    {
        self.Invoked += (o, arg) => action(self);
        return self;
    }
    
}
