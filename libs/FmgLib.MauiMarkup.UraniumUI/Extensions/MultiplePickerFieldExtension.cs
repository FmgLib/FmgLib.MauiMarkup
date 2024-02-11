using System.Collections;
using UraniumUI.Material.Controls;

namespace FmgLib.MauiMarkup.UraniumUI;

public static partial class MultiplePickerFieldExtension
{
    public static T ItemsSourceFmg<T>(this T self,
        IList itemsSource)
        where T : MultiplePickerField
    {
        self.SetValue(MultiplePickerField.ItemsSourceProperty, itemsSource);
        return self;
    }

    public static T ItemsSourceFmg<T>(this T self, Func<PropertyContext<IList>, IPropertyBuilder<IList>> configure)
        where T : MultiplePickerField
    {
        var context = new PropertyContext<IList>(self, MultiplePickerField.ItemsSourceProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ItemsSourceFmg<T>(this SettersContext<T> self,
        IList itemsSource)
        where T : MultiplePickerField
    {
        self.XamlSetters.Add(new Setter { Property = MultiplePickerField.ItemsSourceProperty, Value = itemsSource });
        return self;
    }

    public static SettersContext<T> ItemsSourceFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<IList>, IPropertySettersBuilder<IList>> configure)
        where T : MultiplePickerField
    {
        var context = new PropertySettersContext<IList>(self.XamlSetters, MultiplePickerField.ItemsSourceProperty);
        configure(context).Build();
        return self;
    }

    public static T SelectedItemsFmg<T>(this T self,
       IList selectedItems)
       where T : MultiplePickerField
    {
        self.SetValue(MultiplePickerField.SelectedItemsProperty, selectedItems);
        return self;
    }

    public static T SelectedItemsFmg<T>(this T self, Func<PropertyContext<IList>, IPropertyBuilder<IList>> configure)
        where T : MultiplePickerField
    {
        var context = new PropertyContext<IList>(self, MultiplePickerField.SelectedItemsProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> SelectedItemsFmg<T>(this SettersContext<T> self,
        IList selectedItems)
        where T : MultiplePickerField
    {
        self.XamlSetters.Add(new Setter { Property = MultiplePickerField.SelectedItemsProperty, Value = selectedItems });
        return self;
    }

    public static SettersContext<T> SelectedItemsFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<IList>, IPropertySettersBuilder<IList>> configure)
        where T : MultiplePickerField
    {
        var context = new PropertySettersContext<IList>(self.XamlSetters, MultiplePickerField.SelectedItemsProperty);
        configure(context).Build();
        return self;
    }
}
