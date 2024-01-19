using Microsoft.Maui.Layouts;
using System.Collections;

namespace FmgLib.MauiMarkup;

public static class BindableLayoutExtensions
{
    public static T FlexAlignSelfFmg<T>(this T view, FlexAlignSelf value) where T : View
    {
        FlexLayout.SetAlignSelf((BindableObject)view, value);
        return view;
    }

    public static T FlexBasisFmg<T>(this T view, FlexBasis value) where T : View
    {
        FlexLayout.SetBasis((BindableObject)view, value);
        return view;
    }

    public static T FlexOrderFmg<T>(this T view, int value) where T : View
    {
        FlexLayout.SetOrder((BindableObject)view, value);
        return view;
    }

    public static T FlexGrowFmg<T>(this T view, float value) where T : View
    {
        FlexLayout.SetGrow((BindableObject)view, value);
        return view;
    }

    public static T FlexShrinkFmg<T>(this T view, float value) where T : View
    {
        FlexLayout.SetShrink((BindableObject)view, value);
        return view;
    }

    public static T EmptyViewTemplatesFmg<T>(this T layout, DataTemplate template) where T : BindableObject, Microsoft.Maui.ILayout
    {
        BindableLayout.SetEmptyViewTemplate(layout, template);
        return layout;
    }

    public static T ItemsSourcesFmg<T>(this T layout, IEnumerable source) where T : BindableObject, Microsoft.Maui.ILayout
    {
        BindableLayout.SetItemsSource(layout, source);
        return layout;
    }

    public static T ItemTemplatesFmg<T>(this T layout, DataTemplate template) where T : BindableObject, Microsoft.Maui.ILayout
    {
        BindableLayout.SetItemTemplate(layout, template);
        return layout;
    }
}
