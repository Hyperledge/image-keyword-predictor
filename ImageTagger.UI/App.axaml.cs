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
