﻿namespace FmgLib.MauiMarkup;


public static partial class CarouselViewExtension
{
    public static T LoopFmg<T>(this T self,
        bool loop)
        where T : CarouselView
    {
        self.SetValue(CarouselView.LoopProperty, loop);
        return self;
    }
    
    public static T LoopFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : CarouselView
    {
        var context = new PropertyContext<bool>(self, CarouselView.LoopProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> LoopFmg<T>(this SettersContext<T> self,
        bool loop)
        where T : CarouselView
    {
        self.XamlSetters.Add(new Setter { Property = CarouselView.LoopProperty, Value = loop });
        return self;
    }
    
    public static SettersContext<T> LoopFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : CarouselView
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, CarouselView.LoopProperty);
        configure(context).Build();
        return self;
    }
    
    public static T PeekAreaInsetsFmg<T>(this T self,
        Thickness peekAreaInsets)
        where T : CarouselView
    {
        self.SetValue(CarouselView.PeekAreaInsetsProperty, peekAreaInsets);
        return self;
    }
    
    public static T PeekAreaInsetsFmg<T>(this T self, Func<PropertyContext<Thickness>, IPropertyBuilder<Thickness>> configure)
        where T : CarouselView
    {
        var context = new PropertyContext<Thickness>(self, CarouselView.PeekAreaInsetsProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> PeekAreaInsetsFmg<T>(this SettersContext<T> self,
        Thickness peekAreaInsets)
        where T : CarouselView
    {
        self.XamlSetters.Add(new Setter { Property = CarouselView.PeekAreaInsetsProperty, Value = peekAreaInsets });
        return self;
    }
    
    public static SettersContext<T> PeekAreaInsetsFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Thickness>, IPropertySettersBuilder<Thickness>> configure)
        where T : CarouselView
    {
        var context = new PropertySettersContext<Thickness>(self.XamlSetters, CarouselView.PeekAreaInsetsProperty);
        configure(context).Build();
        return self;
    }
    
    public static T VisibleViewsFmg<T>(this T self,
        IList<View> visibleViews)
        where T : CarouselView
    {
        foreach (var item in visibleViews)
            self.VisibleViews.Add(item);
        return self;
    }

    public static T VisibleViewsFmg<T>(this T self,
        params View[] visibleViews)
        where T : CarouselView
    {
        foreach (var item in visibleViews)
            self.VisibleViews.Add(item);
        return self;
    }
    
    public static T VisibleViewsFmg<T>(this T self, Func<PropertyContext<System.Collections.ObjectModel.ObservableCollection<View>>, IPropertyBuilder<System.Collections.ObjectModel.ObservableCollection<View>>> configure)
        where T : CarouselView
    {
        var context = new PropertyContext<System.Collections.ObjectModel.ObservableCollection<View>>(self, CarouselView.VisibleViewsProperty);
        configure(context).Build();
        return self;
    }
    
    public static T IsBounceEnabledFmg<T>(this T self,
        bool isBounceEnabled)
        where T : CarouselView
    {
        self.SetValue(CarouselView.IsBounceEnabledProperty, isBounceEnabled);
        return self;
    }
    
    public static T IsBounceEnabledFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : CarouselView
    {
        var context = new PropertyContext<bool>(self, CarouselView.IsBounceEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> IsBounceEnabledFmg<T>(this SettersContext<T> self,
        bool isBounceEnabled)
        where T : CarouselView
    {
        self.XamlSetters.Add(new Setter { Property = CarouselView.IsBounceEnabledProperty, Value = isBounceEnabled });
        return self;
    }
    
    public static SettersContext<T> IsBounceEnabledFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : CarouselView
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, CarouselView.IsBounceEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static T IsSwipeEnabledFmg<T>(this T self,
        bool isSwipeEnabled)
        where T : CarouselView
    {
        self.SetValue(CarouselView.IsSwipeEnabledProperty, isSwipeEnabled);
        return self;
    }
    
    public static T IsSwipeEnabledFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : CarouselView
    {
        var context = new PropertyContext<bool>(self, CarouselView.IsSwipeEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> IsSwipeEnabledFmg<T>(this SettersContext<T> self,
        bool isSwipeEnabled)
        where T : CarouselView
    {
        self.XamlSetters.Add(new Setter { Property = CarouselView.IsSwipeEnabledProperty, Value = isSwipeEnabled });
        return self;
    }
    
    public static SettersContext<T> IsSwipeEnabledFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : CarouselView
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, CarouselView.IsSwipeEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static T IsScrollAnimatedFmg<T>(this T self,
        bool isScrollAnimated)
        where T : CarouselView
    {
        self.SetValue(CarouselView.IsScrollAnimatedProperty, isScrollAnimated);
        return self;
    }
    
    public static T IsScrollAnimatedFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : CarouselView
    {
        var context = new PropertyContext<bool>(self, CarouselView.IsScrollAnimatedProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> IsScrollAnimatedFmg<T>(this SettersContext<T> self,
        bool isScrollAnimated)
        where T : CarouselView
    {
        self.XamlSetters.Add(new Setter { Property = CarouselView.IsScrollAnimatedProperty, Value = isScrollAnimated });
        return self;
    }
    
    public static SettersContext<T> IsScrollAnimatedFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : CarouselView
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, CarouselView.IsScrollAnimatedProperty);
        configure(context).Build();
        return self;
    }
    
    public static T CurrentItemFmg<T>(this T self,
        object currentItem)
        where T : CarouselView
    {
        self.SetValue(CarouselView.CurrentItemProperty, currentItem);
        return self;
    }
    
    public static T CurrentItemFmg<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        where T : CarouselView
    {
        var context = new PropertyContext<object>(self, CarouselView.CurrentItemProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> CurrentItemFmg<T>(this SettersContext<T> self,
        object currentItem)
        where T : CarouselView
    {
        self.XamlSetters.Add(new Setter { Property = CarouselView.CurrentItemProperty, Value = currentItem });
        return self;
    }
    
    public static SettersContext<T> CurrentItemFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        where T : CarouselView
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, CarouselView.CurrentItemProperty);
        configure(context).Build();
        return self;
    }
    
    public static T CurrentItemChangedCommandFmg<T>(this T self,
        System.Windows.Input.ICommand currentItemChangedCommand)
        where T : CarouselView
    {
        self.SetValue(CarouselView.CurrentItemChangedCommandProperty, currentItemChangedCommand);
        return self;
    }
    
    public static T CurrentItemChangedCommandFmg<T>(this T self, Func<PropertyContext<System.Windows.Input.ICommand>, IPropertyBuilder<System.Windows.Input.ICommand>> configure)
        where T : CarouselView
    {
        var context = new PropertyContext<System.Windows.Input.ICommand>(self, CarouselView.CurrentItemChangedCommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> CurrentItemChangedCommandFmg<T>(this SettersContext<T> self,
        System.Windows.Input.ICommand currentItemChangedCommand)
        where T : CarouselView
    {
        self.XamlSetters.Add(new Setter { Property = CarouselView.CurrentItemChangedCommandProperty, Value = currentItemChangedCommand });
        return self;
    }
    
    public static SettersContext<T> CurrentItemChangedCommandFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<System.Windows.Input.ICommand>, IPropertySettersBuilder<System.Windows.Input.ICommand>> configure)
        where T : CarouselView
    {
        var context = new PropertySettersContext<System.Windows.Input.ICommand>(self.XamlSetters, CarouselView.CurrentItemChangedCommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static T CurrentItemChangedCommandParameterFmg<T>(this T self,
        object currentItemChangedCommandParameter)
        where T : CarouselView
    {
        self.SetValue(CarouselView.CurrentItemChangedCommandParameterProperty, currentItemChangedCommandParameter);
        return self;
    }
    
    public static T CurrentItemChangedCommandParameterFmg<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        where T : CarouselView
    {
        var context = new PropertyContext<object>(self, CarouselView.CurrentItemChangedCommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> CurrentItemChangedCommandParameterFmg<T>(this SettersContext<T> self,
        object currentItemChangedCommandParameter)
        where T : CarouselView
    {
        self.XamlSetters.Add(new Setter { Property = CarouselView.CurrentItemChangedCommandParameterProperty, Value = currentItemChangedCommandParameter });
        return self;
    }
    
    public static SettersContext<T> CurrentItemChangedCommandParameterFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        where T : CarouselView
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, CarouselView.CurrentItemChangedCommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static T PositionFmg<T>(this T self,
        int position)
        where T : CarouselView
    {
        self.SetValue(CarouselView.PositionProperty, position);
        return self;
    }
    
    public static T PositionFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
        where T : CarouselView
    {
        var context = new PropertyContext<int>(self, CarouselView.PositionProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> PositionFmg<T>(this SettersContext<T> self,
        int position)
        where T : CarouselView
    {
        self.XamlSetters.Add(new Setter { Property = CarouselView.PositionProperty, Value = position });
        return self;
    }
    
    public static SettersContext<T> PositionFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure)
        where T : CarouselView
    {
        var context = new PropertySettersContext<int>(self.XamlSetters, CarouselView.PositionProperty);
        configure(context).Build();
        return self;
    }
    
    public static T PositionChangedCommandFmg<T>(this T self,
        System.Windows.Input.ICommand positionChangedCommand)
        where T : CarouselView
    {
        self.SetValue(CarouselView.PositionChangedCommandProperty, positionChangedCommand);
        return self;
    }
    
    public static T PositionChangedCommandFmg<T>(this T self, Func<PropertyContext<System.Windows.Input.ICommand>, IPropertyBuilder<System.Windows.Input.ICommand>> configure)
        where T : CarouselView
    {
        var context = new PropertyContext<System.Windows.Input.ICommand>(self, CarouselView.PositionChangedCommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> PositionChangedCommandFmg<T>(this SettersContext<T> self,
        System.Windows.Input.ICommand positionChangedCommand)
        where T : CarouselView
    {
        self.XamlSetters.Add(new Setter { Property = CarouselView.PositionChangedCommandProperty, Value = positionChangedCommand });
        return self;
    }
    
    public static SettersContext<T> PositionChangedCommandFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<System.Windows.Input.ICommand>, IPropertySettersBuilder<System.Windows.Input.ICommand>> configure)
        where T : CarouselView
    {
        var context = new PropertySettersContext<System.Windows.Input.ICommand>(self.XamlSetters, CarouselView.PositionChangedCommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static T PositionChangedCommandParameterFmg<T>(this T self,
        object positionChangedCommandParameter)
        where T : CarouselView
    {
        self.SetValue(CarouselView.PositionChangedCommandParameterProperty, positionChangedCommandParameter);
        return self;
    }
    
    public static T PositionChangedCommandParameterFmg<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        where T : CarouselView
    {
        var context = new PropertyContext<object>(self, CarouselView.PositionChangedCommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> PositionChangedCommandParameterFmg<T>(this SettersContext<T> self,
        object positionChangedCommandParameter)
        where T : CarouselView
    {
        self.XamlSetters.Add(new Setter { Property = CarouselView.PositionChangedCommandParameterProperty, Value = positionChangedCommandParameter });
        return self;
    }
    
    public static SettersContext<T> PositionChangedCommandParameterFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        where T : CarouselView
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, CarouselView.PositionChangedCommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static T ItemsLayoutFmg<T>(this T self,
        LinearItemsLayout itemsLayout)
        where T : CarouselView
    {
        self.SetValue(CarouselView.ItemsLayoutProperty, itemsLayout);
        return self;
    }
    
    public static T ItemsLayoutFmg<T>(this T self, Func<PropertyContext<LinearItemsLayout>, IPropertyBuilder<LinearItemsLayout>> configure)
        where T : CarouselView
    {
        var context = new PropertyContext<LinearItemsLayout>(self, CarouselView.ItemsLayoutProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ItemsLayoutFmg<T>(this SettersContext<T> self,
        LinearItemsLayout itemsLayout)
        where T : CarouselView
    {
        self.XamlSetters.Add(new Setter { Property = CarouselView.ItemsLayoutProperty, Value = itemsLayout });
        return self;
    }
    
    public static SettersContext<T> ItemsLayoutFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<LinearItemsLayout>, IPropertySettersBuilder<LinearItemsLayout>> configure)
        where T : CarouselView
    {
        var context = new PropertySettersContext<LinearItemsLayout>(self.XamlSetters, CarouselView.ItemsLayoutProperty);
        configure(context).Build();
        return self;
    }
    
    public static T IndicatorViewFmg<T>(this T self,
        IndicatorView indicatorView)
        where T : CarouselView
    {
        self.IndicatorView = indicatorView;
        return self;
    }
    
    public static T IsScrollingFmg<T>(this T self,
        bool isScrolling)
        where T : CarouselView
    {
        self.IsScrolling = isScrolling;
        return self;
    }
    
    public static T OnCurrentItemChangedFmg<T>(this T self, EventHandler<CurrentItemChangedEventArgs> handler)
        where T : CarouselView
    {
        self.CurrentItemChanged += handler;
        return self;
    }
    
    public static T OnCurrentItemChangedFmg<T>(this T self, Action<T> action)
        where T : CarouselView
    {
        self.CurrentItemChanged += (o, arg) => action(self);
        return self;
    }
    
    public static T OnPositionChangedFmg<T>(this T self, EventHandler<PositionChangedEventArgs> handler)
        where T : CarouselView
    {
        self.PositionChanged += handler;
        return self;
    }
    
    public static T OnPositionChangedFmg<T>(this T self, Action<T> action)
        where T : CarouselView
    {
        self.PositionChanged += (o, arg) => action(self);
        return self;
    }
    
}