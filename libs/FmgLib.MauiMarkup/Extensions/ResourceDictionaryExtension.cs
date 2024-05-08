namespace FmgLib.MauiMarkup;

public static partial class ResourceDictionaryExtension
{
    public static ResourceDictionary Add(this ResourceDictionary dic, string key, object value)
    {
        dic.Add(key, value);

        return dic;
    }

    public static ResourceDictionary Remove(this ResourceDictionary dic, string key)
    {
        dic.Remove(key);

        return dic;
    }
}
