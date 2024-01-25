using CommunityToolkit.Maui.Views;

namespace FmgLib.MauiMarkup.Views;

public static partial class PopupExtension
{
    public static T ContentFmg<T>(this T self, View content) where T : Popup
    {
        self.SetValue(Popup.ContentProperty, content);
        return self;
    }

    public static T ContentFmg<T>(this T self, Func<PropertyContext<View>, IPropertyBuilder<View>> configure) where T : Popup
    {
        PropertyContext<View> arg = new PropertyContext<View>(self, Popup.ContentProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> ContentFmg<T>(this SettersContext<T> self, View content) where T : Popup
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Popup.ContentProperty,
            Value = content
        });
        return self;
    }

    public static SettersContext<T> ContentFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<View>, IPropertySettersBuilder<View>> configure) where T : Popup
    {
        PropertySettersContext<View> arg = new PropertySettersContext<View>(self.XamlSetters, Popup.ContentProperty);
        configure(arg).Build();
        return self;
    }

    public static T CanBeDismissedByTappingOutsideOfPopupFmg<T>(this T self, bool canBeDismissedByTappingOutsideOfPopup) where T : Popup
    {
        self.SetValue(Popup.CanBeDismissedByTappingOutsideOfPopupProperty, canBeDismissedByTappingOutsideOfPopup);
        return self;
    }

    public static T CanBeDismissedByTappingOutsideOfPopupFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure) where T : Popup
    {
        PropertyContext<bool> arg = new PropertyContext<bool>(self, Popup.CanBeDismissedByTappingOutsideOfPopupProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> CanBeDismissedByTappingOutsideOfPopupFmg<T>(this SettersContext<T> self, bool canBeDismissedByTappingOutsideOfPopup) where T : Popup
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Popup.CanBeDismissedByTappingOutsideOfPopupProperty,
            Value = canBeDismissedByTappingOutsideOfPopup
        });
        return self;
    }

    public static SettersContext<T> CanBeDismissedByTappingOutsideOfPopupFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure) where T : Popup
    {
        PropertySettersContext<bool> arg = new PropertySettersContext<bool>(self.XamlSetters, Popup.CanBeDismissedByTappingOutsideOfPopupProperty);
        configure(arg).Build();
        return self;
    }

    public static T ColorFmg<T>(this T self, Color color) where T : Popup
    {
        self.SetValue(Popup.ColorProperty, color);
        return self;
    }

    public static T ColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure) where T : Popup
    {
        PropertyContext<Color> arg = new PropertyContext<Color>(self, Popup.ColorProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> ColorFmg<T>(this SettersContext<T> self, Color color) where T : Popup
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Popup.ColorProperty,
            Value = color
        });
        return self;
    }

    public static SettersContext<T> ColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure) where T : Popup
    {
        PropertySettersContext<Color> arg = new PropertySettersContext<Color>(self.XamlSetters, Popup.ColorProperty);
        configure(arg).Build();
        return self;
    }

    public static T SizeFmg<T>(this T self, Size size) where T : Popup
    {
        self.SetValue(Popup.SizeProperty, size);
        return self;
    }

    public static T SizeFmg<T>(this T self, Func<PropertyContext<Size>, IPropertyBuilder<Size>> configure) where T : Popup
    {
        PropertyContext<Size> arg = new PropertyContext<Size>(self, Popup.SizeProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> SizeFmg<T>(this SettersContext<T> self, Size size) where T : Popup
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Popup.SizeProperty,
            Value = size
        });
        return self;
    }

    public static SettersContext<T> SizeFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Size>, IPropertySettersBuilder<Size>> configure) where T : Popup
    {
        PropertySettersContext<Size> arg = new PropertySettersContext<Size>(self.XamlSetters, Popup.SizeProperty);
        configure(arg).Build();
        return self;
    }

    public static T VerticalOptionsFmg<T>(this T self, Microsoft.Maui.Primitives.LayoutAlignment layoutAlignment) where T : Popup
    {
        self.SetValue(Popup.VerticalOptionsProperty, layoutAlignment);
        return self;
    }

    public static T VerticalOptionsFmg<T>(this T self, Func<PropertyContext<Microsoft.Maui.Primitives.LayoutAlignment>, IPropertyBuilder<Microsoft.Maui.Primitives.LayoutAlignment>> configure) where T : Popup
    {
        PropertyContext<Microsoft.Maui.Primitives.LayoutAlignment> arg = new PropertyContext<Microsoft.Maui.Primitives.LayoutAlignment>(self, Popup.VerticalOptionsProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> VerticalOptionsFmg<T>(this SettersContext<T> self, Microsoft.Maui.Primitives.LayoutAlignment layoutAlignment) where T : Popup
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Popup.VerticalOptionsProperty,
            Value = layoutAlignment
        });
        return self;
    }

    public static SettersContext<T> VerticalOptionsFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Primitives.LayoutAlignment>, IPropertySettersBuilder<Microsoft.Maui.Primitives.LayoutAlignment>> configure) where T : Popup
    {
        PropertySettersContext<Microsoft.Maui.Primitives.LayoutAlignment> arg = new PropertySettersContext<Microsoft.Maui.Primitives.LayoutAlignment>(self.XamlSetters, Popup.VerticalOptionsProperty);
        configure(arg).Build();
        return self;
    }

    public static T HorizontalOptionsFmg<T>(this T self, Microsoft.Maui.Primitives.LayoutAlignment layoutAlignment) where T : Popup
    {
        self.SetValue(Popup.HorizontalOptionsProperty, layoutAlignment);
        return self;
    }

    public static T HorizontalOptionsFmg<T>(this T self, Func<PropertyContext<Microsoft.Maui.Primitives.LayoutAlignment>, IPropertyBuilder<Microsoft.Maui.Primitives.LayoutAlignment>> configure) where T : Popup
    {
        PropertyContext<Microsoft.Maui.Primitives.LayoutAlignment> arg = new PropertyContext<Microsoft.Maui.Primitives.LayoutAlignment>(self, Popup.HorizontalOptionsProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> HorizontalOptionsFmg<T>(this SettersContext<T> self, Microsoft.Maui.Primitives.LayoutAlignment layoutAlignment) where T : Popup
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Popup.HorizontalOptionsProperty,
            Value = layoutAlignment
        });
        return self;
    }

    public static SettersContext<T> HorizontalOptionsFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Primitives.LayoutAlignment>, IPropertySettersBuilder<Microsoft.Maui.Primitives.LayoutAlignment>> configure) where T : Popup
    {
        PropertySettersContext<Microsoft.Maui.Primitives.LayoutAlignment> arg = new PropertySettersContext<Microsoft.Maui.Primitives.LayoutAlignment>(self.XamlSetters, Popup.HorizontalOptionsProperty);
        configure(arg).Build();
        return self;
    }
}
