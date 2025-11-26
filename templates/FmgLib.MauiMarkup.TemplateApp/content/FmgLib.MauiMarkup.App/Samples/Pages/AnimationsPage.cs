using FmgLib.MauiMarkup.App.Samples.ViewModels;
using System.Windows.Input;
using Microsoft.Maui.Controls.Shapes;

namespace FmgLib.MauiMarkup.App.Samples.Pages;

public partial class AnimationsPage : ContentPage, IFmgLibHotReload
{
    private readonly AnimationsViewModel _viewModel;

    public AnimationsPage()
    {
        _viewModel = new AnimationsViewModel();
        BindingContext = _viewModel;
        
        this.InitializeHotReload();
    }

    public void Build()
    {
        this
        .Title("Animations")
        .Content(
            new ScrollView()
            .Content(
                new VerticalStackLayout()
                .Padding(20)
                .Spacing(20)
                .Children(
                    // Header
                    new Label()
                    .Text("Animation Showcase")
                    .FontSize(28)
                    .FontAttributes(Bold)
                    .TextColor("#512BD4".ToColor())
                    .CenterHorizontal(),

                    new Label()
                    .Text("Explore smooth and engaging animations")
                    .FontSize(14)
                    .TextColor(Colors.Gray)
                    .CenterHorizontal()
                    .Margin(0, 0, 0, 20),

                    // Animation Target
                    new Border()
                    .StrokeThickness(0)
                    .BackgroundColor("#512BD4".ToColor())
                    .StrokeShape(new RoundRectangle().CornerRadius(20))
                    .HeightRequest(150)
                    .WidthRequest(150)
                    .CenterHorizontal()
                    .Assign(out Border animationTarget)
                    .Content(
                        new Label()
                        .Text("🎨")
                        .FontSize(60)
                        .Center()
                    )
                    .InvokeOnElement(b => _viewModel.TargetView = b),

                    // Animation Buttons Grid
                    new Grid()
                    .RowDefinitions(e => e.Auto().Auto().Auto())
                    .ColumnDefinitions(e => e.Star().Star())
                    .RowSpacing(12)
                    .ColumnSpacing(12)
                    .Margin(0, 30, 0, 0)
                    .Children(
                        AnimationButton("Fade In", "💫", _viewModel.FadeInCommand, "#6A4C9C").Row(0).Column(0),
                        AnimationButton("Scale", "🎯", _viewModel.ScaleCommand, "#1E88E5").Row(0).Column(1),
                        AnimationButton("Rotate", "🔄", _viewModel.RotateCommand, "#00897B").Row(1).Column(0),
                        AnimationButton("Bounce", "⬆️", _viewModel.BounceCommand, "#FB8C00").Row(1).Column(1),
                        AnimationButton("Shake", "📳", _viewModel.ShakeCommand, "#E53935").Row(2).Column(0),
                        AnimationButton("Slide", "➡️", _viewModel.SlideCommand, "#7CB342").Row(2).Column(1)
                    ),

                    // Combined Animation Button
                    new Button()
                    .Text("🎭 Combined Animation")
                    .FontSize(16)
                    .FontAttributes(Bold)
                    .TextColor(Colors.White)
                    .BackgroundColor("#FF6B6B".ToColor())
                    .CornerRadius(15)
                    .HeightRequest(60)
                    .Margin(0, 20, 0, 0)
                    .Command(_viewModel.CombinedCommand)
                    .Shadow(new Shadow()
                        .Brush(new SolidColorBrush("#40FF6B6B".ToColor()))
                        .Offset(new Point(0, 4))
                        .Radius(8)
                    )
                )
            )
        );
    }

    private Border AnimationButton(string text, string emoji, ICommand command, string colorHex)
    {
        return new Border()
            .StrokeThickness(0)
            .BackgroundColor(colorHex.ToColor())
            .StrokeShape(new RoundRectangle().CornerRadius(12))
            .HeightRequest(80)
            .GestureRecognizers(new TapGestureRecognizer().Command(command))
            .Shadow(new Shadow()
                .Brush(new SolidColorBrush($"#40{colorHex.TrimStart('#')}".ToColor()))
                .Offset(new Point(0, 4))
                .Radius(8)
            )
            .Content(
                new VerticalStackLayout()
                .Spacing(8)
                .Center()
                .Children(
                    new Label()
                    .Text(emoji)
                    .FontSize(32)
                    .CenterHorizontal(),
                    
                    new Label()
                    .Text(text)
                    .FontSize(13)
                    .FontAttributes(Bold)
                    .TextColor(Colors.White)
                    .CenterHorizontal()
                )
            );
    }
}
