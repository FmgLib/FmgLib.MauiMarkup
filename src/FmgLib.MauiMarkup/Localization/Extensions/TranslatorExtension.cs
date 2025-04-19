namespace FmgLib.MauiMarkup;

public static class TranslatorExtension
{
    public static PropertyBindingBuilder<string> Translate(this PropertyContext<string> self, string key)
    {
        return new PropertyBindingBuilder<string>(self).Path($"[{key}]").Source(Translator.Instance).BindingMode(BindingMode.OneWay);
    }

    public static PropertyBindingBuilder<string> TranslateResx(this PropertyContext<string> self, string key)
    {
        return new PropertyBindingBuilder<string>(self).Path($"[{key}]").Source(TranslatorResx.Instance).BindingMode(BindingMode.OneWay);
    }
}
