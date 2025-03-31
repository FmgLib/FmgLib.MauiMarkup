namespace FmgLib.MauiMarkup;

public sealed class PropertySettersContext<TSource, TProperty>
{
    public List<Setter> XamlSetters = new List<Setter>();

    public BindableProperty Property { get; set; }

    public PropertySettersContext(List<Setter> xamlSetters, BindableProperty property)
    {
        XamlSetters = xamlSetters;
        Property = property;
    }
}
