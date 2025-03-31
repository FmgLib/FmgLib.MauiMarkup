using FluentAssertions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Immutable;
using System.Diagnostics;

namespace FmgLib.MauiMarkup.Generator.Test;

[TestFixture]
public class IntegrationTesting
{
    private static (Compilation, ImmutableArray<Diagnostic>) CreateCompilation(string source, params string[] additionalReferences)
    {
        var syntaxTree = CSharpSyntaxTree.ParseText(source);
        var references = AppDomain.CurrentDomain.GetAssemblies()
            .Where(a => !a.IsDynamic && !string.IsNullOrWhiteSpace(a.Location))
            .Select(a => MetadataReference.CreateFromFile(a.Location))
            .Cast<MetadataReference>()
            .ToList();

        foreach (var reference in additionalReferences)
        {
            references.Add(MetadataReference.CreateFromFile(reference));
        }

        var compilation = CSharpCompilation.Create("SourceGeneratorTests",
            new[] { syntaxTree },
            references,
            new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));

        return (compilation, compilation.GetDiagnostics());
    }

    [Test]
    public async Task TestSourceGenerator()
    {
        var rootPath = AppDomain.CurrentDomain.BaseDirectory;
        var source = @"
// using InputKit.Shared.Controls;
// using UraniumUI.Material.Controls;
using Microsoft.Maui.Controls;
using FmgLib.MauiMarkup;
// using DevExpress.Maui.Core.Internal;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Controls.Compatibility.Hosting;
// using SkiaSharp.Views.Maui.Controls.Hosting;
// using DXImage = DevExpress.Maui.Core.DXImage;
// using SwipeItem = DevExpress.Maui.CollectionView.SwipeItem;
// using CommunityToolkit.Maui.Behaviors;
// using LiveChartsCore;
// using LiveChartsCore.SkiaSharpView;
// using LiveChartsCore.SkiaSharpView.Maui;
// using DevExpress.Maui.Controls;
// using DevExpress.Maui.Editors;
// using DevExpress.Maui.CollectionView;
// using DevExpress.Maui.Core;
// using DevExpress.Maui;
// using PanCardView;
// using SkiaSharp.Views.Maui.Controls.Hosting;
// using SkiaSharp.Extended.UI.Controls;

namespace ConsoleApp1;

//[MauiMarkupAttachedProp(typeof(FormView), nameof(FormView.IsSubmitButtonProperty), typeof(bool), typeof(Button))]
//[MauiMarkup(typeof(Button), typeof(FormView), typeof(DataGrid), typeof(TextField), typeof(PickerField), typeof(InputField), typeof(InputKit.Shared.Controls.CheckBox))]
//[MauiMarkup(typeof(StatusBarBehavior), typeof(TextEdit), typeof(TextEditBase), typeof(EditBase), typeof(ComboBoxEdit))]
//[MauiMarkup(typeof(PasswordEdit), typeof(CheckEdit), typeof(DXPopup), typeof(ComboBoxEditBase), typeof(ItemsEditBase))]
//[MauiMarkup(typeof(DXImage), typeof(DXButton), typeof(DXViewBase), typeof(DXBorder), typeof(DXContentPresenterBase))]
//[MauiMarkup(typeof(DXContentPresenter), typeof(DXCollectionView), typeof(CartesianChart), typeof(DevExpress.Maui.Controls.TabView), typeof(TabViewItem))]
//[MauiMarkup(typeof(DevExpress.Maui.Controls.TabItem), typeof(DXButtonBase), typeof(ShimmerView), typeof(DXCollectionViewBase), typeof(SwipeContainer))]
//[MauiMarkup(typeof(SwipeItem), typeof(DateEdit), typeof(CalendarHeaderAppearance), typeof(CalendarDayCellAppearance), typeof(CalendarSelectableCellAppearance))]
//[MauiMarkup(typeof(DateEditActualAppearance), typeof(MultilineEdit), typeof(SimpleButton), typeof(DXStackLayout), typeof(DXLayoutBase))]
//[MauiMarkup(typeof(CardsView), typeof(VisualStateGroup))]
//[MauiMarkup(typeof(SKLottieView),typeof(SKFileLottieImageSource), typeof(SKAnimatedSurfaceView))]
[MauiMarkup(
    typeof(Microsoft.Maui.Controls.SelectableItemsView),
    typeof(Microsoft.Maui.Controls.CompareStateTrigger),
    typeof(Microsoft.Maui.Controls.ActivityIndicator),
    typeof(Microsoft.Maui.Controls.AdaptiveTrigger),
    typeof(Microsoft.Maui.Controls.AppLinkEntry),
    typeof(Microsoft.Maui.Controls.Shapes.ArcSegment),
    typeof(Microsoft.Maui.Controls.BackButtonBehavior),
    typeof(Microsoft.Maui.Controls.BaseShellItem),
    typeof(Microsoft.Maui.Controls.Shapes.BezierSegment),
    typeof(Microsoft.Maui.Controls.Border),
    typeof(Microsoft.Maui.Controls.BoxView),
    typeof(Microsoft.Maui.Controls.Button),
    typeof(Microsoft.Maui.Controls.CarouselView),
    typeof(Microsoft.Maui.Controls.Cell),
    typeof(Microsoft.Maui.Controls.CheckBox),
    typeof(Microsoft.Maui.Controls.ClickGestureRecognizer),
    typeof(Microsoft.Maui.Controls.Compatibility.Layout),
    typeof(Microsoft.Maui.Controls.Shapes.CompositeTransform),
    typeof(Microsoft.Maui.Controls.ColumnDefinition),
    typeof(Microsoft.Maui.Controls.ContentPage),
    typeof(Microsoft.Maui.Controls.ContentPresenter),
    typeof(Microsoft.Maui.Controls.ContentView),
    typeof(Microsoft.Maui.Controls.DatePicker),
    typeof(Microsoft.Maui.Controls.DeviceStateTrigger),
    typeof(Microsoft.Maui.Controls.DragGestureRecognizer),
    typeof(Microsoft.Maui.Controls.DropGestureRecognizer),
    typeof(Microsoft.Maui.Controls.Editor),
    typeof(Microsoft.Maui.Controls.Element),
    typeof(Microsoft.Maui.Controls.Shapes.EllipseGeometry),
    typeof(Microsoft.Maui.Controls.EntryCell),
    typeof(Microsoft.Maui.Controls.Entry),
    typeof(Microsoft.Maui.Controls.FileImageSource),
    typeof(Microsoft.Maui.Controls.FlexLayout),
    typeof(Microsoft.Maui.Controls.FlyoutPage),
    typeof(Microsoft.Maui.Controls.FontImageSource),
    typeof(Microsoft.Maui.Controls.Frame),
    typeof(Microsoft.Maui.Controls.Shapes.GeometryGroup),
    typeof(Microsoft.Maui.Controls.GradientBrush),
    typeof(Microsoft.Maui.Controls.GradientStop),
    typeof(Microsoft.Maui.Controls.GraphicsView),
    typeof(Microsoft.Maui.Controls.Grid),
    typeof(Microsoft.Maui.Controls.GridItemsLayout),
    typeof(Microsoft.Maui.Controls.GroupableItemsView),
    typeof(Microsoft.Maui.Controls.HtmlWebViewSource),
    typeof(Microsoft.Maui.Controls.HybridWebView),
    typeof(Microsoft.Maui.Controls.ImageButton),
    typeof(Microsoft.Maui.Controls.ImageCell),
    typeof(Microsoft.Maui.Controls.Image),
    typeof(Microsoft.Maui.Controls.IndicatorView),
    typeof(Microsoft.Maui.Controls.InputView),
    typeof(Microsoft.Maui.Controls.ItemsLayout),
    typeof(Microsoft.Maui.Controls.ItemsView),
    /*typeof(Microsoft.Maui.Controls.ItemsView<Cell>),*/
    typeof(Microsoft.Maui.Controls.KeyboardAccelerator),
    typeof(Microsoft.Maui.Controls.Label),
    typeof(Microsoft.Maui.Controls.Layout),
    typeof(Microsoft.Maui.Controls.LinearGradientBrush),
    typeof(Microsoft.Maui.Controls.LinearItemsLayout),
    typeof(Microsoft.Maui.Controls.Shapes.Line),
    typeof(Microsoft.Maui.Controls.Shapes.LineGeometry),
    typeof(Microsoft.Maui.Controls.Shapes.LineSegment),
    typeof(Microsoft.Maui.Controls.ListView),
    typeof(Microsoft.Maui.Controls.Shapes.MatrixTransform),
    typeof(Microsoft.Maui.Controls.MenuBar),
    typeof(Microsoft.Maui.Controls.MenuBarItem),
    typeof(Microsoft.Maui.Controls.MenuItem),
    /*typeof(Microsoft.Maui.Controls.MultiPage<Page>),*/
    typeof(Microsoft.Maui.Controls.NavigableElement),
    typeof(Microsoft.Maui.Controls.NavigationPage),
    typeof(Microsoft.Maui.Controls.OrientationStateTrigger),
    typeof(Microsoft.Maui.Controls.Page),
    typeof(Microsoft.Maui.Controls.PanGestureRecognizer),
    typeof(Microsoft.Maui.Controls.Shapes.Path),
    typeof(Microsoft.Maui.Controls.Shapes.PathFigure),
    typeof(Microsoft.Maui.Controls.Shapes.PathGeometry),
    typeof(Microsoft.Maui.Controls.Picker),
    typeof(Microsoft.Maui.Controls.PointerGestureRecognizer),
    typeof(Microsoft.Maui.Controls.Shapes.PolyBezierSegment),
    typeof(Microsoft.Maui.Controls.Shapes.Polygon),
    typeof(Microsoft.Maui.Controls.Shapes.Polyline),
    typeof(Microsoft.Maui.Controls.Shapes.PolyLineSegment),
    typeof(Microsoft.Maui.Controls.Shapes.PolyQuadraticBezierSegment),
    typeof(Microsoft.Maui.Controls.ProgressBar),
    typeof(Microsoft.Maui.Controls.Shapes.QuadraticBezierSegment),
    typeof(Microsoft.Maui.Controls.RadialGradientBrush),
    typeof(Microsoft.Maui.Controls.RadioButton),
    typeof(Microsoft.Maui.Controls.Shapes.Rectangle),
    typeof(Microsoft.Maui.Controls.Shapes.RectangleGeometry),
    typeof(Microsoft.Maui.Controls.RefreshView),
    typeof(Microsoft.Maui.Controls.ReorderableItemsView),
    typeof(Microsoft.Maui.Controls.Shapes.RotateTransform),
    typeof(Microsoft.Maui.Controls.Shapes.RoundRectangle),
    typeof(Microsoft.Maui.Controls.Shapes.RoundRectangleGeometry),
    typeof(Microsoft.Maui.Controls.RowDefinition),
    typeof(Microsoft.Maui.Controls.Shapes.ScaleTransform),
    typeof(Microsoft.Maui.Controls.ScrollView),
    typeof(Microsoft.Maui.Controls.SearchBar),
    typeof(Microsoft.Maui.Controls.SearchHandler),
    typeof(Microsoft.Maui.Controls.Shadow),
    typeof(Microsoft.Maui.Controls.Shapes.Shape),
    typeof(Microsoft.Maui.Controls.ShellContent),
    typeof(Microsoft.Maui.Controls.Shell),
    typeof(Microsoft.Maui.Controls.ShellGroupItem),
    typeof(Microsoft.Maui.Controls.ShellItem),
    typeof(Microsoft.Maui.Controls.ShellSection),
    typeof(Microsoft.Maui.Controls.Shapes.SkewTransform),
    typeof(Microsoft.Maui.Controls.Slider),
    typeof(Microsoft.Maui.Controls.SolidColorBrush),
    typeof(Microsoft.Maui.Controls.Span),
    typeof(Microsoft.Maui.Controls.StackBase),
    typeof(Microsoft.Maui.Controls.StackLayout),
    typeof(Microsoft.Maui.Controls.StateTrigger),
    typeof(Microsoft.Maui.Controls.Stepper),
    typeof(Microsoft.Maui.Controls.StreamImageSource),
    typeof(Microsoft.Maui.Controls.StructuredItemsView),
    typeof(Microsoft.Maui.Controls.SwipeGestureRecognizer),
    typeof(Microsoft.Maui.Controls.SwipeItem),
    typeof(Microsoft.Maui.Controls.SwipeItems),
    typeof(Microsoft.Maui.Controls.SwipeItemView),
    typeof(Microsoft.Maui.Controls.SwipeView),
    typeof(Microsoft.Maui.Controls.SwitchCell),
    typeof(Microsoft.Maui.Controls.Switch),
    typeof(Microsoft.Maui.Controls.TabbedPage),
    typeof(Microsoft.Maui.Controls.TableSectionBase),
    typeof(Microsoft.Maui.Controls.TableView),
    typeof(Microsoft.Maui.Controls.TapGestureRecognizer),
    typeof(Microsoft.Maui.Controls.TemplatedPage),
    typeof(Microsoft.Maui.Controls.TemplatedView),
    typeof(Microsoft.Maui.Controls.TextCell),
    typeof(Microsoft.Maui.Controls.TimePicker),
    typeof(Microsoft.Maui.Controls.TitleBar),
    typeof(Microsoft.Maui.Controls.Shapes.Transform),
    typeof(Microsoft.Maui.Controls.Shapes.TransformGroup),
    typeof(Microsoft.Maui.Controls.Shapes.TranslateTransform),
    typeof(Microsoft.Maui.Controls.UriImageSource),
    typeof(Microsoft.Maui.Controls.UrlWebViewSource),
    typeof(Microsoft.Maui.Controls.VisualElement),
    typeof(Microsoft.Maui.Controls.WebView),
    typeof(Microsoft.Maui.Controls.Window)
)]
public class FileName
{ }";

        var additionalReferences = new[]
        {
            @$"{rootPath}/DLLs/FmgLib.MauiMarkup.dll",
            @$"{rootPath}/DLLs/InputKit.Maui.dll",
            @$"{rootPath}/DLLs/Microsoft.Extensions.Configuration.Abstractions.dll",
            @$"{rootPath}/DLLs/Microsoft.Extensions.Configuration.dll",
            @$"{rootPath}/DLLs/Microsoft.Extensions.DependencyInjection.Abstractions.dll",
            @$"{rootPath}/DLLs/Microsoft.Extensions.DependencyInjection.dll",
            @$"{rootPath}/DLLs/Microsoft.Extensions.Logging.Abstractions.dll",
            @$"{rootPath}/DLLs/Microsoft.Extensions.Logging.dll",
            @$"{rootPath}/DLLs/Microsoft.Extensions.Options.dll",
            @$"{rootPath}/DLLs/Microsoft.Extensions.Primitives.dll",
            @$"{rootPath}/DLLs/Microsoft.Maui.Controls.dll",
            @$"{rootPath}/DLLs/Microsoft.Maui.Controls.Xaml.dll",
            @$"{rootPath}/DLLs/Microsoft.Maui.dll",
            @$"{rootPath}/DLLs/Microsoft.Maui.Essentials.dll",
            @$"{rootPath}/DLLs/Microsoft.Maui.Graphics.dll",
            @$"{rootPath}/DLLs/Plainer.Maui.dll",
            @$"{rootPath}/DLLs/UraniumUI.dll",
            @$"{rootPath}/DLLs/UraniumUI.Material.dll",
            @$"{rootPath}/DLLs/DevExpress.Data.v23.2.dll",
            @$"{rootPath}/DLLs/DevExpress.Maui.CollectionView.dll",
            @$"{rootPath}/DLLs/DevExpress.Maui.Controls.dll",
            @$"{rootPath}/DLLs/DevExpress.Maui.Core.dll",
            @$"{rootPath}/DLLs/DevExpress.Maui.Editors.dll",
            @$"{rootPath}/DLLs/LiveChartsCore.Behaviours.dll",
            @$"{rootPath}/DLLs/LiveChartsCore.dll",
            @$"{rootPath}/DLLs/LiveChartsCore.SkiaSharpView.dll",
            @$"{rootPath}/DLLs/LiveChartsCore.SkiaSharpView.Maui.dll",
            @$"{rootPath}/DLLs/SkiaSharp.dll",
            @$"{rootPath}/DLLs/SkiaSharp.HarfBuzz.dll",
            @$"{rootPath}/DLLs/SkiaSharp.Views.Maui.Controls.Compatibility.dll",
            @$"{rootPath}/DLLs/SkiaSharp.Views.Maui.Controls.dll",
            @$"{rootPath}/DLLs/SkiaSharp.Views.Maui.Core.dll",
            @$"{rootPath}/DLLs/Microsoft.Maui.Controls.Compatibility.dll",
            @$"{rootPath}/DLLs/CommunityToolkit.Maui.Core.dll",
            @$"{rootPath}/DLLs/CommunityToolkit.Maui.dll",
            @$"{rootPath}/DLLs/PanCardView.dll",
            @$"{rootPath}/DLLs/SkiaSharp.Extended.dll",
            @$"{rootPath}/DLLs/SkiaSharp.Extended.UI.dll",
            @$"{rootPath}/DLLs/SkiaSharp.SceneGraph.dll",
            @$"{rootPath}/DLLs/SkiaSharp.Skottie.dll",
            @$"{rootPath}/DLLs/Syncfusion.Licensing.dll",
            @$"{rootPath}/DLLs/Syncfusion.Maui.Core.dll",
            @$"{rootPath}/DLLs/Syncfusion.Maui.Data.dll",
            @$"{rootPath}/DLLs/Syncfusion.Maui.DataGrid.dll",
            @$"{rootPath}/DLLs/Syncfusion.Maui.DataSource.dll",
            @$"{rootPath}/DLLs/Syncfusion.Maui.GridCommon.dll",
            @$"{rootPath}/DLLs/Syncfusion.Maui.Inputs.dll",
            @$"{rootPath}/DLLs/Syncfusion.Maui.ListView.dll",
            @$"{rootPath}/DLLs/Syncfusion.Maui.PullToRefresh.dll"
        };

        var (compilation, diagnostics) = CreateCompilation(source, additionalReferences);

        var generator = new SourceGenerator();
        var driver = CSharpGeneratorDriver.Create(generator);

        driver = (CSharpGeneratorDriver)driver.RunGeneratorsAndUpdateCompilation(compilation, out var outputCompilation, out var diagnostics2);

        var generatedDiagnostics = outputCompilation.GetDiagnostics();

        var runResult = driver.GetRunResult();
        foreach (var item in runResult.GeneratedTrees)
        {
            await CreateFileAsync(item.FilePath.Substring(item.FilePath.LastIndexOf('/') + 1),
                item.GetText(CancellationToken.None).ToString());
        }
        runResult.GeneratedTrees.Should().HaveCountGreaterThanOrEqualTo(2);
    }
    
    public static async Task<bool> CreateFileAsync(string fileName, string content)
    {
        try
        {
            // MacOS'ta kullanıcı ana dizinini al
            string homeDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                
            // "generated" klasör yolu oluştur
            string generatedDirectory = Path.Combine(homeDirectory, "generated");
                
            // Klasör yoksa oluştur
            if (!Directory.Exists(generatedDirectory))
            {
                Directory.CreateDirectory(generatedDirectory);
                Debug.WriteLine($"'{generatedDirectory}' klasörü oluşturuldu.");
            }
                
            // Dosya yolunu oluştur
            string filePath = Path.Combine(generatedDirectory, fileName);
                
            // Dosyayı oluştur ve içeriği yaz
            await File.WriteAllTextAsync(filePath, content);
                
            Debug.WriteLine($"'{fileName}' başarıyla oluşturuldu: {filePath}");
            return true;
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Hata oluştu: {ex.Message}");
            return false;
        }
    }
}
