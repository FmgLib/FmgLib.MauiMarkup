namespace FmgLib.MauiMarkup;

public sealed class PropertySettersDynamicResourcesBuilder<TSource, TProperty> : IPropertySettersBuilder<TSource, TProperty>
{
    public PropertySettersContext<TSource, TProperty> Context { get; set; }

    string key = null;

    public PropertySettersDynamicResourcesBuilder(PropertySettersContext<TSource, TProperty> context)
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

    public PropertySettersDynamicResourcesBuilder<TSource, TProperty> DynamicResource(string key) { this.key = key; return this; }
}
