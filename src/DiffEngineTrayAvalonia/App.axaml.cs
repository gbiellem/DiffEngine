using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using DiffEngineTray.ViewModels;
using DiffEngineTray.Views;
using ReactiveUI;

// ReSharper disable UnusedParameter.Local

namespace DiffEngineTray;

public class App : Application
{
    TrayIcon? Tray { get; set; }

    public override void Initialize() =>
        AvaloniaXamlLoader.Load(this);

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is ISingleViewApplicationLifetime singleViewPlatform)
        {
            singleViewPlatform.MainView = new OptionsView
            {
                DataContext = new OptionsViewModel()
            };
        }

        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime)
        {
           Tray = new()
            {
                IsVisible = true,
                ToolTipText = "DiffEngineTray Avalonia Port",
                Icon = Images.Default,
                Command = ReactiveCommand.Create(ShowOptionsWindow),
                Menu = new()
                {
                    new NativeMenuItem
                    {
                        Header = "Exit",
                        Icon = Images.Exit,
                        Command = ReactiveCommand.Create(Shutdown)
                    },
                    new NativeMenuItem
                    {
                        Header = "Options",
                        Icon = Images.Options,
                        Command = ReactiveCommand.Create(ShowOptionsWindow)
                    },
                    new NativeMenuItem
                    {
                        Header = "Open logs",
                        Icon = Images.Folder
                    },
                    new NativeMenuItem
                    {
                        Header = "Raise issue",
                        Icon = Images.Link
                    }
                }
            };
        }

        base.OnFrameworkInitializationCompleted();
    }

    void Shutdown()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.Shutdown();
        }
    }

    void ShowOptionsWindow()
    {
        if (ApplicationLifetime is not IClassicDesktopStyleApplicationLifetime desktop)
        {
            return;
        }

        desktop.MainWindow ??= new OptionsWindow
        {
            DataContext = new OptionsViewModel()
        };
        desktop.MainWindow.Show();
        var x = desktop.MainWindow.TryGetPlatformHandle();
        ApiHelpers.BringWindowToTop(x!.Handle);
    }
}
