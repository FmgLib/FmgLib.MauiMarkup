using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Layouts;
using CommunityToolkit.Maui.Views;

namespace FmgLib.MauiMarkup.Views;

public static partial class DockLayoutExtension
{
    public static T DockPositionFmg<T>(this T self, DockPosition dockPosition) where T : DockLayout
    {
        self.SetValue(DockLayout.DockPositionProperty, dockPosition);
        return self;
    }

    public static T DockPositionFmg<T>(this T self, Func<PropertyContext<DockPosition>, IPropertyBuilder<DockPosition>> configure) where T : DockLayout
    {
        PropertyContext<DockPosition> arg = new PropertyContext<DockPosition>(self, DockLayout.DockPositionProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> DockPositionFmg<T>(this SettersContext<T> self, DockPosition dockPosition) where T : DockLayout
    {
        self.XamlSetters.Add(new Setter
        {
            Property = DockLayout.DockPositionProperty,
            Value = dockPosition
        });
        return self;
    }

    public static SettersContext<T> DockPositionFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<DockPosition>, IPropertySettersBuilder<DockPosition>> configure) where T : DockLayout
    {
        PropertySettersContext<DockPosition> arg = new PropertySettersContext<DockPosition>(self.XamlSetters, DockLayout.DockPositionProperty);
        configure(arg).Build();
        return self;
    }

    public static T ShouldExpandLastChildFmg<T>(this T self, bool shouldExpandLastChild) where T : DockLayout
    {
        self.SetValue(DockLayout.ShouldExpandLastChildProperty, shouldExpandLastChild);
        return self;
    }

    public static T ShouldExpandLastChildFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure) where T : DockLayout
    {
        PropertyContext<bool> arg = new PropertyContext<bool>(self, DockLayout.ShouldExpandLastChildProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> ShouldExpandLastChildFmg<T>(this SettersContext<T> self, bool shouldExpandLastChild) where T : DockLayout
    {
        self.XamlSetters.Add(new Setter
        {
            Property = DockLayout.ShouldExpandLastChildProperty,
            Value = shouldExpandLastChild
        });
        return self;
    }

    public static SettersContext<T> ShouldExpandLastChildFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure) where T : DockLayout
    {
        PropertySettersContext<bool> arg = new PropertySettersContext<bool>(self.XamlSetters, DockLayout.ShouldExpandLastChildProperty);
        configure(arg).Build();
        return self;
    }

    public static T HorizontalSpacingFmg<T>(this T self,
        double spacing)
        where T : DockLayout
    {
        self.SetValue(DockLayout.HorizontalSpacingProperty, spacing);
        return self;
    }

    public static T HorizontalSpacingFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : DockLayout
    {
        var context = new PropertyContext<double>(self, DockLayout.HorizontalSpacingProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> HorizontalSpacingFmg<T>(this SettersContext<T> self,
        double spacing)
        where T : DockLayout
    {
        self.XamlSetters.Add(new Setter { Property = DockLayout.HorizontalSpacingProperty, Value = spacing });
        return self;
    }

    public static SettersContext<T> HorizontalSpacingFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : DockLayout
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, DockLayout.HorizontalSpacingProperty);
        configure(context).Build();
        return self;
    }

    public static T VerticalSpacingFmg<T>(this T self,
        double spacing)
        where T : DockLayout
    {
        self.SetValue(DockLayout.VerticalSpacingProperty, spacing);
        return self;
    }

    public static T VerticalSpacingFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : DockLayout
    {
        var context = new PropertyContext<double>(self, DockLayout.VerticalSpacingProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> VerticalSpacingFmg<T>(this SettersContext<T> self,
        double spacing)
        where T : DockLayout
    {
        self.XamlSetters.Add(new Setter { Property = DockLayout.VerticalSpacingProperty, Value = spacing });
        return self;
    }

    public static SettersContext<T> VerticalSpacingFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : DockLayout
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, DockLayout.VerticalSpacingProperty);
        configure(context).Build();
        return self;
    }
}
