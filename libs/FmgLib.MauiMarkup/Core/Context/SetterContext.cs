namespace FmgLib.MauiMarkup;

public class SettersContext<T> where T : BindableObject
{
    public List<Setter> XamlSetters = new List<Setter>();
}
