using SkiaSharp.Extended.UI.Controls;

namespace MyOrderApp.Controls;

public partial class MyPopup : Popup
{
    public MyPopup()
    {
        CanBeDismissedByTappingOutsideOfPopup = false;
        Color = Colors.Transparent;
        Content = new Grid()
            .ChildrenFmg(
                new Frame()
                .CornerRadiusFmg(25)
                .ContentFmg(
                    new VerticalStackLayout()
                    .FillHorizontalFmg()
                    .FillVerticalFmg()
                    .MarginFmg(10)
                    .ChildrenFmg(
                        new SKLottieView()
                        .SKSourceFmg(new SKFileLottieImageSource.FileFmg("completed.json"))
                        .RepeatCountFmg(-1)
                        .HeightRequestFmg(250)
                        .WidthRequestFmg(200),

                        new Button()
                        .TextFmg("Ana Sayfa")
                        .FontAttributesFmg(FontAttributes.Bold)
                        .BackgroundColorFmg(Colors.DarkBlue)
                        .TextColorFmg(Colors.White)
                        .HeightRequestFmg(35)
                        .WidthRequestFmg(120)
                        .PaddingFmg(0)
                        .InvokeOnElementFmg(b => b.Clicked += async (sender, e) =>
                        {
                            await CloseAsync();
                        })
                    )
                )
            );
    }
}
