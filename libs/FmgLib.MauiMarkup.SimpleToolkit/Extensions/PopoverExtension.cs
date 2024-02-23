using SimpleToolkit.Core;

namespace FmgLib.MauiMarkup.SimpleToolkit;

public static partial class PopoverExtension
{
    public static T ContentFmg<T>(this T self,
        View view)
        where T : Popover
    {
        self.SetValue(Popover.ContentProperty, view);
        return self;
    }

    public static T ContentFmg<T>(this T self, Func<PropertyContext<View>, IPropertyBuilder<View>> configure)
        where T : Popover
    {
        var context = new PropertyContext<View>(self, Popover.ContentProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ContentFmg<T>(this SettersContext<T> self,
        View view)
        where T : Popover
    {
        self.XamlSetters.Add(new Setter { Property = Popover.ContentProperty, Value = view });
        return self;
    }

    public static SettersContext<T> ContentFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<View>, IPropertySettersBuilder<View>> configure)
        where T : Popover
    {
        var context = new PropertySettersContext<View>(self.XamlSetters, Popover.ContentProperty);
        configure(context).Build();
        return self;
    }

    public static T AttachedPopoverFmg<T>(this T self,
        Popover attachedPopover)
        where T : View
    {
        self.SetValue(Popover.AttachedPopoverProperty, attachedPopover);
        return self;
    }

    public static T AttachedPopoverFmg<T>(this T self, Func<PropertyContext<Popover>, IPropertyBuilder<Popover>> configure)
        where T : View
    {
        var context = new PropertyContext<Popover>(self, Popover.AttachedPopoverProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> AttachedPopoverFmg<T>(this SettersContext<T> self,
        Popover attachedPopover)
        where T : View
    {
        self.XamlSetters.Add(new Setter { Property = Popover.AttachedPopoverProperty, Value = attachedPopover });
        return self;
    }

    public static SettersContext<T> AttachedPopoverFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Popover>, IPropertySettersBuilder<Popover>> configure)
        where T : View
    {
        var context = new PropertySettersContext<Popover>(self.XamlSetters, Popover.AttachedPopoverProperty);
        configure(context).Build();
        return self;
    }
}
