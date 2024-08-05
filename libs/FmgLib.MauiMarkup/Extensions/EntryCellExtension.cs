namespace FmgLib.MauiMarkup;

public static partial class EntryCellExtension
{
    public static T HorizontalTextAlignment<T>(this T self,
        TextAlignment horizontalTextAlignment)
        where T : EntryCell
    {
        self.SetValue(EntryCell.HorizontalTextAlignmentProperty, horizontalTextAlignment);
        return self;
    }
    
    public static T HorizontalTextAlignment<T>(this T self, Func<PropertyContext<TextAlignment>, IPropertyBuilder<TextAlignment>> configure)
        where T : EntryCell
    {
        var context = new PropertyContext<TextAlignment>(self, EntryCell.HorizontalTextAlignmentProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> HorizontalTextAlignment<T>(this SettersContext<T> self,
        TextAlignment horizontalTextAlignment)
        where T : EntryCell
    {
        self.XamlSetters.Add(new Setter { Property = EntryCell.HorizontalTextAlignmentProperty, Value = horizontalTextAlignment });
        return self;
    }
    
    public static SettersContext<T> HorizontalTextAlignment<T>(this SettersContext<T> self, Func<PropertySettersContext<TextAlignment>, IPropertySettersBuilder<TextAlignment>> configure)
        where T : EntryCell
    {
        var context = new PropertySettersContext<TextAlignment>(self.XamlSetters, EntryCell.HorizontalTextAlignmentProperty);
        configure(context).Build();
        return self;
    }
    
    public static T VerticalTextAlignment<T>(this T self,
        TextAlignment verticalTextAlignment)
        where T : EntryCell
    {
        self.SetValue(EntryCell.VerticalTextAlignmentProperty, verticalTextAlignment);
        return self;
    }
    
    public static T VerticalTextAlignment<T>(this T self, Func<PropertyContext<TextAlignment>, IPropertyBuilder<TextAlignment>> configure)
        where T : EntryCell
    {
        var context = new PropertyContext<TextAlignment>(self, EntryCell.VerticalTextAlignmentProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> VerticalTextAlignment<T>(this SettersContext<T> self,
        TextAlignment verticalTextAlignment)
        where T : EntryCell
    {
        self.XamlSetters.Add(new Setter { Property = EntryCell.VerticalTextAlignmentProperty, Value = verticalTextAlignment });
        return self;
    }
    
    public static SettersContext<T> VerticalTextAlignment<T>(this SettersContext<T> self, Func<PropertySettersContext<TextAlignment>, IPropertySettersBuilder<TextAlignment>> configure)
        where T : EntryCell
    {
        var context = new PropertySettersContext<TextAlignment>(self.XamlSetters, EntryCell.VerticalTextAlignmentProperty);
        configure(context).Build();
        return self;
    }
    
    public static T Keyboard<T>(this T self,
        Microsoft.Maui.Keyboard keyboard)
        where T : EntryCell
    {
        self.SetValue(EntryCell.KeyboardProperty, keyboard);
        return self;
    }
    
    public static T Keyboard<T>(this T self,
        Func<Microsoft.Maui.Keyboard> configure)
        where T : EntryCell
    {
        var keyboard = configure();
        self.SetValue(EntryCell.KeyboardProperty, keyboard);
        return self;
    }
    
    public static T Keyboard<T>(this T self, Func<PropertyContext<Microsoft.Maui.Keyboard>, IPropertyBuilder<Microsoft.Maui.Keyboard>> configure)
        where T : EntryCell
    {
        var context = new PropertyContext<Microsoft.Maui.Keyboard>(self, EntryCell.KeyboardProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Keyboard<T>(this SettersContext<T> self,
        Microsoft.Maui.Keyboard keyboard)
        where T : EntryCell
    {
        self.XamlSetters.Add(new Setter { Property = EntryCell.KeyboardProperty, Value = keyboard });
        return self;
    }
    
    public static SettersContext<T> Keyboard<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Keyboard>, IPropertySettersBuilder<Microsoft.Maui.Keyboard>> configure)
        where T : EntryCell
    {
        var context = new PropertySettersContext<Microsoft.Maui.Keyboard>(self.XamlSetters, EntryCell.KeyboardProperty);
        configure(context).Build();
        return self;
    }
    
    public static T Label<T>(this T self,
        string label)
        where T : EntryCell
    {
        self.SetValue(EntryCell.LabelProperty, label);
        return self;
    }
    
    public static T Label<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : EntryCell
    {
        var context = new PropertyContext<string>(self, EntryCell.LabelProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Label<T>(this SettersContext<T> self,
        string label)
        where T : EntryCell
    {
        self.XamlSetters.Add(new Setter { Property = EntryCell.LabelProperty, Value = label });
        return self;
    }
    
    public static SettersContext<T> Label<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : EntryCell
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, EntryCell.LabelProperty);
        configure(context).Build();
        return self;
    }
    
    public static T LabelColor<T>(this T self,
        Color labelColor)
        where T : EntryCell
    {
        self.SetValue(EntryCell.LabelColorProperty, labelColor);
        return self;
    }
    
    public static T LabelColor<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : EntryCell
    {
        var context = new PropertyContext<Color>(self, EntryCell.LabelColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> LabelColor<T>(this SettersContext<T> self,
        Color labelColor)
        where T : EntryCell
    {
        self.XamlSetters.Add(new Setter { Property = EntryCell.LabelColorProperty, Value = labelColor });
        return self;
    }
    
    public static SettersContext<T> LabelColor<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : EntryCell
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, EntryCell.LabelColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static T Placeholder<T>(this T self,
        string placeholder)
        where T : EntryCell
    {
        self.SetValue(EntryCell.PlaceholderProperty, placeholder);
        return self;
    }
    
    public static T Placeholder<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : EntryCell
    {
        var context = new PropertyContext<string>(self, EntryCell.PlaceholderProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Placeholder<T>(this SettersContext<T> self,
        string placeholder)
        where T : EntryCell
    {
        self.XamlSetters.Add(new Setter { Property = EntryCell.PlaceholderProperty, Value = placeholder });
        return self;
    }
    
    public static SettersContext<T> Placeholder<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : EntryCell
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, EntryCell.PlaceholderProperty);
        configure(context).Build();
        return self;
    }
    
    public static T Text<T>(this T self,
        string text)
        where T : EntryCell
    {
        self.SetValue(EntryCell.TextProperty, text);
        return self;
    }
    
    public static T Text<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : EntryCell
    {
        var context = new PropertyContext<string>(self, EntryCell.TextProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Text<T>(this SettersContext<T> self,
        string text)
        where T : EntryCell
    {
        self.XamlSetters.Add(new Setter { Property = EntryCell.TextProperty, Value = text });
        return self;
    }
    
    public static SettersContext<T> Text<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : EntryCell
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, EntryCell.TextProperty);
        configure(context).Build();
        return self;
    }
    
    public static T OnCompleted<T>(this T self, EventHandler handler)
        where T : EntryCell
    {
        self.Completed += handler;
        return self;
    }
    
    public static T OnCompleted<T>(this T self, Action<T> action)
        where T : EntryCell
    {
        self.Completed += (o, arg) => action(self);
        return self;
    }


    public static T AlignText<T>(this T self, TextAlignment vertical, TextAlignment horizontal)
        where T : EntryCell
    {
        self.SetValue(EntryCell.VerticalTextAlignmentProperty, vertical);
        self.SetValue(EntryCell.HorizontalTextAlignmentProperty, horizontal);
        return self;
    }

    public static SettersContext<T> AlignText<T>(this SettersContext<T> self, TextAlignment vertical, TextAlignment horizontal)
        where T : EntryCell
    {
        self.XamlSetters.Add(new Setter { Property = EntryCell.VerticalTextAlignmentProperty, Value = vertical });
        self.XamlSetters.Add(new Setter { Property = EntryCell.HorizontalTextAlignmentProperty, Value = horizontal });
        return self;
    }

    public static T TextCenterHorizontal<T>(this T self)
        where T : EntryCell
    {
        self.SetValue(EntryCell.HorizontalTextAlignmentProperty, TextAlignment.Center);
        return self;
    }

    public static SettersContext<T> TextCenterHorizontal<T>(this SettersContext<T> self)
        where T : EntryCell
    {
        self.XamlSetters.Add(new Setter { Property = EntryCell.HorizontalTextAlignmentProperty, Value = TextAlignment.Center });
        return self;
    }

    public static T TextCenterVertical<T>(this T self)
        where T : EntryCell
    {
        self.SetValue(EntryCell.VerticalTextAlignmentProperty, TextAlignment.Center);
        return self;
    }

    public static SettersContext<T> TextCenterVertical<T>(this SettersContext<T> self)
        where T : EntryCell
    {
        self.XamlSetters.Add(new Setter { Property = EntryCell.VerticalTextAlignmentProperty, Value = TextAlignment.Center });
        return self;
    }

    public static T TextCenter<T>(this T self)
        where T : EntryCell
    {
        self.SetValue(EntryCell.HorizontalTextAlignmentProperty, TextAlignment.Center);
        self.SetValue(EntryCell.VerticalTextAlignmentProperty, TextAlignment.Center);
        return self;
    }

    public static SettersContext<T> TextCenter<T>(this SettersContext<T> self)
        where T : EntryCell
    {
        self.XamlSetters.Add(new Setter { Property = EntryCell.VerticalTextAlignmentProperty, Value = TextAlignment.Center });
        self.XamlSetters.Add(new Setter { Property = EntryCell.HorizontalTextAlignmentProperty, Value = TextAlignment.Center });
        return self;
    }

    public static T TextTop<T>(this T self)
        where T : EntryCell
    {
        self.SetValue(EntryCell.VerticalTextAlignmentProperty, TextAlignment.Start);
        return self;
    }

    public static SettersContext<T> TextTop<T>(this SettersContext<T> self)
        where T : EntryCell
    {
        self.XamlSetters.Add(new Setter { Property = EntryCell.VerticalTextAlignmentProperty, Value = TextAlignment.Start });
        return self;
    }

    public static T TextBottom<T>(this T self)
        where T : EntryCell
    {
        self.SetValue(EntryCell.VerticalTextAlignmentProperty, TextAlignment.End);
        return self;
    }

    public static SettersContext<T> TextBottom<T>(this SettersContext<T> self)
        where T : EntryCell
    {
        self.XamlSetters.Add(new Setter { Property = EntryCell.VerticalTextAlignmentProperty, Value = TextAlignment.End });
        return self;
    }

    public static T TextTopLeft<T>(this T self)
        where T : EntryCell
    {
        self.SetValue(EntryCell.VerticalTextAlignmentProperty, TextAlignment.Start);
        self.SetValue(EntryCell.HorizontalTextAlignmentProperty, TextAlignment.Start);
        return self;
    }

    public static SettersContext<T> TextTopLeft<T>(this SettersContext<T> self)
        where T : EntryCell
    {
        self.XamlSetters.Add(new Setter { Property = EntryCell.VerticalTextAlignmentProperty, Value = TextAlignment.Start });
        self.XamlSetters.Add(new Setter { Property = EntryCell.HorizontalTextAlignmentProperty, Value = TextAlignment.Start });
        return self;
    }

    public static T TextBottomLeft<T>(this T self)
        where T : EntryCell
    {
        self.SetValue(EntryCell.VerticalTextAlignmentProperty, TextAlignment.End);
        self.SetValue(EntryCell.HorizontalTextAlignmentProperty, TextAlignment.Start);
        return self;
    }

    public static SettersContext<T> TextBottomLeft<T>(this SettersContext<T> self)
        where T : EntryCell
    {
        self.XamlSetters.Add(new Setter { Property = EntryCell.VerticalTextAlignmentProperty, Value = TextAlignment.End });
        self.XamlSetters.Add(new Setter { Property = EntryCell.HorizontalTextAlignmentProperty, Value = TextAlignment.Start });
        return self;
    }

    public static T TextTopCenter<T>(this T self)
        where T : EntryCell
    {
        self.SetValue(EntryCell.VerticalTextAlignmentProperty, TextAlignment.Start);
        self.SetValue(EntryCell.HorizontalTextAlignmentProperty, TextAlignment.Center);
        return self;
    }

    public static SettersContext<T> TextTopCenter<T>(this SettersContext<T> self)
        where T : EntryCell
    {
        self.XamlSetters.Add(new Setter { Property = EntryCell.VerticalTextAlignmentProperty, Value = TextAlignment.Start });
        self.XamlSetters.Add(new Setter { Property = EntryCell.HorizontalTextAlignmentProperty, Value = TextAlignment.Center });
        return self;
    }

    public static T TextBottomCenter<T>(this T self)
        where T : EntryCell
    {
        self.SetValue(EntryCell.VerticalTextAlignmentProperty, TextAlignment.End);
        self.SetValue(EntryCell.HorizontalTextAlignmentProperty, TextAlignment.Center);
        return self;
    }

    public static SettersContext<T> TextBottomCenter<T>(this SettersContext<T> self)
        where T : EntryCell
    {
        self.XamlSetters.Add(new Setter { Property = EntryCell.VerticalTextAlignmentProperty, Value = TextAlignment.End });
        self.XamlSetters.Add(new Setter { Property = EntryCell.HorizontalTextAlignmentProperty, Value = TextAlignment.Center });
        return self;
    }

    public static T TextCenterRight<T>(this T self)
        where T : EntryCell
    {
        self.SetValue(EntryCell.VerticalTextAlignmentProperty, TextAlignment.Center);
        self.SetValue(EntryCell.HorizontalTextAlignmentProperty, TextAlignment.End);
        return self;
    }

    public static SettersContext<T> TextCenterRight<T>(this SettersContext<T> self)
        where T : EntryCell
    {
        self.XamlSetters.Add(new Setter { Property = EntryCell.VerticalTextAlignmentProperty, Value = TextAlignment.Center });
        self.XamlSetters.Add(new Setter { Property = EntryCell.HorizontalTextAlignmentProperty, Value = TextAlignment.End });
        return self;
    }

    public static T TextCenterLeft<T>(this T self)
        where T : EntryCell
    {
        self.SetValue(EntryCell.VerticalTextAlignmentProperty, TextAlignment.Center);
        self.SetValue(EntryCell.HorizontalTextAlignmentProperty, TextAlignment.Start);
        return self;
    }

    public static SettersContext<T> TextCenterLeft<T>(this SettersContext<T> self)
        where T : EntryCell
    {
        self.XamlSetters.Add(new Setter { Property = EntryCell.VerticalTextAlignmentProperty, Value = TextAlignment.Center });
        self.XamlSetters.Add(new Setter { Property = EntryCell.HorizontalTextAlignmentProperty, Value = TextAlignment.Start });
        return self;
    }

    public static T TextTopRight<T>(this T self)
        where T : EntryCell
    {
        self.SetValue(EntryCell.VerticalTextAlignmentProperty, TextAlignment.Start);
        self.SetValue(EntryCell.HorizontalTextAlignmentProperty, TextAlignment.End);
        return self;
    }

    public static SettersContext<T> TextTopRight<T>(this SettersContext<T> self)
        where T : EntryCell
    {
        self.XamlSetters.Add(new Setter { Property = EntryCell.VerticalTextAlignmentProperty, Value = TextAlignment.Start });
        self.XamlSetters.Add(new Setter { Property = EntryCell.HorizontalTextAlignmentProperty, Value = TextAlignment.End });
        return self;
    }

    public static T TextBottomRight<T>(this T self)
        where T : EntryCell
    {
        self.SetValue(EntryCell.VerticalTextAlignmentProperty, TextAlignment.End);
        self.SetValue(EntryCell.HorizontalTextAlignmentProperty, TextAlignment.End);
        return self;
    }

    public static SettersContext<T> TextBottomRight<T>(this SettersContext<T> self)
        where T : EntryCell
    {
        self.XamlSetters.Add(new Setter { Property = EntryCell.VerticalTextAlignmentProperty, Value = TextAlignment.End });
        self.XamlSetters.Add(new Setter { Property = EntryCell.HorizontalTextAlignmentProperty, Value = TextAlignment.End });
        return self;
    }

    public static T TextLeft<T>(this T self)
        where T : EntryCell
    {
        self.SetValue(EntryCell.HorizontalTextAlignmentProperty, TextAlignment.Start);
        return self;
    }

    public static SettersContext<T> TextLeft<T>(this SettersContext<T> self)
        where T : EntryCell
    {
        self.XamlSetters.Add(new Setter { Property = EntryCell.HorizontalTextAlignmentProperty, Value = TextAlignment.Start });
        return self;
    }

    public static T TextRight<T>(this T self)
        where T : EntryCell
    {
        self.SetValue(EntryCell.HorizontalTextAlignmentProperty, TextAlignment.End);
        return self;
    }

    public static SettersContext<T> TextRight<T>(this SettersContext<T> self)
        where T : EntryCell
    {
        self.XamlSetters.Add(new Setter { Property = EntryCell.HorizontalTextAlignmentProperty, Value = TextAlignment.End });
        return self;
    }
}