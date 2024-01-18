namespace FmgLib.MauiMarkup;

public static partial class VisualElementExtension
{
    public static T Frame<T>(this T self,
        Rect frame)
        where T : VisualElement
    {
        self.Frame = frame;
        return self;
    }
    
    public static T Shadow<T>(this T self,
        Shadow shadow)
        where T : VisualElement
    {
        self.SetValue(VisualElement.ShadowProperty, shadow);
        return self;
    }
    
    public static T Shadow<T>(this T self, Func<PropertyContext<Shadow>, IPropertyBuilder<Shadow>> configure)
        where T : VisualElement
    {
        var context = new PropertyContext<Shadow>(self, VisualElement.ShadowProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Shadow<T>(this SettersContext<T> self,
        Shadow shadow)
        where T : VisualElement
    {
        self.XamlSetters.Add(new Setter { Property = VisualElement.ShadowProperty, Value = shadow });
        return self;
    }
    
    public static SettersContext<T> Shadow<T>(this SettersContext<T> self, Func<PropertySettersContext<Shadow>, IPropertySettersBuilder<Shadow>> configure)
        where T : VisualElement
    {
        var context = new PropertySettersContext<Shadow>(self.XamlSetters, VisualElement.ShadowProperty);
        configure(context).Build();
        return self;
    }
    
    public static T ZIndex<T>(this T self,
        int zIndex)
        where T : VisualElement
    {
        self.SetValue(VisualElement.ZIndexProperty, zIndex);
        return self;
    }
    
    public static T ZIndex<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
        where T : VisualElement
    {
        var context = new PropertyContext<int>(self, VisualElement.ZIndexProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ZIndex<T>(this SettersContext<T> self,
        int zIndex)
        where T : VisualElement
    {
        self.XamlSetters.Add(new Setter { Property = VisualElement.ZIndexProperty, Value = zIndex });
        return self;
    }
    
    public static SettersContext<T> ZIndex<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure)
        where T : VisualElement
    {
        var context = new PropertySettersContext<int>(self.XamlSetters, VisualElement.ZIndexProperty);
        configure(context).Build();
        return self;
    }
    
    public static T Visual<T>(this T self,
        IVisual visual)
        where T : VisualElement
    {
        self.SetValue(VisualElement.VisualProperty, visual);
        return self;
    }
    
    public static T Visual<T>(this T self, Func<PropertyContext<IVisual>, IPropertyBuilder<IVisual>> configure)
        where T : VisualElement
    {
        var context = new PropertyContext<IVisual>(self, VisualElement.VisualProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Visual<T>(this SettersContext<T> self,
        IVisual visual)
        where T : VisualElement
    {
        self.XamlSetters.Add(new Setter { Property = VisualElement.VisualProperty, Value = visual });
        return self;
    }
    
    public static SettersContext<T> Visual<T>(this SettersContext<T> self, Func<PropertySettersContext<IVisual>, IPropertySettersBuilder<IVisual>> configure)
        where T : VisualElement
    {
        var context = new PropertySettersContext<IVisual>(self.XamlSetters, VisualElement.VisualProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FlowDirection<T>(this T self,
        FlowDirection flowDirection)
        where T : VisualElement
    {
        self.SetValue(VisualElement.FlowDirectionProperty, flowDirection);
        return self;
    }
    
    public static T FlowDirection<T>(this T self, Func<PropertyContext<FlowDirection>, IPropertyBuilder<FlowDirection>> configure)
        where T : VisualElement
    {
        var context = new PropertyContext<FlowDirection>(self, VisualElement.FlowDirectionProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FlowDirection<T>(this SettersContext<T> self,
        FlowDirection flowDirection)
        where T : VisualElement
    {
        self.XamlSetters.Add(new Setter { Property = VisualElement.FlowDirectionProperty, Value = flowDirection });
        return self;
    }
    
    public static SettersContext<T> FlowDirection<T>(this SettersContext<T> self, Func<PropertySettersContext<FlowDirection>, IPropertySettersBuilder<FlowDirection>> configure)
        where T : VisualElement
    {
        var context = new PropertySettersContext<FlowDirection>(self.XamlSetters, VisualElement.FlowDirectionProperty);
        configure(context).Build();
        return self;
    }
    
    public static T AnchorX<T>(this T self,
        double anchorX)
        where T : VisualElement
    {
        self.SetValue(VisualElement.AnchorXProperty, anchorX);
        return self;
    }
    
    public static T AnchorX<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : VisualElement
    {
        var context = new PropertyContext<double>(self, VisualElement.AnchorXProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> AnchorX<T>(this SettersContext<T> self,
        double anchorX)
        where T : VisualElement
    {
        self.XamlSetters.Add(new Setter { Property = VisualElement.AnchorXProperty, Value = anchorX });
        return self;
    }
    
    public static SettersContext<T> AnchorX<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : VisualElement
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, VisualElement.AnchorXProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateAnchorXTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : VisualElement
    {
        double fromValue = self.AnchorX;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.AnchorX = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateAnchorXTo", transform, callback, length, easing);
    }
    
    public static T AnchorY<T>(this T self,
        double anchorY)
        where T : VisualElement
    {
        self.SetValue(VisualElement.AnchorYProperty, anchorY);
        return self;
    }
    
    public static T AnchorY<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : VisualElement
    {
        var context = new PropertyContext<double>(self, VisualElement.AnchorYProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> AnchorY<T>(this SettersContext<T> self,
        double anchorY)
        where T : VisualElement
    {
        self.XamlSetters.Add(new Setter { Property = VisualElement.AnchorYProperty, Value = anchorY });
        return self;
    }
    
    public static SettersContext<T> AnchorY<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : VisualElement
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, VisualElement.AnchorYProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateAnchorYTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : VisualElement
    {
        double fromValue = self.AnchorY;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.AnchorY = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateAnchorYTo", transform, callback, length, easing);
    }
    
    public static T BackgroundColor<T>(this T self,
        Color backgroundColor)
        where T : VisualElement
    {
        self.SetValue(VisualElement.BackgroundColorProperty, backgroundColor);
        return self;
    }
    
    public static T BackgroundColor<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : VisualElement
    {
        var context = new PropertyContext<Color>(self, VisualElement.BackgroundColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> BackgroundColor<T>(this SettersContext<T> self,
        Color backgroundColor)
        where T : VisualElement
    {
        self.XamlSetters.Add(new Setter { Property = VisualElement.BackgroundColorProperty, Value = backgroundColor });
        return self;
    }
    
    public static SettersContext<T> BackgroundColor<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : VisualElement
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, VisualElement.BackgroundColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateBackgroundColorTo<T>(this T self, Color value, uint length = 250, Easing? easing = null)
        where T : VisualElement
    {
        Color fromValue = self.BackgroundColor;
        var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
        var callback = (Color actValue) => { self.BackgroundColor = actValue; };
        return Transformations.AnimateAsync<Color>(self, "AnimateBackgroundColorTo", transform, callback, length, easing);
    }
    
    public static T Background<T>(this T self,
        Brush background)
        where T : VisualElement
    {
        self.SetValue(VisualElement.BackgroundProperty, background);
        return self;
    }
    
    public static T Background<T>(this T self, Func<PropertyContext<Brush>, IPropertyBuilder<Brush>> configure)
        where T : VisualElement
    {
        var context = new PropertyContext<Brush>(self, VisualElement.BackgroundProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Background<T>(this SettersContext<T> self,
        Brush background)
        where T : VisualElement
    {
        self.XamlSetters.Add(new Setter { Property = VisualElement.BackgroundProperty, Value = background });
        return self;
    }
    
    public static SettersContext<T> Background<T>(this SettersContext<T> self, Func<PropertySettersContext<Brush>, IPropertySettersBuilder<Brush>> configure)
        where T : VisualElement
    {
        var context = new PropertySettersContext<Brush>(self.XamlSetters, VisualElement.BackgroundProperty);
        configure(context).Build();
        return self;
    }
    
    public static T Behaviors<T>(this T self,
        IList<Behavior> behaviors)
        where T : VisualElement
    {
        foreach (var item in behaviors)
            self.Behaviors.Add(item);
        return self;
    }

    public static T Behaviors<T>(this T self,
        params Behavior[] behaviors)
        where T : VisualElement
    {
        foreach (var item in behaviors)
            self.Behaviors.Add(item);
        return self;
    }
    
    public static T Behaviors<T>(this T self, Func<PropertyContext<IList<Behavior>>, IPropertyBuilder<IList<Behavior>>> configure)
        where T : VisualElement
    {
        var context = new PropertyContext<IList<Behavior>>(self, VisualElement.BehaviorsProperty);
        configure(context).Build();
        return self;
    }
    
    public static T HeightRequest<T>(this T self,
        double heightRequest)
        where T : VisualElement
    {
        self.SetValue(VisualElement.HeightRequestProperty, heightRequest);
        return self;
    }
    
    public static T HeightRequest<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : VisualElement
    {
        var context = new PropertyContext<double>(self, VisualElement.HeightRequestProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> HeightRequest<T>(this SettersContext<T> self,
        double heightRequest)
        where T : VisualElement
    {
        self.XamlSetters.Add(new Setter { Property = VisualElement.HeightRequestProperty, Value = heightRequest });
        return self;
    }
    
    public static SettersContext<T> HeightRequest<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : VisualElement
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, VisualElement.HeightRequestProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateHeightRequestTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : VisualElement
    {
        double fromValue = self.HeightRequest;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.HeightRequest = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateHeightRequestTo", transform, callback, length, easing);
    }
    
    public static T InputTransparent<T>(this T self,
        bool inputTransparent)
        where T : VisualElement
    {
        self.SetValue(VisualElement.InputTransparentProperty, inputTransparent);
        return self;
    }
    
    public static T InputTransparent<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : VisualElement
    {
        var context = new PropertyContext<bool>(self, VisualElement.InputTransparentProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> InputTransparent<T>(this SettersContext<T> self,
        bool inputTransparent)
        where T : VisualElement
    {
        self.XamlSetters.Add(new Setter { Property = VisualElement.InputTransparentProperty, Value = inputTransparent });
        return self;
    }
    
    public static SettersContext<T> InputTransparent<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : VisualElement
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, VisualElement.InputTransparentProperty);
        configure(context).Build();
        return self;
    }
    
    public static T IsEnabled<T>(this T self,
        bool isEnabled)
        where T : VisualElement
    {
        self.SetValue(VisualElement.IsEnabledProperty, isEnabled);
        return self;
    }
    
    public static T IsEnabled<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : VisualElement
    {
        var context = new PropertyContext<bool>(self, VisualElement.IsEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> IsEnabled<T>(this SettersContext<T> self,
        bool isEnabled)
        where T : VisualElement
    {
        self.XamlSetters.Add(new Setter { Property = VisualElement.IsEnabledProperty, Value = isEnabled });
        return self;
    }
    
    public static SettersContext<T> IsEnabled<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : VisualElement
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, VisualElement.IsEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static T IsVisible<T>(this T self,
        bool isVisible)
        where T : VisualElement
    {
        self.SetValue(VisualElement.IsVisibleProperty, isVisible);
        return self;
    }
    
    public static T IsVisible<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : VisualElement
    {
        var context = new PropertyContext<bool>(self, VisualElement.IsVisibleProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> IsVisible<T>(this SettersContext<T> self,
        bool isVisible)
        where T : VisualElement
    {
        self.XamlSetters.Add(new Setter { Property = VisualElement.IsVisibleProperty, Value = isVisible });
        return self;
    }
    
    public static SettersContext<T> IsVisible<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : VisualElement
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, VisualElement.IsVisibleProperty);
        configure(context).Build();
        return self;
    }
    
    public static T MinimumHeightRequest<T>(this T self,
        double minimumHeightRequest)
        where T : VisualElement
    {
        self.SetValue(VisualElement.MinimumHeightRequestProperty, minimumHeightRequest);
        return self;
    }
    
    public static T MinimumHeightRequest<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : VisualElement
    {
        var context = new PropertyContext<double>(self, VisualElement.MinimumHeightRequestProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> MinimumHeightRequest<T>(this SettersContext<T> self,
        double minimumHeightRequest)
        where T : VisualElement
    {
        self.XamlSetters.Add(new Setter { Property = VisualElement.MinimumHeightRequestProperty, Value = minimumHeightRequest });
        return self;
    }
    
    public static SettersContext<T> MinimumHeightRequest<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : VisualElement
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, VisualElement.MinimumHeightRequestProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateMinimumHeightRequestTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : VisualElement
    {
        double fromValue = self.MinimumHeightRequest;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.MinimumHeightRequest = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateMinimumHeightRequestTo", transform, callback, length, easing);
    }
    
    public static T MinimumWidthRequest<T>(this T self,
        double minimumWidthRequest)
        where T : VisualElement
    {
        self.SetValue(VisualElement.MinimumWidthRequestProperty, minimumWidthRequest);
        return self;
    }
    
    public static T MinimumWidthRequest<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : VisualElement
    {
        var context = new PropertyContext<double>(self, VisualElement.MinimumWidthRequestProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> MinimumWidthRequest<T>(this SettersContext<T> self,
        double minimumWidthRequest)
        where T : VisualElement
    {
        self.XamlSetters.Add(new Setter { Property = VisualElement.MinimumWidthRequestProperty, Value = minimumWidthRequest });
        return self;
    }
    
    public static SettersContext<T> MinimumWidthRequest<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : VisualElement
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, VisualElement.MinimumWidthRequestProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateMinimumWidthRequestTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : VisualElement
    {
        double fromValue = self.MinimumWidthRequest;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.MinimumWidthRequest = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateMinimumWidthRequestTo", transform, callback, length, easing);
    }
    
    public static T MaximumHeightRequest<T>(this T self,
        double maximumHeightRequest)
        where T : VisualElement
    {
        self.SetValue(VisualElement.MaximumHeightRequestProperty, maximumHeightRequest);
        return self;
    }
    
    public static T MaximumHeightRequest<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : VisualElement
    {
        var context = new PropertyContext<double>(self, VisualElement.MaximumHeightRequestProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> MaximumHeightRequest<T>(this SettersContext<T> self,
        double maximumHeightRequest)
        where T : VisualElement
    {
        self.XamlSetters.Add(new Setter { Property = VisualElement.MaximumHeightRequestProperty, Value = maximumHeightRequest });
        return self;
    }
    
    public static SettersContext<T> MaximumHeightRequest<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : VisualElement
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, VisualElement.MaximumHeightRequestProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateMaximumHeightRequestTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : VisualElement
    {
        double fromValue = self.MaximumHeightRequest;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.MaximumHeightRequest = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateMaximumHeightRequestTo", transform, callback, length, easing);
    }
    
    public static T MaximumWidthRequest<T>(this T self,
        double maximumWidthRequest)
        where T : VisualElement
    {
        self.SetValue(VisualElement.MaximumWidthRequestProperty, maximumWidthRequest);
        return self;
    }
    
    public static T MaximumWidthRequest<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : VisualElement
    {
        var context = new PropertyContext<double>(self, VisualElement.MaximumWidthRequestProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> MaximumWidthRequest<T>(this SettersContext<T> self,
        double maximumWidthRequest)
        where T : VisualElement
    {
        self.XamlSetters.Add(new Setter { Property = VisualElement.MaximumWidthRequestProperty, Value = maximumWidthRequest });
        return self;
    }
    
    public static SettersContext<T> MaximumWidthRequest<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : VisualElement
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, VisualElement.MaximumWidthRequestProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateMaximumWidthRequestTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : VisualElement
    {
        double fromValue = self.MaximumWidthRequest;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.MaximumWidthRequest = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateMaximumWidthRequestTo", transform, callback, length, easing);
    }
    
    public static T Opacity<T>(this T self,
        double opacity)
        where T : VisualElement
    {
        self.SetValue(VisualElement.OpacityProperty, opacity);
        return self;
    }
    
    public static T Opacity<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : VisualElement
    {
        var context = new PropertyContext<double>(self, VisualElement.OpacityProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Opacity<T>(this SettersContext<T> self,
        double opacity)
        where T : VisualElement
    {
        self.XamlSetters.Add(new Setter { Property = VisualElement.OpacityProperty, Value = opacity });
        return self;
    }
    
    public static SettersContext<T> Opacity<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : VisualElement
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, VisualElement.OpacityProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateOpacityTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : VisualElement
    {
        double fromValue = self.Opacity;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.Opacity = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateOpacityTo", transform, callback, length, easing);
    }
    
    public static T Rotation<T>(this T self,
        double rotation)
        where T : VisualElement
    {
        self.SetValue(VisualElement.RotationProperty, rotation);
        return self;
    }
    
    public static T Rotation<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : VisualElement
    {
        var context = new PropertyContext<double>(self, VisualElement.RotationProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Rotation<T>(this SettersContext<T> self,
        double rotation)
        where T : VisualElement
    {
        self.XamlSetters.Add(new Setter { Property = VisualElement.RotationProperty, Value = rotation });
        return self;
    }
    
    public static SettersContext<T> Rotation<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : VisualElement
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, VisualElement.RotationProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateRotationTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : VisualElement
    {
        double fromValue = self.Rotation;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.Rotation = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateRotationTo", transform, callback, length, easing);
    }
    
    public static T RotationX<T>(this T self,
        double rotationX)
        where T : VisualElement
    {
        self.SetValue(VisualElement.RotationXProperty, rotationX);
        return self;
    }
    
    public static T RotationX<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : VisualElement
    {
        var context = new PropertyContext<double>(self, VisualElement.RotationXProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> RotationX<T>(this SettersContext<T> self,
        double rotationX)
        where T : VisualElement
    {
        self.XamlSetters.Add(new Setter { Property = VisualElement.RotationXProperty, Value = rotationX });
        return self;
    }
    
    public static SettersContext<T> RotationX<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : VisualElement
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, VisualElement.RotationXProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateRotationXTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : VisualElement
    {
        double fromValue = self.RotationX;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.RotationX = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateRotationXTo", transform, callback, length, easing);
    }
    
    public static T RotationY<T>(this T self,
        double rotationY)
        where T : VisualElement
    {
        self.SetValue(VisualElement.RotationYProperty, rotationY);
        return self;
    }
    
    public static T RotationY<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : VisualElement
    {
        var context = new PropertyContext<double>(self, VisualElement.RotationYProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> RotationY<T>(this SettersContext<T> self,
        double rotationY)
        where T : VisualElement
    {
        self.XamlSetters.Add(new Setter { Property = VisualElement.RotationYProperty, Value = rotationY });
        return self;
    }
    
    public static SettersContext<T> RotationY<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : VisualElement
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, VisualElement.RotationYProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateRotationYTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : VisualElement
    {
        double fromValue = self.RotationY;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.RotationY = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateRotationYTo", transform, callback, length, easing);
    }
    
    public static T Scale<T>(this T self,
        double scale)
        where T : VisualElement
    {
        self.SetValue(VisualElement.ScaleProperty, scale);
        return self;
    }
    
    public static T Scale<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : VisualElement
    {
        var context = new PropertyContext<double>(self, VisualElement.ScaleProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Scale<T>(this SettersContext<T> self,
        double scale)
        where T : VisualElement
    {
        self.XamlSetters.Add(new Setter { Property = VisualElement.ScaleProperty, Value = scale });
        return self;
    }
    
    public static SettersContext<T> Scale<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : VisualElement
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, VisualElement.ScaleProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateScaleTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : VisualElement
    {
        double fromValue = self.Scale;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.Scale = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateScaleTo", transform, callback, length, easing);
    }
    
    public static T ScaleX<T>(this T self,
        double scaleX)
        where T : VisualElement
    {
        self.SetValue(VisualElement.ScaleXProperty, scaleX);
        return self;
    }
    
    public static T ScaleX<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : VisualElement
    {
        var context = new PropertyContext<double>(self, VisualElement.ScaleXProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ScaleX<T>(this SettersContext<T> self,
        double scaleX)
        where T : VisualElement
    {
        self.XamlSetters.Add(new Setter { Property = VisualElement.ScaleXProperty, Value = scaleX });
        return self;
    }
    
    public static SettersContext<T> ScaleX<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : VisualElement
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, VisualElement.ScaleXProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateScaleXTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : VisualElement
    {
        double fromValue = self.ScaleX;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.ScaleX = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateScaleXTo", transform, callback, length, easing);
    }
    
    public static T ScaleY<T>(this T self,
        double scaleY)
        where T : VisualElement
    {
        self.SetValue(VisualElement.ScaleYProperty, scaleY);
        return self;
    }
    
    public static T ScaleY<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : VisualElement
    {
        var context = new PropertyContext<double>(self, VisualElement.ScaleYProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ScaleY<T>(this SettersContext<T> self,
        double scaleY)
        where T : VisualElement
    {
        self.XamlSetters.Add(new Setter { Property = VisualElement.ScaleYProperty, Value = scaleY });
        return self;
    }
    
    public static SettersContext<T> ScaleY<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : VisualElement
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, VisualElement.ScaleYProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateScaleYTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : VisualElement
    {
        double fromValue = self.ScaleY;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.ScaleY = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateScaleYTo", transform, callback, length, easing);
    }
    
    public static T TranslationX<T>(this T self,
        double translationX)
        where T : VisualElement
    {
        self.SetValue(VisualElement.TranslationXProperty, translationX);
        return self;
    }
    
    public static T TranslationX<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : VisualElement
    {
        var context = new PropertyContext<double>(self, VisualElement.TranslationXProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> TranslationX<T>(this SettersContext<T> self,
        double translationX)
        where T : VisualElement
    {
        self.XamlSetters.Add(new Setter { Property = VisualElement.TranslationXProperty, Value = translationX });
        return self;
    }
    
    public static SettersContext<T> TranslationX<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : VisualElement
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, VisualElement.TranslationXProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateTranslationXTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : VisualElement
    {
        double fromValue = self.TranslationX;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.TranslationX = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateTranslationXTo", transform, callback, length, easing);
    }
    
    public static T TranslationY<T>(this T self,
        double translationY)
        where T : VisualElement
    {
        self.SetValue(VisualElement.TranslationYProperty, translationY);
        return self;
    }
    
    public static T TranslationY<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : VisualElement
    {
        var context = new PropertyContext<double>(self, VisualElement.TranslationYProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> TranslationY<T>(this SettersContext<T> self,
        double translationY)
        where T : VisualElement
    {
        self.XamlSetters.Add(new Setter { Property = VisualElement.TranslationYProperty, Value = translationY });
        return self;
    }
    
    public static SettersContext<T> TranslationY<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : VisualElement
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, VisualElement.TranslationYProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateTranslationYTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : VisualElement
    {
        double fromValue = self.TranslationY;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.TranslationY = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateTranslationYTo", transform, callback, length, easing);
    }
    
    public static T Triggers<T>(this T self,
        IList<TriggerBase> triggers)
        where T : VisualElement
    {
        foreach (var item in triggers)
            self.Triggers.Add(item);
        return self;
    }

    public static T Triggers<T>(this T self,
        params TriggerBase[] triggers)
        where T : VisualElement
    {
        foreach (var item in triggers)
            self.Triggers.Add(item);
        return self;
    }
    
    public static T Triggers<T>(this T self, Func<PropertyContext<IList<TriggerBase>>, IPropertyBuilder<IList<TriggerBase>>> configure)
        where T : VisualElement
    {
        var context = new PropertyContext<IList<TriggerBase>>(self, VisualElement.TriggersProperty);
        configure(context).Build();
        return self;
    }
    
    public static T WidthRequest<T>(this T self,
        double widthRequest)
        where T : VisualElement
    {
        self.SetValue(VisualElement.WidthRequestProperty, widthRequest);
        return self;
    }
    
    public static T WidthRequest<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : VisualElement
    {
        var context = new PropertyContext<double>(self, VisualElement.WidthRequestProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> WidthRequest<T>(this SettersContext<T> self,
        double widthRequest)
        where T : VisualElement
    {
        self.XamlSetters.Add(new Setter { Property = VisualElement.WidthRequestProperty, Value = widthRequest });
        return self;
    }
    
    public static SettersContext<T> WidthRequest<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : VisualElement
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, VisualElement.WidthRequestProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateWidthRequestTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : VisualElement
    {
        double fromValue = self.WidthRequest;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.WidthRequest = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateWidthRequestTo", transform, callback, length, easing);
    }
    
    public static T Clip<T>(this T self,
        Microsoft.Maui.Controls.Shapes.Geometry clip)
        where T : VisualElement
    {
        self.SetValue(VisualElement.ClipProperty, clip);
        return self;
    }
    
    public static T Clip<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.Shapes.Geometry>, IPropertyBuilder<Microsoft.Maui.Controls.Shapes.Geometry>> configure)
        where T : VisualElement
    {
        var context = new PropertyContext<Microsoft.Maui.Controls.Shapes.Geometry>(self, VisualElement.ClipProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Clip<T>(this SettersContext<T> self,
        Microsoft.Maui.Controls.Shapes.Geometry clip)
        where T : VisualElement
    {
        self.XamlSetters.Add(new Setter { Property = VisualElement.ClipProperty, Value = clip });
        return self;
    }
    
    public static SettersContext<T> Clip<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Controls.Shapes.Geometry>, IPropertySettersBuilder<Microsoft.Maui.Controls.Shapes.Geometry>> configure)
        where T : VisualElement
    {
        var context = new PropertySettersContext<Microsoft.Maui.Controls.Shapes.Geometry>(self.XamlSetters, VisualElement.ClipProperty);
        configure(context).Build();
        return self;
    }
    
    public static T DisableLayout<T>(this T self,
        bool disableLayout)
        where T : VisualElement
    {
        self.DisableLayout = disableLayout;
        return self;
    }
    
    public static T IsInPlatformLayout<T>(this T self,
        bool isInPlatformLayout)
        where T : VisualElement
    {
        self.IsInPlatformLayout = isInPlatformLayout;
        return self;
    }
    
    public static T IsPlatformStateConsistent<T>(this T self,
        bool isPlatformStateConsistent)
        where T : VisualElement
    {
        self.IsPlatformStateConsistent = isPlatformStateConsistent;
        return self;
    }
    
    public static T IsPlatformEnabled<T>(this T self,
        bool isPlatformEnabled)
        where T : VisualElement
    {
        self.IsPlatformEnabled = isPlatformEnabled;
        return self;
    }
    
    public static T Resources<T>(this T self,
        ResourceDictionary resources)
        where T : VisualElement
    {
        self.Resources = resources;
        return self;
    }
    
    public static T OnLoaded<T>(this T self, EventHandler? handler)
        where T : VisualElement
    {
        self.Loaded += handler;
        return self;
    }
    
    public static T OnLoaded<T>(this T self, Action<T> action)
        where T : VisualElement
    {
        self.Loaded += (o, arg) => action(self);
        return self;
    }
    
    public static T OnUnloaded<T>(this T self, EventHandler? handler)
        where T : VisualElement
    {
        self.Unloaded += handler;
        return self;
    }
    
    public static T OnUnloaded<T>(this T self, Action<T> action)
        where T : VisualElement
    {
        self.Unloaded += (o, arg) => action(self);
        return self;
    }
    
    public static T OnChildrenReordered<T>(this T self, EventHandler handler)
        where T : VisualElement
    {
        self.ChildrenReordered += handler;
        return self;
    }
    
    public static T OnChildrenReordered<T>(this T self, Action<T> action)
        where T : VisualElement
    {
        self.ChildrenReordered += (o, arg) => action(self);
        return self;
    }
    
    public static T OnFocused<T>(this T self, EventHandler<FocusEventArgs> handler)
        where T : VisualElement
    {
        self.Focused += handler;
        return self;
    }
    
    public static T OnFocused<T>(this T self, Action<T> action)
        where T : VisualElement
    {
        self.Focused += (o, arg) => action(self);
        return self;
    }
    
    public static T OnMeasureInvalidated<T>(this T self, EventHandler handler)
        where T : VisualElement
    {
        self.MeasureInvalidated += handler;
        return self;
    }
    
    public static T OnMeasureInvalidated<T>(this T self, Action<T> action)
        where T : VisualElement
    {
        self.MeasureInvalidated += (o, arg) => action(self);
        return self;
    }
    
    public static T OnSizeChanged<T>(this T self, EventHandler handler)
        where T : VisualElement
    {
        self.SizeChanged += handler;
        return self;
    }
    
    public static T OnSizeChanged<T>(this T self, Action<T> action)
        where T : VisualElement
    {
        self.SizeChanged += (o, arg) => action(self);
        return self;
    }
    
    public static T OnUnfocused<T>(this T self, EventHandler<FocusEventArgs> handler)
        where T : VisualElement
    {
        self.Unfocused += handler;
        return self;
    }
    
    public static T OnUnfocused<T>(this T self, Action<T> action)
        where T : VisualElement
    {
        self.Unfocused += (o, arg) => action(self);
        return self;
    }
    
    public static T OnBatchCommitted<T>(this T self, EventHandler<Microsoft.Maui.Controls.Internals.EventArg<VisualElement>> handler)
        where T : VisualElement
    {
        self.BatchCommitted += handler;
        return self;
    }
    
    public static T OnBatchCommitted<T>(this T self, Action<T> action)
        where T : VisualElement
    {
        self.BatchCommitted += (o, arg) => action(self);
        return self;
    }
    
    public static T OnFocusChangeRequested<T>(this T self, EventHandler<VisualElement.FocusRequestArgs> handler)
        where T : VisualElement
    {
        self.FocusChangeRequested += handler;
        return self;
    }
    
    public static T OnFocusChangeRequested<T>(this T self, Action<T> action)
        where T : VisualElement
    {
        self.FocusChangeRequested += (o, arg) => action(self);
        return self;
    }

    public static T VisualStateGroups<T>(this T self,
        VisualStateGroupList visualStateGroups)
        where T : VisualElement
    {
        self.SetValue(VisualStateManager.VisualStateGroupsProperty, visualStateGroups);
        return self;
    }

    public static T VisualStateGroups<T>(this T self, Func<PropertyContext<VisualStateGroupList>, IPropertyBuilder<VisualStateGroupList>> configure)
        where T : VisualElement
    {
        var context = new PropertyContext<VisualStateGroupList>(self, VisualStateManager.VisualStateGroupsProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> VisualStateGroups<T>(this SettersContext<T> self,
        VisualStateGroupList visualStateGroups)
        where T : VisualElement
    {
        self.XamlSetters.Add(new Setter { Property = VisualStateManager.VisualStateGroupsProperty, Value = visualStateGroups });
        return self;
    }

    public static SettersContext<T> VisualStateGroups<T>(this SettersContext<T> self, Func<PropertySettersContext<VisualStateGroupList>, IPropertySettersBuilder<VisualStateGroupList>> configure)
        where T : VisualElement
    {
        var context = new PropertySettersContext<VisualStateGroupList>(self.XamlSetters, VisualStateManager.VisualStateGroupsProperty);
        configure(context).Build();
        return self;
    }

    public static VisualStateGroupList GetVisualStateGroupsValue<T>(this T self)
        where T : VisualElement
    {
        return (VisualStateGroupList)self.GetValue(VisualStateManager.VisualStateGroupsProperty);
    }

    public static T AutomationExcludedWithChildren<T>(this T self,
        bool? automationExcludedWithChildren)
        where T : VisualElement
    {
        self.SetValue(AutomationProperties.ExcludedWithChildrenProperty, automationExcludedWithChildren);
        return self;
    }

    public static T AutomationExcludedWithChildren<T>(this T self, Func<PropertyContext<bool?>, IPropertyBuilder<bool?>> configure)
        where T : VisualElement
    {
        var context = new PropertyContext<bool?>(self, AutomationProperties.ExcludedWithChildrenProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> AutomationExcludedWithChildren<T>(this SettersContext<T> self,
        bool? automationExcludedWithChildren)
        where T : VisualElement
    {
        self.XamlSetters.Add(new Setter { Property = AutomationProperties.ExcludedWithChildrenProperty, Value = automationExcludedWithChildren });
        return self;
    }

    public static SettersContext<T> AutomationExcludedWithChildren<T>(this SettersContext<T> self, Func<PropertySettersContext<bool?>, IPropertySettersBuilder<bool?>> configure)
        where T : VisualElement
    {
        var context = new PropertySettersContext<bool?>(self.XamlSetters, AutomationProperties.ExcludedWithChildrenProperty);
        configure(context).Build();
        return self;
    }

    public static bool? GetAutomationExcludedWithChildrenValue<T>(this T self)
        where T : VisualElement
    {
        return (bool?)self.GetValue(AutomationProperties.ExcludedWithChildrenProperty);
    }

    public static T AutomationIsInAccessibleTree<T>(this T self,
        bool? automationIsInAccessibleTree)
        where T : VisualElement
    {
        self.SetValue(AutomationProperties.IsInAccessibleTreeProperty, automationIsInAccessibleTree);
        return self;
    }

    public static T AutomationIsInAccessibleTree<T>(this T self, Func<PropertyContext<bool?>, IPropertyBuilder<bool?>> configure)
        where T : VisualElement
    {
        var context = new PropertyContext<bool?>(self, AutomationProperties.IsInAccessibleTreeProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> AutomationIsInAccessibleTree<T>(this SettersContext<T> self,
        bool? automationIsInAccessibleTree)
        where T : VisualElement
    {
        self.XamlSetters.Add(new Setter { Property = AutomationProperties.IsInAccessibleTreeProperty, Value = automationIsInAccessibleTree });
        return self;
    }

    public static SettersContext<T> AutomationIsInAccessibleTree<T>(this SettersContext<T> self, Func<PropertySettersContext<bool?>, IPropertySettersBuilder<bool?>> configure)
        where T : VisualElement
    {
        var context = new PropertySettersContext<bool?>(self.XamlSetters, AutomationProperties.IsInAccessibleTreeProperty);
        configure(context).Build();
        return self;
    }

    public static bool? GetAutomationIsInAccessibleTreeValue<T>(this T self)
        where T : VisualElement
    {
        return (bool?)self.GetValue(AutomationProperties.IsInAccessibleTreeProperty);
    }

    public static T AutomationName<T>(this T self,
        string automationName)
        where T : VisualElement
    {
        self.SetValue(AutomationProperties.NameProperty, automationName);
        return self;
    }

    public static T AutomationName<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : VisualElement
    {
        var context = new PropertyContext<string>(self, AutomationProperties.NameProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> AutomationName<T>(this SettersContext<T> self,
        string automationName)
        where T : VisualElement
    {
        self.XamlSetters.Add(new Setter { Property = AutomationProperties.NameProperty, Value = automationName });
        return self;
    }

    public static SettersContext<T> AutomationName<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : VisualElement
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, AutomationProperties.NameProperty);
        configure(context).Build();
        return self;
    }

    public static string GetAutomationNameValue<T>(this T self)
        where T : VisualElement
    {
        return (string)self.GetValue(AutomationProperties.NameProperty);
    }

    public static T AutomationHelpText<T>(this T self,
        string automationHelpText)
        where T : VisualElement
    {
        self.SetValue(AutomationProperties.HelpTextProperty, automationHelpText);
        return self;
    }

    public static T AutomationHelpText<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : VisualElement
    {
        var context = new PropertyContext<string>(self, AutomationProperties.HelpTextProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> AutomationHelpText<T>(this SettersContext<T> self,
        string automationHelpText)
        where T : VisualElement
    {
        self.XamlSetters.Add(new Setter { Property = AutomationProperties.HelpTextProperty, Value = automationHelpText });
        return self;
    }

    public static SettersContext<T> AutomationHelpText<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : VisualElement
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, AutomationProperties.HelpTextProperty);
        configure(context).Build();
        return self;
    }

    public static string GetAutomationHelpTextValue<T>(this T self)
        where T : VisualElement
    {
        return (string)self.GetValue(AutomationProperties.HelpTextProperty);
    }

    public static T AutomationLabeledBy<T>(this T self,
        VisualElement automationLabeledBy)
        where T : VisualElement
    {
        self.SetValue(AutomationProperties.LabeledByProperty, automationLabeledBy);
        return self;
    }

    public static T AutomationLabeledBy<T>(this T self, Func<PropertyContext<VisualElement>, IPropertyBuilder<VisualElement>> configure)
        where T : VisualElement
    {
        var context = new PropertyContext<VisualElement>(self, AutomationProperties.LabeledByProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> AutomationLabeledBy<T>(this SettersContext<T> self,
        VisualElement automationLabeledBy)
        where T : VisualElement
    {
        self.XamlSetters.Add(new Setter { Property = AutomationProperties.LabeledByProperty, Value = automationLabeledBy });
        return self;
    }

    public static SettersContext<T> AutomationLabeledBy<T>(this SettersContext<T> self, Func<PropertySettersContext<VisualElement>, IPropertySettersBuilder<VisualElement>> configure)
        where T : VisualElement
    {
        var context = new PropertySettersContext<VisualElement>(self.XamlSetters, AutomationProperties.LabeledByProperty);
        configure(context).Build();
        return self;
    }

    public static VisualElement GetAutomationLabeledByValue<T>(this T self)
        where T : VisualElement
    {
        return (VisualElement)self.GetValue(AutomationProperties.LabeledByProperty);
    }

    public static T SemanticHint<T>(this T self,
        string semanticHint)
        where T : VisualElement
    {
        self.SetValue(SemanticProperties.HintProperty, semanticHint);
        return self;
    }

    public static T SemanticHint<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : VisualElement
    {
        var context = new PropertyContext<string>(self, SemanticProperties.HintProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> SemanticHint<T>(this SettersContext<T> self,
        string semanticHint)
        where T : VisualElement
    {
        self.XamlSetters.Add(new Setter { Property = SemanticProperties.HintProperty, Value = semanticHint });
        return self;
    }

    public static SettersContext<T> SemanticHint<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : VisualElement
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, SemanticProperties.HintProperty);
        configure(context).Build();
        return self;
    }

    public static string GetSemanticHintValue<T>(this T self)
        where T : VisualElement
    {
        return (string)self.GetValue(SemanticProperties.HintProperty);
    }

    public static T SemanticDescription<T>(this T self,
        string semanticDescription)
        where T : VisualElement
    {
        self.SetValue(SemanticProperties.DescriptionProperty, semanticDescription);
        return self;
    }

    public static T SemanticDescription<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : VisualElement
    {
        var context = new PropertyContext<string>(self, SemanticProperties.DescriptionProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> SemanticDescription<T>(this SettersContext<T> self,
        string semanticDescription)
        where T : VisualElement
    {
        self.XamlSetters.Add(new Setter { Property = SemanticProperties.DescriptionProperty, Value = semanticDescription });
        return self;
    }

    public static SettersContext<T> SemanticDescription<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : VisualElement
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, SemanticProperties.DescriptionProperty);
        configure(context).Build();
        return self;
    }

    public static string GetSemanticDescriptionValue<T>(this T self)
        where T : VisualElement
    {
        return (string)self.GetValue(SemanticProperties.DescriptionProperty);
    }

    public static T SemanticHeadingLevel<T>(this T self,
        Microsoft.Maui.SemanticHeadingLevel semanticHeadingLevel)
        where T : VisualElement
    {
        self.SetValue(SemanticProperties.HeadingLevelProperty, semanticHeadingLevel);
        return self;
    }

    public static T SemanticHeadingLevel<T>(this T self, Func<PropertyContext<Microsoft.Maui.SemanticHeadingLevel>, IPropertyBuilder<Microsoft.Maui.SemanticHeadingLevel>> configure)
        where T : VisualElement
    {
        var context = new PropertyContext<Microsoft.Maui.SemanticHeadingLevel>(self, SemanticProperties.HeadingLevelProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> SemanticHeadingLevel<T>(this SettersContext<T> self,
        Microsoft.Maui.SemanticHeadingLevel semanticHeadingLevel)
        where T : VisualElement
    {
        self.XamlSetters.Add(new Setter { Property = SemanticProperties.HeadingLevelProperty, Value = semanticHeadingLevel });
        return self;
    }

    public static SettersContext<T> SemanticHeadingLevel<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.SemanticHeadingLevel>, IPropertySettersBuilder<Microsoft.Maui.SemanticHeadingLevel>> configure)
        where T : VisualElement
    {
        var context = new PropertySettersContext<Microsoft.Maui.SemanticHeadingLevel>(self.XamlSetters, SemanticProperties.HeadingLevelProperty);
        configure(context).Build();
        return self;
    }

    public static Microsoft.Maui.SemanticHeadingLevel GetSemanticHeadingLevelValue<T>(this T self)
        where T : VisualElement
    {
        return (Microsoft.Maui.SemanticHeadingLevel)self.GetValue(SemanticProperties.HeadingLevelProperty);
    }

}
