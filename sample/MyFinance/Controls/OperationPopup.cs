using DevExpress.CodeParser;

namespace MyFinance.Controls;

public partial class OperationPopup : DXPopup
{
    public static bool RESULT = false;
    public OperationPopup(string title, string desc, string okBtnTxt = "OK", string cancelBtnTxt = "Cancel", PopupType pType = PopupType.Info, bool allowScrim = false)
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

                        new HorizontalStackLayout()
                        .ColumnSpan(2)
                        .Row(2)
                        .Spacing(10)
                        .CenterHorizontal()
                        .Children(
                            new Button()
                            .Text(cancelBtnTxt)
                            .FontAttributes(Bold)
                            .FontSize(15)
                            .WidthRequest(100)
                            .IsVisible(pType == PopupType.Warning)
                            .BackgroundColor(IndianRed)
                            .Padding(0)
                            .HeightRequest(27)
                            .OnClicked((sender, e) =>
                            {
                                RESULT = false;
                                IsOpen = false;
                            }),

                            new Button()
                            .Text(okBtnTxt)
                            .FontAttributes(Bold)
                            .FontSize(15)
                            .WidthRequest(100)
                            .HeightRequest(25)
                            .BackgroundColor(DeepSkyBlue)
                            .AlignEnd()
                            .Padding(0)
                            .HeightRequest(27)
                            .OnClicked((sender, e) =>
                            {
                                RESULT = true;
                                IsOpen = false;
                            })
                        )
                    )
                )
            )
        );
    }
}
