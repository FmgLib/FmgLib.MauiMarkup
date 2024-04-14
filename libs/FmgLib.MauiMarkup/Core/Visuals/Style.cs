using System.Collections;

namespace FmgLib.MauiMarkup;

public class Style<T> : IEnumerable where T : BindableObject
{
    private static readonly BindableProperty AttachedStyleInvokeProperty = BindableProperty.CreateAttached("Style.AttachedInvokeProperty", typeof(Action<T>), typeof(Style<T>), null, BindingMode.OneWay, null, OnAttachedInvokeChanged);

    private Style mauiStyle;

    private static void OnAttachedInvokeChanged(BindableObject obj, object oldValue, object newValue)
    {
        Action<T> action = newValue as Action<T>;
        if (obj is VisualElement visualElement && visualElement.Handler != null)
        {
            action?.Invoke(obj as T);
        }
    }

    public static implicit operator Style(Style<T> style)
    {
        return style.mauiStyle;
    }

    public Style()
    {
        mauiStyle = new Style(typeof(T));
    }

    public Style(Style basedOn)
        : this()
    {
        foreach (Setter setter in basedOn.Setters)
        {
            mauiStyle.Setters.Add(setter);
        }

        foreach (TriggerBase trigger in basedOn.Triggers)
        {
            mauiStyle.Triggers.Add(trigger);
        }
    }

    public Style(bool applyToDerivedTypes)
        : this()
    {
        mauiStyle.ApplyToDerivedTypes = applyToDerivedTypes;
    }

    public Style(Func<SettersContext<T>, SettersContext<T>> buildSetters)
        : this()
    {
        BuildSetters(buildSetters);
    }

    public Style(bool applyToDerivedTypes, Func<SettersContext<T>, SettersContext<T>> buildSetters)
        : this()
    {
        mauiStyle.ApplyToDerivedTypes = applyToDerivedTypes;
        BuildSetters(buildSetters);
    }

    public Style(Style<T> basedOn, bool applyToDerivedTypes)
        : this((Style)basedOn)
    {
        mauiStyle.ApplyToDerivedTypes = applyToDerivedTypes;
    }

    public Style(Style<T> basedOn, Func<SettersContext<T>, SettersContext<T>> buildSetters)
        : this((Style)basedOn)
    {
        BuildSetters(buildSetters);
    }

    public Style(Style<T> basedOn, bool applyToDerivedTypes, Func<SettersContext<T>, SettersContext<T>> buildSetters)
        : this((Style)basedOn)
    {
        mauiStyle.ApplyToDerivedTypes = applyToDerivedTypes;
        BuildSetters(buildSetters);
    }

    private void BuildSetters(Func<SettersContext<T>, SettersContext<T>> buildSetters)
    {
        SettersContext<T> settersContext = new SettersContext<T>();
        buildSetters(settersContext);
        foreach (Setter xamlSetter in settersContext.XamlSetters)
        {
            mauiStyle.Setters.Add(xamlSetter);
        }
    }

    public void Add(Action<T> invokeOnElement)
    {
        mauiStyle.Setters.Add(new Setter
        {
            Property = AttachedStyleInvokeProperty,
            Value = invokeOnElement
        });
    }

    public void Add(Setter setter)
    {
        mauiStyle.Setters.Add(setter);
    }

    public void Add(TriggerBase trigger)
    {
        mauiStyle.Triggers.Add(trigger);
    }

    public void Add(VisualStateGroup group)
    {
        mauiStyle.GetVisualStateGroupList().Add(group);
    }

    public void Add(VisualState visualState)
    {
        mauiStyle.GetVisualStateGroupList().GetCommonStatesVisualStateGroup().States.Add(visualState);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return mauiStyle.Setters.GetEnumerator();
    }
}