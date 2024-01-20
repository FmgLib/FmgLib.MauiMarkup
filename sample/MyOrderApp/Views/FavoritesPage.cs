namespace MyOrderApp.Views;

public partial class FavoritesPage : BasePage<FavoritesPageViewModel>
{
    public FavoritesPage(FavoritesPageViewModel viewModel) : base(viewModel, "Favoriler")
    {
    }

    public override void Build()
    {
        this
        .ContentFmg(
            new ScrollView()
            .ContentFmg(
                new VerticalStackLayout()
                .FillVerticalFmg()
                .ChildrenFmg(
                    new SearchBar()
                    .PlaceholderFmg("Ürünlerde Ara.")
                    .AssignFmg(out var search)
                    .MarginFmg(10)
                    .SearchCommandFmg(BindingContext.SearchCommand)
                    .BindFmg(SearchBar.SearchCommandParameterProperty, "Text", source: search)
                    .InvokeOnElementFmg(s => s.TextChanged += (sender, e) =>
                    {
                        if (search.Text.Length == 0)
                            BindingContext.SearchCommand.Execute(null);
                    }),

                    new CollectionView()
                    .SelectionModeFmg(SelectionMode.None)
                    .MarginFmg(10)
                    .BindFmg(CollectionView.ItemsSourceProperty, "Products")
                    .ItemsLayoutFmg(
                            new GridItemsLayout(ItemsLayoutOrientation.Vertical)
                            .SpanFmg(2)
                            .HorizontalItemSpacingFmg(10)
                            .VerticalItemSpacingFmg(10)
                    )
                    .EmptyViewFmg(
                        new VerticalStackLayout()
                        .ChildrenFmg(
                            new Label()
                            .TextFmg("Kayıt Yoktur.")
                            .TextColorFmg(Colors.Red)
                            .FontAttributesFmg(FontAttributes.Bold)
                            .FontSizeFmg(18)
                        )
                        .CenterFmg()
                    )
                    .ItemTemplateFmg(() =>
                        new Frame()
                        .CornerRadiusFmg(15)
                        .BorderColorFmg(Colors.LightGray)
                        .BackgroundColorFmg(Colors.LightGray)
                        .MinimumHeightRequestFmg(200)
                        .MaximumWidthRequestFmg(175)
                        .PaddingFmg(5)
                        .ContentFmg(
                            new Grid()
                            .RowDefinitionsFmg(e => e.Star(1).Star(6).Star(2).Star(1))
                            .PaddingFmg(5)
                            .MarginFmg(5)
                            .ChildrenFmg(
                                new Grid()
                                .RowFmg(0)
                                .ColumnDefinitionsFmg(e => e.Star(6).Star(4))
                                .ChildrenFmg(
                                    new ImageButton()
                                    .BindFmg(ImageButton.SourceProperty, nameof(ProductVM.IsFavorite), converter: new BoolToFavoriteImageConverter())
                                    .BackgroundColorFmg(Colors.Transparent)
                                    .AlignStartFmg()
                                    .SizeRequestFmg(30, 30)
                                    .CommandFmg(BindingContext.ChangeFavoriteCommand)
                                    .BindFmg(ImageButton.CommandParameterProperty, "."),

                                    new Frame()
                                    .CornerRadiusFmg(20)
                                    .HeightRequestFmg(25)
                                    .WidthRequestFmg(50)
                                    .PaddingFmg(0)
                                    .BackgroundColorFmg(Colors.Red)
                                    .BorderColorFmg(Colors.Red)
                                    .ColumnFmg(1)
                                    .BindFmg(Microsoft.Maui.Controls.Frame.IsVisibleProperty, nameof(ProductVM.IsDiscount))
                                    .ContentFmg(
                                        new Label()
                                        .BindFmg(Label.TextProperty, nameof(ProductVM.DiscountRate))
                                        .FontSizeFmg(11)
                                        .FontAttributesFmg(FontAttributes.Bold)
                                        .TextColorFmg(Colors.White)
                                        .CenterFmg()
                                    )
                                ),

                                new Image()
                                .BindFmg(Image.SourceProperty, nameof(ProductVM.Image))
                                .SizeRequestFmg(100, 100)
                                .MarginFmg(0)
                                .RowFmg(1)
                                .CenterHorizontalFmg(),

                                new VerticalStackLayout()
                                .RowFmg(2)
                                .ChildrenFmg(
                                    new Label()
                                    .BindFmg(Label.TextProperty, nameof(ProductVM.Name))
                                    .FontAttributesFmg(FontAttributes.Bold)
                                    .FontSizeFmg(11)
                                    .AlignStartFmg()
                                    .LineBreakModeFmg(LineBreakMode.TailTruncation)
                                    .FontAutoScalingEnabledFmg(true),

                                    new HorizontalStackLayout()
                                    .SpacingFmg(2)
                                    .ChildrenFmg(
                                        new Label()
                                        .BindFmg(Label.TextProperty, nameof(ProductVM.Price))
                                        .BindFmg(Label.TextDecorationsProperty, nameof(ProductVM.IsDiscount), converter: new BoolToTextDecorationConverter())
                                        .BindFmg(Label.FontSizeProperty, nameof(ProductVM.IsDiscount), converter: new BoolToFontSizeConverter())
                                        .FontAttributesFmg(FontAttributes.Bold)
                                        .CenterVerticalFmg(),

                                        new Label()
                                        .TextColorFmg(Colors.Red)
                                        .FontAttributesFmg(FontAttributes.Bold)
                                        .CenterVerticalFmg()
                                        .BindFmg(Label.IsVisibleProperty, nameof(ProductVM.IsDiscount))
                                        .BindFmg(Label.TextProperty, nameof(ProductVM.DiscountPrice)),

                                        new Label()
                                        .TextFmg("/")
                                        .FontSizeFmg(10)
                                        .CenterVerticalFmg()
                                        .TextColorFmg(Colors.DarkSlateGray),

                                        new Label()
                                        .FontSizeFmg(10)
                                        .CenterVerticalFmg()
                                        .TextColorFmg(Colors.DarkSlateGray)
                                        .BindFmg(Label.TextProperty, nameof(ProductVM.Unit))
                                    )
                                ),

                                new Button()
                                .RowFmg(3)
                                .MarginFmg(new Thickness(0, 15, 0, 15))
                                .PaddingFmg(0)
                                .TextFmg("Sepete Ekle")
                                .BackgroundColorFmg(Colors.Green)
                                .FontSizeFmg(12)
                                .FontAttributesFmg(FontAttributes.Bold)
                                .CenterHorizontalFmg()
                                .HeightRequestFmg(30)
                                .WidthRequestFmg(100)
                                .CommandFmg(BindingContext.AddProductBasketCommand)
                                .BindFmg(Button.CommandParameterProperty, ".")
                            )
                        )
                    )
                )
            )
        )
        .InvokeOnElementFmg(x => x.Loaded += (sender, e) =>
        {
            BindingContext.GetInfo();
        });
    }
}
