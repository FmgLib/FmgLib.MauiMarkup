using Microsoft.Maui.Layouts;

namespace MyOrderApp.Views;

public partial class HomePage : BasePage<HomePageViewModel>
{
    public HomePage(HomePageViewModel viewModel) : base(viewModel, "Home Page")
    {
    }

    public override void Build()
    {
        this
        .Content(
            new VerticalStackLayout()
            .Padding(10)
            .Children(
                new SearchBar()
                .Placeholder("Ürünlerde Ara.")
                .Margin(10)
                .Assign(out var search)
                .SearchCommand(BindingContext.SearchCommand)
                .Bind(SearchBar.SearchCommandParameterProperty, "Text", source: search),

                new Frame()
                .CornerRadius(15)
                .BackgroundColor(Colors.Blue)
                .BorderColor(Colors.Blue)
                .HeightRequest(150)
                .Margin(new Thickness(15,7))
                .Padding(0)
                .Content(
                    new Grid()
                    .ColumnDefinitions(e => e.Star(5).Star(5))
                    .RowDefinitions(e => e.Star(5).Star(5))
                    .Children(
                        new Frame()
                        .Row(0)
                        .Column(0)
                        .Margin(new Thickness(0,20,0,0))
                        .Padding(0)
                        .CornerRadius(0)
                        .BackgroundColor(Colors.DarkBlue)
                        .BorderColor(Colors.DarkBlue)
                        .Content(
                            new Label()
                            .Text("%50 İndirim")
                            .TextColor(Colors.White)
                            .FontAttributes(FontAttributes.Bold)
                            .FontSize(20)
                            .Center()
                        ),

                        new Label()
                        .Text("Tüm Unlu Mamüllerde her gün saat 21:00'dan sonra!")
                        .FontSize(12)
                        .Row(1)
                        .Column(0)
                        .TextColor(Colors.White)
                        .FontAttributes(FontAttributes.Italic)
                        .Margin(new Thickness(10,3,0,0)),

                        new Image()
                        .Source("white_bread.png")
                        .Row(0)
                        .Column(1)
                        .RowSpan(2)
                        .SizeRequest(150,100)
                        .Opacity(.8)
                    )
                ),

                new Grid()
                .ColumnDefinitions(e => e.Star(7).Star(3))
                .FillHorizontally()
                .Padding(10)
                .Children(
                    new Label()
                    .Text("Son Ürünler")
                    .FontAttributes(FontAttributes.Bold)
                    .FontSize(18)
                    .CenterVertically()
                    .Column(0)
                    .AlignStart(),


                    new Label()
                    .Text("Tümünü Gör")
                    .FontSize(15)
                    .CenterVertically()
                    .Column(1)
                    .AlignEnd()
                    .TextDecorations(TextDecorations.Underline)
                    .GestureRecognizers(
                        new TapGestureRecognizer()
                        .Command(BindingContext.GotoAllProductsCommand)
                    )
                ),

                new CollectionView()
                .SelectionMode(SelectionMode.None)
                .Bind(CollectionView.ItemsSourceProperty, "Products")
                .ItemsLayout(new LinearItemsLayout(ItemsLayoutOrientation.Horizontal).ItemSpacing(10))
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
                    .MaximumWidthRequest(200)
                    .Padding(5)
                    .Content(
                        new Grid()
                        .RowDefinitions(e => e.Star(1).Star(6).Star(2).Star(1))
                        .Padding(5)
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
                            .SizeRequest(80,80)
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
                            .Margin(new Thickness(0,5,0,0))
                            .Padding(0)
                            .Text("Sepete Ekle")
                            .BackgroundColor(Colors.Green)
                            .FontSize(12)
                            .FontAttributes(FontAttributes.Bold)
                            .CenterHorizontally()
                            .HeightRequest(35)
                            .WidthRequest(100)
                            .Command(BindingContext.AddProductBasketCommand)
                            .Bind(Button.CommandParameterProperty, ".")
                        )
                    )
                ),

                new Grid()
                .ColumnDefinitions(e => e.Star(7).Star(3))
                .FillHorizontally()
                .Padding(10)
                .Children(
                    new Label()
                    .Text("Kategoriler")
                    .FontAttributes(FontAttributes.Bold)
                    .FontSize(18)
                    .CenterVertically()
                    .Column(0)
                    .AlignStart(),


                    new Label()
                    .Text("Tümünü Gör")
                    .FontSize(15)
                    .CenterVertically()
                    .Column(1)
                    .AlignEnd()
                    .TextDecorations(TextDecorations.Underline)
                    .GestureRecognizers(
                        new TapGestureRecognizer()
                        .Command(BindingContext.GotoAllCategoriesCommand)
                    )
                ),

                new FlexLayout()
                .ItemsSources(BindingContext.Categories)
                .Assign(out var flex)
                .Wrap(FlexWrap.Wrap)
                .FlexBasis(FlexBasis.Auto)
                .ItemTemplates(new DataTemplate(() => 
                    new Frame()
                    .CornerRadius(15)
                    .BorderColor(Colors.LightGray)
                    .BackgroundColor(Colors.LightGray)
                    .MinimumHeightRequest(30)
                    .WidthRequest(180)
                    .Padding(0)
                    .Margin(new Thickness(1,0,5,5))
                    .FlexBasis(FlexBasis.Auto)
                    .Content(
                        new Grid()
                        .ColumnDefinitions(e => e.Star(3).Star(7))
                        .Padding(5)
                        .Children(
                            new Image()
                            .Bind(Image.SourceProperty, nameof(SubCategoryVM.Icon))
                            .SizeRequest(30,30)
                            .Column(0)
                            .CenterVertically(),

                            new Label()
                            .Bind(Label.TextProperty, nameof(SubCategoryVM.Name))
                            .TextColor(Colors.CornflowerBlue)
                            .FontAttributes(FontAttributes.Bold)
                            .FontSize(12)
                            .Column(1)
                            .FontAutoScalingEnabled(true)
                            .CenterVertically()
                        )
                    )
                ))
            )
            .FillHorizontally()
        );
    }
}
