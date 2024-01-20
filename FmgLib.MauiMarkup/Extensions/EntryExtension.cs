namespace FmgLib.MauiMarkup;

public static partial class EntryExtension
{
    public static T HorizontalTextAlignmentFmg<T>(this T self,
        TextAlignment horizontalTextAlignment)
        where T : Entry
    {
        self.SetValue(Entry.HorizontalTextAlignmentProperty, horizontalTextAlignment);
        return self;
    }
    
    public static T HorizontalTextAlignmentFmg<T>(this T self, Func<PropertyContext<TextAlignment>, IPropertyBuilder<TextAlignment>> configure)
        where T : Entry
    {
        var context = new PropertyContext<TextAlignment>(self, Entry.HorizontalTextAlignmentProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> HorizontalTextAlignmentFmg<T>(this SettersContext<T> self,
        TextAlignment horizontalTextAlignment)
        where T : Entry
    {
        self.XamlSetters.Add(new Setter { Property = Entry.HorizontalTextAlignmentProperty, Value = horizontalTextAlignment });
        return self;
    }
    
    public static SettersContext<T> HorizontalTextAlignmentFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<TextAlignment>, IPropertySettersBuilder<TextAlignment>> configure)
        where T : Entry
    {
        var context = new PropertySettersContext<TextAlignment>(self.XamlSetters, Entry.HorizontalTextAlignmentProperty);
        configure(context).Build();
        return self;
    }
    
    public static T VerticalTextAlignmentFmg<T>(this T self,
        TextAlignment verticalTextAlignment)
        where T : Entry
    {
        self.SetValue(Entry.VerticalTextAlignmentProperty, verticalTextAlignment);
        return self;
    }
    
    public static T VerticalTextAlignmentFmg<T>(this T self, Func<PropertyContext<TextAlignment>, IPropertyBuilder<TextAlignment>> configure)
        where T : Entry
    {
        var context = new PropertyContext<TextAlignment>(self, Entry.VerticalTextAlignmentProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> VerticalTextAlignmentFmg<T>(this SettersContext<T> self,
        TextAlignment verticalTextAlignment)
        where T : Entry
    {
        self.XamlSetters.Add(new Setter { Property = Entry.VerticalTextAlignmentProperty, Value = verticalTextAlignment });
        return self;
    }
    
    public static SettersContext<T> VerticalTextAlignmentFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<TextAlignment>, IPropertySettersBuilder<TextAlignment>> configure)
        where T : Entry
    {
        var context = new PropertySettersContext<TextAlignment>(self.XamlSetters, Entry.VerticalTextAlignmentProperty);
        configure(context).Build();
        return self;
    }
    
    public static T IsPasswordFmg<T>(this T self,
        bool isPassword)
        where T : Entry
    {
        self.SetValue(Entry.IsPasswordProperty, isPassword);
        return self;
    }
    
    public static T IsPasswordFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : Entry
    {
        var context = new PropertyContext<bool>(self, Entry.IsPasswordProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> IsPasswordFmg<T>(this SettersContext<T> self,
        bool isPassword)
        where T : Entry
    {
        self.XamlSetters.Add(new Setter { Property = Entry.IsPasswordProperty, Value = isPassword });
        return self;
    }
    
    public static SettersContext<T> IsPasswordFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : Entry
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, Entry.IsPasswordProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FontAttributesFmg<T>(this T self,
        FontAttributes fontAttributes)
        where T : Entry
    {
        self.SetValue(Entry.FontAttributesProperty, fontAttributes);
        return self;
    }
    
    public static T FontAttributesFmg<T>(this T self, Func<PropertyContext<FontAttributes>, IPropertyBuilder<FontAttributes>> configure)
        where T : Entry
    {
        var context = new PropertyContext<FontAttributes>(self, Entry.FontAttributesProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FontAttributesFmg<T>(this SettersContext<T> self,
        FontAttributes fontAttributes)
        where T : Entry
    {
        self.XamlSetters.Add(new Setter { Property = Entry.FontAttributesProperty, Value = fontAttributes });
        return self;
    }
    
    public static SettersContext<T> FontAttributesFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<FontAttributes>, IPropertySettersBuilder<FontAttributes>> configure)
        where T : Entry
    {
        var context = new PropertySettersContext<FontAttributes>(self.XamlSetters, Entry.FontAttributesProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FontFamilyFmg<T>(this T self,
        string fontFamily)
        where T : Entry
    {
        self.SetValue(Entry.FontFamilyProperty, fontFamily);
        return self;
    }
    
    public static T FontFamilyFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : Entry
    {
        var context = new PropertyContext<string>(self, Entry.FontFamilyProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FontFamilyFmg<T>(this SettersContext<T> self,
        string fontFamily)
        where T : Entry
    {
        self.XamlSetters.Add(new Setter { Property = Entry.FontFamilyProperty, Value = fontFamily });
        return self;
    }
    
    public static SettersContext<T> FontFamilyFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : Entry
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, Entry.FontFamilyProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FontSizeFmg<T>(this T self,
        double fontSize)
        where T : Entry
    {
        self.SetValue(Entry.FontSizeProperty, fontSize);
        return self;
    }
    
    public static T FontSizeFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Entry
    {
        var context = new PropertyContext<double>(self, Entry.FontSizeProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FontSizeFmg<T>(this SettersContext<T> self,
        double fontSize)
        where T : Entry
    {
        self.XamlSetters.Add(new Setter { Property = Entry.FontSizeProperty, Value = fontSize });
        return self;
    }
    
    public static SettersContext<T> FontSizeFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Entry
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Entry.FontSizeProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateFontSizeToFmg<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : Entry
    {
        double fromValue = self.FontSize;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.FontSize = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateFontSizeTo", transform, callback, length, easing);
    }
    
    public static T FontAutoScalingEnabledFmg<T>(this T self,
        bool fontAutoScalingEnabled)
        where T : Entry
    {
        self.SetValue(Entry.FontAutoScalingEnabledProperty, fontAutoScalingEnabled);
        return self;
    }
    
    public static T FontAutoScalingEnabledFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : Entry
    {
        var context = new PropertyContext<bool>(self, Entry.FontAutoScalingEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FontAutoScalingEnabledFmg<T>(this SettersContext<T> self,
        bool fontAutoScalingEnabled)
        where T : Entry
    {
        self.XamlSetters.Add(new Setter { Property = Entry.FontAutoScalingEnabledProperty, Value = fontAutoScalingEnabled });
        return self;
    }
    
    public static SettersContext<T> FontAutoScalingEnabledFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : Entry
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, Entry.FontAutoScalingEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static T IsTextPredictionEnabledFmg<T>(this T self,
        bool isTextPredictionEnabled)
        where T : Entry
    {
        self.SetValue(Entry.IsTextPredictionEnabledProperty, isTextPredictionEnabled);
        return self;
    }
    
    public static T IsTextPredictionEnabledFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : Entry
    {
        var context = new PropertyContext<bool>(self, Entry.IsTextPredictionEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> IsTextPredictionEnabledFmg<T>(this SettersContext<T> self,
        bool isTextPredictionEnabled)
        where T : Entry
    {
        self.XamlSetters.Add(new Setter { Property = Entry.IsTextPredictionEnabledProperty, Value = isTextPredictionEnabled });
        return self;
    }
    
    public static SettersContext<T> IsTextPredictionEnabledFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : Entry
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, Entry.IsTextPredictionEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static T ReturnTypeFmg<T>(this T self,
        Microsoft.Maui.ReturnType returnType)
        where T : Entry
    {
        self.SetValue(Entry.ReturnTypeProperty, returnType);
        return self;
    }
    
    public static T ReturnTypeFmg<T>(this T self, Func<PropertyContext<Microsoft.Maui.ReturnType>, IPropertyBuilder<Microsoft.Maui.ReturnType>> configure)
        where T : Entry
    {
        var context = new PropertyContext<Microsoft.Maui.ReturnType>(self, Entry.ReturnTypeProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ReturnTypeFmg<T>(this SettersContext<T> self,
        Microsoft.Maui.ReturnType returnType)
        where T : Entry
    {
        self.XamlSetters.Add(new Setter { Property = Entry.ReturnTypeProperty, Value = returnType });
        return self;
    }
    
    public static SettersContext<T> ReturnTypeFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.ReturnType>, IPropertySettersBuilder<Microsoft.Maui.ReturnType>> configure)
        where T : Entry
    {
        var context = new PropertySettersContext<Microsoft.Maui.ReturnType>(self.XamlSetters, Entry.ReturnTypeProperty);
        configure(context).Build();
        return self;
    }
    
    public static T CursorPositionFmg<T>(this T self,
        int cursorPosition)
        where T : Entry
    {
        self.SetValue(Entry.CursorPositionProperty, cursorPosition);
        return self;
    }
    
    public static T CursorPositionFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
        where T : Entry
    {
        var context = new PropertyContext<int>(self, Entry.CursorPositionProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> CursorPositionFmg<T>(this SettersContext<T> self,
        int cursorPosition)
        where T : Entry
    {
        self.XamlSetters.Add(new Setter { Property = Entry.CursorPositionProperty, Value = cursorPosition });
        return self;
    }
    
    public static SettersContext<T> CursorPositionFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure)
        where T : Entry
    {
        var context = new PropertySettersContext<int>(self.XamlSetters, Entry.CursorPositionProperty);
        configure(context).Build();
        return self;
    }
    
    public static T SelectionLengthFmg<T>(this T self,
        int selectionLength)
        where T : Entry
    {
        self.SetValue(Entry.SelectionLengthProperty, selectionLength);
        return self;
    }
    
    public static T SelectionLengthFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
        where T : Entry
    {
        var context = new PropertyContext<int>(self, Entry.SelectionLengthProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> SelectionLengthFmg<T>(this SettersContext<T> self,
        int selectionLength)
        where T : Entry
    {
        self.XamlSetters.Add(new Setter { Property = Entry.SelectionLengthProperty, Value = selectionLength });
        return self;
    }
    
    public static SettersContext<T> SelectionLengthFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure)
        where T : Entry
    {
        var context = new PropertySettersContext<int>(self.XamlSetters, Entry.SelectionLengthProperty);
        configure(context).Build();
        return self;
    }
    
    public static T ReturnCommandFmg<T>(this T self,
        System.Windows.Input.ICommand returnCommand)
        where T : Entry
    {
        self.SetValue(Entry.ReturnCommandProperty, returnCommand);
        return self;
    }
    
    public static T ReturnCommandFmg<T>(this T self, Func<PropertyContext<System.Windows.Input.ICommand>, IPropertyBuilder<System.Windows.Input.ICommand>> configure)
        where T : Entry
    {
        var context = new PropertyContext<System.Windows.Input.ICommand>(self, Entry.ReturnCommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ReturnCommandFmg<T>(this SettersContext<T> self,
        System.Windows.Input.ICommand returnCommand)
        where T : Entry
    {
        self.XamlSetters.Add(new Setter { Property = Entry.ReturnCommandProperty, Value = returnCommand });
        return self;
    }
    
    public static SettersContext<T> ReturnCommandFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<System.Windows.Input.ICommand>, IPropertySettersBuilder<System.Windows.Input.ICommand>> configure)
        where T : Entry
    {
        var context = new PropertySettersContext<System.Windows.Input.ICommand>(self.XamlSetters, Entry.ReturnCommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static T ReturnCommandParameterFmg<T>(this T self,
        object returnCommandParameter)
        where T : Entry
    {
        self.SetValue(Entry.ReturnCommandParameterProperty, returnCommandParameter);
        return self;
    }
    
    public static T ReturnCommandParameterFmg<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        where T : Entry
    {
        var context = new PropertyContext<object>(self, Entry.ReturnCommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ReturnCommandParameterFmg<T>(this SettersContext<T> self,
        object returnCommandParameter)
        where T : Entry
    {
        self.XamlSetters.Add(new Setter { Property = Entry.ReturnCommandParameterProperty, Value = returnCommandParameter });
        return self;
    }
    
    public static SettersContext<T> ReturnCommandParameterFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        where T : Entry
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, Entry.ReturnCommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static T ClearButtonVisibilityFmg<T>(this T self,
        Microsoft.Maui.ClearButtonVisibility clearButtonVisibility)
        where T : Entry
    {
        self.SetValue(Entry.ClearButtonVisibilityProperty, clearButtonVisibility);
        return self;
    }
    
    public static T ClearButtonVisibilityFmg<T>(this T self, Func<PropertyContext<Microsoft.Maui.ClearButtonVisibility>, IPropertyBuilder<Microsoft.Maui.ClearButtonVisibility>> configure)
        where T : Entry
    {
        var context = new PropertyContext<Microsoft.Maui.ClearButtonVisibility>(self, Entry.ClearButtonVisibilityProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ClearButtonVisibilityFmg<T>(this SettersContext<T> self,
        Microsoft.Maui.ClearButtonVisibility clearButtonVisibility)
        where T : Entry
    {
        self.XamlSetters.Add(new Setter { Property = Entry.ClearButtonVisibilityProperty, Value = clearButtonVisibility });
        return self;
    }
    
    public static SettersContext<T> ClearButtonVisibilityFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.ClearButtonVisibility>, IPropertySettersBuilder<Microsoft.Maui.ClearButtonVisibility>> configure)
        where T : Entry
    {
        var context = new PropertySettersContext<Microsoft.Maui.ClearButtonVisibility>(self.XamlSetters, Entry.ClearButtonVisibilityProperty);
        configure(context).Build();
        return self;
    }
    
    public static T OnCompletedFmg<T>(this T self, EventHandler handler)
        where T : Entry
    {
        self.Completed += handler;
        return self;
    }
    
    public static T OnCompletedFmg<T>(this T self, Action<T> action)
        where T : Entry
    {
        self.Completed += (o, arg) => action(self);
        return self;
    }
    

    public static T TextCenterHorizontalFmg<T>(this T self)
        where T : Entry
    {
        self.SetValue(Entry.HorizontalTextAlignmentProperty, TextAlignment.Center);
        return self;
    }

    public static T TextCenterVerticalFmg<T>(this T self)
        where T : Entry
    {
        self.SetValue(Entry.VerticalTextAlignmentProperty, TextAlignment.Center);
        return self;
    }

    public static T TextCenterFmg<T>(this T self)
        where T : Entry
    {
        self.SetValue(Entry.HorizontalTextAlignmentProperty, TextAlignment.Center);
        self.SetValue(Entry.VerticalTextAlignmentProperty, TextAlignment.Center);
        return self;
    }

    public static T TextTopFmg<T>(this T self)
        where T : Entry
    {
        self.SetValue(Entry.VerticalTextAlignmentProperty, TextAlignment.Start);
        return self;
    }

    public static T TextBottomFmg<T>(this T self)
        where T : Entry, Microsoft.Maui.ITextAlignment
    {
        self.SetValue(Entry.VerticalTextAlignmentProperty, TextAlignment.End);
        return self;
    }

    public static T TextTopStartFmg<T>(this T self)
        where T : Entry
    {
        self.SetValue(Entry.VerticalTextAlignmentProperty, TextAlignment.Start);
        self.SetValue(Entry.HorizontalTextAlignmentProperty, TextAlignment.Start);
        return self;
    }

    public static T TextBottomStartFmg<T>(this T self)
        where T : Entry
    {
        self.SetValue(Entry.VerticalTextAlignmentProperty, TextAlignment.End);
        self.SetValue(Entry.HorizontalTextAlignmentProperty, TextAlignment.Start);
        return self;
    }

    public static T TextTopEndFmg<T>(this T self)
        where T : Entry
    {
        self.SetValue(Entry.VerticalTextAlignmentProperty, TextAlignment.Start);
        self.SetValue(Entry.HorizontalTextAlignmentProperty, TextAlignment.End);
        return self;
    }

    public static T TextBottomEndFmg<T>(this T self)
        where T : Entry
    {
        self.SetValue(Entry.VerticalTextAlignmentProperty, TextAlignment.End);
        self.SetValue(Entry.HorizontalTextAlignmentProperty, TextAlignment.End);
        return self;
    }

    public static T TextStartFmg<T>(this T self)
        where T : Entry
    {
        self.SetValue(Entry.HorizontalTextAlignmentProperty, TextAlignment.Start);
        return self;
    }

    public static T TextEndFmg<T>(this T self)
        where T : Entry
    {
        self.SetValue(Entry.HorizontalTextAlignmentProperty, TextAlignment.End);
        return self;
    }

    
}