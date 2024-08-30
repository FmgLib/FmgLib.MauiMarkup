namespace FmgLib.MauiMarkup;

public static partial class VisualStateGroupExtension
{
    public static Microsoft.Maui.Controls.VisualStateGroup States(this Microsoft.Maui.Controls.VisualStateGroup self,
        IList<Microsoft.Maui.Controls.VisualState> states)
    {
        foreach (var item in states)
            self.States.Add(item);
        return self;
    }

    public static Microsoft.Maui.Controls.VisualStateGroup States(this Microsoft.Maui.Controls.VisualStateGroup self,
        params Microsoft.Maui.Controls.VisualState[] states)
    {
        foreach (var item in states)
            self.States.Add(item);
        return self;
    }

    public static Microsoft.Maui.Controls.VisualStateGroup States(this Microsoft.Maui.Controls.VisualStateGroup self,
        Func<Microsoft.Maui.Controls.VisualState[]> configure)
    {
        var states = configure();
        foreach (var item in states)
            self.States.Add(item);
        return self;
    }

    public static Microsoft.Maui.Controls.VisualStateGroup Name(this Microsoft.Maui.Controls.VisualStateGroup self,
        string name)
    {
        self.Name = name;
        return self;
    }

    public static Microsoft.Maui.Controls.VisualStateGroup Name(this Microsoft.Maui.Controls.VisualStateGroup self,
        Func<string> configure)
    {
        var name = configure();
        self.Name = name;
        return self;
    }

    public static Microsoft.Maui.Controls.VisualStateGroup TargetType(this Microsoft.Maui.Controls.VisualStateGroup self,
        System.Type targetType)
    {
        self.TargetType = targetType;
        return self;
    }

    public static Microsoft.Maui.Controls.VisualStateGroup TargetType(this Microsoft.Maui.Controls.VisualStateGroup self,
        Func<System.Type> configure)
    {
        var targetType = configure();
        self.TargetType = targetType;
        return self;
    }

}
