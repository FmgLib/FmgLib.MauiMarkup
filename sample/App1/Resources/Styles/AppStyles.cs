using Microsoft.Maui;
using Microsoft.Maui.Controls.Shapes;
using Microsoft.Maui.Graphics;

namespace App1;

public class AppStyles
{
    public static MC.ResourceDictionary Default => new MC.ResourceDictionary
    {
        // "ActivityIndicator"

        new Style<MC.ActivityIndicator>(e => e.Color(e => e.OnLight(AppColors.Primary).OnDark(White))),

        // "IndicatorView"

        new Style<MC.IndicatorView>(e => e
            .IndicatorColor(e => e.OnLight(AppColors.Gray200).OnDark(AppColors.Gray500))
            .SelectedIndicatorColor(e => e.OnLight(AppColors.Gray950).OnDark(AppColors.Gray100))),

        // "Border"

        new Style<MC.Border>(e => e
            .Stroke(e => e.OnLight(AppColors.Gray200).OnDark(AppColors.Gray500))
            .StrokeShape(new Rectangle())
            .StrokeThickness(1)),

        // "BoxView"

        new Style<MC.BoxView>(e => e.Color(e => e.OnLight(AppColors.Gray950).OnDark(AppColors.Gray200))),


        // "Button"

        new Style<MC.Button>(e => e
            .TextColor(e => e.OnLight(White).OnDark(AppColors.Primary))
            .BackgroundColor(e => e.OnLight(AppColors.Primary).OnDark(White))
            .FontFamily("OpenSansRegular")
            .FontSize(14)
            .CornerRadius(8)
            .Padding(new Thickness(14, 10))
            .MinimumHeightRequest(44)
            .MinimumWidthRequest(44))
        {
            new VisualState<MC.Button>(VisualStates.VisualElement.Normal, e => e
                .TextColor(e => e.OnLight(White).OnDark(AppColors.Primary))
                .BackgroundColor(e => e.OnLight(AppColors.Primary).OnDark(White))),

            new VisualState<MC.Button>(VisualStates.VisualElement.Disabled, e => e
                .TextColor(e => e.OnLight(AppColors.Gray950).OnDark(AppColors.Gray200))
                .BackgroundColor(e => e.OnLight(AppColors.Gray200).OnDark(AppColors.Gray600)))
        },

        // "MC.CheckBox"

        new Style<MC.CheckBox>(e => e.Color(e => e.OnLight(AppColors.Primary).OnDark(White))
            .MinimumHeightRequest(44)
            .MinimumWidthRequest(44))
        {
            new VisualState<MC.CheckBox>(VisualStates.VisualElement.Normal),
            new VisualState<MC.CheckBox>(VisualStates.VisualElement.Disabled, e => e.Color(e => e.OnLight(AppColors.Gray300).OnDark(AppColors.Gray600))),
        },

        // "MC.DatePicker"

        new Style<MC.DatePicker>(e => e
            .TextColor(e => e.OnLight(AppColors.Gray900).OnDark(White))
            .BackgroundColor(Transparent)
            .FontFamily("OpenSansRegular")
            .FontSize(14)
            .MinimumHeightRequest(44)
            .MinimumWidthRequest(44))
        {
            new VisualState<MC.DatePicker>(VisualStates.VisualElement.Normal),
            new VisualState<MC.DatePicker>(VisualStates.VisualElement.Disabled, e => e
                .TextColor(e => e.OnLight(AppColors.Gray200).OnDark(AppColors.Gray500)))
        },

        // "Editor"

        new Style<MC.Editor>(e => e
            .TextColor(e => e.OnLight(Black).OnDark(White))
            .BackgroundColor(Transparent)
            .FontFamily("OpenSansRegular")
            .FontSize(14)
            .PlaceholderColor(e => e.OnLight(AppColors.Gray200).OnDark(AppColors.Gray500))
            .MinimumHeightRequest(44)
            .MinimumWidthRequest(44))
        {
            new VisualState<MC.Editor>(VisualStates.VisualElement.Normal),
            new VisualState<MC.Editor>(VisualStates.VisualElement.Disabled, e => e
                .TextColor(e => e.OnLight(AppColors.Gray300).OnDark(AppColors.Gray600)))
        },


        // "Entry"

        new Style<MC.Entry>(e => e
            .TextColor(e => e.OnLight(Black).OnDark(White))
            .BackgroundColor(Transparent)
            .FontFamily("OpenSansRegular")
            .FontSize(14)
            .PlaceholderColor(e => e.OnLight(AppColors.Gray200).OnDark(AppColors.Gray500))
            .MinimumHeightRequest(44)
            .MinimumWidthRequest(44))
        {
            new VisualState<MC.Entry>(VisualStates.VisualElement.Normal),
            new VisualState<MC.Entry>(VisualStates.VisualElement.Disabled, e => e
                .TextColor(e => e.OnLight(AppColors.Gray300).OnDark(AppColors.Gray600)))
        },

        // "Frame"

        new Style<MC.Frame>(e => e
            .HasShadow(false)
            .BorderColor(e => e.OnLight(AppColors.Gray200).OnDark(AppColors.Gray950))
            .CornerRadius(8)),

        // "ImageButton"

        new Style<MC.ImageButton>(e => e
            .Opacity(1.0)
            .BackgroundColor(Transparent)
            .BorderWidth(0)
            .BorderWidth(0)
            .MinimumHeightRequest(44)
            .MinimumWidthRequest(44))
        {
            new VisualState<MC.ImageButton>(VisualStates.VisualElement.Normal),
            new VisualState<MC.ImageButton>(VisualStates.VisualElement.Disabled, e => e
                .Opacity(0.5))
        },


        // "Label"

        new Style<MC.Label>(e => e
            .TextColor(e => e.OnLight(AppColors.Gray900).OnDark(White))
            .BackgroundColor(Transparent)
            .FontFamily("OpenSansRegular")
            .FontSize(14))
        {
            new VisualState<MC.Label>(VisualStates.VisualElement.Normal),
            new VisualState<MC.Label>(VisualStates.VisualElement.Disabled, e => e
                .TextColor(e => e.OnLight(AppColors.Gray300).OnDark(AppColors.Gray600)))
        },

        // "ListView"

        new Style<MC.ListView>(e => e
            .SeparatorColor(e => e.OnLight(AppColors.Gray200).OnDark(AppColors.Gray500))
            .RefreshControlColor(e => e.OnLight(AppColors.Gray900).OnDark(AppColors.Gray200))),

        // "Picker"

        new Style<MC.Picker>(e => e
            .TextColor(e => e.OnLight(AppColors.Gray900).OnDark(White))
            .TitleColor(e => e.OnLight(AppColors.Gray900).OnDark(AppColors.Gray200))
            .BackgroundColor(Transparent)
            .FontFamily("OpenSansRegular")
            .FontSize(14)
            .MinimumHeightRequest(44)
            .MinimumWidthRequest(44))
        {
            new VisualState<MC.Picker>(VisualStates.VisualElement.Normal),
            new VisualState<MC.Picker>(VisualStates.VisualElement.Disabled, e => e
                .TextColor(e => e.OnLight(AppColors.Gray300).OnDark(AppColors.Gray600))
                .TitleColor(e => e.OnLight(AppColors.Gray300).OnDark(AppColors.Gray600)))
        },


        // "ProgressBar"

        new Style<MC.ProgressBar>(e => e
            .ProgressColor(e => e.OnLight(AppColors.Primary).OnDark(White)))
        {
            new VisualState<MC.ProgressBar>(VisualStates.VisualElement.Normal),
            new VisualState<MC.ProgressBar>(VisualStates.VisualElement.Disabled, e => e
                .ProgressColor(e => e.OnLight(AppColors.Gray300).OnDark(AppColors.Gray600)))
        },

        // "RadioButton"

        new Style<MC.RadioButton>(e => e
            .BackgroundColor(Transparent)
            .TextColor(e => e.OnLight(Black).OnDark(White))
            .FontFamily("OpenSansRegular")
            .FontSize(14)
            .MinimumHeightRequest(44)
            .MinimumWidthRequest(44))
        {
            new VisualState<MC.RadioButton>(VisualStates.VisualElement.Normal),
            new VisualState<MC.RadioButton>(VisualStates.VisualElement.Disabled, e => e
                .TextColor(e => e.OnLight(AppColors.Gray300).OnDark(AppColors.Gray600)))
        },

        // "RefreshView"

        new Style<MC.RefreshView>(e => e
            .RefreshColor(e => e.OnLight(AppColors.Gray900).OnDark(AppColors.Gray200))),

        // "SearchBar"

        new Style<MC.SearchBar>(e => e
            .TextColor(e => e.OnLight(AppColors.Gray900).OnDark(White))
            .PlaceholderColor(AppColors.Gray500)
            .CancelButtonColor(AppColors.Gray500)
            .BackgroundColor(Transparent)
            .FontFamily("OpenSansRegular")
            .FontSize(14))
        {
            new VisualState<MC.SearchBar>(VisualStates.VisualElement.Normal),
            new VisualState<MC.SearchBar>(VisualStates.VisualElement.Disabled, e => e
                .TextColor(e => e.OnLight(AppColors.Gray300).OnDark(AppColors.Gray600))
                .PlaceholderColor(e => e.OnLight(AppColors.Gray300).OnDark(AppColors.Gray600)))
        },

        // "SearchHandler"

        new Style<MC.SearchHandler>(e => e
            .TextColor(e => e.OnLight(AppColors.Gray900).OnDark(White))
            .PlaceholderColor(AppColors.Gray500)
            .BackgroundColor(Transparent)
            .FontFamily("OpenSansRegular")
            .FontSize(14))
        {
            new VisualState<MC.SearchHandler>(VisualStates.VisualElement.Normal),
            new VisualState<MC.SearchHandler>(VisualStates.VisualElement.Disabled, e => e
                .TextColor(e => e.OnLight(AppColors.Gray300).OnDark(AppColors.Gray600))
                .PlaceholderColor(e => e.OnLight(AppColors.Gray300).OnDark(AppColors.Gray600)))
        },

        // "Shadow"

        new Style<MC.Shadow>(e => e
            .Radius(15)
            .Opacity(0.5f)
            .Brush(e => e.OnLight(White).OnDark(White))
            .Offset(new Point(10, 10))),

        // "Slider"

        new Style<MC.Slider>(e => e
            .MinimumTrackColor(e => e.OnLight(AppColors.Primary).OnDark(White))
            .MaximumTrackColor(e => e.OnLight(AppColors.Gray200).OnDark(AppColors.Gray600))
            .ThumbColor(e => e.OnLight(AppColors.Primary).OnDark(White)))
        {
            new VisualState<MC.Slider>(VisualStates.VisualElement.Normal),
            new VisualState<MC.Slider>(VisualStates.VisualElement.Disabled, e => e
                .MinimumTrackColor(e => e.OnLight(AppColors.Gray300).OnDark(AppColors.Gray600))
                .MaximumTrackColor(e => e.OnLight(AppColors.Gray300).OnDark(AppColors.Gray600))
                .ThumbColor(e => e.OnLight(AppColors.Gray300).OnDark(AppColors.Gray600)))
        },

        // "SwipeItem"

        new Style<MC.SwipeItem>(e => e
            .BackgroundColor(e => e.OnLight(White).OnDark(Black))),

        // "Switch"

        new Style<MC.Switch>(e => e
            .OnColor(e => e.OnLight(AppColors.Primary).OnDark(White))
            .ThumbColor(e => e.OnLight(AppColors.Gray400).OnDark(AppColors.Gray500)))
        {
            new VisualState<MC.Switch>(VisualStates.Switch.Normal),

            new VisualState<MC.Switch>(VisualStates.Switch.Disabled, e => e
                .OnColor(e => e.OnLight(AppColors.Gray300).OnDark(AppColors.Gray600))
                .ThumbColor(e => e.OnLight(AppColors.Gray300).OnDark(AppColors.Gray600))),

            new VisualState<MC.Switch>(VisualStates.Switch.On, e => e
                .OnColor(e => e.OnLight(AppColors.Secondary).OnDark(AppColors.Gray200))
                .ThumbColor(e => e.OnLight(AppColors.Primary).OnDark(White))),

            new VisualState<MC.Switch>(VisualStates.Switch.Off, e => e
                .OnColor(e => e.OnLight(AppColors.Primary).OnDark(White))
                .ThumbColor(e => e.OnLight(AppColors.Gray400).OnDark(AppColors.Gray500)))
        },

        // "TimePicker"

        new Style<MC.TimePicker>(e => e
            .TextColor(e => e.OnLight(AppColors.Gray900).OnDark(White))
            .BackgroundColor(Transparent)
            .FontFamily("OpenSansRegular")
            .FontSize(14)
            .MinimumHeightRequest(44)
            .MinimumWidthRequest(44))
        {
            new VisualState<MC.TimePicker>(VisualStates.VisualElement.Normal),
            new VisualState<MC.TimePicker>(VisualStates.VisualElement.Disabled, e => e
                .TextColor(e => e.OnLight(AppColors.Gray300).OnDark(AppColors.Gray600)))
        },

        // "Page"

        new Style<MC.Page>(applyToDerivedTypes: true, e => e
            .Padding(0)
            .BackgroundColor(e => e.OnLight(White).OnDark(Black))),

        // "Shell"

        new Style<MC.Shell>(applyToDerivedTypes: true, e => e
            .ShellNavBarHasShadow(false)
            .ShellBackgroundColor(e => e.OnLight(AppColors.Primary).OnDark(AppColors.Gray950))
            .ShellForegroundColor(e => e.OnLight(AppColors.Primary).OnDark(White))
            .ShellTitleColor(e => e.OnLight(White).OnDark(White))
            .ShellDisabledColor(e => e.OnLight(AppColors.Gray200).OnDark(AppColors.Gray950))
            .ShellUnselectedColor(e => e.OnLight(AppColors.Gray200).OnDark(AppColors.Gray200))
            .ShellTabBarBackgroundColor(e => e.OnLight(White).OnDark(Black))
            .ShellTabBarForegroundColor(e => e.OnLight(AppColors.Primary).OnDark(White))
            .ShellTabBarTitleColor(e => e.OnLight(AppColors.Primary).OnDark(White))
            .ShellTabBarUnselectedColor(e => e.OnLight(AppColors.Gray900).OnDark(AppColors.Gray200))),

        // "NavigationPage"

        new Style<MC.NavigationPage>(e => e
            .BarBackgroundColor(e => e.OnLight(AppColors.Primary).OnDark(AppColors.Gray950))
            .BarTextColor(e => e.OnLight(AppColors.Gray200).OnDark(White))),

        // "TabbedPage"

        new Style<MC.TabbedPage>(e => e
            .BarBackgroundColor(e => e.OnLight(White).OnDark(AppColors.Gray950))
            .BarTextColor(e => e.OnLight(AppColors.Primary).OnDark(White))
            .UnselectedTabColor(e => e.OnLight(AppColors.Gray200).OnDark(AppColors.Gray500))
            .SelectedTabColor(e => e.OnLight(AppColors.Gray950).OnDark(AppColors.Gray100)))
    };
}