using FluentAssertions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Immutable;

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
    public void TestSourceGenerator()
    {
        var rootPath = AppDomain.CurrentDomain.BaseDirectory;
        var source = @"
using InputKit.Shared.Controls;
using UraniumUI.Material.Controls;
using Microsoft.Maui.Controls;
using FmgLib.MauiMarkup;
using DevExpress.Maui.Core.Internal;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Controls.Compatibility.Hosting;
using SkiaSharp.Views.Maui.Controls.Hosting;
using DXImage = DevExpress.Maui.Core.DXImage;
using SwipeItem = DevExpress.Maui.CollectionView.SwipeItem;
using CommunityToolkit.Maui.Behaviors;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Maui;
using DevExpress.Maui.Controls;
using DevExpress.Maui.Editors;
using DevExpress.Maui.CollectionView;
using DevExpress.Maui.Core;
using DevExpress.Maui;
using PanCardView;
using SkiaSharp.Views.Maui.Controls.Hosting;
using SkiaSharp.Extended.UI.Controls;

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
[MauiMarkup(typeof(Syncfusion.Maui.Core.SfAvatarView))]
public class FileName
{ }";

        var additionalReferences = new[]
        {
            @$"{rootPath}\DLLs\FmgLib.MauiMarkup.dll",
            @$"{rootPath}\DLLs\InputKit.Maui.dll",
            @$"{rootPath}\DLLs\Microsoft.Extensions.Configuration.Abstractions.dll",
            @$"{rootPath}\DLLs\Microsoft.Extensions.Configuration.dll",
            @$"{rootPath}\DLLs\Microsoft.Extensions.DependencyInjection.Abstractions.dll",
            @$"{rootPath}\DLLs\Microsoft.Extensions.DependencyInjection.dll",
            @$"{rootPath}\DLLs\Microsoft.Extensions.Logging.Abstractions.dll",
            @$"{rootPath}\DLLs\Microsoft.Extensions.Logging.dll",
            @$"{rootPath}\DLLs\Microsoft.Extensions.Options.dll",
            @$"{rootPath}\DLLs\Microsoft.Extensions.Primitives.dll",
            @$"{rootPath}\DLLs\Microsoft.Maui.Controls.dll",
            @$"{rootPath}\DLLs\Microsoft.Maui.Controls.Xaml.dll",
            @$"{rootPath}\DLLs\Microsoft.Maui.dll",
            @$"{rootPath}\DLLs\Microsoft.Maui.Essentials.dll",
            @$"{rootPath}\DLLs\Microsoft.Maui.Graphics.dll",
            @$"{rootPath}\DLLs\Plainer.Maui.dll",
            @$"{rootPath}\DLLs\UraniumUI.dll",
            @$"{rootPath}\DLLs\UraniumUI.Material.dll",
            @$"{rootPath}\DLLs\DevExpress.Data.v23.2.dll",
            @$"{rootPath}\DLLs\DevExpress.Maui.CollectionView.dll",
            @$"{rootPath}\DLLs\DevExpress.Maui.Controls.dll",
            @$"{rootPath}\DLLs\DevExpress.Maui.Core.dll",
            @$"{rootPath}\DLLs\DevExpress.Maui.Editors.dll",
            @$"{rootPath}\DLLs\LiveChartsCore.Behaviours.dll",
            @$"{rootPath}\DLLs\LiveChartsCore.dll",
            @$"{rootPath}\DLLs\LiveChartsCore.SkiaSharpView.dll",
            @$"{rootPath}\DLLs\LiveChartsCore.SkiaSharpView.Maui.dll",
            @$"{rootPath}\DLLs\SkiaSharp.dll",
            @$"{rootPath}\DLLs\SkiaSharp.HarfBuzz.dll",
            @$"{rootPath}\DLLs\SkiaSharp.Views.Maui.Controls.Compatibility.dll",
            @$"{rootPath}\DLLs\SkiaSharp.Views.Maui.Controls.dll",
            @$"{rootPath}\DLLs\SkiaSharp.Views.Maui.Core.dll",
            @$"{rootPath}\DLLs\Microsoft.Maui.Controls.Compatibility.dll",
            @$"{rootPath}\DLLs\CommunityToolkit.Maui.Core.dll",
            @$"{rootPath}\DLLs\CommunityToolkit.Maui.dll",
            @$"{rootPath}\DLLs\PanCardView.dll",
            @$"{rootPath}\DLLs\SkiaSharp.Extended.dll",
            @$"{rootPath}\DLLs\SkiaSharp.Extended.UI.dll",
            @$"{rootPath}\DLLs\SkiaSharp.SceneGraph.dll",
            @$"{rootPath}\DLLs\SkiaSharp.Skottie.dll",
            @$"{rootPath}\DLLs\Syncfusion.Licensing.dll",
            @$"{rootPath}\DLLs\Syncfusion.Maui.Core.dll",
            @$"{rootPath}\DLLs\Syncfusion.Maui.Data.dll",
            @$"{rootPath}\DLLs\Syncfusion.Maui.DataGrid.dll",
            @$"{rootPath}\DLLs\Syncfusion.Maui.DataSource.dll",
            @$"{rootPath}\DLLs\Syncfusion.Maui.GridCommon.dll",
            @$"{rootPath}\DLLs\Syncfusion.Maui.Inputs.dll",
            @$"{rootPath}\DLLs\Syncfusion.Maui.ListView.dll",
            @$"{rootPath}\DLLs\Syncfusion.Maui.PullToRefresh.dll"
        };

        var (compilation, diagnostics) = CreateCompilation(source, additionalReferences);

        var generator = new SourceGenerator();
        var driver = CSharpGeneratorDriver.Create(generator);

        driver = (CSharpGeneratorDriver)driver.RunGeneratorsAndUpdateCompilation(compilation, out var outputCompilation, out var diagnostics2);

        var generatedDiagnostics = outputCompilation.GetDiagnostics();

        var runResult = driver.GetRunResult();

        runResult.GeneratedTrees.Should().HaveCountGreaterThanOrEqualTo(2);
    }
}
