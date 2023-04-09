using System.Reflection;

namespace ImageTagger.Core.Tests;

public class ModelPredictionTests
{
    private readonly ModelPrediction _modelPrediction;
    private readonly string _testArchitectureImagePath;

    public ModelPredictionTests()
    {
        var assemblyBasePath = Assembly.GetExecutingAssembly().Location;
        var assemblyPath = Path.GetDirectoryName(assemblyBasePath);

        _testArchitectureImagePath = Path.Join(assemblyPath, "resources", "test-image.jpg");
        _modelPrediction = new ModelPrediction(
            Path.Join(assemblyPath, "AIModels", "resnet50.onnx"),
            Path.Join(assemblyPath, "AIModels", "resnet50_categories.txt")
        );
    }

    [Fact]
    public void Test_PredictTags_Archi