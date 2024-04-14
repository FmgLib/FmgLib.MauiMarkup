namespace FmgLib.MauiMarkup;

public static partial class BindingExtension
{
    public static Binding Converter(this Binding self,
        IValueConverter converter)
    {
        self.Converter = converter;
        return self;
    }
    
    public static Binding ConverterParameter(this Binding self,
        object converterParameter)
    {
        self.ConverterParameter = converterParameter;
        return self;
    }
    
    public static Binding Path(this Binding self,
        string path)
    {
        self.Path = path;
        return self;
    }
    
    public static Binding Source(this Binding self,
        object source)
    {
        self.Source = source;
        return self;
    }
    
    public static Binding UpdateSourceEventName(this Binding self,
        string updateSourceEventName)
    {
        self.UpdateSourceEventName = updateSourceEventName;
        return self;
    }
    
}