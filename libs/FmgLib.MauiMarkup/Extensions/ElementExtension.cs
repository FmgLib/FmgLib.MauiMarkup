namespace FmgLib.MauiMarkup;

public static partial class ElementExtension
{
    public static T AutomationId<T>(this T self,
        string automationId)
        where T : Element
    {
        self.SetValue(Element.AutomationIdProperty, automationId);
        return self;
    }
    
    public static T AutomationId<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : Element
    {
        var context = new PropertyContext<string>(self, Element.AutomationIdProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> AutomationId<T>(this SettersContext<T> self,
        string automationId)
        where T : Element
    {
        self.XamlSetters.Add(new Setter { Property = Element.AutomationIdProperty, Value = automationId });
        return self;
    }
    
    public static SettersContext<T> AutomationId<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : Element
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, Element.AutomationIdProperty);
        configure(context).Build();
        return self;
    }
    
    public static T ClassId<T>(this T self,
        string classId)
        where T : Element
    {
        self.SetValue(Element.ClassIdProperty, classId);
        return self;
    }
    
    public static T ClassId<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : Element
    {
        var context = new PropertyContext<string>(self, Element.ClassIdProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ClassId<T>(this SettersContext<T> self,
        string classId)
        where T : Element
    {
        self.XamlSetters.Add(new Setter { Property = Element.ClassIdProperty, Value = classId });
        return self;
    }
    
    public static SettersContext<T> ClassId<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : Element
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, Element.ClassIdProperty);
        configure(context).Build();
        return self;
    }
    
    public static T Effects<T>(this T self,
        IList<Effect> effects)
        where T : Element
    {
        foreach (var item in effects)
            self.Effects.Add(item);
        return self;
    }

    public static T Effects<T>(this T self,
        params Effect[] effects)
        where T : Element
    {
        foreach (var item in effects)
            self.Effects.Add(item);
        return self;
    }
    
    public static T StyleId<T>(this T self,
        string styleId)
        where T : Element
    {
        self.StyleId = styleId;
        return self;
    }
    
    public static T Parent<T>(this T self,
        Element parent)
        where T : Element
    {
        self.Parent = parent;
        return self;
    }
    
    public static T EffectControlProvider<T>(this T self,
        IEffectControlProvider effectControlProvider)
        where T : Element
    {
        self.EffectControlProvider = effectControlProvider;
        return self;
    }
    
    public static T OnChildAdded<T>(this T self, EventHandler<ElementEventArgs> handler)
        where T : Element
    {
        self.ChildAdded += handler;
        return self;
    }
    
    public static T OnChildAdded<T>(this T self, Action<T> action)
        where T : Element
    {
        self.ChildAdded += (o, arg) => action(self);
        return self;
    }
    
    public static T OnChildRemoved<T>(this T self, EventHandler<ElementEventArgs> handler)
        where T : Element
    {
        self.ChildRemoved += handler;
        return self;
    }
    
    public static T OnChildRemoved<T>(this T self, Action<T> action)
        where T : Element
    {
        self.ChildRemoved += (o, arg) => action(self);
        return self;
    }
    
    public static T OnDescendantAdded<T>(this T self, EventHandler<ElementEventArgs> handler)
        where T : Element
    {
        self.DescendantAdded += handler;
        return self;
    }
    
    public static T OnDescendantAdded<T>(this T self, Action<T> action)
        where T : Element
    {
        self.DescendantAdded += (o, arg) => action(self);
        return self;
    }
    
    public static T OnDescendantRemoved<T>(this T self, EventHandler<ElementEventArgs> handler)
        where T : Element
    {
        self.DescendantRemoved += handler;
        return self;
    }
    
    public static T OnDescendantRemoved<T>(this T self, Action<T> action)
        where T : Element
    {
        self.DescendantRemoved += (o, arg) => action(self);
        return self;
    }
    
    public static T OnParentChanging<T>(this T self, EventHandler<ParentChangingEventArgs> handler)
        where T : Element
    {
        self.ParentChanging += handler;
        return self;
    }
    
    public static T OnParentChanging<T>(this T self, Action<T> action)
        where T : Element
    {
        self.ParentChanging += (o, arg) => action(self);
        return self;
    }
    
    public static T OnParentChanged<T>(this T self, EventHandler handler)
        where T : Element
    {
        self.ParentChanged += handler;
        return self;
    }
    
    public static T OnParentChanged<T>(this T self, Action<T> action)
        where T : Element
    {
        self.ParentChanged += (o, arg) => action(self);
        return self;
    }
    
    public static T OnHandlerChanging<T>(this T self, EventHandler<HandlerChangingEventArgs> handler)
        where T : Element
    {
        self.HandlerChanging += handler;
        return self;
    }
    
    public static T OnHandlerChanging<T>(this T self, Action<T> action)
        where T : Element
    {
        self.HandlerChanging += (o, arg) => action(self);
        return self;
    }
    
    public static T OnHandlerChanged<T>(this T self, EventHandler handler)
        where T : Element
    {
        self.HandlerChanged += handler;
        return self;
    }
    
    public static T OnHandlerChanged<T>(this T self, Action<T> action)
        where T : Element
    {
        self.HandlerChanged += (o, arg) => action(self);
        return self;
    }

    public static T ContextFlyout<T>(this T self,
       MenuFlyout contextFlyout)
       where T : Element
    {
        self.SetValue(FlyoutBase.ContextFlyoutProperty, contextFlyout);
        return self;
    }

    public static T ContextFlyout<T>(this T self, Func<PropertyContext<MenuFlyout>, IPropertyBuilder<MenuFlyout>> configure)
        where T : Element
    {
        var context = new PropertyContext<MenuFlyout>(self, FlyoutBase.ContextFlyoutProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ContextFlyout<T>(this SettersContext<T> self,
        MenuFlyout contextFlyout)
        where T : Element
    {
        self.XamlSetters.Add(new Setter { Property = FlyoutBase.ContextFlyoutProperty, Value = contextFlyout });
        return self;
    }

    public static SettersContext<T> ContextFlyout<T>(this SettersContext<T> self, Func<PropertySettersContext<MenuFlyout>, IPropertySettersBuilder<MenuFlyout>> configure)
        where T : Element
    {
        var context = new PropertySettersContext<MenuFlyout>(self.XamlSetters, FlyoutBase.ContextFlyoutProperty);
        configure(context).Build();
        return self;
    }

    public static MenuFlyout GetContextFlyoutValue<T>(this T self)
        where T : Element
    {
        return (MenuFlyout)self.GetValue(FlyoutBase.ContextFlyoutProperty);
    }

}