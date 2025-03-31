namespace FmgLib.MauiMarkup;

public static class TranslatorExtension
{
    public static PropertyBindingBuilder<string, string> Translate(this PropertyContext<string, string> self, string key)
    {
        return new PropertyBindingBuilder<string, string>(self).Compiled(static (parameter) => parameter).Source(Translator.Instance[key]).BindingMode(BindingMode.OneWay);
    }

    public static PropertyBindingBuilder<string, string> TranslateResx(this PropertyContext<string, string> self, string key)
    {
        return new PropertyBindingBuilder<string, string>(self).Compiled(static (parameter) => parameter).Source(TranslatorResx.Instance[key]).BindingMode(BindingMode.OneWay);
    }
}
