using System.Windows.Input;
using UraniumUI.Controls;

namespace FmgLib.MauiMarkup.UraniumUI;

public static partial class AutoCompleteViewExtension
{
    public static T TextFmg<T>(this T self, string text) where T : AutoCompleteView
    {
        self.SetValue(AutoCompleteView.TextProperty, text);
        return self;
    }

    public static T TextFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure) where T : AutoCompleteView
    {
        PropertyContext<string> arg = new PropertyContext<string>(self, AutoCompleteView.TextProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> TextFmg<T>(this SettersContext<T> self, string text) where T : AutoCompleteView
    {
        self.XamlSetters.Add(new Setter
        {
            Property = AutoCompleteView.TextProperty,
            Value = text
        });
        return self;
    }

    public static SettersContext<T> TextFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure) where T : AutoCompleteView
    {
        PropertySettersContext<string> arg = new PropertySettersContext<string>(self.XamlSetters, AutoCompleteView.TextProperty);
        configure(arg).Build();
        return self;
    }

    public static T SelectedTextFmg<T>(this T self,
       string selectedText)
       where T : AutoCompleteView
    {
        self.SetValue(AutoCompleteView.SelectedTextProperty, selectedText);
        return self;
    }

    public static T SelectedTextFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : AutoCompleteView
    {
        var context = new PropertyContext<string>(self, AutoCompleteView.SelectedTextProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> SelectedTextFmg<T>(this SettersContext<T> self,
        string selectedText)
        where T : AutoCompleteView
    {
        self.XamlSetters.Add(new Setter { Property = AutoCompleteView.SelectedTextProperty, Value = selectedText });
        return self;
    }

    public static SettersContext<T> SelectedTextFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : AutoCompleteView
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, AutoCompleteView.SelectedTextProperty);
        configure(context).Build();
        return self;
    }

    public static T ItemsSourceFmg<T>(this T self,
        IList<string> itemsSource)
        where T : AutoCompleteView
    {
        self.SetValue(AutoCompleteView.ItemsSourceProperty, itemsSource);
        return self;
    }

    public static T ItemsSourceFmg<T>(this T self, Func<PropertyContext<IList<string>>, IPropertyBuilder<IList<string>>> configure)
        where T : AutoCompleteView
    {
        var context = new PropertyContext<IList<string>>(self, AutoCompleteView.ItemsSourceProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ItemsSourceFmg<T>(this SettersContext<T> self,
        IList<string> itemsSource)
        where T : AutoCompleteView
    {
        self.XamlSetters.Add(new Setter { Property = AutoCompleteView.ItemsSourceProperty, Value = itemsSource });
        return self;
    }

    public static SettersContext<T> ItemsSourceFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<IList<string>>, IPropertySettersBuilder<IList<string>>> configure)
        where T : AutoCompleteView
    {
        var context = new PropertySettersContext<IList<string>>(self.XamlSetters, AutoCompleteView.ItemsSourceProperty);
        configure(context).Build();
        return self;
    }

    public static T TextColorFmg<T>(this T self,
        Color textColor)
        where T : AutoCompleteView
    {
        self.SetValue(AutoCompleteView.TextColorProperty, textColor);
        return self;
    }

    public static T TextColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : AutoCompleteView
    {
        var context = new PropertyContext<Color>(self, AutoCompleteView.TextColorProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> TextColorFmg<T>(this SettersContext<T> self,
        Color textColor)
        where T : AutoCompleteView
    {
        self.XamlSetters.Add(new Setter { Property = AutoCompleteView.TextColorProperty, Value = textColor });
        return self;
    }

    public static SettersContext<T> TextColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : AutoCompleteView
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, AutoCompleteView.TextColorProperty);
        configure(context).Build();
        return self;
    }

    public static T ThresholdFmg<T>(this T self,
        int threshold)
        where T : AutoCompleteView
    {
        self.SetValue(AutoCompleteView.ThresholdProperty, threshold);
        return self;
    }

    public static T ThresholdFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
        where T : AutoCompleteView
    {
        var context = new PropertyContext<int>(self, AutoCompleteView.ThresholdProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ThresholdFmg<T>(this SettersContext<T> self,
        int threshold)
        where T : AutoCompleteView
    {
        self.XamlSetters.Add(new Setter { Property = AutoCompleteView.ThresholdProperty, Value = threshold });
        return self;
    }

    public static SettersContext<T> ThresholdFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure)
        where T : AutoCompleteView
    {
        var context = new PropertySettersContext<int>(self.XamlSetters, AutoCompleteView.ThresholdProperty);
        configure(context).Build();
        return self;
    }

    public static T ReturnCommandParameterFmg<T>(this T self,
        object commandParameter)
        where T : AutoCompleteView
    {
        self.SetValue(AutoCompleteView.ReturnCommandParameterProperty, commandParameter);
        return self;
    }

    public static T ReturnCommandParameterFmg<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        where T : AutoCompleteView
    {
        var context = new PropertyContext<object>(self, AutoCompleteView.ReturnCommandParameterProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ReturnCommandParameterFmg<T>(this SettersContext<T> self,
        object commandParameter)
        where T : AutoCompleteView
    {
        self.XamlSetters.Add(new Setter { Property = AutoCompleteView.ReturnCommandParameterProperty, Value = commandParameter });
        return self;
    }

    public static SettersContext<T> ReturnCommandParameterFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        where T : AutoCompleteView
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, AutoCompleteView.ReturnCommandParameterProperty);
        configure(context).Build();
        return self;
    }

    public static T ReturnCommandFmg<T>(this T self, ICommand command) where T : AutoCompleteView
    {
        self.SetValue(AutoCompleteView.ReturnCommandProperty, command);
        return self;
    }

    public static T ReturnCommandFmg<T>(this T self, Func<PropertyContext<ICommand>, IPropertyBuilder<ICommand>> configure) where T : AutoCompleteView
    {
        PropertyContext<ICommand> arg = new PropertyContext<ICommand>(self, AutoCompleteView.ReturnCommandProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> ReturnCommandFmg<T>(this SettersContext<T> self, ICommand command) where T : AutoCompleteView
    {
        self.XamlSetters.Add(new Setter
        {
            Property = AutoCompleteView.ReturnCommandProperty,
            Value = command
        });
        return self;
    }

    public static SettersContext<T> ReturnCommandFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ICommand>, IPropertySettersBuilder<ICommand>> configure) where T : AutoCompleteView
    {
        PropertySettersContext<ICommand> arg = new PropertySettersContext<ICommand>(self.XamlSetters, AutoCompleteView.ReturnCommandProperty);
        configure(arg).Build();
        return self;
    }
}
