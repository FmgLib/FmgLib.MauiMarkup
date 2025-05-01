using Microsoft.Maui.Graphics;

namespace App1;

public class AppColors
{
    public static readonly Color Primary = "#512BD4".ToColor();
    public static readonly Color Secondary = "#DFD8F7".ToColor();
    public static readonly Color Tertiary = "#2B0B98".ToColor();

    public static readonly Color Gray100 = "#E1E1E1".ToColor();
    public static readonly Color Gray200 = "#C8C8C8".ToColor();
    public static readonly Color Gray300 = "#ACACAC".ToColor();
    public static readonly Color Gray400 = "#919191".ToColor();
    public static readonly Color Gray500 = "#6E6E6E".ToColor();
    public static readonly Color Gray600 = "#404040".ToColor();
    public static readonly Color Gray900 = "#212121".ToColor();
    public static readonly Color Gray950 = "#141414".ToColor();


    public static readonly MC.SolidColorBrush PrimaryBrush = new(Primary);
    public static readonly MC.SolidColorBrush SecondaryBrush = new(Secondary);
    public static readonly MC.SolidColorBrush TertiaryBrush = new(Tertiary);
    public static readonly MC.SolidColorBrush WhiteBrush = new(White);
    public static readonly MC.SolidColorBrush BlackBrush = new(Black);

    public static readonly MC.SolidColorBrush Gray100Brush = new(Gray100);
    public static readonly MC.SolidColorBrush Gray200Brush = new(Gray200);
    public static readonly MC.SolidColorBrush Gray300Brush = new(Gray300);
    public static readonly MC.SolidColorBrush Gray400Brush = new(Gray400);
    public static readonly MC.SolidColorBrush Gray500Brush = new(Gray500);
    public static readonly MC.SolidColorBrush Gray600Brush = new(Gray600);
    public static readonly MC.SolidColorBrush Gray900Brush = new(Gray900);
    public static readonly MC.SolidColorBrush Gray950Brush = new(Gray950);
}