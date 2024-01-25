using UraniumUI.Material.Attachments;

namespace FmgLib.MauiMarkup.UraniumUI;

public static partial class BottomSheetViewExtension
{
    public static T IsPresentedFmg<T>(this T self,
        bool isPresented)
        where T : BottomSheetView
    {
        self.SetValue(BottomSheetView.IsPresentedProperty, isPresented);
        return self;
    }

    public static T IsPresentedFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : BottomSheetView
    {
        var context = new PropertyContext<bool>(self, BottomSheetView.IsPresentedProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IsPresentedFmg<T>(this SettersContext<T> self,
        bool isPresented)
        where T : BottomSheetView
    {
        self.XamlSetters.Add(new Setter { Property = BottomSheetView.IsPresentedProperty, Value = isPresented });
        return self;
    }

    public static SettersContext<T> IsPresentedFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : BottomSheetView
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, BottomSheetView.IsPresentedProperty);
        configure(context).Build();
        return self;
    }

    public static T DisablePageWhenOpenedFmg<T>(this T self,
       bool disablePageWhenOpened)
       where T : BottomSheetView
    {
        self.SetValue(BottomSheetView.DisablePageWhenOpenedProperty, disablePageWhenOpened);
        return self;
    }

    public static T DisablePageWhenOpenedFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : BottomSheetView
    {
        var context = new PropertyContext<bool>(self, BottomSheetView.DisablePageWhenOpenedProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> DisablePageWhenOpenedFmg<T>(this SettersContext<T> self,
        bool disablePageWhenOpened)
        where T : BottomSheetView
    {
        self.XamlSetters.Add(new Setter { Property = BottomSheetView.DisablePageWhenOpenedProperty, Value = disablePageWhenOpened });
        return self;
    }

    public static SettersContext<T> DisablePageWhenOpenedFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : BottomSheetView
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, BottomSheetView.DisablePageWhenOpenedProperty);
        configure(context).Build();
        return self;
    }

    public static T CloseOnTapOutsideFmg<T>(this T self,
   bool closeOnTapOutside)
   where T : BottomSheetView
    {
        self.SetValue(BottomSheetView.CloseOnTapOutsideProperty, closeOnTapOutside);
        return self;
    }

    public static T CloseOnTapOutsideFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : BottomSheetView
    {
        var context = new PropertyContext<bool>(self, BottomSheetView.CloseOnTapOutsideProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> CloseOnTapOutsideFmg<T>(this SettersContext<T> self,
        bool closeOnTapOutside)
        where T : BottomSheetView
    {
        self.XamlSetters.Add(new Setter { Property = BottomSheetView.CloseOnTapOutsideProperty, Value = closeOnTapOutside });
        return self;
    }

    public static SettersContext<T> CloseOnTapOutsideFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : BottomSheetView
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, BottomSheetView.CloseOnTapOutsideProperty);
        configure(context).Build();
        return self;
    }
}
