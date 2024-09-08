using System.Text.Json;

namespace FmgLib.MauiMarkup;

public static class JsonLocalizationExtensions
{
    public static void LoadLocalizationData(this string jsonContent)
    {
        var localizationData = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, string>>>(jsonContent);

        if (localizationData == null)
        {
            throw new Exception("JSON content is empty.");
        }

        LocalizationData.Data = localizationData;
    }

    public static async Task LoadLocalizationDataAsync(params string[] filePaths)
    {
        var allData = new Dictionary<string, Dictionary<string, string>>();

        try
        {
            List<string> pathesList = filePaths.ToList();

            if (pathesList.Count == 0)
                pathesList.Add("Localization.json");

            foreach (var filePath in pathesList)
            {
                using var stream = FileSystem.Current.OpenAppPackageFileAsync(filePath).Result;
                using var reader = new StreamReader(stream);
                var json = reader.ReadToEnd();
                var data = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, string>>>(json);

                if (data != null)
                    foreach (var entry in data)
                    {
                        if (allData.ContainsKey(entry.Key))
                            foreach (var lang in entry.Value)
                                allData[entry.Key][lang.Key] = lang.Value;
                        else
                            allData[entry.Key] = new Dictionary<string, string>(entry.Value);
                    }
            }

            LocalizationData.Data = allData;
        }
        catch (Exception ex)
        {
            throw new FileLoadException($"There is an error in your language file.\n{ex.Message} \n\n\n\n The proper json format is:\n \"{{\\n  \\\"wordKey\\\": {{\\n    \\\"langKey1\\\": \\\"1st language translation.\\\",\\n    \\\"langKey2\\\": \\\"2nd language translation.\\\"\\n  }},\\n  \\\"wordKey2\\\": {{\\n    \\\"langKey1\\\": \\\"1st language translation.\\\",\\n    \\\"langKey2\\\": \\\"2nd language translation.\\\"\\n  }}\\n}}\"");
        }
    }


    public static string GetTranslation(this Dictionary<string, Dictionary<string, string>> data, string key, string languageCode)
    {
        if (data != null && data.TryGetValue(key, out var translations) && translations.TryGetValue(languageCode, out var translation))
        {
            return translation;
        }

        return key;
    }
}

