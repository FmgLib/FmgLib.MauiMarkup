﻿namespace MyOrderApp.Views;

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
                .FillVertical()
                .Children(
                    new SearchBar()
                    .Placeholder("Ürünlerde Ara.")
                    .Assign(out var search)
                    .Text(Filter)
                    .Margin(10)
                    .SearchCommand(BindingContext.SearchCommand)
                    .SearchCommandParameter(e => e.Path("Text").Source(search))
                    .InvokeOnElement(s => s.TextChanged += (sender, e) =>
                    {
                        if (search.Text.Length == 0)
                            BindingContext.SearchCommand.Execute(null);
                    }),

                    new CollectionView()
                    .SelectionMode(SelectionMode.None)
                    .Margin(10)
                    .ItemsSource(e => e.Path("Products"))
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
                                    .Source(e => e.Path(nameof(ProductVM.IsFavorite)).Converter(new BoolToFavoriteImageConverter()))
                                    .BackgroundColor(Colors.Transparent)
                                    .AlignStart()
                                    .SizeRequest(30, 30)
                                    .Command(BindingContext.ChangeFavoriteCommand)
                                    .CommandParameter(e => e.Path(".")),

                                    new Frame()
                                    .CornerRadius(20)
                                    .HeightRequest(25)
                                    .WidthRequest(50)
                                    .Padding(0)
                                    .BackgroundColor(Colors.Red)
                                    .BorderColor(Colors.Red)
                                    .Column(1)
                                    .IsVisible(e => e.Path(nameof(ProductVM.IsDiscount)))
                                    .Content(
                                        new Label()
                                        .Text(e => e.Path(nameof(ProductVM.DiscountRate)))
                                        .FontSize(11)
                                        .FontAttributes(FontAttributes.Bold)
                                        .TextColor(Colors.White)
                                        .Center()
                                    )
                                ),

                                new Image()
                                .Source(e => e.Path(nameof(ProductVM.Image)))
                                .SizeRequest(100, 100)
                                .Margin(0)
                                .Row(1)
                                .CenterHorizontal(),

                                new VerticalStackLayout()
                                .Row(2)
                                .Children(
                                    new Label()
                                    .Text(e => e.Path(nameof(ProductVM.Name)))
                                    .FontAttributes(FontAttributes.Bold)
                                    .FontSize(11)
                                    .AlignStart()
                                    .LineBreakMode(LineBreakMode.TailTruncation)
                                    .FontAutoScalingEnabled(true),

                                    new HorizontalStackLayout()
                                    .Spacing(2)
                                    .Children(
                                        new Label()
                                        .Text(e => e.Path(nameof(ProductVM.Price)))
                                        .TextDecorations(e => e.Path(nameof(ProductVM.IsDiscount)).Converter(new BoolToTextDecorationConverter()))
                                        .FontSize(e => e.Path(nameof(ProductVM.IsDiscount)).Converter(new BoolToFontSizeConverter()))
                                        .FontAttributes(FontAttributes.Bold)
                                        .CenterVertical(),

                                        new Label()
                                        .TextColor(Colors.Red)
                                        .FontAttributes(FontAttributes.Bold)
                                        .CenterVertical()
                                        .IsVisible(e => e.Path(nameof(ProductVM.IsDiscount)))
                                        .Text(e => e.Path(nameof(ProductVM.DiscountPrice))),

                                        new Label()
                                        .Text("/")
                                        .FontSize(10)
                                        .CenterVertical()
                                        .TextColor(Colors.DarkSlateGray),

                                        new Label()
                                        .FontSize(10)
                                        .CenterVertical()
                                        .TextColor(Colors.DarkSlateGray)
                                        .Text(e => e.Path(nameof(ProductVM.Unit)))
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
                                .CenterHorizontal()
                                .HeightRequest(30)
                                .WidthRequest(100)
                                .Command(BindingContext.AddProductBasketCommand)
                                .CommandParameter(e => e.Path("."))
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
