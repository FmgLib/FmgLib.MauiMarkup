﻿using Microsoft.Maui.Layouts;

namespace FmgLib.MauiMarkup;

public static partial class ViewExtension
{
    public static T GridSpan<T>(this T self, int column = 1, int row = 1) where T : View
    {
        self.SetValue(Grid.ColumnSpanProperty, column);
        self.SetValue(Grid.RowSpanProperty, row);
        return self;
    }

    public static T Padding<T>(this T self, double horizontalSize, double verticalSize) where T : Border
    {
        self.SetValue(Border.PaddingProperty, new Thickness(horizontalSize, verticalSize));
        return self;
    }

    public static T Padding<T>(this T self, double left, double top, double right, double bottom) where T : Border
    {
        self.SetValue(Border.PaddingProperty, new Thickness(left, top, right, bottom));
        return self;
    }

    public static T Padding<T>(this T self, object _ = null, double left = 0.0, double top = 0.0, double right = 0.0, double bottom = 0.0) where T : Border
    {
        self.SetValue(Border.PaddingProperty, new Thickness(left, top, right, bottom));
        return self;
    }

    public static T Margin<T>(this T self, double horizontalSize, double verticalSize) where T : View
    {
        self.SetValue(View.MarginProperty, new Thickness(horizontalSize, verticalSize));
        return self;
    }

    public static T Margin<T>(this T self, double left, double top, double right, double bottom) where T : View
    {
        self.SetValue(View.MarginProperty, new Thickness(left, top, right, bottom));
        return self;
    }

    public static T Margin<T>(this T self, object _ = null, double left = 0.0, double top = 0.0, double right = 0.0, double bottom = 0.0) where T : View
    {
        self.SetValue(View.MarginProperty, new Thickness(left, top, right, bottom));
        return self;
    }

    public static T AbsoluteLayoutBounds<T>(this T self, double x, double y, double width, double height) where T : View
    {
        self.SetValue(AbsoluteLayout.LayoutBoundsProperty, new Rect(x, y, width, height));
        return self;
    }

    public static T CenterHorizontally<T>(this T self) where T : View
    {
        self.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Center);
        return self;
    }

    public static T CenterVertically<T>(this T self) where T : View
    {
        self.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
        return self;
    }

    public static T Center<T>(this T self) where T : View
    {
        self.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Center);
        self.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
        return self;
    }

    public static T AlignTop<T>(this T self) where T : View
    {
        self.SetValue(View.VerticalOptionsProperty, LayoutOptions.Start);
        return self;
    }

    public static T AlignTopStart<T>(this T self) where T : View
    {
        self.SetValue(View.VerticalOptionsProperty, LayoutOptions.Start);
        self.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Start);
        return self;
    }

    public static T AlignTopEnd<T>(this T self) where T : View
    {
        self.SetValue(View.VerticalOptionsProperty, LayoutOptions.Start);
        self.SetValue(View.HorizontalOptionsProperty, LayoutOptions.End);
        return self;
    }

    public static T AlignBottom<T>(this T self) where T : View
    {
        self.SetValue(View.VerticalOptionsProperty, LayoutOptions.End);
        return self;
    }

    public static T AlignBottomStart<T>(this T self) where T : View
    {
        self.SetValue(View.VerticalOptionsProperty, LayoutOptions.End);
        self.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Start);
        return self;
    }

    public static T AlignBottomEnd<T>(this T self) where T : View
    {
        self.SetValue(View.VerticalOptionsProperty, LayoutOptions.End);
        self.SetValue(View.HorizontalOptionsProperty, LayoutOptions.End);
        return self;
    }

    public static T AlignStart<T>(this T self) where T : View
    {
        self.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Start);
        return self;
    }

    public static T AlignEnd<T>(this T self) where T : View
    {
        self.SetValue(View.HorizontalOptionsProperty, LayoutOptions.End);
        return self;
    }

    public static T FillHorizontally<T>(this T self) where T : View
    {
        self.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Fill);
        return self;
    }

    public static T FillVertically<T>(this T self) where T : View
    {
        self.SetValue(View.VerticalOptionsProperty, LayoutOptions.Fill);
        return self;
    }

    public static T FillBothDirections<T>(this T self) where T : View
    {
        self.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Fill);
        self.SetValue(View.VerticalOptionsProperty, LayoutOptions.Fill);
        return self;
    }

    public static SettersContext<T> GridSpan<T>(this SettersContext<T> self, int column = 1, int row = 1) where T : View
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Grid.ColumnSpanProperty,
            Value = column
        });
        self.XamlSetters.Add(new Setter
        {
            Property = Grid.RowSpanProperty,
            Value = row
        });
        return self;
    }

    public static SettersContext<T> Padding<T>(this SettersContext<T> self, double horizontalSize, double verticalSize) where T : Border
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Border.PaddingProperty,
            Value = new Thickness(horizontalSize, verticalSize)
        });
        return self;
    }

    public static SettersContext<T> Padding<T>(this SettersContext<T> self, double left, double top, double right, double bottom) where T : Border
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Border.PaddingProperty,
            Value = new Thickness(left, top, right, bottom)
        });
        return self;
    }

    public static SettersContext<T> Padding<T>(this SettersContext<T> self, object _ = null, double left = 0.0, double top = 0.0, double right = 0.0, double bottom = 0.0) where T : Border
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Border.PaddingProperty,
            Value = new Thickness(left, top, right, bottom)
        });
        return self;
    }

    public static SettersContext<T> Margin<T>(this SettersContext<T> self, double horizontalSize, double verticalSize) where T : View
    {
        self.XamlSetters.Add(new Setter
        {
            Property = View.MarginProperty,
            Value = new Thickness(horizontalSize, verticalSize)
        });
        return self;
    }

    public static SettersContext<T> Margin<T>(this SettersContext<T> self, double left, double top, double right, double bottom) where T : View
    {
        self.XamlSetters.Add(new Setter
        {
            Property = View.MarginProperty,
            Value = new Thickness(left, top, right, bottom)
        });
        return self;
    }

    public static SettersContext<T> Margin<T>(this SettersContext<T> self, object _ = null, double left = 0.0, double top = 0.0, double right = 0.0, double bottom = 0.0) where T : View
    {
        self.XamlSetters.Add(new Setter
        {
            Property = View.MarginProperty,
            Value = new Thickness(left, top, right, bottom)
        });
        return self;
    }

    public static SettersContext<T> AbsoluteLayoutBounds<T>(this SettersContext<T> self, double x, double y, double width, double height) where T : View
    {
        self.XamlSetters.Add(new Setter
        {
            Property = AbsoluteLayout.LayoutBoundsProperty,
            Value = new Rect(x, y, width, height)
        });
        return self;
    }

    public static SettersContext<T> CenterHorizontally<T>(this SettersContext<T> self) where T : View
    {
        self.XamlSetters.Add(new Setter
        {
            Property = View.HorizontalOptionsProperty,
            Value = LayoutOptions.Center
        });
        return self;
    }

    public static SettersContext<T> CenterVertically<T>(this SettersContext<T> self) where T : View
    {
        self.XamlSetters.Add(new Setter
        {
            Property = View.VerticalOptionsProperty,
            Value = LayoutOptions.Center
        });
        return self;
    }

    public static SettersContext<T> Center<T>(this SettersContext<T> self) where T : View
    {
        self.XamlSetters.Add(new Setter
        {
            Property = View.HorizontalOptionsProperty,
            Value = LayoutOptions.Center
        });
        self.XamlSetters.Add(new Setter
        {
            Property = View.VerticalOptionsProperty,
            Value = LayoutOptions.Center
        });
        return self;
    }

    public static SettersContext<T> AlignTop<T>(this SettersContext<T> self) where T : View
    {
        self.XamlSetters.Add(new Setter
        {
            Property = View.VerticalOptionsProperty,
            Value = LayoutOptions.Start
        });
        return self;
    }

    public static SettersContext<T> AlignTopStart<T>(this SettersContext<T> self) where T : View
    {
        self.XamlSetters.Add(new Setter
        {
            Property = View.VerticalOptionsProperty,
            Value = LayoutOptions.Start
        });
        self.XamlSetters.Add(new Setter
        {
            Property = View.HorizontalOptionsProperty,
            Value = LayoutOptions.Start
        });
        return self;
    }

    public static SettersContext<T> AlignTopEnd<T>(this SettersContext<T> self) where T : View
    {
        self.XamlSetters.Add(new Setter
        {
            Property = View.VerticalOptionsProperty,
            Value = LayoutOptions.Start
        });
        self.XamlSetters.Add(new Setter
        {
            Property = View.HorizontalOptionsProperty,
            Value = LayoutOptions.End
        });
        return self;
    }

    public static SettersContext<T> AlignBottom<T>(this SettersContext<T> self) where T : View
    {
        self.XamlSetters.Add(new Setter
        {
            Property = View.VerticalOptionsProperty,
            Value = LayoutOptions.End
        });
        return self;
    }

    public static SettersContext<T> AlignBottomStart<T>(this SettersContext<T> self) where T : View
    {
        self.XamlSetters.Add(new Setter
        {
            Property = View.VerticalOptionsProperty,
            Value = LayoutOptions.End
        });
        self.XamlSetters.Add(new Setter
        {
            Property = View.HorizontalOptionsProperty,
            Value = LayoutOptions.Start
        });
        return self;
    }

    public static SettersContext<T> AlignBottomEnd<T>(this SettersContext<T> self) where T : View
    {
        self.XamlSetters.Add(new Setter
        {
            Property = View.VerticalOptionsProperty,
            Value = LayoutOptions.End
        });
        self.XamlSetters.Add(new Setter
        {
            Property = View.HorizontalOptionsProperty,
            Value = LayoutOptions.End
        });
        return self;
    }

    public static SettersContext<T> AlignStart<T>(this SettersContext<T> self) where T : View
    {
        self.XamlSetters.Add(new Setter
        {
            Property = View.HorizontalOptionsProperty,
            Value = LayoutOptions.Start
        });
        return self;
    }

    public static SettersContext<T> AlignEnd<T>(this SettersContext<T> self) where T : View
    {
        self.XamlSetters.Add(new Setter
        {
            Property = View.HorizontalOptionsProperty,
            Value = LayoutOptions.End
        });
        return self;
    }

    public static SettersContext<T> FillHorizontally<T>(this SettersContext<T> self) where T : View
    {
        self.XamlSetters.Add(new Setter
        {
            Property = View.HorizontalOptionsProperty,
            Value = LayoutOptions.Fill
        });
        return self;
    }

    public static SettersContext<T> FillVertically<T>(this SettersContext<T> self) where T : View
    {
        self.XamlSetters.Add(new Setter
        {
            Property = View.VerticalOptionsProperty,
            Value = LayoutOptions.Fill
        });
        return self;
    }

    public static SettersContext<T> FillBothDirections<T>(this SettersContext<T> self) where T : View
    {
        self.XamlSetters.Add(new Setter
        {
            Property = View.HorizontalOptionsProperty,
            Value = LayoutOptions.Fill
        });
        self.XamlSetters.Add(new Setter
        {
            Property = View.VerticalOptionsProperty,
            Value = LayoutOptions.Fill
        });
        return self;
    }

    public static T GestureRecognizers<T>(this T self, IList<IGestureRecognizer> gestureRecognizers) where T : View
    {
        foreach (IGestureRecognizer gestureRecognizer in gestureRecognizers)
        {
            self.GestureRecognizers.Add(gestureRecognizer);
        }

        return self;
    }

    public static T GestureRecognizers<T>(this T self, params IGestureRecognizer[] gestureRecognizers) where T : View
    {
        foreach (IGestureRecognizer item in gestureRecognizers)
        {
            self.GestureRecognizers.Add(item);
        }

        return self;
    }

    public static T HorizontalOptions<T>(this T self, LayoutOptions horizontalOptions) where T : View
    {
        self.SetValue(View.HorizontalOptionsProperty, horizontalOptions);
        return self;
    }

    public static T HorizontalOptions<T>(this T self, Func<PropertyContext<LayoutOptions>, IPropertyBuilder<LayoutOptions>> configure) where T : View
    {
        PropertyContext<LayoutOptions> arg = new PropertyContext<LayoutOptions>(self, View.HorizontalOptionsProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> HorizontalOptions<T>(this SettersContext<T> self, LayoutOptions horizontalOptions) where T : View
    {
        self.XamlSetters.Add(new Setter
        {
            Property = View.HorizontalOptionsProperty,
            Value = horizontalOptions
        });
        return self;
    }

    public static SettersContext<T> HorizontalOptions<T>(this SettersContext<T> self, Func<PropertySettersContext<LayoutOptions>, IPropertySettersBuilder<LayoutOptions>> configure) where T : View
    {
        PropertySettersContext<LayoutOptions> arg = new PropertySettersContext<LayoutOptions>(self.XamlSetters, View.HorizontalOptionsProperty);
        configure(arg).Build();
        return self;
    }

    public static T Margin<T>(this T self, Thickness margin) where T : View
    {
        self.SetValue(View.MarginProperty, margin);
        return self;
    }

    public static T Margin<T>(this T self, Func<PropertyContext<Thickness>, IPropertyBuilder<Thickness>> configure) where T : View
    {
        PropertyContext<Thickness> arg = new PropertyContext<Thickness>(self, View.MarginProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> Margin<T>(this SettersContext<T> self, Thickness margin) where T : View
    {
        self.XamlSetters.Add(new Setter
        {
            Property = View.MarginProperty,
            Value = margin
        });
        return self;
    }

    public static SettersContext<T> Margin<T>(this SettersContext<T> self, Func<PropertySettersContext<Thickness>, IPropertySettersBuilder<Thickness>> configure) where T : View
    {
        PropertySettersContext<Thickness> arg = new PropertySettersContext<Thickness>(self.XamlSetters, View.MarginProperty);
        configure(arg).Build();
        return self;
    }

    public static T VerticalOptions<T>(this T self, LayoutOptions verticalOptions) where T : View
    {
        self.SetValue(View.VerticalOptionsProperty, verticalOptions);
        return self;
    }

    public static T VerticalOptions<T>(this T self, Func<PropertyContext<LayoutOptions>, IPropertyBuilder<LayoutOptions>> configure) where T : View
    {
        PropertyContext<LayoutOptions> arg = new PropertyContext<LayoutOptions>(self, View.VerticalOptionsProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> VerticalOptions<T>(this SettersContext<T> self, LayoutOptions verticalOptions) where T : View
    {
        self.XamlSetters.Add(new Setter
        {
            Property = View.VerticalOptionsProperty,
            Value = verticalOptions
        });
        return self;
    }

    public static SettersContext<T> VerticalOptions<T>(this SettersContext<T> self, Func<PropertySettersContext<LayoutOptions>, IPropertySettersBuilder<LayoutOptions>> configure) where T : View
    {
        PropertySettersContext<LayoutOptions> arg = new PropertySettersContext<LayoutOptions>(self.XamlSetters, View.VerticalOptionsProperty);
        configure(arg).Build();
        return self;
    }

    public static T Column<T>(this T self, int column) where T : View
    {
        self.SetValue(Grid.ColumnProperty, column);
        return self;
    }

    public static T Column<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure) where T : View
    {
        PropertyContext<int> arg = new PropertyContext<int>(self, Grid.ColumnProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> Column<T>(this SettersContext<T> self, int column) where T : View
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Grid.ColumnProperty,
            Value = column
        });
        return self;
    }

    public static SettersContext<T> Column<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure) where T : View
    {
        PropertySettersContext<int> arg = new PropertySettersContext<int>(self.XamlSetters, Grid.ColumnProperty);
        configure(arg).Build();
        return self;
    }

    public static int GetColumnValue<T>(this T self) where T : View
    {
        return (int)self.GetValue(Grid.ColumnProperty);
    }

    public static T Row<T>(this T self, int row) where T : View
    {
        self.SetValue(Grid.RowProperty, row);
        return self;
    }

    public static T Row<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure) where T : View
    {
        PropertyContext<int> arg = new PropertyContext<int>(self, Grid.RowProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> Row<T>(this SettersContext<T> self, int row) where T : View
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Grid.RowProperty,
            Value = row
        });
        return self;
    }

    public static SettersContext<T> Row<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure) where T : View
    {
        PropertySettersContext<int> arg = new PropertySettersContext<int>(self.XamlSetters, Grid.RowProperty);
        configure(arg).Build();
        return self;
    }

    public static int GetRowValue<T>(this T self) where T : View
    {
        return (int)self.GetValue(Grid.RowProperty);
    }

    public static T ColumnSpan<T>(this T self, int columnSpan) where T : View
    {
        self.SetValue(Grid.ColumnSpanProperty, columnSpan);
        return self;
    }

    public static T ColumnSpan<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure) where T : View
    {
        PropertyContext<int> arg = new PropertyContext<int>(self, Grid.ColumnSpanProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> ColumnSpan<T>(this SettersContext<T> self, int columnSpan) where T : View
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Grid.ColumnSpanProperty,
            Value = columnSpan
        });
        return self;
    }

    public static SettersContext<T> ColumnSpan<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure) where T : View
    {
        PropertySettersContext<int> arg = new PropertySettersContext<int>(self.XamlSetters, Grid.ColumnSpanProperty);
        configure(arg).Build();
        return self;
    }

    public static int GetColumnSpanValue<T>(this T self) where T : View
    {
        return (int)self.GetValue(Grid.ColumnSpanProperty);
    }

    public static T RowSpan<T>(this T self, int rowSpan) where T : View
    {
        self.SetValue(Grid.RowSpanProperty, rowSpan);
        return self;
    }

    public static T RowSpan<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure) where T : View
    {
        PropertyContext<int> arg = new PropertyContext<int>(self, Grid.RowSpanProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> RowSpan<T>(this SettersContext<T> self, int rowSpan) where T : View
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Grid.RowSpanProperty,
            Value = rowSpan
        });
        return self;
    }

    public static SettersContext<T> RowSpan<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure) where T : View
    {
        PropertySettersContext<int> arg = new PropertySettersContext<int>(self.XamlSetters, Grid.RowSpanProperty);
        configure(arg).Build();
        return self;
    }

    public static int GetRowSpanValue<T>(this T self) where T : View
    {
        return (int)self.GetValue(Grid.RowSpanProperty);
    }

    public static T AbsoluteLayoutFlags<T>(this T self, AbsoluteLayoutFlags absoluteLayoutFlags) where T : View
    {
        self.SetValue(AbsoluteLayout.LayoutFlagsProperty, absoluteLayoutFlags);
        return self;
    }

    public static T AbsoluteLayoutFlags<T>(this T self, Func<PropertyContext<AbsoluteLayoutFlags>, IPropertyBuilder<AbsoluteLayoutFlags>> configure) where T : View
    {
        PropertyContext<AbsoluteLayoutFlags> arg = new PropertyContext<AbsoluteLayoutFlags>(self, AbsoluteLayout.LayoutFlagsProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> AbsoluteLayoutFlags<T>(this SettersContext<T> self, AbsoluteLayoutFlags absoluteLayoutFlags) where T : View
    {
        self.XamlSetters.Add(new Setter
        {
            Property = AbsoluteLayout.LayoutFlagsProperty,
            Value = absoluteLayoutFlags
        });
        return self;
    }

    public static SettersContext<T> AbsoluteLayoutFlags<T>(this SettersContext<T> self, Func<PropertySettersContext<AbsoluteLayoutFlags>, IPropertySettersBuilder<AbsoluteLayoutFlags>> configure) where T : View
    {
        PropertySettersContext<AbsoluteLayoutFlags> arg = new PropertySettersContext<AbsoluteLayoutFlags>(self.XamlSetters, AbsoluteLayout.LayoutFlagsProperty);
        configure(arg).Build();
        return self;
    }

    public static AbsoluteLayoutFlags GetAbsoluteLayoutFlagsValue<T>(this T self) where T : View
    {
        return (AbsoluteLayoutFlags)self.GetValue(AbsoluteLayout.LayoutFlagsProperty);
    }

    public static T AbsoluteLayoutBounds<T>(this T self, Rect absoluteLayoutBounds) where T : View
    {
        self.SetValue(AbsoluteLayout.LayoutBoundsProperty, absoluteLayoutBounds);
        return self;
    }

    public static T AbsoluteLayoutBounds<T>(this T self, Func<PropertyContext<Rect>, IPropertyBuilder<Rect>> configure) where T : View
    {
        PropertyContext<Rect> arg = new PropertyContext<Rect>(self, AbsoluteLayout.LayoutBoundsProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> AbsoluteLayoutBounds<T>(this SettersContext<T> self, Rect absoluteLayoutBounds) where T : View
    {
        self.XamlSetters.Add(new Setter
        {
            Property = AbsoluteLayout.LayoutBoundsProperty,
            Value = absoluteLayoutBounds
        });
        return self;
    }

    public static SettersContext<T> AbsoluteLayoutBounds<T>(this SettersContext<T> self, Func<PropertySettersContext<Rect>, IPropertySettersBuilder<Rect>> configure) where T : View
    {
        PropertySettersContext<Rect> arg = new PropertySettersContext<Rect>(self.XamlSetters, AbsoluteLayout.LayoutBoundsProperty);
        configure(arg).Build();
        return self;
    }

    public static Rect GetAbsoluteLayoutBoundsValue<T>(this T self) where T : View
    {
        return (Rect)self.GetValue(AbsoluteLayout.LayoutBoundsProperty);
    }

}
