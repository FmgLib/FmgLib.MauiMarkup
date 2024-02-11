using UraniumUI.Material.Attachments;

namespace FmgLib.MauiMarkup.UraniumUI;

public static partial class BackdropViewExtension
{
    public static T TitleFmg<T>(this T self,
        string title)
        where T : BackdropView
    {
        self.SetValue(BackdropView.TitleProperty, title);
        return self;
    }

    public static T TitleFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : BackdropView
    {
        var context = new PropertyContext<string>(self, BackdropView.TitleProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> TitleFmg<T>(this SettersContext<T> self,
        string title)
        where T : BackdropView
    {
        self.XamlSetters.Add(new Setter { Property = BackdropView.TitleProperty, Value = title });
        return self;
    }

    public static SettersContext<T> TitleFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : BackdropView
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, BackdropView.TitleProperty);
        configure(context).Build();
        return self;
    }

    public static T IconImageSourceFmg<T>(this T self,
        ImageSource iconImageSource)
        where T : BackdropView
    {
        self.SetValue(BackdropView.IconImageSourceProperty, iconImageSource);
        return self;
    }

    public static T IconImageSourceFmg<T>(this T self, Func<PropertyContext<ImageSource>, IPropertyBuilder<ImageSource>> configure)
        where T : BackdropView
    {
        var context = new PropertyContext<ImageSource>(self, BackdropView.IconImageSourceProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IconImageSourceFmg<T>(this SettersContext<T> self,
        ImageSource iconImageSource)
        where T : BackdropView
    {
        self.XamlSetters.Add(new Setter { Property = BackdropView.IconImageSourceProperty, Value = iconImageSource });
        return self;
    }

    public static SettersContext<T> IconImageSourceFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ImageSource>, IPropertySettersBuilder<ImageSource>> configure)
        where T : BackdropView
    {
        var context = new PropertySettersContext<ImageSource>(self.XamlSetters, BackdropView.IconImageSourceProperty);
        configure(context).Build();
        return self;
    }

    public static T IsPresentedFmg<T>(this T self,
        bool isPresented)
        where T : BackdropView
    {
        self.SetValue(BackdropView.IsPresentedProperty, isPresented);
        return self;
    }

    public static T IsPresentedFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : BackdropView
    {
        var context = new PropertyContext<bool>(self, BackdropView.IsPresentedProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IsPresentedFmg<T>(this SettersContext<T> self,
        bool isPresented)
        where T : BackdropView
    {
        self.XamlSetters.Add(new Setter { Property = BackdropView.IsPresentedProperty, Value = isPresented });
        return self;
    }

    public static SettersContext<T> IsPresentedFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : BackdropView
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, BackdropView.IsPresentedProperty);
        configure(context).Build();
        return self;
    }

    public static T InsertAfterToolbarIconsFmg<T>(this T self,
       bool insertAfterToolbarIcons)
       where T : BackdropView
    {
        self.SetValue(BackdropView.InsertAfterToolbarIconsProperty, insertAfterToolbarIcons);
        return self;
    }

    public static T InsertAfterToolbarIconsFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : BackdropView
    {
        var context = new PropertyContext<bool>(self, BackdropView.InsertAfterToolbarIconsProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> InsertAfterToolbarIconsFmg<T>(this SettersContext<T> self,
        bool insertAfterToolbarIcons)
        where T : BackdropView
    {
        self.XamlSetters.Add(new Setter { Property = BackdropView.InsertAfterToolbarIconsProperty, Value = insertAfterToolbarIcons });
        return self;
    }

    public static SettersContext<T> InsertAfterToolbarIconsFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : BackdropView
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, BackdropView.InsertAfterToolbarIconsProperty);
        configure(context).Build();
        return self;
    }
}
