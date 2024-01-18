namespace FmgLib.MauiMarkup;

public static partial class DataTriggerExtension
{
    public static DataTrigger Binding(this DataTrigger self,
        BindingBase binding)
    {
        self.Binding = binding;
        return self;
    }
    
    public static DataTrigger Setters(this DataTrigger self,
        IList<Setter> setters)
    {
        foreach (var item in setters)
            self.Setters.Add(item);
        return self;
    }

    public static DataTrigger Setters(this DataTrigger self,
        params Setter[] setters)
    {
        foreach (var item in setters)
            self.Setters.Add(item);
        return self;
    }
    
    public static DataTrigger Value(this DataTrigger self,
        object value)
    {
        self.Value = value;
        return self;
    }
    
}