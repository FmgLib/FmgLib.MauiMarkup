using System.Windows.Input;
using UraniumUI.Material.Controls;

namespace FmgLib.MauiMarkup.UraniumUI;

public static partial class ChipExtension
{
    public static T DestroyCommandFmg<T>(this T self, ICommand command) where T : Chip
    {
        self.SetValue(Chip.DestroyCommandProperty, command);
        return self;
    }

    public static T DestroyCommandFmg<T>(this T self, Func<PropertyContext<ICommand>, IPropertyBuilder<ICommand>> configure) where T : Chip
    {
        PropertyContext<ICommand> arg = new PropertyContext<ICommand>(self, Chip.DestroyCommandProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> DestroyCommandFmg<T>(this SettersContext<T> self, ICommand command) where T : Chip
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Chip.DestroyCommandProperty,
            Value = command
        });
        return self;
    }

    public static SettersContext<T> DestroyCommandFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ICommand>, IPropertySettersBuilder<ICommand>> configure) where T : Chip
    {
        PropertySettersContext<ICommand> arg = new PropertySettersContext<ICommand>(self.XamlSetters, Chip.DestroyCommandProperty);
        configure(arg).Build();
        return self;
    }

    public static T TextFmg<T>(this T self, string text) where T : Chip
    {
        self.SetValue(Chip.TextProperty, text);
        return self;
    }

    public static T TextFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure) where T : Chip
    {
        PropertyContext<string> arg = new PropertyContext<string>(self, Chip.TextProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> TextFmg<T>(this SettersContext<T> self, string text) where T : Chip
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Chip.TextProperty,
            Value = text
        });
        return self;
    }

    public static SettersContext<T> TextFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure) where T : Chip
    {
        PropertySettersContext<string> arg = new PropertySettersContext<string>(self.XamlSetters, Chip.TextProperty);
        configure(arg).Build();
        return self;
    }

    public static T TextColorFmg<T>(this T self,
        Color textColor)
        where T : Chip
    {
        self.SetValue(Chip.TextColorProperty, textColor);
        return self;
    }

    public static T TextColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : Chip
    {
        var context = new PropertyContext<Color>(self, Chip.TextColorProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> TextColorFmg<T>(this SettersContext<T> self,
        Color textColor)
        where T : Chip
    {
        self.XamlSetters.Add(new Setter { Property = Chip.TextColorProperty, Value = textColor });
        return self;
    }

    public static SettersContext<T> TextColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : Chip
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, Chip.TextColorProperty);
        configure(context).Build();
        return self;
    }
}
