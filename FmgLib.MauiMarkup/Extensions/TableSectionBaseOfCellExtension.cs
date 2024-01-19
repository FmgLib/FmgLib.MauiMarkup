namespace FmgLib.MauiMarkup;



public static partial class TableSectionBaseOfCellExtension
{
    public static T OnCollectionChangedFmg<T>(this T self, System.Collections.Specialized.NotifyCollectionChangedEventHandler handler)
        where T : TableSectionBase<Cell>
    {
        self.CollectionChanged += handler;
        return self;
    }
    
    public static T OnCollectionChangedFmg<T>(this T self, Action<T> action)
        where T : TableSectionBase<Cell>
    {
        self.CollectionChanged += (o, arg) => action(self);
        return self;
    }
    
}
