namespace FmgLib.MauiMarkup.Generator.Extensions;

public partial class ExtensionGenerator
{
    void GenerateExtensionMethod_ContentProp_Single(PropInfo info)
    {
        builder.Append($@"
    public static T {info.propertyName}_ContentProp<T>(this T self,
        {info.propertyTypeName} {info.camelCaseName})
        where T : {info.MainSymbolName}
    {{
        self.{info.propertyName} = {info.camelCaseName};
        return self;
    }}

    public static T {info.propertyName}_ContentProp<T>(this T self,
        Func<{info.propertyTypeName}> configure)
        where T : {info.MainSymbolName}
    {{
        var {info.camelCaseName} = configure();
        self.{info.propertyName} = {info.camelCaseName};
        return self;
    }}
    ");
    }

    void GenerateExtensionMethod_ContentProp_List(PropInfo info, string elementTypeName, string fluentMethodName = "")
    {
        var tail = info.propertyTypeName.EndsWith("?") ? "?" : "";
        builder.Append($@"
    public static T {(string.IsNullOrEmpty(fluentMethodName) ? info.propertyName : fluentMethodName)}<T>(this T self,
        IList<{elementTypeName}> {info.camelCaseName})
        where T : {info.MainSymbolName}
    {{
        foreach (var item in {info.camelCaseName})
            self.{info.propertyName}{tail}.Add(item);
        return self;
    }}

    public static T {(string.IsNullOrEmpty(fluentMethodName) ? info.propertyName : fluentMethodName)}<T>(this T self,
        params {elementTypeName}[] {info.camelCaseName})
        where T : {info.MainSymbolName}
    {{
        foreach (var item in {info.camelCaseName})
            self.{info.propertyName}{tail}.Add(item);
        return self;
    }}

    public static T {(string.IsNullOrEmpty(fluentMethodName) ? info.propertyName : fluentMethodName)}<T>(this T self,
        Func<{elementTypeName}[]> configure)
        where T : {info.MainSymbolName}
    {{
        var {info.camelCaseName} = configure();
        foreach (var item in {info.camelCaseName})
            self.{info.propertyName}{tail}.Add(item);
        return self;
    }}
    ");
    }
}
