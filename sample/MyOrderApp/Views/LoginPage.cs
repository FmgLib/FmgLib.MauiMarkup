namespace MyOrderApp.Views;

public partial class LoginPage : BasePage<LoginPageViewModel>
{
    public LoginPage(LoginPageViewModel viewModel) : base(viewModel, "Login Page")
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
                            .Placeholder("Kullanıcı Adı Girin.")
                            .PlaceholderColor(Colors.Gray)
                            .TextColor(Colors.White)
                            .Assign(out Entry username)
                            .Text(e => e.Path("User.Username"))
                            /*.Bind(Entry.TextProperty, "User.Username")*/,

                            new Entry()
                            .Placeholder("Şifre Girin.")
                            .PlaceholderColor(Colors.Gray)
                            .TextColor(Colors.White)
                            .IsPassword(true)
                            .Assign(out Entry password)
                            .Text(e => e.Path("User.Password"))
                            /*.Bind(Entry.TextProperty, "User.Password")*/,

                            new HorizontalStackLayout() 
                            .Children(
                                new CheckBox()
                                .Color(Colors.White)
                                .CenterVertical()
                                .IsChecked(e => e.Path("IsControl"))
                                /*.Bind(CheckBox.IsCheckedProperty, "IsControl")*/,

                                new Label()
                                .Text("Beni Hatırla")
                                .TextColor(Colors.White)
                                .CenterVertical()
                            ),
                        
                            new Button()
                            .Text("GİRİŞ YAP")
                            .FontAttributes(FontAttributes.Bold)
                            .IsEnabled(false)
                            .Command(e => e.Path("LoginCommand"))
                            //.Bind(Button.CommandProperty, "LoginCommand")
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
                            .Text("Hesabım Yok! Kayıt Ol.")
                            .TextColor(Colors.LightGray)
                            .CenterHorizontal()
                            .GestureRecognizers(
                                new TapGestureRecognizer()
                                .OnTapped(async (e, args) =>
                                {
                                    username.Text = "";
                                    password.Text = "";
                                    await Shell.Current.GoToAsync($"//{nameof(RegisterPage)}");
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
