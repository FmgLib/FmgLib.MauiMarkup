namespace FmgLib.MauiMarkup;

public static partial class BindingBaseExtension
{
    public static T Mode<T>(this T self,
        BindingMode mode)
        where T : BindingBase
    {
        self.Mode = mode;
        return self;
    }
    
    public static T StringFormat<T>(this T self,
        string stringFormat)
        where T : BindingBase
    {
        self.StringFormat = stringFormat;
        return self;
    }
    
    public static T TargetNullValue<T>(this T self,
        object targetNullValue)
        where T : BindingBase
    {
        self.TargetNullValue = targetNullValue;
        return self;
    }
    
    public static T FallbackValue<T>(this T self,
        object fallbackValue)
        where T : BindingBase
    {
        self.FallbackValue = fallbackValue;
        return self;
    }
    
}