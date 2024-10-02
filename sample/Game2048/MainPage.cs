using CommunityToolkit.Maui.Converters;
using Microsoft.Maui.Controls.Shapes;

namespace Game2048Maui;

public partial class MainPage : FmgLibContentPage<MainPageViewModel>
{
    Style<Label> WhiteLabelStyle = new Style<Label>(e => e
                .TextColor(White)
                .AlignText(TextAlignment.Center,TextAlignment.Center)
                .FontAttributes(Bold));

    Style<Grid> NumberTileGrid = new Style<Grid>(e => e
                .SizeRequest(90,90));

    Style<Frame> NumberTileFrame = new Style<Frame>(e => e
                .CornerRadius(5)
                .SizeRequest(85,85));

    EnumToBoolConverter IsGameOverConverter = new(); 
    //=> 
    //    new EnumToBoolConverter()
    //    .AddValueInProp("TrueValues", LevelState.GameOver)
    //    .AddValueInProp("TrueValues", LevelState.GameOver);

    public override void Build()
    {
        IsGameOverConverter.TrueValues.Add(LevelState.GameOver);
        IsGameOverConverter.TrueValues.Add(LevelState.GameOver);
        this
        .BackgroundColor(WhiteSmoke)
        .NavigationPageHasNavigationBar(true)
        .Padding(0)
        .Content(
            new Grid()
            .Assign(out MainGrid)
            .IgnoreSafeArea(false)
            .Margin(e => e.OnAndroid(new Thickness(0,30,0,0)).OniOS(0))
            .RowDefinitions(e => e.Auto().Star().Auto().Auto())
            .RowSpacing(3)
            .Children(
                new Grid()
                .RowDefinitions(e => e.Auto().Auto().Auto())
                .ColumnDefinitions(e => e.Star().Star().Star())
                .Row(0)
                .RowSpacing(10)
                .ColumnSpacing(10)
                .Padding(20)
                .Children(
                    new Label()
                    .Row(0)
                    .RowSpan(2)
                    .BackgroundColor(Color.FromArgb("#edc22e"))
                    .FontSize(32)
                    .TextCenter()
                    .Text("2048")
                    .TextColor(White)
                    .GestureRecognizers(new TapGestureRecognizer().OnTapped(GameLabelTapGestureRecognizer_Tapped)),

                    new VerticalStackLayout()
                    .Row(0)
                    .Column(1)
                    .Padding(5)
                    .BackgroundColor(Gray)
                    .Children(
                        new Label().Style(WhiteLabelStyle).Text("Score"),
                        new Grid().Children(
                            new Label().Style(WhiteLabelStyle).Text(e => e.Path("Score")),
                            new Label().Assign(out AddedScoreLabel).IsVisible(false).Style(WhiteLabelStyle).Text(e => e.Path("AddedScore"))
                        )
                    ),

                    new VerticalStackLayout()
                    .Row(0)
                    .Column(2)
                    .Padding(5)
                    .BackgroundColor(Gray)
                    .Children(
                        new Label().Style(WhiteLabelStyle).Text("Best"),
                        new Label().Style(WhiteLabelStyle).Text(e => e.Path("BestScore"))
                    ),

                    new Button()
                    .Row(1)
                    .Column(1)
                    .BackgroundColor(AppColors.Orange100Accent)
                    .Command(e => e.Path("NewGameCommand"))
                    .CornerRadius(5)
                    .FontAttributes(Bold)
                    .Text("NEW"),

                    new Button()
                    .Row(1)
                    .Column(2)
                    .BackgroundColor(AppColors.Orange100Accent)
                    .CornerRadius(5)
                    .FontAttributes(Bold)
                    .OnClicked(UndoButton_Clicked)
                    .Text("NEW"),

                    new Label()
                    .Row(2)
                    .ColumnSpan(3)
                    .Margin(5)
                    .FontSize(15)
                    .TextCenterHorizontal()
                    .TextColor(Gray)
                    .Text("Join the numbers and get to the 2048 tile!")
                ),

                new Border()
                .Row(1)
                .AlignTopLeft()
                .SizeRequest(400,400)
                .StrokeShape(new RoundRectangle().CornerRadius(5))
                .Content(
                    new CollectionView()
                    .SizeRequest(400,400)
                    .BackgroundColor(Color.FromArgb("#a49381"))
                    .CenterVertical()
                    .ItemsSource(e => e.Path("Tiles"))
                    .ItemsLayout(new GridItemsLayout(ItemsLayoutOrientation.Vertical).Span(4))
                    .GestureRecognizers(new PanGestureRecognizer().OnPanUpdated(PanGestureRecognizer_PanUpdated))
                    .ItemTemplate(new DataTemplate(() => 
                        new Grid()
                        .Assign(out MyToolsPhotosItem)
                        .Margin(4)
                        .Style(NumberTileGrid)
                        .Children(
                            new Frame()
                            .Assign(out tttt)
                            .Padding(0)
                            .BorderColor(Transparent)
                            .HasShadow(false)
                            .Style(NumberTileFrame)
                            .Behaviors(new TileStateBehavior())
                            .GestureRecognizers(
                                new TapGestureRecognizer().Command(e => e.Path("SelectTileCommand").Source(new RelativeBindingSource(RelativeBindingSourceMode.Self, typeof(MainPageViewModel)))).CommandParameter(new Binding())
                            )
                            .Content(
                                new Label()
                                .FontFamily("PoppinsBold")
                                .Margin(0,5,0,0)
                                .FontSize(36)
                                .Center()
                                .TextCenter()
                                .Text(e => e.Path("Number"))
                                .TextColor(e => e.Path("Number").Converter(new StringToTileTextColorConverter()))
                            )
                        )
                    ))
                ),

                new Grid()
                .Padding(25,20,25,20)
                .AlignTop()
                .Row(2)
                .Children(
                    new Label()
                    .Text("Moves:")
                    .TextColor(Gray)
                    .FormattedText(
                        new FormattedString().Spans(
                            new Span().FontFamily("PoppinsRegular").Text("Moves:").FontSize(15),
                            new Span().FontFamily("PoppinsSemibold").Text(e => e.Path("TotalMoves")).FontSize(16)
                        )
                    ),

                    new Label()
                    .AlignBottomRight()
                    .TextBottomRight()
                    .FontSize(16)
                    .TextColor(Gray)
                    .Text(e => e.Path("FormattedTime"))
                ),

                new Grid()
                .Row(3)
                .AlignBottom()
                .ColumnDefinitions(e => e.Auto().Auto().Auto())
                .Margin(0,0,0,40)
                .Children(
                    new SKLottieView()
                    .SizeRequest(150)
                    .AlignBottomLeft()
                    .RepeatCount(-1)
                    .SemanticDescription("Cute dot net bot waving hi to you!")
                    .Source(new SKFileLottieImageSource().File("dotnetbot.json"))
                    .GestureRecognizers(new TapGestureRecognizer().OnTapped(MauiRobotTapGestureRecognizer_Tapped)),

                    new HorizontalStackLayout()
                    .Spacing(0)
                    .Center()
                    .Margin(-50,0,0,-70)
                    .IsVisible(false)
                    .Column(1)
                    .Assign(out phraseLayout)
                    .Children(
                        new Border()
                        .AlignTopFill()
                        .SizeRequest(8)
                        .BackgroundColor(Color.FromArgb("#aca6f7"))
                        .StrokeShape(new RoundRectangle().CornerRadius(10)),

                        new Border()
                        .AlignTopFill()
                        .SizeRequest(12)
                        .Margin(0,10,0,0)
                        .BackgroundColor(Color.FromArgb("#aca6f7"))
                        .StrokeShape(new RoundRectangle().CornerRadius(10)),

                        new Border()
                        .AlignTopFill()
                        .Margin(0,20,0,0)
                        .Padding(10)
                        .BackgroundColor(Color.FromArgb("#aca6f7"))
                        .StrokeShape(new RoundRectangle().CornerRadius(10))
                        .Content(
                            new Label().TextColor(White).FontSize(15).Text(e => e.Path("MauiRobotPhrase"))
                        )
                    ),

                    new Grid()
                    .Column(2)
                    .IsVisible(false)
                    .Children(
                        new Ellipse()
                        .Fill(Yellow)
                        .SizeRequest(150)
                        .CenterHorizontal(),

                        new Ellipse()
                        .Fill(Gray)
                        .SizeRequest(140)
                        .CenterHorizontal(),

                        new Ellipse()
                        .Fill(Gray)
                        .SizeRequest(80)
                        .CenterHorizontal(),

                        new Grid()
                        .ColumnDefinitions(e => e.Star().Star().Star())
                        .RowDefinitions(e => e.Star().Star().Star())
                        .Center()
                        .Spacing(20)
                        .Children(
                            new Path()
                            .Row(0)
                            .Column(0)
                            .ColumnSpan(3)
                            .Fill(Yellow)
                            .Center()
                            .GestureRecognizers(new TapGestureRecognizer().Command(e => e.Path("UpSwipeCommand")))
                            .Data(
                                new PathGeometry().Figures(
                                    new PathFigure()
                                    .StartPoint(new Point(280.59747, 159.08785))
                                    .IsClosed(true)
                                    .Segments(
                                        new LineSegment(new Point(280.59747 + 16.99999, 159.08785 - 17.458)),
                                        new LineSegment(new Point(280.59747 + 16.99999 + 16.99999, 159.08785 - 17.458 + 17.458))
                                    )
                                )
                            ),

                            new Path()
                            .Row(1)
                            .Column(2)
                            .Fill(Yellow)
                            .Center()
                            .Rotation(90)
                            .GestureRecognizers(new TapGestureRecognizer().Command(e => e.Path("RightSwipeCommand")))
                            .Data(
                                new PathGeometry().Figures(
                                    new PathFigure()
                                    .StartPoint(new Point(281.59747, 159.08785))
                                    .IsClosed(true)
                                    .Segments(
                                        new LineSegment(new Point(281.59747 + 16.99999, 159.08785 - 17.458)),
                                        new LineSegment(new Point(281.59747 + 16.99999 + 16.99999, 159.08785 - 17.458 + 17.458))
                                    )
                                )
                            ),

                            new Path()
                            .Row(2)
                            .Column(1)
                            .Fill(Yellow)
                            .Center()
                            .Rotation(180)
                            .GestureRecognizers(new TapGestureRecognizer().Command(e => e.Path("DownSwipeCommand")))
                            .Data(
                                new PathGeometry().Figures(
                                    new PathFigure()
                                    .StartPoint(new Point(280.59747, 159.08785))
                                    .IsClosed(true)
                                    .Segments(
                                        new LineSegment(new Point(280.59747 + 16.99999, 159.08785 - 17.458)),
                                        new LineSegment(new Point(280.59747 + 16.99999 + 16.99999, 159.08785 - 17.458 + 17.458))
                                    )
                                )
                            ),

                            new Path()
                            .Row(1)
                            .Column(0)
                            .Fill(Yellow)
                            .Center()
                            .Rotation(270)
                            .GestureRecognizers(new TapGestureRecognizer().Command(e => e.Path("LeftSwipeCommand")))
                            .Data(
                                new PathGeometry().Figures(
                                    new PathFigure()
                                    .StartPoint(new Point(280.59747, 159.08785))
                                    .IsClosed(true)
                                    .Segments(
                                        new LineSegment(new Point(280.59747 + 16.99999, 159.08785 - 17.458)),
                                        new LineSegment(new Point(280.59747 + 16.99999 + 16.99999, 159.08785 - 17.458 + 17.458))
                                    )
                                )
                            )
                        )
                    )
                ),

                new Frame()
                .Row(1)
                .RowSpan(2)
                .AlignTopCenter()
                .SizeRequest(400,400)
                .BackgroundColor(Color.FromArgb("#AA000000"))
                .CornerRadius(10)
                .HasShadow(false)
                .IsVisible(e => e.Path("State").Converter(IsGameOverConverter))
                .Content(
                    new Grid().Children(
                        new SKLottieView()
                        .HeightRequest(150)
                        .Assign(out GameOverAnimation)
                        .FillBothDirections()
                        .RepeatCount(-1)
                        .IsAnimationEnabled(false)
                        .SemanticDescription("Cute dot net bot waving hi to you!")
                        .Source(new SKFileLottieImageSource().File("gameoveranimate.json")),

                        new Button()
                        .AlignBottom()
                        .HeightRequest(40)
                        .CornerRadius(5)
                        .FontAttributes(Bold)
                        .Text("Play Again")
                        .BackgroundColor(AppColors.Orange100Accent)
                        .Command(e => e.Path("NewGameCommand"))
                    )
                ),

                new SKConfettiView()
                .Row(0)
                .RowSpan(4)
                .InputTransparent(true)
                .Assign(out skConfetti)
                .FillBothDirections()
            )
        );
    }
}
