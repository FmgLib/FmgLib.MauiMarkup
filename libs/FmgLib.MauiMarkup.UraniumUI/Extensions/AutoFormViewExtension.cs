using UraniumUI.Controls;

namespace FmgLib.MauiMarkup.UraniumUI;

public static partial class AutoFormViewExtension
{
    public static T SourceFmg<T>(this T self,
        object source)
        where T : AutoFormView
    {
        self.SetValue(AutoFormView.SourceProperty, source);
        return self;
    }

    public static T SourceFmg<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        where T : AutoFormView
    {
        var context = new PropertyContext<object>(self, AutoFormView.SourceProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> SourceFmg<T>(this SettersContext<T> self,
        object source)
        where T : AutoFormView
    {
        self.XamlSetters.Add(new Setter { Property = AutoFormView.SourceProperty, Value = source });
        return self;
    }

    public static SettersContext<T> SourceFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        where T : AutoFormView
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, AutoFormView.SourceProperty);
        configure(context).Build();
        return self;
    }

    public static T ShowSubmitButtonFmg<T>(this T self,
        bool showSubmitButton)
        where T : AutoFormView
    {
        self.SetValue(AutoFormView.ShowSubmitbuttonProperty, showSubmitButton);
        return self;
    }

    public static T ShowSubmitButtonFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : AutoFormView
    {
        var context = new PropertyContext<bool>(self, AutoFormView.ShowSubmitbuttonProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ShowSubmitButtonFmg<T>(this SettersContext<T> self,
        bool showSubmitButton)
        where T : AutoFormView
    {
        self.XamlSetters.Add(new Setter { Property = AutoFormView.ShowSubmitbuttonProperty, Value = showSubmitButton });
        return self;
    }

    public static SettersContext<T> ShowSubmitButtonFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : AutoFormView
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, AutoFormView.ShowSubmitbuttonProperty);
        configure(context).Build();
        return self;
    }

    public static T ShowResetButtonFmg<T>(this T self,
        bool showResetButton)
        where T : AutoFormView
    {
        self.SetValue(AutoFormView.ShowResetButtonProperty, showResetButton);
        return self;
    }

    public static T ShowResetButtonFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : AutoFormView
    {
        var context = new PropertyContext<bool>(self, AutoFormView.ShowResetButtonProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ShowResetButtonFmg<T>(this SettersContext<T> self,
        bool showResetButton)
        where T : AutoFormView
    {
        self.XamlSetters.Add(new Setter { Property = AutoFormView.ShowResetButtonProperty, Value = showResetButton });
        return self;
    }

    public static SettersContext<T> ShowResetButtonFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : AutoFormView
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, AutoFormView.ShowResetButtonProperty);
        configure(context).Build();
        return self;
    }

    public static T SubmitButtonTextFmg<T>(this T self, string text) where T : AutoFormView
    {
        self.SetValue(AutoFormView.SubmitButtonTextProperty, text);
        return self;
    }

    public static T SubmitButtonTextFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure) where T : AutoFormView
    {
        PropertyContext<string> arg = new PropertyContext<string>(self, AutoFormView.SubmitButtonTextProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> SubmitButtonTextFmg<T>(this SettersContext<T> self, string text) where T : AutoFormView
    {
        self.XamlSetters.Add(new Setter
        {
            Property = AutoFormView.SubmitButtonTextProperty,
            Value = text
        });
        return self;
    }

    public static SettersContext<T> SubmitButtonTextFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure) where T : AutoFormView
    {
        PropertySettersContext<string> arg = new PropertySettersContext<string>(self.XamlSetters, AutoFormView.SubmitButtonTextProperty);
        configure(arg).Build();
        return self;
    }

    public static T ResetButtonTextFmg<T>(this T self, string text) where T : AutoFormView
    {
        self.SetValue(AutoFormView.ResetButtonTextProperty, text);
        return self;
    }

    public static T ResetButtonTextFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure) where T : AutoFormView
    {
        PropertyContext<string> arg = new PropertyContext<string>(self, AutoFormView.ResetButtonTextProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> ResetButtonTextFmg<T>(this SettersContext<T> self, string text) where T : AutoFormView
    {
        self.XamlSetters.Add(new Setter
        {
            Property = AutoFormView.ResetButtonTextProperty,
            Value = text
        });
        return self;
    }

    public static SettersContext<T> ResetButtonTextFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure) where T : AutoFormView
    {
        PropertySettersContext<string> arg = new PropertySettersContext<string>(self.XamlSetters, AutoFormView.ResetButtonTextProperty);
        configure(arg).Build();
        return self;
    }
}
