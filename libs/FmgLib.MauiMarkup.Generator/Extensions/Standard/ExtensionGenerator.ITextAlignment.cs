﻿//
// MIT License
// Copyright Pawel Krzywdzinski
//

using Microsoft.CodeAnalysis;

namespace FmgLib.MauiMarkup.Generator.Extensions
{
    public partial class ExtensionGenerator
    {
        void GenerateExtensionMethods_ITextAlignment(ISymbol symbol)
        {
            builder.Append($@"

        public static T TextCenterHorizontal<T>(this T self)
            where T : {symbol.ToDisplayString()}
        {{
            self.SetValue({symbol.ToDisplayString()}.HorizontalTextAlignmentProperty, TextAlignment.Center);
            return self;
        }}

        public static T TextCenterVertical<T>(this T self)
            where T : {symbol.ToDisplayString()}
        {{
            self.SetValue({symbol.ToDisplayString()}.VerticalTextAlignmentProperty, TextAlignment.Center);
            return self;
        }}

        public static T TextCenter<T>(this T self)
            where T : {symbol.ToDisplayString()}
        {{
            self.SetValue({symbol.ToDisplayString()}.HorizontalTextAlignmentProperty, TextAlignment.Center);
            self.SetValue({symbol.ToDisplayString()}.VerticalTextAlignmentProperty, TextAlignment.Center);
            return self;
        }}

        public static T TextTop<T>(this T self)
            where T : {symbol.ToDisplayString()}
        {{
            self.SetValue({symbol.ToDisplayString()}.VerticalTextAlignmentProperty, TextAlignment.Start);
            return self;
        }}

        public static T TextBottom<T>(this T self)
            where T : {symbol.ToDisplayString()}, Microsoft.Maui.ITextAlignment
        {{
            self.SetValue({symbol.ToDisplayString()}.VerticalTextAlignmentProperty, TextAlignment.End);
            return self;
        }}

        public static T TextTopStart<T>(this T self)
            where T : {symbol.ToDisplayString()}
        {{
            self.SetValue({symbol.ToDisplayString()}.VerticalTextAlignmentProperty, TextAlignment.Start);
            self.SetValue({symbol.ToDisplayString()}.HorizontalTextAlignmentProperty, TextAlignment.Start);
            return self;
        }}

        public static T TextBottomStart<T>(this T self)
            where T : {symbol.ToDisplayString()}
        {{
            self.SetValue({symbol.ToDisplayString()}.VerticalTextAlignmentProperty, TextAlignment.End);
            self.SetValue({symbol.ToDisplayString()}.HorizontalTextAlignmentProperty, TextAlignment.Start);
            return self;
        }}

        public static T TextTopEnd<T>(this T self)
            where T : {symbol.ToDisplayString()}
        {{
            self.SetValue({symbol.ToDisplayString()}.VerticalTextAlignmentProperty, TextAlignment.Start);
            self.SetValue({symbol.ToDisplayString()}.HorizontalTextAlignmentProperty, TextAlignment.End);
            return self;
        }}

        public static T TextBottomEnd<T>(this T self)
            where T : {symbol.ToDisplayString()}
        {{
            self.SetValue({symbol.ToDisplayString()}.VerticalTextAlignmentProperty, TextAlignment.End);
            self.SetValue({symbol.ToDisplayString()}.HorizontalTextAlignmentProperty, TextAlignment.End);
            return self;
        }}

        public static T TextStart<T>(this T self)
            where T : {symbol.ToDisplayString()}
        {{
            self.SetValue({symbol.ToDisplayString()}.HorizontalTextAlignmentProperty, TextAlignment.Start);
            return self;
        }}

        public static T TextEnd<T>(this T self)
            where T : {symbol.ToDisplayString()}
        {{
            self.SetValue({symbol.ToDisplayString()}.HorizontalTextAlignmentProperty, TextAlignment.End);
            return self;
        }}

        ");
        }
    }
}

