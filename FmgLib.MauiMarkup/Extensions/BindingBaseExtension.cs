namespace FmgLib.MauiMarkup;

public static partial class BindingBaseExtension
{
    public static T ModeFmg<T>(this T self,
        BindingMode mode)
        where T : BindingBase
    {
        self.Mode = mode;
        return self;
    }
    
    public static T StringFormatFmg<T>(this T self,
        string stringFormat)
        where T : BindingBase
    {
        self.StringFormat = stringFormat;
        return self;
    }
    
    public static T TargetNullValueFmg<T>(this T self,
        object targetNullValue)
        where T : BindingBase
    {
        self.TargetNullValue = targetNullValue;
        return self;
    }
    
    public static T FallbackValueFmg<T>(this T self,
        object fallbackValue)
        where T : BindingBase
    {
        self.FallbackValue = fallbackValue;
        return self;
    }
    
}