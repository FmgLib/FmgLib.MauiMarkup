using CommunityToolkit.Maui.Behaviors;

namespace FmgLib.MauiMarkup.Views;

public static partial class NumericValidationBehaviorExtension
{
    public static T MinimumValueFmg<T>(this T self, double minVal) where T : NumericValidationBehavior
    {
        self.SetValue(NumericValidationBehavior.MinimumValueProperty, minVal);
        return self;
    }

    public static T MinimumValueFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure) where T : NumericValidationBehavior
    {
        PropertyContext<double> arg = new PropertyContext<double>(self, NumericValidationBehavior.MinimumValueProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> MinimumValueFmg<T>(this SettersContext<T> self, double minVal) where T : NumericValidationBehavior
    {
        self.XamlSetters.Add(new Setter
        {
            Property = NumericValidationBehavior.MinimumValueProperty,
            Value = minVal
        });
        return self;
    }

    public static SettersContext<T> MinimumValueFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure) where T : NumericValidationBehavior
    {
        PropertySettersContext<double> arg = new PropertySettersContext<double>(self.XamlSetters, NumericValidationBehavior.MinimumValueProperty);
        configure(arg).Build();
        return self;
    }

    public static T MaximumValueFmg<T>(this T self, double maxVal) where T : NumericValidationBehavior
    {
        self.SetValue(NumericValidationBehavior.MaximumValueProperty, maxVal);
        return self;
    }

    public static T MaximumValueFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure) where T : NumericValidationBehavior
    {
        PropertyContext<double> arg = new PropertyContext<double>(self, NumericValidationBehavior.MaximumValueProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> MaximumValueFmg<T>(this SettersContext<T> self, double maxVal) where T : NumericValidationBehavior
    {
        self.XamlSetters.Add(new Setter
        {
            Property = NumericValidationBehavior.MaximumValueProperty,
            Value = maxVal
        });
        return self;
    }

    public static SettersContext<T> MaximumValueFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure) where T : NumericValidationBehavior
    {
        PropertySettersContext<double> arg = new PropertySettersContext<double>(self.XamlSetters, NumericValidationBehavior.MaximumValueProperty);
        configure(arg).Build();
        return self;
    }

    public static T MinimumDecimalPlacesFmg<T>(this T self, int minDecimalPlaces) where T : NumericValidationBehavior
    {
        self.SetValue(NumericValidationBehavior.MinimumDecimalPlacesProperty, minDecimalPlaces);
        return self;
    }

    public static T MinimumDecimalPlacesFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure) where T : NumericValidationBehavior
    {
        PropertyContext<int> arg = new PropertyContext<int>(self, NumericValidationBehavior.MinimumDecimalPlacesProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> MinimumDecimalPlacesFmg<T>(this SettersContext<T> self, int minDecimalPlaces) where T : NumericValidationBehavior
    {
        self.XamlSetters.Add(new Setter
        {
            Property = NumericValidationBehavior.MinimumDecimalPlacesProperty,
            Value = minDecimalPlaces
        });
        return self;
    }

    public static SettersContext<T> MinimumDecimalPlacesFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure) where T : NumericValidationBehavior
    {
        PropertySettersContext<int> arg = new PropertySettersContext<int>(self.XamlSetters, NumericValidationBehavior.MinimumDecimalPlacesProperty);
        configure(arg).Build();
        return self;
    }

    public static T MaximumDecimalPlacesFmg<T>(this T self, int maxDecimalPlaces) where T : NumericValidationBehavior
    {
        self.SetValue(NumericValidationBehavior.MaximumDecimalPlacesProperty, maxDecimalPlaces);
        return self;
    }

    public static T MaximumDecimalPlacesFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure) where T : NumericValidationBehavior
    {
        PropertyContext<int> arg = new PropertyContext<int>(self, NumericValidationBehavior.MaximumDecimalPlacesProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> MaximumDecimalPlacesFmg<T>(this SettersContext<T> self, int maxDecimalPlaces) where T : NumericValidationBehavior
    {
        self.XamlSetters.Add(new Setter
        {
            Property = NumericValidationBehavior.MaximumDecimalPlacesProperty,
            Value = maxDecimalPlaces
        });
        return self;
    }

    public static SettersContext<T> MaximumDecimalPlacesFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure) where T : NumericValidationBehavior
    {
        PropertySettersContext<int> arg = new PropertySettersContext<int>(self.XamlSetters, NumericValidationBehavior.MaximumDecimalPlacesProperty);
        configure(arg).Build();
        return self;
    }
}
