using Microsoft.Maui.Controls.Internals;

namespace FmgLib.MauiMarkup;

public sealed class PropertyDynamicResourcesBuilder<T> : IPropertyBuilder<T>
{
    private string key;

    public PropertyContext<T> Context { get; set; }

    public PropertyDynamicResourcesBuilder(PropertyContext<T> context)
    {
        Context = context;
    }

    public bool Build()
    {
        if (key != null)
        {
            IDynamicResourceHandler bindableObject = Context.BindableObject;
            if (bindableObject != null)
            {
                bindableObject.SetDynamicResource(Context.Property, key);
                return true;
            }

            throw new ArgumentException($"Property {Context.Property.PropertyName} of {Context.BindableObject.GetType().ToString()} can not use dynamic resources");
        }

        return false;
    }

    public PropertyDynamicResourcesBuilder<T> DynamicResource(string key)
    {
        this.key = key;
        return this;
    }
}
