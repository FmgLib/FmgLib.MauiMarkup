using System.Windows.Input;

namespace FmgLib.MauiMarkup;

public static class SearchBarExtension
{
    public static T CancelButtonColorFmg<T>(this T self, Color cancelButtonColor) where T : SearchBar
    {
        self.SetValue(SearchBar.CancelButtonColorProperty, cancelButtonColor);
        return self;
    }

    public static T CancelButtonColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure) where T : SearchBar
    {
        PropertyContext<Color> arg = new PropertyContext<Color>(self, SearchBar.CancelButtonColorProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> CancelButtonColorFmg<T>(this SettersContext<T> self, Color cancelButtonColor) where T : SearchBar
    {
        self.XamlSetters.Add(new Setter
        {
            Property = SearchBar.CancelButtonColorProperty,
            Value = cancelButtonColor
        });
        return self;
    }

    public static SettersContext<T> CancelButtonColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure) where T : SearchBar
    {
        PropertySettersContext<Color> arg = new PropertySettersContext<Color>(self.XamlSetters, SearchBar.CancelButtonColorProperty);
        configure(arg).Build();
        return self;
    }

    public static Task<bool> AnimateCancelButtonColorToFmg<T>(this T self, Color value, uint length = 250u, Easing? easing = null) where T : SearchBar
    {
        Color value2 = value;
        T self2 = self;
        Color fromValue = self2.CancelButtonColor;
        return Transformations.AnimateAsync(transform: (double t) => Transformations.ColorTransform(fromValue, value2, t), callback: delegate (Color actValue)
        {
            self2.CancelButtonColor = actValue;
        }, element: self2, name: "AnimateCancelButtonColorTo", length: length, easing: easing);
    }

    public static T HorizontalTextAlignmentFmg<T>(this T self, TextAlignment horizontalTextAlignment) where T : SearchBar
    {
        self.SetValue(SearchBar.HorizontalTextAlignmentProperty, horizontalTextAlignment);
        return self;
    }

    public static T HorizontalTextAlignmentFmg<T>(this T self, Func<PropertyContext<TextAlignment>, IPropertyBuilder<TextAlignment>> configure) where T : SearchBar
    {
        PropertyContext<TextAlignment> arg = new PropertyContext<TextAlignment>(self, SearchBar.HorizontalTextAlignmentProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> HorizontalTextAlignmentFmg<T>(this SettersContext<T> self, TextAlignment horizontalTextAlignment) where T : SearchBar
    {
        self.XamlSetters.Add(new Setter
        {
            Property = SearchBar.HorizontalTextAlignmentProperty,
            Value = horizontalTextAlignment
        });
        return self;
    }

    public static SettersContext<T> HorizontalTextAlignmentFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<TextAlignment>, IPropertySettersBuilder<TextAlignment>> configure) where T : SearchBar
    {
        PropertySettersContext<TextAlignment> arg = new PropertySettersContext<TextAlignment>(self.XamlSetters, SearchBar.HorizontalTextAlignmentProperty);
        configure(arg).Build();
        return self;
    }

    public static T VerticalTextAlignmentFmg<T>(this T self, TextAlignment verticalTextAlignment) where T : SearchBar
    {
        self.SetValue(SearchBar.VerticalTextAlignmentProperty, verticalTextAlignment);
        return self;
    }

    public static T VerticalTextAlignmentFmg<T>(this T self, Func<PropertyContext<TextAlignment>, IPropertyBuilder<TextAlignment>> configure) where T : SearchBar
    {
        PropertyContext<TextAlignment> arg = new PropertyContext<TextAlignment>(self, SearchBar.VerticalTextAlignmentProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> VerticalTextAlignmentFmg<T>(this SettersContext<T> self, TextAlignment verticalTextAlignment) where T : SearchBar
    {
        self.XamlSetters.Add(new Setter
        {
            Property = SearchBar.VerticalTextAlignmentProperty,
            Value = verticalTextAlignment
        });
        return self;
    }

    public static SettersContext<T> VerticalTextAlignmentFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<TextAlignment>, IPropertySettersBuilder<TextAlignment>> configure) where T : SearchBar
    {
        PropertySettersContext<TextAlignment> arg = new PropertySettersContext<TextAlignment>(self.XamlSetters, SearchBar.VerticalTextAlignmentProperty);
        configure(arg).Build();
        return self;
    }

    public static T SearchCommandFmg<T>(this T self, ICommand searchCommand) where T : SearchBar
    {
        self.SetValue(SearchBar.SearchCommandProperty, searchCommand);
        return self;
    }

    public static T SearchCommandFmg<T>(this T self, Func<PropertyContext<ICommand>, IPropertyBuilder<ICommand>> configure) where T : SearchBar
    {
        PropertyContext<ICommand> arg = new PropertyContext<ICommand>(self, SearchBar.SearchCommandProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> SearchCommandFmg<T>(this SettersContext<T> self, ICommand searchCommand) where T : SearchBar
    {
        self.XamlSetters.Add(new Setter
        {
            Property = SearchBar.SearchCommandProperty,
            Value = searchCommand
        });
        return self;
    }

    public static SettersContext<T> SearchCommandFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ICommand>, IPropertySettersBuilder<ICommand>> configure) where T : SearchBar
    {
        PropertySettersContext<ICommand> arg = new PropertySettersContext<ICommand>(self.XamlSetters, SearchBar.SearchCommandProperty);
        configure(arg).Build();
        return self;
    }

    public static T SearchCommandParameterFmg<T>(this T self, object searchCommandParameter) where T : SearchBar
    {
        self.SetValue(SearchBar.SearchCommandParameterProperty, searchCommandParameter);
        return self;
    }

    public static T SearchCommandParameterFmg<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure) where T : SearchBar
    {
        PropertyContext<object> arg = new PropertyContext<object>(self, SearchBar.SearchCommandParameterProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> SearchCommandParameterFmg<T>(this SettersContext<T> self, object searchCommandParameter) where T : SearchBar
    {
        self.XamlSetters.Add(new Setter
        {
            Property = SearchBar.SearchCommandParameterProperty,
            Value = searchCommandParameter
        });
        return self;
    }

    public static SettersContext<T> SearchCommandParameterFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure) where T : SearchBar
    {
        PropertySettersContext<object> arg = new PropertySettersContext<object>(self.XamlSetters, SearchBar.SearchCommandParameterProperty);
        configure(arg).Build();
        return self;
    }

    public static T FontAttributesFmg<T>(this T self, FontAttributes fontAttributes) where T : SearchBar
    {
        self.SetValue(SearchBar.FontAttributesProperty, fontAttributes);
        return self;
    }

    public static T FontAttributesFmg<T>(this T self, Func<PropertyContext<FontAttributes>, IPropertyBuilder<FontAttributes>> configure) where T : SearchBar
    {
        PropertyContext<FontAttributes> arg = new PropertyContext<FontAttributes>(self, SearchBar.FontAttributesProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> FontAttributesFmg<T>(this SettersContext<T> self, FontAttributes fontAttributes) where T : SearchBar
    {
        self.XamlSetters.Add(new Setter
        {
            Property = SearchBar.FontAttributesProperty,
            Value = fontAttributes
        });
        return self;
    }

    public static SettersContext<T> FontAttributesFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<FontAttributes>, IPropertySettersBuilder<FontAttributes>> configure) where T : SearchBar
    {
        PropertySettersContext<FontAttributes> arg = new PropertySettersContext<FontAttributes>(self.XamlSetters, SearchBar.FontAttributesProperty);
        configure(arg).Build();
        return self;
    }

    public static T IsTextPredictionEnabledFmg<T>(this T self, bool isTextPredictionEnabled) where T : SearchBar
    {
        self.SetValue(SearchBar.IsTextPredictionEnabledProperty, isTextPredictionEnabled);
        return self;
    }

    public static T IsTextPredictionEnabledFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure) where T : SearchBar
    {
        PropertyContext<bool> arg = new PropertyContext<bool>(self, SearchBar.IsTextPredictionEnabledProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> IsTextPredictionEnabledFmg<T>(this SettersContext<T> self, bool isTextPredictionEnabled) where T : SearchBar
    {
        self.XamlSetters.Add(new Setter
        {
            Property = SearchBar.IsTextPredictionEnabledProperty,
            Value = isTextPredictionEnabled
        });
        return self;
    }

    public static SettersContext<T> IsTextPredictionEnabledFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure) where T : SearchBar
    {
        PropertySettersContext<bool> arg = new PropertySettersContext<bool>(self.XamlSetters, SearchBar.IsTextPredictionEnabledProperty);
        configure(arg).Build();
        return self;
    }

    public static T CursorPositionFmg<T>(this T self, int cursorPosition) where T : SearchBar
    {
        self.SetValue(SearchBar.CursorPositionProperty, cursorPosition);
        return self;
    }

    public static T CursorPositionFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure) where T : SearchBar
    {
        PropertyContext<int> arg = new PropertyContext<int>(self, SearchBar.CursorPositionProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> CursorPositionFmg<T>(this SettersContext<T> self, int cursorPosition) where T : SearchBar
    {
        self.XamlSetters.Add(new Setter
        {
            Property = SearchBar.CursorPositionProperty,
            Value = cursorPosition
        });
        return self;
    }

    public static SettersContext<T> CursorPositionFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure) where T : SearchBar
    {
        PropertySettersContext<int> arg = new PropertySettersContext<int>(self.XamlSetters, SearchBar.CursorPositionProperty);
        configure(arg).Build();
        return self;
    }

    public static T SelectionLengthFmg<T>(this T self, int selectionLength) where T : SearchBar
    {
        self.SetValue(SearchBar.SelectionLengthProperty, selectionLength);
        return self;
    }

    public static T SelectionLengthFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure) where T : SearchBar
    {
        PropertyContext<int> arg = new PropertyContext<int>(self, SearchBar.SelectionLengthProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> SelectionLengthFmg<T>(this SettersContext<T> self, int selectionLength) where T : SearchBar
    {
        self.XamlSetters.Add(new Setter
        {
            Property = SearchBar.SelectionLengthProperty,
            Value = selectionLength
        });
        return self;
    }

    public static SettersContext<T> SelectionLengthFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure) where T : SearchBar
    {
        PropertySettersContext<int> arg = new PropertySettersContext<int>(self.XamlSetters, SearchBar.SelectionLengthProperty);
        configure(arg).Build();
        return self;
    }

    public static T FontFamilyFmg<T>(this T self, string fontFamily) where T : SearchBar
    {
        self.SetValue(SearchBar.FontFamilyProperty, fontFamily);
        return self;
    }

    public static T FontFamilyFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure) where T : SearchBar
    {
        PropertyContext<string> arg = new PropertyContext<string>(self, SearchBar.FontFamilyProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> FontFamilyFmg<T>(this SettersContext<T> self, string fontFamily) where T : SearchBar
    {
        self.XamlSetters.Add(new Setter
        {
            Property = SearchBar.FontFamilyProperty,
            Value = fontFamily
        });
        return self;
    }

    public static SettersContext<T> FontFamilyFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure) where T : SearchBar
    {
        PropertySettersContext<string> arg = new PropertySettersContext<string>(self.XamlSetters, SearchBar.FontFamilyProperty);
        configure(arg).Build();
        return self;
    }

    public static T FontSizeFmg<T>(this T self, double fontSize) where T : SearchBar
    {
        self.SetValue(SearchBar.FontSizeProperty, fontSize);
        return self;
    }

    public static T FontSizeFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure) where T : SearchBar
    {
        PropertyContext<double> arg = new PropertyContext<double>(self, SearchBar.FontSizeProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> FontSizeFmg<T>(this SettersContext<T> self, double fontSize) where T : SearchBar
    {
        self.XamlSetters.Add(new Setter
        {
            Property = SearchBar.FontSizeProperty,
            Value = fontSize
        });
        return self;
    }

    public static SettersContext<T> FontSizeFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure) where T : SearchBar
    {
        PropertySettersContext<double> arg = new PropertySettersContext<double>(self.XamlSetters, SearchBar.FontSizeProperty);
        configure(arg).Build();
        return self;
    }

    public static Task<bool> AnimateFontSizeToFmg<T>(this T self, double value, uint length = 250u, Easing? easing = null) where T : SearchBar
    {
        T self2 = self;
        double fromValue = ((SearchBar)self2).FontSize;
        return Transformations.AnimateAsync(transform: (double t) => Transformations.DoubleTransform(fromValue, value, t), callback: delegate (double actValue)
        {
            ((SearchBar)self2).FontSize = actValue;
        }, element: self2, name: "AnimateFontSizeTo", length: length, easing: easing);
    }

    public static T FontAutoScalingEnabledFmg<T>(this T self, bool fontAutoScalingEnabled) where T : SearchBar
    {
        self.SetValue(SearchBar.FontAutoScalingEnabledProperty, fontAutoScalingEnabled);
        return self;
    }

    public static T FontAutoScalingEnabledFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure) where T : SearchBar
    {
        PropertyContext<bool> arg = new PropertyContext<bool>(self, SearchBar.FontAutoScalingEnabledProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> FontAutoScalingEnabledFmg<T>(this SettersContext<T> self, bool fontAutoScalingEnabled) where T : SearchBar
    {
        self.XamlSetters.Add(new Setter
        {
            Property = SearchBar.FontAutoScalingEnabledProperty,
            Value = fontAutoScalingEnabled
        });
        return self;
    }

    public static SettersContext<T> FontAutoScalingEnabledFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure) where T : SearchBar
    {
        PropertySettersContext<bool> arg = new PropertySettersContext<bool>(self.XamlSetters, SearchBar.FontAutoScalingEnabledProperty);
        configure(arg).Build();
        return self;
    }

    public static T OnSearchButtonPressedFmg<T>(this T self, EventHandler handler) where T : SearchBar
    {
        self.SearchButtonPressed += handler;
        return self;
    }

    public static T OnSearchButtonPressedFmg<T>(this T self, Action<T> action) where T : SearchBar
    {
        Action<T> action2 = action;
        T self2 = self;
        self2.SearchButtonPressed += delegate
        {
            action2(self2);
        };
        return self2;
    }

    public static T TextCenterHorizontalFmg<T>(this T self) where T : SearchBar
    {
        self.SetValue(SearchBar.HorizontalTextAlignmentProperty, TextAlignment.Center);
        return self;
    }

    public static T TextCenterVerticalFmg<T>(this T self) where T : SearchBar
    {
        self.SetValue(SearchBar.VerticalTextAlignmentProperty, TextAlignment.Center);
        return self;
    }

    public static T TextCenterFmg<T>(this T self) where T : SearchBar
    {
        self.SetValue(SearchBar.HorizontalTextAlignmentProperty, TextAlignment.Center);
        self.SetValue(SearchBar.VerticalTextAlignmentProperty, TextAlignment.Center);
        return self;
    }

    public static T TextTopFmg<T>(this T self) where T : SearchBar
    {
        self.SetValue(SearchBar.VerticalTextAlignmentProperty, TextAlignment.Start);
        return self;
    }

    public static T TextBottomFmg<T>(this T self) where T : SearchBar, ITextAlignment
    {
        self.SetValue(SearchBar.VerticalTextAlignmentProperty, TextAlignment.End);
        return self;
    }

    public static T TextTopStartFmg<T>(this T self) where T : SearchBar
    {
        self.SetValue(SearchBar.VerticalTextAlignmentProperty, TextAlignment.Start);
        self.SetValue(SearchBar.HorizontalTextAlignmentProperty, TextAlignment.Start);
        return self;
    }

    public static T TextBottomStartFmg<T>(this T self) where T : SearchBar
    {
        self.SetValue(SearchBar.VerticalTextAlignmentProperty, TextAlignment.End);
        self.SetValue(SearchBar.HorizontalTextAlignmentProperty, TextAlignment.Start);
        return self;
    }

    public static T TextTopEndFmg<T>(this T self) where T : SearchBar
    {
        self.SetValue(SearchBar.VerticalTextAlignmentProperty, TextAlignment.Start);
        self.SetValue(SearchBar.HorizontalTextAlignmentProperty, TextAlignment.End);
        return self;
    }

    public static T TextBottomEndFmg<T>(this T self) where T : SearchBar
    {
        self.SetValue(SearchBar.VerticalTextAlignmentProperty, TextAlignment.End);
        self.SetValue(SearchBar.HorizontalTextAlignmentProperty, TextAlignment.End);
        return self;
    }

    public static T TextStartFmg<T>(this T self) where T : SearchBar
    {
        self.SetValue(SearchBar.HorizontalTextAlignmentProperty, TextAlignment.Start);
        return self;
    }

    public static T TextEndFmg<T>(this T self) where T : SearchBar
    {
        self.SetValue(SearchBar.HorizontalTextAlignmentProperty, TextAlignment.End);
        return self;
    }
}
