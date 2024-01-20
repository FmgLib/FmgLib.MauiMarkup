namespace FmgLib.MauiMarkup;

public static partial class DataTriggerExtension
{
    public static DataTrigger BindingFmg(this DataTrigger self,
        BindingBase binding)
    {
        self.Binding = binding;
        return self;
    }
    
    public static DataTrigger SettersFmg(this DataTrigger self,
        IList<Setter> setters)
    {
        foreach (var item in setters)
            self.Setters.Add(item);
        return self;
    }

    public static DataTrigger SettersFmg(this DataTrigger self,
        params Setter[] setters)
    {
        foreach (var item in setters)
            self.Setters.Add(item);
        return self;
    }
    
    public static DataTrigger ValueFmg(this DataTrigger self,
        object value)
    {
        self.Value = value;
        return self;
    }
    
}