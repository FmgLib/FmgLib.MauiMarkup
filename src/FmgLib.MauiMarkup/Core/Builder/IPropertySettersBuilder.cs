namespace FmgLib.MauiMarkup;

public interface IPropertySettersBuilder<TSource, TProperty>
{
    PropertySettersContext<TSource, TProperty> Context { get; set; }

    bool Build()
    {
        return false;
    }
}
