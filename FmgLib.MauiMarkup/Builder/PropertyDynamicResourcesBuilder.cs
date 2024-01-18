namespace FmgLib.MauiMarkup;

public sealed class PropertyDynamicResourcesBuilder<T> : IPropertyBuilder<T>
{
    public PropertyContext<T> Context { get; set; }

    string key = null;

    public PropertyDynamicResourcesBuilder(PropertyContext<T> context)
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

    public PropertyDynamicResourcesBuilder<T> DynamicResource(string key) { this.key = key; return this; }
}
