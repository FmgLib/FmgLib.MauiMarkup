namespace MyOrderApp.Views;

public partial class ProductsPage : BasePage<ProductsPageViewModel>
{
    public static string Filter {  get; set; }

    public ProductsPage(ProductsPageViewModel viewModel) : base(viewModel, "Ürünler Sayfası")
    {
    }

    public override void Build()
    {
        this
        .Content(
            new ScrollView()
            .Content(
                new VerticalStackLayout()
                .FillVertically()
                .Children(
                    new SearchBar()
                    .Placeholder("Ürünlerde Ara.")
                    .Assign(out var search)
                    .Text(Filter)
                    .Margin(10)
                    .SearchCommand(BindingContext.SearchCommand)
                    .Bind(SearchBar.SearchCommandParameterProperty, "Text", source: search)
                    .InvokeOnElement(s => s.TextChanged += (sender, e) =>
                    {
                        if (search.Text.Length == 0)
                            BindingContext.SearchCommand.Execute(null);
                    }),

                    new CollectionView()
                    .SelectionMode(SelectionMode.None)
                    .Margin(10)
                    .Bind(CollectionView.ItemsSourceProperty, "Products")
                    .ItemsLayout(
                            new GridItemsLayout(ItemsLayoutOrientation.Vertical)
                            .Span(2)
                            .HorizontalItemSpacing(10)
                            .VerticalItemSpacing(10)
                    )
                    .EmptyView(
                        new VerticalStackLayout()
                        .Children(
                            new Label()
                            .Text("Kayıt Yoktur.")
                            .TextColor(Colors.Red)
                            .FontAttributes(FontAttributes.Bold)
                            .FontSize(18)
                        )
                        .Center()
                    )
                    .ItemTemplate(() =>
                        new Frame()
                        .CornerRadius(15)
                        .BorderColor(Colors.LightGray)
                        .BackgroundColor(Colors.LightGray)
                        .MinimumHeightRequest(200)
                        .MaximumWidthRequest(175)
                        .Padding(5)
                        .Content(
                            new Grid()
                            .RowDefinitions(e => e.Star(1).Star(6).Star(2).Star(1))
                            .Padding(5)
                            .Margin(5)
                            .Children(
                                new Grid()
                                .Row(0)
                                .ColumnDefinitions(e => e.Star(6).Star(4))
                                .Children(
                                    new ImageButton()
                                    .Bind(ImageButton.SourceProperty, nameof(ProductVM.IsFavorite), converter: new BoolToFavoriteImageConverter())
                                    .BackgroundColor(Colors.Transparent)
                                    .AlignStart()
                                    .SizeRequest(30, 30)
                                    .Command(BindingContext.ChangeFavoriteCommand)
                                    .Bind(ImageButton.CommandParameterProperty, "."),

                                    new Frame()
                                    .CornerRadius(20)
                                    .HeightRequest(25)
                                    .WidthRequest(50)
                                    .Padding(0)
                                    .BackgroundColor(Colors.Red)
                                    .BorderColor(Colors.Red)
                                    .Column(1)
                                    .Bind(Microsoft.Maui.Controls.Frame.IsVisibleProperty, nameof(ProductVM.IsDiscount))
                                    .Content(
                                        new Label()
                                        .Bind(Label.TextProperty, nameof(ProductVM.DiscountRate))
                                        .FontSize(11)
                                        .FontAttributes(FontAttributes.Bold)
                                        .TextColor(Colors.White)
                                        .Center()
                                    )
                                ),

                                new Image()
                                .Bind(Image.SourceProperty, nameof(ProductVM.Image))
                                .SizeRequest(100, 100)
                                .Margin(0)
                                .Row(1)
                                .CenterHorizontally(),

                                new VerticalStackLayout()
                                .Row(2)
                                .Children(
                                    new Label()
                                    .Bind(Label.TextProperty, nameof(ProductVM.Name))
                                    .FontAttributes(FontAttributes.Bold)
                                    .FontSize(11)
                                    .AlignStart()
                                    .LineBreakMode(LineBreakMode.TailTruncation)
                                    .FontAutoScalingEnabled(true),

                                    new HorizontalStackLayout()
                                    .Spacing(2)
                                    .Children(
                                        new Label()
                                        .Bind(Label.TextProperty, nameof(ProductVM.Price))
                                        .Bind(Label.TextDecorationsProperty, nameof(ProductVM.IsDiscount), converter: new BoolToTextDecorationConverter())
                                        .Bind(Label.FontSizeProperty, nameof(ProductVM.IsDiscount), converter: new BoolToFontSizeConverter())
                                        .FontAttributes(FontAttributes.Bold)
                                        .CenterVertically(),

                                        new Label()
                                        .TextColor(Colors.Red)
                                        .FontAttributes(FontAttributes.Bold)
                                        .CenterVertically()
                                        .Bind(Label.IsVisibleProperty, nameof(ProductVM.IsDiscount))
                                        .Bind(Label.TextProperty, nameof(ProductVM.DiscountPrice)),

                                        new Label()
                                        .Text("/")
                                        .FontSize(10)
                                        .CenterVertically()
                                        .TextColor(Colors.DarkSlateGray),

                                        new Label()
                                        .FontSize(10)
                                        .CenterVertically()
                                        .TextColor(Colors.DarkSlateGray)
                                        .Bind(Label.TextProperty, nameof(ProductVM.Unit))
                                    )
                                ),

                                new Button()
                                .Row(3)
                                .Margin(new Thickness(0, 15, 0, 15))
                                .Padding(0)
                                .Text("Sepete Ekle")
                                .BackgroundColor(Colors.Green)
                                .FontSize(12)
                                .FontAttributes(FontAttributes.Bold)
                                .CenterHorizontally()
                                .HeightRequest(30)
                                .WidthRequest(100)
                                .Command(BindingContext.AddProductBasketCommand)
                                .Bind(Button.CommandParameterProperty, ".")
                            )
                        )
                    )
                )
            )
        )
        .InvokeOnElement(s => s.Loaded += (sender, e) =>
        {
            if (!string.IsNullOrEmpty(Filter))
                BindingContext.SearchCommand.Execute(Filter);
        });
    }
}
