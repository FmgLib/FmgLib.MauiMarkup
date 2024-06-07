using SkiaSharp.Extended.UI.Controls;

namespace MyOrderApp.Controls;

public partial class MyPopup : Popup
{
    public MyPopup()
    {
        CanBeDismissedByTappingOutsideOfPopup = false;
        Color = Colors.Transparent;
        Content = new Grid()
            .Children(
                new Frame()
                .CornerRadius(25)
                .Content(
                    new VerticalStackLayout()
                    .FillHorizontal()
                    .FillVertical()
                    .Margin(10)
                    .Children(
                        new SKLottieView()
                        .Source(new SKFileLottieImageSource { File = "completed.json" })
                        .RepeatCount(-1)
                        .HeightRequest(250)
                        .WidthRequest(200),

                        new Button()
                        .Text("Ana Sayfa")
                        .FontAttributes(FontAttributes.Bold)
                        .BackgroundColor(Colors.DarkBlue)
                        .TextColor(Colors.White)
                        .HeightRequest(35)
                        .WidthRequest(120)
                        .Padding(0)
                        .InvokeOnElement(b => b.Clicked += async (sender, e) =>
                        {
                            await CloseAsync();
                        })
                    )
                )
            );
    }
}
