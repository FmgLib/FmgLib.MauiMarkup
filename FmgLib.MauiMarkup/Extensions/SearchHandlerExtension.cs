namespace FmgLib.MauiMarkup;



public static partial class SearchHandlerExtension
{
    public static T Keyboard<T>(this T self,
        Microsoft.Maui.Keyboard keyboard)
        where T : SearchHandler
    {
        self.SetValue(SearchHandler.KeyboardProperty, keyboard);
        return self;
    }
    
    public static T Keyboard<T>(this T self, Func<PropertyContext<Microsoft.Maui.Keyboard>, IPropertyBuilder<Microsoft.Maui.Keyboard>> configure)
        where T : SearchHandler
    {
        var context = new PropertyContext<Microsoft.Maui.Keyboard>(self, SearchHandler.KeyboardProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Keyboard<T>(this SettersContext<T> self,
        Microsoft.Maui.Keyboard keyboard)
        where T : SearchHandler
    {
        self.XamlSetters.Add(new Setter { Property = SearchHandler.KeyboardProperty, Value = keyboard });
        return self;
    }
    
    public static SettersContext<T> Keyboard<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Keyboard>, IPropertySettersBuilder<Microsoft.Maui.Keyboard>> configure)
        where T : SearchHandler
    {
        var context = new PropertySettersContext<Microsoft.Maui.Keyboard>(self.XamlSetters, SearchHandler.KeyboardProperty);
        configure(context).Build();
        return self;
    }
    
    public static T HorizontalTextAlignment<T>(this T self,
        TextAlignment horizontalTextAlignment)
        where T : SearchHandler
    {
        self.SetValue(SearchHandler.HorizontalTextAlignmentProperty, horizontalTextAlignment);
        return self;
    }
    
    public static T HorizontalTextAlignment<T>(this T self, Func<PropertyContext<TextAlignment>, IPropertyBuilder<TextAlignment>> configure)
        where T : SearchHandler
    {
        var context = new PropertyContext<TextAlignment>(self, SearchHandler.HorizontalTextAlignmentProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> HorizontalTextAlignment<T>(this SettersContext<T> self,
        TextAlignment horizontalTextAlignment)
        where T : SearchHandler
    {
        self.XamlSetters.Add(new Setter { Property = SearchHandler.HorizontalTextAlignmentProperty, Value = horizontalTextAlignment });
        return self;
    }
    
    public static SettersContext<T> HorizontalTextAlignment<T>(this SettersContext<T> self, Func<PropertySettersContext<TextAlignment>, IPropertySettersBuilder<TextAlignment>> configure)
        where T : SearchHandler
    {
        var context = new PropertySettersContext<TextAlignment>(self.XamlSetters, SearchHandler.HorizontalTextAlignmentProperty);
        configure(context).Build();
        return self;
    }
    
    public static T VerticalTextAlignment<T>(this T self,
        TextAlignment verticalTextAlignment)
        where T : SearchHandler
    {
        self.SetValue(SearchHandler.VerticalTextAlignmentProperty, verticalTextAlignment);
        return self;
    }
    
    public static T VerticalTextAlignment<T>(this T self, Func<PropertyContext<TextAlignment>, IPropertyBuilder<TextAlignment>> configure)
        where T : SearchHandler
    {
        var context = new PropertyContext<TextAlignment>(self, SearchHandler.VerticalTextAlignmentProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> VerticalTextAlignment<T>(this SettersContext<T> self,
        TextAlignment verticalTextAlignment)
        where T : SearchHandler
    {
        self.XamlSetters.Add(new Setter { Property = SearchHandler.VerticalTextAlignmentProperty, Value = verticalTextAlignment });
        return self;
    }
    
    public static SettersContext<T> VerticalTextAlignment<T>(this SettersContext<T> self, Func<PropertySettersContext<TextAlignment>, IPropertySettersBuilder<TextAlignment>> configure)
        where T : SearchHandler
    {
        var context = new PropertySettersContext<TextAlignment>(self.XamlSetters, SearchHandler.VerticalTextAlignmentProperty);
        configure(context).Build();
        return self;
    }
    
    public static T TextColor<T>(this T self,
        Color textColor)
        where T : SearchHandler
    {
        self.SetValue(SearchHandler.TextColorProperty, textColor);
        return self;
    }
    
    public static T TextColor<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : SearchHandler
    {
        var context = new PropertyContext<Color>(self, SearchHandler.TextColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> TextColor<T>(this SettersContext<T> self,
        Color textColor)
        where T : SearchHandler
    {
        self.XamlSetters.Add(new Setter { Property = SearchHandler.TextColorProperty, Value = textColor });
        return self;
    }
    
    public static SettersContext<T> TextColor<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : SearchHandler
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, SearchHandler.TextColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static T TextTransform<T>(this T self,
        TextTransform textTransform)
        where T : SearchHandler
    {
        self.SetValue(SearchHandler.TextTransformProperty, textTransform);
        return self;
    }
    
    public static T TextTransform<T>(this T self, Func<PropertyContext<TextTransform>, IPropertyBuilder<TextTransform>> configure)
        where T : SearchHandler
    {
        var context = new PropertyContext<TextTransform>(self, SearchHandler.TextTransformProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> TextTransform<T>(this SettersContext<T> self,
        TextTransform textTransform)
        where T : SearchHandler
    {
        self.XamlSetters.Add(new Setter { Property = SearchHandler.TextTransformProperty, Value = textTransform });
        return self;
    }
    
    public static SettersContext<T> TextTransform<T>(this SettersContext<T> self, Func<PropertySettersContext<TextTransform>, IPropertySettersBuilder<TextTransform>> configure)
        where T : SearchHandler
    {
        var context = new PropertySettersContext<TextTransform>(self.XamlSetters, SearchHandler.TextTransformProperty);
        configure(context).Build();
        return self;
    }
    
    public static T CancelButtonColor<T>(this T self,
        Color cancelButtonColor)
        where T : SearchHandler
    {
        self.SetValue(SearchHandler.CancelButtonColorProperty, cancelButtonColor);
        return self;
    }
    
    public static T CancelButtonColor<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : SearchHandler
    {
        var context = new PropertyContext<Color>(self, SearchHandler.CancelButtonColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> CancelButtonColor<T>(this SettersContext<T> self,
        Color cancelButtonColor)
        where T : SearchHandler
    {
        self.XamlSetters.Add(new Setter { Property = SearchHandler.CancelButtonColorProperty, Value = cancelButtonColor });
        return self;
    }
    
    public static SettersContext<T> CancelButtonColor<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : SearchHandler
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, SearchHandler.CancelButtonColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FontAttributes<T>(this T self,
        FontAttributes fontAttributes)
        where T : SearchHandler
    {
        self.SetValue(SearchHandler.FontAttributesProperty, fontAttributes);
        return self;
    }
    
    public static T FontAttributes<T>(this T self, Func<PropertyContext<FontAttributes>, IPropertyBuilder<FontAttributes>> configure)
        where T : SearchHandler
    {
        var context = new PropertyContext<FontAttributes>(self, SearchHandler.FontAttributesProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FontAttributes<T>(this SettersContext<T> self,
        FontAttributes fontAttributes)
        where T : SearchHandler
    {
        self.XamlSetters.Add(new Setter { Property = SearchHandler.FontAttributesProperty, Value = fontAttributes });
        return self;
    }
    
    public static SettersContext<T> FontAttributes<T>(this SettersContext<T> self, Func<PropertySettersContext<FontAttributes>, IPropertySettersBuilder<FontAttributes>> configure)
        where T : SearchHandler
    {
        var context = new PropertySettersContext<FontAttributes>(self.XamlSetters, SearchHandler.FontAttributesProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FontFamily<T>(this T self,
        string fontFamily)
        where T : SearchHandler
    {
        self.SetValue(SearchHandler.FontFamilyProperty, fontFamily);
        return self;
    }
    
    public static T FontFamily<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : SearchHandler
    {
        var context = new PropertyContext<string>(self, SearchHandler.FontFamilyProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FontFamily<T>(this SettersContext<T> self,
        string fontFamily)
        where T : SearchHandler
    {
        self.XamlSetters.Add(new Setter { Property = SearchHandler.FontFamilyProperty, Value = fontFamily });
        return self;
    }
    
    public static SettersContext<T> FontFamily<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : SearchHandler
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, SearchHandler.FontFamilyProperty);
        configure(context).Build();
        return self;
    }
    
    public static T CharacterSpacing<T>(this T self,
        double characterSpacing)
        where T : SearchHandler
    {
        self.SetValue(SearchHandler.CharacterSpacingProperty, characterSpacing);
        return self;
    }
    
    public static T CharacterSpacing<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : SearchHandler
    {
        var context = new PropertyContext<double>(self, SearchHandler.CharacterSpacingProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> CharacterSpacing<T>(this SettersContext<T> self,
        double characterSpacing)
        where T : SearchHandler
    {
        self.XamlSetters.Add(new Setter { Property = SearchHandler.CharacterSpacingProperty, Value = characterSpacing });
        return self;
    }
    
    public static SettersContext<T> CharacterSpacing<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : SearchHandler
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, SearchHandler.CharacterSpacingProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FontSize<T>(this T self,
        double fontSize)
        where T : SearchHandler
    {
        self.SetValue(SearchHandler.FontSizeProperty, fontSize);
        return self;
    }
    
    public static T FontSize<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : SearchHandler
    {
        var context = new PropertyContext<double>(self, SearchHandler.FontSizeProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FontSize<T>(this SettersContext<T> self,
        double fontSize)
        where T : SearchHandler
    {
        self.XamlSetters.Add(new Setter { Property = SearchHandler.FontSizeProperty, Value = fontSize });
        return self;
    }
    
    public static SettersContext<T> FontSize<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : SearchHandler
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, SearchHandler.FontSizeProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FontAutoScalingEnabled<T>(this T self,
        bool fontAutoScalingEnabled)
        where T : SearchHandler
    {
        self.SetValue(SearchHandler.FontAutoScalingEnabledProperty, fontAutoScalingEnabled);
        return self;
    }
    
    public static T FontAutoScalingEnabled<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : SearchHandler
    {
        var context = new PropertyContext<bool>(self, SearchHandler.FontAutoScalingEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FontAutoScalingEnabled<T>(this SettersContext<T> self,
        bool fontAutoScalingEnabled)
        where T : SearchHandler
    {
        self.XamlSetters.Add(new Setter { Property = SearchHandler.FontAutoScalingEnabledProperty, Value = fontAutoScalingEnabled });
        return self;
    }
    
    public static SettersContext<T> FontAutoScalingEnabled<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : SearchHandler
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, SearchHandler.FontAutoScalingEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static T PlaceholderColor<T>(this T self,
        Color placeholderColor)
        where T : SearchHandler
    {
        self.SetValue(SearchHandler.PlaceholderColorProperty, placeholderColor);
        return self;
    }
    
    public static T PlaceholderColor<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : SearchHandler
    {
        var context = new PropertyContext<Color>(self, SearchHandler.PlaceholderColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> PlaceholderColor<T>(this SettersContext<T> self,
        Color placeholderColor)
        where T : SearchHandler
    {
        self.XamlSetters.Add(new Setter { Property = SearchHandler.PlaceholderColorProperty, Value = placeholderColor });
        return self;
    }
    
    public static SettersContext<T> PlaceholderColor<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : SearchHandler
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, SearchHandler.PlaceholderColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static T Placeholder<T>(this T self,
        string placeholder)
        where T : SearchHandler
    {
        self.SetValue(SearchHandler.PlaceholderProperty, placeholder);
        return self;
    }
    
    public static T Placeholder<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : SearchHandler
    {
        var context = new PropertyContext<string>(self, SearchHandler.PlaceholderProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Placeholder<T>(this SettersContext<T> self,
        string placeholder)
        where T : SearchHandler
    {
        self.XamlSetters.Add(new Setter { Property = SearchHandler.PlaceholderProperty, Value = placeholder });
        return self;
    }
    
    public static SettersContext<T> Placeholder<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : SearchHandler
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, SearchHandler.PlaceholderProperty);
        configure(context).Build();
        return self;
    }
    
    public static T BackgroundColor<T>(this T self,
        Color backgroundColor)
        where T : SearchHandler
    {
        self.SetValue(SearchHandler.BackgroundColorProperty, backgroundColor);
        return self;
    }
    
    public static T BackgroundColor<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : SearchHandler
    {
        var context = new PropertyContext<Color>(self, SearchHandler.BackgroundColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> BackgroundColor<T>(this SettersContext<T> self,
        Color backgroundColor)
        where T : SearchHandler
    {
        self.XamlSetters.Add(new Setter { Property = SearchHandler.BackgroundColorProperty, Value = backgroundColor });
        return self;
    }
    
    public static SettersContext<T> BackgroundColor<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : SearchHandler
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, SearchHandler.BackgroundColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static T AutomationId<T>(this T self,
        string automationId)
        where T : SearchHandler
    {
        self.SetValue(SearchHandler.AutomationIdProperty, automationId);
        return self;
    }
    
    public static T AutomationId<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : SearchHandler
    {
        var context = new PropertyContext<string>(self, SearchHandler.AutomationIdProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> AutomationId<T>(this SettersContext<T> self,
        string automationId)
        where T : SearchHandler
    {
        self.XamlSetters.Add(new Setter { Property = SearchHandler.AutomationIdProperty, Value = automationId });
        return self;
    }
    
    public static SettersContext<T> AutomationId<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : SearchHandler
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, SearchHandler.AutomationIdProperty);
        configure(context).Build();
        return self;
    }
    
    public static T ClearIcon<T>(this T self,
        ImageSource clearIcon)
        where T : SearchHandler
    {
        self.SetValue(SearchHandler.ClearIconProperty, clearIcon);
        return self;
    }
    
    public static T ClearIcon<T>(this T self, Func<PropertyContext<ImageSource>, IPropertyBuilder<ImageSource>> configure)
        where T : SearchHandler
    {
        var context = new PropertyContext<ImageSource>(self, SearchHandler.ClearIconProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ClearIcon<T>(this SettersContext<T> self,
        ImageSource clearIcon)
        where T : SearchHandler
    {
        self.XamlSetters.Add(new Setter { Property = SearchHandler.ClearIconProperty, Value = clearIcon });
        return self;
    }
    
    public static SettersContext<T> ClearIcon<T>(this SettersContext<T> self, Func<PropertySettersContext<ImageSource>, IPropertySettersBuilder<ImageSource>> configure)
        where T : SearchHandler
    {
        var context = new PropertySettersContext<ImageSource>(self.XamlSetters, SearchHandler.ClearIconProperty);
        configure(context).Build();
        return self;
    }
    
    public static T ClearIconHelpText<T>(this T self,
        string clearIconHelpText)
        where T : SearchHandler
    {
        self.SetValue(SearchHandler.ClearIconHelpTextProperty, clearIconHelpText);
        return self;
    }
    
    public static T ClearIconHelpText<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : SearchHandler
    {
        var context = new PropertyContext<string>(self, SearchHandler.ClearIconHelpTextProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ClearIconHelpText<T>(this SettersContext<T> self,
        string clearIconHelpText)
        where T : SearchHandler
    {
        self.XamlSetters.Add(new Setter { Property = SearchHandler.ClearIconHelpTextProperty, Value = clearIconHelpText });
        return self;
    }
    
    public static SettersContext<T> ClearIconHelpText<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : SearchHandler
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, SearchHandler.ClearIconHelpTextProperty);
        configure(context).Build();
        return self;
    }
    
    public static T ClearIconName<T>(this T self,
        string clearIconName)
        where T : SearchHandler
    {
        self.SetValue(SearchHandler.ClearIconNameProperty, clearIconName);
        return self;
    }
    
    public static T ClearIconName<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : SearchHandler
    {
        var context = new PropertyContext<string>(self, SearchHandler.ClearIconNameProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ClearIconName<T>(this SettersContext<T> self,
        string clearIconName)
        where T : SearchHandler
    {
        self.XamlSetters.Add(new Setter { Property = SearchHandler.ClearIconNameProperty, Value = clearIconName });
        return self;
    }
    
    public static SettersContext<T> ClearIconName<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : SearchHandler
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, SearchHandler.ClearIconNameProperty);
        configure(context).Build();
        return self;
    }
    
    public static T ClearPlaceholderCommand<T>(this T self,
        System.Windows.Input.ICommand clearPlaceholderCommand)
        where T : SearchHandler
    {
        self.SetValue(SearchHandler.ClearPlaceholderCommandProperty, clearPlaceholderCommand);
        return self;
    }
    
    public static T ClearPlaceholderCommand<T>(this T self, Func<PropertyContext<System.Windows.Input.ICommand>, IPropertyBuilder<System.Windows.Input.ICommand>> configure)
        where T : SearchHandler
    {
        var context = new PropertyContext<System.Windows.Input.ICommand>(self, SearchHandler.ClearPlaceholderCommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ClearPlaceholderCommand<T>(this SettersContext<T> self,
        System.Windows.Input.ICommand clearPlaceholderCommand)
        where T : SearchHandler
    {
        self.XamlSetters.Add(new Setter { Property = SearchHandler.ClearPlaceholderCommandProperty, Value = clearPlaceholderCommand });
        return self;
    }
    
    public static SettersContext<T> ClearPlaceholderCommand<T>(this SettersContext<T> self, Func<PropertySettersContext<System.Windows.Input.ICommand>, IPropertySettersBuilder<System.Windows.Input.ICommand>> configure)
        where T : SearchHandler
    {
        var context = new PropertySettersContext<System.Windows.Input.ICommand>(self.XamlSetters, SearchHandler.ClearPlaceholderCommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static T ClearPlaceholderCommandParameter<T>(this T self,
        object clearPlaceholderCommandParameter)
        where T : SearchHandler
    {
        self.SetValue(SearchHandler.ClearPlaceholderCommandParameterProperty, clearPlaceholderCommandParameter);
        return self;
    }
    
    public static T ClearPlaceholderCommandParameter<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        where T : SearchHandler
    {
        var context = new PropertyContext<object>(self, SearchHandler.ClearPlaceholderCommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ClearPlaceholderCommandParameter<T>(this SettersContext<T> self,
        object clearPlaceholderCommandParameter)
        where T : SearchHandler
    {
        self.XamlSetters.Add(new Setter { Property = SearchHandler.ClearPlaceholderCommandParameterProperty, Value = clearPlaceholderCommandParameter });
        return self;
    }
    
    public static SettersContext<T> ClearPlaceholderCommandParameter<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        where T : SearchHandler
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, SearchHandler.ClearPlaceholderCommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static T ClearPlaceholderEnabled<T>(this T self,
        bool clearPlaceholderEnabled)
        where T : SearchHandler
    {
        self.SetValue(SearchHandler.ClearPlaceholderEnabledProperty, clearPlaceholderEnabled);
        return self;
    }
    
    public static T ClearPlaceholderEnabled<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : SearchHandler
    {
        var context = new PropertyContext<bool>(self, SearchHandler.ClearPlaceholderEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ClearPlaceholderEnabled<T>(this SettersContext<T> self,
        bool clearPlaceholderEnabled)
        where T : SearchHandler
    {
        self.XamlSetters.Add(new Setter { Property = SearchHandler.ClearPlaceholderEnabledProperty, Value = clearPlaceholderEnabled });
        return self;
    }
    
    public static SettersContext<T> ClearPlaceholderEnabled<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : SearchHandler
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, SearchHandler.ClearPlaceholderEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static T ClearPlaceholderHelpText<T>(this T self,
        string clearPlaceholderHelpText)
        where T : SearchHandler
    {
        self.SetValue(SearchHandler.ClearPlaceholderHelpTextProperty, clearPlaceholderHelpText);
        return self;
    }
    
    public static T ClearPlaceholderHelpText<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : SearchHandler
    {
        var context = new PropertyContext<string>(self, SearchHandler.ClearPlaceholderHelpTextProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ClearPlaceholderHelpText<T>(this SettersContext<T> self,
        string clearPlaceholderHelpText)
        where T : SearchHandler
    {
        self.XamlSetters.Add(new Setter { Property = SearchHandler.ClearPlaceholderHelpTextProperty, Value = clearPlaceholderHelpText });
        return self;
    }
    
    public static SettersContext<T> ClearPlaceholderHelpText<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : SearchHandler
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, SearchHandler.ClearPlaceholderHelpTextProperty);
        configure(context).Build();
        return self;
    }
    
    public static T ClearPlaceholderIcon<T>(this T self,
        ImageSource clearPlaceholderIcon)
        where T : SearchHandler
    {
        self.SetValue(SearchHandler.ClearPlaceholderIconProperty, clearPlaceholderIcon);
        return self;
    }
    
    public static T ClearPlaceholderIcon<T>(this T self, Func<PropertyContext<ImageSource>, IPropertyBuilder<ImageSource>> configure)
        where T : SearchHandler
    {
        var context = new PropertyContext<ImageSource>(self, SearchHandler.ClearPlaceholderIconProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ClearPlaceholderIcon<T>(this SettersContext<T> self,
        ImageSource clearPlaceholderIcon)
        where T : SearchHandler
    {
        self.XamlSetters.Add(new Setter { Property = SearchHandler.ClearPlaceholderIconProperty, Value = clearPlaceholderIcon });
        return self;
    }
    
    public static SettersContext<T> ClearPlaceholderIcon<T>(this SettersContext<T> self, Func<PropertySettersContext<ImageSource>, IPropertySettersBuilder<ImageSource>> configure)
        where T : SearchHandler
    {
        var context = new PropertySettersContext<ImageSource>(self.XamlSetters, SearchHandler.ClearPlaceholderIconProperty);
        configure(context).Build();
        return self;
    }
    
    public static T ClearPlaceholderName<T>(this T self,
        string clearPlaceholderName)
        where T : SearchHandler
    {
        self.SetValue(SearchHandler.ClearPlaceholderNameProperty, clearPlaceholderName);
        return self;
    }
    
    public static T ClearPlaceholderName<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : SearchHandler
    {
        var context = new PropertyContext<string>(self, SearchHandler.ClearPlaceholderNameProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ClearPlaceholderName<T>(this SettersContext<T> self,
        string clearPlaceholderName)
        where T : SearchHandler
    {
        self.XamlSetters.Add(new Setter { Property = SearchHandler.ClearPlaceholderNameProperty, Value = clearPlaceholderName });
        return self;
    }
    
    public static SettersContext<T> ClearPlaceholderName<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : SearchHandler
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, SearchHandler.ClearPlaceholderNameProperty);
        configure(context).Build();
        return self;
    }
    
    public static T Command<T>(this T self,
        System.Windows.Input.ICommand command)
        where T : SearchHandler
    {
        self.SetValue(SearchHandler.CommandProperty, command);
        return self;
    }
    
    public static T Command<T>(this T self, Func<PropertyContext<System.Windows.Input.ICommand>, IPropertyBuilder<System.Windows.Input.ICommand>> configure)
        where T : SearchHandler
    {
        var context = new PropertyContext<System.Windows.Input.ICommand>(self, SearchHandler.CommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Command<T>(this SettersContext<T> self,
        System.Windows.Input.ICommand command)
        where T : SearchHandler
    {
        self.XamlSetters.Add(new Setter { Property = SearchHandler.CommandProperty, Value = command });
        return self;
    }
    
    public static SettersContext<T> Command<T>(this SettersContext<T> self, Func<PropertySettersContext<System.Windows.Input.ICommand>, IPropertySettersBuilder<System.Windows.Input.ICommand>> configure)
        where T : SearchHandler
    {
        var context = new PropertySettersContext<System.Windows.Input.ICommand>(self.XamlSetters, SearchHandler.CommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static T CommandParameter<T>(this T self,
        object commandParameter)
        where T : SearchHandler
    {
        self.SetValue(SearchHandler.CommandParameterProperty, commandParameter);
        return self;
    }
    
    public static T CommandParameter<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        where T : SearchHandler
    {
        var context = new PropertyContext<object>(self, SearchHandler.CommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> CommandParameter<T>(this SettersContext<T> self,
        object commandParameter)
        where T : SearchHandler
    {
        self.XamlSetters.Add(new Setter { Property = SearchHandler.CommandParameterProperty, Value = commandParameter });
        return self;
    }
    
    public static SettersContext<T> CommandParameter<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        where T : SearchHandler
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, SearchHandler.CommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static T DisplayMemberName<T>(this T self,
        string displayMemberName)
        where T : SearchHandler
    {
        self.SetValue(SearchHandler.DisplayMemberNameProperty, displayMemberName);
        return self;
    }
    
    public static T DisplayMemberName<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : SearchHandler
    {
        var context = new PropertyContext<string>(self, SearchHandler.DisplayMemberNameProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> DisplayMemberName<T>(this SettersContext<T> self,
        string displayMemberName)
        where T : SearchHandler
    {
        self.XamlSetters.Add(new Setter { Property = SearchHandler.DisplayMemberNameProperty, Value = displayMemberName });
        return self;
    }
    
    public static SettersContext<T> DisplayMemberName<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : SearchHandler
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, SearchHandler.DisplayMemberNameProperty);
        configure(context).Build();
        return self;
    }
    
    public static T IsSearchEnabled<T>(this T self,
        bool isSearchEnabled)
        where T : SearchHandler
    {
        self.SetValue(SearchHandler.IsSearchEnabledProperty, isSearchEnabled);
        return self;
    }
    
    public static T IsSearchEnabled<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : SearchHandler
    {
        var context = new PropertyContext<bool>(self, SearchHandler.IsSearchEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> IsSearchEnabled<T>(this SettersContext<T> self,
        bool isSearchEnabled)
        where T : SearchHandler
    {
        self.XamlSetters.Add(new Setter { Property = SearchHandler.IsSearchEnabledProperty, Value = isSearchEnabled });
        return self;
    }
    
    public static SettersContext<T> IsSearchEnabled<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : SearchHandler
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, SearchHandler.IsSearchEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static T ItemsSource<T>(this T self,
        System.Collections.IEnumerable itemsSource)
        where T : SearchHandler
    {
        self.SetValue(SearchHandler.ItemsSourceProperty, itemsSource);
        return self;
    }
    
    public static T ItemsSource<T>(this T self, Func<PropertyContext<System.Collections.IEnumerable>, IPropertyBuilder<System.Collections.IEnumerable>> configure)
        where T : SearchHandler
    {
        var context = new PropertyContext<System.Collections.IEnumerable>(self, SearchHandler.ItemsSourceProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ItemsSource<T>(this SettersContext<T> self,
        System.Collections.IEnumerable itemsSource)
        where T : SearchHandler
    {
        self.XamlSetters.Add(new Setter { Property = SearchHandler.ItemsSourceProperty, Value = itemsSource });
        return self;
    }
    
    public static SettersContext<T> ItemsSource<T>(this SettersContext<T> self, Func<PropertySettersContext<System.Collections.IEnumerable>, IPropertySettersBuilder<System.Collections.IEnumerable>> configure)
        where T : SearchHandler
    {
        var context = new PropertySettersContext<System.Collections.IEnumerable>(self.XamlSetters, SearchHandler.ItemsSourceProperty);
        configure(context).Build();
        return self;
    }
    
    public static T ItemTemplate<T>(this T self,
        DataTemplate itemTemplate)
        where T : SearchHandler
    {
        self.SetValue(SearchHandler.ItemTemplateProperty, itemTemplate);
        return self;
    }
    
    public static T ItemTemplate<T>(this T self, Func<PropertyContext<DataTemplate>, IPropertyBuilder<DataTemplate>> configure)
        where T : SearchHandler
    {
        var context = new PropertyContext<DataTemplate>(self, SearchHandler.ItemTemplateProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ItemTemplate<T>(this SettersContext<T> self,
        DataTemplate itemTemplate)
        where T : SearchHandler
    {
        self.XamlSetters.Add(new Setter { Property = SearchHandler.ItemTemplateProperty, Value = itemTemplate });
        return self;
    }
    
    public static SettersContext<T> ItemTemplate<T>(this SettersContext<T> self, Func<PropertySettersContext<DataTemplate>, IPropertySettersBuilder<DataTemplate>> configure)
        where T : SearchHandler
    {
        var context = new PropertySettersContext<DataTemplate>(self.XamlSetters, SearchHandler.ItemTemplateProperty);
        configure(context).Build();
        return self;
    }
    
    public static T ItemTemplate<T>(this T self, Func<object> loadTemplate)
        where T : SearchHandler
    {
        self.SetValue(SearchHandler.ItemTemplateProperty, new DataTemplate(loadTemplate));
        return self;
    }
    
    public static T Query<T>(this T self,
        string query)
        where T : SearchHandler
    {
        self.SetValue(SearchHandler.QueryProperty, query);
        return self;
    }
    
    public static T Query<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : SearchHandler
    {
        var context = new PropertyContext<string>(self, SearchHandler.QueryProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Query<T>(this SettersContext<T> self,
        string query)
        where T : SearchHandler
    {
        self.XamlSetters.Add(new Setter { Property = SearchHandler.QueryProperty, Value = query });
        return self;
    }
    
    public static SettersContext<T> Query<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : SearchHandler
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, SearchHandler.QueryProperty);
        configure(context).Build();
        return self;
    }
    
    public static T QueryIcon<T>(this T self,
        ImageSource queryIcon)
        where T : SearchHandler
    {
        self.SetValue(SearchHandler.QueryIconProperty, queryIcon);
        return self;
    }
    
    public static T QueryIcon<T>(this T self, Func<PropertyContext<ImageSource>, IPropertyBuilder<ImageSource>> configure)
        where T : SearchHandler
    {
        var context = new PropertyContext<ImageSource>(self, SearchHandler.QueryIconProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> QueryIcon<T>(this SettersContext<T> self,
        ImageSource queryIcon)
        where T : SearchHandler
    {
        self.XamlSetters.Add(new Setter { Property = SearchHandler.QueryIconProperty, Value = queryIcon });
        return self;
    }
    
    public static SettersContext<T> QueryIcon<T>(this SettersContext<T> self, Func<PropertySettersContext<ImageSource>, IPropertySettersBuilder<ImageSource>> configure)
        where T : SearchHandler
    {
        var context = new PropertySettersContext<ImageSource>(self.XamlSetters, SearchHandler.QueryIconProperty);
        configure(context).Build();
        return self;
    }
    
    public static T QueryIconHelpText<T>(this T self,
        string queryIconHelpText)
        where T : SearchHandler
    {
        self.SetValue(SearchHandler.QueryIconHelpTextProperty, queryIconHelpText);
        return self;
    }
    
    public static T QueryIconHelpText<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : SearchHandler
    {
        var context = new PropertyContext<string>(self, SearchHandler.QueryIconHelpTextProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> QueryIconHelpText<T>(this SettersContext<T> self,
        string queryIconHelpText)
        where T : SearchHandler
    {
        self.XamlSetters.Add(new Setter { Property = SearchHandler.QueryIconHelpTextProperty, Value = queryIconHelpText });
        return self;
    }
    
    public static SettersContext<T> QueryIconHelpText<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : SearchHandler
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, SearchHandler.QueryIconHelpTextProperty);
        configure(context).Build();
        return self;
    }
    
    public static T QueryIconName<T>(this T self,
        string queryIconName)
        where T : SearchHandler
    {
        self.SetValue(SearchHandler.QueryIconNameProperty, queryIconName);
        return self;
    }
    
    public static T QueryIconName<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : SearchHandler
    {
        var context = new PropertyContext<string>(self, SearchHandler.QueryIconNameProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> QueryIconName<T>(this SettersContext<T> self,
        string queryIconName)
        where T : SearchHandler
    {
        self.XamlSetters.Add(new Setter { Property = SearchHandler.QueryIconNameProperty, Value = queryIconName });
        return self;
    }
    
    public static SettersContext<T> QueryIconName<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : SearchHandler
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, SearchHandler.QueryIconNameProperty);
        configure(context).Build();
        return self;
    }
    
    public static T SearchBoxVisibility<T>(this T self,
        SearchBoxVisibility searchBoxVisibility)
        where T : SearchHandler
    {
        self.SetValue(SearchHandler.SearchBoxVisibilityProperty, searchBoxVisibility);
        return self;
    }
    
    public static T SearchBoxVisibility<T>(this T self, Func<PropertyContext<SearchBoxVisibility>, IPropertyBuilder<SearchBoxVisibility>> configure)
        where T : SearchHandler
    {
        var context = new PropertyContext<SearchBoxVisibility>(self, SearchHandler.SearchBoxVisibilityProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> SearchBoxVisibility<T>(this SettersContext<T> self,
        SearchBoxVisibility searchBoxVisibility)
        where T : SearchHandler
    {
        self.XamlSetters.Add(new Setter { Property = SearchHandler.SearchBoxVisibilityProperty, Value = searchBoxVisibility });
        return self;
    }
    
    public static SettersContext<T> SearchBoxVisibility<T>(this SettersContext<T> self, Func<PropertySettersContext<SearchBoxVisibility>, IPropertySettersBuilder<SearchBoxVisibility>> configure)
        where T : SearchHandler
    {
        var context = new PropertySettersContext<SearchBoxVisibility>(self.XamlSetters, SearchHandler.SearchBoxVisibilityProperty);
        configure(context).Build();
        return self;
    }
    
    public static T ShowsResults<T>(this T self,
        bool showsResults)
        where T : SearchHandler
    {
        self.SetValue(SearchHandler.ShowsResultsProperty, showsResults);
        return self;
    }
    
    public static T ShowsResults<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : SearchHandler
    {
        var context = new PropertyContext<bool>(self, SearchHandler.ShowsResultsProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ShowsResults<T>(this SettersContext<T> self,
        bool showsResults)
        where T : SearchHandler
    {
        self.XamlSetters.Add(new Setter { Property = SearchHandler.ShowsResultsProperty, Value = showsResults });
        return self;
    }
    
    public static SettersContext<T> ShowsResults<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : SearchHandler
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, SearchHandler.ShowsResultsProperty);
        configure(context).Build();
        return self;
    }
    
    public static T OnFocused<T>(this T self, EventHandler<EventArgs> handler)
        where T : SearchHandler
    {
        self.Focused += handler;
        return self;
    }
    
    public static T OnFocused<T>(this T self, Action<T> action)
        where T : SearchHandler
    {
        self.Focused += (o, arg) => action(self);
        return self;
    }
    
    public static T OnUnfocused<T>(this T self, EventHandler<EventArgs> handler)
        where T : SearchHandler
    {
        self.Unfocused += handler;
        return self;
    }
    
    public static T OnUnfocused<T>(this T self, Action<T> action)
        where T : SearchHandler
    {
        self.Unfocused += (o, arg) => action(self);
        return self;
    }
    
    public static T OnFocusChangeRequested<T>(this T self, EventHandler<VisualElement.FocusRequestArgs> handler)
        where T : SearchHandler
    {
        self.FocusChangeRequested += handler;
        return self;
    }
    
    public static T OnFocusChangeRequested<T>(this T self, Action<T> action)
        where T : SearchHandler
    {
        self.FocusChangeRequested += (o, arg) => action(self);
        return self;
    }
    
}
