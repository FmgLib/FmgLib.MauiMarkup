namespace FmgLib.MauiMarkup;



public static partial class PropertyConditionExtension
{
    public static PropertyCondition Property(this PropertyCondition self,
        BindableProperty property)
    {
        self.Property = property;
        return self;
    }
    
    public static PropertyCondition Value(this PropertyCondition self,
        object value)
    {
        self.Value = value;
        return self;
    }
    
}
