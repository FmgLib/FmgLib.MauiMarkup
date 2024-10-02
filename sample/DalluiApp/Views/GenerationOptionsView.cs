#if ANDROID
using Microsoft.Maui.Controls.Compatibility.Platform.Android;
#endif

using FmgLib.MauiMarkup.Core;

namespace DalluiApp.Views;

public partial class GenerationOptionsView : FmgLibContentPage
{
    public GenerationOptionsView()
    {
        FillOptions();
        BindingContext = this; 
        Microsoft.Maui.Handlers.EditorHandler.Mapper.AppendToMapping("MyCustomization", (handler, view) =>
        {
#if ANDROID

               handler.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Colors.Transparent.ToAndroid());
#elif IOS || MACCATALYST
         
#elif WINDOWS

#endif
        });
    }

    public override void Build()
    {
        this
        .BackgroundColor(Color.FromArgb("#101216"))
        .Content(
            new Grid()
            .Margin(25, 25, 0, 0)
            .RowDefinitions(e => e.Star(2).Star(1).Star(1).Star(3).Star(2).Star(1))
            .Children(
                new VerticalStackLayout()
                .CenterVertical()
                .Children(
                    new Label()
                    .FontFamily("NexaHeavy")
                    .FontSize(30)
                    .Text("Select Options")
                    .TextColor(White),

                    new Label()
                    .Margin(0,10,0,0)
                    .FontSize(20)
                    .Text("Minimum of 6 options")
                    .TextColor(Color.FromArgb("#ACB1BB"))
                ),

                new CollectionView()
                .Row(1)
                .ItemsSource(e => e.Path("Options"))
                .ItemsLayout(new LinearItemsLayout(ItemsLayoutOrientation.Horizontal).ItemSpacing(10))
                .ItemTemplate(
                    new DataTemplate(() => 
                        new Grid().SizeRequest(150,50).Children(
                            new RoundRectangle().CornerRadius(35).Fill("#242529".ToColor()),
                            new Label().Center().TextColor(White).Text(e => e.Path("."))
                        )
                    )
                ),

                new Label()
                .Row(2)
                .FontFamily("NexaHeavy")
                .FontSize(20)
                .TextColor(White)
                .CenterVertical()
                .Text("Choose a style of picture"),

                new CollectionView()
                .Row(3)
                .ItemsSource(e => e.Path("Styles"))
                .ItemsLayout(new LinearItemsLayout(ItemsLayoutOrientation.Horizontal).ItemSpacing(10))
                .ItemTemplate(
                    new DataTemplate(() => 
                        new Grid().Children(
                            new Border()
                            .StrokeShape(new RoundRectangle().CornerRadius(20))
                            .StrokeThickness(0)
                            .Content(
                                new Image().Source(e => e.Path("ImageUrl"))
                            ),

                            new Label()
                            .Margin(0,0,0,10)
                            .FontFamily("NexaHeavy")
                            .FontSize(15)
                            .AlignBottomRight()
                            .HorizontalTextAlignment(TextAlignment.Center)
                            .TextColor(White)
                            .Text(e => e.Path("Name"))
                            .Shadow(
                                new Shadow()
                                .Brush(Black)
                                .Opacity(1)
                                .Radius(1)
                                .Offset(new Point(5,5))
                            )
                        )
                    )
                ),

                new Border()
                .Row(4)
                .Margin(0,15,25,0)
                .BackgroundColor(Color.FromArgb("#242529"))
                .StrokeShape(new RoundRectangle().CornerRadius(20))
                .StrokeThickness(0)
                .Content(
                    new Editor()
                    .Margin(5)
                    .BackgroundColor(Color.FromArgb("#242529"))
                    .TextColor(White)
                ),

                new Button()
                .Row(5)
                .BackgroundColor(Color.FromArgb("#98C0FE"))
                .CornerRadius(25)
                .Center()
                .Text("Generate")
                .TextColor(Black)
                .WidthRequest(150)
                .OnClicked(async (sender, e) =>
                {
                    await AppShell.Current.GoToAsync($"//{nameof(ImageGeneratorView)}");
                })
            )
        );
    }

    public List<string> Options { get; set; }
    public List<ArtStyle> Styles { get; set; }

    private void FillOptions()
    {
        Options = new List<string>
        {
            "World",
            "Winter",
            "Tress"
        };
        Styles = new List<ArtStyle>()
              {
                  new ArtStyle() { Name = "Cartoon", ImageUrl = "cartoon.jpg" },
                  new ArtStyle() { Name = "Realistic", ImageUrl = "realistic.jpg" },
                  new ArtStyle() { Name = "Watercolor Art", ImageUrl = "watercolor.jpg" },
                  new ArtStyle() { Name = "Isometric", ImageUrl = "isometric.jpg" },
                  new ArtStyle() { Name = "Pop Art", ImageUrl = "popart.jpg" },
                  new ArtStyle() { Name = "Surrealism", ImageUrl = "surrealism.jpg" },
                  new ArtStyle() { Name = "Minimalism", ImageUrl = "minimalism.jpg" },
                  new ArtStyle() { Name = "Funko", ImageUrl = "funko.jpg" },
                  new ArtStyle() { Name = "Anime", ImageUrl = "anime.jpg" },
                  new ArtStyle() { Name = "Storybook", ImageUrl = "storybook.jpg" },
              };
    }
}