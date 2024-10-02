namespace MatchingImage;

public partial class MainPage : FmgLibContentPage
{
    public override void Build()
    {
        this
        .Assign(out thispage)
        .BackgroundColor(Color.FromArgb("#bee893"))
        .BindingContext(this)
        .Resources(
            new ResourceDictionary()
            {
                new Style<Border>(e => e
                    .SizeRequest(100,140)
                    .Stroke(Color.FromArgb("#fbfeb2"))
                    .StrokeThickness(4)
                    .StrokeShape(new RoundRectangle().CornerRadius(16))
                ),

                new Style<Image>(e => e.Source("leaf.png"))
            }
        )
        .Content(
            new VerticalStackLayout()
            .CenterVertical()
            .Children(
                new Grid()
                .Assign(out GameTable)
                .Spacing(20)
                .CenterHorizontal()
                .RowDefinitions(e => e.Star().Star().Star().Star().Star())
                .ColumnDefinitions(e => e.Star().Star().Star())
                .Children(
                    GetImageBorders()
                ),

                new Button()
                .WidthRequest(160)
                .Margin(0,40)
                .CenterHorizontal()
                .Text("Reset")
                .FontSize(20)
                .OnClicked(Reset_Clicked)
            )
        );
    }

    public List<IView> GetImageBorders()
    {
        var result = new List<IView>();
        for (int i = 0; i < 4; i++)
            for (int j = 0; j < 3; j++)
                result.Add(new Border()
                    .Row(i)
                    .Column(j)
                    .GestureRecognizers(new TapGestureRecognizer().OnTapped(Card_Tapped))
                    .Content(new Image()));

        return result;
    }
}
