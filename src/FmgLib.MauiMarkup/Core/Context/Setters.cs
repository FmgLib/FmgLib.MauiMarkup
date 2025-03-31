namespace FmgLib.MauiMarkup;

public class Setters<TSource> : List<Setter> where TSource : BindableObject
	{
    public Setters(Func<SettersContext<TSource>, SettersContext<TSource>> buildSetters)
    {
        var settersContext = new SettersContext<TSource>();
        buildSetters(settersContext);
        foreach (var setter in settersContext.XamlSetters)
            this.Add(setter);
    }
}