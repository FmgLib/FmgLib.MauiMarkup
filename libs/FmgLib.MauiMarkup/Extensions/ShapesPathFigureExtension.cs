﻿namespace FmgLib.MauiMarkup.Extensions;

public static partial class ShapesPathFigureExtension
{
    public static Microsoft.Maui.Controls.Shapes.PathFigure StartPointFmg(this Microsoft.Maui.Controls.Shapes.PathFigure self,
        double x, double y)
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.PathFigure.StartPointProperty, new Point(x, y));
        return self;
    }
}
