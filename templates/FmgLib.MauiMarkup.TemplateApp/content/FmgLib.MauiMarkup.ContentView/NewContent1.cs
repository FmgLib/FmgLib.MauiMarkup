using FmgLib.MauiMarkup;

namespace MauiApp1;

public class NewContent1 : ContentView, IFmgLibHotReload
{
    public NewContent1()
    {
        this.InitializeHotReload();
    }

    public void Build()
    {
        this
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