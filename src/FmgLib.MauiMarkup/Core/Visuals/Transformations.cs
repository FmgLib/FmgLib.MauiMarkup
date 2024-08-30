namespace FmgLib.MauiMarkup;

public static class Transformations
{
    public static Color ColorTransform(Color fromColor, Color toColor, double t)
    {
        return Color.FromRgba((double)fromColor.Red + t * (double)(toColor.Red - fromColor.Red), (double)fromColor.Green + t * (double)(toColor.Green - fromColor.Green), (double)fromColor.Blue + t * (double)(toColor.Blue - fromColor.Blue), (double)fromColor.Alpha + t * (double)(toColor.Alpha - fromColor.Alpha));
    }

    public static double DoubleTransform(double from, double to, double t)
    {
        return from + t * (to - from);
    }

    public static Size SizeTransform(Size from, Size to, double t)
    {
        return new Size(from.Width + t * (to.Width - from.Width), from.Height + t * (to.Height - from.Height));
    }

    public static Task<bool> AnimateAsync<T>(VisualElement element, string name, Func<double, T> transform, Action<T> callback, uint length, Easing easing)
    {
        easing = easing ?? Easing.Linear;
        TaskCompletionSource<bool> taskCompletionSource = new TaskCompletionSource<bool>();
        element.Animate(name, transform, callback, 16u, length, easing, delegate (T value, bool c)
        {
            taskCompletionSource.SetResult(c);
        });

        return taskCompletionSource.Task;
    }
}
