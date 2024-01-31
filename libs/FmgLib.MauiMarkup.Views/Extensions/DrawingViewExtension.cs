using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Views;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace FmgLib.MauiMarkup.Views;

public static partial class DrawingViewExtension
{
    public static T DrawActionFmg<T>(this T self, Action<ICanvas, RectF> action) where T : DrawingView
    {
        self.SetValue(DrawingView.DrawActionProperty, action);
        return self;
    }

    public static T DrawActionFmg<T>(this T self, Func<PropertyContext<Action<ICanvas, RectF>>, IPropertyBuilder<Action<ICanvas, RectF>>> configure) where T : DrawingView
    {
        PropertyContext<Action<ICanvas, RectF>> arg = new PropertyContext<Action<ICanvas, RectF>>(self, DrawingView.DrawActionProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> DrawActionFmg<T>(this SettersContext<T> self, Action<ICanvas, RectF> action) where T : DrawingView
    {
        self.XamlSetters.Add(new Setter
        {
            Property = DrawingView.DrawActionProperty,
            Value = action
        });
        return self;
    }

    public static SettersContext<T> DrawActionFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Action<ICanvas, RectF>>, IPropertySettersBuilder<Action<ICanvas, RectF>>> configure) where T : DrawingView
    {
        PropertySettersContext<Action<ICanvas, RectF>> arg = new PropertySettersContext<Action<ICanvas, RectF>>(self.XamlSetters, DrawingView.DrawActionProperty);
        configure(arg).Build();
        return self;
    }

    public static T ShouldClearOnFinishFmg<T>(this T self, bool shouldClearOnFinish) where T : DrawingView
    {
        self.SetValue(DrawingView.ShouldClearOnFinishProperty, shouldClearOnFinish);
        return self;
    }

    public static T ShouldClearOnFinishFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure) where T : DrawingView
    {
        PropertyContext<bool> arg = new PropertyContext<bool>(self, DrawingView.ShouldClearOnFinishProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> ShouldClearOnFinishFmg<T>(this SettersContext<T> self, bool shouldClearOnFinish) where T : DrawingView
    {
        self.XamlSetters.Add(new Setter
        {
            Property = DrawingView.ShouldClearOnFinishProperty,
            Value = shouldClearOnFinish
        });
        return self;
    }

    public static SettersContext<T> ShouldClearOnFinishFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure) where T : DrawingView
    {
        PropertySettersContext<bool> arg = new PropertySettersContext<bool>(self.XamlSetters, DrawingView.ShouldClearOnFinishProperty);
        configure(arg).Build();
        return self;
    }

    public static T IsMultiLineModeEnabledFmg<T>(this T self, bool isMultiLineModeEnabled) where T : DrawingView
    {
        self.SetValue(DrawingView.IsMultiLineModeEnabledProperty, isMultiLineModeEnabled);
        return self;
    }

    public static T IsMultiLineModeEnabledFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure) where T : DrawingView
    {
        PropertyContext<bool> arg = new PropertyContext<bool>(self, DrawingView.IsMultiLineModeEnabledProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> IsMultiLineModeEnabledFmg<T>(this SettersContext<T> self, bool isMultiLineModeEnabled) where T : DrawingView
    {
        self.XamlSetters.Add(new Setter
        {
            Property = DrawingView.IsMultiLineModeEnabledProperty,
            Value = isMultiLineModeEnabled
        });
        return self;
    }

    public static SettersContext<T> IsMultiLineModeEnabledFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure) where T : DrawingView
    {
        PropertySettersContext<bool> arg = new PropertySettersContext<bool>(self.XamlSetters, DrawingView.IsMultiLineModeEnabledProperty);
        configure(arg).Build();
        return self;
    }

    public static T LinesFmg<T>(this T self, ObservableCollection<IDrawingLine> lines) where T : DrawingView
    {
        self.SetValue(DrawingView.LinesProperty, lines);
        return self;
    }

    public static T LinesFmg<T>(this T self, Func<PropertyContext<ObservableCollection<IDrawingLine>>, IPropertyBuilder<ObservableCollection<IDrawingLine>>> configure) where T : DrawingView
    {
        PropertyContext<ObservableCollection<IDrawingLine>> arg = new PropertyContext<ObservableCollection<IDrawingLine>>(self, DrawingView.LinesProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> LinesFmg<T>(this SettersContext<T> self, ObservableCollection<IDrawingLine> lines) where T : DrawingView
    {
        self.XamlSetters.Add(new Setter
        {
            Property = DrawingView.LinesProperty,
            Value = lines
        });
        return self;
    }

    public static SettersContext<T> LinesFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ObservableCollection<IDrawingLine>>, IPropertySettersBuilder<ObservableCollection<IDrawingLine>>> configure) where T : DrawingView
    {
        PropertySettersContext<ObservableCollection<IDrawingLine>> arg = new PropertySettersContext<ObservableCollection<IDrawingLine>>(self.XamlSetters, DrawingView.LinesProperty);
        configure(arg).Build();
        return self;
    }

    public static T DrawingLineCompletedCommandFmg<T>(this T self, ICommand command) where T : DrawingView
    {
        self.SetValue(DrawingView.DrawingLineCompletedCommandProperty, command);
        return self;
    }

    public static T DrawingLineCompletedCommandFmg<T>(this T self, Func<PropertyContext<ICommand>, IPropertyBuilder<ICommand>> configure) where T : DrawingView
    {
        PropertyContext<ICommand> arg = new PropertyContext<ICommand>(self, DrawingView.DrawingLineCompletedCommandProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> DrawingLineCompletedCommandFmg<T>(this SettersContext<T> self, ICommand command) where T : DrawingView
    {
        self.XamlSetters.Add(new Setter
        {
            Property = DrawingView.DrawingLineCompletedCommandProperty,
            Value = command
        });
        return self;
    }

    public static SettersContext<T> DrawingLineCompletedCommandFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ICommand>, IPropertySettersBuilder<ICommand>> configure) where T : DrawingView
    {
        PropertySettersContext<ICommand> arg = new PropertySettersContext<ICommand>(self.XamlSetters, DrawingView.DrawingLineCompletedCommandProperty);
        configure(arg).Build();
        return self;
    }

    public static T DrawingLineStartedCommandFmg<T>(this T self, ICommand command) where T : DrawingView
    {
        self.SetValue(DrawingView.DrawingLineStartedCommandProperty, command);
        return self;
    }

    public static T DrawingLineStartedCommandFmg<T>(this T self, Func<PropertyContext<ICommand>, IPropertyBuilder<ICommand>> configure) where T : DrawingView
    {
        PropertyContext<ICommand> arg = new PropertyContext<ICommand>(self, DrawingView.DrawingLineStartedCommandProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> DrawingLineStartedCommandFmg<T>(this SettersContext<T> self, ICommand command) where T : DrawingView
    {
        self.XamlSetters.Add(new Setter
        {
            Property = DrawingView.DrawingLineStartedCommandProperty,
            Value = command
        });
        return self;
    }

    public static SettersContext<T> DrawingLineStartedCommandFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ICommand>, IPropertySettersBuilder<ICommand>> configure) where T : DrawingView
    {
        PropertySettersContext<ICommand> arg = new PropertySettersContext<ICommand>(self.XamlSetters, DrawingView.DrawingLineStartedCommandProperty);
        configure(arg).Build();
        return self;
    }

    public static T DrawingLineCancelledCommandFmg<T>(this T self, ICommand command) where T : DrawingView
    {
        self.SetValue(DrawingView.DrawingLineCancelledCommandProperty, command);
        return self;
    }

    public static T DrawingLineCancelledCommandFmg<T>(this T self, Func<PropertyContext<ICommand>, IPropertyBuilder<ICommand>> configure) where T : DrawingView
    {
        PropertyContext<ICommand> arg = new PropertyContext<ICommand>(self, DrawingView.DrawingLineCancelledCommandProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> DrawingLineCancelledCommandFmg<T>(this SettersContext<T> self, ICommand command) where T : DrawingView
    {
        self.XamlSetters.Add(new Setter
        {
            Property = DrawingView.DrawingLineCancelledCommandProperty,
            Value = command
        });
        return self;
    }

    public static SettersContext<T> DrawingLineCancelledCommandFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ICommand>, IPropertySettersBuilder<ICommand>> configure) where T : DrawingView
    {
        PropertySettersContext<ICommand> arg = new PropertySettersContext<ICommand>(self.XamlSetters, DrawingView.DrawingLineCancelledCommandProperty);
        configure(arg).Build();
        return self;
    }

    public static T PointDrawnCommandFmg<T>(this T self, ICommand command) where T : DrawingView
    {
        self.SetValue(DrawingView.PointDrawnCommandProperty, command);
        return self;
    }

    public static T PointDrawnCommandFmg<T>(this T self, Func<PropertyContext<ICommand>, IPropertyBuilder<ICommand>> configure) where T : DrawingView
    {
        PropertyContext<ICommand> arg = new PropertyContext<ICommand>(self, DrawingView.PointDrawnCommandProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> PointDrawnCommandFmg<T>(this SettersContext<T> self, ICommand command) where T : DrawingView
    {
        self.XamlSetters.Add(new Setter
        {
            Property = DrawingView.PointDrawnCommandProperty,
            Value = command
        });
        return self;
    }

    public static SettersContext<T> PointDrawnCommandFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ICommand>, IPropertySettersBuilder<ICommand>> configure) where T : DrawingView
    {
        PropertySettersContext<ICommand> arg = new PropertySettersContext<ICommand>(self.XamlSetters, DrawingView.PointDrawnCommandProperty);
        configure(arg).Build();
        return self;
    }

    public static T LineColorFmg<T>(this T self, Color color) where T : DrawingView
    {
        self.SetValue(DrawingView.LineColorProperty, color);
        return self;
    }

    public static T LineColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure) where T : DrawingView
    {
        PropertyContext<Color> arg = new PropertyContext<Color>(self, DrawingView.LineColorProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> LineColorFmg<T>(this SettersContext<T> self, Color color) where T : DrawingView
    {
        self.XamlSetters.Add(new Setter
        {
            Property = DrawingView.LineColorProperty,
            Value = color
        });
        return self;
    }

    public static SettersContext<T> LineColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure) where T : DrawingView
    {
        PropertySettersContext<Color> arg = new PropertySettersContext<Color>(self.XamlSetters, DrawingView.LineColorProperty);
        configure(arg).Build();
        return self;
    }

    public static T LineWidthFmg<T>(this T self, float width) where T : DrawingView
    {
        self.SetValue(DrawingView.LineWidthProperty, width);
        return self;
    }

    public static T LineWidthFmg<T>(this T self, Func<PropertyContext<float>, IPropertyBuilder<float>> configure) where T : DrawingView
    {
        PropertyContext<float> arg = new PropertyContext<float>(self, DrawingView.LineWidthProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> LineWidthFmg<T>(this SettersContext<T> self, float width) where T : DrawingView
    {
        self.XamlSetters.Add(new Setter
        {
            Property = DrawingView.LineWidthProperty,
            Value = width
        });
        return self;
    }

    public static SettersContext<T> LineWidthFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<float>, IPropertySettersBuilder<float>> configure) where T : DrawingView
    {
        PropertySettersContext<float> arg = new PropertySettersContext<float>(self.XamlSetters, DrawingView.LineWidthProperty);
        configure(arg).Build();
        return self;
    }
}
