namespace TaskManagementApp.Common;

public class AppInfo
{
    public static string Title { get; private set; } = string.Empty;
    public static string Version { get; private set; } = string.Empty;
    public static string Description { get; private set; } = string.Empty;


    public static void Load(IConfiguration configuration)
    {
        Title = configuration["AppInfo:Title"] ?? "Title not loaded.";
        Version = configuration["AppInfo:Version"] ?? "Version not loaded.";
        Description = configuration["AppInfo:Description"] ?? "Description not loaded.";
    }
}
