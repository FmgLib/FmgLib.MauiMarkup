using Microsoft.Maui.Controls.Shapes;
using System.Windows.Input;
using UraniumUI.Material.Controls;

namespace FmgLib.MauiMarkup.UraniumUI;

public static partial class TextFieldExtension
{
    public static T TextFmg<T>(this T self, string text) where T : TextField
    {
        self.SetValue(TextField.TextProperty, text);
        return self;
    }

    public static T TextFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure) where T : TextField
    {
        PropertyContext<string> arg = new PropertyContext<string>(self, TextField.TextProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> TextFmg<T>(this SettersContext<T> self, string text) where T : TextField
    {
        self.XamlSetters.Add(new Setter
        {
            Property = TextField.TextProperty,
            Value = text
        });
        return self;
    }

    public static SettersContext<T> TextFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure) where T : TextField
    {
        PropertySettersContext<string> arg = new PropertySettersContext<string>(self.XamlSetters, TextField.TextProperty);
        configure(arg).Build();
        return self;
    }

    public static T TextColorFmg<T>(this T self,
        Color textColor)
        where T : TextField
    {
        self.SetValue(TextField.TextColorProperty, textColor);
        return self;
    }

    public static T TextColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : TextField
    {
        var context = new PropertyContext<Color>(self, TextField.TextColorProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> TextColorFmg<T>(this SettersContext<T> self,
        Color textColor)
        where T : TextField
    {
        self.XamlSetters.Add(new Setter { Property = TextField.TextColorProperty, Value = textColor });
        return self;
    }

    public static SettersContext<T> TextColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : TextField
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, TextField.TextColorProperty);
        configure(context).Build();
        return self;
    }

    public static T FontFamilyFmg<T>(this T self,
        string fontFamily)
        where T : TextField
    {
        self.SetValue(TextField.FontFamilyProperty, fontFamily);
        return self;
    }

    public static T FontFamilyFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : TextField
    {
        var context = new PropertyContext<string>(self, TextField.FontFamilyProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> FontFamilyFmg<T>(this SettersContext<T> self,
        string fontFamily)
        where T : TextField
    {
        self.XamlSetters.Add(new Setter { Property = TextField.FontFamilyProperty, Value = fontFamily });
        return self;
    }

    public static SettersContext<T> FontFamilyFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : TextField
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, TextField.FontFamilyProperty);
        configure(context).Build();
        return self;
    }

    public static T KeyboardFmg<T>(this T self,
        Keyboard keyboard)
        where T : TextField
    {
        self.SetValue(TextField.KeyboardProperty, keyboard);
        return self;
    }

    public static T KeyboardFmg<T>(this T self, Func<PropertyContext<Keyboard>, IPropertyBuilder<Keyboard>> configure)
        where T : TextField
    {
        var context = new PropertyContext<Keyboard>(self, TextField.KeyboardProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> KeyboardFmg<T>(this SettersContext<T> self,
        Keyboard keyboard)
        where T : TextField
    {
        self.XamlSetters.Add(new Setter { Property = TextField.KeyboardProperty, Value = keyboard });
        return self;
    }

    public static SettersContext<T> KeyboardFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Keyboard>, IPropertySettersBuilder<Keyboard>> configure)
        where T : TextField
    {
        var context = new PropertySettersContext<Keyboard>(self.XamlSetters, TextField.KeyboardProperty);
        configure(context).Build();
        return self;
    }

    public static T ClearButtonVisibilityFmg<T>(this T self, ClearButtonVisibility clearButtonVisibility) where T : TextField
    {
        self.SetValue(TextField.ClearButtonVisibilityProperty, clearButtonVisibility);
        return self;
    }

    public static T ClearButtonVisibilityFmg<T>(this T self, Func<PropertyContext<ClearButtonVisibility>, IPropertyBuilder<ClearButtonVisibility>> configure) where T : TextField
    {
        PropertyContext<ClearButtonVisibility> arg = new PropertyContext<ClearButtonVisibility>(self, TextField.ClearButtonVisibilityProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> ClearButtonVisibilityFmg<T>(this SettersContext<T> self, ClearButtonVisibility clearButtonVisibility) where T : TextField
    {
        self.XamlSetters.Add(new Setter
        {
            Property = TextField.ClearButtonVisibilityProperty,
            Value = clearButtonVisibility
        });
        return self;
    }

    public static SettersContext<T> ClearButtonVisibilityFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ClearButtonVisibility>, IPropertySettersBuilder<ClearButtonVisibility>> configure) where T : TextField
    {
        PropertySettersContext<ClearButtonVisibility> arg = new PropertySettersContext<ClearButtonVisibility>(self.XamlSetters, TextField.ClearButtonVisibilityProperty);
        configure(arg).Build();
        return self;
    }

    public static T IsPasswordFmg<T>(this T self, bool isPassword) where T : TextField
    {
        self.SetValue(TextField.IsPasswordProperty, isPassword);
        return self;
    }

    public static T IsPasswordFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure) where T : TextField
    {
        PropertyContext<bool> arg = new PropertyContext<bool>(self, TextField.IsPasswordProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> IsPasswordFmg<T>(this SettersContext<T> self, bool isPassword) where T : TextField
    {
        self.XamlSetters.Add(new Setter
        {
            Property = TextField.IsPasswordProperty,
            Value = isPassword
        });
        return self;
    }

    public static SettersContext<T> IsPasswordFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure) where T : TextField
    {
        PropertySettersContext<bool> arg = new PropertySettersContext<bool>(self.XamlSetters, TextField.IsPasswordProperty);
        configure(arg).Build();
        return self;
    }

    public static T ReturnCommandParameterFmg<T>(this T self,
        object commandParameter)
        where T : TextField
    {
        self.SetValue(TextField.ReturnCommandParameterProperty, commandParameter);
        return self;
    }

    public static T ReturnCommandParameterFmg<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        where T : TextField
    {
        var context = new PropertyContext<object>(self, TextField.ReturnCommandParameterProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ReturnCommandParameterFmg<T>(this SettersContext<T> self,
        object commandParameter)
        where T : TextField
    {
        self.XamlSetters.Add(new Setter { Property = TextField.ReturnCommandParameterProperty, Value = commandParameter });
        return self;
    }

    public static SettersContext<T> ReturnCommandParameterFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        where T : TextField
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, TextField.ReturnCommandParameterProperty);
        configure(context).Build();
        return self;
    }

    public static T ReturnCommandFmg<T>(this T self, ICommand command) where T : TextField
    {
        self.SetValue(TextField.ReturnCommandProperty, command);
        return self;
    }

    public static T ReturnCommandFmg<T>(this T self, Func<PropertyContext<ICommand>, IPropertyBuilder<ICommand>> configure) where T : TextField
    {
        PropertyContext<ICommand> arg = new PropertyContext<ICommand>(self, TextField.ReturnCommandProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> ReturnCommandFmg<T>(this SettersContext<T> self, ICommand command) where T : TextField
    {
        self.XamlSetters.Add(new Setter
        {
            Property = TextField.ReturnCommandProperty,
            Value = command
        });
        return self;
    }

    public static SettersContext<T> ReturnCommandFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ICommand>, IPropertySettersBuilder<ICommand>> configure) where T : TextField
    {
        PropertySettersContext<ICommand> arg = new PropertySettersContext<ICommand>(self.XamlSetters, TextField.ReturnCommandProperty);
        configure(arg).Build();
        return self;
    }

    public static T CharacterSpacingFmg<T>(this T self,
        double characterSpacing)
        where T : TextField
    {
        self.SetValue(TextField.CharacterSpacingProperty, characterSpacing);
        return self;
    }

    public static T CharacterSpacingFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : TextField
    {
        var context = new PropertyContext<double>(self, TextField.CharacterSpacingProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> CharacterSpacingFmg<T>(this SettersContext<T> self,
        double characterSpacing)
        where T : TextField
    {
        self.XamlSetters.Add(new Setter { Property = TextField.CharacterSpacingProperty, Value = characterSpacing });
        return self;
    }

    public static SettersContext<T> CharacterSpacingFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : TextField
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, TextField.CharacterSpacingProperty);
        configure(context).Build();
        return self;
    }

    public static T ReturnTypeFmg<T>(this T self,
        ReturnType returnType)
        where T : TextField
    {
        self.SetValue(TextField.ReturnTypeProperty, returnType);
        return self;
    }

    public static T ReturnTypeFmg<T>(this T self, Func<PropertyContext<ReturnType>, IPropertyBuilder<ReturnType>> configure)
        where T : TextField
    {
        var context = new PropertyContext<ReturnType>(self, TextField.ReturnTypeProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ReturnTypeFmg<T>(this SettersContext<T> self,
        ReturnType returnType)
        where T : TextField
    {
        self.XamlSetters.Add(new Setter { Property = TextField.ReturnTypeProperty, Value = returnType });
        return self;
    }

    public static SettersContext<T> ReturnTypeFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ReturnType>, IPropertySettersBuilder<ReturnType>> configure)
        where T : TextField
    {
        var context = new PropertySettersContext<ReturnType>(self.XamlSetters, TextField.ReturnTypeProperty);
        configure(context).Build();
        return self;
    }

    public static T SelectionLengthFmg<T>(this T self,
        int selectionLength)
        where T : TextField
    {
        self.SetValue(TextField.SelectionLengthProperty, selectionLength);
        return self;
    }

    public static T SelectionLengthFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
        where T : TextField
    {
        var context = new PropertyContext<int>(self, TextField.SelectionLengthProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> SelectionLengthFmg<T>(this SettersContext<T> self,
        int selectionLength)
        where T : TextField
    {
        self.XamlSetters.Add(new Setter { Property = TextField.SelectionLengthProperty, Value = selectionLength });
        return self;
    }

    public static SettersContext<T> SelectionLengthFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure)
        where T : TextField
    {
        var context = new PropertySettersContext<int>(self.XamlSetters, TextField.SelectionLengthProperty);
        configure(context).Build();
        return self;
    }

    public static T CursorPositionFmg<T>(this T self,
        int cursorPosition)
        where T : TextField
    {
        self.SetValue(TextField.CursorPositionProperty, cursorPosition);
        return self;
    }

    public static T CursorPositionFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
        where T : TextField
    {
        var context = new PropertyContext<int>(self, TextField.CursorPositionProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> CursorPositionFmg<T>(this SettersContext<T> self,
        int cursorPosition)
        where T : TextField
    {
        self.XamlSetters.Add(new Setter { Property = TextField.CursorPositionProperty, Value = cursorPosition });
        return self;
    }

    public static SettersContext<T> CursorPositionFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure)
        where T : TextField
    {
        var context = new PropertySettersContext<int>(self.XamlSetters, TextField.CursorPositionProperty);
        configure(context).Build();
        return self;
    }

    public static T IsTextPredictionEnabledFmg<T>(this T self,
        bool isTextPredictionEnabled)
        where T : TextField
    {
        self.SetValue(TextField.IsTextPredictionEnabledProperty, isTextPredictionEnabled);
        return self;
    }

    public static T IsTextPredictionEnabledFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : TextField
    {
        var context = new PropertyContext<bool>(self, TextField.IsTextPredictionEnabledProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IsTextPredictionEnabledFmg<T>(this SettersContext<T> self,
        bool isTextPredictionEnabled)
        where T : TextField
    {
        self.XamlSetters.Add(new Setter { Property = TextField.IsTextPredictionEnabledProperty, Value = isTextPredictionEnabled });
        return self;
    }

    public static SettersContext<T> IsTextPredictionEnabledFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : TextField
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, TextField.IsTextPredictionEnabledProperty);
        configure(context).Build();
        return self;
    }

    public static T MaxLengthFmg<T>(this T self,
        int maxLength)
        where T : TextField
    {
        self.SetValue(TextField.MaxLengthProperty, maxLength);
        return self;
    }

    public static T MaxLengthFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
        where T : TextField
    {
        var context = new PropertyContext<int>(self, TextField.MaxLengthProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> MaxLengthFmg<T>(this SettersContext<T> self,
        int maxLength)
        where T : TextField
    {
        self.XamlSetters.Add(new Setter { Property = TextField.MaxLengthProperty, Value = maxLength });
        return self;
    }

    public static SettersContext<T> MaxLengthFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure)
        where T : TextField
    {
        var context = new PropertySettersContext<int>(self.XamlSetters, TextField.MaxLengthProperty);
        configure(context).Build();
        return self;
    }

    public static T IsReadOnlyFmg<T>(this T self,
        bool isReadOnly)
        where T : TextField
    {
        self.SetValue(TextField.IsReadOnlyProperty, isReadOnly);
        return self;
    }

    public static T IsReadOnlyFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : TextField
    {
        var context = new PropertyContext<bool>(self, TextField.IsReadOnlyProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IsReadOnlyFmg<T>(this SettersContext<T> self,
        bool isReadOnly)
        where T : TextField
    {
        self.XamlSetters.Add(new Setter { Property = TextField.IsReadOnlyProperty, Value = isReadOnly });
        return self;
    }

    public static SettersContext<T> IsReadOnlyFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : TextField
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, TextField.IsReadOnlyProperty);
        configure(context).Build();
        return self;
    }

    public static T AllowClearFmg<T>(this T self,
        bool allowClear)
        where T : TextField
    {
        self.SetValue(TextField.AllowClearProperty, allowClear);
        return self;
    }

    public static T AllowClearFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : TextField
    {
        var context = new PropertyContext<bool>(self, TextField.AllowClearProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> AllowClearFmg<T>(this SettersContext<T> self,
        bool allowClear)
        where T : TextField
    {
        self.XamlSetters.Add(new Setter { Property = TextField.AllowClearProperty, Value = allowClear });
        return self;
    }

    public static SettersContext<T> AllowClearFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : TextField
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, TextField.AllowClearProperty);
        configure(context).Build();
        return self;
    }

    public static T FontSizeFmg<T>(this T self,
        double fontSize)
        where T : TextField
    {
        self.SetValue(TextField.FontSizeProperty, fontSize);
        return self;
    }

    public static T FontSizeFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : TextField
    {
        var context = new PropertyContext<double>(self, TextField.FontSizeProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> FontSizeFmg<T>(this SettersContext<T> self,
        double fontSize)
        where T : TextField
    {
        self.XamlSetters.Add(new Setter { Property = TextField.FontSizeProperty, Value = fontSize });
        return self;
    }

    public static SettersContext<T> FontSizeFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : TextField
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, TextField.FontSizeProperty);
        configure(context).Build();
        return self;
    }
}
