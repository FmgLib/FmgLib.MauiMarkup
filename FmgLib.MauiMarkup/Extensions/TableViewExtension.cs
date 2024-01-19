namespace FmgLib.MauiMarkup;



public static partial class TableViewExtension
{
    public static T HasUnevenRowsFmg<T>(this T self,
        bool hasUnevenRows)
        where T : TableView
    {
        self.SetValue(TableView.HasUnevenRowsProperty, hasUnevenRows);
        return self;
    }
    
    public static T HasUnevenRowsFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : TableView
    {
        var context = new PropertyContext<bool>(self, TableView.HasUnevenRowsProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> HasUnevenRowsFmg<T>(this SettersContext<T> self,
        bool hasUnevenRows)
        where T : TableView
    {
        self.XamlSetters.Add(new Setter { Property = TableView.HasUnevenRowsProperty, Value = hasUnevenRows });
        return self;
    }
    
    public static SettersContext<T> HasUnevenRowsFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : TableView
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, TableView.HasUnevenRowsProperty);
        configure(context).Build();
        return self;
    }
    
    public static T IntentFmg<T>(this T self,
        TableIntent intent)
        where T : TableView
    {
        self.Intent = intent;
        return self;
    }
    
    public static T RootFmg<T>(this T self,
        IList<TableSection> root)
        where T : TableView
    {
        foreach (var item in root)
            self.Root.Add(item);
        return self;
    }

    public static T RootFmg<T>(this T self,
        params TableSection[] root)
        where T : TableView
    {
        foreach (var item in root)
            self.Root.Add(item);
        return self;
    }
    
    public static T RowHeightFmg<T>(this T self,
        int rowHeight)
        where T : TableView
    {
        self.SetValue(TableView.RowHeightProperty, rowHeight);
        return self;
    }
    
    public static T RowHeightFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
        where T : TableView
    {
        var context = new PropertyContext<int>(self, TableView.RowHeightProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> RowHeightFmg<T>(this SettersContext<T> self,
        int rowHeight)
        where T : TableView
    {
        self.XamlSetters.Add(new Setter { Property = TableView.RowHeightProperty, Value = rowHeight });
        return self;
    }
    
    public static SettersContext<T> RowHeightFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure)
        where T : TableView
    {
        var context = new PropertySettersContext<int>(self.XamlSetters, TableView.RowHeightProperty);
        configure(context).Build();
        return self;
    }
    
    public static T ModelFmg<T>(this T self,
        Microsoft.Maui.Controls.Internals.TableModel model)
        where T : TableView
    {
        self.Model = model;
        return self;
    }
    
    public static T OnModelChangedFmg<T>(this T self, EventHandler handler)
        where T : TableView
    {
        self.ModelChanged += handler;
        return self;
    }
    
    public static T OnModelChangedFmg<T>(this T self, Action<T> action)
        where T : TableView
    {
        self.ModelChanged += (o, arg) => action(self);
        return self;
    }
    
}
