namespace FmgLib.MauiMarkup;

public static partial class EditorExtension
{
    public static T AutoSizeFmg<T>(this T self,
        EditorAutoSizeOption autoSize)
        where T : Editor
    {
        self.SetValue(Editor.AutoSizeProperty, autoSize);
        return self;
    }
    
    public static T AutoSizeFmg<T>(this T self, Func<PropertyContext<EditorAutoSizeOption>, IPropertyBuilder<EditorAutoSizeOption>> configure)
        where T : Editor
    {
        var context = new PropertyContext<EditorAutoSizeOption>(self, Editor.AutoSizeProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> AutoSizeFmg<T>(this SettersContext<T> self,
        EditorAutoSizeOption autoSize)
        where T : Editor
    {
        self.XamlSetters.Add(new Setter { Property = Editor.AutoSizeProperty, Value = autoSize });
        return self;
    }
    
    public static SettersContext<T> AutoSizeFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<EditorAutoSizeOption>, IPropertySettersBuilder<EditorAutoSizeOption>> configure)
        where T : Editor
    {
        var context = new PropertySettersContext<EditorAutoSizeOption>(self.XamlSetters, Editor.AutoSizeProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FontAttributesFmg<T>(this T self,
        FontAttributes fontAttributes)
        where T : Editor
    {
        self.SetValue(Editor.FontAttributesProperty, fontAttributes);
        return self;
    }
    
    public static T FontAttributesFmg<T>(this T self, Func<PropertyContext<FontAttributes>, IPropertyBuilder<FontAttributes>> configure)
        where T : Editor
    {
        var context = new PropertyContext<FontAttributes>(self, Editor.FontAttributesProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FontAttributesFmg<T>(this SettersContext<T> self,
        FontAttributes fontAttributes)
        where T : Editor
    {
        self.XamlSetters.Add(new Setter { Property = Editor.FontAttributesProperty, Value = fontAttributes });
        return self;
    }
    
    public static SettersContext<T> FontAttributesFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<FontAttributes>, IPropertySettersBuilder<FontAttributes>> configure)
        where T : Editor
    {
        var context = new PropertySettersContext<FontAttributes>(self.XamlSetters, Editor.FontAttributesProperty);
        configure(context).Build();
        return self;
    }
    
    public static T IsTextPredictionEnabledFmg<T>(this T self,
        bool isTextPredictionEnabled)
        where T : Editor
    {
        self.SetValue(Editor.IsTextPredictionEnabledProperty, isTextPredictionEnabled);
        return self;
    }
    
    public static T IsTextPredictionEnabledFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : Editor
    {
        var context = new PropertyContext<bool>(self, Editor.IsTextPredictionEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> IsTextPredictionEnabledFmg<T>(this SettersContext<T> self,
        bool isTextPredictionEnabled)
        where T : Editor
    {
        self.XamlSetters.Add(new Setter { Property = Editor.IsTextPredictionEnabledProperty, Value = isTextPredictionEnabled });
        return self;
    }
    
    public static SettersContext<T> IsTextPredictionEnabledFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : Editor
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, Editor.IsTextPredictionEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static T CursorPositionFmg<T>(this T self,
        int cursorPosition)
        where T : Editor
    {
        self.SetValue(Editor.CursorPositionProperty, cursorPosition);
        return self;
    }
    
    public static T CursorPositionFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
        where T : Editor
    {
        var context = new PropertyContext<int>(self, Editor.CursorPositionProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> CursorPositionFmg<T>(this SettersContext<T> self,
        int cursorPosition)
        where T : Editor
    {
        self.XamlSetters.Add(new Setter { Property = Editor.CursorPositionProperty, Value = cursorPosition });
        return self;
    }
    
    public static SettersContext<T> CursorPositionFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure)
        where T : Editor
    {
        var context = new PropertySettersContext<int>(self.XamlSetters, Editor.CursorPositionProperty);
        configure(context).Build();
        return self;
    }
    
    public static T SelectionLengthFmg<T>(this T self,
        int selectionLength)
        where T : Editor
    {
        self.SetValue(Editor.SelectionLengthProperty, selectionLength);
        return self;
    }
    
    public static T SelectionLengthFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
        where T : Editor
    {
        var context = new PropertyContext<int>(self, Editor.SelectionLengthProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> SelectionLengthFmg<T>(this SettersContext<T> self,
        int selectionLength)
        where T : Editor
    {
        self.XamlSetters.Add(new Setter { Property = Editor.SelectionLengthProperty, Value = selectionLength });
        return self;
    }
    
    public static SettersContext<T> SelectionLengthFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure)
        where T : Editor
    {
        var context = new PropertySettersContext<int>(self.XamlSetters, Editor.SelectionLengthProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FontFamilyFmg<T>(this T self,
        string fontFamily)
        where T : Editor
    {
        self.SetValue(Editor.FontFamilyProperty, fontFamily);
        return self;
    }
    
    public static T FontFamilyFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : Editor
    {
        var context = new PropertyContext<string>(self, Editor.FontFamilyProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FontFamilyFmg<T>(this SettersContext<T> self,
        string fontFamily)
        where T : Editor
    {
        self.XamlSetters.Add(new Setter { Property = Editor.FontFamilyProperty, Value = fontFamily });
        return self;
    }
    
    public static SettersContext<T> FontFamilyFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : Editor
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, Editor.FontFamilyProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FontSizeFmg<T>(this T self,
        double fontSize)
        where T : Editor
    {
        self.SetValue(Editor.FontSizeProperty, fontSize);
        return self;
    }
    
    public static T FontSizeFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Editor
    {
        var context = new PropertyContext<double>(self, Editor.FontSizeProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FontSizeFmg<T>(this SettersContext<T> self,
        double fontSize)
        where T : Editor
    {
        self.XamlSetters.Add(new Setter { Property = Editor.FontSizeProperty, Value = fontSize });
        return self;
    }
    
    public static SettersContext<T> FontSizeFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Editor
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Editor.FontSizeProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateFontSizeToFmg<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : Editor
    {
        double fromValue = self.FontSize;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.FontSize = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateFontSizeTo", transform, callback, length, easing);
    }
    
    public static T HorizontalTextAlignmentFmg<T>(this T self,
        TextAlignment horizontalTextAlignment)
        where T : Editor
    {
        self.SetValue(Editor.HorizontalTextAlignmentProperty, horizontalTextAlignment);
        return self;
    }
    
    public static T HorizontalTextAlignmentFmg<T>(this T self, Func<PropertyContext<TextAlignment>, IPropertyBuilder<TextAlignment>> configure)
        where T : Editor
    {
        var context = new PropertyContext<TextAlignment>(self, Editor.HorizontalTextAlignmentProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> HorizontalTextAlignmentFmg<T>(this SettersContext<T> self,
        TextAlignment horizontalTextAlignment)
        where T : Editor
    {
        self.XamlSetters.Add(new Setter { Property = Editor.HorizontalTextAlignmentProperty, Value = horizontalTextAlignment });
        return self;
    }
    
    public static SettersContext<T> HorizontalTextAlignmentFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<TextAlignment>, IPropertySettersBuilder<TextAlignment>> configure)
        where T : Editor
    {
        var context = new PropertySettersContext<TextAlignment>(self.XamlSetters, Editor.HorizontalTextAlignmentProperty);
        configure(context).Build();
        return self;
    }
    
    public static T VerticalTextAlignmentFmg<T>(this T self,
        TextAlignment verticalTextAlignment)
        where T : Editor
    {
        self.SetValue(Editor.VerticalTextAlignmentProperty, verticalTextAlignment);
        return self;
    }
    
    public static T VerticalTextAlignmentFmg<T>(this T self, Func<PropertyContext<TextAlignment>, IPropertyBuilder<TextAlignment>> configure)
        where T : Editor
    {
        var context = new PropertyContext<TextAlignment>(self, Editor.VerticalTextAlignmentProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> VerticalTextAlignmentFmg<T>(this SettersContext<T> self,
        TextAlignment verticalTextAlignment)
        where T : Editor
    {
        self.XamlSetters.Add(new Setter { Property = Editor.VerticalTextAlignmentProperty, Value = verticalTextAlignment });
        return self;
    }
    
    public static SettersContext<T> VerticalTextAlignmentFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<TextAlignment>, IPropertySettersBuilder<TextAlignment>> configure)
        where T : Editor
    {
        var context = new PropertySettersContext<TextAlignment>(self.XamlSetters, Editor.VerticalTextAlignmentProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FontAutoScalingEnabledFmg<T>(this T self,
        bool fontAutoScalingEnabled)
        where T : Editor
    {
        self.SetValue(Editor.FontAutoScalingEnabledProperty, fontAutoScalingEnabled);
        return self;
    }
    
    public static T FontAutoScalingEnabledFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : Editor
    {
        var context = new PropertyContext<bool>(self, Editor.FontAutoScalingEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FontAutoScalingEnabledFmg<T>(this SettersContext<T> self,
        bool fontAutoScalingEnabled)
        where T : Editor
    {
        self.XamlSetters.Add(new Setter { Property = Editor.FontAutoScalingEnabledProperty, Value = fontAutoScalingEnabled });
        return self;
    }
    
    public static SettersContext<T> FontAutoScalingEnabledFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : Editor
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, Editor.FontAutoScalingEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static T OnCompletedFmg<T>(this T self, EventHandler handler)
        where T : Editor
    {
        self.Completed += handler;
        return self;
    }
    
    public static T OnCompletedFmg<T>(this T self, Action<T> action)
        where T : Editor
    {
        self.Completed += (o, arg) => action(self);
        return self;
    }
    

    public static T TextCenterHorizontalFmg<T>(this T self)
        where T : Editor
    {
        self.SetValue(Editor.HorizontalTextAlignmentProperty, TextAlignment.Center);
        return self;
    }

    public static T TextCenterVerticalFmg<T>(this T self)
        where T : Editor
    {
        self.SetValue(Editor.VerticalTextAlignmentProperty, TextAlignment.Center);
        return self;
    }

    public static T TextCenterFmg<T>(this T self)
        where T : Editor
    {
        self.SetValue(Editor.HorizontalTextAlignmentProperty, TextAlignment.Center);
        self.SetValue(Editor.VerticalTextAlignmentProperty, TextAlignment.Center);
        return self;
    }

    public static T TextTopFmg<T>(this T self)
        where T : Editor
    {
        self.SetValue(Editor.VerticalTextAlignmentProperty, TextAlignment.Start);
        return self;
    }

    public static T TextBottomFmg<T>(this T self)
        where T : Editor, Microsoft.Maui.ITextAlignment
    {
        self.SetValue(Editor.VerticalTextAlignmentProperty, TextAlignment.End);
        return self;
    }

    public static T TextTopStartFmg<T>(this T self)
        where T : Editor
    {
        self.SetValue(Editor.VerticalTextAlignmentProperty, TextAlignment.Start);
        self.SetValue(Editor.HorizontalTextAlignmentProperty, TextAlignment.Start);
        return self;
    }

    public static T TextBottomStartFmg<T>(this T self)
        where T : Editor
    {
        self.SetValue(Editor.VerticalTextAlignmentProperty, TextAlignment.End);
        self.SetValue(Editor.HorizontalTextAlignmentProperty, TextAlignment.Start);
        return self;
    }

    public static T TextTopEndFmg<T>(this T self)
        where T : Editor
    {
        self.SetValue(Editor.VerticalTextAlignmentProperty, TextAlignment.Start);
        self.SetValue(Editor.HorizontalTextAlignmentProperty, TextAlignment.End);
        return self;
    }

    public static T TextBottomEndFmg<T>(this T self)
        where T : Editor
    {
        self.SetValue(Editor.VerticalTextAlignmentProperty, TextAlignment.End);
        self.SetValue(Editor.HorizontalTextAlignmentProperty, TextAlignment.End);
        return self;
    }

    public static T TextStartFmg<T>(this T self)
        where T : Editor
    {
        self.SetValue(Editor.HorizontalTextAlignmentProperty, TextAlignment.Start);
        return self;
    }

    public static T TextEndFmg<T>(this T self)
        where T : Editor
    {
        self.SetValue(Editor.HorizontalTextAlignmentProperty, TextAlignment.End);
        return self;
    }

    
}