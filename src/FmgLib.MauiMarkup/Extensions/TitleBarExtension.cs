namespace FmgLib.MauiMarkup;

public static partial class TitleBarExtension
{
    public static T PassthroughElements<T>(this T self,
        IList<Microsoft.Maui.IView> passthroughElements)
        where T : TitleBar
    {
        foreach (var item in passthroughElements)
            self.PassthroughElements.Add(item);
        return self;
    }

    public static T PassthroughElements<T>(this T self,
        params Microsoft.Maui.IView[] passthroughElements)
        where T : TitleBar
    {
        foreach (var item in passthroughElements)
            self.PassthroughElements.Add(item);
        return self;
    }

    public static T PassthroughElements<T>(this T self,
        Func<Microsoft.Maui.IView[]> configure)
        where T : TitleBar
    {
        var passthroughElements = configure();
        foreach (var item in passthroughElements)
            self.PassthroughElements.Add(item);
        return self;
    }
    
    public static T Content<T>(this T self,
        Microsoft.Maui.IView? content)
        where T : TitleBar
    {
        self.SetValue(TitleBar.ContentProperty, content);
        return self;
    }

    public static T Content<T>(this T self,
        Func<Microsoft.Maui.IView?> configure)
        where T : TitleBar
    {
        var content = configure();
        self.SetValue(TitleBar.ContentProperty, content);
        return self;
    }
    
    public static T Content<T>(this T self, Func<PropertyContext<Microsoft.Maui.IView?>, IPropertyBuilder<Microsoft.Maui.IView?>> configure)
        where T : TitleBar
    {
        var context = new PropertyContext<Microsoft.Maui.IView?>(self, TitleBar.ContentProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Content<T>(this SettersContext<T> self,
        Microsoft.Maui.IView? content)
        where T : TitleBar
    {
        self.XamlSetters.Add(new Setter { Property = TitleBar.ContentProperty, Value = content });
        return self;
    }
    
    public static SettersContext<T> Content<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.IView?>, IPropertySettersBuilder<Microsoft.Maui.IView?>> configure)
        where T : TitleBar
    {
        var context = new PropertySettersContext<Microsoft.Maui.IView?>(self.XamlSetters, TitleBar.ContentProperty);
        configure(context).Build();
        return self;
    }
    
    public static T ForegroundColor<T>(this T self,
        Microsoft.Maui.Graphics.Color foregroundColor)
        where T : TitleBar
    {
        self.SetValue(TitleBar.ForegroundColorProperty, foregroundColor);
        return self;
    }

    public static T ForegroundColor<T>(this T self,
        Func<Microsoft.Maui.Graphics.Color> configure)
        where T : TitleBar
    {
        var foregroundColor = configure();
        self.SetValue(TitleBar.ForegroundColorProperty, foregroundColor);
        return self;
    }
    
    public static T ForegroundColor<T>(this T self, Func<PropertyContext<Microsoft.Maui.Graphics.Color>, IPropertyBuilder<Microsoft.Maui.Graphics.Color>> configure)
        where T : TitleBar
    {
        var context = new PropertyContext<Microsoft.Maui.Graphics.Color>(self, TitleBar.ForegroundColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ForegroundColor<T>(this SettersContext<T> self,
        Microsoft.Maui.Graphics.Color foregroundColor)
        where T : TitleBar
    {
        self.XamlSetters.Add(new Setter { Property = TitleBar.ForegroundColorProperty, Value = foregroundColor });
        return self;
    }
    
    public static SettersContext<T> ForegroundColor<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Graphics.Color>, IPropertySettersBuilder<Microsoft.Maui.Graphics.Color>> configure)
        where T : TitleBar
    {
        var context = new PropertySettersContext<Microsoft.Maui.Graphics.Color>(self.XamlSetters, TitleBar.ForegroundColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateForegroundColorTo<T>(this T self, Microsoft.Maui.Graphics.Color value, uint length = 250, Easing? easing = null)
        where T : TitleBar
    {
        Microsoft.Maui.Graphics.Color fromValue = self.ForegroundColor;
        var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
        var callback = (Microsoft.Maui.Graphics.Color actValue) => { self.SetValue(TitleBar.ForegroundColorProperty, actValue); };
        return Transformations.AnimateAsync<Microsoft.Maui.Graphics.Color>(self, "AnimateForegroundColorTo", transform, callback, length, easing);
    }
    
    public static T Icon<T>(this T self,
        ImageSource icon)
        where T : TitleBar
    {
        self.SetValue(TitleBar.IconProperty, icon);
        return self;
    }

    public static T Icon<T>(this T self,
        Func<ImageSource> configure)
        where T : TitleBar
    {
        var icon = configure();
        self.SetValue(TitleBar.IconProperty, icon);
        return self;
    }
    
    public static T Icon<T>(this T self, Func<PropertyContext<ImageSource>, IPropertyBuilder<ImageSource>> configure)
        where T : TitleBar
    {
        var context = new PropertyContext<ImageSource>(self, TitleBar.IconProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Icon<T>(this SettersContext<T> self,
        ImageSource icon)
        where T : TitleBar
    {
        self.XamlSetters.Add(new Setter { Property = TitleBar.IconProperty, Value = icon });
        return self;
    }
    
    public static SettersContext<T> Icon<T>(this SettersContext<T> self, Func<PropertySettersContext<ImageSource>, IPropertySettersBuilder<ImageSource>> configure)
        where T : TitleBar
    {
        var context = new PropertySettersContext<ImageSource>(self.XamlSetters, TitleBar.IconProperty);
        configure(context).Build();
        return self;
    }
    
    public static T LeadingContent<T>(this T self,
        Microsoft.Maui.IView? leadingContent)
        where T : TitleBar
    {
        self.SetValue(TitleBar.LeadingContentProperty, leadingContent);
        return self;
    }

    public static T LeadingContent<T>(this T self,
        Func<Microsoft.Maui.IView?> configure)
        where T : TitleBar
    {
        var leadingContent = configure();
        self.SetValue(TitleBar.LeadingContentProperty, leadingContent);
        return self;
    }
    
    public static T LeadingContent<T>(this T self, Func<PropertyContext<Microsoft.Maui.IView?>, IPropertyBuilder<Microsoft.Maui.IView?>> configure)
        where T : TitleBar
    {
        var context = new PropertyContext<Microsoft.Maui.IView?>(self, TitleBar.LeadingContentProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> LeadingContent<T>(this SettersContext<T> self,
        Microsoft.Maui.IView? leadingContent)
        where T : TitleBar
    {
        self.XamlSetters.Add(new Setter { Property = TitleBar.LeadingContentProperty, Value = leadingContent });
        return self;
    }
    
    public static SettersContext<T> LeadingContent<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.IView?>, IPropertySettersBuilder<Microsoft.Maui.IView?>> configure)
        where T : TitleBar
    {
        var context = new PropertySettersContext<Microsoft.Maui.IView?>(self.XamlSetters, TitleBar.LeadingContentProperty);
        configure(context).Build();
        return self;
    }
    
    public static T Subtitle<T>(this T self,
        string subtitle)
        where T : TitleBar
    {
        self.SetValue(TitleBar.SubtitleProperty, subtitle);
        return self;
    }

    public static T Subtitle<T>(this T self,
        Func<string> configure)
        where T : TitleBar
    {
        var subtitle = configure();
        self.SetValue(TitleBar.SubtitleProperty, subtitle);
        return self;
    }
    
    public static T Subtitle<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : TitleBar
    {
        var context = new PropertyContext<string>(self, TitleBar.SubtitleProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Subtitle<T>(this SettersContext<T> self,
        string subtitle)
        where T : TitleBar
    {
        self.XamlSetters.Add(new Setter { Property = TitleBar.SubtitleProperty, Value = subtitle });
        return self;
    }
    
    public static SettersContext<T> Subtitle<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : TitleBar
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, TitleBar.SubtitleProperty);
        configure(context).Build();
        return self;
    }
    
    public static T Title<T>(this T self,
        string title)
        where T : TitleBar
    {
        self.SetValue(TitleBar.TitleProperty, title);
        return self;
    }

    public static T Title<T>(this T self,
        Func<string> configure)
        where T : TitleBar
    {
        var title = configure();
        self.SetValue(TitleBar.TitleProperty, title);
        return self;
    }
    
    public static T Title<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : TitleBar
    {
        var context = new PropertyContext<string>(self, TitleBar.TitleProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Title<T>(this SettersContext<T> self,
        string title)
        where T : TitleBar
    {
        self.XamlSetters.Add(new Setter { Property = TitleBar.TitleProperty, Value = title });
        return self;
    }
    
    public static SettersContext<T> Title<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : TitleBar
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, TitleBar.TitleProperty);
        configure(context).Build();
        return self;
    }
    
    public static T TrailingContent<T>(this T self,
        Microsoft.Maui.IView? trailingContent)
        where T : TitleBar
    {
        self.SetValue(TitleBar.TrailingContentProperty, trailingContent);
        return self;
    }

    public static T TrailingContent<T>(this T self,
        Func<Microsoft.Maui.IView?> configure)
        where T : TitleBar
    {
        var trailingContent = configure();
        self.SetValue(TitleBar.TrailingContentProperty, trailingContent);
        return self;
    }
    
    public static T TrailingContent<T>(this T self, Func<PropertyContext<Microsoft.Maui.IView?>, IPropertyBuilder<Microsoft.Maui.IView?>> configure)
        where T : TitleBar
    {
        var context = new PropertyContext<Microsoft.Maui.IView?>(self, TitleBar.TrailingContentProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> TrailingContent<T>(this SettersContext<T> self,
        Microsoft.Maui.IView? trailingContent)
        where T : TitleBar
    {
        self.XamlSetters.Add(new Setter { Property = TitleBar.TrailingContentProperty, Value = trailingContent });
        return self;
    }
    
    public static SettersContext<T> TrailingContent<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.IView?>, IPropertySettersBuilder<Microsoft.Maui.IView?>> configure)
        where T : TitleBar
    {
        var context = new PropertySettersContext<Microsoft.Maui.IView?>(self.XamlSetters, TitleBar.TrailingContentProperty);
        configure(context).Build();
        return self;
    }
    
}
