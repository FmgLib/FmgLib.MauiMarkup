namespace MyOrderApp.Views;

public partial class RegisterPage : BasePage<RegisterPageViewModel>
{
    public RegisterPage(RegisterPageViewModel viewModel) : base(viewModel, "Kayıt Sayfası")
    {
    }

    public override void Build()
    {
        this
            .BackgroundImageSource("background.jpg")
            .Content(
                new VerticalStackLayout()
                .Children(
                    new Frame()
                    .Content(
                        new VerticalStackLayout()
                        .Children(
                            new Entry()
                            .Placeholder("Ad Soyad Girin.")
                            .PlaceholderColor(Colors.Gray)
                            .TextColor(Colors.White)
                            .Assign(out Entry fullname)
                            .Bind(Entry.TextProperty, "User.FullName"),

                            new Entry()
                            .Placeholder("Kullanıcı Adı Girin.")
                            .PlaceholderColor(Colors.Gray)
                            .TextColor(Colors.White)
                            .Assign(out Entry username)
                            .Bind(Entry.TextProperty, "User.Username"),

                            new Entry()
                            .Placeholder("Şifre Girin.")
                            .PlaceholderColor(Colors.Gray)
                            .TextColor(Colors.White)
                            .IsPassword(true)
                            .Assign(out Entry password)
                            .Bind(Entry.TextProperty, "User.Password"),

                            

                            new Button()
                            .Text("KAYDET")
                            .FontAttributes(FontAttributes.Bold)
                            .IsEnabled(false)
                            .Bind(Button.CommandProperty, "RegisterCommand")
                            .Triggers(
                                new MultiTrigger(typeof(Button))
                                .Conditions(
                                    new BindingCondition()
                                    .Binding(b => b
                                                    .Path("Text.Length")
                                                    .Source(username)
                                                    .Converter(new TextLengthToBoolConverter()))
                                    .Value(false)

                                )
                                .Setters(new Setters<Button>(e => e.IsEnabled(false))),

                                new MultiTrigger(typeof(Button))
                                .Conditions(
                                    new BindingCondition()
                                    .Binding(b => b
                                                    .Path("Text.Length")
                                                    .Source(password)
                                                    .Converter(new TextLengthToBoolConverter()))
                                    .Value(false)

                                )
                                .Setters(new Setters<Button>(e => e.IsEnabled(false))),

                                new MultiTrigger(typeof(Button))
                                .Conditions(
                                    new BindingCondition()
                                    .Binding(b => b
                                                    .Path("Text.Length")
                                                    .Source(username)
                                                    .Converter(new TextLengthToBoolConverter()))
                                    .Value(true),

                                    new BindingCondition()
                                    .Binding(b => b
                                                    .Path("Text.Length")
                                                    .Source(password)
                                                    .Converter(new TextLengthToBoolConverter()))
                                    .Value(true)
                                )
                                .Setters(new Setters<Button>(e => e.IsEnabled(true)))
                            ),

                            new Label()
                            .Text("Hesabım Var! Giriş Yap.")
                            .TextColor(Colors.LightGray)
                            .CenterHorizontally()
                            .GestureRecognizers(
                                new TapGestureRecognizer()
                                .OnTapped(async (e, args) =>
                                {
                                    fullname.Text = "";
                                    username.Text = "";
                                    password.Text = "";
                                    await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
                                })
                            )

                        )
                        .Spacing(10)
                    )
                    .CornerRadius(25)
                    .BorderColor(Colors.DarkBlue)
                    .BackgroundColor(Colors.DarkBlue)
                    //.MinimumHeightRequest(250)
                    .MinimumWidthRequest(300)
                )
                .Center()
            );
    }
}
