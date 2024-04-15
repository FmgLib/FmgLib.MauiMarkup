namespace FmgLib.MauiMarkup.Generator.Extensions
{
    public partial class ExtensionGenerator
    {
        void GenerateExtensionMethod_Value(PropertyInfo info)
        {
            if (mainSymbol.IsSealed)
                GenerateExtensionMethod_Value_Sealed(info);
            else
                GenerateExtensionMethod_Value_Normal(info);
        }

        void GenerateExtensionMethod_Value_Sealed(PropertyInfo info)
        {
            builder.Append($@"
        public static {info.symbolTypeName} {info.propertyName}(this {info.symbolTypeName} self,
            {info.propertyTypeName} {info.camelCaseName})
        {{
            {info.valueAssignmentString}
            return self;
        }}
        ");
        }

        void GenerateExtensionMethod_Value_Normal(PropertyInfo info)
        {
            builder.Append($@"
        public static T {info.propertyName}<T>(this T self,
            {info.propertyTypeName} {info.camelCaseName})
            where T : {info.symbolTypeName}
        {{
            {info.valueAssignmentString}
            return self;
        }}
        ");
        }
    }
}