using InputKit.Shared;
using Microsoft.Maui.Controls.Shapes;
using System.Windows.Input;
using UraniumUI.Material.Controls;
using RadioButton = UraniumUI.Material.Controls.RadioButton;

namespace FmgLib.MauiMarkup.UraniumUI;

public static partial class RadioButtonExtension
{
    public static T IsCheckedFmg<T>(this T self,
        bool isChecked)
        where T : RadioButton
    {
        self.SetValue(RadioButton.IsCheckedProperty, isChecked);
        return self;
    }

    public static T IsCheckedFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : RadioButton
    {
        var context = new PropertyContext<bool>(self, RadioButton.IsCheckedProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IsCheckedFmg<T>(this SettersContext<T> self,
        bool isChecked)
        where T : RadioButton
    {
        self.XamlSetters.Add(new Setter { Property = RadioButton.IsCheckedProperty, Value = isChecked });
        return self;
    }

    public static SettersContext<T> IsCheckedFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : RadioButton
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, RadioButton.IsCheckedProperty);
        configure(context).Build();
        return self;
    }

    public static T IsDisabledFmg<T>(this T self,
        bool isDisabled)
        where T : RadioButton
    {
        self.SetValue(RadioButton.IsDisabledProperty, isDisabled);
        return self;
    }

    public static T IsDisabledFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : RadioButton
    {
        var context = new PropertyContext<bool>(self, RadioButton.IsDisabledProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IsDisabledFmg<T>(this SettersContext<T> self,
        bool isDisabled)
        where T : RadioButton
    {
        self.XamlSetters.Add(new Setter { Property = RadioButton.IsDisabledProperty, Value = isDisabled });
        return self;
    }

    public static SettersContext<T> IsDisabledFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : RadioButton
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, RadioButton.IsDisabledProperty);
        configure(context).Build();
        return self;
    }

    public static T TextFmg<T>(this T self,
        string text)
        where T : RadioButton
    {
        self.SetValue(RadioButton.TextProperty, text);
        return self;
    }

    public static T TextFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : RadioButton
    {
        var context = new PropertyContext<string>(self, RadioButton.TextProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> TextFmg<T>(this SettersContext<T> self,
        string text)
        where T : RadioButton
    {
        self.XamlSetters.Add(new Setter { Property = RadioButton.TextProperty, Value = text });
        return self;
    }

    public static SettersContext<T> TextFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : RadioButton
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, RadioButton.TextProperty);
        configure(context).Build();
        return self;
    }

    public static T TextFontSizeFmg<T>(this T self,
        double fontSize)
        where T : RadioButton
    {
        self.SetValue(RadioButton.TextFontSizeProperty, fontSize);
        return self;
    }

    public static T TextFontSizeFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : RadioButton
    {
        var context = new PropertyContext<double>(self, RadioButton.TextFontSizeProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> TextFontSizeFmg<T>(this SettersContext<T> self,
        double fontSize)
        where T : RadioButton
    {
        self.XamlSetters.Add(new Setter { Property = RadioButton.TextFontSizeProperty, Value = fontSize });
        return self;
    }

    public static SettersContext<T> TextFontSizeFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : RadioButton
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, RadioButton.TextFontSizeProperty);
        configure(context).Build();
        return self;
    }

    public static T FontFamilyFmg<T>(this T self,
        string fontFamily)
        where T : RadioButton
    {
        self.SetValue(RadioButton.FontFamilyProperty, fontFamily);
        return self;
    }

    public static T FontFamilyFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : RadioButton
    {
        var context = new PropertyContext<string>(self, RadioButton.FontFamilyProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> FontFamilyFmg<T>(this SettersContext<T> self,
        string fontFamily)
        where T : RadioButton
    {
        self.XamlSetters.Add(new Setter { Property = RadioButton.FontFamilyProperty, Value = fontFamily });
        return self;
    }

    public static SettersContext<T> FontFamilyFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : RadioButton
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, RadioButton.FontFamilyProperty);
        configure(context).Build();
        return self;
    }

    public static T ColorFmg<T>(this T self,
        Color color)
        where T : RadioButton
    {
        self.SetValue(RadioButton.ColorProperty, color);
        return self;
    }

    public static T ColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : RadioButton
    {
        var context = new PropertyContext<Color>(self, RadioButton.ColorProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ColorFmg<T>(this SettersContext<T> self,
        Color color)
        where T : RadioButton
    {
        self.XamlSetters.Add(new Setter { Property = RadioButton.ColorProperty, Value = color });
        return self;
    }

    public static SettersContext<T> ColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : RadioButton
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, RadioButton.ColorProperty);
        configure(context).Build();
        return self;
    }

    public static T TextColorFmg<T>(this T self,
        Color textColor)
        where T : RadioButton
    {
        self.SetValue(RadioButton.TextColorProperty, textColor);
        return self;
    }

    public static T TextColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : RadioButton
    {
        var context = new PropertyContext<Color>(self, RadioButton.TextColorProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> TextColorFmg<T>(this SettersContext<T> self,
        Color textColor)
        where T : RadioButton
    {
        self.XamlSetters.Add(new Setter { Property = RadioButton.TextColorProperty, Value = textColor });
        return self;
    }

    public static SettersContext<T> TextColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : RadioButton
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, RadioButton.TextColorProperty);
        configure(context).Build();
        return self;
    }

    public static T CircleColorFmg<T>(this T self,
       Color iconColor)
       where T : RadioButton
    {
        self.SetValue(RadioButton.CircleColorProperty, iconColor);
        return self;
    }

    public static T CircleColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : RadioButton
    {
        var context = new PropertyContext<Color>(self, RadioButton.CircleColorProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> CircleColorFmg<T>(this SettersContext<T> self,
        Color iconColor)
        where T : RadioButton
    {
        self.XamlSetters.Add(new Setter { Property = RadioButton.CircleColorProperty, Value = iconColor });
        return self;
    }

    public static SettersContext<T> CircleColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : RadioButton
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, RadioButton.CircleColorProperty);
        configure(context).Build();
        return self;
    }

    public static T ClickCommandFmg<T>(this T self, ICommand command) where T : RadioButton
    {
        self.SetValue(RadioButton.ClickCommandProperty, command);
        return self;
    }

    public static T ClickCommandFmg<T>(this T self, Func<PropertyContext<ICommand>, IPropertyBuilder<ICommand>> configure) where T : RadioButton
    {
        PropertyContext<ICommand> arg = new PropertyContext<ICommand>(self, RadioButton.ClickCommandProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> ClickCommandFmg<T>(this SettersContext<T> self, ICommand command) where T : RadioButton
    {
        self.XamlSetters.Add(new Setter
        {
            Property = RadioButton.ClickCommandProperty,
            Value = command
        });
        return self;
    }

    public static SettersContext<T> ClickCommandFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ICommand>, IPropertySettersBuilder<ICommand>> configure) where T : RadioButton
    {
        PropertySettersContext<ICommand> arg = new PropertySettersContext<ICommand>(self.XamlSetters, RadioButton.ClickCommandProperty);
        configure(arg).Build();
        return self;
    }

    public static T CommandParameterFmg<T>(this T self,
        object commandParameter)
        where T : RadioButton
    {
        self.SetValue(RadioButton.CommandParameterProperty, commandParameter);
        return self;
    }

    public static T CommandParameterFmg<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        where T : RadioButton
    {
        var context = new PropertyContext<object>(self, RadioButton.CommandParameterProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> CommandParameterFmg<T>(this SettersContext<T> self,
        object commandParameter)
        where T : RadioButton
    {
        self.XamlSetters.Add(new Setter { Property = RadioButton.CommandParameterProperty, Value = commandParameter });
        return self;
    }

    public static SettersContext<T> CommandParameterFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        where T : RadioButton
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, RadioButton.CommandParameterProperty);
        configure(context).Build();
        return self;
    }

    public static T SelectedIconGeomertyFmg<T>(this T self,
        Geometry geometry)
        where T : RadioButton
    {
        self.SetValue(RadioButton.SelectedIconGeomertyProperty, geometry);
        return self;
    }

    public static T SelectedIconGeomertyFmg<T>(this T self, Func<PropertyContext<Geometry>, IPropertyBuilder<Geometry>> configure)
        where T : RadioButton
    {
        var context = new PropertyContext<Geometry>(self, RadioButton.SelectedIconGeomertyProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> SelectedIconGeomertyFmg<T>(this SettersContext<T> self,
        Geometry geometry)
        where T : RadioButton
    {
        self.XamlSetters.Add(new Setter { Property = RadioButton.SelectedIconGeomertyProperty, Value = geometry });
        return self;
    }

    public static SettersContext<T> SelectedIconGeomertyFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Geometry>, IPropertySettersBuilder<Geometry>> configure)
        where T : RadioButton
    {
        var context = new PropertySettersContext<Geometry>(self.XamlSetters, RadioButton.SelectedIconGeomertyProperty);
        configure(context).Build();
        return self;
    }

    public static T LabelPositionFmg<T>(this T self, LabelPosition labelPosition) where T : RadioButton
    {
        self.SetValue(RadioButton.LabelPositionProperty, labelPosition);
        return self;
    }

    public static T LabelPositionFmg<T>(this T self, Func<PropertyContext<LabelPosition>, IPropertyBuilder<LabelPosition>> configure) where T : RadioButton
    {
        PropertyContext<LabelPosition> arg = new PropertyContext<LabelPosition>(self, RadioButton.LabelPositionProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> LabelPositionFmg<T>(this SettersContext<T> self, LabelPosition labelPosition) where T : RadioButton
    {
        self.XamlSetters.Add(new Setter
        {
            Property = RadioButton.LabelPositionProperty,
            Value = labelPosition
        });
        return self;
    }

    public static SettersContext<T> LabelPositionFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<LabelPosition>, IPropertySettersBuilder<LabelPosition>> configure) where T : RadioButton
    {
        PropertySettersContext<LabelPosition> arg = new PropertySettersContext<LabelPosition>(self.XamlSetters, RadioButton.LabelPositionProperty);
        configure(arg).Build();
        return self;
    }

    public static T LineBreakModeFmg<T>(this T self,
       LineBreakMode lineBreakMode)
       where T : RadioButton
    {
        self.SetValue(RadioButton.LineBreakModeProperty, lineBreakMode);
        return self;
    }

    public static T LineBreakModeFmg<T>(this T self, Func<PropertyContext<LineBreakMode>, IPropertyBuilder<LineBreakMode>> configure)
        where T : RadioButton
    {
        var context = new PropertyContext<LineBreakMode>(self, RadioButton.LineBreakModeProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> LineBreakModeFmg<T>(this SettersContext<T> self,
        LineBreakMode lineBreakMode)
        where T : RadioButton
    {
        self.XamlSetters.Add(new Setter { Property = RadioButton.LineBreakModeProperty, Value = lineBreakMode });
        return self;
    }

    public static SettersContext<T> LineBreakModeFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<LineBreakMode>, IPropertySettersBuilder<LineBreakMode>> configure)
        where T : RadioButton
    {
        var context = new PropertySettersContext<LineBreakMode>(self.XamlSetters, RadioButton.LineBreakModeProperty);
        configure(context).Build();
        return self;
    }

    public static T IconVerticalOptionsFmg<T>(this T self, LayoutOptions verticalOptions) where T : RadioButton
    {
        self.SetValue(RadioButton.IconVerticalOptionsProperty, verticalOptions);
        return self;
    }

    public static T IconVerticalOptionsFmg<T>(this T self, Func<PropertyContext<LayoutOptions>, IPropertyBuilder<LayoutOptions>> configure) where T : RadioButton
    {
        PropertyContext<LayoutOptions> arg = new PropertyContext<LayoutOptions>(self, RadioButton.IconVerticalOptionsProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> IconVerticalOptionsFmg<T>(this SettersContext<T> self, LayoutOptions verticalOptions) where T : RadioButton
    {
        self.XamlSetters.Add(new Setter
        {
            Property = RadioButton.IconVerticalOptionsProperty,
            Value = verticalOptions
        });
        return self;
    }

    public static SettersContext<T> IconVerticalOptionsFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<LayoutOptions>, IPropertySettersBuilder<LayoutOptions>> configure) where T : RadioButton
    {
        PropertySettersContext<LayoutOptions> arg = new PropertySettersContext<LayoutOptions>(self.XamlSetters, RadioButton.IconVerticalOptionsProperty);
        configure(arg).Build();
        return self;
    }

    public static T IconHorizontalOptionsFmg<T>(this T self, LayoutOptions horizontalOptions) where T : RadioButton
    {
        self.SetValue(RadioButton.IconHorizontalOptionsProperty, horizontalOptions);
        return self;
    }

    public static T IconHorizontalOptionsFmg<T>(this T self, Func<PropertyContext<LayoutOptions>, IPropertyBuilder<LayoutOptions>> configure) where T : RadioButton
    {
        PropertyContext<LayoutOptions> arg = new PropertyContext<LayoutOptions>(self, RadioButton.IconHorizontalOptionsProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> IconHorizontalOptionsFmg<T>(this SettersContext<T> self, LayoutOptions horizontalOptions) where T : RadioButton
    {
        self.XamlSetters.Add(new Setter
        {
            Property = RadioButton.IconHorizontalOptionsProperty,
            Value = horizontalOptions
        });
        return self;
    }

    public static SettersContext<T> IconHorizontalOptionsFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<LayoutOptions>, IPropertySettersBuilder<LayoutOptions>> configure) where T : RadioButton
    {
        PropertySettersContext<LayoutOptions> arg = new PropertySettersContext<LayoutOptions>(self.XamlSetters, RadioButton.IconHorizontalOptionsProperty);
        configure(arg).Build();
        return self;
    }

    public static T ValueFmg<T>(this T self,
        object value)
        where T : RadioButton
    {
        self.SetValue(RadioButton.ValueProperty, value);
        return self;
    }

    public static T ValueFmg<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        where T : RadioButton
    {
        var context = new PropertyContext<object>(self, RadioButton.ValueProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ValueFmg<T>(this SettersContext<T> self,
        object value)
        where T : RadioButton
    {
        self.XamlSetters.Add(new Setter { Property = RadioButton.ValueProperty, Value = value });
        return self;
    }

    public static SettersContext<T> ValueFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        where T : RadioButton
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, RadioButton.ValueProperty);
        configure(context).Build();
        return self;
    }
}
