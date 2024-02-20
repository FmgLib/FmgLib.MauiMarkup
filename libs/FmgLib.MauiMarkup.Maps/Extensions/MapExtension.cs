using Microsoft.Maui.Maps;
using System.Collections;
using Map = Microsoft.Maui.Controls.Maps.Map;

namespace FmgLib.MauiMarkup.Maps;

public static partial class MapExtension
{
    public static T MapTypeFmg<T>(this T self, MapType mapType) where T : Map
    {
        self.SetValue(Map.MapTypeProperty, mapType);
        return self;
    }

    public static T MapTypeFmg<T>(this T self, Func<PropertyContext<MapType>, IPropertyBuilder<MapType>> configure) where T : Map
    {
        PropertyContext<MapType> arg = new PropertyContext<MapType>(self, Map.MapTypeProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> MapTypeFmg<T>(this SettersContext<T> self, MapType mapType) where T : Map
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Map.MapTypeProperty,
            Value = mapType
        });
        return self;
    }

    public static SettersContext<T> MapTypeFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<MapType>, IPropertySettersBuilder<MapType>> configure) where T : Map
    {
        PropertySettersContext<MapType> arg = new PropertySettersContext<MapType>(self.XamlSetters, Map.MapTypeProperty);
        configure(arg).Build();
        return self;
    }

    public static T IsShowingUserFmg<T>(this T self,
        bool isShowingUser)
        where T : Map
    {
        self.SetValue(Map.IsShowingUserProperty, isShowingUser);
        return self;
    }

    public static T IsShowingUserFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : Map
    {
        var context = new PropertyContext<bool>(self, Map.IsShowingUserProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IsShowingUserFmg<T>(this SettersContext<T> self,
        bool isShowingUser)
        where T : Map
    {
        self.XamlSetters.Add(new Setter { Property = Map.IsShowingUserProperty, Value = isShowingUser });
        return self;
    }

    public static SettersContext<T> IsShowingUserFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : Map
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, Map.IsShowingUserProperty);
        configure(context).Build();
        return self;
    }

    public static T IsTrafficEnabledFmg<T>(this T self,
        bool isTrafficEnabled)
    where T : Map
    {
        self.SetValue(Map.IsTrafficEnabledProperty, isTrafficEnabled);
        return self;
    }

    public static T IsTrafficEnabledFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : Map
    {
        var context = new PropertyContext<bool>(self, Map.IsTrafficEnabledProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IsTrafficEnabledFmg<T>(this SettersContext<T> self,
        bool isTrafficEnabled)
        where T : Map
    {
        self.XamlSetters.Add(new Setter { Property = Map.IsTrafficEnabledProperty, Value = isTrafficEnabled });
        return self;
    }

    public static SettersContext<T> IsTrafficEnabledFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : Map
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, Map.IsTrafficEnabledProperty);
        configure(context).Build();
        return self;
    }

    public static T IsScrollEnabledFmg<T>(this T self,
        bool isScrollEnabled)
    where T : Map
    {
        self.SetValue(Map.IsScrollEnabledProperty, isScrollEnabled);
        return self;
    }

    public static T IsScrollEnabledFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : Map
    {
        var context = new PropertyContext<bool>(self, Map.IsScrollEnabledProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IsScrollEnabledFmg<T>(this SettersContext<T> self,
        bool isScrollEnabled)
        where T : Map
    {
        self.XamlSetters.Add(new Setter { Property = Map.IsScrollEnabledProperty, Value = isScrollEnabled });
        return self;
    }

    public static SettersContext<T> IsScrollEnabledFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : Map
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, Map.IsScrollEnabledProperty);
        configure(context).Build();
        return self;
    }

    public static T IsZoomEnabledFmg<T>(this T self,
        bool isZoomEnabled)
    where T : Map
    {
        self.SetValue(Map.IsZoomEnabledProperty, isZoomEnabled);
        return self;
    }

    public static T IsZoomEnabledFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : Map
    {
        var context = new PropertyContext<bool>(self, Map.IsZoomEnabledProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IsZoomEnabledFmg<T>(this SettersContext<T> self,
        bool isZoomEnabled)
        where T : Map
    {
        self.XamlSetters.Add(new Setter { Property = Map.IsZoomEnabledProperty, Value = isZoomEnabled });
        return self;
    }

    public static SettersContext<T> IsZoomEnabledFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : Map
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, Map.IsZoomEnabledProperty);
        configure(context).Build();
        return self;
    }

    public static T ItemsSourceFmg<T>(this T self, IEnumerable objects) where T : Map
    {
        self.SetValue(Map.ItemsSourceProperty, objects);
        return self;
    }

    public static T ItemsSourceFmg<T>(this T self, Func<PropertyContext<IEnumerable>, IPropertyBuilder<IEnumerable>> configure) where T : Map
    {
        PropertyContext<IEnumerable> arg = new PropertyContext<IEnumerable>(self, Map.ItemsSourceProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> ItemsSourceFmg<T>(this SettersContext<T> self, IEnumerable objects) where T : Map
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Map.ItemsSourceProperty,
            Value = objects
        });
        return self;
    }

    public static SettersContext<T> ItemsSourceFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<IEnumerable>, IPropertySettersBuilder<IEnumerable>> configure) where T : Map
    {
        PropertySettersContext<IEnumerable> arg = new PropertySettersContext<IEnumerable>(self.XamlSetters, Map.ItemsSourceProperty);
        configure(arg).Build();
        return self;
    }

    public static T ItemTemplateFmg<T>(this T self,
        DataTemplate dataTemplate)
        where T : Map
    {
        self.SetValue(Map.ItemTemplateProperty, dataTemplate);
        return self;
    }

    public static T ItemTemplateFmg<T>(this T self, Func<PropertyContext<DataTemplate>, IPropertyBuilder<DataTemplate>> configure)
        where T : Map
    {
        var context = new PropertyContext<DataTemplate>(self, Map.ItemTemplateProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ItemTemplateFmg<T>(this SettersContext<T> self,
        DataTemplate dataTemplate)
        where T : Map
    {
        self.XamlSetters.Add(new Setter { Property = Map.ItemTemplateProperty, Value = dataTemplate });
        return self;
    }

    public static SettersContext<T> ItemTemplateFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<DataTemplate>, IPropertySettersBuilder<DataTemplate>> configure)
        where T : Map
    {
        var context = new PropertySettersContext<DataTemplate>(self.XamlSetters, Map.ItemTemplateProperty);
        configure(context).Build();
        return self;
    }

    public static T ItemTemplateSelectorFmg<T>(this T self,
        DataTemplateSelector dataTemplateSelector)
        where T : Map
    {
        self.SetValue(Map.ItemTemplateSelectorProperty, dataTemplateSelector);
        return self;
    }

    public static T ItemTemplateSelectorFmg<T>(this T self, Func<PropertyContext<DataTemplateSelector>, IPropertyBuilder<DataTemplateSelector>> configure)
        where T : Map
    {
        var context = new PropertyContext<DataTemplateSelector>(self, Map.ItemTemplateSelectorProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ItemTemplateSelectorFmg<T>(this SettersContext<T> self,
        DataTemplateSelector dataTemplateSelector)
        where T : Map
    {
        self.XamlSetters.Add(new Setter { Property = Map.ItemTemplateSelectorProperty, Value = dataTemplateSelector });
        return self;
    }

    public static SettersContext<T> ItemTemplateSelectorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<DataTemplateSelector>, IPropertySettersBuilder<DataTemplateSelector>> configure)
        where T : Map
    {
        var context = new PropertySettersContext<DataTemplateSelector>(self.XamlSetters, Map.ItemTemplateSelectorProperty);
        configure(context).Build();
        return self;
    }
}
