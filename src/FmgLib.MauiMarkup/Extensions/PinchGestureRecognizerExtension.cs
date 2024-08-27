namespace FmgLib.MauiMarkup;



public static partial class PinchGestureRecognizerExtension
{
    public static PinchGestureRecognizer OnPinchUpdated(this PinchGestureRecognizer self, EventHandler<PinchGestureUpdatedEventArgs> handler)
    {
        self.PinchUpdated += handler;
        return self;
    }
    
    public static PinchGestureRecognizer OnPinchUpdated(this PinchGestureRecognizer self, Action<PinchGestureRecognizer> action)
    {
        self.PinchUpdated += (o, arg) => action(self);
        return self;
    }
    
}
