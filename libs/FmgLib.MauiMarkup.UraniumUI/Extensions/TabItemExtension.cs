using UraniumUI.Material.Controls;

namespace FmgLib.MauiMarkup.UraniumUI;

public static partial class TabItemExtension
{
    public static T TitleFmg<T>(this T self,
        string title)
        where T : TabItem
    {
        self.SetValue(TabItem.TitleProperty, title);
        return self;
    }

    public static T TitleFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : TabItem
    {
        var context = new PropertyContext<string>(self, TabItem.TitleProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> TitleFmg<T>(this SettersContext<T> self,
        string title)
        where T : TabItem
    {
        self.XamlSetters.Add(new Setter { Property = TabItem.TitleProperty, Value = title });
        return self;
    }

    public static SettersContext<T> TitleFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : TabItem
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, TabItem.TitleProperty);
        configure(context).Build();
        return self;
    }

    public static T IsVisibleFmg<T>(this T self,
        bool isVisible)
        where T : TabItem
    {
        self.SetValue(TabItem.IsVisibleProperty, isVisible);
        return self;
    }

    public static T IsVisibleFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : TabItem
    {
        var context = new PropertyContext<bool>(self, TabItem.IsVisibleProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IsVisibleFmg<T>(this SettersContext<T> self,
        bool isVisible)
        where T : TabItem
    {
        self.XamlSetters.Add(new Setter { Property = TabItem.IsVisibleProperty, Value = isVisible });
        return self;
    }

    public static SettersContext<T> IsVisibleFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : TabItem
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, TabItem.IsVisibleProperty);
        configure(context).Build();
        return self;
    }
}
