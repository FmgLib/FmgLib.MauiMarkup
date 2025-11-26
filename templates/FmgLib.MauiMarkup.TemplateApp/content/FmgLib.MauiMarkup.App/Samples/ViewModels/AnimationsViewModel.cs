using System.Windows.Input;

namespace FmgLib.MauiMarkup.App.Samples.ViewModels;

public class AnimationsViewModel : BaseViewModel
{
    public AnimationsViewModel()
    {
        Title = "Animations Showcase";
        
        FadeInCommand = new RelayCommand(async () => await OnFadeIn());
        ScaleCommand = new RelayCommand(async () => await OnScale());
        RotateCommand = new RelayCommand(async () => await OnRotate());
        BounceCommand = new RelayCommand(async () => await OnBounce());
        ShakeCommand = new RelayCommand(async () => await OnShake());
        SlideCommand = new RelayCommand(async () => await OnSlide());
        CombinedCommand = new RelayCommand(async () => await OnCombined());
    }

    public ICommand FadeInCommand { get; }
    public ICommand ScaleCommand { get; }
    public ICommand RotateCommand { get; }
    public ICommand BounceCommand { get; }
    public ICommand ShakeCommand { get; }
    public ICommand SlideCommand { get; }
    public ICommand CombinedCommand { get; }

    public View? TargetView { get; set; }

    private async Task OnFadeIn()
    {
        if (TargetView == null) return;
        TargetView.Opacity = 0;
        await TargetView.FadeToAsync(1, 1000, Easing.CubicInOut);
    }

    private async Task OnScale()
    {
        if (TargetView == null) return;
        await TargetView.ScaleToAsync(1.3, 300, Easing.SpringOut);
        await TargetView.ScaleToAsync(1, 300, Easing.SpringIn);
    }

    private async Task OnRotate()
    {
        if (TargetView == null) return;
        await TargetView.RotateToAsync(360, 1000, Easing.CubicInOut);
        TargetView.Rotation = 0;
    }

    private async Task OnBounce()
    {
        if (TargetView == null) return;
        await TargetView.TranslateToAsync(0, -50, 200, Easing.CubicOut);
        await TargetView.TranslateToAsync(0, 0, 200, Easing.BounceOut);
    }

    private async Task OnShake()
    {
        if (TargetView == null) return;
        for (int i = 0; i < 8; i++)
        {
            await TargetView.TranslateToAsync(i % 2 == 0 ? 10 : -10, 0, 50);
        }
        await TargetView.TranslateToAsync(0, 0, 50);
    }

    private async Task OnSlide()
    {
        if (TargetView == null) return;
        await TargetView.TranslateToAsync(200, 0, 500, Easing.CubicInOut);
        await TargetView.TranslateToAsync(0, 0, 500, Easing.CubicInOut);
    }

    private async Task OnCombined()
    {
        if (TargetView == null) return;
        
        await Task.WhenAll(
            TargetView.RotateToAsync(360, 1000, Easing.CubicInOut),
            TargetView.ScaleToAsync(1.5, 1000, Easing.CubicInOut),
            TargetView.FadeToAsync(0.3, 500).ContinueWith(t => TargetView.FadeToAsync(1, 500))
        );
        
        TargetView.Rotation = 0;
        TargetView.Scale = 1;
    }
}
