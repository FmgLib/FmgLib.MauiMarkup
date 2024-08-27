using Microsoft.CodeAnalysis;
using System;
using System.Linq;

namespace FmgLib.MauiMarkup.Generator.Extensions
{
    partial class AttachedFieldInfo
    {
        public INamedTypeSymbol MainSymbol { get; set; }
        public IFieldSymbol FiledSymbol { get; set; }
        public string BindablePropertyName { get; set; }
        public string PropertyName { get; set; }
        public string ReturnTypeName { get; set; }
        public string DeclaringTypeName { get; set; }

        public string propertyName;
        public string propertyTypeName;
        public string camelCaseName;
        public string symbolTypeName;
        public string valueAssignmentString;
        public string dataTemplateAssignmentString;

        public void Build()
        {
            FiledSymbol = MainSymbol.GetMembers(PropertyName).OfType<IFieldSymbol>().FirstOrDefault();
            symbolTypeName = $"{MainSymbol.ToDisplayString()}";
            propertyName = BindablePropertyName.Split(new[] { "." }, StringSplitOptions.None)[^2] + PropertyName.Replace("Property", "");
            propertyTypeName = FiledSymbol.Type.ToDisplayString();
            camelCaseName = Helpers.ToCamelCase(propertyName);
            valueAssignmentString = $@"self.SetValue({BindablePropertyName}, {camelCaseName});";
            dataTemplateAssignmentString = $@"self.SetValue({BindablePropertyName}, new DataTemplate(loadTemplate));";
        }
    }
}
