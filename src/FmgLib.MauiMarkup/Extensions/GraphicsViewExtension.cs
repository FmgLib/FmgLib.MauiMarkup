namespace FmgLib.MauiMarkup;

public static partial class GraphicsViewExtension
{
    public static T Drawable<T>(this T self,
        Func<IDrawable> configure)
        where T : GraphicsView
    {
        var drawable = configure();
        self.SetValue(GraphicsView.DrawableProperty, drawable);
        return self;
    }

    public static T Drawable<T>(this T self,
        IDrawable drawable)
        where T : GraphicsView
    {
        self.SetValue(GraphicsView.DrawableProperty, drawable);
        return self;
    }
    
    public static T Drawable<T>(this T self, Func<PropertyContext<IDrawable>, IPropertyBuilder<IDrawable>> configure)
        where T : GraphicsView
    {
        var context = new PropertyContext<IDrawable>(self, GraphicsView.DrawableProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Drawable<T>(this SettersContext<T> self,
        IDrawable drawable)
        where T : GraphicsView
    {
        self.XamlSetters.Add(new Setter { Property = GraphicsView.DrawableProperty, Value = drawable });
        return self;
    }
    
    public static SettersContext<T> Drawable<T>(this SettersContext<T> self, Func<PropertySettersContext<IDrawable>, IPropertySettersBuilder<IDrawable>> configure)
        where T : GraphicsView
    {
        var context = new PropertySettersContext<IDrawable>(self.XamlSetters, GraphicsView.DrawableProperty);
        configure(context).Build();
        return self;
    }
    
    public static T OnStartHoverInteraction<T>(this T self, EventHandler<TouchEventArgs> handler)
        where T : GraphicsView
    {
        self.StartHoverInteraction += handler;
        return self;
    }
    
    public static T OnStartHoverInteraction<T>(this T self, Action<T> action)
        where T : GraphicsView
    {
        self.StartHoverInteraction += (o, arg) => action(self);
        return self;
    }
    
    public static T OnMoveHoverInteraction<T>(this T self, EventHandler<TouchEventArgs> handler)
        where T : GraphicsView
    {
        self.MoveHoverInteraction += handler;
        return self;
    }
    
    public static T OnMoveHoverInteraction<T>(this T self, Action<T> action)
        where T : GraphicsView
    {
        self.MoveHoverInteraction += (o, arg) => action(self);
        return self;
    }
    
    public static T OnEndHoverInteraction<T>(this T self, EventHandler handler)
        where T : GraphicsView
    {
        self.EndHoverInteraction += handler;
        return self;
    }
    
    public static T OnEndHoverInteraction<T>(this T self, Action<T> action)
        where T : GraphicsView
    {
        self.EndHoverInteraction += (o, arg) => action(self);
        return self;
    }
    
    public static T OnStartInteraction<T>(this T self, EventHandler<TouchEventArgs> handler)
        where T : GraphicsView
    {
        self.StartInteraction += handler;
        return self;
    }
    
    public static T OnStartInteraction<T>(this T self, Action<T> action)
        where T : GraphicsView
    {
        self.StartInteraction += (o, arg) => action(self);
        return self;
    }
    
    public static T OnDragInteraction<T>(this T self, EventHandler<TouchEventArgs> handler)
        where T : GraphicsView
    {
        self.DragInteraction += handler;
        return self;
    }
    
    public static T OnDragInteraction<T>(this T self, Action<T> action)
        where T : GraphicsView
    {
        self.DragInteraction += (o, arg) => action(self);
        return self;
    }
    
    public static T OnEndInteraction<T>(this T self, EventHandler<TouchEventArgs> handler)
        where T : GraphicsView
    {
        self.EndInteraction += handler;
        return self;
    }
    
    public static T OnEndInteraction<T>(this T self, Action<T> action)
        where T : GraphicsView
    {
        self.EndInteraction += (o, arg) => action(self);
        return self;
    }
    
    public static T OnCancelInteraction<T>(this T self, EventHandler handler)
        where T : GraphicsView
    {
        self.CancelInteraction += handler;
        return self;
    }
    
    public static T OnCancelInteraction<T>(this T self, Action<T> action)
        where T : GraphicsView
    {
        self.CancelInteraction += (o, arg) => action(self);
        return self;
    }
    
}