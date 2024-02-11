namespace FmgLib.MauiMarkup;



public static partial class ImageCellExtension
{
    public static T ImageSourceFmg<T>(this T self,
        ImageSource imageSource)
        where T : ImageCell
    {
        self.SetValue(ImageCell.ImageSourceProperty, imageSource);
        return self;
    }
    
    public static T ImageSourceFmg<T>(this T self, Func<PropertyContext<ImageSource>, IPropertyBuilder<ImageSource>> configure)
        where T : ImageCell
    {
        var context = new PropertyContext<ImageSource>(self, ImageCell.ImageSourceProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ImageSourceFmg<T>(this SettersContext<T> self,
        ImageSource imageSource)
        where T : ImageCell
    {
        self.XamlSetters.Add(new Setter { Property = ImageCell.ImageSourceProperty, Value = imageSource });
        return self;
    }
    
    public static SettersContext<T> ImageSourceFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ImageSource>, IPropertySettersBuilder<ImageSource>> configure)
        where T : ImageCell
    {
        var context = new PropertySettersContext<ImageSource>(self.XamlSetters, ImageCell.ImageSourceProperty);
        configure(context).Build();
        return self;
    }
    
}
