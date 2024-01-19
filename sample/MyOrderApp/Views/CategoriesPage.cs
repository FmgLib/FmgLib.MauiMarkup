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
        .ContentFmg(
            new VerticalStackLayout()
            .MarginFmg(10)
            .FillHorizontalFmg()
            .ChildrenFmg(
                new CollectionView()
                .SelectionModeFmg(SelectionMode.None)
                .BindFmg(CollectionView.ItemsSourceProperty, "Categories")
                .ItemsLayoutFmg(
                    new LinearItemsLayout(ItemsLayoutOrientation.Vertical)
                    .ItemSpacingFmg(10)
                )
                .EmptyViewFmg(
                    new VerticalStackLayout()
                    .CenterFmg()
                    .ChildrenFmg(
                        new Label()
                            .TextFmg("Kayıt Yoktur.")
                            .TextColorFmg(Colors.Red)
                            .FontAttributesFmg(FontAttributes.Bold)
                            .FontSizeFmg(18)
                    )
                )
                .ItemTemplateFmg(
                    () => 
                        new Expander()
                        .IsExpandedFmg(true)
                        .AssignFmg(out var expander)
                        .HeaderFmg(
                            new Frame()
                            .BackgroundColorFmg(Colors.Transparent)
                            .BorderColorFmg(Colors.Transparent)
                            .PaddingFmg(0)
                            .ContentFmg(
                                new Grid()
                                .ColumnDefinitionsFmg(e => e.Star(9).Star(1))
                                .MarginFmg(5)
                                .ChildrenFmg(
                                    new Label()
                                    .BindFmg(Label.TextProperty, nameof(CategoryVM.Name))
                                    .FontSizeFmg(18)
                                    .FontAttributesFmg(FontAttributes.Bold)
                                    .ColumnFmg(0),

                                    new Image()
                                    .SourceFmg("chevron.png")
                                    .SizeRequestFmg(25,25)
                                    .ColumnFmg(1)
                                    .AlignEndFmg()
                                    .AssignFmg(out var image)
                                    .TriggersFmg(
                                        new MultiTrigger(typeof(Image))
                                        .ConditionsFmg(
                                            new BindingCondition()
                                            .BindingFmg(b => b
                                                           .SourceFmg(expander)
                                                           .PathFmg("IsExpanded"))
                                            .ValueFmg(true)
                                        )
                                        .SettersFmg(new Setters<Image>(e => e.RotationFmg(180)))
                                    )
                                )
                            )
                        )
                        .ContentsFmg(
                            new CollectionView()
                            .SelectionModeFmg(SelectionMode.None)
                            .BindFmg(CollectionView.ItemsSourceProperty, nameof(CategoryVM.SubCategories))
                            .ItemsLayoutFmg(
                                new GridItemsLayout(ItemsLayoutOrientation.Vertical)
                                .SpanFmg(2)
                                .HorizontalItemSpacingFmg(10)
                                .VerticalItemSpacingFmg(10)
                            )
                            .EmptyViewFmg(
                                new VerticalStackLayout()
                                .CenterFmg()
                                .ChildrenFmg(
                                    new Label()
                                        .TextFmg("Kayıt Yoktur.")
                                        .TextColorFmg(Colors.Red)
                                        .FontAttributesFmg(FontAttributes.Bold)
                                        .FontSizeFmg(18)
                                )
                            )
                            .ItemTemplateFmg(
                                () => new Frame()
                                        .CornerRadiusFmg(15)
                                        .BorderColorFmg(Colors.LightGray)
                                        .BackgroundColorFmg(Colors.LightGray)
                                        .MinimumHeightRequestFmg(30)
                                        .WidthRequestFmg(180)
                                        .PaddingFmg(0)
                                        .MarginFmg(new Thickness(1, 0, 5, 5))
                                        .FlexBasisFmg(FlexBasis.Auto)
                                        .ContentFmg(
                                            new Grid()
                                            .ColumnDefinitionsFmg(e => e.Star(3).Star(7))
                                            .PaddingFmg(5)
                                            .ChildrenFmg(
                                                new Image()
                                                .BindFmg(Image.SourceProperty, nameof(SubCategoryVM.Icon))
                                                .SizeRequestFmg(30, 30)
                                                .ColumnFmg(0)
                                                .CenterVerticalFmg(),

                                                new Label()
                                                .BindFmg(Label.TextProperty, nameof(SubCategoryVM.Name))
                                                .TextColorFmg(Colors.CornflowerBlue)
                                                .FontAttributesFmg(FontAttributes.Bold)
                                                .FontSizeFmg(12)
                                                .ColumnFmg(1)
                                                .FontAutoScalingEnabledFmg(true)
                                                .CenterVerticalFmg()
                                            )
                                        )
                            )
                        )
                )
            )
        );
    }
}
