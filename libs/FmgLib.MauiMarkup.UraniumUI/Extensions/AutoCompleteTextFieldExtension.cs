using UraniumUI.Material.Controls;

namespace FmgLib.MauiMarkup.UraniumUI;

public static partial class AutoCompleteTextFieldExtension
{
    public static T TextFmg<T>(this T self, string text) where T : AutoCompleteTextField
    {
        self.SetValue(AutoCompleteTextField.TextProperty, text);
        return self;
    }

    public static T TextFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure) where T : AutoCompleteTextField
    {
        PropertyContext<string> arg = new PropertyContext<string>(self, AutoCompleteTextField.TextProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> TextFmg<T>(this SettersContext<T> self, string text) where T : AutoCompleteTextField
    {
        self.XamlSetters.Add(new Setter
        {
            Property = AutoCompleteTextField.TextProperty,
            Value = text
        });
        return self;
    }

    public static SettersContext<T> TextFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure) where T : AutoCompleteTextField
    {
        PropertySettersContext<string> arg = new PropertySettersContext<string>(self.XamlSetters, AutoCompleteTextField.TextProperty);
        configure(arg).Build();
        return self;
    }

    public static T SelectedTextFmg<T>(this T self,
       string selectedText)
       where T : AutoCompleteTextField
    {
        self.SetValue(AutoCompleteTextField.SelectedTextProperty, selectedText);
        return self;
    }

    public static T SelectedTextFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : AutoCompleteTextField
    {
        var context = new PropertyContext<string>(self, AutoCompleteTextField.SelectedTextProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> SelectedTextFmg<T>(this SettersContext<T> self,
        string selectedText)
        where T : AutoCompleteTextField
    {
        self.XamlSetters.Add(new Setter { Property = AutoCompleteTextField.SelectedTextProperty, Value = selectedText });
        return self;
    }

    public static SettersContext<T> SelectedTextFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : AutoCompleteTextField
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, AutoCompleteTextField.SelectedTextProperty);
        configure(context).Build();
        return self;
    }

    public static T ItemsSourceFmg<T>(this T self,
        IList<string> itemsSource)
        where T : AutoCompleteTextField
    {
        self.SetValue(AutoCompleteTextField.ItemsSourceProperty, itemsSource);
        return self;
    }

    public static T ItemsSourceFmg<T>(this T self, Func<PropertyContext<IList<string>>, IPropertyBuilder<IList<string>>> configure)
        where T : AutoCompleteTextField
    {
        var context = new PropertyContext<IList<string>>(self, AutoCompleteTextField.ItemsSourceProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ItemsSourceFmg<T>(this SettersContext<T> self,
        IList<string> itemsSource)
        where T : AutoCompleteTextField
    {
        self.XamlSetters.Add(new Setter { Property = AutoCompleteTextField.ItemsSourceProperty, Value = itemsSource });
        return self;
    }

    public static SettersContext<T> ItemsSourceFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<IList<string>>, IPropertySettersBuilder<IList<string>>> configure)
        where T : AutoCompleteTextField
    {
        var context = new PropertySettersContext<IList<string>>(self.XamlSetters, AutoCompleteTextField.ItemsSourceProperty);
        configure(context).Build();
        return self;
    }

    public static T TextColorFmg<T>(this T self,
        Color textColor)
        where T : AutoCompleteTextField
    {
        self.SetValue(AutoCompleteTextField.TextColorProperty, textColor);
        return self;
    }

    public static T TextColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : AutoCompleteTextField
    {
        var context = new PropertyContext<Color>(self, AutoCompleteTextField.TextColorProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> TextColorFmg<T>(this SettersContext<T> self,
        Color textColor)
        where T : AutoCompleteTextField
    {
        self.XamlSetters.Add(new Setter { Property = AutoCompleteTextField.TextColorProperty, Value = textColor });
        return self;
    }

    public static SettersContext<T> TextColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : AutoCompleteTextField
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, AutoCompleteTextField.TextColorProperty);
        configure(context).Build();
        return self;
    }

    public static T AllowClearFmg<T>(this T self,
        bool allowClear)
        where T : AutoCompleteTextField
    {
        self.SetValue(AutoCompleteTextField.AllowClearProperty, allowClear);
        return self;
    }

    public static T AllowClearFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : AutoCompleteTextField
    {
        var context = new PropertyContext<bool>(self, AutoCompleteTextField.AllowClearProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> AllowClearFmg<T>(this SettersContext<T> self,
        bool allowClear)
        where T : AutoCompleteTextField
    {
        self.XamlSetters.Add(new Setter { Property = AutoCompleteTextField.AllowClearProperty, Value = allowClear });
        return self;
    }

    public static SettersContext<T> AllowClearFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : AutoCompleteTextField
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, AutoCompleteTextField.AllowClearProperty);
        configure(context).Build();
        return self;
    }

    public static T ThresholdFmg<T>(this T self,
        int threshold)
        where T : AutoCompleteTextField
    {
        self.SetValue(AutoCompleteTextField.ThresholdProperty, threshold);
        return self;
    }

    public static T ThresholdFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
        where T : AutoCompleteTextField
    {
        var context = new PropertyContext<int>(self, AutoCompleteTextField.ThresholdProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ThresholdFmg<T>(this SettersContext<T> self,
        int threshold)
        where T : AutoCompleteTextField
    {
        self.XamlSetters.Add(new Setter { Property = AutoCompleteTextField.ThresholdProperty, Value = threshold });
        return self;
    }

    public static SettersContext<T> ThresholdFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure)
        where T : AutoCompleteTextField
    {
        var context = new PropertySettersContext<int>(self.XamlSetters, AutoCompleteTextField.ThresholdProperty);
        configure(context).Build();
        return self;
    }
}
