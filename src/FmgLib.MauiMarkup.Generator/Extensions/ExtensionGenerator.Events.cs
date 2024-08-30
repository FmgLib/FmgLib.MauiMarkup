using System;
using System.Linq;
using Microsoft.CodeAnalysis;

namespace FmgLib.MauiMarkup.Generator.Extensions;

public partial class ExtensionGenerator
{
    void GenerateEventMethod(ISymbol @event)
    {
        var eventSymbol = (IEventSymbol)@event;
        var eventHandler = eventSymbol.AddMethod.Parameters.First();
        var eventHandlerType = ((INamedTypeSymbol)eventHandler.Type);

        var existInBases = false;
        Helpers.LoopDownToObject(mainSymbol.BaseType, type =>
        {
            existInBases = (type
            .GetMembers()
            .FirstOrDefault(e =>
            e.Kind == SymbolKind.Event &&
            e.DeclaredAccessibility == Accessibility.Public &&
            e.Name.Equals(eventSymbol.Name, StringComparison.Ordinal)) != null);

            return existInBases;
        });

        if (!existInBases && !Helpers.NotGenerateList.Contains(eventSymbol.Name))
        {
            if (mainSymbol.IsSealed)
            {
                GenerateEventMethodHandler_Sealed(eventSymbol);
                GenerateEventMethodNoArgs_Sealed(eventSymbol);
            }
            else
            {
                GenerateEventMethodHandler_Normal(eventSymbol);
                GenerateEventMethodNoArgs_Normal(eventSymbol);
            }
            isGeneratedExtension = true;
        }
    }


    void GenerateEventMethodHandler_Sealed(IEventSymbol eventSymbol)
    {
        builder.Append($@"
    public static {mainSymbol.ToDisplayString()} On{eventSymbol.Name}(this {mainSymbol.ToDisplayString()} self, {((INamedTypeSymbol)eventSymbol.Type).ToDisplayString()} handler)
    {{
        self.{eventSymbol.Name} += handler;
        return self;
    }}
    ");
    }

    void GenerateEventMethodHandler_Normal(IEventSymbol eventSymbol)
    {
        builder.Append($@"
    public static T On{eventSymbol.Name}<T>(this T self, {((INamedTypeSymbol)eventSymbol.Type).ToDisplayString()} handler)
        where T : {mainSymbol.ToDisplayString()}
    {{
        self.{eventSymbol.Name} += handler;
        return self;
    }}
    ");
    }

    void GenerateEventMethodNoArgs_Sealed(IEventSymbol eventSymbol)
    {
        var parameterCount = ((INamedTypeSymbol)eventSymbol.Type).DelegateInvokeMethod.Parameters.Length;
        if (parameterCount <= 2)
            builder.Append($@"
    public static {mainSymbol.ToDisplayString()} On{eventSymbol.Name}(this {mainSymbol.ToDisplayString()} self, System.Action<{mainSymbol.ToDisplayString()}> action)
    {{
        {(parameterCount == 2 ? $"self.{eventSymbol.Name} += (o, arg) => action(self);" : parameterCount == 1 ? $"self.{eventSymbol.Name} += (o) => action(self);" : parameterCount == 0 ? $"self.{eventSymbol.Name} += () => action(self);" : string.Empty)}
        return self;
    }}
        ");
    }

    void GenerateEventMethodNoArgs_Normal(IEventSymbol eventSymbol)
    {
        var parameterCount = ((INamedTypeSymbol)eventSymbol.Type).DelegateInvokeMethod.Parameters.Length;
        if (parameterCount <= 2)
            builder.Append($@"
    public static T On{eventSymbol.Name}<T>(this T self, System.Action<T> action)
        where T : {mainSymbol.ToDisplayString()}
    {{
        {(parameterCount == 2 ? $"self.{eventSymbol.Name} += (o, arg) => action(self);" : parameterCount == 1 ? $"self.{eventSymbol.Name} += (o) => action(self);" : parameterCount == 0 ? $"self.{eventSymbol.Name} += () => action(self);" : string.Empty)}
        return self;
    }}
        ");
    }
}