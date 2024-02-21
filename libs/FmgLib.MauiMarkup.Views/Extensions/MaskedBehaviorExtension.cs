using CommunityToolkit.Maui.Behaviors;
using System.Windows.Input;

namespace FmgLib.MauiMarkup.Views;

public static partial class MaskedBehaviorExtension
{
    public static T MaskFmg<T>(this T self, string mask) where T : MaskedBehavior
    {
        self.SetValue(MaskedBehavior.MaskProperty, mask);
        return self;
    }

    public static T MaskFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure) where T : MaskedBehavior
    {
        PropertyContext<string> arg = new PropertyContext<string>(self, MaskedBehavior.MaskProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> MaskFmg<T>(this SettersContext<T> self, string mask) where T : MaskedBehavior
    {
        self.XamlSetters.Add(new Setter
        {
            Property = MaskedBehavior.MaskProperty,
            Value = mask
        });
        return self;
    }

    public static SettersContext<T> MaskFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure) where T : MaskedBehavior
    {
        PropertySettersContext<string> arg = new PropertySettersContext<string>(self.XamlSetters, MaskedBehavior.MaskProperty);
        configure(arg).Build();
        return self;
    }

    public static T UnmaskedCharacterFmg<T>(this T self, char unmaskedCharacter) where T : MaskedBehavior
    {
        self.SetValue(MaskedBehavior.UnmaskedCharacterProperty, unmaskedCharacter);
        return self;
    }

    public static T UnmaskedCharacterFmg<T>(this T self, Func<PropertyContext<char>, IPropertyBuilder<char>> configure) where T : MaskedBehavior
    {
        PropertyContext<char> arg = new PropertyContext<char>(self, MaskedBehavior.UnmaskedCharacterProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> UnmaskedCharacterFmg<T>(this SettersContext<T> self, char unmaskedCharacter) where T : MaskedBehavior
    {
        self.XamlSetters.Add(new Setter
        {
            Property = MaskedBehavior.UnmaskedCharacterProperty,
            Value = unmaskedCharacter
        });
        return self;
    }

    public static SettersContext<T> UnmaskedCharacterFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<char>, IPropertySettersBuilder<char>> configure) where T : MaskedBehavior
    {
        PropertySettersContext<char> arg = new PropertySettersContext<char>(self.XamlSetters, MaskedBehavior.UnmaskedCharacterProperty);
        configure(arg).Build();
        return self;
    }
}
