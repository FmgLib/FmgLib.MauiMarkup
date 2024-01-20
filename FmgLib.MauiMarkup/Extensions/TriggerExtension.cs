namespace FmgLib.MauiMarkup;



public static partial class TriggerExtension
{
    public static Trigger PropertyFmg(this Trigger self,
        BindableProperty property)
    {
        self.Property = property;
        return self;
    }
    
    public static Trigger SettersFmg(this Trigger self,
        IList<Setter> setters)
    {
        foreach (var item in setters)
            self.Setters.Add(item);
        return self;
    }

    public static Trigger SettersFmg(this Trigger self,
        params Setter[] setters)
    {
        foreach (var item in setters)
            self.Setters.Add(item);
        return self;
    }
    
    public static Trigger ValueFmg(this Trigger self,
        object value)
    {
        self.Value = value;
        return self;
    }
    
}
