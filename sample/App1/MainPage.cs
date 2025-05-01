using System;
using System.Reflection;
using Microsoft.Maui;
using Microsoft.Maui.Accessibility;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Hosting;

namespace App1;

public partial class MainPage : MC.ContentPage, IFmgLibHotReload
{
    public MainPage()
    {
        this.InitializeHotReload();
    }

    public void Build()
    {
        var version = typeof(MauiApp).Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()
            ?.InformationalVersion;
        var temp = static (ViewModel model) => model.Title;
        this
            .BindingContext(new ViewModel(){ Title = "Hello, World!" })
            .Content(
                new MC.ScrollView()
                    .Content(
                        new MC.Grid()
                            .RowDefinitions(e => e.Star(90).Star(10))
                            .Children(
                                new MC.StackLayout()
                                    .Spacing(25)
                                    .Children(
                                        new MC.Label()
                                            .Text("Hello, World!")
                                            .FontSize(32)
                                            .CenterHorizontal()
                                            .SemanticHeadingLevel(SemanticHeadingLevel.Level1),
                                        new MC.Label()
                                            .Assign(out lbl)
                                            .Text(e => e.Getter(static (ViewModel v) => v.Title))
                                            .FontSize(18)
                                            .CenterHorizontal()
                                            .SemanticDescription("Welcome to dot net Multi platform App U I")
                                            .SemanticHeadingLevel(SemanticHeadingLevel.Level1),
                                        new MC.Label()
                                            .Text("Current count: 0")
                                            .FontSize(18)
                                            .FontAttributes(Bold)
                                            .CenterHorizontal()
                                            .Assign(out CounterLabel),
                                        new MC.Button()
                                            .Text("Click me")
                                            .CenterHorizontal()
                                            .OnClicked(OnCounterClicked)
                                            .SemanticHint("Counts the number of times you click"),
                                        new MC.Image()
                                            .Source("dotnet_bot.png")
                                            .SizeRequest(250, 310)
                                            .CenterHorizontal()
                                            .SemanticDescription("Cute dot net bot waving hi to you!")
                                    ),
                                new MC.Grid()
                                    .BackgroundColor(AppColors.Primary)
                                    .Row(1)
                                    .Children(
                                        new MC.Label()
                                            .Text($"dotNet version: {version}")
                                            .TextColor(White)
                                            .Center()
                                    )
                            )
                    )
            );
        
        
    }

    private int _count = 0;
    private MC.Label CounterLabel, lbl;


    private void OnCounterClicked(object? sender, EventArgs e)
    {
        _count++;
        CounterLabel.Text = $"Current count: {_count}";
        (this.BindingContext as ViewModel).Title = "Deneme";
        // lbl.Bind(Label.TextProperty, static (ViewModel model) => model.Title);
        // lbl.SetBinding(Label.TextProperty, static (ViewModel model) => model.Title);
        SemanticScreenReader.Announce(CounterLabel.Text);
    }
}

public class ViewModel : MC.BindableObject
{
    private string _title;

    public string Title
    {
        get => _title;
        set
        {
            _title = value;
            OnPropertyChanged();
        }
    }
}