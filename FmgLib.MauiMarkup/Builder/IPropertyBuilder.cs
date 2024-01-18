namespace FmgLib.MauiMarkup;

public interface IPropertyBuilder<T>
{
    PropertyContext<T> Context { get; set; }

    bool Build()
    {
        return false;
    }
}
