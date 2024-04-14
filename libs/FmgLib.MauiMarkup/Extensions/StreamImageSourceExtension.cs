namespace FmgLib.MauiMarkup;



public static partial class StreamImageSourceExtension
{
    public static T Stream<T>(this T self,
        Func<CancellationToken, Task<Stream>> stream)
        where T : StreamImageSource
    {
        self.SetValue(StreamImageSource.StreamProperty, stream);
        return self;
    }
    
    public static T Stream<T>(this T self, Func<PropertyContext<Func<CancellationToken, Task<Stream>>>, IPropertyBuilder<Func<CancellationToken, Task<Stream>>>> configure)
        where T : StreamImageSource
    {
        var context = new PropertyContext<Func<CancellationToken, Task<Stream>>>(self, StreamImageSource.StreamProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Stream<T>(this SettersContext<T> self,
        Func<CancellationToken, Task<Stream>> stream)
        where T : StreamImageSource
    {
        self.XamlSetters.Add(new Setter { Property = StreamImageSource.StreamProperty, Value = stream });
        return self;
    }
    
    public static SettersContext<T> Stream<T>(this SettersContext<T> self, Func<PropertySettersContext<Func<CancellationToken, Task<Stream>>>, IPropertySettersBuilder<Func<CancellationToken, Task<Stream>>>> configure)
        where T : StreamImageSource
    {
        var context = new PropertySettersContext<Func<CancellationToken, Task<Stream>>>(self.XamlSetters, StreamImageSource.StreamProperty);
        configure(context).Build();
        return self;
    }
    
}
