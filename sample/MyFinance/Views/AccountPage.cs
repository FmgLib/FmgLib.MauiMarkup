using DevExpress.CodeParser;
using FmgLib.MauiMarkup;

namespace MyFinance.Views;

public partial class AccountPage(AccountPageViewModel viewModel) : FmgLibContentPage<AccountPageViewModel>(viewModel)
{
    public override void Build()
    {
        this
        .Content(
            new Grid()
            .Margin(15)
            .RowDefinitions(e => e.Star(5).Star(2).Star(3))
            .RowSpacing(5)
            .Children(
                new DC.DXImage()
                .Source("profile.png")
                .SizeRequest(224,224)
                .CenterHorizontal()
                .AlignBottom(),

                new VerticalStackLayout()
                .CenterHorizontal()
                .AlignTop()
                .Row(1)
                .Children(
                    new Label()
                    .FontAttributes(Bold)
                    .TextColor(Black)
                    .Text(e => e.Path("User.Name"))
                    .FontSize(20)
                    .Center(),

                    new Label()
                    .TextColor(Gray)
                    .Text(e => e.Path("User.Email"))
                    .FontSize(18)
                    .Center(),

                    new DXButton()
                    .Icon("edit.png")
                    .IconColor(Black)
                    .BackgroundColor(Transparent)
                    .SizeRequest(50,50)
                    .Center()
                    .InvokeOnElement(b => b.Clicked += B_Clicked)
                ),

                new Button()
                .Text("ÇIKIŞ YAP")
                .BackgroundColor(Black)
                .TextColor(White)
                .Command(e => e.Path("LogoutCommand"))
                .Row(2)
                .AlignBottom(),

                new DXPopup()
                .IsOpen(e => e.Path("IsPopupShow"))
                .AllowScrim(false)
                .AnimationDuration(new TimeSpan(0, 0, 0, 1))
                .VerticalAlignment(PopupVerticalAlignment.Center)
                .HorizontalAlignment(PopupHorizontalAlignment.Center)
                .BackgroundColor(LightGray)
                .RowSpan(3)
                .Content(
                    new ScrollView()
                    .Content(
                        new VerticalStackLayout()
                        .Spacing(15)
                        .Padding(new Thickness(25,15))
                        .Children(
                            new TextEdit()
                            .LabelText("First Name")
                            .Text(e => e.Path("UserModel.FirstName")),

                            new TextEdit()
                            .LabelText("Last Name")
                            .Text(e => e.Path("UserModel.LastName")),

                            new TextEdit()
                            .LabelText("Email")
                            .Text(e => e.Path("UserModel.Email")),

                            new PasswordEdit()
                            .LabelText("Password")
                            .Text(e => e.Path("UserModel.Password")),

                            new PasswordEdit()
                            .LabelText("Password (Repeat)")
                            .Text(e => e.Path("UserModel.Password")),

                            new TextEdit()
                            .LabelText("Phone")
                            .Keyboard(Telephone)
                            .Text(e => e.Path("UserModel.PhoneNumber")),

                            new TextEdit()
                            .LabelText("Age")
                            .Keyboard(Numeric)
                            .Text(e => e.Path("UserModel.Age")),

                            new ComboBoxEdit()
                            .SelectedIndex(e => e.Path("UserModel.Gender"))
                            .ItemsSource(new List<string>
                            {
                                "Male",
                                "Female"
                            }),

                            new Button()
                            .Text("KAYDET")
                            .BackgroundColor(DeepSkyBlue)
                            .TextColor(Black)
                            .FontSize(15)
                            .Command(e => e.Path("SaveCommand")),

                            new Button()
                            .Text("İPTAL")
                            .BackgroundColor(DarkGray)
                            .TextColor(White)
                            .FontSize(15)
                            .Command(e => e.Path("CloseDetailsPopupCommand"))
                        )
                    )
                ),

                new DXPopup()
                .IsOpen(e => e.Path("IsInfoPopupShow"))
                .AllowScrim(false)
                .AnimationDuration(new TimeSpan(0, 0, 0, 1))
                .VerticalAlignment(PopupVerticalAlignment.Center)
                .HorizontalAlignment(PopupHorizontalAlignment.Center)
                .BackgroundColor(e => e.Path("InfoPopupColor"))
                .RowSpan(3)
                .Content(
                    new Grid()
                    .WidthRequest(250)
                    .HeightRequest(150)
                    .Padding(0)
                    .Children(
                        new Frame()
                        .CornerRadius(25)
                        .BackgroundColor(e => e.Path("InfoPopupColor"))
                        .BorderColor(e => e.Path("InfoPopupColor"))
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
                                .Text(e => e.Path("InfoPopupTitle"))
                                .FontAttributes(Bold)
                                .FontSize(18)
                                .TextColor(Black)
                                .Center()
                                .Row(0),

                                new Label()
                                .Text(e => e.Path("InfoPopupDesc"))
                                .FontAttributes(Italic)
                                .LineBreakMode(WordWrap)
                                .FontSize(12)
                                .TextColor(Black)
                                .Center()
                                .Row(1),

                                new Button()
                                .Text("OK")
                                .TextColor(Black)
                                .FontAttributes(Bold)
                                .FontSize(15)
                                .Row(2)
                                .HeightRequest(30)
                                .BackgroundColor(DeepSkyBlue)
                                .CenterHorizontal()
                                .Padding(0)
                                .Command(e => e.Path("ClosePopupCommand"))
                            )
                        )
                    )
                )
            )
        );
    }

    private void B_Clicked(object? sender, EventArgs e)
    {
        viewModel?.ShowDetailsCommand.Execute(null);
    }
}
