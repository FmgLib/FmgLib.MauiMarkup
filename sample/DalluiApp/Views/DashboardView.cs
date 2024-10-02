using System.Collections.ObjectModel;

namespace DalluiApp.Views;

public partial class DashboardView : FmgLibContentPage
{
    public ObservableCollection<Profile> Profiles { get; set; }
    public ObservableCollection<GeneratedImage> GeneratedImages { get; set; }

    public DashboardView()
    {
        LoadData();
        BindingContext = this;
    }

    public override void Build()
    {
        this
        .BackgroundColor(Color.FromArgb("$101216"))
        .Content(
            new Grid()
            .Margin(25,25,0,0)
            .RowDefinitions(e => e.Star(10).Star(20).Star(15).Star(45).Star(10))
            .Children(
                new Grid()
                .Margin(0,0,25,0)
                .ColumnDefinitions(e => e.Star().Star())
                .Children(
                    new VerticalStackLayout()
                    .CenterVertical()
                    .Children(
                        new Rectangle()
                        .Fill(Color.FromArgb("#CACDD3"))
                        .SizeRequest(25,2)
                        .AlignTopLeft(),

                         new Rectangle()
                         .Margin(0,5,0,0)
                        .Fill(Color.FromArgb("#CACDD3"))
                        .SizeRequest(35, 2)
                        .AlignTopLeft()
                    ),

                    new Border()
                    .Column(1)
                    .SizeRequest(75)
                    .AlignBottomRight()
                    .StrokeShape(new RoundRectangle().CornerRadius(new CornerRadius(80)))
                    .Content(
                        new Image()
                        .Source("profilesquare.png")
                        .Aspect(Aspect.AspectFill)
                        .SizeRequest(100)
                        .CenterHorizontal()
                    )
                ),

                new VerticalStackLayout()
                .Row(1)
                .CenterVertical()
                .Children(
                    new Label()
                    .FontFamily("NexaHeavy")
                    .FontSize(30)
                    .Text("Create incredible universes")
                    .TextColor(White),

                    new Label()
                    .Margin(0,10,0,0)
                    .FontFamily("NexaHeavy")
                    .FontSize(20)
                    .Text("Join your friends")
                    .TextColor(Color.FromArgb("#ACB1BB"))
                ),

                new CollectionView()
                .Row(2)
                .ItemsSource(e => e.Path("Profiles"))
                .CenterVertical()
                .ItemsLayout(new LinearItemsLayout(ItemsLayoutOrientation.Horizontal).ItemSpacing(10))
                .ItemTemplate(
                    new DataTemplate(() => 
                        new Grid()
                        .ColumnDefinitions(e => e.Star(35).Star(65))
                        .SizeRequest(160,60)
                        .Children(
                            new RoundRectangle()
                            .ColumnSpan(2)
                            .CornerRadius(45)
                            .Fill(Color.FromArgb("#1F252A")),

                            new Border()
                            .RowSpan(2)
                            .Margin(5,0,0,0)
                            .SizeRequest(50)
                            .AlignLeft()
                            .StrokeShape(new RoundRectangle().CornerRadius(80))
                            .StrokeThickness(0)
                            .Content(
                                new Image()
                                .HeightRequest(50)
                                .Source(e => e.Path("ProfileImage"))
                            ),

                            new VerticalStackLayout()
                            .Column(1)
                            .CenterVertical()
                            .Children(
                                new Label()
                                .Margin(10,0,0,0)
                                .FontFamily("NexaHeavy")
                                .HorizontalTextAlignment(TextAlignment.Start)
                                .VerticalTextAlignment(TextAlignment.Center)
                                .TextColor(White)
                                .Text(e => e.Path("Name")),

                                new Label()
                                .Column(1)
                                .Margin(10,0,0,0)
                                .FontFamily("NexaHeavy")
                                .FontSize(12)
                                .Text(e => e.Path("NoPhotos").StringFormat("{0} pictures"))
                                .TextColor(Color.FromArgb("#869CBD"))
                                .AlignLeft()
                            )
                        )
                    )
                ),
                
                new CoverFlowView(new CoverFlowProcessor() { OpacityFactor = 0.25, ScaleFactor = 0.75 })
                .Row(3)
                .Margin(-25,0,25,0)
                .ItemsSource(e => e.Path("GeneratedImages"))
                .PositionShiftValue(125)
                .ItemTemplate(
                    new DataTemplate(() => 
                        new Border()
                        .StrokeShape(new RoundRectangle().CornerRadius(25))
                        .StrokeThickness(0)
                        .Content(
                            new Grid()
                            .RowDefinitions(e => e.Star(7).Star(3))
                            .Children(
                                new Image()
                                .Source(e => e.Path("ImagePath"))
                                .RowSpan(2)
                                .Aspect(Aspect.AspectFill),

                                new Grid()
                                .Row(1)
                                .Children(
                                    new Rectangle()
                                    .Fill(Black)
                                    .Opacity(.5)
                                    .StrokeThickness(0),

                                    new VerticalStackLayout()
                                    .Margin(10,0,0,0)
                                    .CenterVertical()
                                    .Children(
                                        new Label()
                                        .Text(e => e.Path("MainKeyword"))
                                        .FontFamily("NexaHeavy")
                                        .FontSize(25)
                                        .TextColor(White),

                                        new Label()
                                        .FontFamily("NexaLight")
                                        .FontSize(15)
                                        .Text(e => e.Path("Keywords").Converter(new ListToStringConverter() { Separator = "," }))
                                        .TextColor(White)
                                    )
                                )
                            )
                        )
                    )
                 ),

                new Border()
                .Row(4)
                .Margin(0,15,0,0)
                .AlignBottomRight()
                .StrokeShape(new RoundRectangle().CornerRadius(new CornerRadius(55,0,0,0)))
                .WidthRequest(250)
                .Content(
                    new Button()
                    .CornerRadius(0)
                    .BackgroundColor(Color.FromArgb("#E8FF8E"))
                    .FontFamily("NexaHeavy")
                    .FontSize(16)
                    .Text("Create new Image")
                    .TextColor(Color.FromArgb("#101216"))
                    .OnClicked(async (sender, e) =>
                    {
                        await AppShell.Current.GoToAsync($"//{nameof(GenerationOptionsView)}");
                    })
                )
            )
        );
    }

    private void LoadData()
    {
        Profiles = new ObservableCollection<Profile>
          {
               new Profile
               {
                    Name = "Mustafa",
                    ProfileImage = "profile1.jpg",
                    NoPhotos = 12
               },
               new Profile
               {
                    Name = "Maddy",
                    ProfileImage = "profile2.jpg",
                    NoPhotos = 5
               },
               new Profile
               {
                    Name = "Henry",
                    ProfileImage = "profile3.jpg",
                    NoPhotos = 25
               },
          };

        GeneratedImages = new ObservableCollection<GeneratedImage>
          {
               new GeneratedImage
               {
                    ImagePath = "dashboard1.jpg",
                    MainKeyword = "Castle",
                    Keywords = new List<string>{
                         "Epic, hill, mountain, trees, blue sky"
                    }
               },
               new GeneratedImage
               {
                    ImagePath = "dashboard2.jpg",
                    MainKeyword = "Mountains",
                    Keywords = new List<string>{
                         "Landscape, photorealistic, dawn, mountains, moon"
                    }
               },
               new GeneratedImage
               {
                    ImagePath = "dashboard3.jpg",
                    MainKeyword = "Robot",
                    Keywords = new List<string>{
                         "AI, robotic, human, light, metal"
                    }
               },
          };
    }
}
