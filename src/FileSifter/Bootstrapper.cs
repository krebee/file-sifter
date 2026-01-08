using FileSifter.Infrastructure.Settings;
using System;
using System.IO;

namespace FileSifter;

public static class Bootstrapper
{
    public static SettingsService InitializeSettings()
    {
        var appData = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "FileSifter");
        Directory.CreateDirectory(appData);
        var settingsPath = Path.Combine(appData, "settings.json");
        var svc = new SettingsService(settingsPath);
        svc.Load();
        return svc;
    }
}