namespace FmgLib.MauiMarkup;

public sealed class PropertyContext<T>
{
    public BindableObject BindableObject { get; set; }

    public BindableProperty Property { get; set; }

    public PropertyContext(BindableObject bindableObject, BindableProperty property)
    {
        BindableObject = bindableObject;
        Property = property;
    }
}
