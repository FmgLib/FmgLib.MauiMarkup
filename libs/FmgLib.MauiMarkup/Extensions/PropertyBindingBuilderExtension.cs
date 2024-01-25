namespace FmgLib.MauiMarkup;

public static class PropertyBindingBuilderExtension
{
    public static PropertyBindingBuilder<bool> NegateFmg(this PropertyBindingBuilder<bool> self)
    {
        return self.ConvertFmg<bool>(e => !e).ConvertBackFmg<bool>(e => !e);
    }
}
