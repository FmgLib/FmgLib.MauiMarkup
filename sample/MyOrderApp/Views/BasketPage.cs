namespace MyOrderApp.Views;

public partial class BasketPage : BasePage<BasketPageViewModel>
{
    public BasketPage(BasketPageViewModel viewModel) : base(viewModel, "Sepet")
    {
    }

    public override void Build()
    {
        this
            .InvokeOnElement(s => s.Loaded += (sender, e) =>
            {
                BindingContext.GetInfo();
            })
            .Content(
                new Grid()
                .RowDefinitions(e => e.Star(05).Star(60).Star(35))
                .Children(
                    new Label()
                    .Text("SEPET")
                    .Margin(0,5)
                    .FontAttributes(FontAttributes.Bold)
                    .FontSize(20)
                    .CenterHorizontally()
                    .Row(0),

                    new CollectionView()
                    .Row(1)
                    .SelectionMode(SelectionMode.None)
                    .ItemsLayout(new LinearItemsLayout(ItemsLayoutOrientation.Vertical).ItemSpacing(10))
                    .Bind(CollectionView.ItemsSourceProperty, nameof(BindingContext.BasketProducts))
                    .Margin(10,5)
                    .EmptyView(
                        new VerticalStackLayout()
                        .Center()
                        .Children(
                            new Label()
                            .Text("Sepet Boş!")
                            .TextColor(Colors.Red)
                            .FontSize(18)
                            .FontAttributes(FontAttributes.Bold)
                        )
                    )
                    .ItemTemplate(() =>
                        new Frame()
                        .CornerRadius(15)
                        .BorderColor(Colors.DarkGray)
                        .BackgroundColor(Colors.Transparent)
                        .Padding(5)
                        .MinimumWidthRequest(150)
                        .MinimumHeightRequest(90)
                        .Content(
                            new Grid()
                            .ColumnDefinitions(e => e.Star(3).Star(5).Star(2))
                            .Padding(new Thickness(10,5))
                            .Children(
                                new Image()
                                .Bind(Image.SourceProperty, "Product.Image")
                                .SizeRequest(80,80)
                                .Column(0)
                                .CenterVertically(),

                                new VerticalStackLayout()
                                .Column(1)
                                .Spacing(10)
                                .Children(
                                    new Label()
                                    .Bind(Label.TextProperty, "Product.Name")
                                    .FontSize(11)
                                    .FontAttributes(FontAttributes.Italic)
                                    .AlignStart()
                                    .LineBreakMode(LineBreakMode.TailTruncation),

                                    new Frame()
                                    .BorderColor(Colors.DarkGray)
                                    .HeightRequest(50)
                                    .WidthRequest(120)
                                    .AlignStart()
                                    .Padding(0)
                                    .Content(
                                        new HorizontalStackLayout()
                                        .Spacing(8)
                                        .Center()
                                        .Children(
                                            new Button()
                                            .Text("-")
                                            .FontAttributes(FontAttributes.Bold)
                                            .BorderColor(Colors.DarkGray)
                                            .BackgroundColor(Colors.Transparent)
                                            .TextColor(Colors.Black)
                                            .BorderWidth(2)
                                            .CornerRadius(25)
                                            .HeightRequest(35)
                                            .WidthRequest(35)
                                            .Padding(0)
                                            .FontSize(20)
                                            .Command(BindingContext.RemoveCountCommand)
                                            .CommandParameter(e => e.Path(".")),

                                            new Label()
                                            .Bind(Label.TextProperty, "Count")
                                            .FontAttributes(FontAttributes.Bold)
                                            .TextCenter()
                                            .FontSize(18),

                                            new Button()
                                            .Text("+")
                                            .FontAttributes(FontAttributes.Bold)
                                            .BorderColor(Colors.DarkGray)
                                            .BackgroundColor(Colors.Transparent)
                                            .TextColor(Colors.Black)
                                            .BorderWidth(2)
                                            .CornerRadius(25)
                                            .HeightRequest(35)
                                            .WidthRequest(35)
                                            .Padding(0)
                                            .FontSize(20)
                                            .Command(BindingContext.AddCountCommand)
                                            .CommandParameter(e => e.Path("."))
                                        )
                                    )
                                ),
                                new VerticalStackLayout()
                                .Spacing(20)
                                .Column(2)
                                .AlignEnd()
                                .Children(
                                    new Image()
                                    .Source("remove.png")
                                    .SizeRequest(25,25)
                                    .BackgroundColor(Colors.Transparent)
                                    .GestureRecognizers(
                                        new TapGestureRecognizer()
                                        .Command(BindingContext.RemoveProductCommand)
                                        .CommandParameter(e => e.Path("."))
                                    ),

                                    new VerticalStackLayout()
                                    .Spacing(0)
                                    .Children(
                                        new Label()
                                        .Bind(Label.TextProperty, "Product.Price")
                                        .FontSize(10),

                                        new Label()
                                        .Bind(Label.TextProperty, "TotalPrice")
                                        .FontAttributes(FontAttributes.Bold)
                                        .TextCenter()
                                        .FontSize(18)
                                    )
                                )
                            )
                        )
                    ),

                    new Grid()
                    .Row(2)
                    .ColumnDefinitions(e => e.Star(7).Star(3))
                    .RowDefinitions(e => e.Auto().Auto().Auto().Auto())
                    .RowSpacing(7)
                    .AlignBottom()
                    .Margin(10)
                    .Children(
                        new Label()
                        .Text("Ürünler Toplamı")
                        .Column(0)
                        .Row(0),

                        new Label()
                        .Bind(Label.TextProperty, nameof(BindingContext.TotalProductPrice))
                        .Column(1)
                        .Row(0)
                        .AlignEnd(),

                        new Label()
                        .Text("KDV")
                        .Column(0)
                        .Row(1),

                        new Label()
                        .Bind(Label.TextProperty, nameof(BindingContext.TotalKdv))
                        .Column(1)
                        .Row(1)
                        .AlignEnd(),

                        new Label()
                        .Text("TOPLAM")
                        .FontAttributes(FontAttributes.Bold)
                        .FontSize(16)
                        .Column(0)
                        .Row(2),

                        new Label()
                        .Bind(Label.TextProperty, nameof(BindingContext.TotalPrice))
                        .FontAttributes(FontAttributes.Bold)
                        .FontSize(16)
                        .Column(1)
                        .Row(2)
                        .AlignEnd(),

                        new Button()
                        .Text("SİPARİŞ ET")
                        .WidthRequest(150)
                        .CenterHorizontally()
                        .ColumnSpan(2)
                        .Column(0)
                        .Row(3)
                        .Command(BindingContext.CompletedCommand)
                    )
                )
            );
    }
}
