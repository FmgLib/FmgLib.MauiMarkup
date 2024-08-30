using DXImage = DevExpress.Maui.Core.DXImage;

namespace MyFinance.Views;

public partial class MainPage(MainPageViewModel viewModel) : FmgLibContentPage<MainPageViewModel>(viewModel)
{
    public override void Build()
    {
        this
        .Content(
            new Grid()
            .RowDefinitions(e => e.Star(.8).Star(1.2).Star(1.2).Star(6.8))
            .Spacing(15)
            .Margin(20,20,20,10)
            .Children(
                new HorizontalStackLayout()
                .AlignLeft()
                .Spacing(5)
                .Children(
                    new DXImage()
                    .Source("profile.png")
                    .SizeRequest(60,60),

                    new VerticalStackLayout()
                    .CenterVertical()
                    .Children(
                        new Label()
                        .FontAttributes(Bold)
                        .TextColor(Black)
                        .Text(e => e.Path("User.Name")),

                        new Label()
                        .TextColor(Gray)
                        .Text(e => e.Path("User.Email"))
                    )
                ),

                new VerticalStackLayout()
                .Spacing(-3)
                .Row(1)
                .Children(
                    new Label()
                    .FontAttributes(Bold)
                    .TextColor(Black)
                    .Text("Total balance"),

                    new Grid()
                    .RowDefinitions(e => e.Star().Star())
                    .ColumnDefinitions(e => e.Star(7).Star(3))
                    .Spacing(10,3)
                    .Children(
                        new Label()
                        .Text(e => e.Path("TotalBalance"))
                        .FontAttributes(Bold)
                        .FontSize(40)
                        .RowSpan(2),

                        new Label()
                        .Text(e => e.Path("TotalIncome"))
                        .TextColor(Green)
                        .FontSize(12)
                        .Column(1)
                        .AlignBottomRight(),

                        new Label()
                        .Text(e => e.Path("TotalExpense"))
                        .TextColor(Red)
                        .FontSize(12)
                        .Column(1)
                        .Row(1)
                        .AlignTopRight()
                    )
                ),

                new Grid()
                .ColumnDefinitions(e => e.Star().Star())
                .ColumnSpacing(10)
                .Row(2)
                .Children(
                    new DXButton()
                    .HeightRequest(100)
                    .Content("Buy")
                    .TextColor(White)
                    .FontSize(16)
                    .ButtonType(Accent)
                    .Icon("up_arrow.png")
                    .IconColor(Red)
                    .CornerRadius(new CornerRadius(20))
                    .BackgroundColor(Black),

                    new DXButton()
                    .HeightRequest(100)
                    .Content("Sell")
                    .TextColor(Black)
                    .FontSize(16)
                    .ButtonType(Accent)
                    .Icon("down_arrow.png")
                    .IconColor(Green)
                    .CornerRadius(new CornerRadius(20))
                    .BackgroundColor(DeepSkyBlue)
                    .BorderColor(Black)
                    .BorderThickness(1)
                    .Column(1)
                ),

                new Frame()
                .CornerRadius(20)
                .BorderColor(Black)
                .BackgroundColor(Transparent)
                .Row(3)
                .Content(
                    new Grid()
                    .FillBothDirections()
                    .RowDefinitions(e => e.Star(0.6).Star(0.05).Star(9.35))
                    .Children(
                        new Label()
                        .FontAttributes(Bold)
                        .TextColor(Black)
                        .Text("Watchlist"),

                        new Label()
                        .FontAttributes(Bold)
                        .TextColor(Black)
                        .Text("Son 10 İşlem ")
                        .AlignRight(),

                        new Border()
                        .StrokeThickness(1)
                        .Row(1),

                        new DXCollectionView()
                        .ItemsSource(e => e.Path("Items"))
                        .Row(2)
                        .ItemTemplate(() =>
                            new Grid()
                            .RowDefinitions(e => e.Star().Star())
                            .ColumnDefinitions(e => e.Star(1).Star(6).Star(3))
                            .Spacing(5)
                            .Margin(5)
                            .Children(
                                new DXImage()
                                .Source(e => e.Path("Icon"))
                                .SizeRequest(30,30)
                                .RowSpan(2),

                                new Label()
                                .FontAttributes(Bold)
                                .TextColor(Black)
                                .Text(e => e.Path("Title"))
                                .AlignBottom()
                                .Column(1),

                                new Label()
                                .TextColor(DarkGray)
                                .Text(e => e.Path("Description"))
                                .FontSize(12)
                                .FontAttributes(Italic)
                                .AlignTop()
                                .Column(1)
                                .Row(1),

                                new Label()
                                .Text(e => e.Path("Date"))
                                .TextColor(DarkGray)
                                .FontSize(10)
                                .Column(2)
                                .AlignBottomRight(),

                                new Label()
                                .Text(e => e.Path("Amount"))
                                .TextColor(e => e.Path("Color"))
                                .FontSize(12)
                                .Column(2)
                                .Row(1)
                                .AlignTopRight()
                            )
                        )
                    )
                )
            )
        );
    }
}
