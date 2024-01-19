namespace MyOrderApp.Views;

public partial class BasketPage : BasePage<BasketPageViewModel>
{
    public BasketPage(BasketPageViewModel viewModel) : base(viewModel, "Sepet")
    {
    }

    public override void Build()
    {
        this
            .InvokeOnElementFmg(s => s.Loaded += (sender, e) =>
            {
                BindingContext.GetInfo();
            })
            .ContentFmg(
                new Grid()
                .RowDefinitionsFmg(e => e.Star(05).Star(60).Star(35))
                .ChildrenFmg(
                    new Label()
                    .TextFmg("SEPET")
                    .MarginFmg(0,5)
                    .FontAttributesFmg(FontAttributes.Bold)
                    .FontSizeFmg(20)
                    .CenterHorizontalFmg()
                    .RowFmg(0),

                    new CollectionView()
                    .RowFmg(1)
                    .SelectionModeFmg(SelectionMode.None)
                    .ItemsLayoutFmg(new LinearItemsLayout(ItemsLayoutOrientation.Vertical).ItemSpacingFmg(10))
                    .BindFmg(CollectionView.ItemsSourceProperty, nameof(BindingContext.BasketProducts))
                    .MarginFmg(10,5)
                    .EmptyViewFmg(
                        new VerticalStackLayout()
                        .CenterFmg()
                        .ChildrenFmg(
                            new Label()
                            .TextFmg("Sepet Boş!")
                            .TextColorFmg(Colors.Red)
                            .FontSizeFmg(18)
                            .FontAttributesFmg(FontAttributes.Bold)
                        )
                    )
                    .ItemTemplateFmg(() =>
                        new Frame()
                        .CornerRadiusFmg(15)
                        .BorderColorFmg(Colors.DarkGray)
                        .BackgroundColorFmg(Colors.Transparent)
                        .PaddingFmg(5)
                        .MinimumWidthRequestFmg(150)
                        .MinimumHeightRequestFmg(90)
                        .ContentFmg(
                            new Grid()
                            .ColumnDefinitionsFmg(e => e.Star(3).Star(5).Star(2))
                            .PaddingFmg(new Thickness(10,5))
                            .ChildrenFmg(
                                new Image()
                                .BindFmg(Image.SourceProperty, "Product.Image")
                                .SizeRequestFmg(80,80)
                                .ColumnFmg(0)
                                .CenterVerticalFmg(),

                                new VerticalStackLayout()
                                .ColumnFmg(1)
                                .SpacingFmg(10)
                                .ChildrenFmg(
                                    new Label()
                                    .BindFmg(Label.TextProperty, "Product.Name")
                                    .FontSizeFmg(11)
                                    .FontAttributesFmg(FontAttributes.Italic)
                                    .AlignStartFmg()
                                    .LineBreakModeFmg(LineBreakMode.TailTruncation),

                                    new Frame()
                                    .BorderColorFmg(Colors.DarkGray)
                                    .HeightRequestFmg(50)
                                    .WidthRequestFmg(120)
                                    .AlignStartFmg()
                                    .PaddingFmg(0)
                                    .ContentFmg(
                                        new HorizontalStackLayout()
                                        .SpacingFmg(8)
                                        .CenterFmg()
                                        .ChildrenFmg(
                                            new Button()
                                            .TextFmg("-")
                                            .FontAttributesFmg(FontAttributes.Bold)
                                            .BorderColorFmg(Colors.DarkGray)
                                            .BackgroundColorFmg(Colors.Transparent)
                                            .TextColorFmg(Colors.Black)
                                            .BorderWidthFmg(2)
                                            .CornerRadiusFmg(25)
                                            .HeightRequestFmg(35)
                                            .WidthRequestFmg(35)
                                            .PaddingFmg(0)
                                            .FontSizeFmg(20)
                                            .CommandFmg(BindingContext.RemoveCountCommand)
                                            .CommandParameterFmg(e => e.PathFmg(".")),

                                            new Label()
                                            .BindFmg(Label.TextProperty, "Count")
                                            .FontAttributesFmg(FontAttributes.Bold)
                                            .TextCenterFmg()
                                            .FontSizeFmg(18),

                                            new Button()
                                            .TextFmg("+")
                                            .FontAttributesFmg(FontAttributes.Bold)
                                            .BorderColorFmg(Colors.DarkGray)
                                            .BackgroundColorFmg(Colors.Transparent)
                                            .TextColorFmg(Colors.Black)
                                            .BorderWidthFmg(2)
                                            .CornerRadiusFmg(25)
                                            .HeightRequestFmg(35)
                                            .WidthRequestFmg(35)
                                            .PaddingFmg(0)
                                            .FontSizeFmg(20)
                                            .CommandFmg(BindingContext.AddCountCommand)
                                            .CommandParameterFmg(e => e.PathFmg("."))
                                        )
                                    )
                                ),
                                new VerticalStackLayout()
                                .SpacingFmg(20)
                                .ColumnFmg(2)
                                .AlignEndFmg()
                                .ChildrenFmg(
                                    new Image()
                                    .SourceFmg("remove.png")
                                    .SizeRequestFmg(25,25)
                                    .BackgroundColorFmg(Colors.Transparent)
                                    .GestureRecognizersFmg(
                                        new TapGestureRecognizer()
                                        .CommandFmg(BindingContext.RemoveProductCommand)
                                        .CommandParameterFmg(e => e.PathFmg("."))
                                    ),

                                    new VerticalStackLayout()
                                    .SpacingFmg(0)
                                    .ChildrenFmg(
                                        new Label()
                                        .BindFmg(Label.TextProperty, "Product.Price")
                                        .FontSizeFmg(10),

                                        new Label()
                                        .BindFmg(Label.TextProperty, "TotalPrice")
                                        .FontAttributesFmg(FontAttributes.Bold)
                                        .TextCenterFmg()
                                        .FontSizeFmg(18)
                                    )
                                )
                            )
                        )
                    ),

                    new Grid()
                    .RowFmg(2)
                    .ColumnDefinitionsFmg(e => e.Star(7).Star(3))
                    .RowDefinitionsFmg(e => e.Auto().Auto().Auto().Auto())
                    .RowSpacingFmg(7)
                    .AlignBottomFmg()
                    .MarginFmg(10)
                    .ChildrenFmg(
                        new Label()
                        .TextFmg("Ürünler Toplamı")
                        .ColumnFmg(0)
                        .RowFmg(0),

                        new Label()
                        .BindFmg(Label.TextProperty, nameof(BindingContext.TotalProductPrice))
                        .ColumnFmg(1)
                        .RowFmg(0)
                        .AlignEndFmg(),

                        new Label()
                        .TextFmg("KDV")
                        .ColumnFmg(0)
                        .RowFmg(1),

                        new Label()
                        .BindFmg(Label.TextProperty, nameof(BindingContext.TotalKdv))
                        .ColumnFmg(1)
                        .RowFmg(1)
                        .AlignEndFmg(),

                        new Label()
                        .TextFmg("TOPLAM")
                        .FontAttributesFmg(FontAttributes.Bold)
                        .FontSizeFmg(16)
                        .ColumnFmg(0)
                        .RowFmg(2),

                        new Label()
                        .BindFmg(Label.TextProperty, nameof(BindingContext.TotalPrice))
                        .FontAttributesFmg(FontAttributes.Bold)
                        .FontSizeFmg(16)
                        .ColumnFmg(1)
                        .RowFmg(2)
                        .AlignEndFmg(),

                        new Button()
                        .TextFmg("SİPARİŞ ET")
                        .WidthRequestFmg(150)
                        .CenterHorizontalFmg()
                        .ColumnSpanFmg(2)
                        .ColumnFmg(0)
                        .RowFmg(3)
                        .CommandFmg(BindingContext.CompletedCommand)
                    )
                )
            );
    }
}
