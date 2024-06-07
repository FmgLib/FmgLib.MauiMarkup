namespace MyFinance.Utilities;

public static class PathDB
{
    public static string GetPath(string nameDb)
    {
        string pathSqliteDb = string.Empty;

        if (DeviceInfo.Platform == DevicePlatform.Android)
        {
            pathSqliteDb = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            pathSqliteDb = Path.Combine(pathSqliteDb, nameDb);
        }
        else if (DeviceInfo.Platform == DevicePlatform.iOS)
        {
            pathSqliteDb = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            pathSqliteDb = Path.Combine(pathSqliteDb, "..", "Library", nameDb);
        }

        return pathSqliteDb;
    }
}
