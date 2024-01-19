namespace FmgLib.MauiMarkup;

public static partial class BindingExtension
{
    public static Binding ConverterFmg(this Binding self,
        IValueConverter converter)
    {
        self.Converter = converter;
        return self;
    }
    
    public static Binding ConverterParameterFmg(this Binding self,
        object converterParameter)
    {
        self.ConverterParameter = converterParameter;
        return self;
    }
    
    public static Binding PathFmg(this Binding self,
        string path)
    {
        self.Path = path;
        return self;
    }
    
    public static Binding SourceFmg(this Binding self,
        object source)
    {
        self.Source = source;
        return self;
    }
    
    public static Binding UpdateSourceEventNameFmg(this Binding self,
        string updateSourceEventName)
    {
        self.UpdateSourceEventName = updateSourceEventName;
        return self;
    }
    
}