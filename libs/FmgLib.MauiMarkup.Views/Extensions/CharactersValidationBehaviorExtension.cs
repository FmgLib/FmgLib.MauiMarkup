using CommunityToolkit.Maui.Behaviors;

namespace FmgLib.MauiMarkup.Views;

public static partial class CharactersValidationBehaviorExtension
{
    public static T CharacterTypeFmg<T>(this T self, CharacterType characterType) where T : CharactersValidationBehavior
    {
        self.SetValue(CharactersValidationBehavior.CharacterTypeProperty, characterType);
        return self;
    }

    public static T CharacterTypeFmg<T>(this T self, Func<PropertyContext<CharacterType>, IPropertyBuilder<CharacterType>> configure) where T : CharactersValidationBehavior
    {
        PropertyContext<CharacterType> arg = new PropertyContext<CharacterType>(self, CharactersValidationBehavior.CharacterTypeProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> CharacterTypeFmg<T>(this SettersContext<T> self, CharacterType characterType) where T : CharactersValidationBehavior
    {
        self.XamlSetters.Add(new Setter
        {
            Property = CharactersValidationBehavior.CharacterTypeProperty,
            Value = characterType
        });
        return self;
    }

    public static SettersContext<T> CharacterTypeFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<CharacterType>, IPropertySettersBuilder<CharacterType>> configure) where T : CharactersValidationBehavior
    {
        PropertySettersContext<CharacterType> arg = new PropertySettersContext<CharacterType>(self.XamlSetters, CharactersValidationBehavior.CharacterTypeProperty);
        configure(arg).Build();
        return self;
    }

    public static T MinimumCharacterTypeCountFmg<T>(this T self, int count) where T : CharactersValidationBehavior
    {
        self.SetValue(CharactersValidationBehavior.MinimumCharacterTypeCountProperty, count);
        return self;
    }

    public static T MinimumCharacterTypeCountFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure) where T : CharactersValidationBehavior
    {
        PropertyContext<int> arg = new PropertyContext<int>(self, CharactersValidationBehavior.MinimumCharacterTypeCountProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> MinimumCharacterTypeCountFmg<T>(this SettersContext<T> self, int count) where T : CharactersValidationBehavior
    {
        self.XamlSetters.Add(new Setter
        {
            Property = CharactersValidationBehavior.MinimumCharacterTypeCountProperty,
            Value = count
        });
        return self;
    }

    public static SettersContext<T> MinimumCharacterTypeCountFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure) where T : CharactersValidationBehavior
    {
        PropertySettersContext<int> arg = new PropertySettersContext<int>(self.XamlSetters, CharactersValidationBehavior.MinimumCharacterTypeCountProperty);
        configure(arg).Build();
        return self;
    }

    public static T MaximumCharacterTypeCountFmg<T>(this T self, int count) where T : CharactersValidationBehavior
    {
        self.SetValue(CharactersValidationBehavior.MaximumCharacterTypeCountProperty, count);
        return self;
    }

    public static T MaximumCharacterTypeCountFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure) where T : CharactersValidationBehavior
    {
        PropertyContext<int> arg = new PropertyContext<int>(self, CharactersValidationBehavior.MaximumCharacterTypeCountProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> MaximumCharacterTypeCountFmg<T>(this SettersContext<T> self, int count) where T : CharactersValidationBehavior
    {
        self.XamlSetters.Add(new Setter
        {
            Property = CharactersValidationBehavior.MaximumCharacterTypeCountProperty,
            Value = count
        });
        return self;
    }

    public static SettersContext<T> MaximumCharacterTypeCountFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure) where T : CharactersValidationBehavior
    {
        PropertySettersContext<int> arg = new PropertySettersContext<int>(self.XamlSetters, CharactersValidationBehavior.MaximumCharacterTypeCountProperty);
        configure(arg).Build();
        return self;
    }
}
