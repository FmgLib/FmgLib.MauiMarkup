using Microsoft.CodeAnalysis;
using System;
using System.Linq;

namespace FmgLib.MauiMarkup;

public class PropInfo
{
    public string MainSymbolName { get; set; }
    public IPropertySymbol PropertySymbol { get; set; }
    public bool IsBindableProperty { get; set; }
    public string BindablePropertyName { get; set; }

    public string propertyName;
    public string propertyTypeName;
    public string accessedWith;
    public string camelCaseName;
    public string valueAssignmentString;
    public string dataTemplateAssignmentString;

    public void Build()
    {
        propertyName = PropertySymbol.Name.Split(new[] { "." }, StringSplitOptions.None).Last();
        propertyName = propertyName.Equals("class", StringComparison.Ordinal) ? "@class" : propertyName;
        accessedWith = PropertySymbol.IsStatic ? MainSymbolName : "self";

        if (IsBindableProperty && BindablePropertyName == null)
        {
            BindablePropertyName = $"{MainSymbolName}.{propertyName}";
        }

        camelCaseName = Helpers.ToCamelCase(propertyName);
        propertyTypeName = PropertySymbol.Type.ToDisplayString();

        valueAssignmentString = IsBindableProperty ?
            $@"self.SetValue({BindablePropertyName}, {camelCaseName});" :
            $"{accessedWith}.{propertyName} = {camelCaseName};";

        dataTemplateAssignmentString = IsBindableProperty ?
            $@"self.SetValue({BindablePropertyName}, new DataTemplate(loadTemplate));" :
            $@"{accessedWith}.{propertyName} = new DataTemplate(loadTemplate);";

    }
}
