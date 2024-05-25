﻿namespace FmgLib.MauiMarkup;


public static partial class CarouselViewExtension
{
    public static T CurrentItem<T>(this T self,
        object currentItem)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        self.SetValue(Microsoft.Maui.Controls.CarouselView.CurrentItemProperty, currentItem);
        return self;
    }

    public static T CurrentItem<T>(this T self,
        Func<object> configure)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        var currentItem = configure();
        self.SetValue(Microsoft.Maui.Controls.CarouselView.CurrentItemProperty, currentItem);
        return self;
    }

    public static T CurrentItem<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        var context = new PropertyContext<object>(self, Microsoft.Maui.Controls.CarouselView.CurrentItemProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> CurrentItem<T>(this SettersContext<T> self,
        object currentItem)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.CarouselView.CurrentItemProperty, Value = currentItem });
        return self;
    }

    public static SettersContext<T> CurrentItem<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, Microsoft.Maui.Controls.CarouselView.CurrentItemProperty);
        configure(context).Build();
        return self;
    }

    public static T CurrentItemChangedCommand<T>(this T self,
        System.Windows.Input.ICommand currentItemChangedCommand)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        self.SetValue(Microsoft.Maui.Controls.CarouselView.CurrentItemChangedCommandProperty, currentItemChangedCommand);
        return self;
    }

    public static T CurrentItemChangedCommand<T>(this T self,
        Func<System.Windows.Input.ICommand> configure)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        var currentItemChangedCommand = configure();
        self.SetValue(Microsoft.Maui.Controls.CarouselView.CurrentItemChangedCommandProperty, currentItemChangedCommand);
        return self;
    }

    public static T CurrentItemChangedCommand<T>(this T self, Func<PropertyContext<System.Windows.Input.ICommand>, IPropertyBuilder<System.Windows.Input.ICommand>> configure)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        var context = new PropertyContext<System.Windows.Input.ICommand>(self, Microsoft.Maui.Controls.CarouselView.CurrentItemChangedCommandProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> CurrentItemChangedCommand<T>(this SettersContext<T> self,
        System.Windows.Input.ICommand currentItemChangedCommand)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.CarouselView.CurrentItemChangedCommandProperty, Value = currentItemChangedCommand });
        return self;
    }

    public static SettersContext<T> CurrentItemChangedCommand<T>(this SettersContext<T> self, Func<PropertySettersContext<System.Windows.Input.ICommand>, IPropertySettersBuilder<System.Windows.Input.ICommand>> configure)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        var context = new PropertySettersContext<System.Windows.Input.ICommand>(self.XamlSetters, Microsoft.Maui.Controls.CarouselView.CurrentItemChangedCommandProperty);
        configure(context).Build();
        return self;
    }

    public static T CurrentItemChangedCommandParameter<T>(this T self,
        object currentItemChangedCommandParameter)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        self.SetValue(Microsoft.Maui.Controls.CarouselView.CurrentItemChangedCommandParameterProperty, currentItemChangedCommandParameter);
        return self;
    }

    public static T CurrentItemChangedCommandParameter<T>(this T self,
        Func<object> configure)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        var currentItemChangedCommandParameter = configure();
        self.SetValue(Microsoft.Maui.Controls.CarouselView.CurrentItemChangedCommandParameterProperty, currentItemChangedCommandParameter);
        return self;
    }

    public static T CurrentItemChangedCommandParameter<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        var context = new PropertyContext<object>(self, Microsoft.Maui.Controls.CarouselView.CurrentItemChangedCommandParameterProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> CurrentItemChangedCommandParameter<T>(this SettersContext<T> self,
        object currentItemChangedCommandParameter)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.CarouselView.CurrentItemChangedCommandParameterProperty, Value = currentItemChangedCommandParameter });
        return self;
    }

    public static SettersContext<T> CurrentItemChangedCommandParameter<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, Microsoft.Maui.Controls.CarouselView.CurrentItemChangedCommandParameterProperty);
        configure(context).Build();
        return self;
    }

    public static T IsBounceEnabled<T>(this T self,
        bool isBounceEnabled)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        self.SetValue(Microsoft.Maui.Controls.CarouselView.IsBounceEnabledProperty, isBounceEnabled);
        return self;
    }

    public static T IsBounceEnabled<T>(this T self,
        Func<bool> configure)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        var isBounceEnabled = configure();
        self.SetValue(Microsoft.Maui.Controls.CarouselView.IsBounceEnabledProperty, isBounceEnabled);
        return self;
    }

    public static T IsBounceEnabled<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        var context = new PropertyContext<bool>(self, Microsoft.Maui.Controls.CarouselView.IsBounceEnabledProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IsBounceEnabled<T>(this SettersContext<T> self,
        bool isBounceEnabled)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.CarouselView.IsBounceEnabledProperty, Value = isBounceEnabled });
        return self;
    }

    public static SettersContext<T> IsBounceEnabled<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, Microsoft.Maui.Controls.CarouselView.IsBounceEnabledProperty);
        configure(context).Build();
        return self;
    }

    public static T IsDragging<T>(this T self,
        bool isDragging)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        self.SetValue(Microsoft.Maui.Controls.CarouselView.IsDraggingProperty, isDragging);
        return self;
    }

    public static T IsDragging<T>(this T self,
        Func<bool> configure)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        var isDragging = configure();
        self.SetValue(Microsoft.Maui.Controls.CarouselView.IsDraggingProperty, isDragging);
        return self;
    }

    public static T IsDragging<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        var context = new PropertyContext<bool>(self, Microsoft.Maui.Controls.CarouselView.IsDraggingProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IsDragging<T>(this SettersContext<T> self,
        bool isDragging)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.CarouselView.IsDraggingProperty, Value = isDragging });
        return self;
    }

    public static SettersContext<T> IsDragging<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, Microsoft.Maui.Controls.CarouselView.IsDraggingProperty);
        configure(context).Build();
        return self;
    }

    public static T IsScrollAnimated<T>(this T self,
        bool isScrollAnimated)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        self.SetValue(Microsoft.Maui.Controls.CarouselView.IsScrollAnimatedProperty, isScrollAnimated);
        return self;
    }

    public static T IsScrollAnimated<T>(this T self,
        Func<bool> configure)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        var isScrollAnimated = configure();
        self.SetValue(Microsoft.Maui.Controls.CarouselView.IsScrollAnimatedProperty, isScrollAnimated);
        return self;
    }

    public static T IsScrollAnimated<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        var context = new PropertyContext<bool>(self, Microsoft.Maui.Controls.CarouselView.IsScrollAnimatedProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IsScrollAnimated<T>(this SettersContext<T> self,
        bool isScrollAnimated)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.CarouselView.IsScrollAnimatedProperty, Value = isScrollAnimated });
        return self;
    }

    public static SettersContext<T> IsScrollAnimated<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, Microsoft.Maui.Controls.CarouselView.IsScrollAnimatedProperty);
        configure(context).Build();
        return self;
    }

    public static T IsSwipeEnabled<T>(this T self,
        bool isSwipeEnabled)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        self.SetValue(Microsoft.Maui.Controls.CarouselView.IsSwipeEnabledProperty, isSwipeEnabled);
        return self;
    }

    public static T IsSwipeEnabled<T>(this T self,
        Func<bool> configure)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        var isSwipeEnabled = configure();
        self.SetValue(Microsoft.Maui.Controls.CarouselView.IsSwipeEnabledProperty, isSwipeEnabled);
        return self;
    }

    public static T IsSwipeEnabled<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        var context = new PropertyContext<bool>(self, Microsoft.Maui.Controls.CarouselView.IsSwipeEnabledProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IsSwipeEnabled<T>(this SettersContext<T> self,
        bool isSwipeEnabled)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.CarouselView.IsSwipeEnabledProperty, Value = isSwipeEnabled });
        return self;
    }

    public static SettersContext<T> IsSwipeEnabled<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, Microsoft.Maui.Controls.CarouselView.IsSwipeEnabledProperty);
        configure(context).Build();
        return self;
    }

    public static T ItemsLayout<T>(this T self,
        Microsoft.Maui.Controls.LinearItemsLayout itemsLayout)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        self.SetValue(Microsoft.Maui.Controls.CarouselView.ItemsLayoutProperty, itemsLayout);
        return self;
    }

    public static T ItemsLayout<T>(this T self,
        Func<Microsoft.Maui.Controls.LinearItemsLayout> configure)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        var itemsLayout = configure();
        self.SetValue(Microsoft.Maui.Controls.CarouselView.ItemsLayoutProperty, itemsLayout);
        return self;
    }

    public static T ItemsLayout<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.LinearItemsLayout>, IPropertyBuilder<Microsoft.Maui.Controls.LinearItemsLayout>> configure)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        var context = new PropertyContext<Microsoft.Maui.Controls.LinearItemsLayout>(self, Microsoft.Maui.Controls.CarouselView.ItemsLayoutProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ItemsLayout<T>(this SettersContext<T> self,
        Microsoft.Maui.Controls.LinearItemsLayout itemsLayout)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.CarouselView.ItemsLayoutProperty, Value = itemsLayout });
        return self;
    }

    public static SettersContext<T> ItemsLayout<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Controls.LinearItemsLayout>, IPropertySettersBuilder<Microsoft.Maui.Controls.LinearItemsLayout>> configure)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        var context = new PropertySettersContext<Microsoft.Maui.Controls.LinearItemsLayout>(self.XamlSetters, Microsoft.Maui.Controls.CarouselView.ItemsLayoutProperty);
        configure(context).Build();
        return self;
    }

    public static T Loop<T>(this T self,
        bool loop)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        self.SetValue(Microsoft.Maui.Controls.CarouselView.LoopProperty, loop);
        return self;
    }

    public static T Loop<T>(this T self,
        Func<bool> configure)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        var loop = configure();
        self.SetValue(Microsoft.Maui.Controls.CarouselView.LoopProperty, loop);
        return self;
    }

    public static T Loop<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        var context = new PropertyContext<bool>(self, Microsoft.Maui.Controls.CarouselView.LoopProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> Loop<T>(this SettersContext<T> self,
        bool loop)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.CarouselView.LoopProperty, Value = loop });
        return self;
    }

    public static SettersContext<T> Loop<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, Microsoft.Maui.Controls.CarouselView.LoopProperty);
        configure(context).Build();
        return self;
    }

    public static T PeekAreaInsets<T>(this T self,
        Microsoft.Maui.Thickness peekAreaInsets)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        self.SetValue(Microsoft.Maui.Controls.CarouselView.PeekAreaInsetsProperty, peekAreaInsets);
        return self;
    }

    public static T PeekAreaInsets<T>(this T self,
        Func<Microsoft.Maui.Thickness> configure)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        var peekAreaInsets = configure();
        self.SetValue(Microsoft.Maui.Controls.CarouselView.PeekAreaInsetsProperty, peekAreaInsets);
        return self;
    }

    public static T PeekAreaInsets<T>(this T self, Func<PropertyContext<Microsoft.Maui.Thickness>, IPropertyBuilder<Microsoft.Maui.Thickness>> configure)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        var context = new PropertyContext<Microsoft.Maui.Thickness>(self, Microsoft.Maui.Controls.CarouselView.PeekAreaInsetsProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> PeekAreaInsets<T>(this SettersContext<T> self,
        Microsoft.Maui.Thickness peekAreaInsets)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.CarouselView.PeekAreaInsetsProperty, Value = peekAreaInsets });
        return self;
    }

    public static SettersContext<T> PeekAreaInsets<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Thickness>, IPropertySettersBuilder<Microsoft.Maui.Thickness>> configure)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        var context = new PropertySettersContext<Microsoft.Maui.Thickness>(self.XamlSetters, Microsoft.Maui.Controls.CarouselView.PeekAreaInsetsProperty);
        configure(context).Build();
        return self;
    }

    public static T Position<T>(this T self,
        int position)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        self.SetValue(Microsoft.Maui.Controls.CarouselView.PositionProperty, position);
        return self;
    }

    public static T Position<T>(this T self,
        Func<int> configure)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        var position = configure();
        self.SetValue(Microsoft.Maui.Controls.CarouselView.PositionProperty, position);
        return self;
    }

    public static T Position<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        var context = new PropertyContext<int>(self, Microsoft.Maui.Controls.CarouselView.PositionProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> Position<T>(this SettersContext<T> self,
        int position)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.CarouselView.PositionProperty, Value = position });
        return self;
    }

    public static SettersContext<T> Position<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        var context = new PropertySettersContext<int>(self.XamlSetters, Microsoft.Maui.Controls.CarouselView.PositionProperty);
        configure(context).Build();
        return self;
    }

    public static T PositionChangedCommand<T>(this T self,
        System.Windows.Input.ICommand positionChangedCommand)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        self.SetValue(Microsoft.Maui.Controls.CarouselView.PositionChangedCommandProperty, positionChangedCommand);
        return self;
    }

    public static T PositionChangedCommand<T>(this T self,
        Func<System.Windows.Input.ICommand> configure)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        var positionChangedCommand = configure();
        self.SetValue(Microsoft.Maui.Controls.CarouselView.PositionChangedCommandProperty, positionChangedCommand);
        return self;
    }

    public static T PositionChangedCommand<T>(this T self, Func<PropertyContext<System.Windows.Input.ICommand>, IPropertyBuilder<System.Windows.Input.ICommand>> configure)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        var context = new PropertyContext<System.Windows.Input.ICommand>(self, Microsoft.Maui.Controls.CarouselView.PositionChangedCommandProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> PositionChangedCommand<T>(this SettersContext<T> self,
        System.Windows.Input.ICommand positionChangedCommand)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.CarouselView.PositionChangedCommandProperty, Value = positionChangedCommand });
        return self;
    }

    public static SettersContext<T> PositionChangedCommand<T>(this SettersContext<T> self, Func<PropertySettersContext<System.Windows.Input.ICommand>, IPropertySettersBuilder<System.Windows.Input.ICommand>> configure)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        var context = new PropertySettersContext<System.Windows.Input.ICommand>(self.XamlSetters, Microsoft.Maui.Controls.CarouselView.PositionChangedCommandProperty);
        configure(context).Build();
        return self;
    }

    public static T PositionChangedCommandParameter<T>(this T self,
        object positionChangedCommandParameter)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        self.SetValue(Microsoft.Maui.Controls.CarouselView.PositionChangedCommandParameterProperty, positionChangedCommandParameter);
        return self;
    }

    public static T PositionChangedCommandParameter<T>(this T self,
        Func<object> configure)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        var positionChangedCommandParameter = configure();
        self.SetValue(Microsoft.Maui.Controls.CarouselView.PositionChangedCommandParameterProperty, positionChangedCommandParameter);
        return self;
    }

    public static T PositionChangedCommandParameter<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        var context = new PropertyContext<object>(self, Microsoft.Maui.Controls.CarouselView.PositionChangedCommandParameterProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> PositionChangedCommandParameter<T>(this SettersContext<T> self,
        object positionChangedCommandParameter)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.CarouselView.PositionChangedCommandParameterProperty, Value = positionChangedCommandParameter });
        return self;
    }

    public static SettersContext<T> PositionChangedCommandParameter<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, Microsoft.Maui.Controls.CarouselView.PositionChangedCommandParameterProperty);
        configure(context).Build();
        return self;
    }

    public static T VisibleViews<T>(this T self,
        IList<Microsoft.Maui.Controls.View> visibleViews)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        foreach (var item in visibleViews)
            self.VisibleViews.Add(item);
        return self;
    }

    public static T VisibleViews<T>(this T self,
        params Microsoft.Maui.Controls.View[] visibleViews)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        foreach (var item in visibleViews)
            self.VisibleViews.Add(item);
        return self;
    }

    public static T VisibleViews<T>(this T self,
        Func<Microsoft.Maui.Controls.View[]> configure)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        var visibleViews = configure();
        foreach (var item in visibleViews)
            self.VisibleViews.Add(item);
        return self;
    }

    public static T VisibleViews<T>(this T self,
        System.Collections.ObjectModel.ObservableCollection<Microsoft.Maui.Controls.View> visibleViews)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        self.SetValue(Microsoft.Maui.Controls.CarouselView.VisibleViewsProperty, visibleViews);
        return self;
    }

    public static T VisibleViews<T>(this T self,
        Func<System.Collections.ObjectModel.ObservableCollection<Microsoft.Maui.Controls.View>> configure)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        var visibleViews = configure();
        self.SetValue(Microsoft.Maui.Controls.CarouselView.VisibleViewsProperty, visibleViews);
        return self;
    }

    public static T VisibleViews<T>(this T self, Func<PropertyContext<System.Collections.ObjectModel.ObservableCollection<Microsoft.Maui.Controls.View>>, IPropertyBuilder<System.Collections.ObjectModel.ObservableCollection<Microsoft.Maui.Controls.View>>> configure)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        var context = new PropertyContext<System.Collections.ObjectModel.ObservableCollection<Microsoft.Maui.Controls.View>>(self, Microsoft.Maui.Controls.CarouselView.VisibleViewsProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> VisibleViews<T>(this SettersContext<T> self,
        System.Collections.ObjectModel.ObservableCollection<Microsoft.Maui.Controls.View> visibleViews)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.CarouselView.VisibleViewsProperty, Value = visibleViews });
        return self;
    }

    public static SettersContext<T> VisibleViews<T>(this SettersContext<T> self, Func<PropertySettersContext<System.Collections.ObjectModel.ObservableCollection<Microsoft.Maui.Controls.View>>, IPropertySettersBuilder<System.Collections.ObjectModel.ObservableCollection<Microsoft.Maui.Controls.View>>> configure)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        var context = new PropertySettersContext<System.Collections.ObjectModel.ObservableCollection<Microsoft.Maui.Controls.View>>(self.XamlSetters, Microsoft.Maui.Controls.CarouselView.VisibleViewsProperty);
        configure(context).Build();
        return self;
    }

    public static T OnCurrentItemChanged<T>(this T self, System.EventHandler<Microsoft.Maui.Controls.CurrentItemChangedEventArgs> handler)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        self.CurrentItemChanged += handler;
        return self;
    }

    public static T OnCurrentItemChanged<T>(this T self, System.Action<T> action)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        self.CurrentItemChanged += (o, arg) => action(self);
        return self;
    }

    public static T OnPositionChanged<T>(this T self, System.EventHandler<Microsoft.Maui.Controls.PositionChangedEventArgs> handler)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        self.PositionChanged += handler;
        return self;
    }

    public static T OnPositionChanged<T>(this T self, System.Action<T> action)
        where T : Microsoft.Maui.Controls.CarouselView
    {
        self.PositionChanged += (o, arg) => action(self);
        return self;
    }

}

