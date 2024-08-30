namespace FmgLib.MauiMarkup;

public static partial class ElementTemplateExtension
{
    public static T LoadTemplate<T>(this T self,
        Func<object> loadTemplate)
        where T : ElementTemplate
    {
        self.LoadTemplate = loadTemplate;
        return self;
    }
    
}