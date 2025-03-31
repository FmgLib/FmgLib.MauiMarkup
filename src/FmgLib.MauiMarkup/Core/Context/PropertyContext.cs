namespace FmgLib.MauiMarkup;

public sealed class PropertyContext<TSource, TProperty>
{
    public BindableObject BindableObject { get; set; }

    public BindableProperty Property { get; set; }

    public PropertyContext(BindableObject bindableObject, BindableProperty property)
    {
        BindableObject = bindableObject;
        Property = property;
    }
}
