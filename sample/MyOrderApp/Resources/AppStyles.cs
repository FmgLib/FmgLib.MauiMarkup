using Microsoft.Maui.Controls.Shapes;

namespace MyOrderApp;

public class AppStyles
{
    public static ResourceDictionary Default => new ResourceDictionary {

        // "ActivityIndicator"
        
        new Style<ActivityIndicator>(e => e
            .ColorFmg(e => e.OnLightFmg(Colors.White).OnDarkFmg(Colors.White))),
        
        // "IndicatorView"

        new Style<IndicatorView>(e => e
            .IndicatorColorFmg(e => e.OnLightFmg(AppColors.Gray200).OnDarkFmg(AppColors.Gray500))
            .SelectedIndicatorColorFmg(e => e.OnLightFmg(AppColors.Gray950).OnDarkFmg(AppColors.Gray100))),
        
        // "Border"

        new Style<Border>(e => e
            .StrokeFmg(e => e.OnLightFmg(AppColors.Gray200).OnDarkFmg(AppColors.Gray500))
            .StrokeShapeFmg(new Rectangle())
            .StrokeThicknessFmg(1)),

        // "BoxView"

        new Style<BoxView>(e => e
            .ColorFmg(e => e.OnLightFmg(AppColors.Gray950).OnDarkFmg(AppColors.Gray200))),
        

        // "Button"

        new Style<Button>(e => e
            .TextColorFmg(e => e.OnLightFmg(Colors.White).OnDarkFmg(AppColors.Primary))
            .BackgroundColorFmg(e => e.OnLightFmg(AppColors.Primary).OnDarkFmg(Colors.White))
            .FontFamilyFmg("OpenSansRegular")
            .FontSizeFmg(14)
            .CornerRadiusFmg(8)
            .PaddingFmg(new Thickness(14,10))
            .MinimumHeightRequestFmg(44)
            .MinimumWidthRequestFmg(44))
        {
            new VisualState<Button> (VisualStates.VisualElement.Disabled, e => e
                .TextColorFmg(e => e.OnLightFmg(AppColors.Gray950).OnDarkFmg(AppColors.Gray200))
                .BackgroundColorFmg(e => e.OnLightFmg(AppColors.Gray200).OnDarkFmg(AppColors.Gray600)))
        },

        // "CheckBox"

        new Style<CheckBox>(e => e
            .ColorFmg(e => e.OnLightFmg(AppColors.Primary).OnDarkFmg(Colors.White))
            .MinimumHeightRequestFmg(44)
            .MinimumWidthRequestFmg(44))
        {
            new VisualState<CheckBox>(VisualStates.VisualElement.Normal),
            new VisualState<CheckBox>(VisualStates.VisualElement.Disabled, e => e
                .ColorFmg(e => e.OnLightFmg(AppColors.Gray300).OnDarkFmg(AppColors.Gray600))),
        },

        // "DatePicker"

        new Style<DatePicker>(e => e
            .TextColorFmg(e => e.OnLightFmg(AppColors.Gray900).OnDarkFmg(Colors.White))
            .BackgroundColorFmg(Colors.Transparent)
            .FontFamilyFmg("OpenSansRegular")
            .FontSizeFmg(14)
            .MinimumHeightRequestFmg(44)
            .MinimumWidthRequestFmg(44))
        {
            new VisualState<DatePicker>(VisualStates.VisualElement.Normal),
            new VisualState<DatePicker>(VisualStates.VisualElement.Disabled, e => e
                .TextColorFmg(e => e.OnLightFmg(AppColors.Gray200).OnDarkFmg(AppColors.Gray500)))
        },
        
        // "Editor"

        new Style<Editor>(e => e
            .TextColorFmg(e => e.OnLightFmg(Colors.Black).OnDarkFmg(Colors.White))
            .BackgroundColorFmg(Colors.Transparent)
            .FontFamilyFmg("OpenSansRegular")
            .FontSizeFmg(14)
            .PlaceholderColorFmg(e => e.OnLightFmg(AppColors.Gray200).OnDarkFmg(AppColors.Gray500))
            .MinimumHeightRequestFmg(44)
            .MinimumWidthRequestFmg(44))
        {
            new VisualState<Editor>(VisualStates.VisualElement.Normal),
            new VisualState<Editor>(VisualStates.VisualElement.Disabled, e => e
                .TextColorFmg(e => e.OnLightFmg(AppColors.Gray300).OnDarkFmg(AppColors.Gray600)))
        },  
        

        // "Entry"

        new Style<Entry>(e => e
            .TextColorFmg(e => e.OnLightFmg(Colors.Black).OnDarkFmg(Colors.White))
            .BackgroundColorFmg(Colors.Transparent)
            .FontFamilyFmg("OpenSansRegular")
            .FontSizeFmg(14)
            .PlaceholderColorFmg(e => e.OnLightFmg(AppColors.Gray200).OnDarkFmg(AppColors.Gray500))
            .MinimumHeightRequestFmg(44)
            .MinimumWidthRequestFmg(44))
        {
            new VisualState<Entry>(VisualStates.VisualElement.Normal),
            new VisualState<Entry>(VisualStates.VisualElement.Disabled, e => e
                .TextColorFmg(e => e.OnLightFmg(AppColors.Gray300).OnDarkFmg(AppColors.Gray600)))
        },              

        // "Frame"

        new Style<Frame>(e => e
            .HasShadowFmg(false)
            .BorderColorFmg(e => e.OnLightFmg(AppColors.Gray200).OnDarkFmg(AppColors.Gray950))
            .CornerRadiusFmg(8)),
        
        // "ImageButton"

        new Style<ImageButton>(e => e
            .OpacityFmg(1.0)
            .BackgroundColorFmg(Colors.Transparent)
            .BorderWidthFmg(0)
            .BorderWidthFmg(0)
            .MinimumHeightRequestFmg(44)
            .MinimumWidthRequestFmg(44))
        {
            new VisualState<ImageButton>(VisualStates.VisualElement.Normal),
            new VisualState<ImageButton>(VisualStates.VisualElement.Disabled, e => e
                .OpacityFmg(0.5))
        },         
        

        // "Label"

        new Style<Label>(e => e
            .TextColorFmg(e => e.OnLightFmg(AppColors.Gray900).OnDarkFmg(Colors.White))
            .BackgroundColorFmg(Colors.Transparent)
            .FontFamilyFmg("OpenSansRegular")
            .FontSizeFmg(14))
        {
            new VisualState<Label>(VisualStates.VisualElement.Normal),
            new VisualState<Label>(VisualStates.VisualElement.Disabled, e => e
                .TextColorFmg(e => e.OnLightFmg(AppColors.Gray300).OnDarkFmg(AppColors.Gray600)))
        },

        // "ListView"

        new Style<ListView>(e => e
            .SeparatorColorFmg(e => e.OnLightFmg(AppColors.Gray200).OnDarkFmg(AppColors.Gray500))
            .RefreshControlColorFmg(e => e.OnLightFmg(AppColors.Gray900).OnDarkFmg(AppColors.Gray200))),

        // "Picker"

        new Style<Picker>(e => e
            .TextColorFmg(e => e.OnLightFmg(AppColors.Gray900).OnDarkFmg(Colors.White))
            .TitleColorFmg(e => e.OnLightFmg(AppColors.Gray900).OnDarkFmg(AppColors.Gray200))
            .BackgroundColorFmg(Colors.Transparent)
            .FontFamilyFmg("OpenSansRegular")
            .FontSizeFmg(14)
            .MinimumHeightRequestFmg(44)
            .MinimumWidthRequestFmg(44))
        {
            new VisualState<Picker>(VisualStates.VisualElement.Normal),
            new VisualState<Picker>(VisualStates.VisualElement.Disabled, e => e
                .TextColorFmg(e => e.OnLightFmg(AppColors.Gray300).OnDarkFmg(AppColors.Gray600))
                .TitleColorFmg(e => e.OnLightFmg(AppColors.Gray300).OnDarkFmg(AppColors.Gray600)))
        },  
        

        // "ProgressBar"

        new Style<ProgressBar>(e => e
            .ProgressColorFmg(e => e.OnLightFmg(AppColors.Primary).OnDarkFmg(Colors.White)))
        {
            new VisualState<ProgressBar>(VisualStates.VisualElement.Normal),
            new VisualState<ProgressBar>(VisualStates.VisualElement.Disabled, e => e
                .ProgressColorFmg(e => e.OnLightFmg(AppColors.Gray300).OnDarkFmg(AppColors.Gray600)))
        },
        
        // "RadioButton"

        new Style<RadioButton>(e => e
            .BackgroundColorFmg(Colors.Transparent)
            .TextColorFmg(e => e.OnLightFmg(Colors.Black).OnDarkFmg(Colors.White))
            .FontFamilyFmg("OpenSansRegular")
            .FontSizeFmg(14)
            .MinimumHeightRequestFmg(44)
            .MinimumWidthRequestFmg(44))
        {
            new VisualState<RadioButton>(VisualStates.VisualElement.Normal),
            new VisualState<RadioButton>(VisualStates.VisualElement.Disabled, e => e
                .TextColorFmg(e => e.OnLightFmg(AppColors.Gray300).OnDarkFmg(AppColors.Gray600)))
        },            

        // "RefreshView"

        new Style<RefreshView>(e => e
            .RefreshColorFmg(e => e.OnLightFmg(AppColors.Gray900).OnDarkFmg(AppColors.Gray200))),
        
        // "SearchBar"

        new Style<SearchBar>(e => e
            .TextColorFmg(e => e.OnLightFmg(AppColors.Gray900).OnDarkFmg(Colors.White))
            .PlaceholderColorFmg(AppColors.Gray500)
            .CancelButtonColorFmg(AppColors.Gray500)
            .BackgroundColorFmg(Colors.Transparent)
            .FontFamilyFmg("OpenSansRegular")
            .FontSizeFmg(14))
        {
            new VisualState<SearchBar>(VisualStates.VisualElement.Normal),
            new VisualState<SearchBar>(VisualStates.VisualElement.Disabled, e => e
                .TextColorFmg(e => e.OnLightFmg(AppColors.Gray300).OnDarkFmg(AppColors.Gray600))
                .PlaceholderColorFmg(e => e.OnLightFmg(AppColors.Gray300).OnDarkFmg(AppColors.Gray600)))
        },      

        // "SearchHandler"

        new Style<SearchHandler>(e => e
            .TextColorFmg(e => e.OnLightFmg(AppColors.Gray900).OnDarkFmg(Colors.White))
            .PlaceholderColorFmg(AppColors.Gray500)
            .BackgroundColorFmg(Colors.Transparent)
            .FontFamilyFmg("OpenSansRegular")
            .FontSizeFmg(14))
        {
            new VisualState<SearchHandler>(VisualStates.VisualElement.Normal),
            new VisualState<SearchHandler>(VisualStates.VisualElement.Disabled, e => e
                .TextColorFmg(e => e.OnLightFmg(AppColors.Gray300).OnDarkFmg(AppColors.Gray600))
                .PlaceholderColorFmg(e => e.OnLightFmg(AppColors.Gray300).OnDarkFmg(AppColors.Gray600)))
        },            

        // "Shadow"

        new Style<Shadow>(e => e
            .RadiusFmg(15)
            .OpacityFmg(0.5f)
            .BrushFmg(e => e.OnLightFmg(Colors.White).OnDarkFmg(Colors.White))
            .OffsetFmg(new Point(10, 10))),
        
        // "Slider"

        new Style<Slider>(e => e
            .MinimumTrackColorFmg(e => e.OnLightFmg(AppColors.Primary).OnDarkFmg(Colors.White))
            .MaximumTrackColorFmg(e => e.OnLightFmg(AppColors.Gray200).OnDarkFmg(AppColors.Gray600))
            .ThumbColorFmg(e => e.OnLightFmg(AppColors.Primary).OnDarkFmg(Colors.White)))
        {
            new VisualState<Slider>(VisualStates.VisualElement.Normal),
            new VisualState<Slider>(VisualStates.VisualElement.Disabled, e => e
                .MinimumTrackColorFmg(e => e.OnLightFmg(AppColors.Gray300).OnDarkFmg(AppColors.Gray600))
                .MaximumTrackColorFmg(e => e.OnLightFmg(AppColors.Gray300).OnDarkFmg(AppColors.Gray600))
                .ThumbColorFmg(e => e.OnLightFmg(AppColors.Gray300).OnDarkFmg(AppColors.Gray600)))
        },

        // "SwipeItem"

        new Style<SwipeItem>(e => e
            .BackgroundColorFmg(e => e.OnLightFmg(Colors.White).OnDarkFmg(Colors.Black))),            

        // "Switch"

        new Style<Switch>(e => e
            .OnColorFmg(e => e.OnLightFmg(AppColors.Primary).OnDarkFmg(Colors.White))
            .ThumbColorFmg(e => e.OnLightFmg(AppColors.Gray400).OnDarkFmg(AppColors.Gray500)))
        {
            new VisualState<Switch>(VisualStates.Switch.Normal),

            new VisualState<Switch>(VisualStates.Switch.Disabled, e => e
                .OnColorFmg(e => e.OnLightFmg(AppColors.Gray300).OnDarkFmg(AppColors.Gray600))
                .ThumbColorFmg(e => e.OnLightFmg(AppColors.Gray300).OnDarkFmg(AppColors.Gray600))),

            new VisualState<Switch>(VisualStates.Switch.On, e => e
                .OnColorFmg(e => e.OnLightFmg(AppColors.Secondary).OnDarkFmg(AppColors.Gray200))
                .ThumbColorFmg(e => e.OnLightFmg(AppColors.Primary).OnDarkFmg(Colors.White))),

            new VisualState<Switch>(VisualStates.Switch.Off, e => e
                .OnColorFmg(e => e.OnLightFmg(AppColors.Primary).OnDarkFmg(Colors.White))
                .ThumbColorFmg(e => e.OnLightFmg(AppColors.Gray400).OnDarkFmg(AppColors.Gray500)))
        },

        // "TimePicker"

        new Style<TimePicker>(e => e
            .TextColorFmg(e => e.OnLightFmg(AppColors.Gray900).OnDarkFmg(Colors.White))
            .BackgroundColorFmg(Colors.Transparent)
            .FontFamilyFmg("OpenSansRegular")
            .FontSizeFmg(14)
            .MinimumHeightRequestFmg(44)
            .MinimumWidthRequestFmg(44))
        {
            new VisualState<TimePicker>(VisualStates.VisualElement.Normal),
            new VisualState<TimePicker>(VisualStates.VisualElement.Disabled, e => e
                .TextColorFmg(e => e.OnLightFmg(AppColors.Gray300).OnDarkFmg(AppColors.Gray600)))
        },            

        // "Page"

        new Style<Page>(applyToDerivedTypes: true, e => e
            .PaddingFmg(0)
            .BackgroundColorFmg(e => e.OnLightFmg(Colors.White).OnDarkFmg(Colors.Black))),
        
        // "Shell"

        new Style<Shell>(applyToDerivedTypes: true, e => e
            .ShellNavBarHasShadowFmg(false)
            .ShellNavBarIsVisibleFmg(false)
            .ShellBackgroundColorFmg(e => e.OnLightFmg(AppColors.Primary).OnDarkFmg(AppColors.Gray950))
            .ShellForegroundColorFmg(e => e.OnLightFmg(AppColors.Primary).OnDarkFmg(Colors.White))
            .ShellTitleColorFmg(e => e.OnLightFmg(Colors.White).OnDarkFmg(Colors.White))
            .ShellDisabledColorFmg(e => e.OnLightFmg(AppColors.Gray200).OnDarkFmg(AppColors.Gray950))
            .ShellUnselectedColorFmg(e => e.OnLightFmg(AppColors.Gray200).OnDarkFmg(AppColors.Gray200))
            .ShellTabBarBackgroundColorFmg(e => e.OnLightFmg(Colors.White).OnDarkFmg(Colors.Black))
            .ShellTabBarForegroundColorFmg(e => e.OnLightFmg(AppColors.Primary).OnDarkFmg(Colors.White))
            .ShellTabBarTitleColorFmg(e => e.OnLightFmg(AppColors.Primary).OnDarkFmg(Colors.White))
            .ShellTabBarUnselectedColorFmg(e => e.OnLightFmg(AppColors.Gray900).OnDarkFmg(AppColors.Gray200))),

        // "NavigationPage"

        new Style<NavigationPage>(e => e
            .BarBackgroundColorFmg(e => e.OnLightFmg(AppColors.Primary).OnDarkFmg(AppColors.Gray950))
            .BarTextColorFmg(e => e.OnLightFmg(AppColors.Gray200).OnDarkFmg(Colors.White))),
        
        // "TabbedPage"

        new Style<TabbedPage>(e => e
            .BarBackgroundColorFmg(e => e.OnLightFmg(Colors.White).OnDarkFmg(AppColors.Gray950))
            .BarTextColorFmg(e => e.OnLightFmg(AppColors.Primary).OnDarkFmg(Colors.White))
            .UnselectedTabColorFmg(e => e.OnLightFmg(AppColors.Gray200).OnDarkFmg(AppColors.Gray500))
            .SelectedTabColorFmg(e => e.OnLightFmg(AppColors.Gray950).OnDarkFmg(AppColors.Gray100)))
    };
}
