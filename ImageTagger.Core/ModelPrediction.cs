﻿using Microsoft.ML.OnnxRuntime;

namespace ImageTagger.Core;

/// <summary>
///     ModelPrediction class is used to predict tags for given images.
/// </summary>
public class ModelPrediction
{
    /// <summary>
    ///     The <see cref="ImageProcessor" /> instance.
    /// </summary>
    private readonly Image