﻿namespace FmgLib.MauiMarkup;

public static partial class BackButtonBehaviorExtension
{
    public static T Command<T>(this T self,
        System.Windows.Input.ICommand command)
        where T : Microsoft.Maui.Controls.BackButtonBehavior
    {
        self.SetValue(Microsoft.Maui.Controls.BackButtonBehavior.CommandProperty, command);
        return self;
    }

    public static T Command<T>(this T self,
        Func<System.Windows.Input.ICommand> configure)
        where T : Microsoft.Maui.Controls.BackButtonBehavior
    {
        var command = configure();
        self.SetValue(Microsoft.Maui.Controls.BackButtonBehavior.CommandProperty, command);
        return self;
    }

    public static T Command<T>(this T self, Func<PropertyContext<System.Windows.Input.ICommand>, IPropertyBuilder<System.Windows.Input.ICommand>> configure)
        where T : Microsoft.Maui.Controls.BackButtonBehavior
    {
        var context = new PropertyContext<System.Windows.Input.ICommand>(self, Microsoft.Maui.Controls.BackButtonBehavior.CommandProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> Command<T>(this SettersContext<T> self,
        System.Windows.Input.ICommand command)
        where T : Microsoft.Maui.Controls.BackButtonBehavior
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.BackButtonBehavior.CommandProperty, Value = command });
        return self;
    }

    public static SettersContext<T> Command<T>(this SettersContext<T> self, Func<PropertySettersContext<System.Windows.Input.ICommand>, IPropertySettersBuilder<System.Windows.Input.ICommand>> configure)
        where T : Microsoft.Maui.Controls.BackButtonBehavior
    {
        var context = new PropertySettersContext<System.Windows.Input.ICommand>(self.XamlSetters, Microsoft.Maui.Controls.BackButtonBehavior.CommandProperty);
        configure(context).Build();
        return self;
    }

    public static T CommandParameter<T>(this T self,
        object commandParameter)
        where T : Microsoft.Maui.Controls.BackButtonBehavior
    {
        self.SetValue(Microsoft.Maui.Controls.BackButtonBehavior.CommandParameterProperty, commandParameter);
        return self;
    }

    public static T CommandParameter<T>(this T self,
        Func<object> configure)
        where T : Microsoft.Maui.Controls.BackButtonBehavior
    {
        var commandParameter = configure();
        self.SetValue(Microsoft.Maui.Controls.BackButtonBehavior.CommandParameterProperty, commandParameter);
        return self;
    }

    public static T CommandParameter<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        where T : Microsoft.Maui.Controls.BackButtonBehavior
    {
        var context = new PropertyContext<object>(self, Microsoft.Maui.Controls.BackButtonBehavior.CommandParameterProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> CommandParameter<T>(this SettersContext<T> self,
        object commandParameter)
        where T : Microsoft.Maui.Controls.BackButtonBehavior
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.BackButtonBehavior.CommandParameterProperty, Value = commandParameter });
        return self;
    }

    public static SettersContext<T> CommandParameter<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        where T : Microsoft.Maui.Controls.BackButtonBehavior
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, Microsoft.Maui.Controls.BackButtonBehavior.CommandParameterProperty);
        configure(context).Build();
        return self;
    }

    public static T IconOverride<T>(this T self,
        Microsoft.Maui.Controls.ImageSource iconOverride)
        where T : Microsoft.Maui.Controls.BackButtonBehavior
    {
        self.SetValue(Microsoft.Maui.Controls.BackButtonBehavior.IconOverrideProperty, iconOverride);
        return self;
    }

    public static T IconOverride<T>(this T self,
        Func<Microsoft.Maui.Controls.ImageSource> configure)
        where T : Microsoft.Maui.Controls.BackButtonBehavior
    {
        var iconOverride = configure();
        self.SetValue(Microsoft.Maui.Controls.BackButtonBehavior.IconOverrideProperty, iconOverride);
        return self;
    }

    public static T IconOverride<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.ImageSource>, IPropertyBuilder<Microsoft.Maui.Controls.ImageSource>> configure)
        where T : Microsoft.Maui.Controls.BackButtonBehavior
    {
        var context = new PropertyContext<Microsoft.Maui.Controls.ImageSource>(self, Microsoft.Maui.Controls.BackButtonBehavior.IconOverrideProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IconOverride<T>(this SettersContext<T> self,
        Microsoft.Maui.Controls.ImageSource iconOverride)
        where T : Microsoft.Maui.Controls.BackButtonBehavior
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.BackButtonBehavior.IconOverrideProperty, Value = iconOverride });
        return self;
    }

    public static SettersContext<T> IconOverride<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Controls.ImageSource>, IPropertySettersBuilder<Microsoft.Maui.Controls.ImageSource>> configure)
        where T : Microsoft.Maui.Controls.BackButtonBehavior
    {
        var context = new PropertySettersContext<Microsoft.Maui.Controls.ImageSource>(self.XamlSetters, Microsoft.Maui.Controls.BackButtonBehavior.IconOverrideProperty);
        configure(context).Build();
        return self;
    }

    public static T IsEnabled<T>(this T self,
        bool isEnabled)
        where T : Microsoft.Maui.Controls.BackButtonBehavior
    {
        self.SetValue(Microsoft.Maui.Controls.BackButtonBehavior.IsEnabledProperty, isEnabled);
        return self;
    }

    public static T IsEnabled<T>(this T self,
        Func<bool> configure)
        where T : Microsoft.Maui.Controls.BackButtonBehavior
    {
        var isEnabled = configure();
        self.SetValue(Microsoft.Maui.Controls.BackButtonBehavior.IsEnabledProperty, isEnabled);
        return self;
    }

    public static T IsEnabled<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : Microsoft.Maui.Controls.BackButtonBehavior
    {
        var context = new PropertyContext<bool>(self, Microsoft.Maui.Controls.BackButtonBehavior.IsEnabledProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IsEnabled<T>(this SettersContext<T> self,
        bool isEnabled)
        where T : Microsoft.Maui.Controls.BackButtonBehavior
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.BackButtonBehavior.IsEnabledProperty, Value = isEnabled });
        return self;
    }

    public static SettersContext<T> IsEnabled<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : Microsoft.Maui.Controls.BackButtonBehavior
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, Microsoft.Maui.Controls.BackButtonBehavior.IsEnabledProperty);
        configure(context).Build();
        return self;
    }

    public static T IsVisible<T>(this T self,
        bool isVisible)
        where T : Microsoft.Maui.Controls.BackButtonBehavior
    {
        self.SetValue(Microsoft.Maui.Controls.BackButtonBehavior.IsVisibleProperty, isVisible);
        return self;
    }

    public static T IsVisible<T>(this T self,
        Func<bool> configure)
        where T : Microsoft.Maui.Controls.BackButtonBehavior
    {
        var isVisible = configure();
        self.SetValue(Microsoft.Maui.Controls.BackButtonBehavior.IsVisibleProperty, isVisible);
        return self;
    }

    public static T IsVisible<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : Microsoft.Maui.Controls.BackButtonBehavior
    {
        var context = new PropertyContext<bool>(self, Microsoft.Maui.Controls.BackButtonBehavior.IsVisibleProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IsVisible<T>(this SettersContext<T> self,
        bool isVisible)
        where T : Microsoft.Maui.Controls.BackButtonBehavior
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.BackButtonBehavior.IsVisibleProperty, Value = isVisible });
        return self;
    }

    public static SettersContext<T> IsVisible<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : Microsoft.Maui.Controls.BackButtonBehavior
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, Microsoft.Maui.Controls.BackButtonBehavior.IsVisibleProperty);
        configure(context).Build();
        return self;
    }

    public static T TextOverride<T>(this T self,
        string textOverride)
        where T : Microsoft.Maui.Controls.BackButtonBehavior
    {
        self.SetValue(Microsoft.Maui.Controls.BackButtonBehavior.TextOverrideProperty, textOverride);
        return self;
    }

    public static T TextOverride<T>(this T self,
        Func<string> configure)
        where T : Microsoft.Maui.Controls.BackButtonBehavior
    {
        var textOverride = configure();
        self.SetValue(Microsoft.Maui.Controls.BackButtonBehavior.TextOverrideProperty, textOverride);
        return self;
    }

    public static T TextOverride<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : Microsoft.Maui.Controls.BackButtonBehavior
    {
        var context = new PropertyContext<string>(self, Microsoft.Maui.Controls.BackButtonBehavior.TextOverrideProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> TextOverride<T>(this SettersContext<T> self,
        string textOverride)
        where T : Microsoft.Maui.Controls.BackButtonBehavior
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.BackButtonBehavior.TextOverrideProperty, Value = textOverride });
        return self;
    }

    public static SettersContext<T> TextOverride<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : Microsoft.Maui.Controls.BackButtonBehavior
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, Microsoft.Maui.Controls.BackButtonBehavior.TextOverrideProperty);
        configure(context).Build();
        return self;
    }

}