### Free .NET Libraries by FmgLib.MauiMakrup

| NuGet Package | Link |
|--------------|------|
| `FmgLib.MauiMarkup` | [![NuGet](https://buildstats.info/nuget/FmgLib.MauiMarkup?includePreReleases=true)](https://www.nuget.org/packages/FmgLib.MauiMarkup/) |
| `FmgLib.MauiMarkup.Core` | [![NuGet](https://buildstats.info/nuget/FmgLib.MauiMarkup.Core?includePreReleases=true)](https://www.nuget.org/packages/FmgLib.MauiMarkup.Core/) |
| `FmgLib.MauiMarkup.Views` | [![NuGet](https://buildstats.info/nuget/FmgLib.MauiMarkup.Views?includePreReleases=true)](https://www.nuget.org/packages/FmgLib.MauiMarkup.Views/) |
| `FmgLib.MauiMarkup.Maps` | [![NuGet](https://buildstats.info/nuget/FmgLib.MauiMarkup.Maps?includePreReleases=true)](https://www.nuget.org/packages/FmgLib.MauiMarkup.Maps/) |
| `FmgLib.MauiMarkup.SkiaSharp` | [![NuGet](https://buildstats.info/nuget/FmgLib.MauiMarkup.SkiaSharp?includePreReleases=true)](https://www.nuget.org/packages/FmgLib.MauiMarkup.SkiaSharp/) |
| `FmgLib.MauiMarkup.UraniumUI` | [![NuGet](https://buildstats.info/nuget/FmgLib.MauiMarkup.UraniumUI?includePreReleases=true)](https://www.nuget.org/packages/FmgLib.MauiMarkup.UraniumUI/) |
| `FmgLib.MauiMarkup.MediaElements` | [![NuGet](https://buildstats.info/nuget/FmgLib.MauiMarkup.MediaElements?includePreReleases=true)](https://www.nuget.org/packages/FmgLib.MauiMarkup.MediaElements/) |
| `FmgLib.MauiMarkup.DataGrid` | [![NuGet](https://buildstats.info/nuget/FmgLib.MauiMarkup.DataGrid?includePreReleases=true)](https://www.nuget.org/packages/FmgLib.MauiMarkup.DataGrid/) |
| `FmgLib.MauiMarkup.ZXing` | [![NuGet](https://buildstats.info/nuget/FmgLib.MauiMarkup.ZXing?includePreReleases=true)](https://www.nuget.org/packages/FmgLib.MauiMarkup.ZXing/) |
| `FmgLib.MauiMarkup.SimpleToolkit` | [![NuGet](https://buildstats.info/nuget/FmgLib.MauiMarkup.SimpleToolkit?includePreReleases=true)](https://www.nuget.org/packages/FmgLib.MauiMarkup.SimpleToolkit/) |

```csharp

using Microsoft.Maui.Layouts;
using FmgLib.MauiMarkup;

namespace MyOrderApp.Views;

public partial class HomePage : BasePage<HomePageViewModel>
{
    public HomePage(HomePageViewModel viewModel) : base(viewModel, "Home Page")
    {
    }

    public override void Build()
    {
        this
        .ContentFmg(
            new VerticalStackLayout()
            .PaddingFmg(10)
            .ChildrenFmg(
                new SearchBar()
                .PlaceholderFmg("Ürünlerde Ara.")
                .MarginFmg(10)
                .AssignFmg(out var search)
                .SearchCommandFmg(BindingContext.SearchCommand)
                .BindFmg(SearchBar.SearchCommandParameterProperty, "Text", source: search),

                new Frame()
                .CornerRadiusFmg(15)
                .BackgroundColorFmg(Colors.Blue)
                .BorderColorFmg(Colors.Blue)
                .HeightRequestFmg(150)
                .MarginFmg(new Thickness(15,7))
                .PaddingFmg(0)
                .ContentFmg(
                    new Grid()
                    .ColumnDefinitionsFmg(e => e.Star(5).Star(5))
                    .RowDefinitionsFmg(e => e.Star(5).Star(5))
                    .ChildrenFmg(
                        new Frame()
                        .RowFmg(0)
                        .ColumnFmg(0)
                        .MarginFmg(new Thickness(0,20,0,0))
                        .PaddingFmg(0)
                        .CornerRadiusFmg(0)
                        .BackgroundColorFmg(Colors.DarkBlue)
                        .BorderColorFmg(Colors.DarkBlue)
                        .ContentFmg(
                            new Label()
                            .TextFmg("%50 İndirim")
                            .TextColorFmg(Colors.White)
                            .FontAttributesFmg(FontAttributes.Bold)
                            .FontSizeFmg(20)
                            .CenterFmg()
                        ),

                        new Label()
                        .TextFmg("Tüm Unlu Mamüllerde her gün saat 21:00'dan sonra!")
                        .FontSizeFmg(12)
                        .RowFmg(1)
                        .ColumnFmg(0)
                        .TextColorFmg(Colors.White)
                        .FontAttributesFmg(FontAttributes.Italic)
                        .MarginFmg(new Thickness(10,3,0,0)),

                        new Image()
                        .SourceFmg("white_bread.png")
                        .RowFmg(0)
                        .ColumnFmg(1)
                        .RowSpanFmg(2)
                        .SizeRequestFmg(150,100)
                        .OpacityFmg(.8)
                    )
                ),

                new Grid()
                .ColumnDefinitionsFmg(e => e.Star(7).Star(3))
                .FillHorizontalFmg()
                .PaddingFmg(10)
                .ChildrenFmg(
                    new Label()
                    .TextFmg("Son Ürünler")
                    .FontAttributesFmg(FontAttributes.Bold)
                    .FontSizeFmg(18)
                    .CenterVerticalFmg()
                    .ColumnFmg(0)
                    .AlignStartFmg(),


                    new Label()
                    .TextFmg("Tümünü Gör")
                    .FontSizeFmg(15)
                    .CenterVerticalFmg()
                    .ColumnFmg(1)
                    .AlignEndFmg()
                    .TextDecorationsFmg(TextDecorations.Underline)
                    .GestureRecognizersFmg(
                        new TapGestureRecognizer()
                        .CommandFmg(BindingContext.GotoAllProductsCommand)
                    )
                ),

                new CollectionView()
                .SelectionModeFmg(SelectionMode.None)
                .BindFmg(CollectionView.ItemsSourceProperty, "Products")
                .ItemsLayoutFmg(new LinearItemsLayout(ItemsLayoutOrientation.Horizontal).ItemSpacingFmg(10))
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
                    .MaximumWidthRequestFmg(200)
                    .PaddingFmg(5)
                    .ContentFmg(
                        new Grid()
                        .RowDefinitionsFmg(e => e.Star(1).Star(6).Star(2).Star(1))
                        .PaddingFmg(5)
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
                            .SizeRequestFmg(80,80)
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
                            .MarginFmg(new Thickness(0,5,0,0))
                            .PaddingFmg(0)
                            .TextFmg("Sepete Ekle")
                            .BackgroundColorFmg(Colors.Green)
                            .FontSizeFmg(12)
                            .FontAttributesFmg(FontAttributes.Bold)
                            .CenterHorizontalFmg()
                            .HeightRequestFmg(35)
                            .WidthRequestFmg(100)
                            .CommandFmg(BindingContext.AddProductBasketCommand)
                            .BindFmg(Button.CommandParameterProperty, ".")
                        )
                    )
                ),

                new Grid()
                .ColumnDefinitionsFmg(e => e.Star(7).Star(3))
                .FillHorizontalFmg()
                .PaddingFmg(10)
                .ChildrenFmg(
                    new Label()
                    .TextFmg("Kategoriler")
                    .FontAttributesFmg(FontAttributes.Bold)
                    .FontSizeFmg(18)
                    .CenterVerticalFmg()
                    .ColumnFmg(0)
                    .AlignStartFmg(),


                    new Label()
                    .TextFmg("Tümünü Gör")
                    .FontSizeFmg(15)
                    .CenterVerticalFmg()
                    .ColumnFmg(1)
                    .AlignEndFmg()
                    .TextDecorationsFmg(TextDecorations.Underline)
                    .GestureRecognizersFmg(
                        new TapGestureRecognizer()
                        .CommandFmg(BindingContext.GotoAllCategoriesCommand)
                    )
                ),

                new FlexLayout()
                .ItemsSourcesFmg(BindingContext.Categories)
                .AssignFmg(out var flex)
                .WrapFmg(FlexWrap.Wrap)
                .FlexBasisFmg(FlexBasis.Auto)
                .ItemTemplatesFmg(new DataTemplate(() => 
                    new Frame()
                    .CornerRadiusFmg(15)
                    .BorderColorFmg(Colors.LightGray)
                    .BackgroundColorFmg(Colors.LightGray)
                    .MinimumHeightRequestFmg(30)
                    .WidthRequestFmg(180)
                    .PaddingFmg(0)
                    .MarginFmg(new Thickness(1,0,5,5))
                    .FlexBasisFmg(FlexBasis.Auto)
                    .ContentFmg(
                        new Grid()
                        .ColumnDefinitionsFmg(e => e.Star(3).Star(7))
                        .PaddingFmg(5)
                        .ChildrenFmg(
                            new Image()
                            .BindFmg(Image.SourceProperty, nameof(SubCategoryVM.Icon))
                            .SizeRequestFmg(30,30)
                            .ColumnFmg(0)
                            .CenterVerticalFmg(),

                            new Label()
                            .BindFmg(Label.TextProperty, nameof(SubCategoryVM.Name))
                            .TextColorFmg(Colors.CornflowerBlue)
                            .FontAttributesFmg(FontAttributes.Bold)
                            .FontSizeFmg(12)
                            .ColumnFmg(1)
                            .FontAutoScalingEnabledFmg(true)
                            .CenterVerticalFmg()
                        )
                    )
                ))
            )
            .FillHorizontalFmg()
        );
    }
}


```
