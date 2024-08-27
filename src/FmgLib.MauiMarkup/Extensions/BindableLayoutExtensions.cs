using Microsoft.Maui.Layouts;
using System.Collections;

namespace FmgLib.MauiMarkup;

public static class BindableLayoutExtensions
{
    public static T FlexAlignSelf<T>(this T view, FlexAlignSelf value) where T : View
    {
        FlexLayout.SetAlignSelf(view, value);
        return view;
    }

    public static T FlexBasis<T>(this T view, FlexBasis value) where T : View
    {
        FlexLayout.SetBasis(view, value);
        return view;
    }

    public static T FlexOrder<T>(this T view, int value) where T : View
    {
        FlexLayout.SetOrder(view, value);
        return view;
    }

    public static T FlexGrow<T>(this T view, float value) where T : View
    {
        FlexLayout.SetGrow(view, value);
        return view;
    }

    public static T FlexShrink<T>(this T view, float value) where T : View
    {
        FlexLayout.SetShrink(view, value);
        return view;
    }

    public static T BindableLayoutEmptyView<T>(this T layout, IEnumerable source) where T : BindableObject, Microsoft.Maui.ILayout
    {
        BindableLayout.SetEmptyView(layout, source);
        return layout;
    }

    public static T BindableLayoutEmptyView<T>(this T layout, Func<PropertyContext<IEnumerable>, IPropertyBuilder<IEnumerable>> configure) where T : BindableObject, Microsoft.Maui.ILayout
    {
        var context = new PropertyContext<IEnumerable>(layout, BindableLayout.EmptyViewProperty);
        configure(context).Build();
        return layout;
    }

    public static T BindableLayoutEmptyViewTemplate<T>(this T layout, DataTemplate template) where T : BindableObject, Microsoft.Maui.ILayout
    {
        BindableLayout.SetEmptyViewTemplate(layout, template);
        return layout;
    }

    public static T BindableLayoutItemsSource<T>(this T layout, IEnumerable source) where T : BindableObject, Microsoft.Maui.ILayout
    {
        BindableLayout.SetItemsSource(layout, source);
        return layout;
    }

    public static T BindableLayoutItemsSource<T>(this T layout, Func<PropertyContext<IEnumerable>, IPropertyBuilder<IEnumerable>> configure) where T : BindableObject, Microsoft.Maui.ILayout
    {
        var context = new PropertyContext<IEnumerable>(layout, BindableLayout.ItemsSourceProperty);
        configure(context).Build();
        return layout;
    }

    public static T BindableLayoutItemTemplate<T>(this T layout, DataTemplate template) where T : BindableObject, Microsoft.Maui.ILayout
    {
        BindableLayout.SetItemTemplate(layout, template);
        return layout;
    }

    public static T BindableItemTemplateSelector<T>(this T layout, DataTemplateSelector templateSelector) where T : BindableObject, Microsoft.Maui.ILayout
    {
        BindableLayout.SetItemTemplateSelector(layout, templateSelector);
        return layout;
    }
}
