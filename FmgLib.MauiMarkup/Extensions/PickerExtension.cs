namespace FmgLib.MauiMarkup;



public static partial class PickerExtension
{
    public static T FontAttributesFmg<T>(this T self,
        FontAttributes fontAttributes)
        where T : Picker
    {
        self.SetValue(Picker.FontAttributesProperty, fontAttributes);
        return self;
    }
    
    public static T FontAttributesFmg<T>(this T self, Func<PropertyContext<FontAttributes>, IPropertyBuilder<FontAttributes>> configure)
        where T : Picker
    {
        var context = new PropertyContext<FontAttributes>(self, Picker.FontAttributesProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FontAttributesFmg<T>(this SettersContext<T> self,
        FontAttributes fontAttributes)
        where T : Picker
    {
        self.XamlSetters.Add(new Setter { Property = Picker.FontAttributesProperty, Value = fontAttributes });
        return self;
    }
    
    public static SettersContext<T> FontAttributesFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<FontAttributes>, IPropertySettersBuilder<FontAttributes>> configure)
        where T : Picker
    {
        var context = new PropertySettersContext<FontAttributes>(self.XamlSetters, Picker.FontAttributesProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FontFamilyFmg<T>(this T self,
        string fontFamily)
        where T : Picker
    {
        self.SetValue(Picker.FontFamilyProperty, fontFamily);
        return self;
    }
    
    public static T FontFamilyFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : Picker
    {
        var context = new PropertyContext<string>(self, Picker.FontFamilyProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FontFamilyFmg<T>(this SettersContext<T> self,
        string fontFamily)
        where T : Picker
    {
        self.XamlSetters.Add(new Setter { Property = Picker.FontFamilyProperty, Value = fontFamily });
        return self;
    }
    
    public static SettersContext<T> FontFamilyFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : Picker
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, Picker.FontFamilyProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FontSizeFmg<T>(this T self,
        double fontSize)
        where T : Picker
    {
        self.SetValue(Picker.FontSizeProperty, fontSize);
        return self;
    }
    
    public static T FontSizeFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Picker
    {
        var context = new PropertyContext<double>(self, Picker.FontSizeProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FontSizeFmg<T>(this SettersContext<T> self,
        double fontSize)
        where T : Picker
    {
        self.XamlSetters.Add(new Setter { Property = Picker.FontSizeProperty, Value = fontSize });
        return self;
    }
    
    public static SettersContext<T> FontSizeFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Picker
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Picker.FontSizeProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateFontSizeToFmg<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : Picker
    {
        double fromValue = self.FontSize;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.FontSize = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateFontSizeTo", transform, callback, length, easing);
    }
    
    public static T FontAutoScalingEnabledFmg<T>(this T self,
        bool fontAutoScalingEnabled)
        where T : Picker
    {
        self.SetValue(Picker.FontAutoScalingEnabledProperty, fontAutoScalingEnabled);
        return self;
    }
    
    public static T FontAutoScalingEnabledFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : Picker
    {
        var context = new PropertyContext<bool>(self, Picker.FontAutoScalingEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FontAutoScalingEnabledFmg<T>(this SettersContext<T> self,
        bool fontAutoScalingEnabled)
        where T : Picker
    {
        self.XamlSetters.Add(new Setter { Property = Picker.FontAutoScalingEnabledProperty, Value = fontAutoScalingEnabled });
        return self;
    }
    
    public static SettersContext<T> FontAutoScalingEnabledFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : Picker
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, Picker.FontAutoScalingEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static T ItemsFmg<T>(this T self,
        IList<string> items)
        where T : Picker
    {
        foreach (var item in items)
            self.Items.Add(item);
        return self;
    }

    public static T ItemsFmg<T>(this T self,
        params string[] items)
        where T : Picker
    {
        foreach (var item in items)
            self.Items.Add(item);
        return self;
    }
    
    public static T ItemsSourceFmg<T>(this T self,
        System.Collections.IList itemsSource)
        where T : Picker
    {
        self.SetValue(Picker.ItemsSourceProperty, itemsSource);
        return self;
    }
    
    public static T ItemsSourceFmg<T>(this T self, Func<PropertyContext<System.Collections.IList>, IPropertyBuilder<System.Collections.IList>> configure)
        where T : Picker
    {
        var context = new PropertyContext<System.Collections.IList>(self, Picker.ItemsSourceProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ItemsSourceFmg<T>(this SettersContext<T> self,
        System.Collections.IList itemsSource)
        where T : Picker
    {
        self.XamlSetters.Add(new Setter { Property = Picker.ItemsSourceProperty, Value = itemsSource });
        return self;
    }
    
    public static SettersContext<T> ItemsSourceFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<System.Collections.IList>, IPropertySettersBuilder<System.Collections.IList>> configure)
        where T : Picker
    {
        var context = new PropertySettersContext<System.Collections.IList>(self.XamlSetters, Picker.ItemsSourceProperty);
        configure(context).Build();
        return self;
    }
    
    public static T SelectedIndexFmg<T>(this T self,
        int selectedIndex)
        where T : Picker
    {
        self.SetValue(Picker.SelectedIndexProperty, selectedIndex);
        return self;
    }
    
    public static T SelectedIndexFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
        where T : Picker
    {
        var context = new PropertyContext<int>(self, Picker.SelectedIndexProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> SelectedIndexFmg<T>(this SettersContext<T> self,
        int selectedIndex)
        where T : Picker
    {
        self.XamlSetters.Add(new Setter { Property = Picker.SelectedIndexProperty, Value = selectedIndex });
        return self;
    }
    
    public static SettersContext<T> SelectedIndexFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure)
        where T : Picker
    {
        var context = new PropertySettersContext<int>(self.XamlSetters, Picker.SelectedIndexProperty);
        configure(context).Build();
        return self;
    }
    
    public static T SelectedItemFmg<T>(this T self,
        object selectedItem)
        where T : Picker
    {
        self.SetValue(Picker.SelectedItemProperty, selectedItem);
        return self;
    }
    
    public static T SelectedItemFmg<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        where T : Picker
    {
        var context = new PropertyContext<object>(self, Picker.SelectedItemProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> SelectedItemFmg<T>(this SettersContext<T> self,
        object selectedItem)
        where T : Picker
    {
        self.XamlSetters.Add(new Setter { Property = Picker.SelectedItemProperty, Value = selectedItem });
        return self;
    }
    
    public static SettersContext<T> SelectedItemFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        where T : Picker
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, Picker.SelectedItemProperty);
        configure(context).Build();
        return self;
    }
    
    public static T TextColorFmg<T>(this T self,
        Color textColor)
        where T : Picker
    {
        self.SetValue(Picker.TextColorProperty, textColor);
        return self;
    }
    
    public static T TextColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : Picker
    {
        var context = new PropertyContext<Color>(self, Picker.TextColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> TextColorFmg<T>(this SettersContext<T> self,
        Color textColor)
        where T : Picker
    {
        self.XamlSetters.Add(new Setter { Property = Picker.TextColorProperty, Value = textColor });
        return self;
    }
    
    public static SettersContext<T> TextColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : Picker
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, Picker.TextColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateTextColorToFmg<T>(this T self, Color value, uint length = 250, Easing? easing = null)
        where T : Picker
    {
        Color fromValue = self.TextColor;
        var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
        var callback = (Color actValue) => { self.TextColor = actValue; };
        return Transformations.AnimateAsync<Color>(self, "AnimateTextColorTo", transform, callback, length, easing);
    }
    
    public static T CharacterSpacingFmg<T>(this T self,
        double characterSpacing)
        where T : Picker
    {
        self.SetValue(Picker.CharacterSpacingProperty, characterSpacing);
        return self;
    }
    
    public static T CharacterSpacingFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Picker
    {
        var context = new PropertyContext<double>(self, Picker.CharacterSpacingProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> CharacterSpacingFmg<T>(this SettersContext<T> self,
        double characterSpacing)
        where T : Picker
    {
        self.XamlSetters.Add(new Setter { Property = Picker.CharacterSpacingProperty, Value = characterSpacing });
        return self;
    }
    
    public static SettersContext<T> CharacterSpacingFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Picker
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Picker.CharacterSpacingProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateCharacterSpacingToFmg<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : Picker
    {
        double fromValue = self.CharacterSpacing;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.CharacterSpacing = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateCharacterSpacingTo", transform, callback, length, easing);
    }
    
    public static T TitleFmg<T>(this T self,
        string title)
        where T : Picker
    {
        self.SetValue(Picker.TitleProperty, title);
        return self;
    }
    
    public static T TitleFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : Picker
    {
        var context = new PropertyContext<string>(self, Picker.TitleProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> TitleFmg<T>(this SettersContext<T> self,
        string title)
        where T : Picker
    {
        self.XamlSetters.Add(new Setter { Property = Picker.TitleProperty, Value = title });
        return self;
    }
    
    public static SettersContext<T> TitleFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : Picker
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, Picker.TitleProperty);
        configure(context).Build();
        return self;
    }
    
    public static T TitleColorFmg<T>(this T self,
        Color titleColor)
        where T : Picker
    {
        self.SetValue(Picker.TitleColorProperty, titleColor);
        return self;
    }
    
    public static T TitleColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : Picker
    {
        var context = new PropertyContext<Color>(self, Picker.TitleColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> TitleColorFmg<T>(this SettersContext<T> self,
        Color titleColor)
        where T : Picker
    {
        self.XamlSetters.Add(new Setter { Property = Picker.TitleColorProperty, Value = titleColor });
        return self;
    }
    
    public static SettersContext<T> TitleColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : Picker
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, Picker.TitleColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateTitleColorToFmg<T>(this T self, Color value, uint length = 250, Easing? easing = null)
        where T : Picker
    {
        Color fromValue = self.TitleColor;
        var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
        var callback = (Color actValue) => { self.TitleColor = actValue; };
        return Transformations.AnimateAsync<Color>(self, "AnimateTitleColorTo", transform, callback, length, easing);
    }
    
    public static T HorizontalTextAlignmentFmg<T>(this T self,
        TextAlignment horizontalTextAlignment)
        where T : Picker
    {
        self.SetValue(Picker.HorizontalTextAlignmentProperty, horizontalTextAlignment);
        return self;
    }
    
    public static T HorizontalTextAlignmentFmg<T>(this T self, Func<PropertyContext<TextAlignment>, IPropertyBuilder<TextAlignment>> configure)
        where T : Picker
    {
        var context = new PropertyContext<TextAlignment>(self, Picker.HorizontalTextAlignmentProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> HorizontalTextAlignmentFmg<T>(this SettersContext<T> self,
        TextAlignment horizontalTextAlignment)
        where T : Picker
    {
        self.XamlSetters.Add(new Setter { Property = Picker.HorizontalTextAlignmentProperty, Value = horizontalTextAlignment });
        return self;
    }
    
    public static SettersContext<T> HorizontalTextAlignmentFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<TextAlignment>, IPropertySettersBuilder<TextAlignment>> configure)
        where T : Picker
    {
        var context = new PropertySettersContext<TextAlignment>(self.XamlSetters, Picker.HorizontalTextAlignmentProperty);
        configure(context).Build();
        return self;
    }
    
    public static T VerticalTextAlignmentFmg<T>(this T self,
        TextAlignment verticalTextAlignment)
        where T : Picker
    {
        self.SetValue(Picker.VerticalTextAlignmentProperty, verticalTextAlignment);
        return self;
    }
    
    public static T VerticalTextAlignmentFmg<T>(this T self, Func<PropertyContext<TextAlignment>, IPropertyBuilder<TextAlignment>> configure)
        where T : Picker
    {
        var context = new PropertyContext<TextAlignment>(self, Picker.VerticalTextAlignmentProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> VerticalTextAlignmentFmg<T>(this SettersContext<T> self,
        TextAlignment verticalTextAlignment)
        where T : Picker
    {
        self.XamlSetters.Add(new Setter { Property = Picker.VerticalTextAlignmentProperty, Value = verticalTextAlignment });
        return self;
    }
    
    public static SettersContext<T> VerticalTextAlignmentFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<TextAlignment>, IPropertySettersBuilder<TextAlignment>> configure)
        where T : Picker
    {
        var context = new PropertySettersContext<TextAlignment>(self.XamlSetters, Picker.VerticalTextAlignmentProperty);
        configure(context).Build();
        return self;
    }
    
    public static T ItemDisplayBindingFmg<T>(this T self,
        BindingBase itemDisplayBinding)
        where T : Picker
    {
        self.ItemDisplayBinding = itemDisplayBinding;
        return self;
    }
    
    public static T OnSelectedIndexChangedFmg<T>(this T self, EventHandler handler)
        where T : Picker
    {
        self.SelectedIndexChanged += handler;
        return self;
    }
    
    public static T OnSelectedIndexChangedFmg<T>(this T self, Action<T> action)
        where T : Picker
    {
        self.SelectedIndexChanged += (o, arg) => action(self);
        return self;
    }
    

    public static T TextCenterHorizontalFmg<T>(this T self)
        where T : Picker
    {
        self.SetValue(Picker.HorizontalTextAlignmentProperty, TextAlignment.Center);
        return self;
    }

    public static T TextCenterVerticalFmg<T>(this T self)
        where T : Picker
    {
        self.SetValue(Picker.VerticalTextAlignmentProperty, TextAlignment.Center);
        return self;
    }

    public static T TextCenterFmg<T>(this T self)
        where T : Picker
    {
        self.SetValue(Picker.HorizontalTextAlignmentProperty, TextAlignment.Center);
        self.SetValue(Picker.VerticalTextAlignmentProperty, TextAlignment.Center);
        return self;
    }

    public static T TextTopFmg<T>(this T self)
        where T : Picker
    {
        self.SetValue(Picker.VerticalTextAlignmentProperty, TextAlignment.Start);
        return self;
    }

    public static T TextBottomFmg<T>(this T self)
        where T : Picker, Microsoft.Maui.ITextAlignment
    {
        self.SetValue(Picker.VerticalTextAlignmentProperty, TextAlignment.End);
        return self;
    }

    public static T TextTopStartFmg<T>(this T self)
        where T : Picker
    {
        self.SetValue(Picker.VerticalTextAlignmentProperty, TextAlignment.Start);
        self.SetValue(Picker.HorizontalTextAlignmentProperty, TextAlignment.Start);
        return self;
    }

    public static T TextBottomStartFmg<T>(this T self)
        where T : Picker
    {
        self.SetValue(Picker.VerticalTextAlignmentProperty, TextAlignment.End);
        self.SetValue(Picker.HorizontalTextAlignmentProperty, TextAlignment.Start);
        return self;
    }

    public static T TextTopEndFmg<T>(this T self)
        where T : Picker
    {
        self.SetValue(Picker.VerticalTextAlignmentProperty, TextAlignment.Start);
        self.SetValue(Picker.HorizontalTextAlignmentProperty, TextAlignment.End);
        return self;
    }

    public static T TextBottomEndFmg<T>(this T self)
        where T : Picker
    {
        self.SetValue(Picker.VerticalTextAlignmentProperty, TextAlignment.End);
        self.SetValue(Picker.HorizontalTextAlignmentProperty, TextAlignment.End);
        return self;
    }

    public static T TextStartFmg<T>(this T self)
        where T : Picker
    {
        self.SetValue(Picker.HorizontalTextAlignmentProperty, TextAlignment.Start);
        return self;
    }

    public static T TextEndFmg<T>(this T self)
        where T : Picker
    {
        self.SetValue(Picker.HorizontalTextAlignmentProperty, TextAlignment.End);
        return self;
    }

    
}
