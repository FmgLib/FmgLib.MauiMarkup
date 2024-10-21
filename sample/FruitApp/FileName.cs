[assembly: System.Reflection.Metadata.MetadataUpdateHandler(typeof(FmgLib.MauiMarkup.FmgLibHotReloadHandler))]
namespace FmgLib.MauiMarkup;

public static class FmgLibHotReloadHandler
{
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
    public static event Action<Type[]?>? UpdateApplicationEvent;
#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.

    public static void ClearCache(Type[]? types) { }

    public static void UpdateApplication(Type[]? types)
    {
        UpdateApplicationEvent?.Invoke(types);
    }

    public static void InvokeBuildIfExists(object page)
    {
        var buildMethod = page.GetType().GetMethod("Build");
        if (buildMethod != null)
        {
            buildMethod.Invoke(page, null);
        }
    }
}