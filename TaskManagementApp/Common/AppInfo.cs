namespace TaskManagementApp.Common;

public class AppInfo
{
    public static string Title { get; set; } = string.Empty;
    public static string Version { get; set; } = string.Empty;
    public static string Description { get; set; } = string.Empty;


    public static void Load(IConfiguration configuration)
    {
        Title = configuration["AppInfo:Title"]!;
        Version = configuration["AppInfo:Version"]!;
        Description = configuration["AppInfo:Description"]!;
    }
}
