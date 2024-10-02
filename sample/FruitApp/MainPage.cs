using FmgLib.MauiMarkup;

namespace FruitApp;

public partial class MainPage : FmgLibContentPage
{
    public List<FruitInformation> PapayaInfo { get; set; }

    public MainPage()
    {
        LoadData();
        this.BindingContext = this;
    }

    public override void Build()
    {
        this
        .Background(
            new LinearGradientBrush()
            .EndPoint(new Point(0, 1))
            .GradientStops(
                new GradientStop().Offset(0.1f).Color(Color.FromArgb("#FFCC33")),
                new GradientStop().Offset(1.0f).Color(Color.FromArgb("#FCBC03"))
            )
        )
        .Content(
            new Grid()
            .Margin(25)
            .RowDefinitions(e => e.Star(2).Star(4).Star(4))
            .Children(
                new Image()
                .RowSpan(3)
                .Center()
                .Source("papaya.png"),

                new VerticalStackLayout().Children(
                    new Label()
                    .FontFamily("Regular")
                    .FontSize(45)
                    .CenterHorizontal()
                    .Text("PAPAYA"),

                    new Label()
                    .Margin(0, 15, 0, 0)
                    .FontFamily("Bold")
                    .FontAttributes(Bold)
                    .FontSize(20)
                    .CenterHorizontal()
                    .Text("100 grams")
                ),

                new AcrylicView()
                .Row(2)
                .CornerRadius(20)
                .EffectStyle(EffectStyle.Custom)
                .CenterVertical()
                .TintColor(Color.FromArgb("#FCE7A7"))
                .TintOpacity(.2)
                .Content(
                    new VerticalStackLayout()
                    .Padding(35)
                    .CenterVertical()
                    .BindableLayoutItemsSource(e => e.Path("PapayaInfo"))
                    .BindableLayoutItemTemplate(
                        new DataTemplate(() =>
                            new Grid()
                            .Margin(0, 10, 0, 0)
                            .ColumnDefinitions(e => e.Star(6).Star(4))
                            .Children(
                                new Label()
                                .FontFamily("Bold")
                                .FontSize(20)
                                .Text(e => e.Path("Micronutrient")),

                                new Label()
                                .Column(1)
                                .FontFamily("Regular")
                                .FontSize(20)
                                .TextBottomRight()
                                .Text(e => e.Path("Percentage").StringFormat("{0} %"))
                            )
                        )
                    )
                )
            )
        );
    }

    private void LoadData()
    {
        PapayaInfo = new List<FruitInformation>
              {
                   new FruitInformation
                   {
                        Micronutrient = "Vitamin C",
                        Percentage = 101
                   },
                   new FruitInformation
                   {
                        Micronutrient = "Vitamin A",
                        Percentage = 19
                   },
                   new FruitInformation
                   {
                       Micronutrient = "Calcium",
                       Percentage = 2
                   },
                   new FruitInformation
                   {
                       Micronutrient = "Magnesium",
                       Percentage = 5
                   },
                   new FruitInformation
                   {
                       Micronutrient = "Potassium",
                       Percentage = 5
                   },
                };
    }
}
