namespace FmgLib.MauiMarkup;

public static partial class RadioButtonGroupExtension
{
    public static T RadioButtonGroupGroupName<T>(this T self,
        string groupName)
        where T : Layout
    {
        self.SetValue(RadioButtonGroup.GroupNameProperty, groupName);
        return self;
    }

    public static T RadioButtonGroupGroupName<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : Layout
    {
        var context = new PropertyContext<string>(self, RadioButtonGroup.GroupNameProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> RadioButtonGroupGroupName<T>(this SettersContext<T> self,
        string groupName)
        where T : Layout
    {
        self.XamlSetters.Add(new Setter { Property = RadioButtonGroup.GroupNameProperty, Value = groupName });
        return self;
    }

    public static SettersContext<T> RadioButtonGroupGroupName<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : Layout
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, RadioButtonGroup.GroupNameProperty);
        configure(context).Build();
        return self;
    }

    public static T RadioButtonGroupSelectedValue<T>(this T self,
        object selectedValue)
        where T : Layout
    {
        self.SetValue(RadioButtonGroup.SelectedValueProperty, selectedValue);
        return self;
    }

    public static T RadioButtonGroupSelectedValue<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        where T : Layout
    {
        var context = new PropertyContext<object>(self, RadioButtonGroup.SelectedValueProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> RadioButtonGroupSelectedValue<T>(this SettersContext<T> self,
        object selectedValue)
        where T : Layout
    {
        self.XamlSetters.Add(new Setter { Property = RadioButtonGroup.SelectedValueProperty, Value = selectedValue });
        return self;
    }

    public static SettersContext<T> RadioButtonGroupSelectedValue<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        where T : Layout
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, RadioButtonGroup.SelectedValueProperty);
        configure(context).Build();
        return self;
    }
}
