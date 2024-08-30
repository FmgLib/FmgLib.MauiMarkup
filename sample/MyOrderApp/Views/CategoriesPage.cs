using Microsoft.Maui.Layouts;

namespace MyOrderApp.Views;

public partial class CategoriesPage : BasePage<CategoriesPageViewModel>
{
    public CategoriesPage(CategoriesPageViewModel viewModel) : base(viewModel, "Kategoriler")
    {
    }

    public override void Build()
    {
        this
        .Content(
            new VerticalStackLayout()
            .Margin(10)
            .FillHorizontal()
            .Children(
                new CollectionView()
                .SelectionMode(SelectionMode.None)
                //.ItemsSource(e => e.Path("Categories"))
                .Bind(CollectionView.ItemsSourceProperty, "Categories")
                .ItemsLayout(
                    new LinearItemsLayout(ItemsLayoutOrientation.Vertical)
                    .ItemSpacing(10)
                )
                .EmptyView(
                    new VerticalStackLayout()
                    .Center()
                    .Children(
                        new Label()
                            .Text("Kayıt Yoktur.")
                            .TextColor(Colors.Red)
                            .FontAttributes(FontAttributes.Bold)
                            .FontSize(18)
                    )
                )
                .ItemTemplate(
                    () => 
                        new Expander()
                        .IsExpanded(true)
                        .Assign(out var expander)
                        .Header(
                            new Frame()
                            .BackgroundColor(Colors.Transparent)
                            .BorderColor(Colors.Transparent)
                            .Padding(0)
                            .Content(
                                new Grid()
                                .ColumnDefinitions(e => e.Star(9).Star(1))
                                .Margin(5)
                                .Children(
                                    new Label()
                                    .Text(e => e.Path(nameof(CategoryVM.Name)))
                                    //.Bind(Label.TextProperty, nameof(CategoryVM.Name))
                                    .FontSize(18)
                                    .FontAttributes(FontAttributes.Bold)
                                    .Column(0),

                                    new Image()
                                    .Source("chevron.png")
                                    .SizeRequest(25,25)
                                    .Column(1)
                                    .AlignBottomRight()
                                    .Assign(out var image)
                                    .Triggers(
                                        new MultiTrigger(typeof(Image))
                                        .Conditions(
                                            new BindingCondition()
                                            .Binding(b => b
                                                           .Source(expander)
                                                           .Path("IsExpanded"))
                                            .Value(true)
                                        )
                                        .Setters(new Setters<Image>(e => e.Rotation(180)))
                                    )
                                )
                            )
                        )
                        .Content(
                            new CollectionView()
                            .SelectionMode(SelectionMode.None)
                            .ItemsSource(e => e.Path(nameof(CategoryVM.SubCategories)))
                            //.Bind(CollectionView.ItemsSourceProperty, nameof(CategoryVM.SubCategories))
                            .ItemsLayout(
                                new GridItemsLayout(ItemsLayoutOrientation.Vertical)
                                .Span(2)
                                .HorizontalItemSpacing(10)
                                .VerticalItemSpacing(10)
                            )
                            .EmptyView(
                                new VerticalStackLayout()
                                .Center()
                                .Children(
                                    new Label()
                                        .Text("Kayıt Yoktur.")
                                        .TextColor(Colors.Red)
                                        .FontAttributes(FontAttributes.Bold)
                                        .FontSize(18)
                                )
                            )
                            .ItemTemplate(
                                () => new Frame()
                                        .CornerRadius(15)
                                        .BorderColor(Colors.LightGray)
                                        .BackgroundColor(Colors.LightGray)
                                        .MinimumHeightRequest(30)
                                        .WidthRequest(180)
                                        .Padding(0)
                                        .Margin(new Thickness(1, 0, 5, 5))
                                        .FlexBasis(FlexBasis.Auto)
                                        .Content(
                                            new Grid()
                                            .ColumnDefinitions(e => e.Star(3).Star(7))
                                            .Padding(5)
                                            .Children(
                                                new Image()
                                                .Source(e => e.Path(nameof(SubCategoryVM.Icon)))
                                                //.Bind(Image.SourceProperty, nameof(SubCategoryVM.Icon))
                                                .SizeRequest(30, 30)
                                                .Column(0)
                                                .CenterVertical(),

                                                new Label()
                                                .Text(e => e.Path(nameof(SubCategoryVM.Name)))
                                                //.Bind(Label.TextProperty, nameof(SubCategoryVM.Name))
                                                .TextColor(Colors.CornflowerBlue)
                                                .FontAttributes(FontAttributes.Bold)
                                                .FontSize(12)
                                                .Column(1)
                                                .FontAutoScalingEnabled(true)
                                                .CenterVertical()
                                            )
                                        )
                            )
                        )
                )
            )
        );
    }
}
