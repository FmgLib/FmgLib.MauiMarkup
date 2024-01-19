namespace FmgLib.MauiMarkup;

public static partial class ElementExtension
{
    public static T AutomationIdFmg<T>(this T self,
        string automationId)
        where T : Element
    {
        self.SetValue(Element.AutomationIdProperty, automationId);
        return self;
    }
    
    public static T AutomationIdFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : Element
    {
        var context = new PropertyContext<string>(self, Element.AutomationIdProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> AutomationIdFmg<T>(this SettersContext<T> self,
        string automationId)
        where T : Element
    {
        self.XamlSetters.Add(new Setter { Property = Element.AutomationIdProperty, Value = automationId });
        return self;
    }
    
    public static SettersContext<T> AutomationIdFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : Element
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, Element.AutomationIdProperty);
        configure(context).Build();
        return self;
    }
    
    public static T ClassIdFmg<T>(this T self,
        string classId)
        where T : Element
    {
        self.SetValue(Element.ClassIdProperty, classId);
        return self;
    }
    
    public static T ClassIdFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : Element
    {
        var context = new PropertyContext<string>(self, Element.ClassIdProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ClassIdFmg<T>(this SettersContext<T> self,
        string classId)
        where T : Element
    {
        self.XamlSetters.Add(new Setter { Property = Element.ClassIdProperty, Value = classId });
        return self;
    }
    
    public static SettersContext<T> ClassIdFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : Element
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, Element.ClassIdProperty);
        configure(context).Build();
        return self;
    }
    
    public static T EffectsFmg<T>(this T self,
        IList<Effect> effects)
        where T : Element
    {
        foreach (var item in effects)
            self.Effects.Add(item);
        return self;
    }

    public static T EffectsFmg<T>(this T self,
        params Effect[] effects)
        where T : Element
    {
        foreach (var item in effects)
            self.Effects.Add(item);
        return self;
    }
    
    public static T StyleIdFmg<T>(this T self,
        string styleId)
        where T : Element
    {
        self.StyleId = styleId;
        return self;
    }
    
    public static T ParentFmg<T>(this T self,
        Element parent)
        where T : Element
    {
        self.Parent = parent;
        return self;
    }
    
    public static T EffectControlProviderFmg<T>(this T self,
        IEffectControlProvider effectControlProvider)
        where T : Element
    {
        self.EffectControlProvider = effectControlProvider;
        return self;
    }
    
    public static T OnChildAddedFmg<T>(this T self, EventHandler<ElementEventArgs> handler)
        where T : Element
    {
        self.ChildAdded += handler;
        return self;
    }
    
    public static T OnChildAddedFmg<T>(this T self, Action<T> action)
        where T : Element
    {
        self.ChildAdded += (o, arg) => action(self);
        return self;
    }
    
    public static T OnChildRemovedFmg<T>(this T self, EventHandler<ElementEventArgs> handler)
        where T : Element
    {
        self.ChildRemoved += handler;
        return self;
    }
    
    public static T OnChildRemovedFmg<T>(this T self, Action<T> action)
        where T : Element
    {
        self.ChildRemoved += (o, arg) => action(self);
        return self;
    }
    
    public static T OnDescendantAddedFmg<T>(this T self, EventHandler<ElementEventArgs> handler)
        where T : Element
    {
        self.DescendantAdded += handler;
        return self;
    }
    
    public static T OnDescendantAddedFmg<T>(this T self, Action<T> action)
        where T : Element
    {
        self.DescendantAdded += (o, arg) => action(self);
        return self;
    }
    
    public static T OnDescendantRemovedFmg<T>(this T self, EventHandler<ElementEventArgs> handler)
        where T : Element
    {
        self.DescendantRemoved += handler;
        return self;
    }
    
    public static T OnDescendantRemovedFmg<T>(this T self, Action<T> action)
        where T : Element
    {
        self.DescendantRemoved += (o, arg) => action(self);
        return self;
    }
    
    public static T OnParentChangingFmg<T>(this T self, EventHandler<ParentChangingEventArgs> handler)
        where T : Element
    {
        self.ParentChanging += handler;
        return self;
    }
    
    public static T OnParentChangingFmg<T>(this T self, Action<T> action)
        where T : Element
    {
        self.ParentChanging += (o, arg) => action(self);
        return self;
    }
    
    public static T OnParentChangedFmg<T>(this T self, EventHandler handler)
        where T : Element
    {
        self.ParentChanged += handler;
        return self;
    }
    
    public static T OnParentChangedFmg<T>(this T self, Action<T> action)
        where T : Element
    {
        self.ParentChanged += (o, arg) => action(self);
        return self;
    }
    
    public static T OnHandlerChangingFmg<T>(this T self, EventHandler<HandlerChangingEventArgs> handler)
        where T : Element
    {
        self.HandlerChanging += handler;
        return self;
    }
    
    public static T OnHandlerChangingFmg<T>(this T self, Action<T> action)
        where T : Element
    {
        self.HandlerChanging += (o, arg) => action(self);
        return self;
    }
    
    public static T OnHandlerChangedFmg<T>(this T self, EventHandler handler)
        where T : Element
    {
        self.HandlerChanged += handler;
        return self;
    }
    
    public static T OnHandlerChangedFmg<T>(this T self, Action<T> action)
        where T : Element
    {
        self.HandlerChanged += (o, arg) => action(self);
        return self;
    }

    public static T ContextFlyoutFmg<T>(this T self,
       MenuFlyout contextFlyout)
       where T : Element
    {
        self.SetValue(FlyoutBase.ContextFlyoutProperty, contextFlyout);
        return self;
    }

    public static T ContextFlyoutFmg<T>(this T self, Func<PropertyContext<MenuFlyout>, IPropertyBuilder<MenuFlyout>> configure)
        where T : Element
    {
        var context = new PropertyContext<MenuFlyout>(self, FlyoutBase.ContextFlyoutProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ContextFlyoutFmg<T>(this SettersContext<T> self,
        MenuFlyout contextFlyout)
        where T : Element
    {
        self.XamlSetters.Add(new Setter { Property = FlyoutBase.ContextFlyoutProperty, Value = contextFlyout });
        return self;
    }

    public static SettersContext<T> ContextFlyoutFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<MenuFlyout>, IPropertySettersBuilder<MenuFlyout>> configure)
        where T : Element
    {
        var context = new PropertySettersContext<MenuFlyout>(self.XamlSetters, FlyoutBase.ContextFlyoutProperty);
        configure(context).Build();
        return self;
    }

    public static MenuFlyout GetContextFlyoutValueFmg<T>(this T self)
        where T : Element
    {
        return (MenuFlyout)self.GetValue(FlyoutBase.ContextFlyoutProperty);
    }

}