namespace FmgLib.MauiMarkup;

public static partial class RowDefinitionCollectionExtension
{
    public static RowDefinitionCollection Auto(this RowDefinitionCollection self, int count = 1)
    {
        for (int i = 0; i < count; i++)
        {
            self.Add(new RowDefinition(new GridLength(0.0, GridUnitType.Auto)));
        }

        return self;
    }

    public static RowDefinitionCollection Star(this RowDefinitionCollection self, double height = 1.0, int count = 1)
    {
        for (int i = 0; i < count; i++)
        {
            self.Add(new RowDefinition(new GridLength(height, GridUnitType.Star)));
        }

        return self;
    }

    public static RowDefinitionCollection Absolute(this RowDefinitionCollection self, double height, int count = 1)
    {
        for (int i = 0; i < count; i++)
        {
            self.Add(new RowDefinition(new GridLength(height, GridUnitType.Absolute)));
        }

        return self;
    }
}