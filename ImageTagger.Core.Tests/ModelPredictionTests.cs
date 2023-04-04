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

        _testArchitectureImagePath = Path.Join(assemblyPath, "resources", "test-image.jpg"