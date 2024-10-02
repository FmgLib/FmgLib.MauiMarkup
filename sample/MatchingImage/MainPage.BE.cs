namespace MatchingImage;

public partial class MainPage : FmgLibContentPage
{
    Grid GameTable;
    Border Card0;
    MainPage thispage;


    private static List<FruitCard> _cards = new List<FruitCard>
    {
        new FruitCard("peach.jpg"),  new FruitCard("peach.jpg"),
        new FruitCard("orange.jpg"), new FruitCard("orange.jpg"),
        new FruitCard("pear.jpg"),   new FruitCard("pear.jpg"),
        new FruitCard("banana.jpg"),   new FruitCard("banana.jpg"),
        new FruitCard("strawberry.jpg"),   new FruitCard("strawberry.jpg"),
        new FruitCard("apricot.jpg"),   new FruitCard("apricot.jpg")
    };

    private bool _IsWaitForCheck;
    private Border _previouseBorder;
    private FruitCard _previouseData;

    public MainPage()
    {
        ShuffleCardsData();
    }

    public bool IsFliping { get; set; }

    private async void Card_Tapped(object sender, EventArgs e)
    {
        if (IsFliping)
        {
            return;
        }
        IsFliping = true;

        var border = sender as Border;
        var borderlist = GameTable.Children.Cast<Border>().ToList();

        var carddata = _cards[borderlist.IndexOf(border)];
        if (carddata.IsFaceUp)
        {
            IsFliping = false;
            return;
        }

        await FlipCard(border, carddata, true);

        //matching check
        if (_IsWaitForCheck)
        {
            if (carddata.ImageSource != _previouseData.ImageSource)
            {
                FlipCard(border, carddata, false);
                FlipCard(_previouseBorder, _previouseData, false);
            }
        }
        else
        {
            _previouseBorder = border;
            _previouseData = carddata;
        }

        //end game check
        if (!_cards.Any(x => !x.IsFaceUp))
        {
            thispage.BackgroundColor = Color.FromHex("#9dffb0");
            await Task.Delay(300);
            thispage.BackgroundColor = Color.FromHex("#81f1f7");
            await Task.Delay(300);
            thispage.BackgroundColor = Color.FromHex("#fffffa");
            await Task.Delay(300);
            thispage.BackgroundColor = Color.FromHex("#c48d3f");
            await Task.Delay(300);
            thispage.BackgroundColor = Color.FromHex("#fff563");
        }

        _IsWaitForCheck = !_IsWaitForCheck;
        IsFliping = false;

    }

    private async Task FlipCard(Border border, FruitCard card, bool isFirstFlip)
    {
        //flip both ui and data
        await border.RotateYTo(90, 250, Easing.CubicIn);
        card.IsFaceUp = isFirstFlip;
        (border.Content as Image).Source = isFirstFlip ? card.ImageSource : "leaf.jpg";
        await border.RotateYTo(isFirstFlip ? 180 : 0, 250, Easing.SpringOut);
    }

    private async void Reset_Clicked(object sender, EventArgs e)
    {
        thispage.BackgroundColor = Color.FromHex("#bee893");

        if (IsFliping)
        {
            return;
        }
        IsFliping = true;

        var borders = GameTable.Children.Cast<Border>().ToList();
        borders.ForEach(async x =>
        {
            if (x.RotationY != 0)
            {
                x.RotateYTo(0, 250, Easing.Linear);
                await Task.Delay(125);
                var img = x.Content as Image;
                img.Source = "leaf";
            }

            x.RotationY = 0;
        });

        await Task.Delay(500);

        //shuffle animation
        new Animation {
            { 0, 0.125, new Animation (v => GameTable.TranslationX = v, 0, -13) },
            { 0.125, 0.250, new Animation (v => GameTable.TranslationX = v, -13, 13) },
            { 0.250, 0.375, new Animation (v => GameTable.TranslationX = v, 13, -11) },
            { 0.375, 0.5, new Animation (v => GameTable.TranslationX = v, -11, 11) },
            { 0.5, 0.625, new Animation (v => GameTable.TranslationX = v, 11, -7) },
            { 0.625, 0.75, new Animation (v => GameTable.TranslationX = v, -7, 7) },
            { 0.75, 0.875, new Animation (v => GameTable.TranslationX = v, 7, -5) },
            { 0.875, 1, new Animation (v => GameTable.TranslationX = v, -5, 0) }
        }.Commit(this, "ShuffleCards", length: 400, easing: Easing.Linear);

        ShuffleCardsData();
        _IsWaitForCheck = false;
        IsFliping = false;
    }

    private void ShuffleCardsData()
    {
        foreach (FruitCard fruitcard in _cards)
        {
            fruitcard.IsFaceUp = false;
        }

        Random r = new Random();
        _cards = _cards.OrderBy(x => r.Next()).ToList();
    }
}

public class FruitCard
{
    public FruitCard(string imageSource)
    {
        ImageSource = imageSource;
    }

    public string ImageSource { get; set; }
    public bool IsFaceUp { get; set; }
}
