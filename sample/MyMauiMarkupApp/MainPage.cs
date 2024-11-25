using System.Globalization;
using System.Reflection;

using MyMauiMarkupApp.Resources;

namespace MyMauiMarkupApp;

public partial class MainPage : ContentPage, IFmgLibHotReload
{
    public MainPage()
    {
        this.InitializeHotReload();
    }

    public void Build()
    {
        var version = typeof(MauiApp).Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion;

        this
        .Content(
            new ScrollView()
            .Content(
                new Grid()
                .RowDefinitions(e => e.Star(90).Star(10))
                .Children(
                    new StackLayout()
                    .Spacing(25)
                    .Children(
                        new Label()
                        .Text(e => e.Translate("Hello"))
                        .FontSize(32)
                        .CenterHorizontal()
                        .SemanticHeadingLevel(SemanticHeadingLevel.Level1),

                        new Label()
                        .Text(e => e.TranslateResx(nameof(AppResources.hello)))
                        .FontSize(32)
                        .CenterHorizontal()
                        .SemanticHeadingLevel(SemanticHeadingLevel.Level1),

                        new Label()
                        .Text(e => e.Translate("Msg"))
                        .FontSize(18)
                        .CenterHorizontal()
                        .SemanticDescription(e => e.Translate("Msg"))
                        .SemanticHeadingLevel(SemanticHeadingLevel.Level1),

                        new Label()
                        .Text(e => e.Translate("Msg"))
                        .FontSize(18)
                        .CenterHorizontal()
                        .SemanticDescription(e => e.TranslateResx("Msg"))
                        .SemanticHeadingLevel(SemanticHeadingLevel.Level1),


                        new VerticalStackLayout()
                        .Center()
                        .Children(
                            new RadioButton()
                            .IsChecked(Translator.Instance.CurrentCulture.Name == "tr-TR")
                            .Content("tr-TR")
                            .OnCheckedChanged((sender, e) =>
                            {
                                Translator.Instance.ChangeCulture(CultureInfo.GetCultureInfo("tr-TR"));
                                TranslatorResx.Instance.ChangeCulture(CultureInfo.GetCultureInfo("tr-TR"));
                            }),
                            new RadioButton()
                            .IsChecked(Translator.Instance.CurrentCulture.Name == "en-US")
                            .Content("en-US")
                            .OnCheckedChanged((sender, e) =>
                            {
                                Translator.Instance.ChangeCulture(CultureInfo.GetCultureInfo("en-US"));
                                TranslatorResx.Instance.ChangeCulture(CultureInfo.GetCultureInfo("en-US"));
                            })
                        ),

                        new Image()
                        .Source("dotnet_bot.png")
                        .SizeRequest(250, 310)
                        .CenterHorizontal()
                        .SemanticDescription("Cute dot net bot waving hi to you!")
                    ),

                    new Grid()
                    .BackgroundColor(AppColors.Primary)
                    .Row(1)
                    .Children(
                        new Label()
                        .Text($"dotNet version: {version}")
                        .TextColor(White)
                        .Center()
                    )
                )
            )
        );
    }
}
