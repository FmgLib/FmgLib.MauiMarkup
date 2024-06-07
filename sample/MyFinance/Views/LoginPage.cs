using CommunityToolkit.Maui.Core;

namespace MyFinance.Views;

public partial class LoginPage(LoginPageViewModel viewModel) : FmgLibContentPage<LoginPageViewModel>(viewModel)
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
            .RowDefinitions(e => e.Star(3).Star(2.5).Star(2).Star(2.5))
            .RowSpacing(15)
            .Margin(20, 15)
            .Children(
                (IView)new VerticalStackLayout()
                .Spacing(10)
                .Children(
                    new HorizontalStackLayout()
                    .CenterHorizontal()
                    .Spacing(5)
                    .Margin(0, 25, 0, 0)
                    .Children(
                        new Label()
                        .Text("My")
                        .TextColor(DeepSkyBlue)
                        .FontSize(44)
                        .FontAttributes(Bold),

                        new Label()
                        .Text("FINANCE")
                        .TextColor(Black)
                        .FontSize(44)
                        .FontAttributes(Bold)
                    ),

                    new Label()
                    .Text("Welcome back")
                    .TextColor(Black)
                    .FontSize(25)
                    .FontAttributes(Bold)
                    .Margin(0,30,0,0),

                    new Label()
                    .Text("Please enter your details")
                    .TextColor(Black)
                    .FontSize(15)
                    .FontAttributes(Italic)
                ),

                new VerticalStackLayout()
                .Spacing(15)
                .Row(1)
                .Children( 
                    new TextEdit()
                    .LabelText("Email")
                    .Text(e => e.Path("Login.Username")),

                    new PasswordEdit()
                    .LabelText("Password")
                    .Text(e => e.Path("Login.Password")),

                    new Grid()
                    .ColumnDefinitions(e => e.Star().Star())
                    .FillHorizontal()
                    .Children(
                        new CheckEdit()
                        .Label("Remember for 30 days")
                        .AlignStart()
                        .IsChecked(e => e.Path("Login.IsRememberMe")),

                         new Label()
                         .Text("Forget password")
                         .TextColor(DeepSkyBlue)
                         .TextDecorations(Underline)
                         .TextCenterVertical()
                         .Column(1)
                         .AlignEnd()
                    )
                ),

                new VerticalStackLayout()
                .Row(2)
                .Spacing(20)
                .Children(
                     new Button()
                    .Text("Sign in")
                    .BackgroundColor(DeepSkyBlue)
                    .TextColor(Black)
                    .FontSize(15)
                    .Command(e => e.Path("LoginCommand")),

                     new HorizontalStackLayout()
                     .CenterHorizontal()
                     .Spacing(5)
                     .Children(
                         new Label()
                        .Text("Don't have an account? ")
                        .TextColor(Black)
                        .FontAttributes(Italic)
                        .FontSize(16),

                         new Label()
                         .Text("Sign up")
                         .TextColor(DeepSkyBlue)
                         .TextDecorations(Underline)
                         .GestureRecognizers(
                             new TapGestureRecognizer()
                             .Command(e => e.Path("GoToRegisterCommand"))
                         )
                     )
                ),

                new HorizontalStackLayout()
                .Row(3)
                .Center()
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

                new GeneralPopup("HATA", "Kullanıcı Adı veya Şifre Hatalı!!! ", "OK", PopupType.Error)
                .RowSpan(4)
                .IsOpen(e => e.Path("IsPopupShow"))
            )
        );
    }
}
