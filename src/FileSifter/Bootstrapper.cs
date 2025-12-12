using FileSifter.Infrastructure.Settings;
<<<<<<<< HEAD:src/FileSifter/Presentation/App/Bootstrapper.cs

namespace FileSifter.Presentation.App;
========
using System.IO;
namespace FileSifter;
>>>>>>>> レイヤード構成への全面リファクタリング:src/FileSifter/Bootstrapper.cs

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