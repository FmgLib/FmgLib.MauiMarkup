namespace FmgLib.MauiMarkup;



public static partial class FormattedStringExtension
{
    public static T Spans<T>(this T self,
        IList<Span> spans)
        where T : FormattedString
    {
        foreach (var item in spans)
            self.Spans.Add(item);
        return self;
    }

    public static T Spans<T>(this T self,
        params Span[] spans)
        where T : FormattedString
    {
        foreach (var item in spans)
            self.Spans.Add(item);
        return self;
    }
    
}