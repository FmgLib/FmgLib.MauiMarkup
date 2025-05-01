using Microsoft.Maui;

namespace App1;

public partial class App : MC.Application
{
    public App()
    {
        this.Resources(new MC.ResourceDictionary().MergedDictionaries(AppStyles.Default));
    }

    protected override MC.Window CreateWindow(IActivationState? activationState) => new MC.Window(new AppShell());
}