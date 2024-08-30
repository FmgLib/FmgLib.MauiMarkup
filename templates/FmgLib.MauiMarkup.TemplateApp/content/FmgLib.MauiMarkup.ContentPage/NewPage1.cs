using FmgLib.MauiMarkup;

namespace MauiApp1;

public class NewPage1 : ContentPage, IFmgLibHotReload
{
    public NewPage1()
    {
        this.InitializeHotReload();
    }

    public void Build()
    {
        this
        .Title("NewPage1")
        .Content(
            new VerticalStackLayout()
            .Children(
                new Label()
                .Text("Welcome to .NET MAUI!")
                .Center()
            )
        );
    }
}