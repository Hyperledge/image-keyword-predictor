using Microsoft.ML.OnnxRuntime;

namespace ImageTagger.Core;

/// <summary>
///     ModelPrediction class is used to predict tags for given images.
/// </summary>
public class ModelPrediction
{
    /// <summary>
    ///     The <see cref="ImageProcessor" /> instance.
    /// </summary>
    private readonly ImageProcessor _imageProcessor;

    /// <summary>
    ///     The ONNX <see cref="InferenceSession" /> instance.
    /// </summary>
    private readonly InferenceSession _inferenceSession;

    /// <summary>
    ///     The LabelsRegistry instance.