namespace FmgLib.MauiMarkup;



public static partial class SearchBarExtension
{
    public static T CancelButtonColorFmg<T>(this T self,
        Color cancelButtonColor)
        where T : SearchBar
    {
        self.SetValue(SearchBar.CancelButtonColorProperty, cancelButtonColor);
        return self;
    }
    
    public static T CancelButtonColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : SearchBar
    {
        var context = new PropertyContext<Color>(self, SearchBar.CancelButtonColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> CancelButtonColorFmg<T>(this SettersContext<T> self,
        Color cancelButtonColor)
        where T : SearchBar
    {
        self.XamlSetters.Add(new Setter { Property = SearchBar.CancelButtonColorProperty, Value = cancelButtonColor });
        return self;
    }
    
    public static SettersContext<T> CancelButtonColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : SearchBar
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, SearchBar.CancelButtonColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateCancelButtonColorToFmg<T>(this T self, Color value, uint length = 250, Easing? easing = null)
        where T : SearchBar
    {
        Color fromValue = self.CancelButtonColor;
        var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
        var callback = (Color actValue) => { self.CancelButtonColor = actValue; };
        return Transformations.AnimateAsync<Color>(self, "AnimateCancelButtonColorTo", transform, callback, length, easing);
    }
    
    public static T HorizontalTextAlignmentFmg<T>(this T self,
        TextAlignment horizontalTextAlignment)
        where T : SearchBar
    {
        self.SetValue(SearchBar.HorizontalTextAlignmentProperty, horizontalTextAlignment);
        return self;
    }
    
    public static T HorizontalTextAlignmentFmg<T>(this T self, Func<PropertyContext<TextAlignment>, IPropertyBuilder<TextAlignment>> configure)
        where T : SearchBar
    {
        var context = new PropertyContext<TextAlignment>(self, SearchBar.HorizontalTextAlignmentProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> HorizontalTextAlignmentFmg<T>(this SettersContext<T> self,
        TextAlignment horizontalTextAlignment)
        where T : SearchBar
    {
        self.XamlSetters.Add(new Setter { Property = SearchBar.HorizontalTextAlignmentProperty, Value = horizontalTextAlignment });
        return self;
    }
    
    public static SettersContext<T> HorizontalTextAlignmentFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<TextAlignment>, IPropertySettersBuilder<TextAlignment>> configure)
        where T : SearchBar
    {
        var context = new PropertySettersContext<TextAlignment>(self.XamlSetters, SearchBar.HorizontalTextAlignmentProperty);
        configure(context).Build();
        return self;
    }
    
    public static T VerticalTextAlignmentFmg<T>(this T self,
        TextAlignment verticalTextAlignment)
        where T : SearchBar
    {
        self.SetValue(SearchBar.VerticalTextAlignmentProperty, verticalTextAlignment);
        return self;
    }
    
    public static T VerticalTextAlignmentFmg<T>(this T self, Func<PropertyContext<TextAlignment>, IPropertyBuilder<TextAlignment>> configure)
        where T : SearchBar
    {
        var context = new PropertyContext<TextAlignment>(self, SearchBar.VerticalTextAlignmentProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> VerticalTextAlignmentFmg<T>(this SettersContext<T> self,
        TextAlignment verticalTextAlignment)
        where T : SearchBar
    {
        self.XamlSetters.Add(new Setter { Property = SearchBar.VerticalTextAlignmentProperty, Value = verticalTextAlignment });
        return self;
    }
    
    public static SettersContext<T> VerticalTextAlignmentFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<TextAlignment>, IPropertySettersBuilder<TextAlignment>> configure)
        where T : SearchBar
    {
        var context = new PropertySettersContext<TextAlignment>(self.XamlSetters, SearchBar.VerticalTextAlignmentProperty);
        configure(context).Build();
        return self;
    }
    
    public static T SearchCommandFmg<T>(this T self,
        System.Windows.Input.ICommand searchCommand)
        where T : SearchBar
    {
        self.SetValue(SearchBar.SearchCommandProperty, searchCommand);
        return self;
    }
    
    public static T SearchCommandFmg<T>(this T self, Func<PropertyContext<System.Windows.Input.ICommand>, IPropertyBuilder<System.Windows.Input.ICommand>> configure)
        where T : SearchBar
    {
        var context = new PropertyContext<System.Windows.Input.ICommand>(self, SearchBar.SearchCommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> SearchCommandFmg<T>(this SettersContext<T> self,
        System.Windows.Input.ICommand searchCommand)
        where T : SearchBar
    {
        self.XamlSetters.Add(new Setter { Property = SearchBar.SearchCommandProperty, Value = searchCommand });
        return self;
    }
    
    public static SettersContext<T> SearchCommandFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<System.Windows.Input.ICommand>, IPropertySettersBuilder<System.Windows.Input.ICommand>> configure)
        where T : SearchBar
    {
        var context = new PropertySettersContext<System.Windows.Input.ICommand>(self.XamlSetters, SearchBar.SearchCommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static T SearchCommandParameterFmg<T>(this T self,
        object searchCommandParameter)
        where T : SearchBar
    {
        self.SetValue(SearchBar.SearchCommandParameterProperty, searchCommandParameter);
        return self;
    }
    
    public static T SearchCommandParameterFmg<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        where T : SearchBar
    {
        var context = new PropertyContext<object>(self, SearchBar.SearchCommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> SearchCommandParameterFmg<T>(this SettersContext<T> self,
        object searchCommandParameter)
        where T : SearchBar
    {
        self.XamlSetters.Add(new Setter { Property = SearchBar.SearchCommandParameterProperty, Value = searchCommandParameter });
        return self;
    }
    
    public static SettersContext<T> SearchCommandParameterFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        where T : SearchBar
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, SearchBar.SearchCommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FontAttributesFmg<T>(this T self,
        FontAttributes fontAttributes)
        where T : SearchBar
    {
        self.SetValue(SearchBar.FontAttributesProperty, fontAttributes);
        return self;
    }
    
    public static T FontAttributesFmg<T>(this T self, Func<PropertyContext<FontAttributes>, IPropertyBuilder<FontAttributes>> configure)
        where T : SearchBar
    {
        var context = new PropertyContext<FontAttributes>(self, SearchBar.FontAttributesProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FontAttributesFmg<T>(this SettersContext<T> self,
        FontAttributes fontAttributes)
        where T : SearchBar
    {
        self.XamlSetters.Add(new Setter { Property = SearchBar.FontAttributesProperty, Value = fontAttributes });
        return self;
    }
    
    public static SettersContext<T> FontAttributesFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<FontAttributes>, IPropertySettersBuilder<FontAttributes>> configure)
        where T : SearchBar
    {
        var context = new PropertySettersContext<FontAttributes>(self.XamlSetters, SearchBar.FontAttributesProperty);
        configure(context).Build();
        return self;
    }
    
    public static T IsTextPredictionEnabledFmg<T>(this T self,
        bool isTextPredictionEnabled)
        where T : SearchBar
    {
        self.SetValue(SearchBar.IsTextPredictionEnabledProperty, isTextPredictionEnabled);
        return self;
    }
    
    public static T IsTextPredictionEnabledFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : SearchBar
    {
        var context = new PropertyContext<bool>(self, SearchBar.IsTextPredictionEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> IsTextPredictionEnabledFmg<T>(this SettersContext<T> self,
        bool isTextPredictionEnabled)
        where T : SearchBar
    {
        self.XamlSetters.Add(new Setter { Property = SearchBar.IsTextPredictionEnabledProperty, Value = isTextPredictionEnabled });
        return self;
    }
    
    public static SettersContext<T> IsTextPredictionEnabledFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : SearchBar
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, SearchBar.IsTextPredictionEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static T CursorPositionFmg<T>(this T self,
        int cursorPosition)
        where T : SearchBar
    {
        self.SetValue(SearchBar.CursorPositionProperty, cursorPosition);
        return self;
    }
    
    public static T CursorPositionFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
        where T : SearchBar
    {
        var context = new PropertyContext<int>(self, SearchBar.CursorPositionProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> CursorPositionFmg<T>(this SettersContext<T> self,
        int cursorPosition)
        where T : SearchBar
    {
        self.XamlSetters.Add(new Setter { Property = SearchBar.CursorPositionProperty, Value = cursorPosition });
        return self;
    }
    
    public static SettersContext<T> CursorPositionFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure)
        where T : SearchBar
    {
        var context = new PropertySettersContext<int>(self.XamlSetters, SearchBar.CursorPositionProperty);
        configure(context).Build();
        return self;
    }
    
    public static T SelectionLengthFmg<T>(this T self,
        int selectionLength)
        where T : SearchBar
    {
        self.SetValue(SearchBar.SelectionLengthProperty, selectionLength);
        return self;
    }
    
    public static T SelectionLengthFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
        where T : SearchBar
    {
        var context = new PropertyContext<int>(self, SearchBar.SelectionLengthProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> SelectionLengthFmg<T>(this SettersContext<T> self,
        int selectionLength)
        where T : SearchBar
    {
        self.XamlSetters.Add(new Setter { Property = SearchBar.SelectionLengthProperty, Value = selectionLength });
        return self;
    }
    
    public static SettersContext<T> SelectionLengthFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure)
        where T : SearchBar
    {
        var context = new PropertySettersContext<int>(self.XamlSetters, SearchBar.SelectionLengthProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FontFamilyFmg<T>(this T self,
        string fontFamily)
        where T : SearchBar
    {
        self.SetValue(SearchBar.FontFamilyProperty, fontFamily);
        return self;
    }
    
    public static T FontFamilyFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : SearchBar
    {
        var context = new PropertyContext<string>(self, SearchBar.FontFamilyProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FontFamilyFmg<T>(this SettersContext<T> self,
        string fontFamily)
        where T : SearchBar
    {
        self.XamlSetters.Add(new Setter { Property = SearchBar.FontFamilyProperty, Value = fontFamily });
        return self;
    }
    
    public static SettersContext<T> FontFamilyFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : SearchBar
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, SearchBar.FontFamilyProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FontSizeFmg<T>(this T self,
        double fontSize)
        where T : SearchBar
    {
        self.SetValue(SearchBar.FontSizeProperty, fontSize);
        return self;
    }
    
    public static T FontSizeFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : SearchBar
    {
        var context = new PropertyContext<double>(self, SearchBar.FontSizeProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FontSizeFmg<T>(this SettersContext<T> self,
        double fontSize)
        where T : SearchBar
    {
        self.XamlSetters.Add(new Setter { Property = SearchBar.FontSizeProperty, Value = fontSize });
        return self;
    }
    
    public static SettersContext<T> FontSizeFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : SearchBar
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, SearchBar.FontSizeProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateFontSizeToFmg<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : SearchBar
    {
        double fromValue = self.FontSize;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.FontSize = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateFontSizeTo", transform, callback, length, easing);
    }
    
    public static T FontAutoScalingEnabledFmg<T>(this T self,
        bool fontAutoScalingEnabled)
        where T : SearchBar
    {
        self.SetValue(SearchBar.FontAutoScalingEnabledProperty, fontAutoScalingEnabled);
        return self;
    }
    
    public static T FontAutoScalingEnabledFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : SearchBar
    {
        var context = new PropertyContext<bool>(self, SearchBar.FontAutoScalingEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FontAutoScalingEnabledFmg<T>(this SettersContext<T> self,
        bool fontAutoScalingEnabled)
        where T : SearchBar
    {
        self.XamlSetters.Add(new Setter { Property = SearchBar.FontAutoScalingEnabledProperty, Value = fontAutoScalingEnabled });
        return self;
    }
    
    public static SettersContext<T> FontAutoScalingEnabledFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : SearchBar
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, SearchBar.FontAutoScalingEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static T OnSearchButtonPressedFmg<T>(this T self, EventHandler handler)
        where T : SearchBar
    {
        self.SearchButtonPressed += handler;
        return self;
    }
    
    public static T OnSearchButtonPressedFmg<T>(this T self, Action<T> action)
        where T : SearchBar
    {
        self.SearchButtonPressed += (o, arg) => action(self);
        return self;
    }
    

    public static T TextCenterHorizontalFmg<T>(this T self)
        where T : SearchBar
    {
        self.SetValue(SearchBar.HorizontalTextAlignmentProperty, TextAlignment.Center);
        return self;
    }

    public static T TextCenterVerticalFmg<T>(this T self)
        where T : SearchBar
    {
        self.SetValue(SearchBar.VerticalTextAlignmentProperty, TextAlignment.Center);
        return self;
    }

    public static T TextCenterFmg<T>(this T self)
        where T : SearchBar
    {
        self.SetValue(SearchBar.HorizontalTextAlignmentProperty, TextAlignment.Center);
        self.SetValue(SearchBar.VerticalTextAlignmentProperty, TextAlignment.Center);
        return self;
    }

    public static T TextTopFmg<T>(this T self)
        where T : SearchBar
    {
        self.SetValue(SearchBar.VerticalTextAlignmentProperty, TextAlignment.Start);
        return self;
    }

    public static T TextBottomFmg<T>(this T self)
        where T : SearchBar, Microsoft.Maui.ITextAlignment
    {
        self.SetValue(SearchBar.VerticalTextAlignmentProperty, TextAlignment.End);
        return self;
    }

    public static T TextTopStartFmg<T>(this T self)
        where T : SearchBar
    {
        self.SetValue(SearchBar.VerticalTextAlignmentProperty, TextAlignment.Start);
        self.SetValue(SearchBar.HorizontalTextAlignmentProperty, TextAlignment.Start);
        return self;
    }

    public static T TextBottomStartFmg<T>(this T self)
        where T : SearchBar
    {
        self.SetValue(SearchBar.VerticalTextAlignmentProperty, TextAlignment.End);
        self.SetValue(SearchBar.HorizontalTextAlignmentProperty, TextAlignment.Start);
        return self;
    }

    public static T TextTopEndFmg<T>(this T self)
        where T : SearchBar
    {
        self.SetValue(SearchBar.VerticalTextAlignmentProperty, TextAlignment.Start);
        self.SetValue(SearchBar.HorizontalTextAlignmentProperty, TextAlignment.End);
        return self;
    }

    public static T TextBottomEndFmg<T>(this T self)
        where T : SearchBar
    {
        self.SetValue(SearchBar.VerticalTextAlignmentProperty, TextAlignment.End);
        self.SetValue(SearchBar.HorizontalTextAlignmentProperty, TextAlignment.End);
        return self;
    }

    public static T TextStartFmg<T>(this T self)
        where T : SearchBar
    {
        self.SetValue(SearchBar.HorizontalTextAlignmentProperty, TextAlignment.Start);
        return self;
    }

    public static T TextEndFmg<T>(this T self)
        where T : SearchBar
    {
        self.SetValue(SearchBar.HorizontalTextAlignmentProperty, TextAlignment.End);
        return self;
    }

    
}
