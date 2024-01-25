using InputKit.Shared;
using Microsoft.Maui.Controls.Shapes;
using System.Windows.Input;
using static InputKit.Shared.Controls.CheckBox;
using CheckBox = UraniumUI.Material.Controls.CheckBox;

namespace FmgLib.MauiMarkup.UraniumUI;

public static partial class CheckBoxExtension
{
    public static T ColorFmg<T>(this T self,
        Color color)
        where T : CheckBox
    {
        self.SetValue(CheckBox.ColorProperty, color);
        return self;
    }

    public static T ColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : CheckBox
    {
        var context = new PropertyContext<Color>(self, CheckBox.ColorProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ColorFmg<T>(this SettersContext<T> self,
        Color color)
        where T : CheckBox
    {
        self.XamlSetters.Add(new Setter { Property = CheckBox.ColorProperty, Value = color });
        return self;
    }

    public static SettersContext<T> ColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : CheckBox
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, CheckBox.ColorProperty);
        configure(context).Build();
        return self;
    }

    public static T TextColorFmg<T>(this T self,
        Color textColor)
        where T : CheckBox
    {
        self.SetValue(CheckBox.TextColorProperty, textColor);
        return self;
    }

    public static T TextColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : CheckBox
    {
        var context = new PropertyContext<Color>(self, CheckBox.TextColorProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> TextColorFmg<T>(this SettersContext<T> self,
        Color textColor)
        where T : CheckBox
    {
        self.XamlSetters.Add(new Setter { Property = CheckBox.TextColorProperty, Value = textColor });
        return self;
    }

    public static SettersContext<T> TextColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : CheckBox
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, CheckBox.TextColorProperty);
        configure(context).Build();
        return self;
    }

    public static T IconColorFmg<T>(this T self,
       Color iconColor)
       where T : CheckBox
    {
        self.SetValue(CheckBox.IconColorProperty, iconColor);
        return self;
    }

    public static T IconColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : CheckBox
    {
        var context = new PropertyContext<Color>(self, CheckBox.IconColorProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IconColorFmg<T>(this SettersContext<T> self,
        Color iconColor)
        where T : CheckBox
    {
        self.XamlSetters.Add(new Setter { Property = CheckBox.IconColorProperty, Value = iconColor });
        return self;
    }

    public static SettersContext<T> IconColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : CheckBox
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, CheckBox.IconColorProperty);
        configure(context).Build();
        return self;
    }

    public static T BorderColorFmg<T>(this T self,
       Color borderColor)
       where T : CheckBox
    {
        self.SetValue(CheckBox.BorderColorProperty, borderColor);
        return self;
    }

    public static T BorderColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : CheckBox
    {
        var context = new PropertyContext<Color>(self, CheckBox.BorderColorProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> BorderColorFmg<T>(this SettersContext<T> self,
        Color borderColor)
        where T : CheckBox
    {
        self.XamlSetters.Add(new Setter { Property = CheckBox.BorderColorProperty, Value = borderColor });
        return self;
    }

    public static SettersContext<T> BorderColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : CheckBox
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, CheckBox.BorderColorProperty);
        configure(context).Build();
        return self;
    }

    public static T IsCheckedFmg<T>(this T self,
        bool isChecked)
        where T : CheckBox
    {
        self.SetValue(CheckBox.IsCheckedProperty, isChecked);
        return self;
    }

    public static T IsCheckedFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : CheckBox
    {
        var context = new PropertyContext<bool>(self, CheckBox.IsCheckedProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IsCheckedFmg<T>(this SettersContext<T> self,
        bool isChecked)
        where T : CheckBox
    {
        self.XamlSetters.Add(new Setter { Property = CheckBox.IsCheckedProperty, Value = isChecked });
        return self;
    }

    public static SettersContext<T> IsCheckedFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : CheckBox
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, CheckBox.IsCheckedProperty);
        configure(context).Build();
        return self;
    }

    public static T IsDisabledFmg<T>(this T self,
        bool isDisabled)
        where T : CheckBox
    {
        self.SetValue(CheckBox.IsDisabledProperty, isDisabled);
        return self;
    }

    public static T IsDisabledFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : CheckBox
    {
        var context = new PropertyContext<bool>(self, CheckBox.IsDisabledProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IsDisabledFmg<T>(this SettersContext<T> self,
        bool isDisabled)
        where T : CheckBox
    {
        self.XamlSetters.Add(new Setter { Property = CheckBox.IsDisabledProperty, Value = isDisabled });
        return self;
    }

    public static SettersContext<T> IsDisabledFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : CheckBox
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, CheckBox.IsDisabledProperty);
        configure(context).Build();
        return self;
    }

    public static T KeyFmg<T>(this T self,
        int key)
        where T : CheckBox
    {
        self.SetValue(CheckBox.KeyProperty, key);
        return self;
    }

    public static T KeyFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
        where T : CheckBox
    {
        var context = new PropertyContext<int>(self, CheckBox.KeyProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> KeyFmg<T>(this SettersContext<T> self,
        int key)
        where T : CheckBox
    {
        self.XamlSetters.Add(new Setter { Property = CheckBox.KeyProperty, Value = key });
        return self;
    }

    public static SettersContext<T> KeyFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure)
        where T : CheckBox
    {
        var context = new PropertySettersContext<int>(self.XamlSetters, CheckBox.KeyProperty);
        configure(context).Build();
        return self;
    }

    public static T CornerRadiusFmg<T>(this T self,
        int cornerRadius)
        where T : CheckBox
    {
        self.SetValue(CheckBox.CornerRadiusProperty, cornerRadius);
        return self;
    }

    public static T CornerRadiusFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
        where T : CheckBox
    {
        var context = new PropertyContext<int>(self, CheckBox.CornerRadiusProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> CornerRadiusFmg<T>(this SettersContext<T> self,
        int cornerRadius)
        where T : CheckBox
    {
        self.XamlSetters.Add(new Setter { Property = CheckBox.CornerRadiusProperty, Value = cornerRadius });
        return self;
    }

    public static SettersContext<T> CornerRadiusFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure)
        where T : CheckBox
    {
        var context = new PropertySettersContext<int>(self.XamlSetters, CheckBox.CornerRadiusProperty);
        configure(context).Build();
        return self;
    }

    public static T TextFmg<T>(this T self, string text) where T : CheckBox
    {
        self.SetValue(CheckBox.TextProperty, text);
        return self;
    }

    public static T TextFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure) where T : CheckBox
    {
        PropertyContext<string> arg = new PropertyContext<string>(self, CheckBox.TextProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> TextFmg<T>(this SettersContext<T> self, string text) where T : CheckBox
    {
        self.XamlSetters.Add(new Setter
        {
            Property = CheckBox.TextProperty,
            Value = text
        });
        return self;
    }

    public static SettersContext<T> TextFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure) where T : CheckBox
    {
        PropertySettersContext<string> arg = new PropertySettersContext<string>(self.XamlSetters, CheckBox.TextProperty);
        configure(arg).Build();
        return self;
    }

    public static T CheckChangedCommandFmg<T>(this T self, ICommand command) where T : CheckBox
    {
        self.SetValue(CheckBox.CheckChangedCommandProperty, command);
        return self;
    }

    public static T CheckChangedCommandFmg<T>(this T self, Func<PropertyContext<ICommand>, IPropertyBuilder<ICommand>> configure) where T : CheckBox
    {
        PropertyContext<ICommand> arg = new PropertyContext<ICommand>(self, CheckBox.CheckChangedCommandProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> CheckChangedCommandFmg<T>(this SettersContext<T> self, ICommand command) where T : CheckBox
    {
        self.XamlSetters.Add(new Setter
        {
            Property = CheckBox.CheckChangedCommandProperty,
            Value = command
        });
        return self;
    }

    public static SettersContext<T> CheckChangedCommandFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ICommand>, IPropertySettersBuilder<ICommand>> configure) where T : CheckBox
    {
        PropertySettersContext<ICommand> arg = new PropertySettersContext<ICommand>(self.XamlSetters, CheckBox.CheckChangedCommandProperty);
        configure(arg).Build();
        return self;
    }

    public static T CommandParameterFmg<T>(this T self,
        object commandParameter)
        where T : CheckBox
    {
        self.SetValue(CheckBox.CommandParameterProperty, commandParameter);
        return self;
    }

    public static T CommandParameterFmg<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        where T : CheckBox
    {
        var context = new PropertyContext<object>(self, CheckBox.CommandParameterProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> CommandParameterFmg<T>(this SettersContext<T> self,
        object commandParameter)
        where T : CheckBox
    {
        self.XamlSetters.Add(new Setter { Property = CheckBox.CommandParameterProperty, Value = commandParameter });
        return self;
    }

    public static SettersContext<T> CommandParameterFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        where T : CheckBox
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, CheckBox.CommandParameterProperty);
        configure(context).Build();
        return self;
    }

    public static T BoxBackgroundColorFmg<T>(this T self,
       Color boxBackgroundColor)
       where T : CheckBox
    {
        self.SetValue(CheckBox.BoxBackgroundColorProperty, boxBackgroundColor);
        return self;
    }

    public static T BoxBackgroundColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : CheckBox
    {
        var context = new PropertyContext<Color>(self, CheckBox.BoxBackgroundColorProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> BoxBackgroundColorFmg<T>(this SettersContext<T> self,
        Color boxBackgroundColor)
        where T : CheckBox
    {
        self.XamlSetters.Add(new Setter { Property = CheckBox.BoxBackgroundColorProperty, Value = boxBackgroundColor });
        return self;
    }

    public static SettersContext<T> BoxBackgroundColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : CheckBox
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, CheckBox.BoxBackgroundColorProperty);
        configure(context).Build();
        return self;
    }

    public static T TextFontSizeFmg<T>(this T self,
        double fontSize)
        where T : CheckBox
    {
        self.SetValue(CheckBox.TextFontSizeProperty, fontSize);
        return self;
    }

    public static T TextFontSizeFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : CheckBox
    {
        var context = new PropertyContext<double>(self, CheckBox.TextFontSizeProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> TextFontSizeFmg<T>(this SettersContext<T> self,
        double fontSize)
        where T : CheckBox
    {
        self.XamlSetters.Add(new Setter { Property = CheckBox.TextFontSizeProperty, Value = fontSize });
        return self;
    }

    public static SettersContext<T> TextFontSizeFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : CheckBox
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, CheckBox.TextFontSizeProperty);
        configure(context).Build();
        return self;
    }

    public static T FontFamilyFmg<T>(this T self,
        string fontFamily)
        where T : CheckBox
    {
        self.SetValue(CheckBox.FontFamilyProperty, fontFamily);
        return self;
    }

    public static T FontFamilyFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : CheckBox
    {
        var context = new PropertyContext<string>(self, CheckBox.FontFamilyProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> FontFamilyFmg<T>(this SettersContext<T> self,
        string fontFamily)
        where T : CheckBox
    {
        self.XamlSetters.Add(new Setter { Property = CheckBox.FontFamilyProperty, Value = fontFamily });
        return self;
    }

    public static SettersContext<T> FontFamilyFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : CheckBox
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, CheckBox.FontFamilyProperty);
        configure(context).Build();
        return self;
    }

    public static T IconGeometryFmg<T>(this T self, Geometry iconGeometry) where T : CheckBox
    {
        self.SetValue(CheckBox.IconGeometryProperty, iconGeometry);
        return self;
    }

    public static T IconGeometryFmg<T>(this T self, Func<PropertyContext<Geometry>, IPropertyBuilder<Geometry>> configure) where T : CheckBox
    {
        PropertyContext<Geometry> arg = new PropertyContext<Geometry>(self, CheckBox.IconGeometryProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> IconGeometryFmg<T>(this SettersContext<T> self, Geometry iconGeometry) where T : CheckBox
    {
        self.XamlSetters.Add(new Setter
        {
            Property = CheckBox.IconGeometryProperty,
            Value = iconGeometry
        });
        return self;
    }

    public static SettersContext<T> IconGeometryFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Geometry>, IPropertySettersBuilder<Geometry>> configure) where T : CheckBox
    {
        PropertySettersContext<Geometry> arg = new PropertySettersContext<Geometry>(self.XamlSetters, CheckBox.IconGeometryProperty);
        configure(arg).Build();
        return self;
    }

    public static T IsPressedFmg<T>(this T self, bool isPressed) where T : CheckBox
    {
        self.SetValue(CheckBox.IsPressedProperty, isPressed);
        return self;
    }

    public static T IsPressedFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure) where T : CheckBox
    {
        PropertyContext<bool> arg = new PropertyContext<bool>(self, CheckBox.IsPressedProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> IsPressedFmg<T>(this SettersContext<T> self, bool isPressed) where T : CheckBox
    {
        self.XamlSetters.Add(new Setter
        {
            Property = CheckBox.IsPressedProperty,
            Value = isPressed
        });
        return self;
    }

    public static SettersContext<T> IsPressedFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure) where T : CheckBox
    {
        PropertySettersContext<bool> arg = new PropertySettersContext<bool>(self.XamlSetters, CheckBox.IsPressedProperty);
        configure(arg).Build();
        return self;
    }

    public static T LabelPositionFmg<T>(this T self, LabelPosition labelPosition) where T : CheckBox
    {
        self.SetValue(CheckBox.LabelPositionProperty, labelPosition);
        return self;
    }

    public static T LabelPositionFmg<T>(this T self, Func<PropertyContext<LabelPosition>, IPropertyBuilder<LabelPosition>> configure) where T : CheckBox
    {
        PropertyContext<LabelPosition> arg = new PropertyContext<LabelPosition>(self, CheckBox.LabelPositionProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> LabelPositionFmg<T>(this SettersContext<T> self, LabelPosition labelPosition) where T : CheckBox
    {
        self.XamlSetters.Add(new Setter
        {
            Property = CheckBox.LabelPositionProperty,
            Value = labelPosition
        });
        return self;
    }

    public static SettersContext<T> LabelPositionFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<LabelPosition>, IPropertySettersBuilder<LabelPosition>> configure) where T : CheckBox
    {
        PropertySettersContext<LabelPosition> arg = new PropertySettersContext<LabelPosition>(self.XamlSetters, CheckBox.LabelPositionProperty);
        configure(arg).Build();
        return self;
    }

    public static T ValidationColorFmg<T>(this T self,
       Color validationColor)
       where T : CheckBox
    {
        self.SetValue(CheckBox.ValidationColorProperty, validationColor);
        return self;
    }

    public static T ValidationColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : CheckBox
    {
        var context = new PropertyContext<Color>(self, CheckBox.ValidationColorProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ValidationColorFmg<T>(this SettersContext<T> self,
        Color validationColor)
        where T : CheckBox
    {
        self.XamlSetters.Add(new Setter { Property = CheckBox.ValidationColorProperty, Value = validationColor });
        return self;
    }

    public static SettersContext<T> ValidationColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : CheckBox
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, CheckBox.ValidationColorProperty);
        configure(context).Build();
        return self;
    }

    public static T TypeFmg<T>(this T self,
       CheckType type)
       where T : CheckBox
    {
        self.SetValue(CheckBox.TypeProperty, type);
        return self;
    }

    public static T TypeFmg<T>(this T self, Func<PropertyContext<CheckType>, IPropertyBuilder<CheckType>> configure)
        where T : CheckBox
    {
        var context = new PropertyContext<CheckType>(self, CheckBox.TypeProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> TypeFmg<T>(this SettersContext<T> self,
        CheckType type)
        where T : CheckBox
    {
        self.XamlSetters.Add(new Setter { Property = CheckBox.TypeProperty, Value = type });
        return self;
    }

    public static SettersContext<T> TypeFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<CheckType>, IPropertySettersBuilder<CheckType>> configure)
        where T : CheckBox
    {
        var context = new PropertySettersContext<CheckType>(self.XamlSetters, CheckBox.TypeProperty);
        configure(context).Build();
        return self;
    }

    public static T LineBreakModeFmg<T>(this T self,
       LineBreakMode lineBreakMode)
       where T : CheckBox
    {
        self.SetValue(CheckBox.LineBreakModeProperty, lineBreakMode);
        return self;
    }

    public static T LineBreakModeFmg<T>(this T self, Func<PropertyContext<LineBreakMode>, IPropertyBuilder<LineBreakMode>> configure)
        where T : CheckBox
    {
        var context = new PropertyContext<LineBreakMode>(self, CheckBox.LineBreakModeProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> LineBreakModeFmg<T>(this SettersContext<T> self,
        LineBreakMode lineBreakMode)
        where T : CheckBox
    {
        self.XamlSetters.Add(new Setter { Property = CheckBox.LineBreakModeProperty, Value = lineBreakMode });
        return self;
    }

    public static SettersContext<T> LineBreakModeFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<LineBreakMode>, IPropertySettersBuilder<LineBreakMode>> configure)
        where T : CheckBox
    {
        var context = new PropertySettersContext<LineBreakMode>(self.XamlSetters, CheckBox.LineBreakModeProperty);
        configure(context).Build();
        return self;
    }

    public static T IconVerticalOptionsFmg<T>(this T self, LayoutOptions verticalOptions) where T : CheckBox
    {
        self.SetValue(CheckBox.IconVerticalOptionsProperty, verticalOptions);
        return self;
    }

    public static T IconVerticalOptionsFmg<T>(this T self, Func<PropertyContext<LayoutOptions>, IPropertyBuilder<LayoutOptions>> configure) where T : CheckBox
    {
        PropertyContext<LayoutOptions> arg = new PropertyContext<LayoutOptions>(self, CheckBox.IconVerticalOptionsProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> IconVerticalOptionsFmg<T>(this SettersContext<T> self, LayoutOptions verticalOptions) where T : CheckBox
    {
        self.XamlSetters.Add(new Setter
        {
            Property = CheckBox.IconVerticalOptionsProperty,
            Value = verticalOptions
        });
        return self;
    }

    public static SettersContext<T> IconVerticalOptionsFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<LayoutOptions>, IPropertySettersBuilder<LayoutOptions>> configure) where T : CheckBox
    {
        PropertySettersContext<LayoutOptions> arg = new PropertySettersContext<LayoutOptions>(self.XamlSetters, CheckBox.IconVerticalOptionsProperty);
        configure(arg).Build();
        return self;
    }

    public static T IconHorizontalOptionsFmg<T>(this T self, LayoutOptions horizontalOptions) where T : CheckBox
    {
        self.SetValue(CheckBox.IconHorizontalOptionsProperty, horizontalOptions);
        return self;
    }

    public static T IconHorizontalOptionsFmg<T>(this T self, Func<PropertyContext<LayoutOptions>, IPropertyBuilder<LayoutOptions>> configure) where T : CheckBox
    {
        PropertyContext<LayoutOptions> arg = new PropertyContext<LayoutOptions>(self, CheckBox.IconHorizontalOptionsProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> IconHorizontalOptionsFmg<T>(this SettersContext<T> self, LayoutOptions horizontalOptions) where T : CheckBox
    {
        self.XamlSetters.Add(new Setter
        {
            Property = CheckBox.IconHorizontalOptionsProperty,
            Value = horizontalOptions
        });
        return self;
    }

    public static SettersContext<T> IconHorizontalOptionsFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<LayoutOptions>, IPropertySettersBuilder<LayoutOptions>> configure) where T : CheckBox
    {
        PropertySettersContext<LayoutOptions> arg = new PropertySettersContext<LayoutOptions>(self.XamlSetters, CheckBox.IconHorizontalOptionsProperty);
        configure(arg).Build();
        return self;
    }
}
