using Microsoft.ML.OnnxRuntime.Tensors;

namespace ImageTagger.Core;

/// <summary>
///     ImageProcessor is a class for processing images.
/// </summary>
public class ImageProcessor
{
    private readonly float[] _mean = { 0.485f, 0.456f, 0.406f };
    private readonly float[] _standardDeviation = { 0.229f, 0.224f, 0.225f };


    /// <summary>
    ///     Given an image it applies ne