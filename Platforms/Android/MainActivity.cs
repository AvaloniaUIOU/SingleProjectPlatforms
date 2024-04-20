using Android.App;
using Android.Content.PM;
using Avalonia;
using Avalonia.Android;
using AvaloniaUI.Xpf;
using AvaloniaUI.Xpf.Helpers;

namespace ProjectName;

[Activity(Label = "ProjectName", Theme = "@style/Theme.AppCompat", MainLauncher = true, ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize)]
public class MainActivity : AvaloniaMainActivity<DefaultXpfAvaloniaApplication>
{
    protected override AppBuilder CustomizeAppBuilder(AppBuilder builder)
    {
        return base.CustomizeAppBuilder(builder)
            .WithAvaloniaXpf()
            .AfterSetup(_ => App.Start());
    }
}
