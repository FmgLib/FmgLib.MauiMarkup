#nullable enable

namespace FmgLib.MauiMarkup;

public sealed class PropertyContext<T>
{
    public BindableObject BindableObject { get; }

    public BindableProperty Property { get; }

    public PropertyContext(BindableObject bindableObject, BindableProperty property)
    {
        BindableObject = bindableObject ?? throw new ArgumentNullException(nameof(bindableObject));
        Property = property ?? throw new ArgumentNullException(nameof(property));
    }
}
