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
    ///     Given an image it applies necessary transformations and returns a tensor.
    /// </summary>
    /// <param name="image">The image object.</param>
    /// <returns>The DenseTensor of dimension {1, 3, 224, 224}</returns>
    private Tensor<float> ImageToTensor(Image<Rgb24> image)
    {
        Tensor<float> outputTensor = new DenseTensor<float>(new[] { 1, 3