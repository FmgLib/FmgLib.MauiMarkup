namespace FmgLib.MauiMarkup;

public sealed class PropertySettersDynamicResourcesBuilder<T> : IPropertySettersBuilder<T>
{
    public PropertySettersContext<T> Context { get; set; }

    string key = null;

    public PropertySettersDynamicResourcesBuilder(PropertySettersContext<T> context)
    {
        Context = context;
    }

    public bool Build()
    {
        if (!string.IsNullOrEmpty(key))
        {
            Context.XamlSetters.Add(new Setter { Property = Context.Property, Value = new Microsoft.Maui.Controls.Internals.DynamicResource(key) });
        }

        return false;
    }

    public PropertySettersDynamicResourcesBuilder<T> DynamicResource(string key) { this.key = key; return this; }
}
