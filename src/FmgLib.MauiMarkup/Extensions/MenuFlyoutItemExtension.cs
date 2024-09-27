namespace FmgLib.MauiMarkup;

public static partial class MenuFlyoutItemExtension
{
    public static T KeyboardAccelerators<T>(this T self,
        IList<Microsoft.Maui.Controls.KeyboardAccelerator> keyboardAccelerators)
        where T : Microsoft.Maui.Controls.MenuFlyoutItem
    {
        foreach (var item in keyboardAccelerators)
            self.KeyboardAccelerators.Add(item);
        return self;
    }

    public static T KeyboardAccelerators<T>(this T self,
        params Microsoft.Maui.Controls.KeyboardAccelerator[] keyboardAccelerators)
        where T : Microsoft.Maui.Controls.MenuFlyoutItem
    {
        foreach (var item in keyboardAccelerators)
            self.KeyboardAccelerators.Add(item);
        return self;
    }

    public static T KeyboardAccelerators<T>(this T self,
        Func<Microsoft.Maui.Controls.KeyboardAccelerator[]> configure)
        where T : Microsoft.Maui.Controls.MenuFlyoutItem
    {
        var keyboardAccelerators = configure();
        foreach (var item in keyboardAccelerators)
            self.KeyboardAccelerators.Add(item);
        return self;
    }

}
