### Free .NET Libraries by FmgLib.MauiMakrup

| NuGet Package | Link |
|--------------|------|
| `FmgLib.MauiMarkup` | [![NuGet](https://buildstats.info/nuget/FmgLib.MauiMarkup?includePreReleases=true)](https://www.nuget.org/packages/FmgLib.MauiMarkup/) |
| `FmgLib.MauiMarkup.Core` | [![NuGet](https://buildstats.info/nuget/FmgLib.MauiMarkup.Core?includePreReleases=true)](https://www.nuget.org/packages/FmgLib.MauiMarkup.Core/) |
| `FmgLib.MauiMarkup.Generator` | [![NuGet](https://buildstats.info/nuget/FmgLib.MauiMarkup.Generator?includePreReleases=true)](https://www.nuget.org/packages/FmgLib.MauiMarkup.Generator/) |
| `FmgLib.MauiMarkup.Template` | [![NuGet](https://buildstats.info/nuget/FmgLib.MauiMarkup.Template?includePreReleases=true)](https://www.nuget.org/packages/FmgLib.MauiMarkup.Template/) |



# **FmgLib.MauiMarkup**

FmgLib.MauiMarkup is a specialized library crafted for .NET MAUI. This library allows you to code directly in C# without the necessity of employing XAML language. It provides developers with a straightforward and flexible approach to building user interfaces using C# code. With FmgLib.MauiMarkup, you can now develop application interfaces in a code-focused manner, avoiding the complexities of dealing with XAML files. This library accelerates your development process while enabling you to write more readable and manageable code.

FmgLib.MauiMarkup provides extension methods for all properties provided for a View on the XAML side.

# Getting Started

### Creating a new FmgLib.MauiMarkup project from CLI

FmgLib provides a project template to start a new project with FmgLib.MauiMarkup.

**Install latest templates from NuGet:**
```bash
dotnet new install FmgLib.MauiMarkup.Template
```


**Create a new project:**

```bash
dotnet new fmglib-mauimarkup-app -o my-new-project
```

<br>

### Existing Projects

Install the [FmgLib.MauiMarkup](https://www.nuget.org/packages/FmgLib.MauiMarkup/) NuGet package to your MAUI application.
```bash
dotnet add package FmgLib.MauiMarkup
```



For example:

If we were to write XAML code for the Image class, it would look like this:
```xaml
<Image
    Source="dotnet_bot.png"
    HeightRequest="100"
    WidthRequest="150"
    Grid.Row="0"
    Grid.Column="1"
    Grid.RowSpan="2"
    Opacity=".8" />
```

The C# equivalent with the help of FmgLib.MauiMarkup would be as follows:
```csharp
new Image()
.Source("dotnet_bot.png")
.Row(0)
.Column(1)
.RowSpan(2)
.SizeRequest(150,100)
.Opacity(.8)
```

Similarly, we can see this for other Views. Let's write a few sample codes as an example:
```csharp
new Label()
.Text("fmglib.mauimarkup")
.FontSize(12)
.Row(1)
.TextColor(Colors.Green)
.FontAttributes(FontAttributes.Bold)
.Margin(new Thickness(5,3,0,5))
```

```csharp
this
.BackgroundImageSource("background.jpg")
.Content(
    new StackLayout()
    .Center()
    .Children(
        new ActivityIndicator()
        .IsRunning(true)
        .HeightRequest(70)
        .WidthRequest(70)
        .Center()
        .InvokeOnElement(ai => ai.Loaded += CheckLogin(sender, e))
    )
);
```

## Extensions for 3rd Party Controls

FmgLib.MauiMarkup library can also generate extension methods for controls from third-party libraries. To achieve this, you should utilize the MauiMarkupAttribute provided by FmgLib.MauiMarkup.

Simply specify the control for which you want to create extension methods as `[MauiMarkup(typeof(YourControl))]`.

The constructor method of the `MauiMarkup()` attribute automatically generates extension methods for BindableProperties and Events found within the type provided as an argument. **You can provide a minimum of 1 and a maximum of 5 types inside the constructor method.** *Multiple MauiMarkup attributes can be added to a single class.*

Let's look at an example:

```csharp
using FmgLib.MauiMarkup;

namespace GeneratedExam;

[MauiMarkup(typeof(ZXing.Net.Maui.Controls.BarcodeGeneratorView))]
public class MyBarcodeGeneratorView { }

[MauiMarkup(typeof(ZXing.Net.Maui.Controls.CameraView))]
public class MyCameraView { }


[MauiMarkup(typeof(ZXing.Net.Maui.Controls.CameraBarcodeReaderView))]
public class MyCameraBarcodeReaderView { }

[MauiMarkup(typeof(SkiaSharp.Extended.UI.Controls.SKLottieView))]
public class MySkLottieView { }

```

Or instead of dealing with it like this, it can be used like this:

```csharp

using Microsoft.Extensions.Logging;
using FmgLib.MauiMarkup;
using SkiaSharp.Extended.UI.Controls;
using ZXing.Net.Maui.Controls;
using UraniumUI.Material.Controls;
namespace MauiApp1
{
    [MauiMarkup(typeof(CameraView))]
    [MauiMarkup(typeof(SKLottieView), typeof(SKFileLottieImageSource), typeof(DataGrid))]
    [MauiMarkup(typeof(SKConfettiView), typeof(BarcodeGeneratorView),typeof(InputField),typeof(EditorField),typeof(TextField))]
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            return builder.Build();
        }
    }
}
```

For example, let's write the sample code for the **TextField and SKLottieView Controls**:

```csharp
new TextField()
.Title("Password")
.TitleColor(Colors.LightGray)
.AccentColor(Colors.CadetBlue)
.TextColor(Colors.White)
.IsPassword(true),

new SKLottieView()
.Source(new SKFileLottieImageSource().File("iconapp.json"))
.RepeatCount(-1)
.HeightRequest(250)
.WidthRequest(250)
```

**Genral Example Code:**
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
                        .Source("white_board.png")
                        .Row(0)
                        .Column(1)
                        .RowSpan(2)
                        .SizeRequest(150,100)
                        .Opacity(.8)
                    )
                ),

                new Grid()
                .ColumnDefinitions(e => e.Star(7).Star(3))
                .FillHorizontal()
                .Padding(10)
                .Children(
                    new Label()
                    .Text("Son Ürünler")
                    .FontAttributes(FontAttributes.Bold)
                    .FontSize(18)
                    .CenterVertical()
                    .Column(0)
                    .AlignStart(),


                    new Label()
                    .Text("Tümünü Gör")
                    .FontSize(15)
                    .CenterVertical()
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
                            .CenterHorizontal(),

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
                                    .CenterVertical(),

                                    new Label()
                                    .TextColor(Colors.Red)
                                    .FontAttributes(FontAttributes.Bold)
                                    .CenterVertical()
                                    .Bind(Label.IsVisibleProperty, nameof(ProductVM.IsDiscount))
                                    .Bind(Label.TextProperty, nameof(ProductVM.DiscountPrice)),

                                    new Label()
                                    .Text("/")
                                    .FontSize(10)
                                    .CenterVertical()
                                    .TextColor(Colors.DarkSlateGray),

                                    new Label()
                                    .FontSize(10)
                                    .CenterVertical()
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
                            .CenterHorizontal()
                            .HeightRequest(35)
                            .WidthRequest(100)
                            .Command(BindingContext.AddProductBasketCommand)
                            .Bind(Button.CommandParameterProperty, ".")
                        )
                    )
                ),

                new Grid()
                .ColumnDefinitions(e => e.Star(7).Star(3))
                .FillHorizontal()
                .Padding(10)
                .Children(
                    new Label()
                    .Text("Kategoriler")
                    .FontAttributes(FontAttributes.Bold)
                    .FontSize(18)
                    .CenterVertical()
                    .Column(0)
                    .AlignStart(),


                    new Label()
                    .Text("Tümünü Gör")
                    .FontSize(15)
                    .CenterVertical()
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
                            .CenterVertical(),

                            new Label()
                            .Bind(Label.TextProperty, nameof(SubCategoryVM.Name))
                            .TextColor(Colors.CornflowerBlue)
                            .FontAttributes(FontAttributes.Bold)
                            .FontSize(12)
                            .Column(1)
                            .FontAutoScalingEnabled(true)
                            .CenterVertical()
                        )
                    )
                ))
            )
            .FillHorizontal()
        );
    }
}


```
