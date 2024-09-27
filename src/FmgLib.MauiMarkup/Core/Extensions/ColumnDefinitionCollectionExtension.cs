namespace FmgLib.MauiMarkup;

public static partial class ColumnDefinitionCollectionExtension
{
    public static ColumnDefinitionCollection Auto(this ColumnDefinitionCollection self, int count = 1)
    {
        for (int i = 0; i < count; i++)
        {
            self.Add(new ColumnDefinition(new GridLength(0.0, GridUnitType.Auto)));
        }

        return self;
    }

    public static ColumnDefinitionCollection Star(this ColumnDefinitionCollection self, double width = 1.0, int count = 1)
    {
        for (int i = 0; i < count; i++)
        {
            self.Add(new ColumnDefinition(new GridLength(width, GridUnitType.Star)));
        }

        return self;
    }

    public static ColumnDefinitionCollection Absolute(this ColumnDefinitionCollection self, double width, int count = 1)
    {
        for (int i = 0; i < count; i++)
        {
            self.Add(new ColumnDefinition(new GridLength(width, GridUnitType.Absolute)));
        }

        return self;
    }
}
