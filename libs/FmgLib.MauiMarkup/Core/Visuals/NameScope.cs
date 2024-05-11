﻿namespace FmgLib.MauiMarkup;

public class NameScope : INameScope
{
    public static readonly BindableProperty NameScopeProperty =
        BindableProperty.CreateAttached("NameScope", typeof(INameScope), typeof(NameScope), default(INameScope));

    readonly Dictionary<string, object> _names = new(StringComparer.Ordinal);
    readonly Dictionary<object, string> _values = new Dictionary<object, string>();

    object INameScope.FindByName(string name)
        => _names.TryGetValue(name, out var element) ? element : null;

    void INameScope.RegisterName(string name, object scopedElement)
    {
        if (_names.ContainsKey(name))
            throw new ArgumentException($"An element with the key '{name}' already exists in NameScope", nameof(name));

        _names[name] = scopedElement;
        _values[scopedElement] = name;
    }

    internal string NameOf(object scopedObject)
        => _values.TryGetValue(scopedObject, out var name) ? name : null;


    public static INameScope GetNameScope(BindableObject bindable) => (INameScope)bindable.GetValue(NameScopeProperty);

    public static void SetNameScope(BindableObject bindable, INameScope value)
    {
        if (bindable.GetValue(NameScopeProperty) == null)
            bindable.SetValue(NameScopeProperty, value);
    }

    void INameScope.UnregisterName(string name)
    {
        if (name == null)
            throw new ArgumentNullException(nameof(name));

        if (name == "")
            throw new ArgumentException("name was provided as empty string.", nameof(name));

        if (!_names.ContainsKey(name))
            throw new ArgumentException("name provided had not been registered.", nameof(name));

        _values.Remove(_names[name]);
        _names.Remove(name);
    }
}
