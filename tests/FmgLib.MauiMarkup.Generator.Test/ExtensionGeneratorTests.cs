using FmgLib.MauiMarkup.Generator.Extensions;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;

namespace FmgLib.MauiMarkup.Generator.Test;

[TestFixture]
public class ExtensionGeneratorTests
{
    [Test]
    public void Build_ReturnsExpectedValues()
    {
        // Arrange
        // GeneratorExecutionContext örneği oluşturma
        var syntaxTree = SyntaxFactory.ParseSyntaxTree(@"
using System;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

namespace ZXing.Net.Maui.Controls;

public class CameraView : View, ICameraView, IView, IElement, ITransform, ICameraFrameAnalyzer
{
    public static readonly BindableProperty IsTorchOnProperty = BindableProperty.Create(""IsTorchOn"", typeof(bool), typeof(CameraView), true);

    public static readonly BindableProperty CameraLocationProperty = BindableProperty.Create(""CameraLocation"", typeof(CameraLocation), typeof(CameraView), CameraLocation.Rear);

    public bool IsTorchOn
    {
        get
        {
            return (bool)GetValue(IsTorchOnProperty);
        }
        set
        {
            SetValue(IsTorchOnProperty, value);
        }
    }

    public CameraLocation CameraLocation
    {
        get
        {
            return (CameraLocation)GetValue(CameraLocationProperty);
        }
        set
        {
            SetValue(CameraLocationProperty, value);
        }
    }

    private CameraViewHandler StrongHandler => base.Handler as CameraViewHandler;

    public event EventHandler<CameraFrameBufferEventArgs> FrameReady;

    void ICameraFrameAnalyzer.FrameReady(CameraFrameBufferEventArgs e)
    {
        this.FrameReady?.Invoke(this, e);
    }

    public void AutoFocus()
    {
        StrongHandler?.Invoke(""AutoFocus"", null);
    }

    public void Focus(Point point)
    {
        StrongHandler?.Invoke(""Focus"", point);
    }
}
");
        var compilation = CSharpCompilation.Create("ExampleCompilation")
            .AddReferences(MetadataReference.CreateFromFile(typeof(object).Assembly.Location))
            .AddSyntaxTrees(syntaxTree);


        // INamedTypeSymbol örneği oluşturma
        var semanticModel = compilation.GetSemanticModel(syntaxTree);
        var root = syntaxTree.GetCompilationUnitRoot();
        var exampleClass = root.DescendantNodes().OfType<ClassDeclarationSyntax>().First();
        var symbol = semanticModel.GetDeclaredSymbol(exampleClass);

        var generator = new ExtensionGenerator(new(), symbol);

        // Act
        var (fileName, generatedCode) = generator.Build();

        // Assert
        Assert.IsNotNull(fileName);
        Assert.IsNotNull(generatedCode);
        // Burada dönen fileName ve generatedCode'un beklendiği gibi olup olmadığını kontrol edebilirsiniz
    }
}
