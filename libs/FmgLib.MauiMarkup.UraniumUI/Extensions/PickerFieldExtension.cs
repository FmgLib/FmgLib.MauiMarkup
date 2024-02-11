using System.Collections;
using System.Windows.Input;
using UraniumUI.Material.Controls;

namespace FmgLib.MauiMarkup.UraniumUI;

public static partial class PickerFieldExtension
{
    public static T ItemsSourceFmg<T>(this T self,
        IList itemsSource)
        where T : PickerField
    {
        self.SetValue(PickerField.ItemsSourceProperty, itemsSource);
        return self;
    }

    public static T ItemsSourceFmg<T>(this T self, Func<PropertyContext<IList>, IPropertyBuilder<IList>> configure)
        where T : PickerField
    {
        var context = new PropertyContext<IList>(self, PickerField.ItemsSourceProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ItemsSourceFmg<T>(this SettersContext<T> self,
        IList itemsSource)
        where T : PickerField
    {
        self.XamlSetters.Add(new Setter { Property = PickerField.ItemsSourceProperty, Value = itemsSource });
        return self;
    }

    public static SettersContext<T> ItemsSourceFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<IList>, IPropertySettersBuilder<IList>> configure)
        where T : PickerField
    {
        var context = new PropertySettersContext<IList>(self.XamlSetters, PickerField.ItemsSourceProperty);
        configure(context).Build();
        return self;
    }

    public static T SelectedItemFmg<T>(this T self,
        object selectedItem)
        where T : PickerField
    {
        self.SetValue(PickerField.SelectedItemProperty, selectedItem);
        return self;
    }

    public static T SelectedItemFmg<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        where T : PickerField
    {
        var context = new PropertyContext<object>(self, PickerField.SelectedItemProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> SelectedItemFmg<T>(this SettersContext<T> self,
        object selectedItem)
        where T : PickerField
    {
        self.XamlSetters.Add(new Setter { Property = PickerField.SelectedItemProperty, Value = selectedItem });
        return self;
    }

    public static SettersContext<T> SelectedItemFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        where T : PickerField
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, PickerField.SelectedItemProperty);
        configure(context).Build();
        return self;
    }

    public static T SelectedIndexFmg<T>(this T self,
        int selectedIndex)
        where T : PickerField
    {
        self.SetValue(PickerField.SelectedIndexProperty, selectedIndex);
        return self;
    }

    public static T SelectedIndexFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
        where T : PickerField
    {
        var context = new PropertyContext<int>(self, PickerField.SelectedIndexProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> SelectedIndexFmg<T>(this SettersContext<T> self,
        int selectedIndex)
        where T : PickerField
    {
        self.XamlSetters.Add(new Setter { Property = PickerField.SelectedIndexProperty, Value = selectedIndex });
        return self;
    }

    public static SettersContext<T> SelectedIndexFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure)
        where T : PickerField
    {
        var context = new PropertySettersContext<int>(self.XamlSetters, PickerField.SelectedIndexProperty);
        configure(context).Build();
        return self;
    }

    public static T ItemDisplayBindingFmg<T>(this T self,
        BindingBase itemDisplayBinding)
        where T : PickerField
    {
        self.ItemDisplayBinding = itemDisplayBinding;
        return self;
    }

    public static T TextColorFmg<T>(this T self,
        Color textColor)
        where T : PickerField
    {
        self.SetValue(PickerField.TextColorProperty, textColor);
        return self;
    }

    public static T TextColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : PickerField
    {
        var context = new PropertyContext<Color>(self, PickerField.TextColorProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> TextColorFmg<T>(this SettersContext<T> self,
        Color textColor)
        where T : PickerField
    {
        self.XamlSetters.Add(new Setter { Property = PickerField.TextColorProperty, Value = textColor });
        return self;
    }

    public static SettersContext<T> TextColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : PickerField
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, PickerField.TextColorProperty);
        configure(context).Build();
        return self;
    }

    public static T CharacterSpacingFmg<T>(this T self,
        double characterSpacing)
        where T : PickerField
    {
        self.SetValue(PickerField.CharacterSpacingProperty, characterSpacing);
        return self;
    }

    public static T CharacterSpacingFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : PickerField
    {
        var context = new PropertyContext<double>(self, PickerField.CharacterSpacingProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> CharacterSpacingFmg<T>(this SettersContext<T> self,
        double characterSpacing)
        where T : PickerField
    {
        self.XamlSetters.Add(new Setter { Property = PickerField.CharacterSpacingProperty, Value = characterSpacing });
        return self;
    }

    public static SettersContext<T> CharacterSpacingFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : PickerField
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, PickerField.CharacterSpacingProperty);
        configure(context).Build();
        return self;
    }

    public static T FontAttributesFmg<T>(this T self,
        FontAttributes fontAttributes)
        where T : PickerField
    {
        self.SetValue(PickerField.FontAttributesProperty, fontAttributes);
        return self;
    }

    public static T FontAttributesFmg<T>(this T self, Func<PropertyContext<FontAttributes>, IPropertyBuilder<FontAttributes>> configure)
        where T : PickerField
    {
        var context = new PropertyContext<FontAttributes>(self, PickerField.FontAttributesProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> FontAttributesFmg<T>(this SettersContext<T> self,
        FontAttributes fontAttributes)
        where T : PickerField
    {
        self.XamlSetters.Add(new Setter { Property = PickerField.FontAttributesProperty, Value = fontAttributes });
        return self;
    }

    public static SettersContext<T> FontAttributesFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<FontAttributes>, IPropertySettersBuilder<FontAttributes>> configure)
        where T : PickerField
    {
        var context = new PropertySettersContext<FontAttributes>(self.XamlSetters, PickerField.FontAttributesProperty);
        configure(context).Build();
        return self;
    }

    public static T FontFamilyFmg<T>(this T self,
        string fontFamily)
        where T : PickerField
    {
        self.SetValue(PickerField.FontFamilyProperty, fontFamily);
        return self;
    }

    public static T FontFamilyFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : PickerField
    {
        var context = new PropertyContext<string>(self, PickerField.FontFamilyProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> FontFamilyFmg<T>(this SettersContext<T> self,
        string fontFamily)
        where T : PickerField
    {
        self.XamlSetters.Add(new Setter { Property = PickerField.FontFamilyProperty, Value = fontFamily });
        return self;
    }

    public static SettersContext<T> FontFamilyFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : PickerField
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, PickerField.FontFamilyProperty);
        configure(context).Build();
        return self;
    }

    public static T FontSizeFmg<T>(this T self,
        double fontSize)
        where T : PickerField
    {
        self.SetValue(PickerField.FontSizeProperty, fontSize);
        return self;
    }

    public static T FontSizeFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : PickerField
    {
        var context = new PropertyContext<double>(self, PickerField.FontSizeProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> FontSizeFmg<T>(this SettersContext<T> self,
        double fontSize)
        where T : PickerField
    {
        self.XamlSetters.Add(new Setter { Property = PickerField.FontSizeProperty, Value = fontSize });
        return self;
    }

    public static SettersContext<T> FontSizeFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : PickerField
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, PickerField.FontSizeProperty);
        configure(context).Build();
        return self;
    }

    public static T FontAutoScalingEnabledFmg<T>(this T self,
       bool fontAutoScalingEnabled)
       where T : PickerField
    {
        self.SetValue(PickerField.FontAutoScalingEnabledProperty, fontAutoScalingEnabled);
        return self;
    }

    public static T FontAutoScalingEnabledFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : PickerField
    {
        var context = new PropertyContext<bool>(self, PickerField.FontAutoScalingEnabledProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> FontAutoScalingEnabledFmg<T>(this SettersContext<T> self,
        bool fontAutoScalingEnabled)
        where T : PickerField
    {
        self.XamlSetters.Add(new Setter { Property = PickerField.FontAutoScalingEnabledProperty, Value = fontAutoScalingEnabled });
        return self;
    }

    public static SettersContext<T> FontAutoScalingEnabledFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : PickerField
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, PickerField.FontAutoScalingEnabledProperty);
        configure(context).Build();
        return self;
    }

    public static T AllowClearFmg<T>(this T self,
        bool allowClear)
        where T : PickerField
    {
        self.SetValue(PickerField.AllowClearProperty, allowClear);
        return self;
    }

    public static T AllowClearFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : PickerField
    {
        var context = new PropertyContext<bool>(self, PickerField.AllowClearProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> AllowClearFmg<T>(this SettersContext<T> self,
        bool allowClear)
        where T : PickerField
    {
        self.XamlSetters.Add(new Setter { Property = PickerField.AllowClearProperty, Value = allowClear });
        return self;
    }

    public static SettersContext<T> AllowClearFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : PickerField
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, PickerField.AllowClearProperty);
        configure(context).Build();
        return self;
    }

    public static T SelectedValueChangedCommandFmg<T>(this T self, ICommand command) where T : PickerField
    {
        self.SetValue(PickerField.SelectedValueChangedCommandProperty, command);
        return self;
    }

    public static T SelectedValueChangedCommandFmg<T>(this T self, Func<PropertyContext<ICommand>, IPropertyBuilder<ICommand>> configure) where T : PickerField
    {
        PropertyContext<ICommand> arg = new PropertyContext<ICommand>(self, PickerField.SelectedValueChangedCommandProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> SelectedValueChangedCommandFmg<T>(this SettersContext<T> self, ICommand command) where T : PickerField
    {
        self.XamlSetters.Add(new Setter
        {
            Property = PickerField.SelectedValueChangedCommandProperty,
            Value = command
        });
        return self;
    }

    public static SettersContext<T> SelectedValueChangedCommandFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ICommand>, IPropertySettersBuilder<ICommand>> configure) where T : PickerField
    {
        PropertySettersContext<ICommand> arg = new PropertySettersContext<ICommand>(self.XamlSetters, PickerField.SelectedValueChangedCommandProperty);
        configure(arg).Build();
        return self;
    }
}
