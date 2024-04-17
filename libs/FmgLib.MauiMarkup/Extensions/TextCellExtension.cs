namespace FmgLib.MauiMarkup;



public static partial class TextCellExtension
{
    public static T Command<T>(this T self,
        System.Windows.Input.ICommand command)
        where T : TextCell
    {
        self.SetValue(TextCell.CommandProperty, command);
        return self;
    }
    
    public static T Command<T>(this T self, Func<PropertyContext<System.Windows.Input.ICommand>, IPropertyBuilder<System.Windows.Input.ICommand>> configure)
        where T : TextCell
    {
        var context = new PropertyContext<System.Windows.Input.ICommand>(self, TextCell.CommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Command<T>(this SettersContext<T> self,
        System.Windows.Input.ICommand command)
        where T : TextCell
    {
        self.XamlSetters.Add(new Setter { Property = TextCell.CommandProperty, Value = command });
        return self;
    }
    
    public static SettersContext<T> Command<T>(this SettersContext<T> self, Func<PropertySettersContext<System.Windows.Input.ICommand>, IPropertySettersBuilder<System.Windows.Input.ICommand>> configure)
        where T : TextCell
    {
        var context = new PropertySettersContext<System.Windows.Input.ICommand>(self.XamlSetters, TextCell.CommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static T CommandParameter<T>(this T self,
        object commandParameter)
        where T : TextCell
    {
        self.SetValue(TextCell.CommandParameterProperty, commandParameter);
        return self;
    }
    
    public static T CommandParameter<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        where T : TextCell
    {
        var context = new PropertyContext<object>(self, TextCell.CommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> CommandParameter<T>(this SettersContext<T> self,
        object commandParameter)
        where T : TextCell
    {
        self.XamlSetters.Add(new Setter { Property = TextCell.CommandParameterProperty, Value = commandParameter });
        return self;
    }
    
    public static SettersContext<T> CommandParameter<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        where T : TextCell
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, TextCell.CommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static T Detail<T>(this T self,
        string detail)
        where T : TextCell
    {
        self.SetValue(TextCell.DetailProperty, detail);
        return self;
    }
    
    public static T Detail<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : TextCell
    {
        var context = new PropertyContext<string>(self, TextCell.DetailProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Detail<T>(this SettersContext<T> self,
        string detail)
        where T : TextCell
    {
        self.XamlSetters.Add(new Setter { Property = TextCell.DetailProperty, Value = detail });
        return self;
    }
    
    public static SettersContext<T> Detail<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : TextCell
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, TextCell.DetailProperty);
        configure(context).Build();
        return self;
    }
    
    public static T DetailColor<T>(this T self,
        Color detailColor)
        where T : TextCell
    {
        self.SetValue(TextCell.DetailColorProperty, detailColor);
        return self;
    }
    
    public static T DetailColor<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : TextCell
    {
        var context = new PropertyContext<Color>(self, TextCell.DetailColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> DetailColor<T>(this SettersContext<T> self,
        Color detailColor)
        where T : TextCell
    {
        self.XamlSetters.Add(new Setter { Property = TextCell.DetailColorProperty, Value = detailColor });
        return self;
    }
    
    public static SettersContext<T> DetailColor<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : TextCell
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, TextCell.DetailColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static T Text<T>(this T self,
        string text)
        where T : TextCell
    {
        self.SetValue(TextCell.TextProperty, text);
        return self;
    }
    
    public static T Text<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : TextCell
    {
        var context = new PropertyContext<string>(self, TextCell.TextProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Text<T>(this SettersContext<T> self,
        string text)
        where T : TextCell
    {
        self.XamlSetters.Add(new Setter { Property = TextCell.TextProperty, Value = text });
        return self;
    }
    
    public static SettersContext<T> Text<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : TextCell
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, TextCell.TextProperty);
        configure(context).Build();
        return self;
    }
    
    public static T TextColor<T>(this T self,
        Color textColor)
        where T : TextCell
    {
        self.SetValue(TextCell.TextColorProperty, textColor);
        return self;
    }
    
    public static T TextColor<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : TextCell
    {
        var context = new PropertyContext<Color>(self, TextCell.TextColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> TextColor<T>(this SettersContext<T> self,
        Color textColor)
        where T : TextCell
    {
        self.XamlSetters.Add(new Setter { Property = TextCell.TextColorProperty, Value = textColor });
        return self;
    }
    
    public static SettersContext<T> TextColor<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : TextCell
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, TextCell.TextColorProperty);
        configure(context).Build();
        return self;
    }
    
}
