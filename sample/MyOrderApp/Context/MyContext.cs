using LiteDB;

namespace MyOrderApp.Context;

public class MyContext
{
    private static LiteDatabase _db;

    public LiteDatabase GetLiteDB()
    {
        var path = FileSystem.AppDataDirectory;
        var fullPath = Path.Combine(path, "MyOrderApp.db");
        _db = new LiteDatabase(fullPath);

        return _db;
    }

    public void DbDispose() => _db.Dispose();

    private string GetConnectionString()
    {
        var path = FileSystem.AppDataDirectory;
        var fullPath = Path.Combine(path, "MyOrderApp.db");
        var password = GetPassword("MyOrderAppPassKey").GetAwaiter().GetResult();

        return $"Filename={fullPath};Password={password}";
    }

    private async Task<string> GetPassword(string key)
    {
        var password = await SecureStorage.Default.GetAsync(key);
        if (password == null)
        {
            password = "MyOrderAppPass";
            await SecureStorage.Default.SetAsync(key, password);
        }

        return password;
    }
}
