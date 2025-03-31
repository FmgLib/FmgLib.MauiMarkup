namespace FmgLib.MauiMarkup;

public interface IPropertyBuilder<TSource, TProperty>
{
    PropertyContext<TSource, TProperty> Context { get; set; }

    bool Build()
    {
        return false;
    }
}
