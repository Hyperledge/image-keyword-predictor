
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Logging;
using Avalonia.Threading;
using ImageTagger.UI.Controls;
using ImageTagger.UI.Service;
using ImageTagger.UI.ViewModels;
using SixLabors.ImageSharp;

namespace ImageTagger.UI.Views.MainWindow;

/// <summary>
///     The MainWindow class is the main window of the application.
/// </summary>
public partial class MainWindow : Window
{
    private readonly IFileDialogService _fileDialogService;

    private readonly StackPanel _imagePredictionStackPanel;
    private readonly IModelInferenceService _modelInferenceService;
    private readonly Mutex _predictImagesMutex;
    private readonly PredictionStats _predictionStats;
    private readonly TextBlock _predictionStatsTextBlock;
    private readonly ProgressBar _progressBar;

    /// <summary>
    ///     Constructs a new instance of MainWindow.
    ///     <param name="fileDialogService">An instance of <see cref="IFileDialogService" />.</param>
    ///     <param name="modelInferenceService">An instance of <see cref="ModelInferenceService" />.</param>