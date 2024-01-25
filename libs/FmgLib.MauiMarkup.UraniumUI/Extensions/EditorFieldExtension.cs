using UraniumUI.Material.Controls;

namespace FmgLib.MauiMarkup.UraniumUI;

public static partial class EditorFieldExtension
{
    public static T TextFmg<T>(this T self,
        string text)
        where T : EditorField
    {
        self.SetValue(EditorField.TextProperty, text);
        return self;
    }

    public static T TextFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : EditorField
    {
        var context = new PropertyContext<string>(self, EditorField.TextProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> TextFmg<T>(this SettersContext<T> self,
        string text)
        where T : EditorField
    {
        self.XamlSetters.Add(new Setter { Property = EditorField.TextProperty, Value = text });
        return self;
    }

    public static SettersContext<T> TextFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : EditorField
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, EditorField.TextProperty);
        configure(context).Build();
        return self;
    }

    public static T TextColorFmg<T>(this T self,
        Color textColor)
        where T : EditorField
    {
        self.SetValue(EditorField.TextColorProperty, textColor);
        return self;
    }

    public static T TextColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : EditorField
    {
        var context = new PropertyContext<Color>(self, EditorField.TextColorProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> TextColorFmg<T>(this SettersContext<T> self,
        Color textColor)
        where T : EditorField
    {
        self.XamlSetters.Add(new Setter { Property = EditorField.TextColorProperty, Value = textColor });
        return self;
    }

    public static SettersContext<T> TextColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : EditorField
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, EditorField.TextColorProperty);
        configure(context).Build();
        return self;
    }

    public static T FontFamilyFmg<T>(this T self,
       string fontFamily)
       where T : EditorField
    {
        self.SetValue(EditorField.FontFamilyProperty, fontFamily);
        return self;
    }

    public static T FontFamilyFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : EditorField
    {
        var context = new PropertyContext<string>(self, EditorField.FontFamilyProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> FontFamilyFmg<T>(this SettersContext<T> self,
        string fontFamily)
        where T : EditorField
    {
        self.XamlSetters.Add(new Setter { Property = EditorField.FontFamilyProperty, Value = fontFamily });
        return self;
    }

    public static SettersContext<T> FontFamilyFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : EditorField
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, EditorField.FontFamilyProperty);
        configure(context).Build();
        return self;
    }

    public static T KeyboardFmg<T>(this T self,
        Keyboard keyboard)
        where T : EditorField
    {
        self.SetValue(EditorField.KeyboardProperty, keyboard);
        return self;
    }

    public static T KeyboardFmg<T>(this T self, Func<PropertyContext<Keyboard>, IPropertyBuilder<Keyboard>> configure)
        where T : EditorField
    {
        var context = new PropertyContext<Keyboard>(self, EditorField.KeyboardProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> KeyboardFmg<T>(this SettersContext<T> self,
        Keyboard keyboard)
        where T : EditorField
    {
        self.XamlSetters.Add(new Setter { Property = EditorField.KeyboardProperty, Value = keyboard });
        return self;
    }

    public static SettersContext<T> KeyboardFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Keyboard>, IPropertySettersBuilder<Keyboard>> configure)
        where T : EditorField
    {
        var context = new PropertySettersContext<Keyboard>(self.XamlSetters, EditorField.KeyboardProperty);
        configure(context).Build();
        return self;
    }

    public static T CharacterSpacingFmg<T>(this T self,
        double characterSpacing)
        where T : EditorField
    {
        self.SetValue(EditorField.CharacterSpacingProperty, characterSpacing);
        return self;
    }

    public static T CharacterSpacingFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : EditorField
    {
        var context = new PropertyContext<double>(self, EditorField.CharacterSpacingProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> CharacterSpacingFmg<T>(this SettersContext<T> self,
        double characterSpacing)
        where T : EditorField
    {
        self.XamlSetters.Add(new Setter { Property = EditorField.CharacterSpacingProperty, Value = characterSpacing });
        return self;
    }

    public static SettersContext<T> CharacterSpacingFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : EditorField
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, EditorField.CharacterSpacingProperty);
        configure(context).Build();
        return self;
    }

    public static T SelectionLengthFmg<T>(this T self,
        int selectionLength)
        where T : EditorField
    {
        self.SetValue(EditorField.SelectionLengthProperty, selectionLength);
        return self;
    }

    public static T SelectionLengthFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
        where T : EditorField
    {
        var context = new PropertyContext<int>(self, EditorField.SelectionLengthProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> SelectionLengthFmg<T>(this SettersContext<T> self,
        int selectionLength)
        where T : EditorField
    {
        self.XamlSetters.Add(new Setter { Property = EditorField.SelectionLengthProperty, Value = selectionLength });
        return self;
    }

    public static SettersContext<T> SelectionLengthFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure)
        where T : EditorField
    {
        var context = new PropertySettersContext<int>(self.XamlSetters, EditorField.SelectionLengthProperty);
        configure(context).Build();
        return self;
    }

    public static T CursorPositionFmg<T>(this T self,
        int cursorPosition)
        where T : EditorField
    {
        self.SetValue(EditorField.CursorPositionProperty, cursorPosition);
        return self;
    }

    public static T CursorPositionFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
        where T : EditorField
    {
        var context = new PropertyContext<int>(self, EditorField.CursorPositionProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> CursorPositionFmg<T>(this SettersContext<T> self,
        int cursorPosition)
        where T : EditorField
    {
        self.XamlSetters.Add(new Setter { Property = EditorField.CursorPositionProperty, Value = cursorPosition });
        return self;
    }

    public static SettersContext<T> CursorPositionFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure)
        where T : EditorField
    {
        var context = new PropertySettersContext<int>(self.XamlSetters, EditorField.CursorPositionProperty);
        configure(context).Build();
        return self;
    }

    public static T IsTextPredictionEnabledFmg<T>(this T self,
        bool isTextPredictionEnabled)
        where T : EditorField
    {
        self.SetValue(EditorField.IsTextPredictionEnabledProperty, isTextPredictionEnabled);
        return self;
    }

    public static T IsTextPredictionEnabledFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : EditorField
    {
        var context = new PropertyContext<bool>(self, EditorField.IsTextPredictionEnabledProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IsTextPredictionEnabledFmg<T>(this SettersContext<T> self,
        bool isTextPredictionEnabled)
        where T : EditorField
    {
        self.XamlSetters.Add(new Setter { Property = EditorField.IsTextPredictionEnabledProperty, Value = isTextPredictionEnabled });
        return self;
    }

    public static SettersContext<T> IsTextPredictionEnabledFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : EditorField
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, EditorField.IsTextPredictionEnabledProperty);
        configure(context).Build();
        return self;
    }

    public static T MaxLengthFmg<T>(this T self,
        int maxLength)
        where T : EditorField
    {
        self.SetValue(EditorField.MaxLengthProperty, maxLength);
        return self;
    }

    public static T MaxLengthFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
        where T : EditorField
    {
        var context = new PropertyContext<int>(self, EditorField.MaxLengthProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> MaxLengthFmg<T>(this SettersContext<T> self,
        int maxLength)
        where T : EditorField
    {
        self.XamlSetters.Add(new Setter { Property = EditorField.MaxLengthProperty, Value = maxLength });
        return self;
    }

    public static SettersContext<T> MaxLengthFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure)
        where T : EditorField
    {
        var context = new PropertySettersContext<int>(self.XamlSetters, EditorField.MaxLengthProperty);
        configure(context).Build();
        return self;
    }

    public static T IsReadOnlyFmg<T>(this T self,
        bool isReadOnly)
        where T : EditorField
    {
        self.SetValue(EditorField.IsReadOnlyProperty, isReadOnly);
        return self;
    }

    public static T IsReadOnlyFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : EditorField
    {
        var context = new PropertyContext<bool>(self, EditorField.IsReadOnlyProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IsReadOnlyFmg<T>(this SettersContext<T> self,
        bool isReadOnly)
        where T : EditorField
    {
        self.XamlSetters.Add(new Setter { Property = EditorField.IsReadOnlyProperty, Value = isReadOnly });
        return self;
    }

    public static SettersContext<T> IsReadOnlyFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : EditorField
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, EditorField.IsReadOnlyProperty);
        configure(context).Build();
        return self;
    }

    public static T IsSpellCheckEnabledFmg<T>(this T self,
        bool isSpellCheckEnabled)
        where T : EditorField
    {
        self.SetValue(EditorField.IsSpellCheckEnabledProperty, isSpellCheckEnabled);
        return self;
    }

    public static T IsSpellCheckEnabledFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : EditorField
    {
        var context = new PropertyContext<bool>(self, EditorField.IsSpellCheckEnabledProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IsSpellCheckEnabledFmg<T>(this SettersContext<T> self,
        bool isSpellCheckEnabled)
        where T : EditorField
    {
        self.XamlSetters.Add(new Setter { Property = EditorField.IsSpellCheckEnabledProperty, Value = isSpellCheckEnabled });
        return self;
    }

    public static SettersContext<T> IsSpellCheckEnabledFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : EditorField
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, EditorField.IsSpellCheckEnabledProperty);
        configure(context).Build();
        return self;
    }
}
