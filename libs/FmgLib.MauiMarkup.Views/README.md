```csharp
global using FmgLib.MauiMarkup;
global using FmgLib.MauiMarkup.Views;

namespace Sample.Controls;

public partial class MyPopup : Popup
{
    public MyPopup()
    {
        this
            .CanBeDismissedByTappingOutsideOfPopupFmg(false)
            .ColorFmg(Colors.Transparent)
            .ContentFmg(
                new Grid()
                .ChildrenFmg(
                    new Frame()
                    .CornerRadiusFmg(25)
                    .ContentFmg(
                        new VerticalStackLayout()
                        .FillHorizontalFmg()
                        .FillVerticalFmg()
                        .MarginFmg(10)
                        .ChildrenFmg(

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
                )
            );
    }
}

```