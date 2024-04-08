
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
    /// </summary>
    public MainWindow(IFileDialogService fileDialogService, IModelInferenceService modelInferenceService)
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel(this);

        _imagePredictionStackPanel = this.FindControl<StackPanel>("MainStackPanel") ??
                                     throw new ApplicationException("MainStackPanel could not be found");
        _progressBar = this.FindControl<ProgressBar>("ProgressBar") ??
                       throw new ApplicationException("ProgressBar could not be found!");
        _predictionStatsTextBlock = this.FindControl<TextBlock>("PredictedFilesTextBlock") ??
                                    throw new ApplicationException("PredictedFilesTextBlock not found!");

        _predictionStats = new PredictionStats();
        _modelInferenceService = modelInferenceService;
        _fileDialogService = fileDialogService;
        _predictImagesMutex = new Mutex();
    }

    /// <summary>
    ///     Constructs a new instance of MainWindow with the given image files.
    /// </summary>
    /// <param name="fileDialogService">An instance of <see cref="IFileDialogService" />.</param>
    /// <param name="modelInferenceService">An instance of <see cref="ModelInferenceService" />.</param>
    /// <param name="imageFiles">The image files paths.</param>
    public MainWindow(IFileDialogService fileDialogService, IModelInferenceService modelInferenceService,
        IEnumerable<string> imageFiles) : this(fileDialogService, modelInferenceService)
    {
        var imageFilesArray = imageFiles.ToArray();
        var file = imageFilesArray[0];
        if (imageFilesArray.Length == 1 && Directory.Exists(file))
        {
            var filesInDirectory = Directory.GetFiles(imageFilesArray[0]);
            Task.Run(async () => { await PredictTagsForFiles(filesInDirectory); });
        }
        else
        {
            Task.Run(async () => { await PredictTagsForFiles(imageFilesArray); });
        }
    }

    /// <summary>
    ///     Predicts the tags for the given image files.
    /// </summary>
    /// <param name="files">The image file paths.</param>
    /// <throws><see cref="ArgumentNullException" /> if <paramref name="files" /> is null.</throws>
    private Task PredictTagsForFiles(IEnumerable<string> files)
    {
        var result = _predictImagesMutex.WaitOne(1000);
        if (!result)
        {