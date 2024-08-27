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

namespace ConsoleApp1;

//[MauiMarkupAttachedProp(typeof(FormView), nameof(FormView.IsSubmitButtonProperty), typeof(bool), typeof(Button))]
[MauiMarkup(typeof(Button), typeof(FormView), typeof(DataGrid), typeof(TextField), typeof(PickerField), typeof(InputField), typeof(InputKit.Shared.Controls.CheckBox))]
[MauiMarkup(typeof(StatusBarBehavior), typeof(TextEdit), typeof(TextEditBase), typeof(EditBase), typeof(ComboBoxEdit))]
[MauiMarkup(typeof(PasswordEdit), typeof(CheckEdit), typeof(DXPopup), typeof(ComboBoxEditBase), typeof(ItemsEditBase))]
[MauiMarkup(typeof(DXImage), typeof(DXButton), typeof(DXViewBase), typeof(DXBorder), typeof(DXContentPresenterBase))]
[MauiMarkup(typeof(DXContentPresenter), typeof(DXCollectionView), typeof(CartesianChart), typeof(DevExpress.Maui.Controls.TabView), typeof(TabViewItem))]
[MauiMarkup(typeof(DevExpress.Maui.Controls.TabItem), typeof(DXButtonBase), typeof(ShimmerView), typeof(DXCollectionViewBase), typeof(SwipeContainer))]
[MauiMarkup(typeof(SwipeItem), typeof(DateEdit), typeof(CalendarHeaderAppearance), typeof(CalendarDayCellAppearance), typeof(CalendarSelectableCellAppearance))]
[MauiMarkup(typeof(DateEditActualAppearance), typeof(MultilineEdit), typeof(SimpleButton), typeof(DXStackLayout), typeof(DXLayoutBase))]
[MauiMarkup(typeof(SwipeItemBase))]
//[MauiMarkup(typeof(DataGrid))]
public class FileName
{ }";

        var additionalReferences = new[]
        {
            @"C:\Users\gonul\source\repos\FmgLib\FmgLib.MauiMarkup.Generator\FmgLib.MauiMarkup.Generator.Test\DLLs\FmgLib.MauiMarkup.dll",
            @"C:\Users\gonul\source\repos\FmgLib\FmgLib.MauiMarkup.Generator\FmgLib.MauiMarkup.Generator.Test\DLLs\InputKit.Maui.dll",
            @"C:\Users\gonul\source\repos\FmgLib\FmgLib.MauiMarkup.Generator\FmgLib.MauiMarkup.Generator.Test\DLLs\Microsoft.Extensions.Configuration.Abstractions.dll",
            @"C:\Users\gonul\source\repos\FmgLib\FmgLib.MauiMarkup.Generator\FmgLib.MauiMarkup.Generator.Test\DLLs\Microsoft.Extensions.Configuration.dll",
            @"C:\Users\gonul\source\repos\FmgLib\FmgLib.MauiMarkup.Generator\FmgLib.MauiMarkup.Generator.Test\DLLs\Microsoft.Extensions.DependencyInjection.Abstractions.dll",
            @"C:\Users\gonul\source\repos\FmgLib\FmgLib.MauiMarkup.Generator\FmgLib.MauiMarkup.Generator.Test\DLLs\Microsoft.Extensions.DependencyInjection.dll",
            @"C:\Users\gonul\source\repos\FmgLib\FmgLib.MauiMarkup.Generator\FmgLib.MauiMarkup.Generator.Test\DLLs\Microsoft.Extensions.Logging.Abstractions.dll",
            @"C:\Users\gonul\source\repos\FmgLib\FmgLib.MauiMarkup.Generator\FmgLib.MauiMarkup.Generator.Test\DLLs\Microsoft.Extensions.Logging.dll",
            @"C:\Users\gonul\source\repos\FmgLib\FmgLib.MauiMarkup.Generator\FmgLib.MauiMarkup.Generator.Test\DLLs\Microsoft.Extensions.Options.dll",
            @"C:\Users\gonul\source\repos\FmgLib\FmgLib.MauiMarkup.Generator\FmgLib.MauiMarkup.Generator.Test\DLLs\Microsoft.Extensions.Primitives.dll",
            @"C:\Users\gonul\source\repos\FmgLib\FmgLib.MauiMarkup.Generator\FmgLib.MauiMarkup.Generator.Test\DLLs\Microsoft.Maui.Controls.dll",
            @"C:\Users\gonul\source\repos\FmgLib\FmgLib.MauiMarkup.Generator\FmgLib.MauiMarkup.Generator.Test\DLLs\Microsoft.Maui.Controls.Xaml.dll",
            @"C:\Users\gonul\source\repos\FmgLib\FmgLib.MauiMarkup.Generator\FmgLib.MauiMarkup.Generator.Test\DLLs\Microsoft.Maui.dll",
            @"C:\Users\gonul\source\repos\FmgLib\FmgLib.MauiMarkup.Generator\FmgLib.MauiMarkup.Generator.Test\DLLs\Microsoft.Maui.Essentials.dll",
            @"C:\Users\gonul\source\repos\FmgLib\FmgLib.MauiMarkup.Generator\FmgLib.MauiMarkup.Generator.Test\DLLs\Microsoft.Maui.Graphics.dll",
            @"C:\Users\gonul\source\repos\FmgLib\FmgLib.MauiMarkup.Generator\FmgLib.MauiMarkup.Generator.Test\DLLs\Plainer.Maui.dll",
            @"C:\Users\gonul\source\repos\FmgLib\FmgLib.MauiMarkup.Generator\FmgLib.MauiMarkup.Generator.Test\DLLs\UraniumUI.dll",
            @"C:\Users\gonul\source\repos\FmgLib\FmgLib.MauiMarkup.Generator\FmgLib.MauiMarkup.Generator.Test\DLLs\UraniumUI.Material.dll",
            @"C:\Users\gonul\source\repos\FmgLib\FmgLib.MauiMarkup.Generator\FmgLib.MauiMarkup.Generator.Test\DLLs\DevExpress.Data.v23.2.dll",
            @"C:\Users\gonul\source\repos\FmgLib\FmgLib.MauiMarkup.Generator\FmgLib.MauiMarkup.Generator.Test\DLLs\DevExpress.Maui.CollectionView.dll",
            @"C:\Users\gonul\source\repos\FmgLib\FmgLib.MauiMarkup.Generator\FmgLib.MauiMarkup.Generator.Test\DLLs\DevExpress.Maui.Controls.dll",
            @"C:\Users\gonul\source\repos\FmgLib\FmgLib.MauiMarkup.Generator\FmgLib.MauiMarkup.Generator.Test\DLLs\DevExpress.Maui.Core.dll",
            @"C:\Users\gonul\source\repos\FmgLib\FmgLib.MauiMarkup.Generator\FmgLib.MauiMarkup.Generator.Test\DLLs\DevExpress.Maui.Editors.dll",
            @"C:\Users\gonul\source\repos\FmgLib\FmgLib.MauiMarkup.Generator\FmgLib.MauiMarkup.Generator.Test\DLLs\LiveChartsCore.Behaviours.dll",
            @"C:\Users\gonul\source\repos\FmgLib\FmgLib.MauiMarkup.Generator\FmgLib.MauiMarkup.Generator.Test\DLLs\LiveChartsCore.dll",
            @"C:\Users\gonul\source\repos\FmgLib\FmgLib.MauiMarkup.Generator\FmgLib.MauiMarkup.Generator.Test\DLLs\LiveChartsCore.SkiaSharpView.dll",
            @"C:\Users\gonul\source\repos\FmgLib\FmgLib.MauiMarkup.Generator\FmgLib.MauiMarkup.Generator.Test\DLLs\LiveChartsCore.SkiaSharpView.Maui.dll",
            @"C:\Users\gonul\source\repos\FmgLib\FmgLib.MauiMarkup.Generator\FmgLib.MauiMarkup.Generator.Test\DLLs\SkiaSharp.dll",
            @"C:\Users\gonul\source\repos\FmgLib\FmgLib.MauiMarkup.Generator\FmgLib.MauiMarkup.Generator.Test\DLLs\SkiaSharp.HarfBuzz.dll",
            @"C:\Users\gonul\source\repos\FmgLib\FmgLib.MauiMarkup.Generator\FmgLib.MauiMarkup.Generator.Test\DLLs\SkiaSharp.Views.Maui.Controls.Compatibility.dll",
            @"C:\Users\gonul\source\repos\FmgLib\FmgLib.MauiMarkup.Generator\FmgLib.MauiMarkup.Generator.Test\DLLs\SkiaSharp.Views.Maui.Controls.dll",
            @"C:\Users\gonul\source\repos\FmgLib\FmgLib.MauiMarkup.Generator\FmgLib.MauiMarkup.Generator.Test\DLLs\SkiaSharp.Views.Maui.Core.dll",
            @"C:\Users\gonul\source\repos\FmgLib\FmgLib.MauiMarkup.Generator\FmgLib.MauiMarkup.Generator.Test\DLLs\Microsoft.Maui.Controls.Compatibility.dll",
            @"C:\Users\gonul\source\repos\FmgLib\FmgLib.MauiMarkup.Generator\FmgLib.MauiMarkup.Generator.Test\DLLs\CommunityToolkit.Maui.Core.dll",
            @"C:\Users\gonul\source\repos\FmgLib\FmgLib.MauiMarkup.Generator\FmgLib.MauiMarkup.Generator.Test\DLLs\CommunityToolkit.Maui.dll"
        };

        var (compilation, diagnostics) = CreateCompilation(source, additionalReferences);

        var generator = new SourceGenerator();
        var driver = CSharpGeneratorDriver.Create(generator);

        driver = (CSharpGeneratorDriver)driver.RunGeneratorsAndUpdateCompilation(compilation, out var outputCompilation, out var diagnostics2);

        var generatedDiagnostics = outputCompilation.GetDiagnostics();
        //Assert.IsEmpty(generatedDiagnostics.Where(d => d.Severity == DiagnosticSeverity.Error));

        var runResult = driver.GetRunResult();

        //Assert.AreEqual(2, runResult.GeneratedTrees.Length); // Attribute and the generated class
        //Assert.IsEmpty(runResult.Diagnostics.Where(d => d.Severity == DiagnosticSeverity.Error));
    }
}
