using Microsoft.CodeAnalysis;

namespace FmgLib.MauiMarkup.Generator.Extensions;

public partial class ExtensionGenerator
{
    void GenerateExtensionMethods_ITextAlignment(ISymbol symbol)
    {
        builder.Append($@"

    public static T AlignText<T>(this T self, TextAlignment vertical, TextAlignment horizontal)
        where T : {symbol.ToDisplayString()}
    {{
        self.SetValue({symbol.ToDisplayString()}.VerticalTextAlignmentProperty, vertical);
        self.SetValue({symbol.ToDisplayString()}.HorizontalTextAlignmentProperty, horizontal);
        return self;
    }}

    public static SettersContext<T> AlignText<T>(this SettersContext<T> self, TextAlignment vertical, TextAlignment horizontal)
        where T : {symbol.ToDisplayString()}
    {{
        self.XamlSetters.Add(new Setter {{ Property = {symbol.ToDisplayString()}.VerticalTextAlignmentProperty, Value = vertical }});
        self.XamlSetters.Add(new Setter {{ Property = {symbol.ToDisplayString()}.HorizontalTextAlignmentProperty, Value = horizontal }});
        return self;
    }}

    public static T TextCenterHorizontal<T>(this T self)
        where T : {symbol.ToDisplayString()}
    {{
        self.SetValue({symbol.ToDisplayString()}.HorizontalTextAlignmentProperty, TextAlignment.Center);
        return self;
    }}

    public static SettersContext<T> TextCenterHorizontal<T>(this SettersContext<T> self)
        where T : {symbol.ToDisplayString()}
    {{
        self.XamlSetters.Add(new Setter {{ Property = {symbol.ToDisplayString()}.HorizontalTextAlignmentProperty, Value = TextAlignment.Center }});
        return self;
    }}

    public static T TextCenterVertical<T>(this T self)
        where T : {symbol.ToDisplayString()}
    {{
        self.SetValue({symbol.ToDisplayString()}.VerticalTextAlignmentProperty, TextAlignment.Center);
        return self;
    }}

    public static SettersContext<T> TextCenterVertical<T>(this SettersContext<T> self)
        where T : {symbol.ToDisplayString()}
    {{
        self.XamlSetters.Add(new Setter {{ Property = {symbol.ToDisplayString()}.VerticalTextAlignmentProperty, Value = TextAlignment.Center }});
        return self;
    }}

    public static T TextCenter<T>(this T self)
        where T : {symbol.ToDisplayString()}
    {{
        self.SetValue({symbol.ToDisplayString()}.HorizontalTextAlignmentProperty, TextAlignment.Center);
        self.SetValue({symbol.ToDisplayString()}.VerticalTextAlignmentProperty, TextAlignment.Center);
        return self;
    }}

    public static SettersContext<T> TextCenter<T>(this SettersContext<T> self)
        where T : {symbol.ToDisplayString()}
    {{
        self.XamlSetters.Add(new Setter {{ Property = {symbol.ToDisplayString()}.VerticalTextAlignmentProperty, Value = TextAlignment.Center }});
        self.XamlSetters.Add(new Setter {{ Property = {symbol.ToDisplayString()}.HorizontalTextAlignmentProperty, Value = TextAlignment.Center }});
        return self;
    }}

    public static T TextTop<T>(this T self)
        where T : {symbol.ToDisplayString()}
    {{
        self.SetValue({symbol.ToDisplayString()}.VerticalTextAlignmentProperty, TextAlignment.Start);
        return self;
    }}

    public static SettersContext<T> TextTop<T>(this SettersContext<T> self)
        where T : {symbol.ToDisplayString()}
    {{
        self.XamlSetters.Add(new Setter {{ Property = {symbol.ToDisplayString()}.VerticalTextAlignmentProperty, Value = TextAlignment.Start }});
        return self;
    }}

    public static T TextBottom<T>(this T self)
        where T : {symbol.ToDisplayString()}
    {{
        self.SetValue({symbol.ToDisplayString()}.VerticalTextAlignmentProperty, TextAlignment.End);
        return self;
    }}

    public static SettersContext<T> TextBottom<T>(this SettersContext<T> self)
        where T : {symbol.ToDisplayString()}
    {{
        self.XamlSetters.Add(new Setter {{ Property = {symbol.ToDisplayString()}.VerticalTextAlignmentProperty, Value = TextAlignment.End }});
        return self;
    }}

    public static T TextTopLeft<T>(this T self)
        where T : {symbol.ToDisplayString()}
    {{
        self.SetValue({symbol.ToDisplayString()}.VerticalTextAlignmentProperty, TextAlignment.Start);
        self.SetValue({symbol.ToDisplayString()}.HorizontalTextAlignmentProperty, TextAlignment.Start);
        return self;
    }}

    public static SettersContext<T> TextTopLeft<T>(this SettersContext<T> self)
        where T : {symbol.ToDisplayString()}
    {{
        self.XamlSetters.Add(new Setter {{ Property = {symbol.ToDisplayString()}.VerticalTextAlignmentProperty, Value = TextAlignment.Start }});
        self.XamlSetters.Add(new Setter {{ Property = {symbol.ToDisplayString()}.HorizontalTextAlignmentProperty, Value = TextAlignment.Start }});
        return self;
    }}

    public static T TextBottomLeft<T>(this T self)
        where T : {symbol.ToDisplayString()}
    {{
        self.SetValue({symbol.ToDisplayString()}.VerticalTextAlignmentProperty, TextAlignment.End);
        self.SetValue({symbol.ToDisplayString()}.HorizontalTextAlignmentProperty, TextAlignment.Start);
        return self;
    }}

    public static SettersContext<T> TextBottomLeft<T>(this SettersContext<T> self)
        where T : {symbol.ToDisplayString()}
    {{
        self.XamlSetters.Add(new Setter {{ Property = {symbol.ToDisplayString()}.VerticalTextAlignmentProperty, Value = TextAlignment.End }});
        self.XamlSetters.Add(new Setter {{ Property = {symbol.ToDisplayString()}.HorizontalTextAlignmentProperty, Value = TextAlignment.Start }});
        return self;
    }}

    public static T TextTopCenter<T>(this T self)
        where T : {symbol.ToDisplayString()}
    {{
        self.SetValue({symbol.ToDisplayString()}.VerticalTextAlignmentProperty, TextAlignment.Start);
        self.SetValue({symbol.ToDisplayString()}.HorizontalTextAlignmentProperty, TextAlignment.Center);
        return self;
    }}

    public static SettersContext<T> TextTopCenter<T>(this SettersContext<T> self)
        where T : {symbol.ToDisplayString()}
    {{
        self.XamlSetters.Add(new Setter {{ Property = {symbol.ToDisplayString()}.VerticalTextAlignmentProperty, Value = TextAlignment.Start }});
        self.XamlSetters.Add(new Setter {{ Property = {symbol.ToDisplayString()}.HorizontalTextAlignmentProperty, Value = TextAlignment.Center }});
        return self;
    }}

    public static T TextBottomCenter<T>(this T self)
        where T : {symbol.ToDisplayString()}
    {{
        self.SetValue({symbol.ToDisplayString()}.VerticalTextAlignmentProperty, TextAlignment.End);
        self.SetValue({symbol.ToDisplayString()}.HorizontalTextAlignmentProperty, TextAlignment.Center);
        return self;
    }}

    public static SettersContext<T> TextBottomCenter<T>(this SettersContext<T> self)
        where T : {symbol.ToDisplayString()}
    {{
        self.XamlSetters.Add(new Setter {{ Property = {symbol.ToDisplayString()}.VerticalTextAlignmentProperty, Value = TextAlignment.End }});
        self.XamlSetters.Add(new Setter {{ Property = {symbol.ToDisplayString()}.HorizontalTextAlignmentProperty, Value = TextAlignment.Center }});
        return self;
    }}

    public static T TextCenterRight<T>(this T self)
        where T : {symbol.ToDisplayString()}
    {{
        self.SetValue({symbol.ToDisplayString()}.VerticalTextAlignmentProperty, TextAlignment.Center);
        self.SetValue({symbol.ToDisplayString()}.HorizontalTextAlignmentProperty, TextAlignment.End);
        return self;
    }}

    public static SettersContext<T> TextCenterRight<T>(this SettersContext<T> self)
        where T : {symbol.ToDisplayString()}
    {{
        self.XamlSetters.Add(new Setter {{ Property = {symbol.ToDisplayString()}.VerticalTextAlignmentProperty, Value = TextAlignment.Center }});
        self.XamlSetters.Add(new Setter {{ Property = {symbol.ToDisplayString()}.HorizontalTextAlignmentProperty, Value = TextAlignment.End }});
        return self;
    }}

    public static T TextCenterLeft<T>(this T self)
        where T : {symbol.ToDisplayString()}
    {{
        self.SetValue({symbol.ToDisplayString()}.VerticalTextAlignmentProperty, TextAlignment.Center);
        self.SetValue({symbol.ToDisplayString()}.HorizontalTextAlignmentProperty, TextAlignment.Start);
        return self;
    }}

    public static SettersContext<T> TextCenterLeft<T>(this SettersContext<T> self)
        where T : {symbol.ToDisplayString()}
    {{
        self.XamlSetters.Add(new Setter {{ Property = {symbol.ToDisplayString()}.VerticalTextAlignmentProperty, Value = TextAlignment.Center }});
        self.XamlSetters.Add(new Setter {{ Property = {symbol.ToDisplayString()}.HorizontalTextAlignmentProperty, Value = TextAlignment.Start }});
        return self;
    }}

    public static T TextTopRight<T>(this T self)
        where T : {symbol.ToDisplayString()}
    {{
        self.SetValue({symbol.ToDisplayString()}.VerticalTextAlignmentProperty, TextAlignment.Start);
        self.SetValue({symbol.ToDisplayString()}.HorizontalTextAlignmentProperty, TextAlignment.End);
        return self;
    }}

    public static SettersContext<T> TextTopRight<T>(this SettersContext<T> self)
        where T : {symbol.ToDisplayString()}
    {{
        self.XamlSetters.Add(new Setter {{ Property = {symbol.ToDisplayString()}.VerticalTextAlignmentProperty, Value = TextAlignment.Start }});
        self.XamlSetters.Add(new Setter {{ Property = {symbol.ToDisplayString()}.HorizontalTextAlignmentProperty, Value = TextAlignment.End }});
        return self;
    }}

    public static T TextBottomRight<T>(this T self)
        where T : {symbol.ToDisplayString()}
    {{
        self.SetValue({symbol.ToDisplayString()}.VerticalTextAlignmentProperty, TextAlignment.End);
        self.SetValue({symbol.ToDisplayString()}.HorizontalTextAlignmentProperty, TextAlignment.End);
        return self;
    }}

    public static SettersContext<T> TextBottomRight<T>(this SettersContext<T> self)
        where T : {symbol.ToDisplayString()}
    {{
        self.XamlSetters.Add(new Setter {{ Property = {symbol.ToDisplayString()}.VerticalTextAlignmentProperty, Value = TextAlignment.End }});
        self.XamlSetters.Add(new Setter {{ Property = {symbol.ToDisplayString()}.HorizontalTextAlignmentProperty, Value = TextAlignment.End }});
        return self;
    }}

    public static T TextLeft<T>(this T self)
        where T : {symbol.ToDisplayString()}
    {{
        self.SetValue({symbol.ToDisplayString()}.HorizontalTextAlignmentProperty, TextAlignment.Start);
        return self;
    }}

    public static SettersContext<T> TextLeft<T>(this SettersContext<T> self)
        where T : {symbol.ToDisplayString()}
    {{
        self.XamlSetters.Add(new Setter {{ Property = {symbol.ToDisplayString()}.HorizontalTextAlignmentProperty, Value = TextAlignment.Start }});
        return self;
    }}

    public static T TextRight<T>(this T self)
        where T : {symbol.ToDisplayString()}
    {{
        self.SetValue({symbol.ToDisplayString()}.HorizontalTextAlignmentProperty, TextAlignment.End);
        return self;
    }}

    public static SettersContext<T> TextRight<T>(this SettersContext<T> self)
        where T : {symbol.ToDisplayString()}
    {{
        self.XamlSetters.Add(new Setter {{ Property = {symbol.ToDisplayString()}.HorizontalTextAlignmentProperty, Value = TextAlignment.End }});
        return self;
    }}

    ");
    }
}

