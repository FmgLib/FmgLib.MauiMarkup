namespace FmgLib.MauiMarkup;

public static partial class ResourceDictionaryExtension
{
    public static ResourceDictionary AddResource(this ResourceDictionary dic, string key, object value)
    {
        dic.Add(key, value);

        return dic;
    }

    public static ResourceDictionary RemoveResource(this ResourceDictionary dic, string key)
    {
        dic.Remove(key);

        return dic;
    }
}
