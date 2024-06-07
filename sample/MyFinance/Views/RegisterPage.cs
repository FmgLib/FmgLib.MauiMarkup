using CommunityToolkit.Maui.Core;

namespace MyFinance.Views;

public partial class RegisterPage(RegisterPageViewModel viewModel) : FmgLibContentPage<RegisterPageViewModel>(viewModel)
{
    public override void Build()
    {
        this
        .ShellNavBarIsVisible(false)
        .Behaviors(
            new StatusBarBehavior()
            .StatusBarColor(White)
            .StatusBarStyle(StatusBarStyle.DarkContent)
        )
        .Content(
            new Grid()
            .RowDefinitions(e => e.Star(1.2).Star(7.4).Star(1).Star(0.4))
            .Margin(20,10)
            .RowSpacing(5)
            .Children(
                (IView)new VerticalStackLayout()
                .Spacing(5)
                .Children(
                    new HorizontalStackLayout()
                    .CenterHorizontal()
                    .Spacing(5)
                    //.Margin(0, 25, 0, 0)
                    .Children(
                        new Label()
                        .Text("My")
                        .TextColor(DeepSkyBlue)
                        .FontSize(25)
                        .FontAttributes(Bold),

                        new Label()
                        .Text("FINANCE")
                        .TextColor(Black)
                        .FontSize(25)
                        .FontAttributes(Bold)
                    ),

                    new VerticalStackLayout()
                    .Spacing(3)
                    .Children(
                        new Label()
                        .Text("Welcome to our app")
                        .TextColor(Black)
                        .FontSize(15)
                        .FontAttributes(Bold),

                        new Label()
                        .Text("Create a free account")
                        .TextColor(Black)
                        .FontSize(12)
                        .FontAttributes(Italic)
                    )
                ),

                new VerticalStackLayout()
                .Spacing(5)
                .Row(1)
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
                    })
                ),

                new VerticalStackLayout()
                .Row(2)
                .Spacing(10)
                .Children(
                     new Button()
                    .Text("Sign up")
                    .BackgroundColor(DeepSkyBlue)
                    .TextColor(Black)
                    .FontSize(15)
                    .Command(e => e.Path("RegisterCommand")),

                     new HorizontalStackLayout()
                     .CenterHorizontal()
                     .Spacing(5)
                     .Children(
                         new Label()
                        .Text("Already have an account? ")
                        .TextColor(Black)
                        .FontAttributes(Italic)
                        .FontSize(14),

                         new Label()
                         .Text("Sign in")
                         .TextColor(DeepSkyBlue)
                         .TextDecorations(Underline)
                         .GestureRecognizers(
                             new TapGestureRecognizer()
                             .Command(e => e.Path("GoToLoginCommand"))
                         )
                     )
                ),

                new HorizontalStackLayout()
                .Row(3)
                .CenterHorizontal()
                .AlignBottom()
                .Spacing(5)
                .Children(
                    new Label()
                    .Text("By ")
                    .TextColor(Black)
                    .FontAttributes(Italic)
                    .FontSize(16),

                    new Label()
                    .Text("FmgLib.MauiMarkup")
                    .TextColor(DeepSkyBlue)
                    .FontAttributes(Bold)
                    .FontSize(18)
                ),

                new GeneralPopup("BİLGİ", "Kullanıcı Başarılı Şekilde Eklendi. ", "OK", PopupType.Info)
                .RowSpan(4)
                .IsOpen(e => e.Path("IsInfoPopupShow")),

                new GeneralPopup("HATA", "İşlem sırasında beklenmeyen bir hata oluştu! ", "OK", PopupType.Error)
                .RowSpan(4)
                .IsOpen(e => e.Path("IsErrorPopupShow"))
            )
        );
    }
}
