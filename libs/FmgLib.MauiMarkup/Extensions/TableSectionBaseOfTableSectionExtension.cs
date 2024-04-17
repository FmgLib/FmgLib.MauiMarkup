namespace FmgLib.MauiMarkup;



public static partial class TableSectionBaseOfTableSectionExtension
{
    public static T OnCollectionChanged<T>(this T self, System.Collections.Specialized.NotifyCollectionChangedEventHandler handler)
        where T : TableSectionBase<TableSection>
    {
        self.CollectionChanged += handler;
        return self;
    }
    
    public static T OnCollectionChanged<T>(this T self, Action<T> action)
        where T : TableSectionBase<TableSection>
    {
        self.CollectionChanged += (o, arg) => action(self);
        return self;
    }
    
}
