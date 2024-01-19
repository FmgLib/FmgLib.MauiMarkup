namespace MyOrderApp.Views;

public partial class RegisterPage : BasePage<RegisterPageViewModel>
{
    public RegisterPage(RegisterPageViewModel viewModel) : base(viewModel, "Kayıt Sayfası")
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
                            .PlaceholderFmg("Ad Soyad Girin.")
                            .PlaceholderColorFmg(Colors.Gray)
                            .TextColorFmg(Colors.White)
                            .AssignFmg(out Entry fullname)
                            .BindFmg(Entry.TextProperty, "User.FullName"),

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

                            

                            new Button()
                            .TextFmg("KAYDET")
                            .FontAttributesFmg(FontAttributes.Bold)
                            .IsEnabledFmg(false)
                            .BindFmg(Button.CommandProperty, "RegisterCommand")
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
                            .TextFmg("Hesabım Var! Giriş Yap.")
                            .TextColorFmg(Colors.LightGray)
                            .CenterHorizontalFmg()
                            .GestureRecognizersFmg(
                                new TapGestureRecognizer()
                                .OnTappedFmg(async (e, args) =>
                                {
                                    fullname.Text = "";
                                    username.Text = "";
                                    password.Text = "";
                                    await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
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
