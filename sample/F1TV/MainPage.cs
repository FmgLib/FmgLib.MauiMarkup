namespace F1TV;

public partial class MainPage : FmgLibContentPage
{
    public override void Build()
    {
        this
        .ShellNavBarIsVisible(false)
        .BackgroundColor(Color.FromArgb("#15151d"))
        .Behaviors(
            new StatusBarBehavior()
            .StatusBarColor(Color.FromArgb("#e10600"))
        )
        .Resources(
            new ResourceDictionary
            {
                new Style<Label>(e => e.TextColor(White))
            }
        )
        .Content(
            new ScrollView().Content(
                new VerticalStackLayout().Children(
                    new FlexLayout()
                    .Padding(20)
                    .Background(Color.FromArgb("#e10600"))
                    .HeightRequest(60)
                    .Center()
                    .JustifyContent(FlexJustify.SpaceBetween)
                    .Children(
                        new Image()
                        .Margin(0,10,0,0)
                        .SizeRequest(32)
                        .CenterVertical()
                        .Source(
                            new FontImageSource()
                            .FontFamily("IconFontTypes")
                            .Size(32)
                            .Glyph(IconFont.Menu)
                            .Color(White)
                        ),

                        new Label()
                        .FontAttributes(Bold)
                        .FontSize(22)
                        .Text("F1TV")
                        .CenterVertical(),

                        new Image()
                        .Margin(0,10,0,0)
                        .SizeRequest(32)
                        .CenterVertical()
                        .Source(
                            new FontImageSource()
                            .FontFamily("IconFontTypes")
                            .Size(32)
                            .Glyph(IconFont.Magnify)
                            .Color(White)
                        )
                    ),

                    new Grid().Children(
                        new Image()
                        .HeightRequest(220)
                        .CenterHorizontal()
                        .Source("leclerc.jpg"),

                        new Frame()
                        .BorderColor(Color.FromArgb("#15151d"))
                        .CornerRadius(0)
                        .HeightRequest(220)
                        .Background(
                            new LinearGradientBrush()
                            .EndPoint(new Point(0,1))
                            .GradientStops(
                                new GradientStop().Offset(0.1f).Color(Transparent),
                                new GradientStop().Offset(1.0f).Color(Color.FromArgb("#15151d"))
                            )
                        ),

                        new Border()
                        .Margin(20,30)
                        .Padding(0)
                        .Background(Color.FromArgb("#e10600"))
                        .SizeRequest(70)
                        .AlignBottomLeft()
                        .StrokeThickness(0)
                        .StrokeShape(new RoundRectangle().CornerRadius(new CornerRadius(0,30,0,0)))
                        .Content(
                            new Image()
                            .SizeRequest(50)
                            .CenterVertical()
                            .Source(
                                new FontImageSource()
                                .FontFamily("IconFontTypes")
                                .Size(50)
                                .Glyph(IconFont.PlayOutline)
                                .Color(White)
                            )
                        ),

                        new Label()
                        .Margin(20,0)
                        .FontAttributes(Bold)
                        .FontSize(20)
                        .AlignBottomLeft()
                        .Text("2024 British GP - Practice 2")
                    ),

                    new HorizontalStackLayout()
                    .Margin(0,0,10,0)
                    .Children(
                        new Image()
                        .Margin(0,0,10,0)
                        .SizeRequest(20)
                        .CenterVertical()
                        .Source(
                            new FontImageSource()
                            .FontFamily("IconFontTypes")
                            .Size(20)
                            .Glyph(IconFont.ClockOutline)
                            .Color(White)
                        ),

                        new Label().Text("01:12:24 | "),
                        new Label().Text(" REPLAY | "),

                        new Image()
                        .Margin(6,0,6,0)
                        .SizeRequest(20)
                        .CenterVertical()
                        .Source(
                            new FontImageSource()
                            .FontFamily("IconFontTypes")
                            .Size(20)
                            .Glyph(IconFont.Steering)
                            .Color(White)
                        ),

                        new Label().Text(" | "),
                        new Label().Text(" F1 | "),
                        new Label().Text(" F1 TV Pro")
                    ),

                    new HorizontalStackLayout()
                    .CenterHorizontal()
                    .Margin(0,10,0,0)
                    .Spacing(4)
                    .Children(
                        new Line().Stroke(White).X2(30),
                        new Line().Stroke(Color.FromArgb("#949398")).X2(30),
                        new Line().Stroke(Color.FromArgb("#949398")).X2(30),
                        new Line().Stroke(Color.FromArgb("#949398")).X2(30)
                    ),

                    new FlexLayout()
                    .Margin(20,10,20,0)
                    .JustifyContent(FlexJustify.SpaceBetween)
                    .Children(
                        new HorizontalStackLayout().Children(
                            new Label()
                            .FontAttributes(Bold)
                            .FontSize(18)
                            .AlignTopLeft()
                            .Text("2024 British Grand Prix"),

                            new Label()
                            .Margin(10,0)
                            .FontAttributes(Bold)
                            .FontSize(18)
                            .Text(">")
                            .TextColor(Color.FromArgb("#e10600"))
                        ),

                        new Label()
                        .Margin(0,0)
                        .FontAttributes(Bold)
                        .FontSize(18)
                        .CenterHorizontal()
                        .Text("View All")
                    ),

                    new CollectionView()
                    .ItemsLayout(new LinearItemsLayout(ItemsLayoutOrientation.Horizontal).ItemSpacing(10))
                    .ItemsSource(new List<string>
                    {
                        "test",
                        "test",
                        "test"
                    })
                    .ItemTemplate(new DataTemplate(() =>
                        new Border()
                        .Margin(10,10,0,0)
                        .Background(Color.FromArgb("#1f1f27"))
                        .SizeRequest(180,200)
                        .StrokeThickness(0)
                        .StrokeShape(new RoundRectangle().CornerRadius(new CornerRadius(0,0,15,15)))
                        .Content(
                            new Grid()
                            .RowDefinitions(e => e.Star().Star())
                            .Children(
                                new Grid().Children(
                                    new Image()
                                    .Margin(0)
                                    .HeightRequest(110)
                                    .CenterHorizontal()
                                    .Source("leclerc.jpg"),

                                    new Border()
                                    .Margin(-3,0,0,-2)
                                    .Padding(0)
                                    .Background(Color.FromArgb("#1f1f27"))
                                    .SizeRequest(50)
                                    .AlignBottomLeft()
                                    .StrokeThickness(0)
                                    .StrokeShape(new RoundRectangle().CornerRadius(new CornerRadius(0,20,0,0)))
                                    .Content(
                                        new Image()
                                        .SizeRequest(38)
                                        .CenterVertical()
                                        .Source(
                                            new FontImageSource()
                                            .FontFamily("IconFontTypes")
                                            .Size(38)
                                            .Glyph(IconFont.PlayOutline)
                                            .Color(White)
                                        )
                                    )
                                ),

                                new VerticalStackLayout()
                                .Row(1)
                                .Margin(10)
                                .Children(
                                    new Label().Margin(0,0,0,6).Text("00:10:22"),
                                    new Label().Text("PRACTICE 2 HIGHLIGHTS - Great Britain"),
                                    new Label().Text("F1").AlignBottomRight().TextColor(Color.FromArgb("#e10600"))
                                )
                            )
                        )
                    )),

                    new Grid()
                    .Margin(0,20,0,0)
                    .Children(
                        new Image().Source("redoutline.png"),

                        new VerticalStackLayout()
                        .Margin(20,30,0,0)
                        .Children(
                            new Label().FontSize(26).Text("🇬🇧"),
                            new Label().FontAttributes(Bold).FontSize(22).Text("GREAT BRITAIN"),
                            new Label().Text("FORMULA 1 LENOVO BRITISH"),
                            new Label().Text("GRAND PRIX 2024"),

                            new Border()
                            .Margin(0,20,0,0)
                            .Padding(4)
                            .Background(Color.FromArgb("#38393e"))
                            .SizeRequest(110,30)
                            .AlignBottomLeft()
                            .StrokeThickness(0)
                            .StrokeShape(new RoundRectangle().CornerRadius(15))
                            .Content(
                                new Label().CenterHorizontal().Text("1 JUL - 3 JUL")
                            )
                        )
                    )
                )
            )
        );
    }
}
