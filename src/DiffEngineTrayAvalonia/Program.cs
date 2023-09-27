using System;
using System.Threading;
using Avalonia;
using Avalonia.Controls;
using Avalonia.ReactiveUI;

namespace DiffEngineTray;

class Program
{
   [STAThread]
    public static void Main() =>
        Inner();

    static void Inner()
    {
        using var mutex = new Mutex(true, "DiffEngine", out var createdNew);
        if (!createdNew)
        {
            //Log.Information("Mutex already exists. Exiting.");
            return;
        }
        BuildAvaloniaApp().StartWithClassicDesktopLifetime(Array.Empty<string>(), ShutdownMode.OnExplicitShutdown);
    }

    // Avalonia configuration, don't remove; also used by visual designer.
    public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<App>()
            .UsePlatformDetect()
            .WithInterFont()
            .LogToTrace()
            .UseReactiveUI();
}
