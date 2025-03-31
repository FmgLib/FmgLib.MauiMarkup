namespace FmgLib.MauiMarkup;

public sealed class PropertyDynamicResourcesBuilder<TSource, TProperty> : IPropertyBuilder<TSource, TProperty>
{
    public PropertyContext<TSource, TProperty> Context { get; set; }

    string key = null;

    public PropertyDynamicResourcesBuilder(PropertyContext<TSource, TProperty> context)
    {
        Context = context;
    }

    public bool Build()
    {
        if (key != null)
        {
            if (Context.BindableObject is Microsoft.Maui.Controls.Internals.IDynamicResourceHandler resourceHandler)
            {
                resourceHandler.SetDynamicResource(Context.Property, key);
                return true;
            }
            throw new ArgumentException($"Property {Context.Property.PropertyName} of {Context.BindableObject.GetType().ToString()} can not use dynamic resources");
        }
        return false;
    }

    public PropertyDynamicResourcesBuilder<TSource, TProperty> DynamicResource(string key) { this.key = key; return this; }
}
