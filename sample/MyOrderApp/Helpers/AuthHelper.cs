using System.Text;

namespace MyOrderApp.Helpers;

public static class AuthHelper
{
    public static string BasicAuth(string username, string password)
    {
        string credentials = $"{username}:{password}";
        byte[] credentialsBytes = Encoding.UTF8.GetBytes(credentials);
        string base64Credentials = Convert.ToBase64String(credentialsBytes);

        return base64Credentials;
    }

    public static (string, string) ParseBasicAuthToken(string authKey)
    {
        if (authKey == null)
            throw new ArgumentNullException(nameof(authKey));

        byte[] bytes = Convert.FromBase64String(authKey);
        string credentials = Encoding.UTF8.GetString(bytes);
        var userInfo = credentials.Split(':', 2);

        return (userInfo[0], userInfo[1]);
    }
}
