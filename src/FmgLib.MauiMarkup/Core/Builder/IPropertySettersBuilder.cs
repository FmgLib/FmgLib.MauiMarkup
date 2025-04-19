namespace FmgLib.MauiMarkup;

public interface IPropertySettersBuilder<T>
{
    PropertySettersContext<T> Context { get; set; }

    bool Build()
    {
        return false;
    }
}
