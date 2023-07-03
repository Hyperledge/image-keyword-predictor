using System;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using ImageTagger.UI.Service;
using ImageTagger.UI.Views.MainWindow;

namespace ImageTagger.UI;

/// <summary>
///     App is the entry point of the application.
/// </summary>
public class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        // Gather the services.
        var fileDialogService = new FileDialogService();
        var modelInferenceService = new ModelInferenceService();

        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            if (desktop.Args?.Length > 0)
          