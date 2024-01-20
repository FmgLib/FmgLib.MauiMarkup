namespace MyOrderApp.Views;

public partial class LoginPage : BasePage<LoginPageViewModel>
{
    public LoginPage(LoginPageViewModel viewModel) : base(viewModel, "Login Page")
    {
    }

    public override void Build()
    {
        this
            .BackgroundImageSourceFmg("background.jpg")
            .ContentFmg(
                new VerticalStackLayout()
                .ChildrenFmg(
                    new Frame()
                    .ContentFmg(
                        new VerticalStackLayout()
                        .ChildrenFmg(
                            new Entry()
                            .PlaceholderFmg("Kullanıcı Adı Girin.")
                            .PlaceholderColorFmg(Colors.Gray)
                            .TextColorFmg(Colors.White)
                            .AssignFmg(out Entry username)
                            .BindFmg(Entry.TextProperty, "User.Username"),

                            new Entry()
                            .PlaceholderFmg("Şifre Girin.")
                            .PlaceholderColorFmg(Colors.Gray)
                            .TextColorFmg(Colors.White)
                            .IsPasswordFmg(true)
                            .AssignFmg(out Entry password)
                            .BindFmg(Entry.TextProperty, "User.Password"),

                            new HorizontalStackLayout() 
                            .ChildrenFmg(
                                new CheckBox()
                                .ColorFmg(Colors.White)
                                .CenterVerticalFmg()
                                .BindFmg(CheckBox.IsCheckedProperty, "IsControl"),

                                new Label()
                                .TextFmg("Beni Hatırla")
                                .TextColorFmg(Colors.White)
                                .CenterVerticalFmg()
                            ),
                        
                            new Button()
                            .TextFmg("GİRİŞ YAP")
                            .FontAttributesFmg(FontAttributes.Bold)
                            .IsEnabledFmg(false)
                            .BindFmg(Button.CommandProperty, "LoginCommand")
                            .TriggersFmg(
                                new MultiTrigger(typeof(Button))
                                .ConditionsFmg(
                                    new BindingCondition()
                                    .BindingFmg(b => b
                                                    .PathFmg("Text.Length")
                                                    .SourceFmg(username)
                                                    .ConverterFmg(new TextLengthToBoolConverter()))
                                    .ValueFmg(false)

                                )
                                .SettersFmg(new Setters<Button>(e => e.IsEnabledFmg(false))), 

                                new MultiTrigger(typeof(Button))
                                .ConditionsFmg(
                                    new BindingCondition()
                                    .BindingFmg(b => b
                                                    .PathFmg("Text.Length")
                                                    .SourceFmg(password)
                                                    .ConverterFmg(new TextLengthToBoolConverter()))
                                    .ValueFmg(false)

                                )
                                .SettersFmg(new Setters<Button>(e => e.IsEnabledFmg(false))), 
                            
                                new MultiTrigger(typeof(Button))
                                .ConditionsFmg(
                                    new BindingCondition()
                                    .BindingFmg(b => b
                                                    .PathFmg("Text.Length")
                                                    .SourceFmg(username)
                                                    .ConverterFmg(new TextLengthToBoolConverter()))
                                    .ValueFmg(true),

                                    new BindingCondition()
                                    .BindingFmg(b => b
                                                    .PathFmg("Text.Length")
                                                    .SourceFmg(password)
                                                    .ConverterFmg(new TextLengthToBoolConverter()))
                                    .ValueFmg(true)
                                )
                                .SettersFmg(new Setters<Button>(e => e.IsEnabledFmg(true)))
                            ),

                            new Label()
                            .TextFmg("Hesabım Yok! Kayıt Ol.")
                            .TextColorFmg(Colors.LightGray)
                            .CenterHorizontalFmg()
                            .GestureRecognizersFmg(
                                new TapGestureRecognizer()
                                .OnTappedFmg(async (e, args) =>
                                {
                                    username.Text = "";
                                    password.Text = "";
                                    await Shell.Current.GoToAsync($"//{nameof(RegisterPage)}");
                                })
                            )
                            
                        )
                        .SpacingFmg(10)
                    )
                    .CornerRadiusFmg(25)
                    .BorderColorFmg(Colors.DarkBlue)
                    .BackgroundColorFmg(Colors.DarkBlue)
                    //.MinimumHeightRequestFmg(250)
                    .MinimumWidthRequestFmg(300)
                )
                .CenterFmg()
            );
    }
}
