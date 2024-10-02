using Game2048Maui.Models;

namespace Game2048Maui.Behaviors
{
    public class TileStateBehavior : Behavior<Frame>
    {
        private Frame frame;
        private NumberTile numberTile;

        protected override void OnAttachedTo(Frame bindable)
        {
            base.OnAttachedTo(bindable);

            frame = bindable;
            frame.BindingContextChanged += OnBindingContextChanged;
        }

        protected override void OnDetachingFrom(Frame bindable)
        {
            base.OnDetachingFrom(bindable);

            frame.BindingContextChanged -= OnBindingContextChanged;

            if (numberTile is not null)
            {
                numberTile.PropertyChanged -= OnTileViewModelPropertyChanged;
            }
        }

        private void OnBindingContextChanged(object sender, EventArgs e)
        {
            if (frame.BindingContext is NumberTile tile)
            {
                numberTile = tile;
                numberTile.PropertyChanged += OnTileViewModelPropertyChanged;
            }
        }

        private async void OnTileViewModelPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if(e.PropertyName == nameof(NumberTile.IsNumberMultiplied))
            {
                if (numberTile.IsNumberMultiplied)
                {
                    double frameScale = frame.Scale;
                    await frame.ScaleTo(frameScale * 1.25, 150);
                    await frame.ScaleTo(frameScale, 150);
                }
                numberTile.IsNumberMultiplied = false;
            }
            else if (e.PropertyName == nameof(NumberTile.IsNewNumberGenerated))
            {
                if (numberTile.IsNewNumberGenerated)
                {
                    var animation = new Animation();

                    animation.WithConcurrent(
                                   f => frame.Scale = f,
                                    0.5, 1,
                                   Microsoft.Maui.Easing.Linear, 0, 1);

                    animation.WithConcurrent(
                            (f) => frame.Opacity = f,
                            0, 1,
                            null,
                            0, 0.25);
                    frame.Animate("BounceIn", animation, 16, Convert.ToUInt32(200));
                }
                numberTile.IsNewNumberGenerated = false;
            }
        }
    }
}