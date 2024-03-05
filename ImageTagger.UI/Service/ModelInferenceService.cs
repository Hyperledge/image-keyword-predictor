using System.IO;
using System.Linq;
using System.Reflection;
using ImageTagger.Core;

namespace ImageTagger.UI.Service;

/// <summary>
///     ModelInference class is used to predict tags for given images.
/// </summary>
public class ModelInferenceService : IModelInferenceService
{
    private const string TaggingModelCategoriesPath = "AIModels/prediction_categories.txt";
    private const string TaggingModelPath = "AIModels/prediction.onnx";
    private readonly ModelPrediction _modelPrediction;

    /// <summary>
    ///     Constructs a new instance of ModelInference.
    /// </summary>
    public ModelInferenceService()
    {
        // Get assembly base path
        var assemblyBasePath = Assembly.GetExecutingAssembly().Location;
        var assemblyPath = Path.GetDirectoryName(assemblyBasePath);
        // Create model prediction instance
        _modelPrediction = n