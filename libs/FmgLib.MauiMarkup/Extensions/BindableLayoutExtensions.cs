using Microsoft.Maui.Layouts;
using System.Collections;

namespace FmgLib.MauiMarkup;

public static class BindableLayoutExtensions
{
    public static T FlexAlignSelf<T>(this T view, FlexAlignSelf value) where T : View
    {
        FlexLayout.SetAlignSelf((BindableObject)view, value);
        return view;
    }

    public static T FlexBasis<T>(this T view, FlexBasis value) where T : View
    {
        FlexLayout.SetBasis((BindableObject)view, value);
        return view;
    }

    public static T FlexOrder<T>(this T view, int value) where T : View
    {
        FlexLayout.SetOrder((BindableObject)view, value);
        return view;
    }

    public static T FlexGrow<T>(this T view, float value) where T : View
    {
        FlexLayout.SetGrow((BindableObject)view, value);
        return view;
    }

    public static T FlexShrink<T>(this T view, float value) where T : View
    {
        FlexLayout.SetShrink((BindableObject)view, value);
        return view;
    }

    public static T EmptyViewTemplates<T>(this T layout, DataTemplate template) where T : BindableObject, Microsoft.Maui.ILayout
    {
        BindableLayout.SetEmptyViewTemplate(layout, template);
        return layout;
    }

    public static T ItemsSources<T>(this T layout, IEnumerable source) where T : BindableObject, Microsoft.Maui.ILayout
    {
        BindableLayout.SetItemsSource(layout, source);
        return layout;
    }

    public static T ItemsSources<T>(this T layout, Func<PropertyContext<IEnumerable>, IPropertyBuilder<IEnumerable>> configure) where T : BindableObject, Microsoft.Maui.ILayout
    {
        var context = new PropertyContext<IEnumerable>(layout, BindableLayout.ItemsSourceProperty);
        configure(context).Build();
        return layout;
    }

    public static T ItemTemplates<T>(this T layout, DataTemplate template) where T : BindableObject, Microsoft.Maui.ILayout
    {
        BindableLayout.SetItemTemplate(layout, template);
        return layout;
    }
}
