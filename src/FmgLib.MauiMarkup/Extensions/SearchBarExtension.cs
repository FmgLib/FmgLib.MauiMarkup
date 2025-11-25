namespace FmgLib.MauiMarkup;



public static partial class SearchBarExtension
{
    public static T SearchIconColor<T>(this T self,
        Color searchIconColor)
        where T : SearchBar
    {
        self.SetValue(SearchBar.SearchIconColorProperty, searchIconColor);
        return self;
    }

    public static T SearchIconColor<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : SearchBar
    {
        var context = new PropertyContext<Color>(self, SearchBar.SearchIconColorProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> SearchIconColor<T>(this SettersContext<T> self,
        Color searchIconColor)
        where T : SearchBar
    {
        self.XamlSetters.Add(new Setter { Property = SearchBar.SearchIconColorProperty, Value = searchIconColor });
        return self;
    }

    public static SettersContext<T> SearchIconColor<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : SearchBar
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, SearchBar.SearchIconColorProperty);
        configure(context).Build();
        return self;
    }

    public static T ReturnType<T>(this T self,
        ReturnType returnType)
        where T : SearchBar
    {
        self.SetValue(SearchBar.ReturnTypeProperty, returnType);
        return self;
    }

    public static T ReturnType<T>(this T self, Func<PropertyContext<ReturnType>, IPropertyBuilder<ReturnType>> configure)
        where T : SearchBar
    {
        var context = new PropertyContext<ReturnType>(self, SearchBar.ReturnTypeProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ReturnType<T>(this SettersContext<T> self,
        ReturnType returnType)
        where T : SearchBar
    {
        self.XamlSetters.Add(new Setter { Property = SearchBar.ReturnTypeProperty, Value = returnType });
        return self;
    }

    public static SettersContext<T> ReturnType<T>(this SettersContext<T> self, Func<PropertySettersContext<ReturnType>, IPropertySettersBuilder<ReturnType>> configure)
        where T : SearchBar
    {
        var context = new PropertySettersContext<ReturnType>(self.XamlSetters, SearchBar.ReturnTypeProperty);
        configure(context).Build();
        return self;
    }

    public static T CancelButtonColor<T>(this T self,
        Color cancelButtonColor)
        where T : SearchBar
    {
        self.SetValue(SearchBar.CancelButtonColorProperty, cancelButtonColor);
        return self;
    }
    
    public static T CancelButtonColor<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : SearchBar
    {
        var context = new PropertyContext<Color>(self, SearchBar.CancelButtonColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> CancelButtonColor<T>(this SettersContext<T> self,
        Color cancelButtonColor)
        where T : SearchBar
    {
        self.XamlSetters.Add(new Setter { Property = SearchBar.CancelButtonColorProperty, Value = cancelButtonColor });
        return self;
    }
    
    public static SettersContext<T> CancelButtonColor<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : SearchBar
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, SearchBar.CancelButtonColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateCancelButtonColorTo<T>(this T self, Color value, uint length = 250, Easing? easing = null)
        where T : SearchBar
    {
        Color fromValue = self.CancelButtonColor;
        var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
        var callback = (Color actValue) => { self.CancelButtonColor = actValue; };
        return Transformations.AnimateAsync<Color>(self, "AnimateCancelButtonColorTo", transform, callback, length, easing);
    }
    
    public static T HorizontalTextAlignment<T>(this T self,
        TextAlignment horizontalTextAlignment)
        where T : SearchBar
    {
        self.SetValue(SearchBar.HorizontalTextAlignmentProperty, horizontalTextAlignment);
        return self;
    }
    
    public static T HorizontalTextAlignment<T>(this T self, Func<PropertyContext<TextAlignment>, IPropertyBuilder<TextAlignment>> configure)
        where T : SearchBar
    {
        var context = new PropertyContext<TextAlignment>(self, SearchBar.HorizontalTextAlignmentProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> HorizontalTextAlignment<T>(this SettersContext<T> self,
        TextAlignment horizontalTextAlignment)
        where T : SearchBar
    {
        self.XamlSetters.Add(new Setter { Property = SearchBar.HorizontalTextAlignmentProperty, Value = horizontalTextAlignment });
        return self;
    }
    
    public static SettersContext<T> HorizontalTextAlignment<T>(this SettersContext<T> self, Func<PropertySettersContext<TextAlignment>, IPropertySettersBuilder<TextAlignment>> configure)
        where T : SearchBar
    {
        var context = new PropertySettersContext<TextAlignment>(self.XamlSetters, SearchBar.HorizontalTextAlignmentProperty);
        configure(context).Build();
        return self;
    }
    
    public static T VerticalTextAlignment<T>(this T self,
        TextAlignment verticalTextAlignment)
        where T : SearchBar
    {
        self.SetValue(SearchBar.VerticalTextAlignmentProperty, verticalTextAlignment);
        return self;
    }
    
    public static T VerticalTextAlignment<T>(this T self, Func<PropertyContext<TextAlignment>, IPropertyBuilder<TextAlignment>> configure)
        where T : SearchBar
    {
        var context = new PropertyContext<TextAlignment>(self, SearchBar.VerticalTextAlignmentProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> VerticalTextAlignment<T>(this SettersContext<T> self,
        TextAlignment verticalTextAlignment)
        where T : SearchBar
    {
        self.XamlSetters.Add(new Setter { Property = SearchBar.VerticalTextAlignmentProperty, Value = verticalTextAlignment });
        return self;
    }
    
    public static SettersContext<T> VerticalTextAlignment<T>(this SettersContext<T> self, Func<PropertySettersContext<TextAlignment>, IPropertySettersBuilder<TextAlignment>> configure)
        where T : SearchBar
    {
        var context = new PropertySettersContext<TextAlignment>(self.XamlSetters, SearchBar.VerticalTextAlignmentProperty);
        configure(context).Build();
        return self;
    }
    
    public static T SearchCommand<T>(this T self,
        System.Windows.Input.ICommand searchCommand)
        where T : SearchBar
    {
        self.SetValue(SearchBar.SearchCommandProperty, searchCommand);
        return self;
    }
    
    public static T SearchCommand<T>(this T self, Func<PropertyContext<System.Windows.Input.ICommand>, IPropertyBuilder<System.Windows.Input.ICommand>> configure)
        where T : SearchBar
    {
        var context = new PropertyContext<System.Windows.Input.ICommand>(self, SearchBar.SearchCommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> SearchCommand<T>(this SettersContext<T> self,
        System.Windows.Input.ICommand searchCommand)
        where T : SearchBar
    {
        self.XamlSetters.Add(new Setter { Property = SearchBar.SearchCommandProperty, Value = searchCommand });
        return self;
    }
    
    public static SettersContext<T> SearchCommand<T>(this SettersContext<T> self, Func<PropertySettersContext<System.Windows.Input.ICommand>, IPropertySettersBuilder<System.Windows.Input.ICommand>> configure)
        where T : SearchBar
    {
        var context = new PropertySettersContext<System.Windows.Input.ICommand>(self.XamlSetters, SearchBar.SearchCommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static T SearchCommandParameter<T>(this T self,
        object searchCommandParameter)
        where T : SearchBar
    {
        self.SetValue(SearchBar.SearchCommandParameterProperty, searchCommandParameter);
        return self;
    }
    
    public static T SearchCommandParameter<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        where T : SearchBar
    {
        var context = new PropertyContext<object>(self, SearchBar.SearchCommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> SearchCommandParameter<T>(this SettersContext<T> self,
        object searchCommandParameter)
        where T : SearchBar
    {
        self.XamlSetters.Add(new Setter { Property = SearchBar.SearchCommandParameterProperty, Value = searchCommandParameter });
        return self;
    }
    
    public static SettersContext<T> SearchCommandParameter<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        where T : SearchBar
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, SearchBar.SearchCommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FontAttributes<T>(this T self,
        FontAttributes fontAttributes)
        where T : SearchBar
    {
        self.SetValue(SearchBar.FontAttributesProperty, fontAttributes);
        return self;
    }
    
    public static T FontAttributes<T>(this T self, Func<PropertyContext<FontAttributes>, IPropertyBuilder<FontAttributes>> configure)
        where T : SearchBar
    {
        var context = new PropertyContext<FontAttributes>(self, SearchBar.FontAttributesProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FontAttributes<T>(this SettersContext<T> self,
        FontAttributes fontAttributes)
        where T : SearchBar
    {
        self.XamlSetters.Add(new Setter { Property = SearchBar.FontAttributesProperty, Value = fontAttributes });
        return self;
    }
    
    public static SettersContext<T> FontAttributes<T>(this SettersContext<T> self, Func<PropertySettersContext<FontAttributes>, IPropertySettersBuilder<FontAttributes>> configure)
        where T : SearchBar
    {
        var context = new PropertySettersContext<FontAttributes>(self.XamlSetters, SearchBar.FontAttributesProperty);
        configure(context).Build();
        return self;
    }
    
    public static T IsTextPredictionEnabled<T>(this T self,
        bool isTextPredictionEnabled)
        where T : SearchBar
    {
        self.SetValue(SearchBar.IsTextPredictionEnabledProperty, isTextPredictionEnabled);
        return self;
    }
    
    public static T IsTextPredictionEnabled<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : SearchBar
    {
        var context = new PropertyContext<bool>(self, SearchBar.IsTextPredictionEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> IsTextPredictionEnabled<T>(this SettersContext<T> self,
        bool isTextPredictionEnabled)
        where T : SearchBar
    {
        self.XamlSetters.Add(new Setter { Property = SearchBar.IsTextPredictionEnabledProperty, Value = isTextPredictionEnabled });
        return self;
    }
    
    public static SettersContext<T> IsTextPredictionEnabled<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : SearchBar
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, SearchBar.IsTextPredictionEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static T CursorPosition<T>(this T self,
        int cursorPosition)
        where T : SearchBar
    {
        self.SetValue(SearchBar.CursorPositionProperty, cursorPosition);
        return self;
    }
    
    public static T CursorPosition<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
        where T : SearchBar
    {
        var context = new PropertyContext<int>(self, SearchBar.CursorPositionProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> CursorPosition<T>(this SettersContext<T> self,
        int cursorPosition)
        where T : SearchBar
    {
        self.XamlSetters.Add(new Setter { Property = SearchBar.CursorPositionProperty, Value = cursorPosition });
        return self;
    }
    
    public static SettersContext<T> CursorPosition<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure)
        where T : SearchBar
    {
        var context = new PropertySettersContext<int>(self.XamlSetters, SearchBar.CursorPositionProperty);
        configure(context).Build();
        return self;
    }
    
    public static T SelectionLength<T>(this T self,
        int selectionLength)
        where T : SearchBar
    {
        self.SetValue(SearchBar.SelectionLengthProperty, selectionLength);
        return self;
    }
    
    public static T SelectionLength<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
        where T : SearchBar
    {
        var context = new PropertyContext<int>(self, SearchBar.SelectionLengthProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> SelectionLength<T>(this SettersContext<T> self,
        int selectionLength)
        where T : SearchBar
    {
        self.XamlSetters.Add(new Setter { Property = SearchBar.SelectionLengthProperty, Value = selectionLength });
        return self;
    }
    
    public static SettersContext<T> SelectionLength<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure)
        where T : SearchBar
    {
        var context = new PropertySettersContext<int>(self.XamlSetters, SearchBar.SelectionLengthProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FontFamily<T>(this T self,
        string fontFamily)
        where T : SearchBar
    {
        self.SetValue(SearchBar.FontFamilyProperty, fontFamily);
        return self;
    }
    
    public static T FontFamily<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : SearchBar
    {
        var context = new PropertyContext<string>(self, SearchBar.FontFamilyProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FontFamily<T>(this SettersContext<T> self,
        string fontFamily)
        where T : SearchBar
    {
        self.XamlSetters.Add(new Setter { Property = SearchBar.FontFamilyProperty, Value = fontFamily });
        return self;
    }
    
    public static SettersContext<T> FontFamily<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : SearchBar
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, SearchBar.FontFamilyProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FontSize<T>(this T self,
        double fontSize)
        where T : SearchBar
    {
        self.SetValue(SearchBar.FontSizeProperty, fontSize);
        return self;
    }
    
    public static T FontSize<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : SearchBar
    {
        var context = new PropertyContext<double>(self, SearchBar.FontSizeProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FontSize<T>(this SettersContext<T> self,
        double fontSize)
        where T : SearchBar
    {
        self.XamlSetters.Add(new Setter { Property = SearchBar.FontSizeProperty, Value = fontSize });
        return self;
    }
    
    public static SettersContext<T> FontSize<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : SearchBar
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, SearchBar.FontSizeProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateFontSizeTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : SearchBar
    {
        double fromValue = self.FontSize;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.FontSize = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateFontSizeTo", transform, callback, length, easing);
    }
    
    public static T FontAutoScalingEnabled<T>(this T self,
        bool fontAutoScalingEnabled)
        where T : SearchBar
    {
        self.SetValue(SearchBar.FontAutoScalingEnabledProperty, fontAutoScalingEnabled);
        return self;
    }
    
    public static T FontAutoScalingEnabled<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : SearchBar
    {
        var context = new PropertyContext<bool>(self, SearchBar.FontAutoScalingEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FontAutoScalingEnabled<T>(this SettersContext<T> self,
        bool fontAutoScalingEnabled)
        where T : SearchBar
    {
        self.XamlSetters.Add(new Setter { Property = SearchBar.FontAutoScalingEnabledProperty, Value = fontAutoScalingEnabled });
        return self;
    }
    
    public static SettersContext<T> FontAutoScalingEnabled<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : SearchBar
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, SearchBar.FontAutoScalingEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static T OnSearchButtonPressed<T>(this T self, EventHandler handler)
        where T : SearchBar
    {
        self.SearchButtonPressed += handler;
        return self;
    }
    
    public static T OnSearchButtonPressed<T>(this T self, Action<T> action)
        where T : SearchBar
    {
        self.SearchButtonPressed += (o, arg) => action(self);
        return self;
    }


    public static T AlignText<T>(this T self, TextAlignment vertical, TextAlignment horizontal)
        where T : SearchBar
    {
        self.SetValue(SearchBar.VerticalTextAlignmentProperty, vertical);
        self.SetValue(SearchBar.HorizontalTextAlignmentProperty, horizontal);
        return self;
    }

    public static SettersContext<T> AlignText<T>(this SettersContext<T> self, TextAlignment vertical, TextAlignment horizontal)
        where T : SearchBar
    {
        self.XamlSetters.Add(new Setter { Property = SearchBar.VerticalTextAlignmentProperty, Value = vertical });
        self.XamlSetters.Add(new Setter { Property = SearchBar.HorizontalTextAlignmentProperty, Value = horizontal });
        return self;
    }

    public static T TextCenterHorizontal<T>(this T self)
        where T : SearchBar
    {
        self.SetValue(SearchBar.HorizontalTextAlignmentProperty, TextAlignment.Center);
        return self;
    }

    public static SettersContext<T> TextCenterHorizontal<T>(this SettersContext<T> self)
        where T : SearchBar
    {
        self.XamlSetters.Add(new Setter { Property = SearchBar.HorizontalTextAlignmentProperty, Value = TextAlignment.Center });
        return self;
    }

    public static T TextCenterVertical<T>(this T self)
        where T : SearchBar
    {
        self.SetValue(SearchBar.VerticalTextAlignmentProperty, TextAlignment.Center);
        return self;
    }

    public static SettersContext<T> TextCenterVertical<T>(this SettersContext<T> self)
        where T : SearchBar
    {
        self.XamlSetters.Add(new Setter { Property = SearchBar.VerticalTextAlignmentProperty, Value = TextAlignment.Center });
        return self;
    }

    public static T TextCenter<T>(this T self)
        where T : SearchBar
    {
        self.SetValue(SearchBar.HorizontalTextAlignmentProperty, TextAlignment.Center);
        self.SetValue(SearchBar.VerticalTextAlignmentProperty, TextAlignment.Center);
        return self;
    }

    public static SettersContext<T> TextCenter<T>(this SettersContext<T> self)
        where T : SearchBar
    {
        self.XamlSetters.Add(new Setter { Property = SearchBar.VerticalTextAlignmentProperty, Value = TextAlignment.Center });
        self.XamlSetters.Add(new Setter { Property = SearchBar.HorizontalTextAlignmentProperty, Value = TextAlignment.Center });
        return self;
    }

    public static T TextTop<T>(this T self)
        where T : SearchBar
    {
        self.SetValue(SearchBar.VerticalTextAlignmentProperty, TextAlignment.Start);
        return self;
    }

    public static SettersContext<T> TextTop<T>(this SettersContext<T> self)
        where T : SearchBar
    {
        self.XamlSetters.Add(new Setter { Property = SearchBar.VerticalTextAlignmentProperty, Value = TextAlignment.Start });
        return self;
    }

    public static T TextBottom<T>(this T self)
        where T : SearchBar
    {
        self.SetValue(SearchBar.VerticalTextAlignmentProperty, TextAlignment.End);
        return self;
    }

    public static SettersContext<T> TextBottom<T>(this SettersContext<T> self)
        where T : SearchBar
    {
        self.XamlSetters.Add(new Setter { Property = SearchBar.VerticalTextAlignmentProperty, Value = TextAlignment.End });
        return self;
    }

    public static T TextTopLeft<T>(this T self)
        where T : SearchBar
    {
        self.SetValue(SearchBar.VerticalTextAlignmentProperty, TextAlignment.Start);
        self.SetValue(SearchBar.HorizontalTextAlignmentProperty, TextAlignment.Start);
        return self;
    }

    public static SettersContext<T> TextTopLeft<T>(this SettersContext<T> self)
        where T : SearchBar
    {
        self.XamlSetters.Add(new Setter { Property = SearchBar.VerticalTextAlignmentProperty, Value = TextAlignment.Start });
        self.XamlSetters.Add(new Setter { Property = SearchBar.HorizontalTextAlignmentProperty, Value = TextAlignment.Start });
        return self;
    }

    public static T TextBottomLeft<T>(this T self)
        where T : SearchBar
    {
        self.SetValue(SearchBar.VerticalTextAlignmentProperty, TextAlignment.End);
        self.SetValue(SearchBar.HorizontalTextAlignmentProperty, TextAlignment.Start);
        return self;
    }

    public static SettersContext<T> TextBottomLeft<T>(this SettersContext<T> self)
        where T : SearchBar
    {
        self.XamlSetters.Add(new Setter { Property = SearchBar.VerticalTextAlignmentProperty, Value = TextAlignment.End });
        self.XamlSetters.Add(new Setter { Property = SearchBar.HorizontalTextAlignmentProperty, Value = TextAlignment.Start });
        return self;
    }

    public static T TextTopCenter<T>(this T self)
        where T : SearchBar
    {
        self.SetValue(SearchBar.VerticalTextAlignmentProperty, TextAlignment.Start);
        self.SetValue(SearchBar.HorizontalTextAlignmentProperty, TextAlignment.Center);
        return self;
    }

    public static SettersContext<T> TextTopCenter<T>(this SettersContext<T> self)
        where T : SearchBar
    {
        self.XamlSetters.Add(new Setter { Property = SearchBar.VerticalTextAlignmentProperty, Value = TextAlignment.Start });
        self.XamlSetters.Add(new Setter { Property = SearchBar.HorizontalTextAlignmentProperty, Value = TextAlignment.Center });
        return self;
    }

    public static T TextBottomCenter<T>(this T self)
        where T : SearchBar
    {
        self.SetValue(SearchBar.VerticalTextAlignmentProperty, TextAlignment.End);
        self.SetValue(SearchBar.HorizontalTextAlignmentProperty, TextAlignment.Center);
        return self;
    }

    public static SettersContext<T> TextBottomCenter<T>(this SettersContext<T> self)
        where T : SearchBar
    {
        self.XamlSetters.Add(new Setter { Property = SearchBar.VerticalTextAlignmentProperty, Value = TextAlignment.End });
        self.XamlSetters.Add(new Setter { Property = SearchBar.HorizontalTextAlignmentProperty, Value = TextAlignment.Center });
        return self;
    }

    public static T TextCenterRight<T>(this T self)
        where T : SearchBar
    {
        self.SetValue(SearchBar.VerticalTextAlignmentProperty, TextAlignment.Center);
        self.SetValue(SearchBar.HorizontalTextAlignmentProperty, TextAlignment.End);
        return self;
    }

    public static SettersContext<T> TextCenterRight<T>(this SettersContext<T> self)
        where T : SearchBar
    {
        self.XamlSetters.Add(new Setter { Property = SearchBar.VerticalTextAlignmentProperty, Value = TextAlignment.Center });
        self.XamlSetters.Add(new Setter { Property = SearchBar.HorizontalTextAlignmentProperty, Value = TextAlignment.End });
        return self;
    }

    public static T TextCenterLeft<T>(this T self)
        where T : SearchBar
    {
        self.SetValue(SearchBar.VerticalTextAlignmentProperty, TextAlignment.Center);
        self.SetValue(SearchBar.HorizontalTextAlignmentProperty, TextAlignment.Start);
        return self;
    }

    public static SettersContext<T> TextCenterLeft<T>(this SettersContext<T> self)
        where T : SearchBar
    {
        self.XamlSetters.Add(new Setter { Property = SearchBar.VerticalTextAlignmentProperty, Value = TextAlignment.Center });
        self.XamlSetters.Add(new Setter { Property = SearchBar.HorizontalTextAlignmentProperty, Value = TextAlignment.Start });
        return self;
    }

    public static T TextTopRight<T>(this T self)
        where T : SearchBar
    {
        self.SetValue(SearchBar.VerticalTextAlignmentProperty, TextAlignment.Start);
        self.SetValue(SearchBar.HorizontalTextAlignmentProperty, TextAlignment.End);
        return self;
    }

    public static SettersContext<T> TextTopRight<T>(this SettersContext<T> self)
        where T : SearchBar
    {
        self.XamlSetters.Add(new Setter { Property = SearchBar.VerticalTextAlignmentProperty, Value = TextAlignment.Start });
        self.XamlSetters.Add(new Setter { Property = SearchBar.HorizontalTextAlignmentProperty, Value = TextAlignment.End });
        return self;
    }

    public static T TextBottomRight<T>(this T self)
        where T : SearchBar
    {
        self.SetValue(SearchBar.VerticalTextAlignmentProperty, TextAlignment.End);
        self.SetValue(SearchBar.HorizontalTextAlignmentProperty, TextAlignment.End);
        return self;
    }

    public static SettersContext<T> TextBottomRight<T>(this SettersContext<T> self)
        where T : SearchBar
    {
        self.XamlSetters.Add(new Setter { Property = SearchBar.VerticalTextAlignmentProperty, Value = TextAlignment.End });
        self.XamlSetters.Add(new Setter { Property = SearchBar.HorizontalTextAlignmentProperty, Value = TextAlignment.End });
        return self;
    }

    public static T TextLeft<T>(this T self)
        where T : SearchBar
    {
        self.SetValue(SearchBar.HorizontalTextAlignmentProperty, TextAlignment.Start);
        return self;
    }

    public static SettersContext<T> TextLeft<T>(this SettersContext<T> self)
        where T : SearchBar
    {
        self.XamlSetters.Add(new Setter { Property = SearchBar.HorizontalTextAlignmentProperty, Value = TextAlignment.Start });
        return self;
    }

    public static T TextRight<T>(this T self)
        where T : SearchBar
    {
        self.SetValue(SearchBar.HorizontalTextAlignmentProperty, TextAlignment.End);
        return self;
    }

    public static SettersContext<T> TextRight<T>(this SettersContext<T> self)
        where T : SearchBar
    {
        self.XamlSetters.Add(new Setter { Property = SearchBar.HorizontalTextAlignmentProperty, Value = TextAlignment.End });
        return self;
    }
}
