namespace FmgLib.MauiMarkup;


public static partial class FileImageSourceExtension
{
    public static FileImageSource FileFmg(this FileImageSource self,
        string file)
    {
        self.SetValue(FileImageSource.FileProperty, file);
        return self;
    }
    
    public static FileImageSource FileFmg(this FileImageSource self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
    {
        var context = new PropertyContext<string>(self, FileImageSource.FileProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<FileImageSource> FileFmg(this SettersContext<FileImageSource> self,
        string file)
    {
        self.XamlSetters.Add(new Setter { Property = FileImageSource.FileProperty, Value = file });
        return self;
    }
    
    public static SettersContext<FileImageSource> FileFmg(this SettersContext<FileImageSource> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, FileImageSource.FileProperty);
        configure(context).Build();
        return self;
    }
    
}