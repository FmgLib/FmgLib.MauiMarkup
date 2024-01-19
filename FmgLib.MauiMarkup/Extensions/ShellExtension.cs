namespace FmgLib.MauiMarkup;



public static partial class ShellExtension
{
    public static T FlyoutVerticalScrollModeFmg<T>(this T self,
        ScrollMode flyoutVerticalScrollMode)
        where T : Shell
    {
        self.SetValue(Shell.FlyoutVerticalScrollModeProperty, flyoutVerticalScrollMode);
        return self;
    }
    
    public static T FlyoutVerticalScrollModeFmg<T>(this T self, Func<PropertyContext<ScrollMode>, IPropertyBuilder<ScrollMode>> configure)
        where T : Shell
    {
        var context = new PropertyContext<ScrollMode>(self, Shell.FlyoutVerticalScrollModeProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FlyoutVerticalScrollModeFmg<T>(this SettersContext<T> self,
        ScrollMode flyoutVerticalScrollMode)
        where T : Shell
    {
        self.XamlSetters.Add(new Setter { Property = Shell.FlyoutVerticalScrollModeProperty, Value = flyoutVerticalScrollMode });
        return self;
    }
    
    public static SettersContext<T> FlyoutVerticalScrollModeFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ScrollMode>, IPropertySettersBuilder<ScrollMode>> configure)
        where T : Shell
    {
        var context = new PropertySettersContext<ScrollMode>(self.XamlSetters, Shell.FlyoutVerticalScrollModeProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FlyoutIconFmg<T>(this T self,
        ImageSource flyoutIcon)
        where T : Shell
    {
        self.SetValue(Shell.FlyoutIconProperty, flyoutIcon);
        return self;
    }
    
    public static T FlyoutIconFmg<T>(this T self, Func<PropertyContext<ImageSource>, IPropertyBuilder<ImageSource>> configure)
        where T : Shell
    {
        var context = new PropertyContext<ImageSource>(self, Shell.FlyoutIconProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FlyoutIconFmg<T>(this SettersContext<T> self,
        ImageSource flyoutIcon)
        where T : Shell
    {
        self.XamlSetters.Add(new Setter { Property = Shell.FlyoutIconProperty, Value = flyoutIcon });
        return self;
    }
    
    public static SettersContext<T> FlyoutIconFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ImageSource>, IPropertySettersBuilder<ImageSource>> configure)
        where T : Shell
    {
        var context = new PropertySettersContext<ImageSource>(self.XamlSetters, Shell.FlyoutIconProperty);
        configure(context).Build();
        return self;
    }
    
    public static T CurrentItemFmg<T>(this T self,
        ShellItem currentItem)
        where T : Shell
    {
        self.SetValue(Shell.CurrentItemProperty, currentItem);
        return self;
    }
    
    public static T CurrentItemFmg<T>(this T self, Func<PropertyContext<ShellItem>, IPropertyBuilder<ShellItem>> configure)
        where T : Shell
    {
        var context = new PropertyContext<ShellItem>(self, Shell.CurrentItemProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> CurrentItemFmg<T>(this SettersContext<T> self,
        ShellItem currentItem)
        where T : Shell
    {
        self.XamlSetters.Add(new Setter { Property = Shell.CurrentItemProperty, Value = currentItem });
        return self;
    }
    
    public static SettersContext<T> CurrentItemFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ShellItem>, IPropertySettersBuilder<ShellItem>> configure)
        where T : Shell
    {
        var context = new PropertySettersContext<ShellItem>(self.XamlSetters, Shell.CurrentItemProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FlyoutBackgroundImageFmg<T>(this T self,
        ImageSource flyoutBackgroundImage)
        where T : Shell
    {
        self.SetValue(Shell.FlyoutBackgroundImageProperty, flyoutBackgroundImage);
        return self;
    }
    
    public static T FlyoutBackgroundImageFmg<T>(this T self, Func<PropertyContext<ImageSource>, IPropertyBuilder<ImageSource>> configure)
        where T : Shell
    {
        var context = new PropertyContext<ImageSource>(self, Shell.FlyoutBackgroundImageProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FlyoutBackgroundImageFmg<T>(this SettersContext<T> self,
        ImageSource flyoutBackgroundImage)
        where T : Shell
    {
        self.XamlSetters.Add(new Setter { Property = Shell.FlyoutBackgroundImageProperty, Value = flyoutBackgroundImage });
        return self;
    }
    
    public static SettersContext<T> FlyoutBackgroundImageFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ImageSource>, IPropertySettersBuilder<ImageSource>> configure)
        where T : Shell
    {
        var context = new PropertySettersContext<ImageSource>(self.XamlSetters, Shell.FlyoutBackgroundImageProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FlyoutBackgroundImageAspectFmg<T>(this T self,
        Aspect flyoutBackgroundImageAspect)
        where T : Shell
    {
        self.SetValue(Shell.FlyoutBackgroundImageAspectProperty, flyoutBackgroundImageAspect);
        return self;
    }
    
    public static T FlyoutBackgroundImageAspectFmg<T>(this T self, Func<PropertyContext<Aspect>, IPropertyBuilder<Aspect>> configure)
        where T : Shell
    {
        var context = new PropertyContext<Aspect>(self, Shell.FlyoutBackgroundImageAspectProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FlyoutBackgroundImageAspectFmg<T>(this SettersContext<T> self,
        Aspect flyoutBackgroundImageAspect)
        where T : Shell
    {
        self.XamlSetters.Add(new Setter { Property = Shell.FlyoutBackgroundImageAspectProperty, Value = flyoutBackgroundImageAspect });
        return self;
    }
    
    public static SettersContext<T> FlyoutBackgroundImageAspectFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Aspect>, IPropertySettersBuilder<Aspect>> configure)
        where T : Shell
    {
        var context = new PropertySettersContext<Aspect>(self.XamlSetters, Shell.FlyoutBackgroundImageAspectProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FlyoutBackgroundColorFmg<T>(this T self,
        Color flyoutBackgroundColor)
        where T : Shell
    {
        self.SetValue(Shell.FlyoutBackgroundColorProperty, flyoutBackgroundColor);
        return self;
    }
    
    public static T FlyoutBackgroundColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : Shell
    {
        var context = new PropertyContext<Color>(self, Shell.FlyoutBackgroundColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FlyoutBackgroundColorFmg<T>(this SettersContext<T> self,
        Color flyoutBackgroundColor)
        where T : Shell
    {
        self.XamlSetters.Add(new Setter { Property = Shell.FlyoutBackgroundColorProperty, Value = flyoutBackgroundColor });
        return self;
    }
    
    public static SettersContext<T> FlyoutBackgroundColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : Shell
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, Shell.FlyoutBackgroundColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateFlyoutBackgroundColorToFmg<T>(this T self, Color value, uint length = 250, Easing? easing = null)
        where T : Shell
    {
        Color fromValue = self.FlyoutBackgroundColor;
        var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
        var callback = (Color actValue) => { self.FlyoutBackgroundColor = actValue; };
        return Transformations.AnimateAsync<Color>(self, "AnimateFlyoutBackgroundColorTo", transform, callback, length, easing);
    }
    
    public static T FlyoutBackgroundFmg<T>(this T self,
        Brush flyoutBackground)
        where T : Shell
    {
        self.SetValue(Shell.FlyoutBackgroundProperty, flyoutBackground);
        return self;
    }
    
    public static T FlyoutBackgroundFmg<T>(this T self, Func<PropertyContext<Brush>, IPropertyBuilder<Brush>> configure)
        where T : Shell
    {
        var context = new PropertyContext<Brush>(self, Shell.FlyoutBackgroundProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FlyoutBackgroundFmg<T>(this SettersContext<T> self,
        Brush flyoutBackground)
        where T : Shell
    {
        self.XamlSetters.Add(new Setter { Property = Shell.FlyoutBackgroundProperty, Value = flyoutBackground });
        return self;
    }
    
    public static SettersContext<T> FlyoutBackgroundFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Brush>, IPropertySettersBuilder<Brush>> configure)
        where T : Shell
    {
        var context = new PropertySettersContext<Brush>(self.XamlSetters, Shell.FlyoutBackgroundProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FlyoutBackdropFmg<T>(this T self,
        Brush flyoutBackdrop)
        where T : Shell
    {
        self.SetValue(Shell.FlyoutBackdropProperty, flyoutBackdrop);
        return self;
    }
    
    public static T FlyoutBackdropFmg<T>(this T self, Func<PropertyContext<Brush>, IPropertyBuilder<Brush>> configure)
        where T : Shell
    {
        var context = new PropertyContext<Brush>(self, Shell.FlyoutBackdropProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FlyoutBackdropFmg<T>(this SettersContext<T> self,
        Brush flyoutBackdrop)
        where T : Shell
    {
        self.XamlSetters.Add(new Setter { Property = Shell.FlyoutBackdropProperty, Value = flyoutBackdrop });
        return self;
    }
    
    public static SettersContext<T> FlyoutBackdropFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Brush>, IPropertySettersBuilder<Brush>> configure)
        where T : Shell
    {
        var context = new PropertySettersContext<Brush>(self.XamlSetters, Shell.FlyoutBackdropProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FlyoutWidthFmg<T>(this T self,
        double flyoutWidth)
        where T : Shell
    {
        self.SetValue(Shell.FlyoutWidthProperty, flyoutWidth);
        return self;
    }
    
    public static T FlyoutWidthFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Shell
    {
        var context = new PropertyContext<double>(self, Shell.FlyoutWidthProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FlyoutWidthFmg<T>(this SettersContext<T> self,
        double flyoutWidth)
        where T : Shell
    {
        self.XamlSetters.Add(new Setter { Property = Shell.FlyoutWidthProperty, Value = flyoutWidth });
        return self;
    }
    
    public static SettersContext<T> FlyoutWidthFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Shell
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Shell.FlyoutWidthProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateFlyoutWidthToFmg<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : Shell
    {
        double fromValue = self.FlyoutWidth;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.FlyoutWidth = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateFlyoutWidthTo", transform, callback, length, easing);
    }
    
    public static T FlyoutHeightFmg<T>(this T self,
        double flyoutHeight)
        where T : Shell
    {
        self.SetValue(Shell.FlyoutHeightProperty, flyoutHeight);
        return self;
    }
    
    public static T FlyoutHeightFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Shell
    {
        var context = new PropertyContext<double>(self, Shell.FlyoutHeightProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FlyoutHeightFmg<T>(this SettersContext<T> self,
        double flyoutHeight)
        where T : Shell
    {
        self.XamlSetters.Add(new Setter { Property = Shell.FlyoutHeightProperty, Value = flyoutHeight });
        return self;
    }
    
    public static SettersContext<T> FlyoutHeightFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Shell
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Shell.FlyoutHeightProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateFlyoutHeightToFmg<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : Shell
    {
        double fromValue = self.FlyoutHeight;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.FlyoutHeight = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateFlyoutHeightTo", transform, callback, length, easing);
    }
    
    public static T FlyoutBehaviorFmg<T>(this T self,
        FlyoutBehavior flyoutBehavior)
        where T : Shell
    {
        self.SetValue(Shell.FlyoutBehaviorProperty, flyoutBehavior);
        return self;
    }
    
    public static T FlyoutBehaviorFmg<T>(this T self, Func<PropertyContext<FlyoutBehavior>, IPropertyBuilder<FlyoutBehavior>> configure)
        where T : Shell
    {
        var context = new PropertyContext<FlyoutBehavior>(self, Shell.FlyoutBehaviorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FlyoutBehaviorFmg<T>(this SettersContext<T> self,
        FlyoutBehavior flyoutBehavior)
        where T : Shell
    {
        self.XamlSetters.Add(new Setter { Property = Shell.FlyoutBehaviorProperty, Value = flyoutBehavior });
        return self;
    }
    
    public static SettersContext<T> FlyoutBehaviorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<FlyoutBehavior>, IPropertySettersBuilder<FlyoutBehavior>> configure)
        where T : Shell
    {
        var context = new PropertySettersContext<FlyoutBehavior>(self.XamlSetters, Shell.FlyoutBehaviorProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FlyoutHeaderFmg<T>(this T self,
        object flyoutHeader)
        where T : Shell
    {
        self.SetValue(Shell.FlyoutHeaderProperty, flyoutHeader);
        return self;
    }
    
    public static T FlyoutHeaderFmg<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        where T : Shell
    {
        var context = new PropertyContext<object>(self, Shell.FlyoutHeaderProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FlyoutHeaderFmg<T>(this SettersContext<T> self,
        object flyoutHeader)
        where T : Shell
    {
        self.XamlSetters.Add(new Setter { Property = Shell.FlyoutHeaderProperty, Value = flyoutHeader });
        return self;
    }
    
    public static SettersContext<T> FlyoutHeaderFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        where T : Shell
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, Shell.FlyoutHeaderProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FlyoutFooterFmg<T>(this T self,
        object flyoutFooter)
        where T : Shell
    {
        self.SetValue(Shell.FlyoutFooterProperty, flyoutFooter);
        return self;
    }
    
    public static T FlyoutFooterFmg<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        where T : Shell
    {
        var context = new PropertyContext<object>(self, Shell.FlyoutFooterProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FlyoutFooterFmg<T>(this SettersContext<T> self,
        object flyoutFooter)
        where T : Shell
    {
        self.XamlSetters.Add(new Setter { Property = Shell.FlyoutFooterProperty, Value = flyoutFooter });
        return self;
    }
    
    public static SettersContext<T> FlyoutFooterFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        where T : Shell
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, Shell.FlyoutFooterProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FlyoutHeaderBehaviorFmg<T>(this T self,
        FlyoutHeaderBehavior flyoutHeaderBehavior)
        where T : Shell
    {
        self.SetValue(Shell.FlyoutHeaderBehaviorProperty, flyoutHeaderBehavior);
        return self;
    }
    
    public static T FlyoutHeaderBehaviorFmg<T>(this T self, Func<PropertyContext<FlyoutHeaderBehavior>, IPropertyBuilder<FlyoutHeaderBehavior>> configure)
        where T : Shell
    {
        var context = new PropertyContext<FlyoutHeaderBehavior>(self, Shell.FlyoutHeaderBehaviorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FlyoutHeaderBehaviorFmg<T>(this SettersContext<T> self,
        FlyoutHeaderBehavior flyoutHeaderBehavior)
        where T : Shell
    {
        self.XamlSetters.Add(new Setter { Property = Shell.FlyoutHeaderBehaviorProperty, Value = flyoutHeaderBehavior });
        return self;
    }
    
    public static SettersContext<T> FlyoutHeaderBehaviorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<FlyoutHeaderBehavior>, IPropertySettersBuilder<FlyoutHeaderBehavior>> configure)
        where T : Shell
    {
        var context = new PropertySettersContext<FlyoutHeaderBehavior>(self.XamlSetters, Shell.FlyoutHeaderBehaviorProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FlyoutHeaderTemplateFmg<T>(this T self,
        DataTemplate flyoutHeaderTemplate)
        where T : Shell
    {
        self.SetValue(Shell.FlyoutHeaderTemplateProperty, flyoutHeaderTemplate);
        return self;
    }
    
    public static T FlyoutHeaderTemplateFmg<T>(this T self, Func<PropertyContext<DataTemplate>, IPropertyBuilder<DataTemplate>> configure)
        where T : Shell
    {
        var context = new PropertyContext<DataTemplate>(self, Shell.FlyoutHeaderTemplateProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FlyoutHeaderTemplateFmg<T>(this SettersContext<T> self,
        DataTemplate flyoutHeaderTemplate)
        where T : Shell
    {
        self.XamlSetters.Add(new Setter { Property = Shell.FlyoutHeaderTemplateProperty, Value = flyoutHeaderTemplate });
        return self;
    }
    
    public static SettersContext<T> FlyoutHeaderTemplateFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<DataTemplate>, IPropertySettersBuilder<DataTemplate>> configure)
        where T : Shell
    {
        var context = new PropertySettersContext<DataTemplate>(self.XamlSetters, Shell.FlyoutHeaderTemplateProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FlyoutHeaderTemplateFmg<T>(this T self, Func<object> loadTemplate)
        where T : Shell
    {
        self.SetValue(Shell.FlyoutHeaderTemplateProperty, new DataTemplate(loadTemplate));
        return self;
    }
    
    public static T FlyoutFooterTemplateFmg<T>(this T self,
        DataTemplate flyoutFooterTemplate)
        where T : Shell
    {
        self.SetValue(Shell.FlyoutFooterTemplateProperty, flyoutFooterTemplate);
        return self;
    }
    
    public static T FlyoutFooterTemplateFmg<T>(this T self, Func<PropertyContext<DataTemplate>, IPropertyBuilder<DataTemplate>> configure)
        where T : Shell
    {
        var context = new PropertyContext<DataTemplate>(self, Shell.FlyoutFooterTemplateProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FlyoutFooterTemplateFmg<T>(this SettersContext<T> self,
        DataTemplate flyoutFooterTemplate)
        where T : Shell
    {
        self.XamlSetters.Add(new Setter { Property = Shell.FlyoutFooterTemplateProperty, Value = flyoutFooterTemplate });
        return self;
    }
    
    public static SettersContext<T> FlyoutFooterTemplateFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<DataTemplate>, IPropertySettersBuilder<DataTemplate>> configure)
        where T : Shell
    {
        var context = new PropertySettersContext<DataTemplate>(self.XamlSetters, Shell.FlyoutFooterTemplateProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FlyoutFooterTemplateFmg<T>(this T self, Func<object> loadTemplate)
        where T : Shell
    {
        self.SetValue(Shell.FlyoutFooterTemplateProperty, new DataTemplate(loadTemplate));
        return self;
    }
    
    public static T FlyoutIsPresentedFmg<T>(this T self,
        bool flyoutIsPresented)
        where T : Shell
    {
        self.SetValue(Shell.FlyoutIsPresentedProperty, flyoutIsPresented);
        return self;
    }
    
    public static T FlyoutIsPresentedFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : Shell
    {
        var context = new PropertyContext<bool>(self, Shell.FlyoutIsPresentedProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FlyoutIsPresentedFmg<T>(this SettersContext<T> self,
        bool flyoutIsPresented)
        where T : Shell
    {
        self.XamlSetters.Add(new Setter { Property = Shell.FlyoutIsPresentedProperty, Value = flyoutIsPresented });
        return self;
    }
    
    public static SettersContext<T> FlyoutIsPresentedFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : Shell
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, Shell.FlyoutIsPresentedProperty);
        configure(context).Build();
        return self;
    }
    
    public static T ItemsFmg<T>(this T self,
        IList<ShellItem> items)
        where T : Shell
    {
        foreach (var item in items)
            self.Items.Add(item);
        return self;
    }

    public static T ItemsFmg<T>(this T self,
        params ShellItem[] items)
        where T : Shell
    {
        foreach (var item in items)
            self.Items.Add(item);
        return self;
    }
    
    public static T ItemsFmg<T>(this T self, Func<PropertyContext<IList<ShellItem>>, IPropertyBuilder<IList<ShellItem>>> configure)
        where T : Shell
    {
        var context = new PropertyContext<IList<ShellItem>>(self, Shell.ItemsProperty);
        configure(context).Build();
        return self;
    }
    
    public static T ItemTemplateFmg<T>(this T self,
        DataTemplate itemTemplate)
        where T : Shell
    {
        self.SetValue(Shell.ItemTemplateProperty, itemTemplate);
        return self;
    }
    
    public static T ItemTemplateFmg<T>(this T self, Func<PropertyContext<DataTemplate>, IPropertyBuilder<DataTemplate>> configure)
        where T : Shell
    {
        var context = new PropertyContext<DataTemplate>(self, Shell.ItemTemplateProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ItemTemplateFmg<T>(this SettersContext<T> self,
        DataTemplate itemTemplate)
        where T : Shell
    {
        self.XamlSetters.Add(new Setter { Property = Shell.ItemTemplateProperty, Value = itemTemplate });
        return self;
    }
    
    public static SettersContext<T> ItemTemplateFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<DataTemplate>, IPropertySettersBuilder<DataTemplate>> configure)
        where T : Shell
    {
        var context = new PropertySettersContext<DataTemplate>(self.XamlSetters, Shell.ItemTemplateProperty);
        configure(context).Build();
        return self;
    }
    
    public static T ItemTemplateFmg<T>(this T self, Func<object> loadTemplate)
        where T : Shell
    {
        self.SetValue(Shell.ItemTemplateProperty, new DataTemplate(loadTemplate));
        return self;
    }
    
    public static T MenuItemTemplateFmg<T>(this T self,
        DataTemplate menuItemTemplate)
        where T : Shell
    {
        self.SetValue(Shell.MenuItemTemplateProperty, menuItemTemplate);
        return self;
    }
    
    public static T MenuItemTemplateFmg<T>(this T self, Func<PropertyContext<DataTemplate>, IPropertyBuilder<DataTemplate>> configure)
        where T : Shell
    {
        var context = new PropertyContext<DataTemplate>(self, Shell.MenuItemTemplateProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> MenuItemTemplateFmg<T>(this SettersContext<T> self,
        DataTemplate menuItemTemplate)
        where T : Shell
    {
        self.XamlSetters.Add(new Setter { Property = Shell.MenuItemTemplateProperty, Value = menuItemTemplate });
        return self;
    }
    
    public static SettersContext<T> MenuItemTemplateFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<DataTemplate>, IPropertySettersBuilder<DataTemplate>> configure)
        where T : Shell
    {
        var context = new PropertySettersContext<DataTemplate>(self.XamlSetters, Shell.MenuItemTemplateProperty);
        configure(context).Build();
        return self;
    }
    
    public static T MenuItemTemplateFmg<T>(this T self, Func<object> loadTemplate)
        where T : Shell
    {
        self.SetValue(Shell.MenuItemTemplateProperty, new DataTemplate(loadTemplate));
        return self;
    }
    
    public static T FlyoutContentFmg<T>(this T self,
        object flyoutContent)
        where T : Shell
    {
        self.SetValue(Shell.FlyoutContentProperty, flyoutContent);
        return self;
    }
    
    public static T FlyoutContentFmg<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        where T : Shell
    {
        var context = new PropertyContext<object>(self, Shell.FlyoutContentProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FlyoutContentFmg<T>(this SettersContext<T> self,
        object flyoutContent)
        where T : Shell
    {
        self.XamlSetters.Add(new Setter { Property = Shell.FlyoutContentProperty, Value = flyoutContent });
        return self;
    }
    
    public static SettersContext<T> FlyoutContentFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        where T : Shell
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, Shell.FlyoutContentProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FlyoutContentTemplateFmg<T>(this T self,
        DataTemplate flyoutContentTemplate)
        where T : Shell
    {
        self.SetValue(Shell.FlyoutContentTemplateProperty, flyoutContentTemplate);
        return self;
    }
    
    public static T FlyoutContentTemplateFmg<T>(this T self, Func<PropertyContext<DataTemplate>, IPropertyBuilder<DataTemplate>> configure)
        where T : Shell
    {
        var context = new PropertyContext<DataTemplate>(self, Shell.FlyoutContentTemplateProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FlyoutContentTemplateFmg<T>(this SettersContext<T> self,
        DataTemplate flyoutContentTemplate)
        where T : Shell
    {
        self.XamlSetters.Add(new Setter { Property = Shell.FlyoutContentTemplateProperty, Value = flyoutContentTemplate });
        return self;
    }
    
    public static SettersContext<T> FlyoutContentTemplateFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<DataTemplate>, IPropertySettersBuilder<DataTemplate>> configure)
        where T : Shell
    {
        var context = new PropertySettersContext<DataTemplate>(self.XamlSetters, Shell.FlyoutContentTemplateProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FlyoutContentTemplateFmg<T>(this T self, Func<object> loadTemplate)
        where T : Shell
    {
        self.SetValue(Shell.FlyoutContentTemplateProperty, new DataTemplate(loadTemplate));
        return self;
    }
    
    public static T OnNavigatedFmg<T>(this T self, EventHandler<ShellNavigatedEventArgs> handler)
        where T : Shell
    {
        self.Navigated += handler;
        return self;
    }
    
    public static T OnNavigatedFmg<T>(this T self, Action<T> action)
        where T : Shell
    {
        self.Navigated += (o, arg) => action(self);
        return self;
    }
    
    public static T OnNavigatingFmg<T>(this T self, EventHandler<ShellNavigatingEventArgs> handler)
        where T : Shell
    {
        self.Navigating += handler;
        return self;
    }
    
    public static T OnNavigatingFmg<T>(this T self, Action<T> action)
        where T : Shell
    {
        self.Navigating += (o, arg) => action(self);
        return self;
    }
    
}
