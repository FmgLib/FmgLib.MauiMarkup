namespace FmgLib.MauiMarkup;

public interface INameScope
{
    object FindByName(string name);
    void RegisterName(string name, object scopedElement);
    void UnregisterName(string name);
}
