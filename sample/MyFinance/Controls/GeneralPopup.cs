namespace MyFinance.Controls;

public partial class GeneralPopup : DXPopup
{
    public GeneralPopup(string title, string desc, string okBtnTxt = "OK", PopupType pType = PopupType.Info, bool allowScrim = false, string okBtnCommand = "OkBtnPopupCommand")
    {
        var color = pType == PopupType.Info ? SkyBlue : pType == PopupType.Warning ? DarkOrange : Red;

        this
        .AllowScrim(allowScrim)
        .AnimationDuration(new TimeSpan(0, 0, 0, 1))
        .VerticalAlignment(PopupVerticalAlignment.Center)
        .HorizontalAlignment(PopupHorizontalAlignment.Center)
        .BackgroundColor(color)
        .Content(
            new Grid()
            .WidthRequest(250)
            .HeightRequest(150)
            .Padding(0)
            .Children(
                new Frame()
                .CornerRadius(25)
                .BackgroundColor(color)
                .BorderColor(color)
                .FillBothDirections()
                .Padding(0)
                .Content(
                    new Grid()
                    .RowDefinitions(e => e.Star(2).Star(7).Star(1))
                    .FillBothDirections()
                    .Margin(10)
                    .Padding(10)
                    .Children(
                        new Label()
                        .Text(title)
                        .FontAttributes(Bold)
                        .FontSize(18)
                        .TextColor(Black)
                        .Center()
                        .Row(0),

                        new Label()
                        .Text(desc)
                        .FontAttributes(Italic)
                        .LineBreakMode(WordWrap)
                        .FontSize(12)
                        .TextColor(Black)
                        .Center()
                        .Row(1),

                        new Button()
                        .Text(okBtnTxt)
                        .TextColor(Black)
                        .FontAttributes(Bold)
                        .FontSize(15)
                        .Row(2)
                        .HeightRequest(30)
                        .BackgroundColor(DeepSkyBlue)
                        .CenterHorizontal()
                        .Padding(0)
                        .Command(e => e.Path(okBtnCommand))
                        .OnClicked((sender, e) =>
                        {
                            IsOpen = false;
                        })
                    )
                )
            )
        );
    }
}
