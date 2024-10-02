using System.Diagnostics;

namespace DalluiApp.Views;

public partial class ImageGeneratorView : FmgLibContentPage
{
    Stopwatch watch = new Stopwatch();
    SKLottieView lottie;
    Border borderTime;
    Border imageAnimation;
    Border imageBorder;
    Label lblTimer;
    Button btnFinish;

    public override void Build()
    {
        this
        .BackgroundColor(Color.FromArgb("#101216"))
        .Content(
            new Grid()
            .Margin(25,25,00)
            .RowDefinitions(e => e.Star(2).Star(6).Star(2))
            .Children(
                new VerticalStackLayout().CenterVertical().Children(
                    new Label()
                    .FontFamily("NexaHeavy")
                    .FontSize(30)
                    .TextColor(White)
                    .Text("Picture\ngenerated"),

                    new HorizontalStackLayout().Margin(0,10,0,0).Children(
                         new Label()
                        .FontSize(20)
                        .TextColor(Color.FromArgb("#ACB1BB"))
                        .Text("Time spent")
                        .CenterVertical(),

                         new Grid().Children(
                             new Border()
                             .Assign(out borderTime)
                             .Row(1)
                             .BackgroundColor(Color.FromArgb("#E8FF8E"))
                             .IsVisible(true)
                             .Opacity(0)
                             .Scale(1.1)
                             .StrokeShape(new RoundRectangle().CornerRadius(5))
                             .StrokeThickness(0),

                             new Label()
                             .Assign(out lblTimer)
                             .FontSize(20)
                             .Text("0")
                             .TextColor(Color.FromArgb("#ACB1BB"))
                             .CenterVertical()
                         ),

                         new Label()
                         .FontSize(20)
                         .Text("Seconds")
                         .TextColor(Color.FromArgb("#ACB1BB"))
                         .CenterVertical()
                    )
                ),

                new Border()
                .Assign(out imageBorder)
                .Row(1)
                .IsVisible(false)
                .StrokeShape(new RoundRectangle().CornerRadius(20))
                .StrokeThickness(0)
                .Content(
                    new Image().Source("cartoon.jpg").Aspect(Aspect.AspectFill)
                ),

                new Border()
                .Assign(out imageAnimation)
                .Row(1)
                .BackgroundColor(Color.FromArgb("#E8FF8E"))
                .IsVisible(false)
                .Opacity(.9)
                .StrokeShape(new RoundRectangle().CornerRadius(20))
                .StrokeThickness(0),

                new SKLottieView()
                .Assign(out lottie)
                .Row(1)
                .IsAnimationEnabled(true)
                .RepeatCount(-1)
                .Source(new SKFileLottieImageSource().File("robot.json")),

                new Button()
                .Assign(out btnFinish)
                .Row(2)
                .BackgroundColor(Color.FromArgb("#E8FF8E"))
                .TextColor(Color.FromArgb("#101216"))
                .CornerRadius(35)
                .FontSize(25)
                .SizeRequest(250,75)
                .Center()
                .Scale(0)
                .Text("Finish")
                .OnClicked(async (sender, e) =>
                {
                    await AppShell.Current.GoToAsync($"//{nameof(DashboardView)}");
                })
            )
        );
    }

    protected override async void OnAppearing()
    {
        await Task.Delay(TimeSpan.FromSeconds(2));
        watch.Start();

        var cts = new CancellationTokenSource();

        using (var timer = new PeriodicTimer(TimeSpan.FromSeconds(1)))
        {
            try
            {
                var counter = 0;
                while (await timer.WaitForNextTickAsync(cts.Token))
                {
                    if (counter == 5)
                    {
                        cts.Cancel();
                    }

                    var seconds = watch.Elapsed.Seconds;
                    lblTimer.Text = seconds.ToString();
                    counter++;
                }

            }
            catch (TaskCanceledException)
            {
                await StopGeneration();
            }
        }
    }

    private async Task StopGeneration()
    {
        watch.Stop();

        lottie.IsAnimationEnabled = false;
        lottie.IsVisible = false;
        imageBorder.IsVisible = true;
        imageAnimation.IsVisible = true;

        await Task.Delay(2000);

        await Task.WhenAny(
             imageAnimation.ScaleTo(1.1, 1000),
             imageAnimation.FadeTo(0, 1000),
             borderTime.ScaleTo(1, 1000),
             borderTime.FadeTo(1, 1000)
             );

        await borderTime.FadeTo(0, 300);
        await btnFinish.ScaleTo(1, 1000);

    }
}
