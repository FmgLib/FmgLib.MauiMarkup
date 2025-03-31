namespace FmgLib.MauiMarkup;

public class SettersContext<TSource> where TSource : BindableObject
{
    public List<Setter> XamlSetters = new List<Setter>();
}
