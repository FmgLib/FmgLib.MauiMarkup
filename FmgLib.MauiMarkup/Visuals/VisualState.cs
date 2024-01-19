using System.Collections;

namespace FmgLib.MauiMarkup;

public class VisualState<T> : IEnumerable where T : BindableObject
{
    private static readonly BindableProperty AttachedVisualStateInvokeProperty = BindableProperty.CreateAttached("VisualState.AttachedInvokeProperty", typeof(Action<T>), typeof(VisualState<T>), null, BindingMode.OneWay, null, OnAttachedInvokeChanged);

    private VisualState mauiVisualState;

    private static void OnAttachedInvokeChanged(BindableObject obj, object oldValue, object newValue)
    {
        Action<T> action = newValue as Action<T>;
        if (obj is VisualElement visualElement && visualElement.Handler != null)
        {
            action?.Invoke(obj as T);
        }
    }

    public static implicit operator VisualState(VisualState<T> visualState)
    {
        return visualState.mauiVisualState;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return mauiVisualState.Setters.GetEnumerator();
    }

    public void Add(Setter setter)
    {
        mauiVisualState.Setters.Add(setter);
    }

    public void Add(StateTriggerBase triggerBase)
    {
        mauiVisualState.StateTriggers.Add(triggerBase);
    }

    public void Add(Action<T> invokeOnElement)
    {
        mauiVisualState.Setters.Add(new Setter
        {
            Property = AttachedVisualStateInvokeProperty,
            Value = invokeOnElement
        });
    }

    public VisualState(string name)
    {
        mauiVisualState = new VisualState();
        mauiVisualState.Name = name;
    }

    public VisualState()
        : this(Guid.NewGuid().ToString())
    {
    }

    public VisualState(Func<SettersContext<T>, SettersContext<T>> buildSetters)
        : this()
    {
        BuildSetters(buildSetters);
    }

    public VisualState(string name, Func<SettersContext<T>, SettersContext<T>> buildSetters)
        : this(name)
    {
        BuildSetters(buildSetters);
    }

    private void BuildSetters(Func<SettersContext<T>, SettersContext<T>> buildSetters)
    {
        SettersContext<T> settersContext = new SettersContext<T>();
        buildSetters(settersContext);
        foreach (Setter xamlSetter in settersContext.XamlSetters)
        {
            mauiVisualState.Setters.Add(xamlSetter);
        }
    }
}
