using Microsoft.Maui.Controls.Shapes;

namespace MatchingImage;

public partial class CardView : ContentView
{
    public static readonly BindableProperty CardImageProperty =
        BindableProperty.Create(nameof(CardImage), typeof(string), typeof(CardView), "ac1", BindingMode.TwoWay);

    public string CardImage
    {
        get => (string)GetValue(CardImageProperty);
        set => SetValue(CardImageProperty, value);
    }


    public CardView()
    {
        this
        .BindingContext(this)
        .Content(
            new Border()
            .SizeRequest(100,140)
            .StrokeShape(new RoundRectangle().CornerRadius(10))
            .Content(
                new Image().Source(e => e.Path("CardImage"))
            )
        );
    }
}
