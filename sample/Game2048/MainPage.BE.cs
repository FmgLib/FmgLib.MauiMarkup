namespace Game2048Maui;

public partial class MainPage : FmgLibContentPage<MainPageViewModel>
{
    private bool canHitMauiRobot = true;
    private DateTime tappedDateTime = DateTime.MaxValue;
    double eTotalXStart = 0;
    double eTotalYStart = 0;
    private MainPageViewModel CurrentViewModel;

    private Grid MainGrid;
    private Grid MyToolsPhotosItem;
    private Frame tttt;
    private Label AddedScoreLabel;
    private HorizontalStackLayout phraseLayout;
    private SKLottieView GameOverAnimation;
    private SKConfettiView skConfetti;

    string[] phrases = new string[]
    {
        "I am thankful to the community",
        "You can stop poking me and play some game",
        "I am feeling sleepy now"
    };
    public MainPage(MainPageViewModel viewModel) : base(viewModel)
    {
        CurrentViewModel = BindingContext;
        skConfetti.Systems.Clear();
    }

    private void DisplayConfettiAnimation()
    {
        var sus = new SKConfettiSystem()
        {
            Lifetime = 2,
            Colors = new SKConfettiColorCollection(ConfettiConfig.Colors),
            Shapes = new SKConfettiShapeCollection(ConfettiConfig.GetShapes(ConfettiConfig.Shapes).SelectMany(s => s)),
            MinimumInitialVelocity = 30,
            MaximumInitialVelocity = 150,
            Emitter = SKConfettiEmitter.Burst(100),
            EmitterBounds = SKConfettiEmitterBounds.Top,
        };
        skConfetti.Systems.Add(sus);
    }

    void MainPageViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        var bindingContext = (MainPageViewModel)BindingContext;

        if (e.PropertyName == nameof(MainPageViewModel.State))
        {
            if ((bindingContext.State == LevelState.GameOver))
            {
                GameOverAnimation.IsAnimationEnabled = true;
            }
            else if ((bindingContext.State == LevelState.Playing))
            {
                GameOverAnimation.IsAnimationEnabled = false;
            }
        }
        else if (e.PropertyName == nameof(MainPageViewModel.AddedScore))
        {
            Device.BeginInvokeOnMainThread(async () =>
            {
                AddedScoreLabel.IsVisible = true;
                await AddedScoreLabel.TranslateTo(0, -40, 500, Easing.Linear);
                AddedScoreLabel.TranslateTo(0, 0, 0, Easing.Linear);
                AddedScoreLabel.IsVisible = false;
            });
        }
    }
    void OnSwiped(object sender, SwipedEventArgs e)
    {
        switch (e.Direction)
        {
            case SwipeDirection.Left:
                // Handle the swipe
                break;
            case SwipeDirection.Right:
                // Handle the swipe
                break;
            case SwipeDirection.Up:
                // Handle the swipe
                break;
            case SwipeDirection.Down:
                // Handle the swipe
                break;
        }
    }

    private SwipeDirection? swipedDirection;
    private void PanGestureRecognizer_PanUpdated(object sender, PanUpdatedEventArgs e)
    {
        switch (e.StatusType)
        {
            //case GestureStatus.Started:
            //    HandleTouchStart(e.TotalX, e.TotalY);
            //    break;
            case GestureStatus.Running:
                HandleTouch(e.TotalX, e.TotalY);
                break;
            case GestureStatus.Completed:
                HandleTouchEnd(swipedDirection);
                break;
        }
    }


    private void HandleTouchStart(double eTotalX, double eTotalY)
    {
        eTotalXStart = eTotalX;
        eTotalYStart = eTotalY;
    }
    private void HandleTouch(double eTotalX, double eTotalY)
    {
        swipedDirection = null;
        const int delta = 10;
        if (eTotalX > delta)
        {
            swipedDirection = SwipeDirection.Right;
        }
        else if (eTotalX < -delta)
        {
            swipedDirection = SwipeDirection.Left;
        }
        else if (eTotalY > delta)
        {
            swipedDirection = SwipeDirection.Down;
        }
        else if (eTotalY < -delta)
        {
            swipedDirection = SwipeDirection.Up;
        }
    }
    private void HandleTouchEnd(SwipeDirection? swiped)
    {
        if (swiped == null)
        {
            return;
        }
        var currentViewModel = (MainPageViewModel)BindingContext;
        switch (swiped)
        {
            case SwipeDirection.Right:
                currentViewModel.RightSwipeCommand.Execute(null);
                break;
            case SwipeDirection.Left:
                currentViewModel.LeftSwipeCommand.Execute(null);
                break;
            case SwipeDirection.Up:
                currentViewModel.UpSwipeCommand.Execute(null);

                break;
            case SwipeDirection.Down:
                currentViewModel.DownSwipeCommand.Execute(null);
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    async void UndoButton_Clicked(System.Object sender, System.EventArgs e)
    {
        await Speak("Feature is not supported yet!!");
    }

    async void MauiRobotTapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
    {
        await Speak("Hey I am MauiMarkup Robot!");
    }

    private async Task Speak(string phrase)
    {
        //Prevent multiple Taps before the animation gets completed.
        if (canHitMauiRobot)
        {
            canHitMauiRobot = false;
            HapticFeedback.Default.Perform(HapticFeedbackType.Click);
            CurrentViewModel.MauiRobotPhrase = phrase;
            phraseLayout.IsVisible = true;
            await phraseLayout.TranslateTo(10, 30, 1000, Easing.CubicOut);
            await phraseLayout.TranslateTo(0, 0, 1000, Easing.CubicIn);
            phraseLayout.IsVisible = false;
            canHitMauiRobot = true;
            tappedDateTime = DateTime.Now;
        }
    }

    void GameLabelTapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
    {
        DisplayConfettiAnimation();
    }
}
