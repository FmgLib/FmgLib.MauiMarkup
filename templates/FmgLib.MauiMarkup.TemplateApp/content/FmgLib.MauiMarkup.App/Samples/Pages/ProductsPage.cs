using Microsoft.Maui.Controls.Shapes;
using FmgLib.MauiMarkup.App.Samples.Models;
using FmgLib.MauiMarkup.App.Samples.ViewModels;
using FmgLib.MauiMarkup.App.Samples.Converters;

namespace FmgLib.MauiMarkup.App.Samples.Pages;

public partial class ProductsPage : ContentPage, IFmgLibHotReload
{
    private readonly ProductsViewModel _viewModel;

    public ProductsPage()
    {
        _viewModel = new ProductsViewModel();
        BindingContext = _viewModel;

        this.InitializeHotReload();
    }

    public void Build()
    {
        this
        .Title("Products")
        .Content(
            new Grid()
            .RowDefinitions(e => e.Auto().Star())
            .Children(
                // Search and Filter Header
                new VerticalStackLayout()
                .Row(0)
                .Padding(16)
                .Spacing(12)
                .BackgroundColor("#F8F9FA".ToColor())
                .Children(
                    // Search Bar
                    new Border()
                    .StrokeThickness(0)
                    .BackgroundColor(Colors.White)
                    .StrokeShape(new RoundRectangle().CornerRadius(12))
                    .Padding(4)
                    .Shadow(new Shadow()
                        .Brush(new SolidColorBrush("#20000000".ToColor()))
                        .Offset(new Point(0, 2))
                        .Radius(4)
                    )
                    .Content(
                        new SearchBar()
                        .Placeholder("Search products...")
                        .TextColor("#111827".ToColor())
                        .PlaceholderColor("#9CA3AF".ToColor())
                        .BackgroundColor("#F3F4F6".ToColor())
                        .Text(e => e.Path(nameof(_viewModel.SearchText)))
                        .SearchCommand(_viewModel.SearchCommand)
                        .CancelButtonColor("#6B7280".ToColor())
                    ),

                    // Category Filter
                    new ScrollView()
                    .Orientation(ScrollOrientation.Horizontal)
                    .Content(
                        new HorizontalStackLayout()
                        .Spacing(8)
                        .Children(
                            _viewModel.Categories.Select(cat => CategoryChip(cat)).ToArray()
                        )
                    )
                ),

                // Products List
                new RefreshView()
                .Row(1)
                .Command(_viewModel.RefreshCommand)
                .IsRefreshing(e => e.Path(nameof(_viewModel.IsBusy)))
                .Content(
                    new CollectionView()
                    .ItemsSource(e => e.Path(nameof(_viewModel.FilteredProducts)))
                    .SelectionMode(SelectionMode.None)
                    .ItemTemplate(new DataTemplate(() => ProductCard()))
                    .EmptyView(
                        new VerticalStackLayout()
                        .Spacing(12)
                        .Center()
                        .Children(
                            new Label().Text("🔍").FontSize(60).CenterHorizontal(),
                            new Label()
                            .Text("No products found")
                            .FontSize(18)
                            .TextColor(Colors.Gray)
                            .CenterHorizontal()
                        )
                    )
                )
            )
        );
    }

    private Border CategoryChip(string category)
    {
        var isSelected = new Binding(nameof(_viewModel.SelectedCategory), converter: new StringToBoolConverter(), converterParameter: category);

        return new Border()
            .Padding(16, 8)
            .StrokeThickness(1)
            .StrokeShape(new RoundRectangle().CornerRadius(20))
            .GestureRecognizers(
                new TapGestureRecognizer()
                .Command(_viewModel.FilterByCategoryCommand)
                .CommandParameter(category)
            )
            .Triggers(
                new DataTrigger(typeof(Border))
                .Binding(isSelected)
                .Value(true)
                .Setters(
                    new Setter { Property = Border.BackgroundColorProperty, Value = "#512BD4".ToColor() },
                    new Setter { Property = Border.StrokeProperty, Value = "#512BD4".ToColor() }
                ),
                new DataTrigger(typeof(Border))
                .Binding(isSelected)
                .Value(false)
                .Setters(
                    new Setter { Property = Border.BackgroundColorProperty, Value = Colors.Transparent },
                    new Setter { Property = Border.StrokeProperty, Value = Colors.LightGray }
                )
            )
            .Content(
                new Label()
                .Text(category)
                .FontAttributes(Bold)
                .FontSize(13)
                .Triggers(
                    new DataTrigger(typeof(Label))
                    .Binding(isSelected)
                    .Value(true)
                    .Setters(new Setters<Label>(e => e.TextColor(Colors.White))),
                    new DataTrigger(typeof(Label))
                    .Binding(isSelected)
                    .Value(false)
                    .Setters(new Setters<Label>(e => e.TextColor(Colors.Gray)))
                )
            );
    }

    private Border ProductCard()
    {
        return new Border()
            .Margin(16, 8)
            .StrokeThickness(0)
            .BackgroundColor(Colors.White)
            .StrokeShape(new RoundRectangle().CornerRadius(16))
            .Shadow(new Shadow()
                .Brush(new SolidColorBrush("#15000000".ToColor()))
                .Offset(new Point(0, 2))
                .Radius(8)
            )
            .Content(
                new Grid()
                .Padding(16)
                .ColumnDefinitions(e => e.Auto().Star().Auto())
                .RowDefinitions(e => e.Auto().Auto().Auto())
                .RowSpacing(8)
                .ColumnSpacing(12)
                .Children(
                    // Product Icon
                    new Border()
                    .Row(0).RowSpan(2).Column(0)
                    .WidthRequest(60).HeightRequest(60)
                    .BackgroundColor("#F8F9FA".ToColor())
                    .StrokeThickness(0)
                    .StrokeShape(new RoundRectangle().CornerRadius(12))
                    .Content(
                        new Label()
                        .Text(e => e.Path(nameof(Product.ImageUrl)))
                        .FontSize(32)
                        .Center()
                    ),

                    // Product Name
                    new Label()
                    .Row(0).Column(1)
                    .Text(e => e.Path(nameof(Product.Name)))
                    .FontSize(16)
                    .FontAttributes(Bold)
                    .TextColor("#1A1A1A".ToColor()),

                    // Product Description
                    new Label()
                    .Row(1).Column(1)
                    .Text(e => e.Path(nameof(Product.Description)))
                    .FontSize(13)
                    .TextColor(Colors.Gray),

                    // Rating and Price Row
                    new HorizontalStackLayout()
                    .Row(2).Column(1)
                    .Spacing(16)
                    .Children(
                        new HorizontalStackLayout()
                        .Spacing(4)
                        .Children(
                            new Label().Text("⭐").FontSize(14),
                            new Label()
                            .Text(e => e.Path(nameof(Product.Rating)))
                            .FontSize(13)
                            .FontAttributes(Bold)
                            .TextColor("#FFA500".ToColor())
                        ),

                        new Label()
                        .Text(e => e.Path(nameof(Product.Price)).StringFormat("${0:F2}"))
                        .FontSize(16)
                        .FontAttributes(Bold)
                        .TextColor("#512BD4".ToColor())
                    ),

                    // Favorite Button
                    new Border()
                    .Row(0).Column(2)
                    .WidthRequest(40).HeightRequest(40)
                    .BackgroundColor("#F8F9FA".ToColor())
                    .StrokeThickness(0)
                    .StrokeShape(new RoundRectangle().CornerRadius(20))
                    .GestureRecognizers(
                        new TapGestureRecognizer()
                        .Command(e => e.Path(nameof(_viewModel.ToggleFavoriteCommand)).Source(RelativeBindingSource.TemplatedParent))
                    )
                    .Content(
                        new Label()
                        .FontSize(20)
                        .Center()
                        .Triggers(
                            new DataTrigger(typeof(Label))
                            .Binding(new Binding(nameof(Product.IsFavorite)))
                            .Value(true)
                            .Setters(new Setters<Label>(e => e.Text("❤️"))),

                            new DataTrigger(typeof(Label))
                            .Binding(new Binding(nameof(Product.IsFavorite)))
                            .Value(false)
                            .Setters(new Setters<Label>(e => e.Text("🤍")))
                        )
                    )
                )
            );
    }
}
