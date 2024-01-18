using Microsoft.Maui.Controls.Shapes;
using Microsoft.Maui.Controls.Internals;

namespace FmgLib.MauiMarkup;

public static class VisualElementExtension
{
    public static T SizeRequestFmg<T>(this T self, double widthRequest, double heightRequest) where T : VisualElement
    {
        self.SetValue(VisualElement.WidthRequestProperty, widthRequest);
        self.SetValue(VisualElement.HeightRequestProperty, heightRequest);
        return self;
    }

    public static SettersContext<T> SizeRequestFmg<T>(this SettersContext<T> self, double widthRequest, double heightRequest) where T : VisualElement
    {
        self.XamlSetters.Add(new Setter
        {
            Property = VisualElement.WidthRequestProperty,
            Value = widthRequest
        });
        self.XamlSetters.Add(new Setter
        {
            Property = VisualElement.HeightRequestProperty,
            Value = heightRequest
        });
        return self;
    }

    public static Task<bool> AnimateSizeRequestToFmg<T>(this T self, double width, double height, uint length = 250u, Easing easing = null) where T : VisualElement
    {
        Size from = new Size(self.WidthRequest, self.HeightRequest);
        Size to = new Size(width, height);
        Func<double, Size> transform = (double t) => Transformations.SizeTransform(from, to, t);
        Action<Size> callback = delegate (Size value)
        {
            self.SizeRequestFmg(value.Width, value.Height);
        };
        return Transformations.AnimateAsync(self, "AnimateSizeRequestTo", transform, callback, length, easing);
    }

    public static T FrameFmg<T>(this T self, Rect frame) where T : VisualElement
    {
        self.Frame = frame;
        return self;
    }

    public static T ShadowFmg<T>(this T self, Shadow shadow) where T : VisualElement
    {
        self.SetValue(VisualElement.ShadowProperty, shadow);
        return self;
    }

    public static T ShadowFmg<T>(this T self, Func<PropertyContext<Shadow>, IPropertyBuilder<Shadow>> configure) where T : VisualElement
    {
        PropertyContext<Shadow> arg = new PropertyContext<Shadow>(self, VisualElement.ShadowProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> ShadowFmg<T>(this SettersContext<T> self, Shadow shadow) where T : VisualElement
    {
        self.XamlSetters.Add(new Setter
        {
            Property = VisualElement.ShadowProperty,
            Value = shadow
        });
        return self;
    }

    public static SettersContext<T> ShadowFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Shadow>, IPropertySettersBuilder<Shadow>> configure) where T : VisualElement
    {
        PropertySettersContext<Shadow> arg = new PropertySettersContext<Shadow>(self.XamlSetters, VisualElement.ShadowProperty);
        configure(arg).Build();
        return self;
    }

    public static T ZIndexFmg<T>(this T self, int zIndex) where T : VisualElement
    {
        self.SetValue(VisualElement.ZIndexProperty, zIndex);
        return self;
    }

    public static T ZIndexFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure) where T : VisualElement
    {
        PropertyContext<int> arg = new PropertyContext<int>(self, VisualElement.ZIndexProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> ZIndexFmg<T>(this SettersContext<T> self, int zIndex) where T : VisualElement
    {
        self.XamlSetters.Add(new Setter
        {
            Property = VisualElement.ZIndexProperty,
            Value = zIndex
        });
        return self;
    }

    public static SettersContext<T> ZIndexFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure) where T : VisualElement
    {
        PropertySettersContext<int> arg = new PropertySettersContext<int>(self.XamlSetters, VisualElement.ZIndexProperty);
        configure(arg).Build();
        return self;
    }

    public static T VisualFmg<T>(this T self, IVisual visual) where T : VisualElement
    {
        self.SetValue(VisualElement.VisualProperty, visual);
        return self;
    }

    public static T VisualFmg<T>(this T self, Func<PropertyContext<IVisual>, IPropertyBuilder<IVisual>> configure) where T : VisualElement
    {
        PropertyContext<IVisual> arg = new PropertyContext<IVisual>(self, VisualElement.VisualProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> VisualFmg<T>(this SettersContext<T> self, IVisual visual) where T : VisualElement
    {
        self.XamlSetters.Add(new Setter
        {
            Property = VisualElement.VisualProperty,
            Value = visual
        });
        return self;
    }

    public static SettersContext<T> VisualFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<IVisual>, IPropertySettersBuilder<IVisual>> configure) where T : VisualElement
    {
        PropertySettersContext<IVisual> arg = new PropertySettersContext<IVisual>(self.XamlSetters, VisualElement.VisualProperty);
        configure(arg).Build();
        return self;
    }

    public static T FlowDirectionFmg<T>(this T self, FlowDirection flowDirection) where T : VisualElement
    {
        self.SetValue(VisualElement.FlowDirectionProperty, flowDirection);
        return self;
    }

    public static T FlowDirectionFmg<T>(this T self, Func<PropertyContext<FlowDirection>, IPropertyBuilder<FlowDirection>> configure) where T : VisualElement
    {
        PropertyContext<FlowDirection> arg = new PropertyContext<FlowDirection>(self, VisualElement.FlowDirectionProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> FlowDirectionFmg<T>(this SettersContext<T> self, FlowDirection flowDirection) where T : VisualElement
    {
        self.XamlSetters.Add(new Setter
        {
            Property = VisualElement.FlowDirectionProperty,
            Value = flowDirection
        });
        return self;
    }

    public static SettersContext<T> FlowDirectionFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<FlowDirection>, IPropertySettersBuilder<FlowDirection>> configure) where T : VisualElement
    {
        PropertySettersContext<FlowDirection> arg = new PropertySettersContext<FlowDirection>(self.XamlSetters, VisualElement.FlowDirectionProperty);
        configure(arg).Build();
        return self;
    }

    public static T AnchorXFmg<T>(this T self, double anchorX) where T : VisualElement
    {
        self.SetValue(VisualElement.AnchorXProperty, anchorX);
        return self;
    }

    public static T AnchorXFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure) where T : VisualElement
    {
        PropertyContext<double> arg = new PropertyContext<double>(self, VisualElement.AnchorXProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> AnchorXFmg<T>(this SettersContext<T> self, double anchorX) where T : VisualElement
    {
        self.XamlSetters.Add(new Setter
        {
            Property = VisualElement.AnchorXProperty,
            Value = anchorX
        });
        return self;
    }

    public static SettersContext<T> AnchorXFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure) where T : VisualElement
    {
        PropertySettersContext<double> arg = new PropertySettersContext<double>(self.XamlSetters, VisualElement.AnchorXProperty);
        configure(arg).Build();
        return self;
    }

    public static Task<bool> AnimateAnchorXToFmg<T>(this T self, double value, uint length = 250u, Easing? easing = null) where T : VisualElement
    {
        T self2 = self;
        double fromValue = self2.AnchorX;
        return Transformations.AnimateAsync(transform: (double t) => Transformations.DoubleTransform(fromValue, value, t), callback: delegate (double actValue)
        {
            self2.AnchorX = actValue;
        }, element: self2, name: "AnimateAnchorXTo", length: length, easing: easing);
    }

    public static T AnchorYFmg<T>(this T self, double anchorY) where T : VisualElement
    {
        self.SetValue(VisualElement.AnchorYProperty, anchorY);
        return self;
    }

    public static T AnchorYFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure) where T : VisualElement
    {
        PropertyContext<double> arg = new PropertyContext<double>(self, VisualElement.AnchorYProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> AnchorYFmg<T>(this SettersContext<T> self, double anchorY) where T : VisualElement
    {
        self.XamlSetters.Add(new Setter
        {
            Property = VisualElement.AnchorYProperty,
            Value = anchorY
        });
        return self;
    }

    public static SettersContext<T> AnchorYFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure) where T : VisualElement
    {
        PropertySettersContext<double> arg = new PropertySettersContext<double>(self.XamlSetters, VisualElement.AnchorYProperty);
        configure(arg).Build();
        return self;
    }

    public static Task<bool> AnimateAnchorYToFmg<T>(this T self, double value, uint length = 250u, Easing? easing = null) where T : VisualElement
    {
        T self2 = self;
        double fromValue = self2.AnchorY;
        return Transformations.AnimateAsync(transform: (double t) => Transformations.DoubleTransform(fromValue, value, t), callback: delegate (double actValue)
        {
            self2.AnchorY = actValue;
        }, element: self2, name: "AnimateAnchorYTo", length: length, easing: easing);
    }

    public static T BackgroundColorFmg<T>(this T self, Color backgroundColor) where T : VisualElement
    {
        self.SetValue(VisualElement.BackgroundColorProperty, backgroundColor);
        return self;
    }

    public static T BackgroundColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure) where T : VisualElement
    {
        PropertyContext<Color> arg = new PropertyContext<Color>(self, VisualElement.BackgroundColorProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> BackgroundColorFmg<T>(this SettersContext<T> self, Color backgroundColor) where T : VisualElement
    {
        self.XamlSetters.Add(new Setter
        {
            Property = VisualElement.BackgroundColorProperty,
            Value = backgroundColor
        });
        return self;
    }

    public static SettersContext<T> BackgroundColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure) where T : VisualElement
    {
        PropertySettersContext<Color> arg = new PropertySettersContext<Color>(self.XamlSetters, VisualElement.BackgroundColorProperty);
        configure(arg).Build();
        return self;
    }

    public static Task<bool> AnimateBackgroundColorToFmg<T>(this T self, Color value, uint length = 250u, Easing? easing = null) where T : VisualElement
    {
        Color value2 = value;
        T self2 = self;
        Color fromValue = self2.BackgroundColor;
        return Transformations.AnimateAsync(transform: (double t) => Transformations.ColorTransform(fromValue, value2, t), callback: delegate (Color actValue)
        {
            self2.BackgroundColor = actValue;
        }, element: self2, name: "AnimateBackgroundColorTo", length: length, easing: easing);
    }

    public static T BackgroundFmg<T>(this T self, Brush background) where T : VisualElement
    {
        self.SetValue(VisualElement.BackgroundProperty, background);
        return self;
    }

    public static T BackgroundFmg<T>(this T self, Func<PropertyContext<Brush>, IPropertyBuilder<Brush>> configure) where T : VisualElement
    {
        PropertyContext<Brush> arg = new PropertyContext<Brush>(self, VisualElement.BackgroundProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> BackgroundFmg<T>(this SettersContext<T> self, Brush background) where T : VisualElement
    {
        self.XamlSetters.Add(new Setter
        {
            Property = VisualElement.BackgroundProperty,
            Value = background
        });
        return self;
    }

    public static SettersContext<T> BackgroundFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Brush>, IPropertySettersBuilder<Brush>> configure) where T : VisualElement
    {
        PropertySettersContext<Brush> arg = new PropertySettersContext<Brush>(self.XamlSetters, VisualElement.BackgroundProperty);
        configure(arg).Build();
        return self;
    }

    public static T BehaviorsFmg<T>(this T self, IList<Behavior> behaviors) where T : VisualElement
    {
        foreach (Behavior behavior in behaviors)
        {
            self.Behaviors.Add(behavior);
        }

        return self;
    }

    public static T BehaviorsFmg<T>(this T self, params Behavior[] behaviors) where T : VisualElement
    {
        foreach (Behavior item in behaviors)
        {
            self.Behaviors.Add(item);
        }

        return self;
    }

    public static T BehaviorsFmg<T>(this T self, Func<PropertyContext<IList<Behavior>>, IPropertyBuilder<IList<Behavior>>> configure) where T : VisualElement
    {
        PropertyContext<IList<Behavior>> arg = new PropertyContext<IList<Behavior>>(self, VisualElement.BehaviorsProperty);
        configure(arg).Build();
        return self;
    }

    public static T HeightRequestFmg<T>(this T self, double heightRequest) where T : VisualElement
    {
        self.SetValue(VisualElement.HeightRequestProperty, heightRequest);
        return self;
    }

    public static T HeightRequestFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure) where T : VisualElement
    {
        PropertyContext<double> arg = new PropertyContext<double>(self, VisualElement.HeightRequestProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> HeightRequestFmg<T>(this SettersContext<T> self, double heightRequest) where T : VisualElement
    {
        self.XamlSetters.Add(new Setter
        {
            Property = VisualElement.HeightRequestProperty,
            Value = heightRequest
        });
        return self;
    }

    public static SettersContext<T> HeightRequestFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure) where T : VisualElement
    {
        PropertySettersContext<double> arg = new PropertySettersContext<double>(self.XamlSetters, VisualElement.HeightRequestProperty);
        configure(arg).Build();
        return self;
    }

    public static Task<bool> AnimateHeightRequestToFmg<T>(this T self, double value, uint length = 250u, Easing? easing = null) where T : VisualElement
    {
        T self2 = self;
        double fromValue = self2.HeightRequest;
        return Transformations.AnimateAsync(transform: (double t) => Transformations.DoubleTransform(fromValue, value, t), callback: delegate (double actValue)
        {
            self2.HeightRequest = actValue;
        }, element: self2, name: "AnimateHeightRequestTo", length: length, easing: easing);
    }

    public static T InputTransparentFmg<T>(this T self, bool inputTransparent) where T : VisualElement
    {
        self.SetValue(VisualElement.InputTransparentProperty, inputTransparent);
        return self;
    }

    public static T InputTransparentFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure) where T : VisualElement
    {
        PropertyContext<bool> arg = new PropertyContext<bool>(self, VisualElement.InputTransparentProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> InputTransparentFmg<T>(this SettersContext<T> self, bool inputTransparent) where T : VisualElement
    {
        self.XamlSetters.Add(new Setter
        {
            Property = VisualElement.InputTransparentProperty,
            Value = inputTransparent
        });
        return self;
    }

    public static SettersContext<T> InputTransparentFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure) where T : VisualElement
    {
        PropertySettersContext<bool> arg = new PropertySettersContext<bool>(self.XamlSetters, VisualElement.InputTransparentProperty);
        configure(arg).Build();
        return self;
    }

    public static T IsEnabledFmg<T>(this T self, bool isEnabled) where T : VisualElement
    {
        self.SetValue(VisualElement.IsEnabledProperty, isEnabled);
        return self;
    }

    public static T IsEnabledFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure) where T : VisualElement
    {
        PropertyContext<bool> arg = new PropertyContext<bool>(self, VisualElement.IsEnabledProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> IsEnabledFmg<T>(this SettersContext<T> self, bool isEnabled) where T : VisualElement
    {
        self.XamlSetters.Add(new Setter
        {
            Property = VisualElement.IsEnabledProperty,
            Value = isEnabled
        });
        return self;
    }

    public static SettersContext<T> IsEnabledFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure) where T : VisualElement
    {
        PropertySettersContext<bool> arg = new PropertySettersContext<bool>(self.XamlSetters, VisualElement.IsEnabledProperty);
        configure(arg).Build();
        return self;
    }

    public static T IsVisibleFmg<T>(this T self, bool isVisible) where T : VisualElement
    {
        self.SetValue(VisualElement.IsVisibleProperty, isVisible);
        return self;
    }

    public static T IsVisibleFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure) where T : VisualElement
    {
        PropertyContext<bool> arg = new PropertyContext<bool>(self, VisualElement.IsVisibleProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> IsVisibleFmg<T>(this SettersContext<T> self, bool isVisible) where T : VisualElement
    {
        self.XamlSetters.Add(new Setter
        {
            Property = VisualElement.IsVisibleProperty,
            Value = isVisible
        });
        return self;
    }

    public static SettersContext<T> IsVisibleFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure) where T : VisualElement
    {
        PropertySettersContext<bool> arg = new PropertySettersContext<bool>(self.XamlSetters, VisualElement.IsVisibleProperty);
        configure(arg).Build();
        return self;
    }

    public static T MinimumHeightRequestFmg<T>(this T self, double minimumHeightRequest) where T : VisualElement
    {
        self.SetValue(VisualElement.MinimumHeightRequestProperty, minimumHeightRequest);
        return self;
    }

    public static T MinimumHeightRequestFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure) where T : VisualElement
    {
        PropertyContext<double> arg = new PropertyContext<double>(self, VisualElement.MinimumHeightRequestProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> MinimumHeightRequestFmg<T>(this SettersContext<T> self, double minimumHeightRequest) where T : VisualElement
    {
        self.XamlSetters.Add(new Setter
        {
            Property = VisualElement.MinimumHeightRequestProperty,
            Value = minimumHeightRequest
        });
        return self;
    }

    public static SettersContext<T> MinimumHeightRequestFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure) where T : VisualElement
    {
        PropertySettersContext<double> arg = new PropertySettersContext<double>(self.XamlSetters, VisualElement.MinimumHeightRequestProperty);
        configure(arg).Build();
        return self;
    }

    public static Task<bool> AnimateMinimumHeightRequestToFmg<T>(this T self, double value, uint length = 250u, Easing? easing = null) where T : VisualElement
    {
        T self2 = self;
        double fromValue = self2.MinimumHeightRequest;
        return Transformations.AnimateAsync(transform: (double t) => Transformations.DoubleTransform(fromValue, value, t), callback: delegate (double actValue)
        {
            self2.MinimumHeightRequest = actValue;
        }, element: self2, name: "AnimateMinimumHeightRequestTo", length: length, easing: easing);
    }

    public static T MinimumWidthRequestFmg<T>(this T self, double minimumWidthRequest) where T : VisualElement
    {
        self.SetValue(VisualElement.MinimumWidthRequestProperty, minimumWidthRequest);
        return self;
    }

    public static T MinimumWidthRequestFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure) where T : VisualElement
    {
        PropertyContext<double> arg = new PropertyContext<double>(self, VisualElement.MinimumWidthRequestProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> MinimumWidthRequestFmg<T>(this SettersContext<T> self, double minimumWidthRequest) where T : VisualElement
    {
        self.XamlSetters.Add(new Setter
        {
            Property = VisualElement.MinimumWidthRequestProperty,
            Value = minimumWidthRequest
        });
        return self;
    }

    public static SettersContext<T> MinimumWidthRequestFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure) where T : VisualElement
    {
        PropertySettersContext<double> arg = new PropertySettersContext<double>(self.XamlSetters, VisualElement.MinimumWidthRequestProperty);
        configure(arg).Build();
        return self;
    }

    public static Task<bool> AnimateMinimumWidthRequestToFmg<T>(this T self, double value, uint length = 250u, Easing? easing = null) where T : VisualElement
    {
        T self2 = self;
        double fromValue = self2.MinimumWidthRequest;
        return Transformations.AnimateAsync(transform: (double t) => Transformations.DoubleTransform(fromValue, value, t), callback: delegate (double actValue)
        {
            self2.MinimumWidthRequest = actValue;
        }, element: self2, name: "AnimateMinimumWidthRequestTo", length: length, easing: easing);
    }

    public static T MaximumHeightRequestFmg<T>(this T self, double maximumHeightRequest) where T : VisualElement
    {
        self.SetValue(VisualElement.MaximumHeightRequestProperty, maximumHeightRequest);
        return self;
    }

    public static T MaximumHeightRequestFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure) where T : VisualElement
    {
        PropertyContext<double> arg = new PropertyContext<double>(self, VisualElement.MaximumHeightRequestProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> MaximumHeightRequestFmg<T>(this SettersContext<T> self, double maximumHeightRequest) where T : VisualElement
    {
        self.XamlSetters.Add(new Setter
        {
            Property = VisualElement.MaximumHeightRequestProperty,
            Value = maximumHeightRequest
        });
        return self;
    }

    public static SettersContext<T> MaximumHeightRequestFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure) where T : VisualElement
    {
        PropertySettersContext<double> arg = new PropertySettersContext<double>(self.XamlSetters, VisualElement.MaximumHeightRequestProperty);
        configure(arg).Build();
        return self;
    }

    public static Task<bool> AnimateMaximumHeightRequestToFmg<T>(this T self, double value, uint length = 250u, Easing? easing = null) where T : VisualElement
    {
        T self2 = self;
        double fromValue = self2.MaximumHeightRequest;
        return Transformations.AnimateAsync(transform: (double t) => Transformations.DoubleTransform(fromValue, value, t), callback: delegate (double actValue)
        {
            self2.MaximumHeightRequest = actValue;
        }, element: self2, name: "AnimateMaximumHeightRequestTo", length: length, easing: easing);
    }

    public static T MaximumWidthRequestFmg<T>(this T self, double maximumWidthRequest) where T : VisualElement
    {
        self.SetValue(VisualElement.MaximumWidthRequestProperty, maximumWidthRequest);
        return self;
    }

    public static T MaximumWidthRequestFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure) where T : VisualElement
    {
        PropertyContext<double> arg = new PropertyContext<double>(self, VisualElement.MaximumWidthRequestProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> MaximumWidthRequestFmg<T>(this SettersContext<T> self, double maximumWidthRequest) where T : VisualElement
    {
        self.XamlSetters.Add(new Setter
        {
            Property = VisualElement.MaximumWidthRequestProperty,
            Value = maximumWidthRequest
        });
        return self;
    }

    public static SettersContext<T> MaximumWidthRequestFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure) where T : VisualElement
    {
        PropertySettersContext<double> arg = new PropertySettersContext<double>(self.XamlSetters, VisualElement.MaximumWidthRequestProperty);
        configure(arg).Build();
        return self;
    }

    public static Task<bool> AnimateMaximumWidthRequestToFmg<T>(this T self, double value, uint length = 250u, Easing? easing = null) where T : VisualElement
    {
        T self2 = self;
        double fromValue = self2.MaximumWidthRequest;
        return Transformations.AnimateAsync(transform: (double t) => Transformations.DoubleTransform(fromValue, value, t), callback: delegate (double actValue)
        {
            self2.MaximumWidthRequest = actValue;
        }, element: self2, name: "AnimateMaximumWidthRequestTo", length: length, easing: easing);
    }

    public static T OpacityFmg<T>(this T self, double opacity) where T : VisualElement
    {
        self.SetValue(VisualElement.OpacityProperty, opacity);
        return self;
    }

    public static T OpacityFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure) where T : VisualElement
    {
        PropertyContext<double> arg = new PropertyContext<double>(self, VisualElement.OpacityProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> OpacityFmg<T>(this SettersContext<T> self, double opacity) where T : VisualElement
    {
        self.XamlSetters.Add(new Setter
        {
            Property = VisualElement.OpacityProperty,
            Value = opacity
        });
        return self;
    }

    public static SettersContext<T> OpacityFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure) where T : VisualElement
    {
        PropertySettersContext<double> arg = new PropertySettersContext<double>(self.XamlSetters, VisualElement.OpacityProperty);
        configure(arg).Build();
        return self;
    }

    public static Task<bool> AnimateOpacityToFmg<T>(this T self, double value, uint length = 250u, Easing? easing = null) where T : VisualElement
    {
        T self2 = self;
        double fromValue = self2.Opacity;
        return Transformations.AnimateAsync(transform: (double t) => Transformations.DoubleTransform(fromValue, value, t), callback: delegate (double actValue)
        {
            self2.Opacity = actValue;
        }, element: self2, name: "AnimateOpacityTo", length: length, easing: easing);
    }

    public static T RotationFmg<T>(this T self, double rotation) where T : VisualElement
    {
        self.SetValue(VisualElement.RotationProperty, rotation);
        return self;
    }

    public static T RotationFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure) where T : VisualElement
    {
        PropertyContext<double> arg = new PropertyContext<double>(self, VisualElement.RotationProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> RotationFmg<T>(this SettersContext<T> self, double rotation) where T : VisualElement
    {
        self.XamlSetters.Add(new Setter
        {
            Property = VisualElement.RotationProperty,
            Value = rotation
        });
        return self;
    }

    public static SettersContext<T> RotationFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure) where T : VisualElement
    {
        PropertySettersContext<double> arg = new PropertySettersContext<double>(self.XamlSetters, VisualElement.RotationProperty);
        configure(arg).Build();
        return self;
    }

    public static Task<bool> AnimateRotationToFmg<T>(this T self, double value, uint length = 250u, Easing? easing = null) where T : VisualElement
    {
        T self2 = self;
        double fromValue = self2.Rotation;
        return Transformations.AnimateAsync(transform: (double t) => Transformations.DoubleTransform(fromValue, value, t), callback: delegate (double actValue)
        {
            self2.Rotation = actValue;
        }, element: self2, name: "AnimateRotationTo", length: length, easing: easing);
    }

    public static T RotationXFmg<T>(this T self, double rotationX) where T : VisualElement
    {
        self.SetValue(VisualElement.RotationXProperty, rotationX);
        return self;
    }

    public static T RotationXFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure) where T : VisualElement
    {
        PropertyContext<double> arg = new PropertyContext<double>(self, VisualElement.RotationXProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> RotationXFmg<T>(this SettersContext<T> self, double rotationX) where T : VisualElement
    {
        self.XamlSetters.Add(new Setter
        {
            Property = VisualElement.RotationXProperty,
            Value = rotationX
        });
        return self;
    }

    public static SettersContext<T> RotationXFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure) where T : VisualElement
    {
        PropertySettersContext<double> arg = new PropertySettersContext<double>(self.XamlSetters, VisualElement.RotationXProperty);
        configure(arg).Build();
        return self;
    }

    public static Task<bool> AnimateRotationXToFmg<T>(this T self, double value, uint length = 250u, Easing? easing = null) where T : VisualElement
    {
        T self2 = self;
        double fromValue = self2.RotationX;
        return Transformations.AnimateAsync(transform: (double t) => Transformations.DoubleTransform(fromValue, value, t), callback: delegate (double actValue)
        {
            self2.RotationX = actValue;
        }, element: self2, name: "AnimateRotationXTo", length: length, easing: easing);
    }

    public static T RotationYFmg<T>(this T self, double rotationY) where T : VisualElement
    {
        self.SetValue(VisualElement.RotationYProperty, rotationY);
        return self;
    }

    public static T RotationYFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure) where T : VisualElement
    {
        PropertyContext<double> arg = new PropertyContext<double>(self, VisualElement.RotationYProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> RotationYFmg<T>(this SettersContext<T> self, double rotationY) where T : VisualElement
    {
        self.XamlSetters.Add(new Setter
        {
            Property = VisualElement.RotationYProperty,
            Value = rotationY
        });
        return self;
    }

    public static SettersContext<T> RotationYFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure) where T : VisualElement
    {
        PropertySettersContext<double> arg = new PropertySettersContext<double>(self.XamlSetters, VisualElement.RotationYProperty);
        configure(arg).Build();
        return self;
    }

    public static Task<bool> AnimateRotationYToFmg<T>(this T self, double value, uint length = 250u, Easing? easing = null) where T : VisualElement
    {
        T self2 = self;
        double fromValue = self2.RotationY;
        return Transformations.AnimateAsync(transform: (double t) => Transformations.DoubleTransform(fromValue, value, t), callback: delegate (double actValue)
        {
            self2.RotationY = actValue;
        }, element: self2, name: "AnimateRotationYTo", length: length, easing: easing);
    }

    public static T ScaleFmg<T>(this T self, double scale) where T : VisualElement
    {
        self.SetValue(VisualElement.ScaleProperty, scale);
        return self;
    }

    public static T ScaleFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure) where T : VisualElement
    {
        PropertyContext<double> arg = new PropertyContext<double>(self, VisualElement.ScaleProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> ScaleFmg<T>(this SettersContext<T> self, double scale) where T : VisualElement
    {
        self.XamlSetters.Add(new Setter
        {
            Property = VisualElement.ScaleProperty,
            Value = scale
        });
        return self;
    }

    public static SettersContext<T> ScaleFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure) where T : VisualElement
    {
        PropertySettersContext<double> arg = new PropertySettersContext<double>(self.XamlSetters, VisualElement.ScaleProperty);
        configure(arg).Build();
        return self;
    }

    public static Task<bool> AnimateScaleToFmg<T>(this T self, double value, uint length = 250u, Easing? easing = null) where T : VisualElement
    {
        T self2 = self;
        double fromValue = self2.Scale;
        return Transformations.AnimateAsync(transform: (double t) => Transformations.DoubleTransform(fromValue, value, t), callback: delegate (double actValue)
        {
            self2.Scale = actValue;
        }, element: self2, name: "AnimateScaleTo", length: length, easing: easing);
    }

    public static T ScaleXFmg<T>(this T self, double scaleX) where T : VisualElement
    {
        self.SetValue(VisualElement.ScaleXProperty, scaleX);
        return self;
    }

    public static T ScaleXFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure) where T : VisualElement
    {
        PropertyContext<double> arg = new PropertyContext<double>(self, VisualElement.ScaleXProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> ScaleXFmg<T>(this SettersContext<T> self, double scaleX) where T : VisualElement
    {
        self.XamlSetters.Add(new Setter
        {
            Property = VisualElement.ScaleXProperty,
            Value = scaleX
        });
        return self;
    }

    public static SettersContext<T> ScaleXFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure) where T : VisualElement
    {
        PropertySettersContext<double> arg = new PropertySettersContext<double>(self.XamlSetters, VisualElement.ScaleXProperty);
        configure(arg).Build();
        return self;
    }

    public static Task<bool> AnimateScaleXToFmg<T>(this T self, double value, uint length = 250u, Easing? easing = null) where T : VisualElement
    {
        T self2 = self;
        double fromValue = self2.ScaleX;
        return Transformations.AnimateAsync(transform: (double t) => Transformations.DoubleTransform(fromValue, value, t), callback: delegate (double actValue)
        {
            self2.ScaleX = actValue;
        }, element: self2, name: "AnimateScaleXTo", length: length, easing: easing);
    }

    public static T ScaleYFmg<T>(this T self, double scaleY) where T : VisualElement
    {
        self.SetValue(VisualElement.ScaleYProperty, scaleY);
        return self;
    }

    public static T ScaleYFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure) where T : VisualElement
    {
        PropertyContext<double> arg = new PropertyContext<double>(self, VisualElement.ScaleYProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> ScaleYFmg<T>(this SettersContext<T> self, double scaleY) where T : VisualElement
    {
        self.XamlSetters.Add(new Setter
        {
            Property = VisualElement.ScaleYProperty,
            Value = scaleY
        });
        return self;
    }

    public static SettersContext<T> ScaleYFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure) where T : VisualElement
    {
        PropertySettersContext<double> arg = new PropertySettersContext<double>(self.XamlSetters, VisualElement.ScaleYProperty);
        configure(arg).Build();
        return self;
    }

    public static Task<bool> AnimateScaleYToFmg<T>(this T self, double value, uint length = 250u, Easing? easing = null) where T : VisualElement
    {
        T self2 = self;
        double fromValue = self2.ScaleY;
        return Transformations.AnimateAsync(transform: (double t) => Transformations.DoubleTransform(fromValue, value, t), callback: delegate (double actValue)
        {
            self2.ScaleY = actValue;
        }, element: self2, name: "AnimateScaleYTo", length: length, easing: easing);
    }

    public static T TranslationXFmg<T>(this T self, double translationX) where T : VisualElement
    {
        self.SetValue(VisualElement.TranslationXProperty, translationX);
        return self;
    }

    public static T TranslationXFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure) where T : VisualElement
    {
        PropertyContext<double> arg = new PropertyContext<double>(self, VisualElement.TranslationXProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> TranslationXFmg<T>(this SettersContext<T> self, double translationX) where T : VisualElement
    {
        self.XamlSetters.Add(new Setter
        {
            Property = VisualElement.TranslationXProperty,
            Value = translationX
        });
        return self;
    }

    public static SettersContext<T> TranslationXFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure) where T : VisualElement
    {
        PropertySettersContext<double> arg = new PropertySettersContext<double>(self.XamlSetters, VisualElement.TranslationXProperty);
        configure(arg).Build();
        return self;
    }

    public static Task<bool> AnimateTranslationXToFmg<T>(this T self, double value, uint length = 250u, Easing? easing = null) where T : VisualElement
    {
        T self2 = self;
        double fromValue = self2.TranslationX;
        return Transformations.AnimateAsync(transform: (double t) => Transformations.DoubleTransform(fromValue, value, t), callback: delegate (double actValue)
        {
            self2.TranslationX = actValue;
        }, element: self2, name: "AnimateTranslationXTo", length: length, easing: easing);
    }

    public static T TranslationYFmg<T>(this T self, double translationY) where T : VisualElement
    {
        self.SetValue(VisualElement.TranslationYProperty, translationY);
        return self;
    }

    public static T TranslationYFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure) where T : VisualElement
    {
        PropertyContext<double> arg = new PropertyContext<double>(self, VisualElement.TranslationYProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> TranslationYFmg<T>(this SettersContext<T> self, double translationY) where T : VisualElement
    {
        self.XamlSetters.Add(new Setter
        {
            Property = VisualElement.TranslationYProperty,
            Value = translationY
        });
        return self;
    }

    public static SettersContext<T> TranslationYFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure) where T : VisualElement
    {
        PropertySettersContext<double> arg = new PropertySettersContext<double>(self.XamlSetters, VisualElement.TranslationYProperty);
        configure(arg).Build();
        return self;
    }

    public static Task<bool> AnimateTranslationYToFmg<T>(this T self, double value, uint length = 250u, Easing? easing = null) where T : VisualElement
    {
        T self2 = self;
        double fromValue = self2.TranslationY;
        return Transformations.AnimateAsync(transform: (double t) => Transformations.DoubleTransform(fromValue, value, t), callback: delegate (double actValue)
        {
            self2.TranslationY = actValue;
        }, element: self2, name: "AnimateTranslationYTo", length: length, easing: easing);
    }

    public static T TriggersFmg<T>(this T self, IList<TriggerBase> triggers) where T : VisualElement
    {
        foreach (TriggerBase trigger in triggers)
        {
            self.Triggers.Add(trigger);
        }

        return self;
    }

    public static T TriggersFmg<T>(this T self, params TriggerBase[] triggers) where T : VisualElement
    {
        foreach (TriggerBase item in triggers)
        {
            self.Triggers.Add(item);
        }

        return self;
    }

    public static T TriggersFmg<T>(this T self, Func<PropertyContext<IList<TriggerBase>>, IPropertyBuilder<IList<TriggerBase>>> configure) where T : VisualElement
    {
        PropertyContext<IList<TriggerBase>> arg = new PropertyContext<IList<TriggerBase>>(self, VisualElement.TriggersProperty);
        configure(arg).Build();
        return self;
    }

    public static T WidthRequestFmg<T>(this T self, double widthRequest) where T : VisualElement
    {
        self.SetValue(VisualElement.WidthRequestProperty, widthRequest);
        return self;
    }

    public static T WidthRequestFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure) where T : VisualElement
    {
        PropertyContext<double> arg = new PropertyContext<double>(self, VisualElement.WidthRequestProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> WidthRequestFmg<T>(this SettersContext<T> self, double widthRequest) where T : VisualElement
    {
        self.XamlSetters.Add(new Setter
        {
            Property = VisualElement.WidthRequestProperty,
            Value = widthRequest
        });
        return self;
    }

    public static SettersContext<T> WidthRequestFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure) where T : VisualElement
    {
        PropertySettersContext<double> arg = new PropertySettersContext<double>(self.XamlSetters, VisualElement.WidthRequestProperty);
        configure(arg).Build();
        return self;
    }

    public static Task<bool> AnimateWidthRequestToFmg<T>(this T self, double value, uint length = 250u, Easing? easing = null) where T : VisualElement
    {
        T self2 = self;
        double fromValue = self2.WidthRequest;
        return Transformations.AnimateAsync(transform: (double t) => Transformations.DoubleTransform(fromValue, value, t), callback: delegate (double actValue)
        {
            self2.WidthRequest = actValue;
        }, element: self2, name: "AnimateWidthRequestTo", length: length, easing: easing);
    }

    public static T ClipFmg<T>(this T self, Geometry clip) where T : VisualElement
    {
        self.SetValue(VisualElement.ClipProperty, clip);
        return self;
    }

    public static T ClipFmg<T>(this T self, Func<PropertyContext<Geometry>, IPropertyBuilder<Geometry>> configure) where T : VisualElement
    {
        PropertyContext<Geometry> arg = new PropertyContext<Geometry>(self, VisualElement.ClipProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> ClipFmg<T>(this SettersContext<T> self, Geometry clip) where T : VisualElement
    {
        self.XamlSetters.Add(new Setter
        {
            Property = VisualElement.ClipProperty,
            Value = clip
        });
        return self;
    }

    public static SettersContext<T> ClipFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Geometry>, IPropertySettersBuilder<Geometry>> configure) where T : VisualElement
    {
        PropertySettersContext<Geometry> arg = new PropertySettersContext<Geometry>(self.XamlSetters, VisualElement.ClipProperty);
        configure(arg).Build();
        return self;
    }

    public static T DisableLayoutFmg<T>(this T self, bool disableLayout) where T : VisualElement
    {
        self.DisableLayout = disableLayout;
        return self;
    }

    public static T IsInPlatformLayoutFmg<T>(this T self, bool isInPlatformLayout) where T : VisualElement
    {
        self.IsInPlatformLayout = isInPlatformLayout;
        return self;
    }

    public static T IsPlatformStateConsistentFmg<T>(this T self, bool isPlatformStateConsistent) where T : VisualElement
    {
        self.IsPlatformStateConsistent = isPlatformStateConsistent;
        return self;
    }

    public static T IsPlatformEnabledFmg<T>(this T self, bool isPlatformEnabled) where T : VisualElement
    {
        self.IsPlatformEnabled = isPlatformEnabled;
        return self;
    }

    public static T ResourcesFmg<T>(this T self, ResourceDictionary resources) where T : VisualElement
    {
        self.Resources = resources;
        return self;
    }

    public static T OnLoadedFmg<T>(this T self, EventHandler? handler) where T : VisualElement
    {
        self.Loaded += handler;
        return self;
    }

    public static T OnLoadedFmg<T>(this T self, Action<T> action) where T : VisualElement
    {
        Action<T> action2 = action;
        T self2 = self;
        self2.Loaded += delegate
        {
            action2(self2);
        };
        return self2;
    }

    public static T OnUnloadedFmg<T>(this T self, EventHandler? handler) where T : VisualElement
    {
        self.Unloaded += handler;
        return self;
    }

    public static T OnUnloadedFmg<T>(this T self, Action<T> action) where T : VisualElement
    {
        Action<T> action2 = action;
        T self2 = self;
        self2.Unloaded += delegate
        {
            action2(self2);
        };
        return self2;
    }

    public static T OnChildrenReorderedFmg<T>(this T self, EventHandler handler) where T : VisualElement
    {
        self.ChildrenReordered += handler;
        return self;
    }

    public static T OnChildrenReorderedFmg<T>(this T self, Action<T> action) where T : VisualElement
    {
        Action<T> action2 = action;
        T self2 = self;
        self2.ChildrenReordered += delegate
        {
            action2(self2);
        };
        return self2;
    }

    public static T OnFocusedFmg<T>(this T self, EventHandler<FocusEventArgs> handler) where T : VisualElement
    {
        self.Focused += handler;
        return self;
    }

    public static T OnFocusedFmg<T>(this T self, Action<T> action) where T : VisualElement
    {
        Action<T> action2 = action;
        T self2 = self;
        self2.Focused += delegate
        {
            action2(self2);
        };
        return self2;
    }

    public static T OnMeasureInvalidatedFmg<T>(this T self, EventHandler handler) where T : VisualElement
    {
        self.MeasureInvalidated += handler;
        return self;
    }

    public static T OnMeasureInvalidatedFmg<T>(this T self, Action<T> action) where T : VisualElement
    {
        Action<T> action2 = action;
        T self2 = self;
        self2.MeasureInvalidated += delegate
        {
            action2(self2);
        };
        return self2;
    }

    public static T OnSizeChangedFmg<T>(this T self, EventHandler handler) where T : VisualElement
    {
        self.SizeChanged += handler;
        return self;
    }

    public static T OnSizeChangedFmg<T>(this T self, Action<T> action) where T : VisualElement
    {
        Action<T> action2 = action;
        T self2 = self;
        self2.SizeChanged += delegate
        {
            action2(self2);
        };
        return self2;
    }

    public static T OnUnfocusedFmg<T>(this T self, EventHandler<FocusEventArgs> handler) where T : VisualElement
    {
        self.Unfocused += handler;
        return self;
    }

    public static T OnUnfocusedFmg<T>(this T self, Action<T> action) where T : VisualElement
    {
        Action<T> action2 = action;
        T self2 = self;
        self2.Unfocused += delegate
        {
            action2(self2);
        };
        return self2;
    }

    public static T OnBatchCommittedFmg<T>(this T self, EventHandler<EventArg<VisualElement>> handler) where T : VisualElement
    {
        self.BatchCommitted += handler;
        return self;
    }

    public static T OnBatchCommittedFmg<T>(this T self, Action<T> action) where T : VisualElement
    {
        Action<T> action2 = action;
        T self2 = self;
        self2.BatchCommitted += delegate
        {
            action2(self2);
        };
        return self2;
    }

    public static T OnFocusChangeRequestedFmg<T>(this T self, EventHandler<VisualElement.FocusRequestArgs> handler) where T : VisualElement
    {
        self.FocusChangeRequested += handler;
        return self;
    }

    public static T OnFocusChangeRequestedFmg<T>(this T self, Action<T> action) where T : VisualElement
    {
        Action<T> action2 = action;
        T self2 = self;
        self2.FocusChangeRequested += delegate
        {
            action2(self2);
        };
        return self2;
    }

    public static T VisualStateGroupsFmg<T>(this T self, VisualStateGroupList visualStateGroups) where T : VisualElement
    {
        self.SetValue(VisualStateManager.VisualStateGroupsProperty, visualStateGroups);
        return self;
    }

    public static T VisualStateGroupsFmg<T>(this T self, Func<PropertyContext<VisualStateGroupList>, IPropertyBuilder<VisualStateGroupList>> configure) where T : VisualElement
    {
        PropertyContext<VisualStateGroupList> arg = new PropertyContext<VisualStateGroupList>(self, VisualStateManager.VisualStateGroupsProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> VisualStateGroupsFmg<T>(this SettersContext<T> self, VisualStateGroupList visualStateGroups) where T : VisualElement
    {
        self.XamlSetters.Add(new Setter
        {
            Property = VisualStateManager.VisualStateGroupsProperty,
            Value = visualStateGroups
        });
        return self;
    }

    public static SettersContext<T> VisualStateGroupsFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<VisualStateGroupList>, IPropertySettersBuilder<VisualStateGroupList>> configure) where T : VisualElement
    {
        PropertySettersContext<VisualStateGroupList> arg = new PropertySettersContext<VisualStateGroupList>(self.XamlSetters, VisualStateManager.VisualStateGroupsProperty);
        configure(arg).Build();
        return self;
    }

    public static VisualStateGroupList GetVisualStateGroupsValueFmg<T>(this T self) where T : VisualElement
    {
        return (VisualStateGroupList)self.GetValue(VisualStateManager.VisualStateGroupsProperty);
    }

    public static T AutomationExcludedWithChildrenFmg<T>(this T self, bool? automationExcludedWithChildren) where T : VisualElement
    {
        self.SetValue(AutomationProperties.ExcludedWithChildrenProperty, automationExcludedWithChildren);
        return self;
    }

    public static T AutomationExcludedWithChildrenFmg<T>(this T self, Func<PropertyContext<bool?>, IPropertyBuilder<bool?>> configure) where T : VisualElement
    {
        PropertyContext<bool?> arg = new PropertyContext<bool?>(self, AutomationProperties.ExcludedWithChildrenProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> AutomationExcludedWithChildrenFmg<T>(this SettersContext<T> self, bool? automationExcludedWithChildren) where T : VisualElement
    {
        self.XamlSetters.Add(new Setter
        {
            Property = AutomationProperties.ExcludedWithChildrenProperty,
            Value = automationExcludedWithChildren
        });
        return self;
    }

    public static SettersContext<T> AutomationExcludedWithChildrenFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool?>, IPropertySettersBuilder<bool?>> configure) where T : VisualElement
    {
        PropertySettersContext<bool?> arg = new PropertySettersContext<bool?>(self.XamlSetters, AutomationProperties.ExcludedWithChildrenProperty);
        configure(arg).Build();
        return self;
    }

    public static bool? GetAutomationExcludedWithChildrenValueFmg<T>(this T self) where T : VisualElement
    {
        return (bool?)self.GetValue(AutomationProperties.ExcludedWithChildrenProperty);
    }

    public static T AutomationIsInAccessibleTreeFmg<T>(this T self, bool? automationIsInAccessibleTree) where T : VisualElement
    {
        self.SetValue(AutomationProperties.IsInAccessibleTreeProperty, automationIsInAccessibleTree);
        return self;
    }

    public static T AutomationIsInAccessibleTreeFmg<T>(this T self, Func<PropertyContext<bool?>, IPropertyBuilder<bool?>> configure) where T : VisualElement
    {
        PropertyContext<bool?> arg = new PropertyContext<bool?>(self, AutomationProperties.IsInAccessibleTreeProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> AutomationIsInAccessibleTreeFmg<T>(this SettersContext<T> self, bool? automationIsInAccessibleTree) where T : VisualElement
    {
        self.XamlSetters.Add(new Setter
        {
            Property = AutomationProperties.IsInAccessibleTreeProperty,
            Value = automationIsInAccessibleTree
        });
        return self;
    }

    public static SettersContext<T> AutomationIsInAccessibleTreeFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool?>, IPropertySettersBuilder<bool?>> configure) where T : VisualElement
    {
        PropertySettersContext<bool?> arg = new PropertySettersContext<bool?>(self.XamlSetters, AutomationProperties.IsInAccessibleTreeProperty);
        configure(arg).Build();
        return self;
    }

    public static bool? GetAutomationIsInAccessibleTreeValueFmg<T>(this T self) where T : VisualElement
    {
        return (bool?)self.GetValue(AutomationProperties.IsInAccessibleTreeProperty);
    }

    public static T AutomationNameFmg<T>(this T self, string automationName) where T : VisualElement
    {
        self.SetValue(AutomationProperties.NameProperty, automationName);
        return self;
    }

    public static T AutomationNameFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure) where T : VisualElement
    {
        PropertyContext<string> arg = new PropertyContext<string>(self, AutomationProperties.NameProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> AutomationNameFmg<T>(this SettersContext<T> self, string automationName) where T : VisualElement
    {
        self.XamlSetters.Add(new Setter
        {
            Property = AutomationProperties.NameProperty,
            Value = automationName
        });
        return self;
    }

    public static SettersContext<T> AutomationNameFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure) where T : VisualElement
    {
        PropertySettersContext<string> arg = new PropertySettersContext<string>(self.XamlSetters, AutomationProperties.NameProperty);
        configure(arg).Build();
        return self;
    }

    public static string GetAutomationNameValueFmg<T>(this T self) where T : VisualElement
    {
        return (string)self.GetValue(AutomationProperties.NameProperty);
    }

    public static T AutomationHelpTextFmg<T>(this T self, string automationHelpText) where T : VisualElement
    {
        self.SetValue(AutomationProperties.HelpTextProperty, automationHelpText);
        return self;
    }

    public static T AutomationHelpTextFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure) where T : VisualElement
    {
        PropertyContext<string> arg = new PropertyContext<string>(self, AutomationProperties.HelpTextProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> AutomationHelpTextFmg<T>(this SettersContext<T> self, string automationHelpText) where T : VisualElement
    {
        self.XamlSetters.Add(new Setter
        {
            Property = AutomationProperties.HelpTextProperty,
            Value = automationHelpText
        });
        return self;
    }

    public static SettersContext<T> AutomationHelpTextFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure) where T : VisualElement
    {
        PropertySettersContext<string> arg = new PropertySettersContext<string>(self.XamlSetters, AutomationProperties.HelpTextProperty);
        configure(arg).Build();
        return self;
    }

    public static string GetAutomationHelpTextValueFmg<T>(this T self) where T : VisualElement
    {
        return (string)self.GetValue(AutomationProperties.HelpTextProperty);
    }

    public static T AutomationLabeledByFmg<T>(this T self, VisualElement automationLabeledBy) where T : VisualElement
    {
        self.SetValue(AutomationProperties.LabeledByProperty, automationLabeledBy);
        return self;
    }

    public static T AutomationLabeledByFmg<T>(this T self, Func<PropertyContext<VisualElement>, IPropertyBuilder<VisualElement>> configure) where T : VisualElement
    {
        PropertyContext<VisualElement> arg = new PropertyContext<VisualElement>(self, AutomationProperties.LabeledByProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> AutomationLabeledByFmg<T>(this SettersContext<T> self, VisualElement automationLabeledBy) where T : VisualElement
    {
        self.XamlSetters.Add(new Setter
        {
            Property = AutomationProperties.LabeledByProperty,
            Value = automationLabeledBy
        });
        return self;
    }

    public static SettersContext<T> AutomationLabeledByFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<VisualElement>, IPropertySettersBuilder<VisualElement>> configure) where T : VisualElement
    {
        PropertySettersContext<VisualElement> arg = new PropertySettersContext<VisualElement>(self.XamlSetters, AutomationProperties.LabeledByProperty);
        configure(arg).Build();
        return self;
    }

    public static VisualElement GetAutomationLabeledByValueFmg<T>(this T self) where T : VisualElement
    {
        return (VisualElement)self.GetValue(AutomationProperties.LabeledByProperty);
    }

    public static T SemanticHintFmg<T>(this T self, string semanticHint) where T : VisualElement
    {
        self.SetValue(SemanticProperties.HintProperty, semanticHint);
        return self;
    }

    public static T SemanticHintFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure) where T : VisualElement
    {
        PropertyContext<string> arg = new PropertyContext<string>(self, SemanticProperties.HintProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> SemanticHintFmg<T>(this SettersContext<T> self, string semanticHint) where T : VisualElement
    {
        self.XamlSetters.Add(new Setter
        {
            Property = SemanticProperties.HintProperty,
            Value = semanticHint
        });
        return self;
    }

    public static SettersContext<T> SemanticHintFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure) where T : VisualElement
    {
        PropertySettersContext<string> arg = new PropertySettersContext<string>(self.XamlSetters, SemanticProperties.HintProperty);
        configure(arg).Build();
        return self;
    }

    public static string GetSemanticHintValueFmg<T>(this T self) where T : VisualElement
    {
        return (string)self.GetValue(SemanticProperties.HintProperty);
    }

    public static T SemanticDescriptionFmg<T>(this T self, string semanticDescription) where T : VisualElement
    {
        self.SetValue(SemanticProperties.DescriptionProperty, semanticDescription);
        return self;
    }

    public static T SemanticDescriptionFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure) where T : VisualElement
    {
        PropertyContext<string> arg = new PropertyContext<string>(self, SemanticProperties.DescriptionProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> SemanticDescriptionFmg<T>(this SettersContext<T> self, string semanticDescription) where T : VisualElement
    {
        self.XamlSetters.Add(new Setter
        {
            Property = SemanticProperties.DescriptionProperty,
            Value = semanticDescription
        });
        return self;
    }

    public static SettersContext<T> SemanticDescriptionFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure) where T : VisualElement
    {
        PropertySettersContext<string> arg = new PropertySettersContext<string>(self.XamlSetters, SemanticProperties.DescriptionProperty);
        configure(arg).Build();
        return self;
    }

    public static string GetSemanticDescriptionValueFmg<T>(this T self) where T : VisualElement
    {
        return (string)self.GetValue(SemanticProperties.DescriptionProperty);
    }

    public static T SemanticHeadingLevelFmg<T>(this T self, SemanticHeadingLevel semanticHeadingLevel) where T : VisualElement
    {
        self.SetValue(SemanticProperties.HeadingLevelProperty, semanticHeadingLevel);
        return self;
    }

    public static T SemanticHeadingLevelFmg<T>(this T self, Func<PropertyContext<SemanticHeadingLevel>, IPropertyBuilder<SemanticHeadingLevel>> configure) where T : VisualElement
    {
        PropertyContext<SemanticHeadingLevel> arg = new PropertyContext<SemanticHeadingLevel>(self, SemanticProperties.HeadingLevelProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> SemanticHeadingLevelFmg<T>(this SettersContext<T> self, SemanticHeadingLevel semanticHeadingLevel) where T : VisualElement
    {
        self.XamlSetters.Add(new Setter
        {
            Property = SemanticProperties.HeadingLevelProperty,
            Value = semanticHeadingLevel
        });
        return self;
    }

    public static SettersContext<T> SemanticHeadingLevelFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<SemanticHeadingLevel>, IPropertySettersBuilder<SemanticHeadingLevel>> configure) where T : VisualElement
    {
        PropertySettersContext<SemanticHeadingLevel> arg = new PropertySettersContext<SemanticHeadingLevel>(self.XamlSetters, SemanticProperties.HeadingLevelProperty);
        configure(arg).Build();
        return self;
    }

    public static SemanticHeadingLevel GetSemanticHeadingLevelValueFmg<T>(this T self) where T : VisualElement
    {
        return (SemanticHeadingLevel)self.GetValue(SemanticProperties.HeadingLevelProperty);
    }
}
