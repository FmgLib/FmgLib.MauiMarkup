namespace FmgLib.MauiMarkup;



public static partial class TriggerExtension
{
    public static Trigger Property(this Trigger self,
        BindableProperty property)
    {
        self.Property = property;
        return self;
    }
    
    public static Trigger Setters(this Trigger self,
        IList<Setter> setters)
    {
        foreach (var item in setters)
            self.Setters.Add(item);
        return self;
    }

    public static Trigger Setters(this Trigger self,
        params Setter[] setters)
    {
        foreach (var item in setters)
            self.Setters.Add(item);
        return self;
    }

    public static Trigger Setters(this Trigger self,
        Func<Setter[]> configure)
    {
        var setters = configure();
        foreach (var item in setters)
            self.Setters.Add(item);
        return self;
    }
    
    public static Trigger Value(this Trigger self,
        object value)
    {
        self.Value = value;
        return self;
    }
    
}
