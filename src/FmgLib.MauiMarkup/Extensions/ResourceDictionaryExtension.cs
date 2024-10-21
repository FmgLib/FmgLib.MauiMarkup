namespace FmgLib.MauiMarkup;

public static partial class ResourceDictionaryExtension
{
    public static T AddResource<T>(this T self, string key, object value) where T : Microsoft.Maui.Controls.ResourceDictionary
    {
        self.Add(key, value);

        return self;
    }

    public static T AddResource<T>(this T self, Style style) where T : Microsoft.Maui.Controls.ResourceDictionary
    {
        self.Add(style);

        return self;
    }

    public static T AddResource<T>(this T self, Microsoft.Maui.Controls.StyleSheets.StyleSheet styleSheet) where T : Microsoft.Maui.Controls.ResourceDictionary
    {
        self.Add(styleSheet);

        return self;
    }

    public static T AddResource<T>(this T self, string strStyleSheet) where T : Microsoft.Maui.Controls.ResourceDictionary
    {
        self.Add(Microsoft.Maui.Controls.StyleSheets.StyleSheet.FromReader(new StringReader(strStyleSheet)));

        return self;
    }

    public static T AddResource<T>(this T self, ResourceDictionary mergedResourceDictionary) where T : Microsoft.Maui.Controls.ResourceDictionary
    {
        self.Add(mergedResourceDictionary);

        return self;
    }

    public static T RemoveResource<T>(this T self, string key) where T : Microsoft.Maui.Controls.ResourceDictionary
    {
        self.Remove(key);

        return self;
    }

    public static T MergedDictionaries<T>(this T self, params ResourceDictionary[] resources) where T : Microsoft.Maui.Controls.ResourceDictionary
    {
        foreach (var resource in resources)
        {
            self.MergedDictionaries.Add(resource);
        }
        return self;
    }

    public static T MergedDictionaries<T>(this T self, IList<ResourceDictionary> resources) where T : Microsoft.Maui.Controls.ResourceDictionary
    {
        foreach (var resource in resources)
        {
            self.MergedDictionaries.Add(resource);
        }
        return self;
    }

    public static T Source<T>(this T self, Uri uri) where T : Microsoft.Maui.Controls.ResourceDictionary
    {
        self.Source = uri;
        return self;
    }

    public static T Source<T>(this T self, string url) where T : Microsoft.Maui.Controls.ResourceDictionary
    {
        self.Source = new Uri(url);
        return self;
    }
}
